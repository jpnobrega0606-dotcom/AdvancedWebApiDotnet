using AdvancedWebApiDotnet.Domain.Entities.Coment.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdvancedWebApiDotnet.Domain.Entities.Coment.Repository
{
    public interface IComentRepository
    {
        List<ComentModel> GetAll();

        void Create(ComentModel model);
    }
}
