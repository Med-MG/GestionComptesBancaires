using System;
using System.Collections.Generic;
using System.Text;

namespace GestionComptesBancaires
{
    class CompteSurCarnet : AbstractCompte
    {

        public String NumCarnet { get; set; }
        public CompteSurCarnet() : base()
        {
            //emty constructor
        }
        /**
        * Constructor
        * @params Sring Name
        * @params Double balance
        * 
        */
        public CompteSurCarnet(String Name, double balance) : base(Name, balance)
        {
            this.NumCarnet = GenerateNumber();
        }

        public CompteSurCarnet(String AccNumber ,String Name, double balance) : base(AccNumber, Name, balance)
        {
            this.NumCarnet = GenerateNumber();
        }


        //Display Account Info
        public override void DisplayInfo()
        {
            Console.WriteLine($"\r\nYour Account carnet Information : \r\nAccount Holder : {this.AccountHolderName}\r\nAccount Number: {this.AccountNumber}\r\nCarnet Number: {this.NumCarnet}\r\nAccount Balance: {this.Balace}\r\n");
        }
        public override bool Credit(double ammount)
        {
            //amount to add to the balance
            this.Balace += ammount;
            Console.WriteLine("\r\n|| Your saving's account balance is now {0} dh ||\r\n", this.Balace);

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
                Console.WriteLine($"\r\n|| You have withdrawn {ammount} from your account, the remaining balance is {this.Balace}||\r\n");
                return true;

            }
        }

        //public override void ManageAccount()
        //{

        //}
    }
}
