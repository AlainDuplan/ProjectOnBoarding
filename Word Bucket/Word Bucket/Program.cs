using System;
using System.Linq;

namespace Word_Bucket
{
    class Program
    {
        

        static string[] bucketize(string phrase, int bucket)
        {
            phrase = phrase.Trim();
            string[] phrases = phrase.Split();
            string[] bucketized = new string[phrases.Length];

            
            string temp = "";
            int counter = 0;
            int counter2 = 0;
            while (counter < phrases.Length)
            {
                if((temp + " " + phrases[counter]).Trim().Length <= bucket)
                {
                    temp += " "; temp += phrases[counter];
                    temp = temp.Trim();
                    counter++;
                    continue;
                }
                if (temp != "")
                {
                    bucketized[counter2] = temp;
                    counter2++;
                    temp = "";
                    continue;
                }
                if (temp == "")
                {
                    break;
                }
            }
            if (temp != "")
            {
                bucketized[counter2] = temp;
            }


            if (counter != phrases.Length)
            {
                return new string[0];
            }


            return bucketized.Where(x => !string.IsNullOrEmpty(x)).ToArray();

        }

        static void Main(string[] args)
        {
            string shells = "she sells sea shells by the sea";
            string cheese = "the mouse jumped over the cheese";
            string fairy = "fairy dust coated the air";
            string alph = "a b c d e";


           foreach(string bucket in bucketize(shells, 10))
            {
                Console.WriteLine(bucket);
            }
            Console.WriteLine();

            foreach (string bucket in bucketize(cheese, 7))
            {
                Console.WriteLine(bucket);
            }
            Console.WriteLine();
            foreach (string bucket in bucketize(fairy, 20))
            {
                Console.WriteLine(bucket);
            }
            Console.WriteLine();
            foreach (string bucket in bucketize(alph, 2))
            {
                Console.WriteLine(bucket);
            }
            Console.WriteLine();
        }
    }
}
