using System;
using Models;
namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Notebook notebook = new Notebook();
            notebook.Name = "Lenove";
            notebook.No = 5;
            notebook.Price = 1000;
            notebook.RAM = 8;
            notebook.Storage = 16;
            


            Notebook notebook1 = new Notebook();
            notebook1.Name = "HP";
            notebook1.No = 10;
            notebook1.Price = 1200;
            notebook1.RAM = 16;
            notebook1.Storage = 32;

            Phone phone = new Phone();
            phone.Name = "Iphone";
            phone.No = 3;
            phone.Price = 1200;


            Store store = new Store();
            store.NotebookLimit = 5;
            store.PhoneLimit = 10;
            store.AddProduct(notebook);
            store.AddProduct(notebook1);
            store.AddProduct(phone);
         


            Console.WriteLine("-------");
            Console.WriteLine(store.products.Length);

            Console.WriteLine("---Notebook ortalamasi ---");
            Console.WriteLine(store.CalcNoteBookAvg());

            Console.WriteLine("---CalcPhoneAvg ortalamasi ---");
            Console.WriteLine(store.CalcPhoneAvg()); 

        }
    }
}
