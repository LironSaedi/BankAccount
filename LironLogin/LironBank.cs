using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//YES CONSOLE
namespace LironLogin
{
    class Bank
    {

        List<Account> accounts;
        Account loggedInAccount;
 ;
 

        public Bank()
        {
            //add default accounts
            accounts.Add(new Account("jeff", "jeffy"));
            accounts.Add(new Account("Kenny", "1231"));
            accounts.Add(new Account("super", "Mario"));
            accounts.Add(new Account("apple", "banana"));
            accounts.Add(new Account("pop", "corn"));
        }

        public bool Login(Account account)
        {
             
            bool loggedIn = false;
            for (int i = 0; i < accounts.Count; i++)
            {
                if (accounts[i].CheckLogin(account.GetUser(), account.GetPassword()))
                {

                    loggedInAccount = accounts[i];
                    loggedIn = true;
                }
            }
        
            return loggedIn;

                    
                    //if (userinput == 1)
                    //{
                    //    AddUser();
                    //}
                    //if (userinput == 2)
                    //{

                    //    //ask for how much to withdrawl
                    //    int amount = 0;
                       
                        
                       
                    //    loggedInAccount.Withdrawl(amount);
                        
                    //}
                    //if (userinput == 3)
                    //{
                    //    int amount = 0;
                       
                    //    amount = int.Parse(Console.ReadLine());
                       
                    //    loggedInAccount.Deposit(amount);
                    //}
                  
                    //return true;
                }
            }


            //if (checkerUser == true)
            //{
            //    return true;

            //}

            //if (checkerUser == false)
            //{
            //    return false;
            //}
            //return false;
        }

        public bool AddUser()
        {
           
            for (int i = 0; i < accounts.Count; i++)
            {
                if (accounts[i].Username == username)
                {

                  
                    
                    //username already taken
                    return false;
                }
            }
           
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
