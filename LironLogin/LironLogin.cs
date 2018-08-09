using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LironLogin
{
    class Bank
    {

        List<Account> accounts = new List<Account>();
        Account loggedInAccount;


        public Bank()
        {
            //add default accounts
            accounts.Add(new Account("jeff", "jeffy"));
            accounts.Add(new Account("Kenny", "1231"));
            accounts.Add(new Account("super", "Mario"));
            accounts.Add(new Account("apple", "banana"));
            accounts.Add(new Account("pop", "corn"));
        }

        public bool Login()
        {
            Console.WriteLine("Please enter a username");
            string tempUser = Console.ReadLine();
            Console.WriteLine("Then enter a password");
            string tempPass = Console.ReadLine();

            bool checkerUser = false;
            for (int i = 0; i < accounts.Count; i++)
            {
                if (accounts[i].CheckLogin(tempUser, tempPass))
                {
                    Console.WriteLine("You Logged In");
                    loggedInAccount = accounts[i];
                    checkerUser = true;
                    Console.WriteLine("Would You Like To Create A Username If you do the press : 1 | IF you would like to withDrawl then press 2  | If you would like to add to your account them press 3");
                    int userinput = int.Parse(Console.ReadLine());
                    if (userinput == 1)
                    {
                        AddUser();
                    }
                    if (userinput == 2)
                    {
                        //ask for how much to withdrawl
                        int amount = 0;
                        Console.WriteLine("Please Enter An Anmount That You Would LIke TO WIth Drawl");
                        amount = int.Parse(Console.ReadLine());
                        Console.WriteLine($"")
                        loggedInAccount.Withdrawl(amount);
                        
                    }
                    if (userinput == 3)
                    {
                        int amount = 0;
                        Console.WriteLine("Please Enter The Amount That You WOuld lIke to deposti");
                        amount = int.Parse(Console.ReadLine());
                        loggedInAccount.Deposit(amount);
                    }
                  
                    return true;
                }
            }


            if (checkerUser == true)
            {
                //Console.WriteLine("Would You Like To Create A Username If you do the press : 1 | IF you would like to withDrawl then press 2  | If you would like to add to your account them press 3| if You want to log out and exit the press : 4");
                //int userinput = int.Parse(Console.ReadLine());
                //if (userinput == 1)
                //{
                //    AddUser();
                //}
                //if (userinput == 2)
                //{
                //    //ask for how much to withdrawl
                //    int amount = 0;
                //    Console.WriteLine("Please Enter An Anmount That You Would LIke TO WIth Drawl");
                //    amount = int.Parse(Console.ReadLine());
                //    loggedInAccount.Withdrawl(amount);
                //}
                //if(userinput == 3)
                //{
                //    int amount = 0;
                //    Console.WriteLine("Please Enter The Amount That You WOuld lIke to deposti");
                //    amount = int.Parse(Console.ReadLine());
                //    loggedInAccount.Deposit(amount);
                //}
                //if (userinput == 4 )   
                //{
                //    return false;
                //}

                return true;

            }

            if (checkerUser == false)
            {
                Console.WriteLine("You Did Not Succesfully Log In");
            }
            return false;
        }

        public bool AddUser()
        {
            Console.WriteLine("Please Enter A Username That You Would Like To Create");
            string username = Console.ReadLine();
            for (int i = 0; i < accounts.Count; i++)
            {
                if (accounts[i].Username == username)
                {

                    Console.WriteLine("This username is already taken");
                    
                    //username already taken
                    return false;
                }
            }
            Console.WriteLine("Then Enter A PassWord That You Would Like To Create");
            string password = Console.ReadLine();


            

            accounts.Add(new Account($"{username}", $"{password}"));

            //check if the username already exists (return false)
            //add user to list of users (return true)
            return true;
        }
        // accounts
        // (I have a constructor ( it is named bank) ) constructor 
        // (finsihed)login
        // add user
        // Menu

        public void Menu()
        {
            Console.WriteLine("To Login Press : 1 | To Exit Press 2");
            int userInput = int.Parse(Console.ReadLine());
            if (userInput == 1)
            {
                Login();
                
            }
            if (userInput == 2)
            {
                return;
            }
            //print menu
            //read user input
            //call appropriate functions
        }

    }
}
