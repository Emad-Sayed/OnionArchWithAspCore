using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Domain
{
    public class BasEntity
    {
        public BasEntity()
        {
            this.CreatedAt = DateTime.Now;
        }
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
