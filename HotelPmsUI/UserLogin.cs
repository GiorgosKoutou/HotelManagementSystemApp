using DataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelPmsUI
{
    public class UserLogin(DataAccessLibrary.Context.HpmsDbContext context)
    {
        private ArgonLibrary.Argon2 argon = new();

        private DataAccessLibrary.Models.User? user = new();
        public string? Username { get => user!.UserName; }
        public string? FullName { get => user!.FullName; }
        public string? Description { get => user!.Description; }
        public string? Password { get => user!.Password; }

        public bool CheckLoginInfo(TextBox usernameText, TextBox passwordText)
        {
            user = context.Users.FirstOrDefault(u => u.UserName == usernameText.Text.Trim());
            
            if(user == null)
            {
                MessageBox.Show("Wrong Username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            var passwordMatch = argon.VerifyPassword(passwordText.Text.Trim(), user!.Password);

            if (!passwordMatch)
            {
                MessageBox.Show("Wrong Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}
