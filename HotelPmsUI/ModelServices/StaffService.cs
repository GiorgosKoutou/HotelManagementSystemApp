using DataAccessLibrary.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelPmsUI.ModelServices
{
    public class StaffService : BaseService<DataAccessLibrary.Models.Staff, 
                                            Forms.Staff.StaffCrudForm, Forms.Staff.StaffListForm,Forms.Staff.StaffFilterForm>
    {
        public StaffService(HpmsDbContext context) : base(context)
        {
            var table = context.Staff.Include(i => i.Specialty).OrderBy(s => s.Id);
            SetRecords(table);
        }

        public override void SaveData()
        {
            var currentRecord = (DataAccessLibrary.Models.Staff)BindingSource!.Current;
            currentRecord.FirstName = currentRecord.FirstName.Trim();
            currentRecord.LastName = currentRecord.LastName.Trim();

            StringBuilder messsage = CheckFields();
            if(messsage is not null)
            {
                MessageBox.Show(messsage.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            base.SaveData();
        }
    }
}
