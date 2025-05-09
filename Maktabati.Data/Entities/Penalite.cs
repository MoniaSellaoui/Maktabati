using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maktabati.Data.Entities
{
    public class Penalite
    {
        [Key]
        public int Id { get; set; }
        public float Montant { get; set; }
        public DateTime Date { get; set; }
        public bool EstPayee { get; set; }

        // Relation one-to-one avec Emprunt
        public int EmpruntId { get; set; }
        [ForeignKey("EmpruntId")]
        public virtual required Emprunt Emprunt { get; set; }
    }
}
