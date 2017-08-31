using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSim
{
    class Program
    {
        static void Main(string[] args)
        {
            //array of accounts
            //login program
            //when user logs in diplay menu

            //1) Deposit Money
            //2) Withdrawl Money
            //3) Exit (does not end program, goes back to login)

            Console.WriteLine("Please enter your username and password");
            string username = "Lironbillybobboo";
            int password = 1;
            username = Console.ReadLine();
            password = int.Parse(Console.ReadLine());
            if (username == "Lironbillybobboo" && password == 1)
            {
                Console.WriteLine("Login Complete");
            }


            else
            {
                Console.WriteLine("Login Failed");
            }


            //Console.WriteLine("); //displays words
            //string word = Console.ReadLine(); //reads what user types in
            //Console.WriteLine(word);


            Console.ReadKey();
        }
    }
}
