using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StorageAdministrator.Models
{
    public class Product
    {
        public int id;
        public string name;
        public Category category;
        public int price;
        public string description;
        public int amount;
    }
}
