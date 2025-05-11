using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelPmsUI.Extensions
{
    public static class FormPositionExtension
    {
        public static void CenterForm(this Form source, Form destination)
        {
            destination.StartPosition = FormStartPosition.Manual;
            destination.Location = new Point(
                (source.Location.X + (source.Width - destination.Width) / 2),
                (source.Location.Y + (source.Height - destination.Height) / 2));
        }
    }
}
