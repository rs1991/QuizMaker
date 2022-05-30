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

            QnA Sports = new QnA();
            Sports.Question = "Who has won the champions league the most times?";
            Sports.Answers.Add("Liverpool");
            Sports.Answers.Add("Real Madrid");
            Sports.Answers.Add("Bayern Munich");
            Sports.Answers.Add("AC Milan");
            Sports.CorrectAnswerIndex = 1;


            //Random rnd = new Random();
            List<QnA> QuestionList = new List<QnA>();
            QuestionList.Add(CapitalsOfTheWorld);
            QuestionList.Add(Sports);

            //int index = rnd.Next(QuestionList.Count);
            //Console.WriteLine(QuestionList[index]);
                
            XmlSerializer serializer= new XmlSerializer(typeof(List<QnA>));
            var path = @"C:\tmp\QuestionList.xml";
            
            using (FileStream file = File.OpenRead(path))
            {
                QuestionList = serializer.Deserialize(file) as List<QnA>;
            }

            foreach(var QnA in QuestionList)
            {
                Console.WriteLine(QnA.Question);

            }

            

        }

        public static void DisplayQnAs()
        {
            

        } 
       
    }
}
