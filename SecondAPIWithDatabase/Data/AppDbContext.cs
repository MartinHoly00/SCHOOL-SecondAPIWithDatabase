using Microsoft.EntityFrameworkCore;
using SecondAPIWithDatabase.Models;
using System.Linq.Expressions;

namespace SecondAPIWithDatabase.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options) { }
        public DbSet<Article> Articles { get; set; }

        //pri vytvoreni databaze prida tyto 2 clanky
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Article>().HasData
            (
                new Article
                {
                    ArticleId = 1,
                    Title = "Test",
                    Content = "Test kdnfklS DŮsdlů kslůdk asůlk s"
                },
                new Article
                {
                    ArticleId = 2,
                    Title = "Test",
                    Content = "oahioasjpfa jaopfaops sjfpjas sjafjasklfj aklsjfkla jfkljaklf "

                }
            );
            modelBuilder.Entity<Comment>().HasData
            (
                new Comment
                {
                    CommentId = 1,
                    ArticleId = 1,
                    CommentText = "Test1",
                },
                new Comment
                {
                    CommentId = 2,
                    ArticleId = 1,
                    CommentText = "Test2",
                }
            );
        }
        public DbSet<SecondAPIWithDatabase.Models.Comment> Comment { get; set; } = default!;

    }
}
