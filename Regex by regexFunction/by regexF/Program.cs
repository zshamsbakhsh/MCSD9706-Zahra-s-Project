using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace by_regexF
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                //Console.Write("Pattern:");
                //var pattern = Console.ReadLine();
                //if (pattern == "exit")
                //    break;
                Regex re = new Regex(@"^[0-9][0-9][0-9][0-9][01][0-9][1-3][09]");
                while (true)
                {
                    Console.Write("Text:");
                    var text = Console.ReadLine();
                    if (text == "exit")
                        break;
                    var isMatch = re.IsMatch(text);
                    if (isMatch)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Match!");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Not Match!");
                    }
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }

        }
    
    }
}
