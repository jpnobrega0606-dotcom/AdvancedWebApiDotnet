using AdvancedWebApiDotnet.Domain.Entities.People.Model;
using AdvancedWebApiDotnet.Domain.Entities.Posts.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdvancedWebApiDotnet.Domain.Entities.Coment.Model
{
    public class ComentModel
    {
        public Guid Id { get; set; } 

        public string Description { get; set; }

        public Guid PostId { get; set; }  
        public PostModel Post { get; set; }

        public Guid PeopleId { get; set; }
        public PeopleModel People{ get; set; }

    }
}
