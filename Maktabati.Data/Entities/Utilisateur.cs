using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maktabati.Data.Entities
{
    public class Utilisateur
    {
        [Key]
        public int Id { get; set; }
        public required string Nom { get; set; }
        public required string Email { get; set; }
        public required string MotDePasse { get; set; }
    }
}
