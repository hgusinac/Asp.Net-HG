using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.Net_HG.Models
{
    public class Fever
    {
       
        public static string FeverCheck(string temp)
        {
            string message = "";
            double Tempen = new double();
            Tempen = Convert.ToDouble(temp);
            
            
            if(Tempen >= 37.8)
            {

                message = "You have a temperature call 911 !!!";
            }
            else
            {
                message = "You are okej";
            } return message;
        } 
      
    }
    
    
        
        
       
    
}
