using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        [Display(Name = "Firts Name")]
        public required string FirstName { get; set; } = string.Empty;

        [Required]
        [Column(TypeName = "varchar(50)")]
        [Display(Name = "Last Name")]
        public required string LastName { get; set; } = string.Empty;

        [Required]
        [Column(TypeName = "varchar(50)")]
        [Display(Name = "Tax Identification Number")]
        public required string Tin { get; set; } = string.Empty;

        [Column(TypeName = "varchar(50)")]
        public string Country { get; set; } = string.Empty;

        [Column(TypeName = "varchar(50)")]
        public string City { get; set; } = string.Empty;

        [Column(TypeName = "varchar(50)")]
        public string Address { get; set; } = string.Empty;

        [Column(TypeName = "varchar(50)")]
        public string PhoneNumber { get; set; } = string.Empty;
    }
}
