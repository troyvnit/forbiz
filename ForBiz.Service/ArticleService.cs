using ForBiz.Entities.Models;
using Repository.Pattern.Repositories;
using Service.Pattern;

namespace ForBiz.Service
{
    public interface IArticleService : IService<Article>
    {
    }

    public class ArticleService : Service<Article>, IArticleService
    {
        public ArticleService(IRepositoryAsync<Article> articleRepository) : base(articleRepository)
        {
        }
    }
}
