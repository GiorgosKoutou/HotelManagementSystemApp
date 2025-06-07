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

        [AttributeMarkerClasses.RequiredForValidation]
        [Column(TypeName = "varchar(100)")]
        [Display(Name = "Firts Name")]
        public string? FirstName { get; set; } = string.Empty;

        [AttributeMarkerClasses.RequiredForValidation]
        [Column(TypeName = "varchar(100)")]
        [Display(Name = "Last Name")]
        public string? LastName { get; set; } = string.Empty;

        [AttributeMarkerClasses.RequiredForValidation]
        [Column(TypeName = "varchar(100)")]
        [Display(Name = "Tax Identification Number")]
        public string? Tin { get; set; } = string.Empty;

        [Column(TypeName = "varchar(100)")]
        public string Country { get; set; } = string.Empty;

        [Column(TypeName = "varchar(100)")]
        public string City { get; set; } = string.Empty;

        [Column(TypeName = "varchar(100)")]
        public string Address { get; set; } = string.Empty;

        [Column(TypeName = "varchar(100)")]
        public string PhoneNumber { get; set; } = string.Empty;
    }
}
