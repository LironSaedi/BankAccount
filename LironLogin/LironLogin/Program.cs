using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LironLogin
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Bank bank = new Bank();
            bool Continue = false;
            do
            {
                bank.Menu();
                Console.WriteLine("Would You Like to continue doing stuff. if You would press 1 if you would not press 2 ");
                int reader = int.Parse(Console.ReadLine());
                if (reader ==  1)
                {
                    Continue = true;

                }
                if (reader == 2)
                {
                    Continue = false;
                }
                //ask them if they want to continue doing stuff
                //read their input
                //if they said yes, then set continue to true
                //if not, set it false
            } while (Continue);
            
            
            
            //Make Bank object
            
            //bank.login(user info)
            //while user is logged in (aka they do not select exit)
            //bank.Menu()


            Console.WriteLine("Goodbye!");
            Console.ReadKey();
        }
    }

}
