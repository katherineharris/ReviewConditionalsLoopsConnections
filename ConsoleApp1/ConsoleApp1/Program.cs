using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] firstNames = new string[15];
            //string[] lastNames = new string[15];
            //firstNames[0] = "Adam";
            //lastNames[0] = "Ackerman";
            //firstNames[1] = "Katie";
            //lastNames[1] = "Harris";

            //for(int i=0;i<firstNames.Length;i++)
            //{
            //    if (lastNames[i] == null && firstNames[i] == null)
            //    {

            //    }
            //    else
            //    {

            //        Console.WriteLine($"{lastNames[i]}, {firstNames[i]}");
            //    }
            //}

            List<double> examScores = new List<double>();
            examScores.Add(95.8);
            examScores.Add(98.8);
            examScores.Add(90.8);
            examScores.Add(65.2);
            examScores.Add(60);

            foreach(var item in examScores)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
