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
    public class Room
    {
        public int Id { get; set; }

        [Column(TypeName = "varchar(20)")]
        [Display(Name = "Room Number")]
        [AttributeMarkerClasses.RequiredForValidation]
        public string RoomNumber { get; set; } = string.Empty;

        [Display(Name = "Floor")]
        [AttributeMarkerClasses.RequiredForValidation]
        public int Floor { get; set; }

        [Display(Name = "Bed Number")]
        [AttributeMarkerClasses.RequiredForValidation]
        public int BedNumber { get; set; }

        [Display(Name = "Bath Number")]
        [AttributeMarkerClasses.RequiredForValidation]
        public int BathNumber { get; set; }

        public TypeCategory RoomTypeCategory { get; set; } = new();

        public string Description { get => RoomTypeCategory.Description; }
    }
}
