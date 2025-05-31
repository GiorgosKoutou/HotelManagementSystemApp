using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.Models
{
    public class Staff
    {
        public int Id { get; set; }

        [Column(TypeName = "varchar(100)")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; } = string.Empty;

        [Column(TypeName = "varchar(100)")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; } = string.Empty;
        public TypeCategory Specialty { get; set; } = new();
        public string Description { get => Specialty.Description; }
    }
}
