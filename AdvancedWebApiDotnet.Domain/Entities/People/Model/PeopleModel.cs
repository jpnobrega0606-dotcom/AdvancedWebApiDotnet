using AdvancedWebApiDotnet.Domain.Entities.Posts.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdvancedWebApiDotnet.Domain.Entities.People.Model
{
    public class PeopleModel
    {
        public Guid Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Document { get; set; }


        //Relationship
        public IList<PostModel> Posts { get; set; } = new List<PostModel>();
    }
}
