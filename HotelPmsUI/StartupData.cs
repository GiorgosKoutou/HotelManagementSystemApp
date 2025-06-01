using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelPmsUI
{
    public class StartupData
    {
        private readonly DataAccessLibrary.Context.HpmsDbContext context;
        public List<DataAccessLibrary.Models.TypeCategory> RoomDescList { get; set; } = [];
        public List<DataAccessLibrary.Models.TypeCategory> UserDescList { get; set; } = [];
        public List<DataAccessLibrary.Models.TypeCategory> SpecialtyDesc { get; set; } = [];

        public StartupData(DataAccessLibrary.Context.HpmsDbContext context)
        {
            this.context = context;
        }

        public void LoadRoomDesc()
        {
            var roomDesc = context.TypeCategories.Where(rc => rc.Type == 2).ToList();

            if (RoomDescList.Count == 0)
            {
                RoomDescList.Add(new() { id = 0 });
                RoomDescList.AddRange(roomDesc);
            }
            
        }

        public void LoadUserDesc()
        {
            var userDesc = context.TypeCategories.Where(uc => uc.Type == 3).ToList();

            if (UserDescList.Count == 0)
            {
                UserDescList.Add(new() { id = 0 });
                UserDescList.AddRange(userDesc);
            }
           
        }

        public void LoadStaffDesc()
        {
            var staffDesc = context.TypeCategories.Where(tc => tc.Type == 1).ToList();

            if (SpecialtyDesc.Count == 0) 
            {
                SpecialtyDesc.Add(new() { id = 0 });
                SpecialtyDesc.AddRange(staffDesc);
            }
            
        }
    }
}
