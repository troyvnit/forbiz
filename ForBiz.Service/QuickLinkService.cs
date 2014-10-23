using ForBiz.Entities.Models;
using Repository.Pattern.Repositories;
using Service.Pattern;

namespace ForBiz.Service
{
    public interface IQuickLinkService : IService<QuickLink>
    {
    }

    public class QuickLinkService : Service<QuickLink>, IQuickLinkService
    {
        public QuickLinkService(IRepositoryAsync<QuickLink> quickLinkRepository) : base(quickLinkRepository)
        {
        }
    }
}
