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

        public static void AddQnAs()
        {

            QnA CapitalsOfTheWorld = new QnA();
            CapitalsOfTheWorld.Question = "What is the capital of Austria?";
            CapitalsOfTheWorld.Answers.Add("Vienna");
            CapitalsOfTheWorld.Answers.Add("Graz");
            CapitalsOfTheWorld.Answers.Add("Salzburg");
            CapitalsOfTheWorld.Answers.Add("Innsbruck");
            CapitalsOfTheWorld.CorrectAnswerIndex = 0;

            QnA Sports = new QnA();
            Sports.Question = "Who has won the champions league the most times?";
            Sports.Answers.Add("Liverpool");
            Sports.Answers.Add("Real Madrid");
            Sports.Answers.Add("Bayern Munich");
            Sports.Answers.Add("AC Milan");
            Sports.CorrectAnswerIndex = 1;

            QnA BrieCheese = new QnA();
            BrieCheese.Question = "Where does Brie cheese come from?";
            BrieCheese.Answers.Add("Germany");
            BrieCheese.Answers.Add("Switzerland");
            BrieCheese.Answers.Add("France");
            BrieCheese.Answers.Add("UK");
            BrieCheese.CorrectAnswerIndex = 2;

            List<QnA> QuestionList = new List<QnA>();
            QuestionList.Add(CapitalsOfTheWorld);
            QuestionList.Add(Sports);
            QuestionList.Add(BrieCheese);


            XmlSerializer serializer = new XmlSerializer(typeof(List<QnA>));
            var path = @"C:\tmp\QuestionList.xml";
            

            using (FileStream file = File.Create(path))
            {
                serializer.Serialize(file, QuestionList);
            }

            using (FileStream file = File.OpenRead(path))
            {
                QuestionList = serializer.Deserialize(file) as List<QnA>;
            }

            Console.WriteLine(string.Join(", ", QuestionList));



        }

        public static void DisplayQnAs()
        {
            
        } 


       
    }
}
