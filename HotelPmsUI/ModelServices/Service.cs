using DataAccessLibrary.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace HotelPms.ModelServices
{
    public class Service
    {

        public virtual void ViewData<TContext, TClass>(BindingSource source) where TContext : new() where TClass : class
        {
            using (var context = new TContext() as DbContext)
            {
                var entity = context.Set<TClass>().ToList();
                source.DataSource = entity;
            }
        }

        public virtual void AddData<TContext, TClass>(BindingSource source) where TContext : new() where TClass : class
        {
            using (var context = new TContext() as DbContext)
            {
                var entity = (TClass)source.Current;
                context.Add(entity);
                context.SaveChanges();
                source.AddNew();
            }
        }

       public virtual void EdiData<TContext, TClass>(BindingSource source) where TContext : new() where TClass : class
        {
            using (var context = new TContext() as DbContext)
            {
                var entity = (TClass)source.Current;
                context.Set<TClass>().Update(entity);
                context.SaveChanges();
            }
        }


        public virtual void DeleteData<TContext, TClass, TvarName>(TvarName propName) where TContext : new() where TClass : class where TvarName : struct
        {

            using (var context = new TContext() as DbContext)
            {
                var entity = context.Set<TClass>().Find(propName);
                context.Set<TClass>().Remove(entity);
                context.SaveChanges(); 
            }
        }

        public virtual TClass FindData<TContext, TClass, TvarName>(TvarName propName) where TContext : new() where TClass : class where TvarName : struct
        {
            using (var context = new TContext() as DbContext)
            {
                var entity = context.Set<TClass>().Find(propName);
                return entity;
            }
        }

    }
}
