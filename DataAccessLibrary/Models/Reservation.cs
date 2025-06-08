using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.Models
{
    public class Reservation
    {
        public int Id { get; set; }

        [Column(TypeName = "datetime(0)")]
        public DateTime ReservationDateFrom { get; set; }

        [Column(TypeName = "datetime(0)")]
        public DateTime ReservationDateTo { get; set; }

        [Column(TypeName = "datetime(0)")]
        public DateTime? CheckInDate { get; set; }

        [Column(TypeName = "datetime(0)")]
        public DateTime? CheckOutDate { get; set; }
        public double ReservationPrice { get; set; }
        public bool IsCanceled { get; set; }

        public Customer Customer { get; set; } = new();
        public Room Room { get; set; } = new();


        public string CustomerFullname { get => $"{Customer.FirstName} {Customer.LastName}"; }
        public string RoomNumber { get => Room.RoomNumber; }
    }
}
