using AdvancedWebApiDotnet.Domain.Entities.Common.Model;
using AdvancedWebApiDotnet.Domain.Entities.People.Model;
using AdvancedWebApiDotnet.Domain.Entities.Posts.Model;

namespace AdvancedWebApiDotnet.Domain.Entities.Comments.Model
{
    public class CommentsModel : EntityModel
    {
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? LastUpdatedDate { get; set; }

        public Guid PostId { get; set; }  
        public PostModel? Post { get; set; }

        public Guid PeopleId { get; set; }
        public PeopleModel? People { get; set; }
    }
}
