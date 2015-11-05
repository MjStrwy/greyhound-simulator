using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aDayAtTheRaces
{
    public class Bet
    {
        public int Amount;
        public int Dog;
        public Guy Bettor;

        public string GetDescription()
        {
             //return a string that say who placed the bet, how much cash was bet, and which dog he bet on. 
             //If amount is zero no bet is placed
            string desc = Bettor.Name + " bet $" + this.Amount + " on dog " + (this.Dog + 1);
            return desc;
        }

        public int PayOut(int Winner)
        {
            //paramter is winner of race. if the dog won, return the amount bet
            //otherwise, return the negative of the amount bet
            if (Winner == this.Dog)
            {
                return this.Amount;
            }
            else
            {
                return -1 * this.Amount;
            }
        }
    }
}
