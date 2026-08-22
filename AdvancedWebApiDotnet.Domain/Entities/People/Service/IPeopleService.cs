using AdvancedWebApiDotnet.Domain.Entities.People.Model;

namespace AdvancedWebApiDotnet.Domain.Entities.People.Service
{
    public interface IPeopleService
    {
        IList<PeopleModel> GetAllPeople();
        void Create(PeopleModel model);
        void Update(PeopleModel model);
        void Delete(Guid Id);
        PeopleModel GetById(Guid id);
    }

}
