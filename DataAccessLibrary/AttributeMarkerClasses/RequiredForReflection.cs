using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.AttributeMarkerClasses
{
    /// <summary>
    /// Attribute used to mark properties that must be included during reflection-based operations.
    /// This is typically applied to properties that are required for dynamic processing,
    /// such as serialization, mapping, or other runtime inspection scenarios.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    public class RequiredForReflection : Attribute
    {
    }
}
