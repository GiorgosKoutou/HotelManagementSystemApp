using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelPmsUI.Modules
{
    public class BaseModule<TFormCrud, TFormList> where TFormCrud : Form where TFormList : Form
    {
       public virtual void ShowForm(Control panel, Form form)
        {
            panel.Controls.Clear();

            form.TopLevel = false;
            form.TopMost = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;

            panel.Controls.Add(form);
            form.Show();
        }

        public virtual void ShowListForm(Control panel)
        {
            panel.Controls.Clear();
            var form = Program.ServiceProvider.GetRequiredService<TFormList>();

            form.TopLevel = false;
            form.TopMost = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;

            panel.Controls.Add(form);
            form.Show();
        }

        

    }
}
