using System;

namespace GestionComptesBancaires
{
    class Program
    {
        
        //private static byte AccountToUse;

        static void Main(string[] args)
        {
            Run();
        }

        public static void Run()
        {
            /**
             * Give the user the following choices
             * (0) Ask the user if he has an account or he wants to create one 
             * (1) Give the user a chance to create an account
             * (2) choose which account your want to use
             * (3) Display your accounts information 
             * (4) Withraw money from your account
             * (5) Deposit money in your account
             */


            Bank bankAccount = new Bank();
            Console.WriteLine("Do you Have an Account with us ( press (y) for Yes / press (n) for No )");
            if (Console.ReadKey().Key == ConsoleKey.Y)
            {
                Console.WriteLine("\r\nWhat is your Account Number : ");
                int accounType = bankAccount.SearchAccount(Console.ReadLine());
                bankAccount.ManageAccount(accounType, 0);

                // prompt user to give his account's name
            }
            else
            {
                Console.WriteLine("\nWelcome Are you ready to create an account:\r\n");
                Console.WriteLine("What is your name :");
                String HolderName = Console.ReadLine();
                Console.WriteLine("Press (1) To create Account cheque or (2) to create Account carnet");
                int AccountType = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("How much would you like to deposit in your account:");
                double deposit = Convert.ToDouble(Console.ReadLine());
                //Create an account
                int accountIndex = bankAccount.CreateBankAccount(HolderName, AccountType, deposit);

                bankAccount.ManageAccount(AccountType, accountIndex);
            }

        }


   

    }
}
