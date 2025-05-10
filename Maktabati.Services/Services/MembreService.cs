using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Maktabati.Data.Entities;
using Maktabati.Data.Repositories;

namespace Maktabati.Services.Services
{
    public class MembreService
    {
        private readonly EmpruntRepository _empruntRepository;
        private readonly LivreRepository _livreRepository;

        public MembreService(EmpruntRepository empruntRepository, LivreRepository livreRepository)
        {
            _empruntRepository = empruntRepository;
            _livreRepository = livreRepository;
        }

       

      
    }
}
