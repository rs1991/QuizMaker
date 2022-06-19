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

        public enum GameMode
        {
            Play,
            AddQuestion
        }



        public static void GamePlayChoice()
        {

            Console.WriteLine("Which mode would you like to choose? Select P to play and A to add questions");
            string choice = Console.ReadLine().ToUpper();

            switch (choice)
            {
                case "A":
                    Console.WriteLine("---------------------");
                    break;
                    case "P":
                    LogicMethods.CreateQuestions();
                    break;
                    default:
                    Console.WriteLine("Select a valid option");
                    break;
            }
            
            
            
            //
            //switch (mode) {
            //    case GameMode.Play:
            //        Console.WriteLine("Play the game");
            //        break;
            //       case GameMode.AddQuestion:
            //        Console.WriteLine("Add questions");
            //        break;
            //        }
            }

        public static void DisplayQuestion(QnA q)
        {
            Console.WriteLine(q.Question);
        }      

        public static void AnswerDisp(QnA a)
        {
                        
            foreach (var ans in a.Answers)
            {
                Console.WriteLine(ans);
            }
        }

        public static int SelectAnswer()
        {
            Console.WriteLine("----------------------------");
            Console.WriteLine("Select answer 1, 2, 3 or 4: ");
            int selectAnswer = Convert.ToInt32(Console.ReadLine());
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


    }

}

