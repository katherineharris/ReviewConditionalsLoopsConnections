using System;

namespace ReviewConditionalsLoopsCollections
{
    class Program
    {
        static void Main(string[] args)
        {

            int age = 0;
            string messageForUser = "Please enter your age: ";

            Console.Write(messageForUser);
            age = Convert.ToInt32(Console.ReadLine());

           // Console.Write("Your age is: " + age.ToString("N0"));
            if(age>=21)
            {
                Console.WriteLine("OH SHIT YOU CAN DRINK");
            }
            else if(age >= 18)
            {
                Console.WriteLine("CONGRraTZ BiSh you CAn GamBLE and vote :P XD");
            }
            else if (age >= 16)
            {
                Console.WriteLine("WOoo YoU fiNALly dRiVE :)");
            }
            else if (age>=0)
            {
                Console.WriteLine("welCOme to Earth LMao little baby hahaha");
            }
            else
            {
                Console.WriteLine("youre stupid thats not even an age haha");
            }

            Console.ReadKey();

        }
    }
}
