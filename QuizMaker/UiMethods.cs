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

        //public enum GameMode
        //{
        //    Play,
        //    AddQuestion
        //}

        //public static GameMode GetGameMode(GameMode gameMode)
        //{
        //    bool validInput = false;
        //    while (!validInput) //until the input is valid
        //    {
        //        Console.WriteLine("Select the game mode to play [1 to play] or [2 to add questions]");
        //        int gameChoice = Convert.ToInt32(Console.ReadLine());
        //        if (gameChoice == 1)
        //        {
        //            return GameMode.Play;
        //            validInput = true;
        //        }
        //        if (gameChoice == 2)
        //        {
        //            return GameMode.AddQuestion;
        //            validInput = true;
        //        }

        //    }
        //    return gameMode;
        //}

         

            //if (gameChoice == 1 || gameChoice == 2)
            //{
            //    //valid input
            //    if (gameChoice == 1)
            //    {
            //        UiMethods.GamePlayChoice(UiMethods.GameMode.Play);
            //    }
            //    if (gameChoice == 2)
            //    {
            //        UiMethods.GamePlayChoice(UiMethods.GameMode.AddQuestion);
            //        UiMethods.CreateQuestions();
            //    }
            //}
            //else
            //{
            //    //invalid input
            //}

            //while (gameChoice != 1 || gameChoice != 2)
            //{
            //    Console.WriteLine("Insert valid option");
            //    Console.WriteLine("Select the game mode to play [1 to play] or [2 to add questions]");
            //    gameChoice = Convert.ToInt32(Console.ReadLine());
            //    break;
            //}


          //  return gameChoice;
        



        


        public static void DisplayQuestion(QnA q)
        {
            Console.WriteLine(q.Question);
        }

        public static void DisplayAnswers(QnA a)
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

        


    }

}

