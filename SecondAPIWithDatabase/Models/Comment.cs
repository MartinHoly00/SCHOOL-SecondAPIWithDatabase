using System.Text.Json.Serialization;

namespace SecondAPIWithDatabase.Models
{
    public class Comment
    {
        public int CommentId { get; set; }
        public required string CommentText { get; set; }

        public int User { get; set; }
        [JsonIgnore]
        public Article? Article { get; set; }
        public required int ArticleId { get; set; }
    }
}
