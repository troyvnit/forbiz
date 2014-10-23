using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository.Pattern.Ef6;

namespace ForBiz.Entities.Models
{
    public class QuickLink : Entity
    {
        public int QuickLinkId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Link { get; set; }
        public int OrderNumber { get; set; }
        public string Avatar { get; set; }
        public Position Position { get; set; }
        public Page Page { get; set; }
    }

    public enum Position
    {
        Left, Right, Center
    }

    public enum Page
    {
        Home, Article
    }
}
