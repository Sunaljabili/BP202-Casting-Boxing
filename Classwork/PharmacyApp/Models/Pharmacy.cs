using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
   public class Pharmacy
    {

        private int _Id;
        public static int UnikalId { get; set; }
        public Pharmacy()
        {
            _Id++;
            UnikalId = _Id;
        }
        public string Name { get; set; }

        public Drug[] drugs = new Drug[0];

        public override string ToString()
        {
            return $"Id -{_Id}  Name - {Name}";
        }

        public void AddDrug(Drug drug)
        {

            Array.Resize(ref drugs, drugs.Length + 1);
            drugs[drugs.Length - 1] = drug;
        }

        public void DrugList()
        {
            foreach (var item in drugs)
            {
                Console.WriteLine(item);
            }
        }

        public void SaleDrug(string name, double money,double count)
        {
            bool check = false;
            int satishSayi = 0;
            foreach (var item in drugs)
            {
                if (item.Count>count)
                {
                    if (item.Price<=money)
                    {
                        if (item.Name.ToLower() ==name.ToLower())
                        {
                           
                            item.Count-=count;
                            check = true;
                            satishSayi++;
                        }
                        
                    }
                  
                }
                
            }
            Console.WriteLine($"{satishSayi} -defe satish bash verdi");
            if (!check)
            {
                Console.WriteLine("Satish bash vermir");
            }
        }
    }
}
