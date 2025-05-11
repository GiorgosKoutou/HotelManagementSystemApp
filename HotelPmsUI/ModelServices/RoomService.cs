using DataAccessLibrary.Context;
using DataAccessLibrary.Models;
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
        public RoomService(HpmsDbContext context) : base(context) { }

        public override void SaveData()
        {
            try
            {
                if (isNew)
                    MessageBox.Show("Room added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Room Updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ((Room)BindingSource.Current).RoomType = 2;
                base.SaveData();
                transaction.Commit();
            }
            catch (DbException ex)
            {
                string msg = ex.Message;
                MessageBox.Show($"Error: {msg}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
            
    }

}
