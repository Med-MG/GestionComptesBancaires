using System;
using System.Collections.Generic;
using System.Text;

namespace GestionComptesBancaires
{
    class Bank
    {
        static bool quiteProgram = false;
        static List<CompteSurCarnet> CarnetAccounts = new List<CompteSurCarnet>() { new CompteSurCarnet("12", "Mohamed Mouiguina", 23000) };
        static List<CompteSurCheque> ChequeAccounts = new List<CompteSurCheque>() { new CompteSurCheque("14", "Mohamed Mouiguina", 45000) };

        public int SearchAccount(String Num)
        {
            var AccountCarnet = CarnetAccounts.FindAll(x => x.AccountNumber.Contains(Num));
            var AccountCheque = CarnetAccounts.FindAll(x => x.AccountNumber.Contains(Num));


            if(AccountCarnet.Count > 0)
            {
                AccountCarnet[0].DisplayInfo();
                return 2; //We know that this account is carnet so we return 2
            }
            if(AccountCheque.Count > 0)
            {
                AccountCheque[0].DisplayInfo();
                return 1; //We know that this account is cheque so we return 1

            }
            return -1;


        }

        public int CreateBankAccount (String HolderName, int AccountType, double Balance)
        {
            if(AccountType == 1)
            {
                ChequeAccounts.Add(new CompteSurCheque(HolderName, Balance));
                Console.WriteLine("Your Account Has been created, Here's your accounts information:\r\n");
                int Index = ChequeAccounts.Count - 1;
                ChequeAccounts[Index].DisplayInfo();
                //Block saperator
                Console.WriteLine("\r\n______________________________________\r\n");
                return Index;
            }
            else if(AccountType == 2)
            {
                CarnetAccounts.Add(new CompteSurCarnet(HolderName, Balance));
                Console.WriteLine("Your Account Has been created, Here's your accounts information:\r\n");
                int Index = CarnetAccounts.Count - 1;
                CarnetAccounts[CarnetAccounts.Count - 1].DisplayInfo();
                //Block saperator
                Console.WriteLine("\r\n______________________________________\r\n");
                return Index;
            }
            return -1;
        }

        public void ManageAccount(int AccountType, int index)
        {
            while (quiteProgram == false)
            {
                if (AccountType == 1)
                {
                    
                    ChequeAccounts[index].ManageAccount(AccountType, index);
                }
                else if (AccountType == 2)
                {
                    CarnetAccounts[index].ManageAccount(AccountType, index);
                }

                Console.WriteLine("Press Q to (quite) or (Enter) to continue");
                if (Console.ReadKey().Key == ConsoleKey.Q)
                {
                    quiteProgram = true;
                }
            }
        }

        internal static void DeleteAccount(int accountType, int index)
        {
            if (accountType == 1)
            {
                ChequeAccounts.RemoveAt(index);
                Console.WriteLine("\nYour account is deleted");

            }
            else if (accountType == 2)
            {
                CarnetAccounts.RemoveAt(index);
                
                Console.WriteLine("\nYour account is deleted");


            }
        }
    }
}
