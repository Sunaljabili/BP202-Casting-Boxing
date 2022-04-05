using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
  public  class Drug
    {
        private int _Id;
        public static int UnikalId { get; set; }
        public Drug()
        {
            UnikalId++;
            _Id = UnikalId;
        }
        public string Name { get; set; }

        public TypeDrug Type { get; set; }

        public double Price { get; set; }
        public double Count { get; set; }

        public override string ToString()
        {
            return $"Id - {_Id}  Name - {Name}  Price - {Price}  Count - {Count}";
        }

    }
}
