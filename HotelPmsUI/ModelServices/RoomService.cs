using DataAccessLibrary.Context;
using DataAccessLibrary.Models;
using HotelPmsUI.Forms.Room;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelPmsUI.ModelServices
{
    public class RoomService : BaseService<DataAccessLibrary.Models.Room,
                                            Forms.Room.RoomCrudForm, Forms.Room.RoomListForm,Forms.Room.RoomFilterForm>
    {
        public RoomService(HpmsDbContext context) : base(context) 
        {
            var table = context.Rooms
                                .Include(r => r.RoomTypeCategory)
                                .OrderBy(r => r.Id);
            //var table = context.Rooms.Where(r => r.RoomTypeCategory.Description.Equals("Quad Room")).Include(i => i.RoomTypeCategory);
            SetRecords(table);

            
        }

        public override void SaveData()
        {
            var currentRecord = (DataAccessLibrary.Models.Room)BindingSource!.Current;
            currentRecord.RoomNumber = currentRecord.RoomNumber.Trim();

            var roomNumberExists = Context.Rooms.FirstOrDefault(r => r.RoomNumber == currentRecord.RoomNumber);

            var entry = Context.Entry(currentRecord);

            StringBuilder message = CheckFields();
            if (message != null)
            {
                MessageBox.Show(message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (entry.State == EntityState.Modified)
            {
                base.SaveData();
                return;
            }


            if (roomNumberExists is not null)
            {
                MessageBox.Show("Room Number Exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ((Room)BindingSource!.Current).RoomTypeCategory.Type = 2;
            base.SaveData();
        }

        public override void NewData()
        {
            
            base.NewData();
        }

            
    }

}
