using DataAccessLibrary.Context;

namespace HotelPmsUI.ModelServices
{
    public class Service<TClass, TValueType>(DataAccessLibrary.Context.HpmsDbContext context) where TClass : class
    {

        private int currentPage = 0;
        private int skippedRecords;
        private int recordsPerPage = 30;
        private int totalRecords = context.Set<TClass>().Count();
        private int totalPages = 0;
        public int CurrentPage { get => currentPage; }
        public int CurrentPageIncrement { set => currentPage += value; }
        public int CurrentPageDecrement { set => currentPage -= value; }
        public int RecordsPerPage { get => recordsPerPage; }
        public int TotalRecords { get => totalRecords; }
        public int TotalPages { get => totalPages; }


        public virtual void ViewData(BindingSource source)
        {
            CalculatePages();
            skippedRecords = currentPage * recordsPerPage;
            var entity = context.Set<TClass>().Skip(skippedRecords).Take(recordsPerPage).ToList();
            source.DataSource = entity;
        }

        public virtual void AddData(BindingSource source)
        {
            var entity = (TClass)source.Current;
            context.Add(entity);
            context.SaveChanges();
            source.AddNew();
        }

        public virtual void EdiData(BindingSource source)
        {
            var entity = (TClass)source.Current;
            context.Set<TClass>().Update(entity);
            context.SaveChanges();
        }


        public virtual void DeleteData(TValueType propName)
        {

            var entity = context.Set<TClass>().Find(propName);
            context.Set<TClass>().Remove(entity);
            context.SaveChanges();
        }

        public virtual TClass FindData(TValueType propName)
        {
            var entity = context.Set<TClass>().Find(propName);
            return entity;
        }

        private void CalculatePages()
        {
            totalPages = totalRecords / recordsPerPage;
        }
    }
}
