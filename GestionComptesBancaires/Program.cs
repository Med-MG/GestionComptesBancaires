using System;

namespace GestionComptesBancaires
{
    class Program
    {
        
        private static byte AccountToUse;
        private static byte quiteProgram = 0;
        static void Main(string[] args)
        {
            Run();
        }

        public static void Run()
        {
            /**
             * Give the user the following choices
             * (0) Give the user a chance to create an account
             * (1) choose which account your want to use
             * (2) Display your accounts information 
             * (3) Withraw money from your account
             * (4) Deposit money in your account
             */

            //Create an account
            CreateAccount();



        }

        private static void CreateAccount()
        {
            Console.WriteLine("Welcome Are you ready to create an account:\r\n");
            Console.WriteLine("What is your name :");
            String HolderName = Console.ReadLine();
            Console.WriteLine("How much would you like to deposit in your cheque account:");
            double depositChaque = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("How much would you like to deposit in your Carnet account:");
            double depositCarnet = Convert.ToDouble(Console.ReadLine());

            CompteSurCheque cptCheque = new CompteSurCheque(HolderName, depositChaque);
            CompteSurCarnet cptCarnet = new CompteSurCarnet(HolderName, depositCarnet);

            Console.WriteLine("Your Account Has been created, Here's your accounts information:\r\n");

            cptCarnet.DisplayInfo();
            //Block saperator
            Console.WriteLine("\r\n______________________________________\r\n");
            cptCheque.DisplayInfo();
            //Block saperator
            Console.WriteLine("\r\n______________________________________\r\n");

            while (quiteProgram == 0)
            {

                Console.WriteLine("choose which account your want to use : \r\n (1) CompteSurCheque \r\n (2) CompteSurCarnet");
            AccountToUse = Convert.ToByte(Console.ReadLine());

            if (AccountToUse == 1)
            {
                cptCheque.ManageAccount();
            }
            else if (AccountToUse == 2)
            {
                cptCarnet.ManageAccount();
            }
                Console.WriteLine("Press Q to (quite) or (Enter) to continue");
                if (Console.ReadKey().Key == ConsoleKey.Q)
                {
                    quiteProgram = 1;
                }
                else
                {
                    quiteProgram = 0;
                }
            }
        }

    }
}
