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

        public static string GamePlayChoice()
        {
            Console.WriteLine("Which mode would you like to choose? Select P to play and A to add questions");
            string choice = Console.ReadLine().ToUpper();
            
            switch (choice)
            {
                case "P":
                    Console.WriteLine(GameMode.Play);
                    break;
                case "A":
                    Console.WriteLine(GameMode.AddQuestion);
                    break;
            }
            return choice;
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
            while (selectAnswer > 4 || selectAnswer < 1)
            {
                Console.WriteLine("Please select a valid option");
                selectAnswer = UiMethods.SelectAnswer();
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


    }

}

