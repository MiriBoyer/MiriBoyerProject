using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Entities
{
    public class Child
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [MaxLength(9)]
        [MinLength(9)]
        public string IdNumber { get; set; }
        [Required]
        public DateTime DOB { get; set; }
    }
}
