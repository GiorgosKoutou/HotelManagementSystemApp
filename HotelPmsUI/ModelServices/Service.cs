namespace HotelPmsUI.ModelServices
{
    public class Service<TClass, TValueType>(DataAccessLibrary.Context.HpmsDbContext context) where TClass : class
    {

        public virtual void ViewData(BindingSource source)
        {
            var entity = context.Set<TClass>().ToList();
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

    }
}
