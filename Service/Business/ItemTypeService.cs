using AutoMapper;
using Core.Domain;
using Core.Domain.ViewModels;
using Core.Domain.ViewModels.ItemType;
using Core.Repository;
using Core.Service;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Service.Business
{
    public class ItemTypeService : IService<ItemType, CreateItemType>
    {
        public readonly IUOW UOW;
        public readonly IMapper mapper;
        public readonly IRequestResult RS;
        public ItemTypeService(IUOW uow_, IRequestResult rs, IMapper mapper_)
        {
            UOW = uow_;
            mapper = mapper_;
            RS = rs;
        }
        public IRequestResult Create(CreateItemType model)
        {
            ItemType itemType = mapper.Map<ItemType>(model);
            UOW.ItemTypes.Add(itemType);
            UOW.Compelete();
            RS.data = model;
            return RS;
        }

        public IRequestResult GetAll()
        {
            var data = UOW.ItemTypes.GetAll().ToList();
            var result = mapper.Map<List<ItemTypeView>>(data);
            RS.data = result;
            return RS;
        }
    }
}
