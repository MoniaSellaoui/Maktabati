using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maktabati.Data.Entities
{
    public class Evaluation
    {
        [Key]
        public int Id { get; set; }
        public int Note { get; set; }
        public string Commentaire { get; set; }
        public DateTime Date { get; set; }

        // Relations
        public int LivreId { get; set; }
        [ForeignKey("LivreId")]
        public virtual Livre Livre { get; set; }

        public int MembreId { get; set; }
        [ForeignKey("MembreId")]
        public virtual Membre Membre { get; set; }
    }
}
