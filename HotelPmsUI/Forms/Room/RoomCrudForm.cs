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
        private readonly DataAccessLibrary.Models.Room model;
        public RoomCrudForm(ModelServices.RoomService roomService, DataAccessLibrary.Models.Room model)
        {
            InitializeComponent();
            var roomDesc = Program.ServiceProvider?.GetRequiredService<StartupData>();
            this.roomService = roomService;
            roomBindingSource.DataSource = roomService.BindingSource;
            typeCatgoryBindingSource.DataSource = roomDesc!.RoomDescList;
            this.model = model;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            roomService.SaveData();
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
    }
}
