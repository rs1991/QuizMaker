using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;



namespace QuizMaker
{
    public class LogicMethods
    {

         public static List<QnA> GenerateQnAList() 
        {

            QnA Question1 = new QnA();
            Question1.Question = "What's the capital of Austria?";
            Question1.Answers.Add("Vienna");
            Question1.Answers.Add("Salzburg");
            Question1.Answers.Add("Linz");
            Question1.Answers.Add("Innsbruck");
            Question1.CorrectAnswerIndex = 0;

            QnA Question2 = new QnA();
            Question2.Question = "Who has won the champions league the most times?";
            Question2.Answers.Add("Liverpool");
            Question2.Answers.Add("Real Madrid");
            Question2.Answers.Add("Bayern Munich");
            Question2.Answers.Add("AC Milan");
            Question2.CorrectAnswerIndex = 1;

            QnA Question3 = new QnA();
            Question3.Question = "Which city hosted the 2000 Olympics?";
            Question3.Answers.Add("London");
            Question3.Answers.Add("Paris");
            Question3.Answers.Add("Sydney");
            Question3.Answers.Add("Rio de Janeiro");
            Question3.CorrectAnswerIndex = 2;

            QnA Question4 = new QnA();
            Question4.Question = "Which is the first Harry Potter book?";
            Question4.Answers.Add("Deathly Hallows");
            Question4.Answers.Add("Philosopher's stone");
            Question4.Answers.Add("Goblet of Fire");
            Question4.Answers.Add("Chamber of Secrets");
            Question4.CorrectAnswerIndex = 1;

            QnA Question5 = new QnA();
            Question5.Question = "Which artist famously cut off his own ear?";
            Question5.Answers.Add("Van Gogh");
            Question5.Answers.Add("Claude Monet");
            Question5.Answers.Add("Salvador Dali");
            Question5.Answers.Add("Pablo Picasso");
            Question5.CorrectAnswerIndex = 0;

            QnA Question6 = new QnA();
            Question6.Question = "Which country gifted America the statue of Liberty?";
            Question6.Answers.Add("Belgium");
            Question6.Answers.Add("France");
            Question6.Answers.Add("Sweden");
            Question6.Answers.Add("Denmark");
            Question6.CorrectAnswerIndex = 1;


            List<QnA> QuestionList = new List<QnA>();
            QuestionList.Add(Question1);
            QuestionList.Add(Question2);
            QuestionList.Add(Question3);
            QuestionList.Add(Question4);
            QuestionList.Add(Question5);
            QuestionList.Add(Question6);

            return QuestionList;

            //TODO: return that list back to whoever requested it

            //var random = new Random();                               //TODO: Should be part of main program
            //int index = random.Next(QuestionList.Count);             //TODO: Should be part of main program
            //Console.WriteLine(QuestionList[index]);                  //TODO: Should be part of main program
            //UiMethods.DisplayAnswers(QuestionList[index]);           //TODO: Should be part of main program

        }

        public static void WriteQnAList(List<QnA>QuestionList, string path)
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
        //Console.Write(string.Join(System.Environment.NewLine, Sports.Question + "\n " + Sports.Answers));
        //Console.WriteLine(string.Join(System.Environment.NewLine, CapitalsOfTheWorld.Question));

        //    string joinedString = "";
        //    foreach(string answer in CapitalsOfTheWorld.Answers)
        //    {
        //        joinedString += answer + Environment.NewLine;
        //    }
        //    Console.WriteLine(joinedString);   

        //}


        //public static void CreateQuestions()
        //{
        //    List<string> QuestionList = new List<string>();
        //    Console.Write("Please add your question: ");
        //    string UserQuestion = Console.ReadLine();
        //    QnA NewQuestion = new QnA();
        //    NewQuestion.Question = UserQuestion;
        //Console.Write("Please add your answers: ");
        //string newAnswer = Console.ReadLine();
        //NewQuestion.Answers.Add("");
        //NewQuestion.Answers.Add("");
        //NewQuestion.Answers.Add("");
        //NewQuestion.Answers.Add("");

        //    QuestionList.Add(Console.ReadLine());
        //    //QnA Question1 = new QnA();
        //    for (int i = 0; i < QuestionList.Count; i++)
        //    {
        //        Console.WriteLine(QuestionList[i]);
        //    }




        //    foreach (var QnA in QuestionList)
        //    {
        //        Console.WriteLine(QnA.Question);

        //    }


        // }

        public static bool VerifyAnswer(int SelectedAnswer, QnA anAToCheck)
        {
            SelectedAnswer -= 1;
            if (anAToCheck.CorrectAnswerIndex == SelectedAnswer)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
