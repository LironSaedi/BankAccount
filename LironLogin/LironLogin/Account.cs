namespace LironLogin
{
    class Account
    {
        //NO CONSOLE
        public string Username;
        string password;
        double money;

        public Account(string username, string password)
        {
            this.Username = username;
            this.password = password;
            money = 100;
        }

        public bool CheckLogin(string username, string password)
        {
            if (this.Username == username && this.password == password)
            {
                return true;
            }
            return false;
        }
       
        public bool Deposit(int amount)
        {
            if (amount < 0)
            {
                return false;
            }
            money += amount;
            return true;
        }

        public bool Withdrawl(int amount)
        {
            //make sure account has enough money before withdrawling        
            if (amount > money)
            {
                return false;
            }
            else
            {
                money = money - amount;
            }
            return false;
        }
    

        /*
         * Console.WriteLine("You are in the deposit class; In this class you add and take away money. If You would like to Deposit money type in 'Deposit' if you would like to withdrawl money then type in withdrawal");
            string checker = Console.ReadLine();
            if (checker == "Deposit")
            {

                // add 

                Console.WriteLine("Please Enter How Much Money You Would Add To Your account");

                double addingMoney = int.Parse(Console.ReadLine());

                double totalAmount = addingMoney + money;



            }
            if (checker == "withdrawl")
            {


                Console.WriteLine($"Your Account Has {money} ");
                Console.WriteLine("Please Enter How Much Money You Would LIke to withDrawl");
                double withDrawlingMoney = int.Parse(Console.ReadLine());
                if (withDrawlingMoney > money)
                {
                    Console.WriteLine($"You Only have ${money} Please Enter An amount that you can withDrawl ");



                }
            }

            // this is where the withdrawal things go

         */
    }
}
