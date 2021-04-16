using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.Net_HG.Models
{
    public class number
    {

        private static Random random = new Random();
        public static string  Rightguess(int Userinput,int randomNumber)//userinput kommer från input på webben
            
        {
            
            if(Userinput < randomNumber)
            {
                return "To low, guess higher" + " " + Userinput;
            }
            else if (Userinput> randomNumber)
            {
                return "To High, guess lower" + Userinput;
            }
            else 
            {
                return "Nice You guesst it !! Right Number was" + randomNumber;
            }
        }
        public static int GetRandomNum()
        {
            return random.Next(1,100);
        }

        
    }

}
