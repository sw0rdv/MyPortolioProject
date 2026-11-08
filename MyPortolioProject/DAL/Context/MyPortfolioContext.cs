using Microsoft.EntityFrameworkCore;
using MyPortolioProject.DAL.Entitiy;
using MyPortolioProject.DAL.Entity;

namespace MyPortolioProject.DAL.Context
{
    public class MyPortfolioContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-DOR5KIU\SQLEXPRESS;Database=MyPortfolioDb;Integrated Security=True;TrustServerCertificate=True");
        }

        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<SocialMedia> SocialMedias { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Portfolio> Portfolios { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet <Feature> Features { get; set; }
        public DbSet<ToDoList> ToDoLists { get; set; }



    }
}
