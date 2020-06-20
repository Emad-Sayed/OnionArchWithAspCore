using Core.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Repository
{
    public interface IAppDbContext
    {
         DbSet<ItemType> ItemTypes { get; set; }
         DbSet<Item> Items { get; set; }
    }
}
