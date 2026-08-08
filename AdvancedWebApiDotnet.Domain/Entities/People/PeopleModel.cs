using System;
using System.Collections.Generic;
using System.Text;

namespace AdvancedWebApiDotnet.Domain.Entities.People
{
    public class PeopleModel
    {
        public Guid Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Document { get; set; }
    }
}
