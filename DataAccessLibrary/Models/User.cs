using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.Models
{
    [Index(nameof(UserName), IsUnique = true)]
    public class User
    { 
        public int Id { get; set; }

        [Required]
        [Display(Name = "User Name")]
        [Column(TypeName = "varchar(100)")]
        public string UserName { get; set; } = string.Empty;

        [Required]
        [Display(Name = "Password")]
        [Column(TypeName = "varchar(100)")]
        public string Password { get; set; } = string.Empty;

        [DataAccessLibrary.AttributeMarkerClasses.RequiredForValidation]
        [Display(Name = "Full Name")]
        [Column(TypeName = "varchar(100)")]
        public string? FullName { get; set; } = string.Empty;
        public TypeCategory UserRole { get; set; } = new();

        public string Description { get => UserRole.Description; }
    }
}
