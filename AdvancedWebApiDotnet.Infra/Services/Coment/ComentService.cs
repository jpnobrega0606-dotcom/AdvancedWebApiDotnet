using AdvancedWebApiDotnet.Domain.Entities.Coment.Model;
using AdvancedWebApiDotnet.Domain.Entities.Coment.Repository;
using AdvancedWebApiDotnet.Domain.Entities.Coment.Service;
using System;
using System.Collections.Generic;
using System.Text;
using static AdvancedWebApiDotnet.Infra.Services.Coment.ComentService;

namespace AdvancedWebApiDotnet.Infra.Services.Coment
{
    public class ComentService
    {
        public class CommentService : IComentService
        {
            private readonly IComentRepository _commentRepository;

            public CommentService(IComentRepository commentRepository)
            {
                _commentRepository = commentRepository;
            }

            public void Create(ComentModel model)
            {
                _commentRepository.Create(model);
            }

            public List<ComentModel> GetAll()
            {
                return _commentRepository.GetAll();
            }
        }
    }
}
