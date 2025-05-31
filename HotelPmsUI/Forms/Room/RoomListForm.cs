using DataAccessLibrary.Models;
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
            roomButtonPanel.Visible = false;
            this.roomService = roomService;
            roomBindingSource.DataSource = roomService.BindingSource;
        }

        private void RoomListForm_Load(object sender, EventArgs e)
        {
            if (roomService.TotalRecords > 30)
            {
                roomButtonPanel.Visible = true;
            }

            if (roomService.CurrentPage == 1)
                roomPreviousButton.Enabled = false;

            if (roomService.CurrentPage == roomService.TotalPages)
                roomNextButton.Enabled = false;
        }

        private void roomPreviousButton_Click(object sender, EventArgs e)
        {
            roomService.CheckPage(roomPreviousButton, roomNextButton);
            roomService.CurrentPageDecrement = 1;
            roomService.StartPointDecrement = 1;

            roomService.ViewData();
        }

        private void roomNextButton_Click(object sender, EventArgs e)
        {
            roomService.CheckPage(roomPreviousButton, roomNextButton);
            roomService.CurrentPageIncrement = 1;
            roomService.StartPointIncrement = 1;

            roomService.ViewData();
        }

        private void roomDataGridView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            roomService.SetIndex(e.RowIndex);
        }
    }
}
