using DataAccessLibrary.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelPmsUI.ModelServices
{
    public class PeriodService : BaseService<DataAccessLibrary.Models.Period, Forms.Period.PeriodCrudForm, Forms.Period.PeriodListForm, Form>
    {
        public PeriodService(HpmsDbContext context) : base(context)
        {
        }
    }
}
