using System.Data.Entity;
using ForBiz.Entities.Migrations;
using ForBiz.Entities.Models;
using Repository.Pattern.Ef6;

namespace ForBiz.Entities
{
    public class ForBizContext : DataContext
    {
        public ForBizContext()
            : base("Name=ForBizContext")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<ForBizContext, Configuration>());
        }

        DbSet<Article> Articles { get; set; }
        DbSet<QuickLink> QuickLinks { get; set; } 
    }
}
