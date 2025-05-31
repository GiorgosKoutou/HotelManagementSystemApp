using DataAccessLibrary.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelPmsUI.ModelServices
{
    public class UserService : BaseService<DataAccessLibrary.Models.User, Forms.User.UserCrudForm, Forms.User.UserListForm>
    {
        public UserService(HpmsDbContext context) : base(context)
        {
            var table = context.Users
                        .Include(u => u.UserRole)
                        .OrderBy(u => u.Id);
            SetRecords(table);
        }

        public override void SaveData()
        {
            ((DataAccessLibrary.Models.User)BindingSource!.Current).UserRole.Type = 3;

            var userPassword = ((DataAccessLibrary.Models.User)BindingSource!.Current).Password;

            ArgonLibrary.Argon2 argon = new();

            ((DataAccessLibrary.Models.User)BindingSource!.Current).Password = argon.HashPassword(userPassword);

            base.SaveData();
        }
    }
}
