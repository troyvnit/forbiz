using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository.Pattern.Ef6;

namespace ForBiz.Entities.Models
{
    public class ArticleSource : Entity
    {
        public int ArticleSourceId { get; set; }
        public string ArticleSourceName { get; set; }
        public string SourceLink { get; set; }
        public ICollection<Article> Articles { get; set; }
    }
}
