using AdvancedWebApiDotnet.Domain.Entities.Coment.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdvancedWebApiDotnet.Domain.Entities.Coment.Service
{
    public interface IComentService
    {
        List<ComentModel> GetAll();

        void Create(ComentModel model);
    }
}
