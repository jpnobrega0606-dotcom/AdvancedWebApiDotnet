using AdvancedWebApiDotnet.Domain.Entities.Common.Repository;
using AdvancedWebApiDotnet.Domain.Entities.Posts.Model;

namespace AdvancedWebApiDotnet.Domain.Entities.Posts.Repository
{
    public interface IPostRepository: IBaseRepository<PostModel>
    {
    }
}
