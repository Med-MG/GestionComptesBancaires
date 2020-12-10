using System;

namespace GestionComptesBancaires
{
    class Program
    {
        private static byte choice;
        private static byte AccountToUse;
        static void Main(string[] args)
        {
            Run();
        }

        public static void Run()
        {
            /**
             * Give the user the following choices
             * (0) Give the user a chance to create an account
             * (1) Display your accounts information
             * (2) choose which account your want to use
             * (3) Withraw money from your account
             * (4) Diposit money in your account
             */

            CreateAccount();

            Console.WriteLine("choose which account your want to use : \r\n (1) CompteSurCheque \r\n (2) CompteSurCarnet");
            AccountToUse = Convert.ToByte(Console.ReadLine());

            if(AccountToUse == 1)
            {
                CompteSurCheque cptCheque = new CompteSurCheque();
                InputManager(cptCheque);
            } else if( AccountToUse == 2)
            {
                CompteSurCarnet cptCarnet = new CompteSurCarnet();
                InputManager(cptCarnet);
            }



           



        }

        private static void CreateAccount()
        {
            Console.WriteLine("Welcome Are you ready to create an account:\r\n");
            Console.WriteLine("What is your name :");
            String HolderName = Console.ReadLine();
            Console.WriteLine("How much would you like to deposit in your account:");
            double deposit = Convert.ToDouble(Console.ReadLine());

            CompteSurCheque cptCheque = new CompteSurCheque();
            CompteSurCarnet cptCarnet = new CompteSurCarnet();


        }

        public static void InputManager(Object obj)
        {

            //Display the choices for the User
            Console.WriteLine("Please Choose your next action: "
                + "\r\n (1) -> choose which account your want to use"
                + "\r\n (2) -> Display your accounts information "
                + "\r\n (3) -> Withraw money from your account"
                + "\r\n (4) -> Diposit money in your account");
            choice = Convert.ToByte(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    //Display Account Info method
                    obj.DisplayInfo();
                    break;
                default:
                    break;
            }
        }


    }
}
