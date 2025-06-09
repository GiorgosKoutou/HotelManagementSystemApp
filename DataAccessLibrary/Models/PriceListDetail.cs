using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.Models
{
    public class PriceListDetail
    {
        public int Id { get; set; }
        public int RoomTypeId { get; set; }
        public double Price { get; set; }

        public int PriceListId { get; set; }
        public PriceList PriceList { get; set; } = null!;

    }
}
