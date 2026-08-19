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

        public PeopleModel CreatePeople(PeopleModel people)
        {
            return _peopleRepository.Create(people);
        }
    }
}
