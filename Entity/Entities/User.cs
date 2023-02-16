using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Entities
{
  

    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        [MaxLength(9)]
        [MinLength(9)]
        public string IdNumber { get; set; }
        [Required]
        public DateTime DOB { get; set; }
        [Required]
        public string gender { get; set; }
        [Required]
        public string HOM { get; set; }
        [Required]
        public ICollection<Child> Children { get; set; }
    }
}
