using Microsoft.EntityFrameworkCore;

namespace Mission06_yiywu.Models
{
    public class MovieFormContext:DbContext 
    {
        public MovieFormContext(DbContextOptions<MovieFormContext> options):base(options)
        {
            //Leave Blank for Now 

        }
        public DbSet<ApplicationResponse> ApplicationResponse { get; set; }
        public DbSet<Category>Category{ get; set; }
        //seed database with three of my favorite movies 
        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Category>().HasData(
            new Category { CategoryId = 1, CategoryName = "Action/Adventure" },
            new Category { CategoryId = 2, CategoryName = "Comedy" },
            new Category { CategoryId = 3, CategoryName = "Drama" },
            new Category { CategoryId = 4, CategoryName = "Family" },
            new Category { CategoryId = 5, CategoryName = "Horror/Suspense" },
            new Category { CategoryId = 6, CategoryName = "Miscellaneous" },
            new Category { CategoryId = 7, CategoryName = "Television" },
            new Category { CategoryId = 8, CategoryName = "VHS" });
            mb.Entity<ApplicationResponse>().HasData(
                    new ApplicationResponse
                    {
                        MovieId = 1,
                        CategoryId = 4,
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
                        CategoryId = 4,
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
                        CategoryId = 2,
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
