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

        
        public int RoomTypeId { get; set; }
        public int RoomType { get; set; }
        public TypeCatgory RoomTypeCategory { get; set; } = null!;
    }
}
