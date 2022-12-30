namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Whats is your favorite subject in school?");
            var faveSubject = Console.ReadLine();

            switch (faveSubject.ToLower())
            {
                case "math":
                    Console.WriteLine("Math is a tough one!");
                    break;
                case "science":
                    Console.WriteLine("Science is fun!");
                    break;
                case "english":
                    Console.WriteLine("You'll do a lot of reading in this one!");
                    break;
                case "history":
                    Console.WriteLine("Flashcards will be very beneficial in this subject");
                    break;
                case "physical Education":
                case "p.e.":
                case "pe":
                case "gym":
                    Console.WriteLine("Great time to get some energy out!");
                    break;
                default: 
                    Console.WriteLine($"I'm sorry, I'm not familiar with {faveSubject}.");
                    break;
            }         
         
        }
    }
}