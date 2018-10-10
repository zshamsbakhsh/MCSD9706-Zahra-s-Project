using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace regex
{
    class Program
    {
        static void Main(string[] args)
        {


            while (true)
            {
                Console.WriteLine("Enter a Date in yyyymmdd format:");
                var date = Console.ReadLine();
                int[] Date = new int[8];
                for (int i = 0; i < date.Length; i++)
                {
                    Date[i] = date[i];
                }
                if (CheckDateRegEx(Date))
                {
                    Console.WriteLine("Valid");
                }
                
            else
                    Console.WriteLine("Invalid");
            }



          //  Console.ReadKey();
        }

        static bool CheckDateRegEx(int[] _date)
        
        {
            if ((_date[4] == 0 && _date[5] > 6) || ( _date[4] == 1 ))
            {
                if (_date[6] == 3 && _date[7] == 1)
                {
                    return false;
                }
                else
                    return true;
            }
            else
                return true;
        }



    }
}
