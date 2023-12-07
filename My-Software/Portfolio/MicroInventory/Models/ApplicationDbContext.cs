using Microsoft.EntityFrameworkCore;
using MyInventory.Controllers;
using MyInventory.Migrations;

namespace MyInventory.Models
{
  public class ApplicationDbContext : DbContext
  {
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
    public DbSet<Product> Products { get; set; }
    public DbSet<Project> Projects { get; set; }
    public DbSet<Badge> Badges { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder
          .EnableSensitiveDataLogging();
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      base.OnModelCreating(modelBuilder);

      modelBuilder.Entity<Product>().HasData(
      new Product
      {
        Id = 1,
        Title = "HDMI Wall Plate White",
        Price = 9.95m,
        ImageURL = "https://www.ftpzero.com/temp-test/1-HDMI-WALL.jpg",
        Description="This item has female to female jacks. Just plug one cable into the front and one into the back. Screws included."
      },
      new Product
      {
        Id = 2,
        Title = "Cat6 Wall Plate White",
        Price = 7.95m,
        ImageURL = "https://www.ftpzero.com/temp-test/1-CAT6-WALL.jpg",
        Description = "This item has female to female jacks. Just plug one cable into the front and one into the back. Screws included."
      },
      new Product
      {
        Id = 3,
        Title = "Cat7 Wall Plate White",
        Price = 11.95m,
        ImageURL = "https://www.ftpzero.com/temp-test/1-CAT7-WALL.jpg",
        Description= "This item has female to female jacks. Just plug one cable into the front and one into the back. Screws included."
      }

      );

      modelBuilder.Entity<Project>().HasData(
      new Project
      {
        Id = 1,
        Title = "My Inventory ASP.NET Core MVC",
        ImageURL = "https://www.michellenesbitt.com/images/myinv.jpg",
        Description = "This program is built in C# .NET using ASP.net MVC. It uses .NET Core 7.0 and Microsoft Identity technology. It uses SQLite to store the products and connects to SQL Server for a user identity server. There is an admin page where the admin logs in and can create, edit, update, and delete products.",
        Link = "/Projects/Details/1"
      },
      new Project
      {
        Id = 2,
        Title = "Micro Plate Full",       
        ImageURL = "https://www.michellenesbitt.com/images/wpb2023.jpg",
        Description = "This program is built in VB.NET and C#.NET. It is a Windows forms app for Windows desktops to do basic tasks for my job. " +
        "I created this as a wall plate builder to create wall plate images dynamically. " +
        "It is one of the custom products that we sell at my job. " +
        "FTP Upload is incorporated into the program as well. " +
        "This program also creates Amazon, Ebay, and Shopify product feeds for download. " +
        "Employees can then upload the feeds to the channels. The products will then be advertised for sale after upload of the feeds. I did all the product photos myself for each individual wall plate part.",
        Link="/Projects/Details/2"
      },
      new Project
      {
        Id = 3,
        Title = "Micro Plate",
        ImageURL = "https://www.michellenesbitt.com/images/microplate2022.jpg",
        Description = "This program was started in 2016 and is built in VB .NET. It is a Windows desktop app that creates custom wall plate images for my job. It opens a preview and you can save the image to your drive. The program also sends the images to FTP so that we can list the products online. It saves the history of each plate made into a flat file. You can later open that flat file and preview all of the plates that were made. This program has several modes including plates up to 4 Gangs as well as patch panels and UK plate styles. I did all the product photos myself for each individual wall plate part. I did all the Photoshop myself which includes about 1000 individual wall plate image combos and parts.",
        Link = "/Projects/Details/3"
      },
      new Project
      {
        Id = 4,
        Title = "Nerdom Cert Exams CCNA/CCNP/A+/Network+ Practice Exams",        
        ImageURL = "https://www.michellenesbitt.com/images/nerdomcertexams.jpg",
        Description = "This program was built in VB6 (originally) and migrated to .NET. It is a fully featured practice exams program for IT Certification exams. It was created for NetworkDesigner.net, an online practice exams blog. The exams were later packaged and sold on CD on the site and on eBay. The questions are held in an Access database bank. Examples of questions are input type (by entering commands), multiple choice, multiple answer, look at exhibit, true/false, and more, The program includes flashcards and an exam editor to create exams.",
        Link = "/Projects/Details/4"
      },
      new Project
      {
        Id = 5,
        Title = "My Portfolio 2.0",
        ImageURL = "https://www.michellenesbitt.com/images/myportfolio.jpg",
        Description = "This program is built in C# .NET using ASP.net MVC. It uses .NET Core 7.0 and Microsoft Identity technology. It uses SQLite to store the projects and badges and connects to SQL Server for a user identity server. There is an admin page where the admin logs in and can create, edit, update, and delete badges and projects. When the link to the portfolio is shared, none of the admin functions are available without logging in.",
        Link = "/Projects/Details/5"
      }
      );


      modelBuilder.Entity<Badge>().HasData(
      new Badge
      {
        Id = 1,
        Title = "Full Stack Web Developer (MERN)",
        ImageURL = "https://images.credly.com/size/340x340/images/1f7dd028-5bec-41de-9a20-16fabfdb921f/FullStack.png",
        Description = "An earner of this badge has completed all courses in the Full Stack Web Development Certificate program. Badge milestones include Web Development Foundations, Frontend Web Applications, GIT Version Control, Problem Solving and Debugging, and Backend Web Applications",
        Link = "https://www.credly.com/badges/42a9c661-0794-46ad-8836-28cb40067756/linked_in_profile",
        DateIssued="3/18/2022"

      },
      new Badge
      {
        Id = 2,
        Title = "Front-End Web Development Certificate",
        ImageURL = "https://t3.nobledesktop.com/credential.php?format=jpg&id=f9175548-ce58-471f-be5e-e94a9c9107e4",
        Description = "108-Hour program",
        Link = "https://www.nobledesktop.com/credentials/f9175548-ce58-471f-be5e-e94a9c9107e4",
        DateIssued = "11/11/2022"
      },
      new Badge
      {
        Id = 3,
        Title = "Back-End Web Applications",
        ImageURL = "https://images.credly.com/size/340x340/images/47c07f67-217a-422d-9cab-ba45f8414ac9/BackEnd.png",
        Description = "An earner of this badge has demonstrated the ability to create, populate and interact with servers (e.g. Node, Express), relational databases, (e.g. Mongo) and non-relational databases (e.g. PostgresSQL).",
        Link = "https://www.credly.com/badges/aaa042a9-9858-4974-bd9b-76916cc835c1/linked_in_profile",
        DateIssued = "3/18/2022"

      }

      );

    }
  }
}
