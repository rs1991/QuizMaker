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
            Console.WriteLine("--------------------");
            Console.WriteLine("Welcome to the quiz!");
            Console.WriteLine("--------------------");
        }

        public static string DisplayQuestion(string Question)
        {
           LogicMethods.AddQnAs();
           return Question;
        }
        
        public static void DisplayAnswers(QnA ans)
        {
            ans.AnswerDisp();
        }

    }
}
