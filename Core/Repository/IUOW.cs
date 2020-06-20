using Core.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Repository
{
    public interface IUOW 
    {
        IRepository<ItemType> ItemTypes { get; }
        IRepository<Item> Items { get; }
        void Compelete();
    }
}
