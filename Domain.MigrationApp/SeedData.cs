using Domain.Models.POCOs;
using System;
using System.Linq;

namespace Domain.MigrationApp
{
    public static class SeedData
    {
        internal static void SeedMovies()
        {
            using (var context = new ApplicationContext())
            {
                if (!context.Movie.Any())
                {
                    context.Movie.AddRange(
                        new Movie
                        {
                            Title = "When Harry Met Sally",
                            ReleaseDate = DateTime.Parse("1989-1-11"),
                            Genre = "Romantic Comedy",
                            Rating = "R",
                            Price = 7.99M
                        },
                        new Movie
                        {
                            Title = "Ghostbusters ",
                            ReleaseDate = DateTime.Parse("1984-3-13"),
                            Genre = "Comedy",
                            Rating = "PG",
                            Price = 8.99M
                        },
                        new Movie
                        {
                            Title = "Ghostbusters 2",
                            ReleaseDate = DateTime.Parse("1986-2-23"),
                            Genre = "Comedy",
                            Rating = "PG",
                            Price = 9.99M
                        },
                        new Movie
                        {
                            Title = "Rio Bravo",
                            ReleaseDate = DateTime.Parse("1959-4-15"),
                            Genre = "Western",
                            Rating = "PG",
                            Price = 3.99M
                        }
                    );
                    context.SaveChanges();
                }
            }
        }

        internal static void SeedUsers()
        {            
            using (var context = new ApplicationContext())
            {            
                if (!context.User.Any())
                {
                    context.User.AddRange(
                        new User
                        {
                            FirstName = "Boris",
                            Surname = "Borisnikov"
                        },
                        new User
                        {
                            FirstName = "Fred",
                            Surname = "Bloggs"
                        },
                        new User
                        {
                            FirstName = "Herman",
                            Surname = "Munster"
                        }
                    );
                    context.SaveChanges();
                }
            }
        }
    }
}
