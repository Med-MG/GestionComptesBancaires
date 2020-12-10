using System;
using System.Collections.Generic;
using System.Text;

namespace GestionComptesBancaires
{
    class CompteSurCheque : AbstractCompte
    {

        private double dailyWithdrawLimit = 10000;

        public CompteSurCheque() : base()
        {
            //Empty constructor
        }

        public CompteSurCheque(String Name, int AccountNum, double balance) : base(Name, AccountNum, balance)
        {
            //no init
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
