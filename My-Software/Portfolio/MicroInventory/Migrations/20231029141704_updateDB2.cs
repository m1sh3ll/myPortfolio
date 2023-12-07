using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MyInventory.Migrations
{
    /// <inheritdoc />
    public partial class updateDB2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Badges",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    ImageURL = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    Link = table.Column<string>(type: "TEXT", nullable: false),
                    DateIssued = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Badges", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    Price = table.Column<decimal>(type: "TEXT", nullable: false),
                    ImageURL = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    ImageURL = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    Link = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Badges",
                columns: new[] { "Id", "DateIssued", "Description", "ImageURL", "Link", "Title" },
                values: new object[,]
                {
                    { 1, "3/18/2022", "An earner of this badge has completed all courses in the Full Stack Web Development Certificate program. Badge milestones include Web Development Foundations, Frontend Web Applications, GIT Version Control, Problem Solving and Debugging, and Backend Web Applications", "https://images.credly.com/size/340x340/images/1f7dd028-5bec-41de-9a20-16fabfdb921f/FullStack.png", "https://www.credly.com/badges/42a9c661-0794-46ad-8836-28cb40067756/linked_in_profile", "Full Stack Web Developer (MERN)" },
                    { 2, "11/11/2022", "108-Hour program", "https://t3.nobledesktop.com/credential.php?format=jpg&id=f9175548-ce58-471f-be5e-e94a9c9107e4", "https://www.nobledesktop.com/credentials/f9175548-ce58-471f-be5e-e94a9c9107e4", "Front-End Web Development Certificate" },
                    { 3, "3/18/2022", "An earner of this badge has demonstrated the ability to create, populate and interact with servers (e.g. Node, Express), relational databases, (e.g. Mongo) and non-relational databases (e.g. PostgresSQL).", "https://images.credly.com/size/340x340/images/47c07f67-217a-422d-9cab-ba45f8414ac9/BackEnd.png", "https://www.credly.com/badges/aaa042a9-9858-4974-bd9b-76916cc835c1/linked_in_profile", "Back-End Web Applications" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageURL", "Price", "Title" },
                values: new object[,]
                {
                    { 1, "This item has female to female jacks. Just plug one cable into the front and one into the back. Screws included.", "https://www.ftpzero.com/temp-test/1-HDMI-WALL.jpg", 9.95m, "HDMI Wall Plate White" },
                    { 2, "This item has female to female jacks. Just plug one cable into the front and one into the back. Screws included.", "https://www.ftpzero.com/temp-test/1-CAT6-WALL.jpg", 7.95m, "Cat6 Wall Plate White" },
                    { 3, "This item has female to female jacks. Just plug one cable into the front and one into the back. Screws included.", "https://www.ftpzero.com/temp-test/1-CAT7-WALL.jpg", 11.95m, "Cat7 Wall Plate White" }
                });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "Description", "ImageURL", "Link", "Title" },
                values: new object[,]
                {
                    { 1, "This program is built in C# .NET using ASP.net MVC. It uses .NET Core 7.0 and Microsoft Identity technology. It uses SQLite to store the products and connects to SQL Server for a user identity server. There is an admin page where the admin logs in and can create, edit, update, and delete products.", "https://www.michellenesbitt.com/images/myinv.jpg", "/Projects/Details/1", "My Inventory ASP.NET Core MVC" },
                    { 2, "This program is built in VB.NET and C#.NET. It is a Windows forms app for Windows desktops to do basic tasks for my job. I created this as a wall plate builder to create wall plate images dynamically. It is one of the custom products that we sell at my job. FTP Upload is incorporated into the program as well. This program also creates Amazon, Ebay, and Shopify product feeds for download. Employees can then upload the feeds to the channels. The products will then be advertised for sale after upload of the feeds. I did all the product photos myself for each individual wall plate part.", "https://www.michellenesbitt.com/images/wpb2023.jpg", "/Projects/Details/2", "Micro Plate Full" },
                    { 3, "This program was started in 2016 and is built in VB .NET. It is a Windows desktop app that creates custom wall plate images for my job. It opens a preview and you can save the image to your drive. The program also sends the images to FTP so that we can list the products online. It saves the history of each plate made into a flat file. You can later open that flat file and preview all of the plates that were made. This program has several modes including plates up to 4 Gangs as well as patch panels and UK plate styles. I did all the product photos myself for each individual wall plate part. I did all the Photoshop myself which includes about 1000 individual wall plate image combos and parts.", "https://www.michellenesbitt.com/images/microplate2022.jpg", "/Projects/Details/3", "Micro Plate" },
                    { 4, "This program was built in VB6 (originally) and migrated to .NET. It is a fully featured practice exams program for IT Certification exams. It was created for NetworkDesigner.net, an online practice exams blog. The exams were later packaged and sold on CD on the site and on eBay. The questions are held in an Access database bank. Examples of questions are input type (by entering commands), multiple choice, multiple answer, look at exhibit, true/false, and more, The program includes flashcards and an exam editor to create exams.", "https://www.michellenesbitt.com/images/nerdomcertexams.jpg", "/Projects/Details/4", "Nerdom Cert Exams CCNA/CCNP/A+/Network+ Practice Exams" },
                    { 5, "This program is built in C# .NET using ASP.net MVC. It uses .NET Core 7.0 and Microsoft Identity technology. It uses SQLite to store the projects and badges and connects to SQL Server for a user identity server. There is an admin page where the admin logs in and can create, edit, update, and delete badges and projects. When the link to the portfolio is shared, none of the admin functions are available without logging in.", "https://www.michellenesbitt.com/images/myportfolio.jpg", "/Projects/Details/5", "My Portfolio 2.0" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Badges");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Projects");
        }
    }
}
