using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReProductify.Domain.Entities
{
    public class Product
    {
        public Guid Id { get; set; }
        public String Name { get; set; }
        public DateTime CreatedOn { get; set; }


        public Product(string name) 
        { 
            Id = Guid.NewGuid();
            Name = name;
            CreatedOn = DateTime.Now;
        }



    }
}
