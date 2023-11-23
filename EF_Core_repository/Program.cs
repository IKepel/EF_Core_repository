using EF_Core_repository;
using Microsoft.EntityFrameworkCore;

using var myDb = new AppDbContext();

if (!myDb.Movies.Any())
{
    myDb.Movies.AddRange(
        new Movie { Title = "Harry Potter", IsAdult = false },
        new Movie { Title = "The Lord of the Rings", IsAdult = false },
        new Movie { Title = "Transformers", IsAdult = false },
        new Movie { Title = "Gladiator", IsAdult = true },
        new Movie { Title = "Piranha 3D", IsAdult = true },
        new Movie { Title = "Room in Rome", IsAdult = true }
    );
    myDb.SaveChanges();
}

var movieLibrary = new MovieLibrary(myDb);

foreach (var movie in movieLibrary)
{
    Console.WriteLine(movie);
}

myDb.Movies.Add(new Movie { Title = "Marvel", IsAdult = false });
myDb.SaveChanges();

Console.WriteLine();
foreach (var movie in movieLibrary)
{
    Console.WriteLine(movie);
}