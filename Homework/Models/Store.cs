using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Store
    {
        public Product[] products = new Product[0];

        public int NotebookLimit { get; set; }
        public int PhoneLimit { get; set; }

        public void AddProduct(Product product)
        {
            int count = 0;
            foreach (var item in products)
            {

                if (item is Notebook)
                {

                    count++;
                }

            }
            if (NotebookLimit > count)
            {
                Array.Resize(ref products, products.Length + 1);
                products[products.Length - 1] = product;
            }


            int countP = 0;
            foreach (var item in products)
            {
                if (item is Phone)
                {
                    countP++;
                }
            }
            if (PhoneLimit > countP)
            {
                Array.Resize(ref products, products.Length + 1);
                products[products.Length - 1] = product;
            }

        }
    
    
         public void FindByNo(int no)
         {

            foreach (var item in products)
            {
                if (item.No==no)
                {
                    Console.WriteLine($"{item.Name}  {item.Price} {item.No} ");
                }
            }
        }

        public double CalcNoteBookAvg(){


            int count = 0;
            double sum = 0;
            double avg = 0;
            foreach (var item in products)
            {
                if (item is Notebook)
                {
                    count++;
                    sum += item.Price;
                }
            }
            if (count>0)
            {
                avg  =sum / count;
            }
            return avg;

        }
        public double CalcPhoneAvg()
        {
            int count = 0;
            double sum = 0;
            double avg = 0;
            foreach (var item in products)
            {
                if (item is Phone)
                {
                    count++;
                    sum += item.Price;
                }
            }
            if (count > 0)
            {
                avg = sum / count;
            }
            return avg;

        }

    }
}
