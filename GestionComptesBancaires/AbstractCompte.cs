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
        private int accountNumber;

        public int AccountNumber
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
        public AbstractCompte(String Name, int AccountNum, double balance)
        {
            this.balance = balance;
            this.accountNumber = AccountNum;
            this.accountHolderName = Name;
        }

        public abstract bool Credit(double ammount);
        public abstract bool Debit(double ammount);
    }
}
