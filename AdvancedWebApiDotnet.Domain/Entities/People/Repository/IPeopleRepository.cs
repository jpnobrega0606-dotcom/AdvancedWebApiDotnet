using AdvancedWebApiDotnet.Domain.Entities.People.Model;

namespace AdvancedWebApiDotnet.Domain.Entities.People.Repository
{
    public interface IPeopleRepository
    {
        IList<PeopleModel> GetAll();
    }
}
