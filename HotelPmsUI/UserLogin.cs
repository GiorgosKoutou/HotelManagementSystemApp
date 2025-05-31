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
        private DataAccessLibrary.Models.User? login = context.Users.FirstOrDefault(u => u.FullName == "Administrator");
        public string? FullName { get => login!.FullName; }
    }
}
