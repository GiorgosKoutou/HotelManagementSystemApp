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
        void SetPanel(Control panel);

        int CategoryType { get; set; }

    }
}
