using AdvancedWebApiDotnet.Domain.Entities.People.Model;

namespace AdvancedWebApiDotnet.Domain.Entities.People.Repository
{
    public interface IPeopleRepository
    {
        IList<PeopleModel> GetAll();
        void Create(PeopleModel model);
        void Update(PeopleModel model);
        void Delete(Guid Id );
        PeopleModel GetById(Guid id);
    }
}

