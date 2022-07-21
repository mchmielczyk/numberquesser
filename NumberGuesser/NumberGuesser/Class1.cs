namespace NumberGuesser
{
    internal class Numberguesser
    {
        public void Guesser()
        {
            Console.WriteLine("In this program you will try to guess number from 1 to 10");
            Console.WriteLine("What's your name?");
            string userName = Console.ReadLine();
            Console.WriteLine("Hello " + userName + "!", Console.ForegroundColor = ConsoleColor.Blue);
            Random random = new Random();
            int correctNumber = random.Next(1, 11);
            bool correctAnswer = false;
            Console.WriteLine("Guess number between 1 and 10", Console.ForegroundColor = ConsoleColor.White);
            int guess;
            while (!correctAnswer)
            {
                string input = Console.ReadLine();
                bool InputCheck = Int32.TryParse(input, out guess);
                if (!InputCheck)
                {
                    Console.WriteLine("Input must be a number");
                    continue;
                }
                if (guess < 1 || guess > 10)
                {
                    Console.WriteLine("Input must be a number between 1 and 10", Console.ForegroundColor = ConsoleColor.Yellow);
                    Console.ForegroundColor = ConsoleColor.White;
                    continue;
                }
                if (guess < correctNumber)
                {
                    Console.WriteLine("Wrong answer, random number is higher", Console.ForegroundColor = ConsoleColor.Red);
                    Console.ForegroundColor = ConsoleColor.White;
                    continue;
                }
                else if (guess > correctNumber)
                {
                    Console.WriteLine("Wrong answer, random number is lower", Console.ForegroundColor = ConsoleColor.Red);
                    Console.ForegroundColor = ConsoleColor.White;
                    continue;
                }
                else
                {
                    Console.WriteLine("Congratulations, correct answer! " + correctNumber + " was that number", Console.ForegroundColor = ConsoleColor.Green);
                    correctAnswer = true;
                }
            }
        }
    }
}
