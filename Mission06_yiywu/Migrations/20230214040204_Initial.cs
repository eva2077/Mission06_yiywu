using Microsoft.EntityFrameworkCore.Migrations;

namespace Mission06_yiywu.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ApplicationResponse",
                columns: table => new
                {
                    MovieId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Category = table.Column<string>(nullable: false),
                    Title = table.Column<string>(nullable: false),
                    Year = table.Column<int>(nullable: false),
                    Director = table.Column<string>(nullable: false),
                    Rating = table.Column<string>(nullable: false),
                    Edited = table.Column<bool>(nullable: false),
                    LentTo = table.Column<string>(nullable: true),
                    Notes = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationResponse", x => x.MovieId);
                });

            migrationBuilder.InsertData(
                table: "ApplicationResponse",
                columns: new[] { "MovieId", "Category", "Director", "Edited", "LentTo", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 1, "Romance", "steven", true, "Eva", "Best Movie of the Century", "G", "Pride and Prejudice", 2006 });

            migrationBuilder.InsertData(
                table: "ApplicationResponse",
                columns: new[] { "MovieId", "Category", "Director", "Edited", "LentTo", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 2, "Comedy", "Tom", true, "Eva", "Best Comedy of the Century", "G", "Parent Trap", 2000 });

            migrationBuilder.InsertData(
                table: "ApplicationResponse",
                columns: new[] { "MovieId", "Category", "Director", "Edited", "LentTo", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 3, "Inspiring", "Sylvie Ohayon", true, "Eva", "Wish it was as easy as that to get an internship", "PG-13", "Haute Couture", 2021 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ApplicationResponse");
        }
    }
}
