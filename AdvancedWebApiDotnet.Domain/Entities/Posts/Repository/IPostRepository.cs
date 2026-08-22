using AdvancedWebApiDotnet.Domain.Entities.Posts.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdvancedWebApiDotnet.Domain.Entities.Posts.Repository
{
    public interface IPostRepository
    {
        IList<PostModel> GetAll();
        void Create(PostModel model);
    }
}
