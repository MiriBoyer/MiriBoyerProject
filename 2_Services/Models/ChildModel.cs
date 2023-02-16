using Entity.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Services.Models
{
    public class ChildModel
    {
        public string Name { get; set; }
        public string IdNumber { get; set; }
        public DateTime DOB { get; set; }
        //public UserModel Parent { get; set; }
    }
}
