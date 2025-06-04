
using DataAccessLibrary.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelPmsUI.ModelServices
{
    public class UserService : BaseService<DataAccessLibrary.Models.User, 
                                        Forms.User.UserCrudForm, Forms.User.UserListForm, Forms.User.UserFilterForm>
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

            //var userPassword = ((DataAccessLibrary.Models.User)BindingSource!.Current).Password;
            var currentRecord = (DataAccessLibrary.Models.User)BindingSource!.Current;
            currentRecord.UserName = currentRecord.UserName.Trim();
            currentRecord.Password = currentRecord.Password.Trim();
            currentRecord.FullName = currentRecord?.FullName!.Trim();

            var message = CheckFields();
            if (message != null)
            {
                MessageBox.Show(message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var entry = Context.Entry(currentRecord);

            var oldPassword = entry!.OriginalValues["Password"];
            var newPassword = entry.CurrentValues["Password"];

            var oldUsername = entry.OriginalValues["UserName"];
            var newUsername = entry.CurrentValues["UserName"];

            newPassword = (oldPassword!.Equals(newPassword)) ? null : newPassword;
            newUsername = (oldUsername!.Equals(newUsername)) ? null : newUsername;

            if (entry.State == EntityState.Modified && (newPassword == null && newUsername == null))
            {
                base.SaveData();
                return;
            }

            var usernameExists = Context.Users.FirstOrDefault(u => u.UserName == currentRecord!.UserName);

            if (usernameExists != null)
            {
                MessageBox.Show("Username already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            ArgonLibrary.Argon2 argon = new();

            ((DataAccessLibrary.Models.User)BindingSource!.Current).UserRole.Type = 3;

            //((DataAccessLibrary.Models.User)BindingSource!.Current).Password = argon.HashPassword(userPassword);
            currentRecord!.Password = argon.HashPassword(currentRecord.Password);

            base.SaveData();
        }
    }
}
