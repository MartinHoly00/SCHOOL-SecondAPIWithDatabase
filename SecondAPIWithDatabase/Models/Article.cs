using System.ComponentModel.DataAnnotations;

namespace SecondAPIWithDatabase.Models
{
    public class Article
    {
        public int ArticleId {  get; set; }
        [Required]
        public required string Title { get; set; }
        [Required]
        public required string Content { get; set; }
        public List<Comment> Comments { get; set; } = [];
    }
}
