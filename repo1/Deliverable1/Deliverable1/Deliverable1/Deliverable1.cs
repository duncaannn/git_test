using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Deliverable1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Create Password.");

            string justType = Console.ReadLine();

            bool valid = false;

            while (!valid)
            {

                if ((justType.Length > 7 && justType.Length < 12)
                    && justType.Any(char.IsUpper) && justType.Any(char.IsLower)
                    && justType.Contains("!"))

                {
                    valid = true;
                        Console.WriteLine("Password valid and accepted.");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Error.");
                    Console.WriteLine("Create Password.");

                    justType = Console.ReadLine();
                }
                }
            }
        }
    }

