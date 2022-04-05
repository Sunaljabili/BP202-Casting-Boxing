using Models;
using System;

namespace PharmacyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            TypeDrug typeDrug = new TypeDrug();
            typeDrug.TypeName = "Agrikesici";

            TypeDrug typeDrug2 = new TypeDrug();
            typeDrug2.TypeName = "Vitamin";

            Drug drug = new Drug();
            drug.Name = "Valerian";
            drug.Count = 5;
            drug.Price = 1.2;
            drug.Type = typeDrug;


            Drug drug2 = new Drug();
            drug2.Name = "B12";
            drug2.Count = 10;
            drug2.Price = 2.2;
            drug2.Type = typeDrug;


            Drug drug3 = new Drug();
            drug3.Name = "Spazmaqon";
            drug3.Count = 7;
            drug3.Price = 3.2;
            drug3.Type = typeDrug2;
            Pharmacy pharmacy = new Pharmacy();
            pharmacy.Name = "Zeferan";

            pharmacy.AddDrug(drug);
            pharmacy.AddDrug(drug2);
            pharmacy.AddDrug(drug3);


            pharmacy.SaleDrug("Valerian", 3, 2);
            pharmacy.SaleDrug("B12", 6, 2);
            pharmacy.SaleDrug("Spazmaqon", 20, 5);


            //pharmacy.ToString();

            Console.WriteLine("=====DRUG LIST =====");
            pharmacy.DrugList();

        }
       
    }
}
