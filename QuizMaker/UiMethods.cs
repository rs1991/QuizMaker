using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
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

        /// <summary>
        /// Displays the question along with possible answers
        /// </summary>
        /// <param name="q"></param>
        public static void DisplayQnA(QnA q)
        {
            Console.WriteLine(q.Question);
            foreach (var ans in q.Answers)
            {
                Console.WriteLine(ans);
            }
        }
                
        public static int SelectAnswer()
        {
            Console.WriteLine("----------------------------");
            Console.WriteLine("Select answer 1, 2, 3 or 4: ");
            int selectAnswer = Convert.ToInt32(Console.ReadLine());
            
            while (selectAnswer > 4 || selectAnswer < 1)
            {
                Console.WriteLine("Please select one of valid options, [1, 2, 3 or 4");
                selectAnswer  = Convert.ToInt32(Console.ReadLine());
            }
            return selectAnswer;
        }

        public static void DisplayResultInfo(bool correct)
        {
            
            if (correct)
            {
                Console.WriteLine("Correct!");
            }
            else
            {
                Console.WriteLine("Wrong!");
            }

        }

        public static List<QnA> CreateQuestions()
        {
            QnA QuestionAnswer = new QnA();
            Console.Write("Please add your question: ");
            
            string UserQuestion = Console.ReadLine();
            QuestionAnswer.Question = UserQuestion;
            
            for (int i = 0; i < 4; i++)
            {
                Console.Write("Please add your 4 possible answers: ");
                string answers = Console.ReadLine();
                QuestionAnswer.Answers.Add(answers);
            }

            Console.Write("Select correct answer: ");
            int CorrectAnsIndex = Convert.ToInt32(Console.ReadLine());
            
            QuestionAnswer.CorrectAnswerIndex = CorrectAnsIndex;
            List<QnA> QuestionList = new List<QnA>();
            QuestionList.Add(QuestionAnswer);
            
            return QuestionList;
        }

        public static bool PlayAgain()
        {
            string Answer;
            Console.WriteLine("Would you like to play again? [Y or N]");
            Answer = Console.ReadLine().ToUpper(); 
            if(Answer == "Y")
            {
                return true;
            }
            else  
            {
                return false;
            }
            
        }

        public static void TotalScore()
        {
            double Total = 0;
            Total++;
            Console.WriteLine("Your total score is: " + Total);
        }

        public static void EndMessage()
        {
            Console.WriteLine("Thanks for playing!");
        }
    }
}
