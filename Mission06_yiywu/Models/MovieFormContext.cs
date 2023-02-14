using Microsoft.EntityFrameworkCore;

namespace Mission06_yiywu.Models
{
    public class MovieFormContext:DbContext 
    {
        public MovieFormContext(DbContextOptions<MovieFormContext> options) : base (options)
        {
            //Leave Blank for Now 

        }
        public DbSet<ApplicationResponse> ApplicationResponse { get; set; }

        //seed database with three of my favorite movies 
        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<ApplicationResponse>().HasData(
                    new ApplicationResponse
                    {
                        MovieId = 1,
                        Category = "Romance",
                        Title = "Pride and Prejudice",
                        Year = 2006,
                        Director = "steven",
                        Rating = "G",
                        Edited = true,
                        LentTo = "Eva",
                        Notes = "Best Movie of the Century"
                    },
                    new ApplicationResponse
                    {
                        MovieId = 2,
                        Category = "Comedy",
                        Title = "Parent Trap",
                        Year = 2000,
                        Director = "Tom",
                        Rating = "G",
                        Edited = true,
                        LentTo = "Eva",
                        Notes = "Best Comedy of the Century"
                    },
                    new ApplicationResponse
                    {
                        MovieId = 3,
                        Category = "Inspiring",
                        Title = "Haute Couture",
                        Year = 2021,
                        Director = "Sylvie Ohayon",
                        Rating = "PG-13",
                        Edited = true,
                        LentTo = "Eva",
                        Notes = "Wish it was as easy as that to get an internship"
                    }

                );


        }
    }
}
