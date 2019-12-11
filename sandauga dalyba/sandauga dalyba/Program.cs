using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sandauga_dalyba
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sveiki!");

            string debit = "";
            Console.WriteLine("skaicius1:");
            debit = Console.ReadLine();
            Console.WriteLine("skaicius1:" + debit);
           
            string credit = "";
            Console.WriteLine("skaicius2:");
            credit = Console.ReadLine();
            Console.WriteLine("skaicius2:" + credit);
            
            int debitInt;
            int creditInt = 0;
            int.TryParse(debit, out debitInt);
            int.TryParse(credit, out creditInt);
            int balance = debitInt - creditInt;
            Console.WriteLine("Skirtumas:" + balance.ToString());
            Console.ReadLine();



        }
    }
}

















            





















   
    
        
        
      


            


     