using System;

namespace MethodExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();

            Console.WriteLine("What is your age?");
            string userAge = Console.ReadLine();

            Console.WriteLine("What is a good name for a dog?");
            string userDogName = Console.ReadLine();

            Console.WriteLine("What is your favorite color?");
            string userColor = Console.ReadLine();

            Console.WriteLine($"There was a person named {userName}, He was {userAge} years old.");
            Console.WriteLine($"They had a {userColor} colored dog named {userDogName}");

            Console.WriteLine($"----------------");

            Console.WriteLine($"give me a number to add");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine($"give me a number to add to the first one");
            int num2 = int.Parse(Console.ReadLine());

            int sum = Sum(num1, num2);
            Console.WriteLine($"The sum is: {sum}");

            Console.WriteLine($"----------------");

            Console.WriteLine($"Give me a number to multiply");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine($"What number should I multiply the first number with?");
            int y = int.Parse(Console.ReadLine());

            int product = Multiply(x, y);
            Console.WriteLine($"The answer is: {product}");

        }

        public static int Sum(int num1, int num2)
        {
            int sum = num1 + num2;
            
            return sum;
        }

        public static int Multiply(int x, int y)
        {
            int product = x * y;
            return product;
        }
    }
}
