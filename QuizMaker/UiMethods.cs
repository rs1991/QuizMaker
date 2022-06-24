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

        public static void GamePlayChoice(GameMode mode)
        {
            //Console.WriteLine("Which mode would you like to choose? Select P to play and A to add questions");
            //string choice = Console.ReadLine().ToUpper();

            switch (mode)
            {
                case GameMode.Play:
                    Console.WriteLine("Play");
                    break;
                case GameMode.AddQuestion:
                    Console.WriteLine("Add questions");
                    break;
            }

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

        public static void CreateQuestions()
        {
            List<string> QuestionList = new List<string>();
            Console.Write("Please add your question: ");
            string UserQuestion = Console.ReadLine();
            QnA NewQuestion = new QnA();
            NewQuestion.Question = UserQuestion;
            Console.Write("Please add your answers: ");
            string newAnswer = Console.ReadLine();
            NewQuestion.Answers.Add("");
            NewQuestion.Answers.Add("");
            NewQuestion.Answers.Add("");
            NewQuestion.Answers.Add("");
            QuestionList.Add(Console.ReadLine());
            QnA Question1 = new QnA();
            for (int i = 0; i < QuestionList.Count; i++)
            {
                Console.WriteLine(QuestionList[i]);
            }
        }


    }

}

