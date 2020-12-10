using System;
using System.Collections.Generic;
using System.Text;

namespace GestionComptesBancaires
{
    abstract class AbstractCompte
    {

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

        Random random = new Random((int)DateTime.Now.Ticks);
        public AbstractCompte(String Name, double balance)
        {
            this.balance = balance;
            this.accountNumber = Convert.ToString(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
            this.accountHolderName = Name;

        }
        public abstract void DisplayInfo();
        public abstract bool Credit(double ammount);
        public abstract bool Debit(double ammount);
    }
}
