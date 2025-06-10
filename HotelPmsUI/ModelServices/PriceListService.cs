using DataAccessLibrary.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelPmsUI.ModelServices
{
    public class PriceListService : BaseService<DataAccessLibrary.Models.PriceList, Forms.PriceList.PriceListCrudForm, Forms.PriceList.PriceListListForm, Form>
    {
        private string periodName = string.Empty;
        private BindingSource detailsSource = new();
        private List<DataAccessLibrary.Models.PriceListDetail> deletedRows = [];
        private int detailsIndex = -1;

        public BindingSource DetailsSource { get => detailsSource; }
        public PriceListService(HpmsDbContext context) : base(context)
        {
            detailsSource.DataSource = context.PriceListDetail.ToList();
            var table = context.PriceList.Include(i => i.Period);
            SetRecords(table);
        }

        public override void SaveData()
        {
            var priceListRecord = (DataAccessLibrary.Models.PriceList)BindingSource!.Current;

            var currentDetailList = detailsSource.List;

            foreach(var rec in currentDetailList)
            {
                var detailsRecord = (DataAccessLibrary.Models.PriceListDetail)rec;
                var entry = Context.Entry(detailsRecord);

                if (entry.State == EntityState.Detached)
                {
                    detailsRecord.PriceList = priceListRecord;
                    Context.Add(detailsRecord);
                }else if (entry.State == EntityState.Modified)
                {
                    detailsRecord.PriceList = priceListRecord;
                    Context.Update(detailsRecord);
                }
                    
            }

            if (deletedRows.Count == 1)
            {
                Context.Remove(deletedRows[0]);
                MessageBox.Show("Room Deleted successfully", "Delete", MessageBoxButtons.OK);
                deletedRows.Clear();
            }
            if(deletedRows.Count > 1)
            {
                Context.RemoveRange(deletedRows);
                MessageBox.Show("Rooms Deleted successfully", "Delete", MessageBoxButtons.OK);
                deletedRows.Clear();
            }

            base.SaveData();
        }

        public void DeleteDetailsData()
        {
            var currentRecord = (DataAccessLibrary.Models.PriceListDetail)detailsSource[detailsIndex];
            deletedRows.Add(currentRecord);
        }


        public override void NewData()
        {
            var newRecords = detailsSource.AddNew();
            detailsSource.DataSource = newRecords;
            base.NewData();
        }

        public override void EditData()
        {
            var priceListId = ((DataAccessLibrary.Models.PriceList)BindingSource![CurrentIndex]).Id;
            detailsSource.DataSource = Context.PriceListDetail.Where(pl => pl.PriceListId == priceListId).ToList();
            base.EditData();
        }

        public void SetDetailsIndex(int index)
        {
            detailsIndex = index;
        }
    }
}
