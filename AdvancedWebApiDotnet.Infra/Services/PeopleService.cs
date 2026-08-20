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

        public void  Create(PeopleModel model)
        {
         _peopleRepository.Create(model);
        }
        public void Update(PeopleModel model)
        {
            _peopleRepository.Update(model);
        }

        public void Delete(Guid Id)
        {
            _peopleRepository.Delete(Id);
        }
    }
}
