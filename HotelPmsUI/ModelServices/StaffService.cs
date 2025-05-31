using DataAccessLibrary.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelPmsUI.ModelServices
{
    public class StaffService : BaseService<DataAccessLibrary.Models.Staff, Forms.Staff.StaffCrudForm, Forms.Staff.StaffListForm>
    {
        public StaffService(HpmsDbContext context) : base(context)
        {
            var table = context.Staff.Include(i => i.Specialty).OrderBy(s => s.Id);
            SetRecords(table);
        }
    }
}
