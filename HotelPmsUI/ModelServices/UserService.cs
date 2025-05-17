using DataAccessLibrary.Context;
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
        }
    }
}
