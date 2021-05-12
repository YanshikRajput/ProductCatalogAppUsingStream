using System;
using System.Collections.Generic;
using System.Text;
//using System.CsvHelper;

namespace Product_Library.Entites
{
    public class Product 
    {
        public   int Id { get; set; }
        public string Manufacturer { get; set; } = "";
        
       
        public int SellingPrice { get; set; } = 0;
        public string Name { get; set; }
        public string Description { get; set; }
        public static int Prod_Id;
        public Product()
        {
            Prod_Id = Prod_Id + 1;
            

        }


    }
}
