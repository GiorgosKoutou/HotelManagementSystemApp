using HotelPmsUI.Forms.Customer;

namespace HotelPmsUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CustomerCrudForm form = new CustomerCrudForm();
            form.Show();
        }
    }
}
