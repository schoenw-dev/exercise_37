using System;

namespace exercise_37
{
    class Program
    {
        static void Main(string[] args)
        {
            bool repeat = true;

            while (repeat)
            {

                string message = "Please enter 5 numbers:";
                int[] userArray = new int[5];

                int total = SumOfArray(message, userArray);
                Console.WriteLine($"The total of your array is {total}!");

                Console.WriteLine("Would you like to continue? (y|n)");
                string userAnswer = Console.ReadLine();
                if(userAnswer == "y")
                {
                    repeat = true;
                }
                else if(userAnswer == "n")
                {
                    Console.WriteLine("Goodbye!");
                    repeat = false;
                }
                else
                {
                    Console.WriteLine("error, goodbye!");
                    repeat = false;
                }
            }
        }

        public static int SumOfArray(string message, int[] userArray)
        {
            Console.WriteLine(message);
            int[] userNum = new int[5];
            
            for(int i = 0; i < 5; i++)
            {
                userNum[i] = int.Parse(Console.ReadLine());
                userArray[i] = userNum[i];
                
            }
            int total =
            userArray[0] + userArray[1] + userArray[2] + userArray[3] + userArray[4];

            return total;

        }
    }
}
