using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Domain
{
    public class Item : BasEntity
    {
        public string Name { get; set; }
        public float Price { get; set; }
        public int TypeId { get; set; }
        public ItemType Type { get; set; }
    }
}
