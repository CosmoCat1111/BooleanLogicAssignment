using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLogicAssignment
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome, here is the Car Insurance Application Approval Program Application");
            Console.WriteLine("Please fill out the questions below:");
            //requesting info on age and display
            Console.WriteLine("What's your age?  ");
            int ageInput = Convert.ToInt32(Console.ReadLine());
            //requesting info on DUI and display
            Console.WriteLine("Have you ever had a DUI? (Yes or No)");
            string answerDUI = Console.ReadLine().ToLower();
            bool duiAnswer = answerDUI == "yes";
            //requesting info on tickets and dispaly
            Console.WriteLine("How many speeding tickets do you have? ");
            int manyTickets = Convert.ToInt32(Console.ReadLine());
            //Prompting user that answer is coming and displaying
            Console.WriteLine("Are you qualified for insurance?");
            //putting everything together to see if qualified and display
            bool youQualified = (ageInput > 15) && !duiAnswer && (manyTickets <= 3);
            Console.WriteLine(youQualified);
     
            Console.ReadLine();

        }
    }
}
