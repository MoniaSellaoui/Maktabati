using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maktabati.Data.Entities
{
    public class Livre
    {
        [Key]
        public int Id { get; set; }
        public string Titre { get; set; }
        public string Auteur { get; set; }
        public string Isbn { get; set; }
        public string Statut { get; set; }
        public string Categorie { get; set; }

        // Relations
        public virtual ICollection<Emprunt> Emprunts { get; set; }
        public virtual ICollection<Reservation> Reservations { get; set; }
      

        public Livre()
        {
            Emprunts = new HashSet<Emprunt>();
            Reservations = new HashSet<Reservation>();
          
        }
    }
}
