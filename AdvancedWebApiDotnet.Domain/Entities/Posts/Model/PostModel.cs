using AdvancedWebApiDotnet.Domain.Entities.People.Model;
using System.ComponentModel;

namespace AdvancedWebApiDotnet.Domain.Entities.Posts.Model
{
    public class PostModel
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Datetime { get; set; }
        
        //Relationship
        public Guid PeopleId { get; set; }
        public PeopleModel? Persona { get; set; }
    }
}
