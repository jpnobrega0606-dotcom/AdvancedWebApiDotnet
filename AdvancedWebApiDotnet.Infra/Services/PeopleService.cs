using AdvancedWebApiDotnet.Domain.Entities.People.Model;
using AdvancedWebApiDotnet.Domain.Entities.People.Repository;
using AdvancedWebApiDotnet.Domain.Entities.People.Service;

namespace AdvancedWebApiDotnet.Infra.Services
{
    public class PeopleService : IPeopleService
    {
        private IPeopleRepository _peopleRepository;

        public PeopleService(IPeopleRepository peopleRepository)
        {
            _peopleRepository = peopleRepository;
        }

        public IList<PeopleModel> GetAllPeople()
        {
            return _peopleRepository.GetAll();
        }

        public void  Create(IPeopleRepository peopleRepository)
        {
            return _peopleRepository.Create(PeopleModel);
        }
    }
}
