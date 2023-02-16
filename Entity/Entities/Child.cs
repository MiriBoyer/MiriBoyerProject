using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Entities
{
    public class Child
    {//vcvcvc
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string IdNumber { get; set; }
        public DateTime DOB { get; set; }
        //public User Parent { get; set; }
    }
}
