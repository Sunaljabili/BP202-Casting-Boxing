using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
  public  class TypeDrug
    {
        private int _Id;
        public static int  UnikalId { get; set; }
        public string TypeName { get; set; }

        public TypeDrug()
        {
            _Id++;
            UnikalId = _Id;
        }

        public override string ToString()
        {
            return $"TypeName - {TypeName}";
        }


    }
}
