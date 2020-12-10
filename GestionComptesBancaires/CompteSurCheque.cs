using System;
using System.Collections.Generic;
using System.Text;

namespace GestionComptesBancaires
{
    class CompteSurCheque : AbstractCompte
    {
        public String NumCheque { get; set; }
        public String NumCarte { get; set; }

        DateTime DateFinValiditeCarte = DateTime.Now.AddYears(2);

        private double dailyWithdrawLimit = 10000;

        public CompteSurCheque() : base()
        {
            //Empty constructor
        }
        Random random = new Random((int)DateTime.Now.Ticks);
        public CompteSurCheque(String Name, double balance) : base(Name, balance)
        {
            this.NumCheque = Convert.ToString(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
            this.NumCarte = Convert.ToString(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
        }

        //Display Account Info
        public override void DisplayInfo()
        {
            Console.WriteLine($"\r\nYour Account Cheque Information : \r\nAccount Holder : {this.AccountHolderName} \r\nAccount Number: {this.AccountNumber}\r\nCheque Number: {this.NumCheque}\r\nCarte Number: {this.NumCarte}\r\nCarte Number: {this.DateFinValiditeCarte}\r\n Account Balance: {this.Balace}");
        }

        public override bool Credit(double ammount)
        {
            this.Balace += ammount;
            Console.WriteLine("Your che's account balance is now {0} dh", this.Balace);

            throw new NotImplementedException();
        }

        public override bool Debit(double ammount)
        {
            //amount to be withdrawn from the account
            if (ammount > this.Balace)
            {
                throw new ArgumentException("Solde insuffisant");
            }
            else if (ammount > dailyWithdrawLimit)
            {
                throw new ArgumentException($"You can not surpass the daily limit of {dailyWithdrawLimit}");
            }
            else
            {

                this.Balace -= ammount;
                Console.WriteLine($"You have withdrawn {ammount} from your account, the remaining balance is {this.Balace}");
                return true;
            }
        }
    }
}
