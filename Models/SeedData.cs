using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace RazorPagesMovie.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RazorPagesMovieContext(
                serviceProvider.GetRequiredService<DbContextOptions<RazorPagesMovieContext>>()))
            {
                if (context == null || context.Movie == null)
                {
                    throw new ArgumentNullException("THE RAZOR PAGE CONTEXT IS NULL");
                }

                if (context.Movie.Any())
                {
                    return;
                    //This means that the is value already in the database
                }
                context.Movie.AddRange(
                          new Movie
                          {
                              Title = "When Harry Met Sally",
                              ReleaseDate = DateTime.Parse("1989-2-12"),
                              Genre = "Romantic Comedy",
                              Price = 7.99M,
                              Rating = "7",
                          },

                          new Movie
                          {
                              Title = "Ghostbusters ",
                              ReleaseDate = DateTime.Parse("1984-3-13"),
                              Genre = "Comedy",
                              Price = 8.99M,
                              Rating = "5",

                          },

                          new Movie
                          {
                              Title = "Ghostbusters 2",
                              ReleaseDate = DateTime.Parse("1986-2-23"),
                              Genre = "Comedy",
                              Price = 9.99M,
                              Rating = "7",

                          },

                          new Movie
                          {
                              Title = "Rio Bravo",
                              ReleaseDate = DateTime.Parse("1959-4-15"),
                              Genre = "Western",
                              Price = 3.99M,
                              Rating = "9",
                          }
                      );
                context.SaveChanges();
            }
        }
    }
}