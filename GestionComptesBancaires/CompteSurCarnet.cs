using System;
using System.Collections.Generic;
using System.Text;

namespace GestionComptesBancaires
{
    class CompteSurCarnet : AbstractCompte
    {

        public int NumCarnet { get; set; }
        public CompteSurCarnet() : base()
        {
            //emty constructor
        }

        public CompteSurCarnet(String Name, double balance) : base(Name, balance)
        {
            this.NumCarnet = 1212;
        }

        //Display Account Info
        public override void DisplayInfo()
        {
            Console.WriteLine($"\r\nYour Account Cheque Information : \r\nAccount Holder : {this.AccountHolderName}\r\nAccount Number: {this.AccountNumber}\r\nCarnet Number: {this.NumCarnet}\r\nAccount Balance: {this.Balace}");
        }
        public override bool Credit(double ammount)
        {
            //amount to add to the balance
            this.Balace += ammount;
            Console.WriteLine("Your saving's account balance is now {0} dh", this.Balace);

            return true;
                 
        }

 

        public override bool Debit(double ammount)
        {
            //amount to be withdrawn from the account
            if(ammount > this.Balace)
            {
                throw new ArgumentException("Solde insuffisant");
            }else
            {
                this.Balace -= ammount;
                Console.WriteLine($"You have withdrawn {ammount} from your account, the remaining balance is {this.Balace}");
                return true;

            }
        }
    }
}
