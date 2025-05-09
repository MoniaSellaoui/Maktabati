using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maktabati.Data.Entities
{
    public class Emprunt
    {
        [Key]
        public int Id { get; set; }
        public DateTime DateEmprunt { get; set; }
        public DateTime DateRetourPrevue { get; set; }
        public DateTime? DateRetourEffective { get; set; }

        // Relations
        public int LivreId { get; set; }
        [ForeignKey("LivreId")]
        public virtual required Livre Livre { get; set; }

        public int MembreId { get; set; }
        [ForeignKey("MembreId")]
        public virtual required Membre Membre { get; set; }

        // Relation optionnelle avec Penalite (0..1)
        public virtual Penalite? Penalite { get; set; }
    }
}


