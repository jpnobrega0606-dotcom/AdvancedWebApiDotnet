using AdvancedWebApiDotnet.Domain.Entities.People.Model;

namespace AdvancedWebApiDotnet.Domain.Entities.People.Service
{
    public interface IPeopleService
    {
        IList<PeopleModel> GetAllPeople();
    }
}
