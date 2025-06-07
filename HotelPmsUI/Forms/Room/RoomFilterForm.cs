using HotelPmsUI.ModelServices;
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
    public partial class RoomFilterForm : Form
    {
        #region Properties for filtering
        [DataAccessLibrary.AttributeMarkerClasses.ColumnNames(Name = "RoomNumber")]
        public string? RoomNumber { get => roomNumberText.Text; }

        [DataAccessLibrary.AttributeMarkerClasses.ColumnNames(Name = "Floor")]
        public int Floor { get => Convert.ToInt32(floorNumeric.Value); }
        
        [DataAccessLibrary.AttributeMarkerClasses.ColumnNames(Name = "RoomTypeCategory")]
        public string? DescriptionBox { get => descripitonComboBox.Text; }
        #endregion

        private readonly ModelServices.RoomService roomService;
        public RoomFilterForm(ModelServices.RoomService roomService)
        {
            InitializeComponent();
            this.roomService = roomService;

            var boxData = Program.ServiceProvider?.GetRequiredService<StartupData>();
            boxData?.LoadRoomDesc();

            descripitonComboBox.DataSource = boxData?.RoomDescList;
        }

        private void searchButton_Click(object sender, EventArgs e)
        { 
            roomService.Filter();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            roomNumberText.Clear();
            floorNumeric.Value = 0;
            descripitonComboBox.SelectedIndex = 0;
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
