using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository.Pattern.Ef6;

namespace ForBiz.Entities.Models
{
    public class ArticleCategory : Entity
    {
        public int ArticleCategoryId { get; set; }
        public string ArticleCategoryName { get; set; }
        public bool IsActived { get; set; }
        public ICollection<Article> Articles { get; set; } 
    }
}
