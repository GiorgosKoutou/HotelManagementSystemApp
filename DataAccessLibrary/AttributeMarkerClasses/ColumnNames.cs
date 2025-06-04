using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.AttributeMarkerClasses
{
    [AttributeUsage(AttributeTargets.Property)]
    public class ColumnNames : Attribute
    {
        public string? Name { get; set; }
    }
}
