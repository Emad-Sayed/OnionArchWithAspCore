using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Domain.ViewModels.Item
{
    public class CreateItem
    {
        public string Name { get; set; }
        public float Price { get; set; }
        public DateTime ExpirationDate { get; set; }
        public int TypeId { get; set; }
    }
}
