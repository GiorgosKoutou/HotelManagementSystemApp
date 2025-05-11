using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.Models
{
    [PrimaryKey(nameof(id), nameof(Type))]
    public class TypeCatgory
    {
        public int id { get; set; }
        [Column(TypeName = "Varchar(20)")]
        public string Description { get; set; } = string.Empty;
        public int Type { get; set; }
    }
}
