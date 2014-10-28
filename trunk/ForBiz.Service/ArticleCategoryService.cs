using ForBiz.Entities.Models;
using Repository.Pattern.Repositories;
using Service.Pattern;

namespace ForBiz.Service
{
    public interface IArticleCategoryService : IService<ArticleCategory>
    {
    }

    public class ArticleCategoryService : Service<ArticleCategory>, IArticleCategoryService
    {
        public ArticleCategoryService(IRepositoryAsync<ArticleCategory> articleCategoryRepository)
            : base(articleCategoryRepository)
        {
        }
    }
}
