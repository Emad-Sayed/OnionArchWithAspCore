using AutoMapper;
using Core.Domain;
using Core.Domain.ViewModels;
using Core.Domain.ViewModels.Item;
using Core.Domain.ViewModels.ItemType;
using Core.Repository;
using Core.Service;
using Core.Service.HangFire;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Business
{
    public class ItemService : IService<Item, CreateItem>
    {
        public readonly IUOW UOW;
        public readonly IMapper mapper;
        public readonly IRequestResult RS;
        public readonly IItemSchedule scedule;
        public ItemService(IUOW uow_, IRequestResult rs, IMapper mapper_, IItemSchedule scedule_)
        {
            UOW = uow_;
            mapper = mapper_;
            RS = rs;
            scedule = scedule_;
        }
        public IRequestResult Create(CreateItem model)
        {
            Item item = mapper.Map<Item>(model);
            item.scheduleId=scedule.CreateExpirationSchedule(item);
            UOW.Items.Add(item);
            UOW.Compelete();
            RS.data = model;
            return RS;
        }

        public IRequestResult GetAll()
        {
            var result = UOW.Items.GetAll();
            RS.data = result;
            return RS;
        }
        public IRequestResult Delete(int id)
        {
            var selectedItem = UOW.Items.SingleOrDefault(i=>i.Id==id);
            scedule.DeleteExpirationSchedule(selectedItem.scheduleId);
            UOW.Items.Remove(selectedItem);
            UOW.Compelete();
            return RS;
        }
    }
}
