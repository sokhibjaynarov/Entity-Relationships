using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using vazifa0224.Models;

namespace vazifa0224.Data
{
    internal class AppDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Group> Groups { get; set; } 
        public DbSet<Subject> Subjects { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB; Database=vazifa0224;Trusted_Connection=True;");
        }

        /*protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Subject>().HasData(new List<Subject>
            {
                new Subject { Id = 1, Name = "DotNet" },
                new Subject { Id = 2, Name = "Java" },
                new Subject { Id = 3, Name = "Go" },
            });

            modelBuilder.Entity<Teacher>().HasData(new List<Teacher>
            {
                new Teacher { Id = 1, Name = "Sohib", Email = "sohib@gmail.com", SubjectId = 1 },
                new Teacher { Id = 2, Name = "Ruslan", Email = "ruslan@gmail.com", SubjectId = 2 },
                new Teacher { Id = 3, Name = "Husniddin", Email = "husniddin@gmail.com", SubjectId = 3 },
            });

            modelBuilder.Entity<Group>().HasData(new List<Group>
            {
                new Group { Id = 1, Name = "Go Bootcamp" },
                new Group { Id = 2, Name = "Java Bootcamp" },
                new Group { Id = 3, Name = "DotNet Bootcamp" },
            });

            modelBuilder.Entity<Student>().HasData(new List<Student>
            {
                new Student { Id = 1, Name = "Muhammadabdulloh", Email = "muhammadabdulloh@gmail.com", GroupId = 1 },
                new Student { Id = 2, Name = "Akbar", Email = "akbar@gmail.com", GroupId = 2 },
                new Student { Id = 3, Name = "Tohirjon" +
                "", Email = "tohirjon@gmail.com", GroupId = 3 },
            });
        }*/
    }
}
