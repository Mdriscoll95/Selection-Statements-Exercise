namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("guess a number");
            int favNumber = 13;

            int input = int.Parse(Console.ReadLine());

            if (input == favNumber)
            {
                Console.WriteLine($"You Guessed it!");
            }
            else if (input > favNumber)
            {
                Console.WriteLine($"too high!");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine($"too low");

            }
        }
    }
}
