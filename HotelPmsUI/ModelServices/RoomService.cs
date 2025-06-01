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
    public class RoomService : BaseService<DataAccessLibrary.Models.Room, Forms.Room.RoomCrudForm, Forms.Room.RoomListForm>
    {
        public RoomService(HpmsDbContext context) : base(context) 
        {
            var table = context.Rooms
                                .Include(r => r.RoomTypeCategory)
                                .OrderBy(r => r.Id);
            SetRecords(table);
        }

        public override void SaveData()
        {
            StringBuilder message = CheckFields();
            if (message != null) 
            {
                MessageBox.Show(message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ((Room)BindingSource!.Current).RoomTypeCategory.Type = 2;
            base.SaveData();
        }

        public override void NewData()
        {
            
            base.NewData();
            //formCrud!.CategoryComboBox.SelectedIndex = 0;
        }

            
    }

}
