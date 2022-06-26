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

        public enum GameMode
        {
            Play,
            AddQuestion
        }

        public static int PromptToSelectGameChoice()
        {
            Console.WriteLine("Select the game mode to play [1 to play] or [2 to add questions]");
            int gameChoice = Convert.ToInt32(Console.ReadLine());

            if (gameChoice == 1)
            {
                UiMethods.GamePlayChoice(UiMethods.GameMode.Play);
            }
            if (gameChoice == 2)
            {
                UiMethods.GamePlayChoice(UiMethods.GameMode.AddQuestion);
                UiMethods.CreateQuestions();
            }
            while (gameChoice != 1 || gameChoice != 2)
            {
                Console.WriteLine("Insert valid option");
                Console.WriteLine("Select the game mode to play [1 to play] or [2 to add questions]");
                gameChoice = Convert.ToInt32(Console.ReadLine());
                break;
            }


            return gameChoice;
        }

        

        public static void GamePlayChoice(GameMode mode)
        {
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

        public static List<QnA> CreateQuestions()
        {
            QnA QuestionAnswer = new QnA();
            Console.Write("Please add your question: ");
            string UserQuestion = Console.ReadLine();
            QuestionAnswer.Question = UserQuestion;
            
            for(int i = 0; i <4; i++)
            {
                Console.Write("Please add your 4 possible answers: ");
                string answers = Console.ReadLine();
                QuestionAnswer.Answers.Add(answers);
            }

            List<QnA> QuestionList = new List<QnA>();
            QuestionList.Add(QuestionAnswer);

            return QuestionList;



        }

        public static void WriteQnAList(List<QnA> QuestionList, string path)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<QnA>));
            using (FileStream file = File.Create(path))
            {
                serializer.Serialize(file, QuestionList);
            }
        }

        public static List<QnA> LoadQnAList(string path)
        {
            List<QnA> QuestionList;
            XmlSerializer serializer = new XmlSerializer(typeof(List<QnA>));
            using (FileStream file = File.OpenRead(path))
            {
                QuestionList = serializer.Deserialize(file) as List<QnA>;
            }
            return QuestionList;
        }


    }

}

