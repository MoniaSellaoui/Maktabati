using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maktabati.Data.Entities
{
    public class Notification
    {
        [Key]
        public int Id { get; set; }
        public string Type { get; set; }
        public string Contenu { get; set; }
        public DateTime DateEnvoi { get; set; }

        // Relations
        public int MembreId { get; set; }
        [ForeignKey("MembreId")]
        public virtual Membre Membre { get; set; }
    }
}
