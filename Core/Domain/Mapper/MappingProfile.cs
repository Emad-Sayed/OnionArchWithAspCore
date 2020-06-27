using AutoMapper;
using Core.Domain.ViewModels.Item;
using Core.Domain.ViewModels.ItemType;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Domain.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CreateItemType, ItemType>();
            CreateMap<ItemType, ItemTypeView>();
            CreateMap<CreateItem, Item>();
        }
    }
}
