
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
            ArgonLibrary.Argon2 argon = new();

            
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

            var entry = Context?.Entry(currentRecord!);

            if (entry!.State == EntityState.Modified)
            {
                currentRecord!.Password = argon.HashPassword(currentRecord.Password);
                base.SaveData();
                return;
            }

            var usernameExists = Context?.Users.FirstOrDefault(u => u.UserName == currentRecord!.UserName);

            if (usernameExists != null)
            {
                MessageBox.Show("Username already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            ((DataAccessLibrary.Models.User)BindingSource!.Current).UserRole.Type = 3;

            currentRecord!.Password = argon.HashPassword(currentRecord.Password);

            base.SaveData();

        }
    }
}
