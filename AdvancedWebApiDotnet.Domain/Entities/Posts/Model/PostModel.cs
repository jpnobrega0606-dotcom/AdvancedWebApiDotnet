using AdvancedWebApiDotnet.Domain.Entities.Comments.Model;
using AdvancedWebApiDotnet.Domain.Entities.Common.Model;
using AdvancedWebApiDotnet.Domain.Entities.People.Model;

namespace AdvancedWebApiDotnet.Domain.Entities.Posts.Model
{
    public class PostModel : EntityModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? LastUpdatedDate { get; set; }

        //Relationship
        public Guid PeopleId { get; set; }
        public PeopleModel? Persona { get; set; }

        public IList<CommentsModel> Comments { get; set; } = new List<CommentsModel>();
    }
}
