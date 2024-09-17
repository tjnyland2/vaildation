using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vaildation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your date of birth");
            string myBirthday = Console.ReadLine();
            do
            { 
                try
                {
                    DateTime TheTimeNow = DateTime.Now;
                    DateTime myBirth = DateTime.Parse(myBirthday);
                    if (myBirth < TheTimeNow)
                    {
                        Console.WriteLine("Vaid birthday");
                        Console.ReadLine();
                    }
                    else if (myBirth > TheTimeNow)
                    {
                        Console.WriteLine("Invaid birthday");
                        Console.ReadLine();
                    }
                }
                catch
                {
                    Console.WriteLine("This is not a correct DoB!");
                    Console.ReadLine();

                }
            }
            while (0 == 0);
        }
    }
}
