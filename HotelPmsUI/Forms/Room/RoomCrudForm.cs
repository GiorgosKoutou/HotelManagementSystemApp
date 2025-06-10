using DataAccessLibrary.Models;
using Microsoft.Extensions.DependencyInjection;
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
    public partial class RoomCrudForm : Form
    {
        private readonly ModelServices.RoomService roomService;

        public ComboBox CategoryComboBox { get => roomTypeComboBox; }
        public RoomCrudForm(ModelServices.RoomService roomService)
        {
            InitializeComponent();
            var roomDesc = Program.ServiceProvider?.GetRequiredService<StartupData>();
            roomDesc!.LoadRoomDesc();
            this.roomService = roomService;
            roomBindingSource.DataSource = roomService.BindingSource;
            typeCatgoryBindingSource.DataSource = roomDesc!.RoomDescList;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            roomService.SaveData();
            if (roomService.IsNew)
                roomTypeComboBox.SelectedIndex = -1;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to cancel?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                roomService.ViewData();
            }
            else
                return;
        }

        private void roomTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //var roomType = roomTypeComboBox.SelectedValue;

            //MessageBox.Show($"Value: {roomType}");
        }
    }
}
