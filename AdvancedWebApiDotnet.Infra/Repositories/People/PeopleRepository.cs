using AdvancedWebApiDotnet.Domain.Entities.People.Model;
using AdvancedWebApiDotnet.Domain.Entities.People.Repository;
using AdvancedWebApiDotnet.Infra.Storage.Database.SqlServer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdvancedWebApiDotnet.Infra.Repositories.People
{
    public class PeopleRepository : IPeopleRepository
    {
        private SqlServerContext _sqlServerContext;

        public PeopleRepository(SqlServerContext context)
        {
            _sqlServerContext = context;
        }

        public IList<PeopleModel> GetAll()
        {
            return _sqlServerContext.People.Include(x => x.Posts).ToList();
        }

        public void Create(PeopleModel people)
        {
            _sqlServerContext.People.Add(people);
            _sqlServerContext.SaveChanges();

         
        } 
        public void Update(PeopleModel people)
        {
            var peoplePersisted = _sqlServerContext.People.Find(people.Id);

            peoplePersisted.Document = people.Document;
            peoplePersisted.FirstName = people.FirstName;
            peoplePersisted.LastName = people.LastName;
            
            _sqlServerContext.People.Update(peoplePersisted);
            _sqlServerContext.SaveChanges();
        }
         
        public void Delete(Guid Id)
        {
            var people = _sqlServerContext.People.Find(Id);
            
            if (people != null)
            {
                _sqlServerContext.People.Remove(people);
                _sqlServerContext.SaveChanges();
            }
        }

        public PeopleModel GetById(Guid id)
        {
           return _sqlServerContext.People.Find(id);
        }
    }
}
