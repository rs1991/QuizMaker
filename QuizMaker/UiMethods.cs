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
       
        
        public static int SelectAnswer()
        {
            Console.WriteLine("----------------------------");
            Console.WriteLine("Select answer 1, 2, 3 or 4: ");
            int selectAnswer = Convert.ToInt32(Console.ReadLine());
            return selectAnswer;
        }
        

        public static bool VerifyAnswer(int SelectedAnswer)
        {
            

            if (SelectAnswer() == SelectedAnswer)
            {
                Console.WriteLine("Correct");
                return true;
            }
            else
            {
                Console.WriteLine("Wrong!");
                return false;

            }
        }

    }
}
