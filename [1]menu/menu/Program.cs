using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace menu
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstPage = new string[5];
               firstPage[0] = "1. Recipe List";
               firstPage[1] = "2. Add Recipe";
               firstPage[2] = "3. Edit";
               firstPage[3] = "4. Remove";
               firstPage[4] = "5. Exit";
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(firstPage[i]);
            }
            Console.WriteLine("------------------");
            Console.WriteLine("Select Item:");
            var Item = Console.ReadLine();
            Console.Clear();



            //switch (Item)
            //{
            //    case 1:


            //}
                    


            Console.ReadKey();
        }
    }
}
