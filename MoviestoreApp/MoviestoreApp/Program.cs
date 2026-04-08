using System.Transactions;

namespace MoviestoreApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Movie> movies = new List<Movie>();

            Console.WriteLine("Welcome to movie store developed by: Raju Siriyala");

            while (true)
            {
                Console.WriteLine("\n1. Add New Movie");
                Console.WriteLine("2. Display All Movies");
                Console.WriteLine("3. Find Movie by ID");
                Console.WriteLine("4. Remove Movie by ID");
                Console.WriteLine("5. Clear All Movies");
                Console.WriteLine("6. Exit");
                Console.Write("\nEnter your Choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        if (movies.Count < 5)
                        {
                            Movie m = new Movie();
                            Console.Write("Enter Movie ID: ");
                            m.Id = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Enter Movie Name: ");
                            m.Name = Console.ReadLine();
                            Console.Write("Enter Year Of Release: ");
                            m.YearOfRelease = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Enter Genre: ");
                            m.Genre = Console.ReadLine();
                            movies.Add(m);
                            Console.WriteLine("Movie Added Successfully");
                        }
                        else
                        {
                            Console.WriteLine("Store is full! Max 5 movies allowed.");
                        }
                        break;
                    case 2:
                        foreach (Movie m in movies)
                        {
                            Console.WriteLine($"ID: {m.Id} | Name: {m.Name} | Year: {m.YearOfRelease} | Genre: {m.Genre}");
                        }
                        break;
                    case 3:
                        Console.Write("Enter Movie Id: ");
                        int id = Convert.ToInt32(Console.ReadLine());
                        foreach (Movie m in movies)
                        {
                            if (id == m.Id)
                            {
                                Console.WriteLine($"ID: {m.Id} | Name: {m.Name} | Year: {m.YearOfRelease} | Genre: {m.Genre}");
                            }
                        }
                        break;
                    case 4:
                        Console.Write("Enter Movie Id to remove: ");
                        int id1 = Convert.ToInt32(Console.ReadLine());
                        Movie Remove = null;
                        foreach (Movie m in movies)
                        {
                            if (m.Id == id1)
                            {
                                Remove = m;
                                break;
                            }
                        }
                        if (Remove != null)
                        {
                            movies.Remove(Remove);
                            Console.WriteLine("Movie Removed Successfully");
                        }
                        else
                        {
                            Console.WriteLine("Movie not found!");
                        }
                        break;
                    case 5:
                        movies.Clear();
                        Console.WriteLine("All the Movies Removed Successfully");
                        break;
                    case 6:
                        return;
                    default:
                        Console.WriteLine("Choose proper option.");
                        break;
                }
            }
        }
    }
}
