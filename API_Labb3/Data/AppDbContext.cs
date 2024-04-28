using API_Labb3.Models;
using Microsoft.EntityFrameworkCore;

namespace API_Labb3.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Person> Persons { get; set; }
        public DbSet<Interest> Interests { get; set; }
        public DbSet<Link> Links { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>().HasData(
            new Person
            {
                PersonId = 1,
                Name = "Sanna Harrysson",
                PhoneNumber = "123456456"
            },
            new Person
            {
                PersonId = 2,
                Name = "Kalah Berggren",
                PhoneNumber = "5546654"
            },
            new Person
            {
                PersonId = 3,
                Name = "Göran Bengtsson",
                PhoneNumber = "5645221"
            }
            );

            modelBuilder.Entity<Interest>().HasData(
             new Interest 
             { 
                 InterestId = 1, 
                 Title = "Cybersecurity", 
                 Description = "Protecting systems and data from digital attacks"
             },
             new Interest 
             { 
                 InterestId = 2, 
                 Title = "Data Science", 
                 Description = "Extracting knowledge and insights from structured and unstructured data"
             },
             new Interest 
             { 
                 InterestId = 3, 
                 Title = "Artificial Intelligence", 
                 Description = "Creating intelligent machines that react and work like humans" 
             },
             new Interest
             {
                 InterestId = 4, 
                 Title = "Web Development", 
                 Description = "Building and maintaining websites or web applications"
             });

            modelBuilder.Entity<Link>().HasData(
            new Link
            {
                Id = 1,
                Url = "https://www.datasciencecentral.com/",
                PersonId = 1,
                InterestId= 2
            },
            new Link
            {
                Id = 2,
                Url = "https://www.datasciencecentral.com/",
                PersonId = 2,
                InterestId = 2
            },
            new Link
            {
                Id = 3,
                Url = "https://www.datasciencecentral.com/",
                PersonId = 3,
                InterestId = 1
            },
            new Link
            {
                Id = 4,
                Url = "https://www.datasciencecentral.com/",
                PersonId = 2,
                InterestId = 4
            });
        }
    }
}
