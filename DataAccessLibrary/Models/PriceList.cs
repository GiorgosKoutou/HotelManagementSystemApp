using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.Models
{
    public class PriceList
    {
        public int Id { get; set; }
        public string? Description { get; set; } = string.Empty;
        public Period Period { get; set; } = new();
        public ICollection<PriceListDetail> Details { get; } = [];

        public string PeriodName { get => Period.Name!; }
    }
}
