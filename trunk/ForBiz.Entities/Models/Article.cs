using System;
using System.Collections.Generic;
using Repository.Pattern.Ef6;

namespace ForBiz.Entities.Models
{
    public class Article : Entity
    {
        public int ArticleId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Content { get; set; }
        public string Tags { get; set; }
        public int OrderNumber { get; set; }
        public string Avatar { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime PublishedDate { get; set; }
        public string Author { get; set; }
        public ArticleType ArticleType { get; set; }
        public bool? IsActived { get; set; }
        public int ArticleSourceId { get; set; }
        public ArticleSource ArticleSource { get; set; }
        public ICollection<ArticleCategory> ArticleCategory { get; set; }
    }

    public enum ArticleType
    {
        Rss, ForBiz
    }
}
