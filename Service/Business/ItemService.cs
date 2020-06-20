using AutoMapper;
using Core.Domain;
using Core.Domain.ViewModels;
using Core.Domain.ViewModels.ItemType;
using Core.Repository;
using Core.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Business
{
    public class ItemService : IService<Item, Item>
    {
        public readonly IUOW UOW;
        public readonly IMapper mapper;
        public readonly IRequestResult RS;
        public ItemService(IUOW uow_, IRequestResult rs, IMapper mapper_)
        {
            UOW = uow_;
            mapper = mapper_;
            RS = rs;
        }
        public IRequestResult Create(Item model)
        {
            UOW.Items.Add(model);
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
    }
}
