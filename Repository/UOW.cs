using Core.Domain;
using Core.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class UOW : IUOW
    {
        AppDbContext context;
        public UOW(AppDbContext _context)
        {
            context = _context;
            ItemTypes = new Repository<ItemType>(_context);
            Items = new Repository<Item>(_context);
        }
        public IRepository<ItemType> ItemTypes { get; }
        public IRepository<Item> Items { get; }
        public void Compelete()
        {
            context.SaveChanges();
        }
    }
}
