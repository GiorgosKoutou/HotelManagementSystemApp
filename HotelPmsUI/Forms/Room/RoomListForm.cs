using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelPmsUI.Forms.Room
{
    public partial class RoomListForm : Form
    {
        private readonly ModelServices.RoomService roomService;
        public RoomListForm(ModelServices.RoomService roomService)
        {
            InitializeComponent();
            this.roomService = roomService;
            roomBindingSource.DataSource = roomService.BindingSource;
        }

        private void roomsDataGridView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            roomService.SetIndex(e.RowIndex);
        }
    }
}
