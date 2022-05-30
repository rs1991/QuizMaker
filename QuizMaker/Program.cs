using System;
namespace QuizMaker
{
    internal class Program
    {
        static void Main(string[] args)
        {

            

            UiMethods.WelcomeMessage();

            QnA CapitalsOfTheWorld = new QnA();
            CapitalsOfTheWorld.Question = "What is the capital of Austria?";
            //CapitalsOfTheWorld.Answer1 = "Innsbruck";
            //CapitalsOfTheWorld.Answer2 = "Salzburg";
            //CapitalsOfTheWorld.Answer3 = "Graz";
            //CapitalsOfTheWorld.Answer4 = "Vienna";

            QnA Sports = new QnA();
            Sports.Question = "Who has won the champions league the most times?";
            Sports.Answers.Add("Liverpool");
            Sports.Answers.Add("Real Madrid");
            Sports.Answers.Add("Bayern Munich"); 
            Sports.Answers.Add("AC Milan");
            Sports.CorrectAnswerIndex = 1;

            List<QnA> QuestionList = new List<QnA>();
            QuestionList.Add(CapitalsOfTheWorld);
            QuestionList.Add(Sports);

            System.Xml.Serialization.XmlSerializer writer = new System.Xml.Serialization.XmlSerializer(typeof(List<QnA>));

            var path = @"C:\tmp\QuestionList.xml";
            using (FileStream file = File.Create(path))
            {
                writer.Serialize(file, QuestionList);
            }

        }
    }
}
