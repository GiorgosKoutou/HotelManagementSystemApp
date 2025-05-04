using Microsoft.EntityFrameworkCore.Query.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelPmsUI.ModelServices
{
    public interface IService 
    {
        void ViewData();
        void SaveData();
        void NewData();
        void EditData();
        void DeleteData();

        void ShowListForm();
        void ShowCrudForm();
        void SetBindingSource(BindingSource gridSource, BindingSource crudSource);
        void SetPanel(Control panel);
        void SetForms(Form crudForm, Form listForm);

    }
}
