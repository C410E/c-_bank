namespace Movies;
class MoviesPrincipal
{
    public static void Main(string[] args)
    {
       try 
       {
        Movie movieA = new Movie("Matrix", "Ficção científica");
        Movie movieB = new Movie("Senhor dos Aneis", "Fantasia");

        movieA.Category = "Fantasia";

        Console.WriteLine(movieA.Title);
        Console.WriteLine(movieA.Category);
        Console.WriteLine(movieB.Title);
        Console.WriteLine(movieB.Category);
       }
       catch (Exception ex)
       {
            Console.WriteLine("Erro: " + ex.Message);
            throw;
       }
    }
}