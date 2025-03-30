using System.Windows.Forms;

namespace HotelPms.ModelServices
{
    public class Service(DataAccessLibrary.Context.HpmsDbContext context)
    { 

        public virtual void ViewData<TClass>(BindingSource source) where TClass : class
        {
            var entity = context.Set<TClass>().ToList();
            source.DataSource = entity;
        }

        public virtual void AddData<TClass>(BindingSource source) where TClass : class
        {
            var entity = (TClass)source.Current;
            context.Add(entity);
            context.SaveChanges();
            source.AddNew();
        }

        public virtual void EdiData<TClass>(BindingSource source) where TClass : class
        {
            var entity = (TClass)source.Current;
            context.Set<TClass>().Update(entity);
            context.SaveChanges();
        }


        public virtual void DeleteData<TClass, TValueType>(TValueType propName) where TClass : class
        {

            var entity = context.Set<TClass>().Find(propName);
            context.Set<TClass>().Remove(entity);
            context.SaveChanges();
        }

        public virtual TClass FindData<TClass, TValueType>(TValueType propName) where TClass : class
        {
            var entity = context.Set<TClass>().Find(propName);
            return entity;
        }

    }
}
