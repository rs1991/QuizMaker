using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizMaker
{
    internal class UiMethods
    {

        public static void WelcomeMessage()
        {
            Console.WriteLine("Welcome to the quiz!");
        }

        public static double SelectOption(double option)
        {
            Console.WriteLine("What would you like to do? Select 1 to add questions and 2 to play");
            Console.ReadLine();
            return option;
        }

      


    }
}
