namespace SelectionStatementExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Initialize a random number between 1 and 50
            Random random = new Random();
            int favNumber = random.Next(1, 50);

            Console.WriteLine("Welcome to the Guess the Favorite Number Game!");
            int userInput = int.Parse(Console.ReadLine());

            // Check if the guessed number is below, equal to, or above the initial value
            if (userInput < favNumber)
            {
                Console.WriteLine("Too low! Try again.");
            }
            else if (userInput > favNumber)
            {
                Console.WriteLine("Too high! Try again.");
            }
            else
            {
                Console.WriteLine($"Congratulations! You guessed it!!! The favorite number was: {favNumber}");
            }
        }
    }
}
