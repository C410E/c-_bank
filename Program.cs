namespace Movies;
class MoviesPrincipal
{
    public static void Main(string[] args)
    {
        Movie movieA = new Movie("Matrix", "Ação");
        Movie movieB = new Movie("Senhor dos Aneis", "Fantasia");

        Console.WriteLine(movieA.Title);
        Console.WriteLine(movieA.Category);
        Console.WriteLine(movieB.Title);
        Console.WriteLine(movieB.Category);
    }
}