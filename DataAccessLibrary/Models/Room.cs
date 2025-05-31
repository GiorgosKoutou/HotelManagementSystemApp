using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.Models
{
    public class Room
    {
        public int Id { get; set; }

        [Column(TypeName = "varchar(20)")]
        public string RoomNumber { get; set; } = string.Empty;
        public int Floor { get; set; }
        public int BedNumber { get; set; }
        public int BathNumber { get; set; }

        public TypeCategory RoomTypeCategory { get; set; } = new();

        public string Description { get => RoomTypeCategory.Description; }
    }
}
