using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Pets.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Animals",
                columns: table => new
                {
                    AnimalId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: false),
                    Species = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: false),
                    Breed = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Gender = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Animals", x => x.AnimalId);
                });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "AnimalId", "Age", "Breed", "Gender", "Name", "Species" },
                values: new object[,]
                {
                    { 1, 5, "Unknown", "Female", "Frenchy", "Cat" },
                    { 2, 4, "Persian", "Female", "Pickels", "Cat" },
                    { 3, 3, "Husky", "Female", "Spot", "Dog" },
                    { 4, 1, "Great Dane", "Male", "Bisque", "Dog" },
                    { 5, 2, "German Shepherd", "Male", "Chicago", "Dog" },
                    { 6, 5, "Siamese", "Male", "Sammy", "Cat" },
                    { 7, 9, "Bulldog", "Female", "Baby", "Dog" },
                    { 8, 6, "Beagle", "Male", "Rufus", "Dog" },
                    { 9, 10, "Unknown", "Male", "Doug", "Cat" },
                    { 10, 1, "Mixed", "Female", "Lucy", "Dog" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Animals");
        }
    }
}
