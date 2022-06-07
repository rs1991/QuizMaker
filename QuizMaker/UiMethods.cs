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
           Question.ToString();
           return Question;
           
        }
        
        public static void DisplayAnswers(QnA ans)
        {
            ans.AnswerDisp();
        }

        public static int SelectAnswer(int selectedAnswer, QnA AnswerIndex)
        {
            Console.WriteLine("Select answer 1, 2, 3 or 4: ");
            selectedAnswer = Convert.ToInt32(Console.ReadLine());

            if(selectedAnswer == AnswerIndex.CorrectAnswerIndex)
            {
                Console.WriteLine("Correct answer");
            }
            else
            {
                Console.WriteLine("Wrong answer");
            }
            
            return selectedAnswer;
        }

        public static bool VerifyAnswer(int selectedAnswer)
        {
            return VerifyAnswer(selectedAnswer);
        }

    }
}
