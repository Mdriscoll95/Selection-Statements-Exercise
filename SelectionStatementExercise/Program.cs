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
                Console.WriteLine($"Correct");
            }
            else
            {
                Console.WriteLine($"incorrect!");
            }
        }
    }
}
