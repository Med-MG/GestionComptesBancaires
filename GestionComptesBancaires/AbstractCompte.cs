using System;
using System.Collections.Generic;
using System.Text;

namespace GestionComptesBancaires
{
    abstract class AbstractCompte
    {
        public byte choice { get; set; }
        //Account holder proprety
        private String accountHolderName;

        public String AccountHolderName
        {
            get { return accountHolderName; }
            set { accountHolderName = value; }
        }

        //Account Number 
        private String accountNumber;

        public String AccountNumber
        {
            get { return accountNumber; }
            set { accountNumber = value; }
        }


        //Account Balance
        private double balance;

        public double Balace
        {
            get { return balance; }
            set { balance = value; }
        }

        public AbstractCompte()
        {
            //Empty constructor
        }

        public string GenerateNumber()
        {
            Random random = new Random();
            string r = "";
            int i;
            for (i = 1; i < 11; i++)
            {
                r += random.Next(0, 9).ToString();
            }
            return r;
        }

        Random random = new Random((int)DateTime.Now.Ticks);
        public AbstractCompte(String Name, double balance)
        {
            this.balance = balance;
            this.accountNumber = GenerateNumber();
            this.accountHolderName = Name;

        }

        public void ManageAccount() {

            

            //Display the choices for the User
            Console.WriteLine("Please Choose your next action: "
                + "\r\n (1) -> Display your accounts information "
                + "\r\n (2) -> Withdraw money from your account"
                + "\r\n (3) -> Diposit money in your account");
            this.choice = Convert.ToByte(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    //Display Account Info method
                    DisplayInfo();
                    break;
                case 2:
                    //Display Account Info method
                    Console.WriteLine("How much you want to withdraw");
                    double wAmmount = Convert.ToDouble(Console.ReadLine());
                    Debit(wAmmount);
                    break;
                case 3:
                    //Display Account Info method
                    Console.WriteLine("How much you want deposit");
                    double dAmmount = Convert.ToDouble(Console.ReadLine());
                    Credit(dAmmount);
                    break;
                default:
                    break;
            }
        }
        public abstract void DisplayInfo();
        public abstract bool Credit(double ammount);
        public abstract bool Debit(double ammount);
    }
}
