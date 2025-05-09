using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maktabati.Data.Entities
{
    public class Membre : Utilisateur
    {
        public bool AbonnementActif { get; set; }

        // Relations
        public virtual ICollection<Emprunt> Emprunts { get; set; }
        public virtual ICollection<Reservation> Reservations { get; set; }
   
        public virtual ICollection<Notification> Notifications { get; set; }

        public Membre()
        {
            Emprunts = new HashSet<Emprunt>();
            Reservations = new HashSet<Reservation>();
        
            Notifications = new HashSet<Notification>();
        }
    }
}

