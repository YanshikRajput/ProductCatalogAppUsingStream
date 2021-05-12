using Product_Library;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductCatalogStreams.Entities
{
    public class MainMenu
    {
        public static void MainMenus()
        {
            Console.WriteLine("1.PRODUCTS");
            Console.WriteLine("2.ADD CATEGORIES");
            Console.WriteLine("3.EXIT!!");
            userinput();

        }

        public static void userinput()
        {
            int input = Convert.ToInt32(Console.ReadLine());
            if(input==1)
            {
                ProductMenu.productmenu();
            }
        }

    }
}
