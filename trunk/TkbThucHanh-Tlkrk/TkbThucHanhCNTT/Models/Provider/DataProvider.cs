using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Linq;
using System.Linq.Expressions;

namespace TkbThucHanhCNTT.Models.Provider
{
    public class DataProvider<T> where T : class
    {
        public static int RemoveById(object id)
        {
            using (var context = new TkbThucHanhContext())
            {
                T obj = context.Set<T>().Find(id);
                context.Entry(obj).State = EntityState.Deleted;
                return context.SaveChanges();
            }
        }

        public static IList<T> GetAll(params Expression<Func<T, object>>[] navigationProperties)
        {
            List<T> list = new List<T>();
            using (var context = new TkbThucHanhContext())
            {
                try
                {
                    IQueryable<T> dbQuery = context.Set<T>();
                    dbQuery = navigationProperties.Aggregate(dbQuery, (current, navigationProperty) => current.Include(navigationProperty));
                    list = dbQuery
                                  .AsNoTracking()
                                  .ToList();
                }
                catch (Exception)
                {
                }
            }
            return list;
        }

        public static IList<T> GetList(Func<T, bool> where, params Expression<Func<T, object>>[] navigationProperties)
        {
            List<T> list;
            using (var context = new TkbThucHanhContext())
            {
                IQueryable<T> dbQuery = context.Set<T>();

                dbQuery = navigationProperties.Aggregate(dbQuery, (current, navigationProperty) => current.Include(navigationProperty));

                list = dbQuery
                              .AsNoTracking()
                              .Where(where)
                              .ToList();
            }
            return list;
        }

        public static T GetSingle(Func<T, bool> where, params Expression<Func<T, object>>[] navigationProperties)
        {
            T item;
            using (var context = new TkbThucHanhContext())
            {
                IQueryable<T> dbQuery = context.Set<T>();

                dbQuery = navigationProperties.Aggregate(dbQuery, (current, navigationProperty) => current.Include(navigationProperty));

                item = dbQuery
                              .AsNoTracking()
                              .FirstOrDefault(where);
            }
            return item;
        }

        public static int Add(params T[] items)
        {
            return Add(items.ToList());
        }

        public static int Add(IEnumerable<T> items)
        {
            try
            {
                using (var context = new TkbThucHanhContext())
                {
                    foreach (var item in items)
                    {
                        context.Entry(item).State = EntityState.Added;
                    }
                    return context.SaveChanges();
                }
            }
            catch (DbEntityValidationException e)
            {
                foreach (var eve in e.EntityValidationErrors)
                {
                    System.Diagnostics.Debug.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                        eve.Entry.Entity.GetType().Name, eve.Entry.State);
                    foreach (var ve in eve.ValidationErrors)
                    {
                        System.Diagnostics.Debug.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                            ve.PropertyName, ve.ErrorMessage);
                    }
                }
                throw;
            }
        }

        public static int Update(IEnumerable<T> items)
        {
            using (var context = new TkbThucHanhContext())
            {
                foreach (var item in items)
                {
                    context.Entry(item).State = EntityState.Modified;
                }
                return context.SaveChanges();
            }
        }

        public static int Update(params T[] items)
        {
            return Update(items.ToList());
        }

        public static int Remove(IEnumerable<T> items)
        {
            using (var context = new TkbThucHanhContext())
            {
                foreach (var item in items)
                {
                    context.Entry(item).State = EntityState.Deleted;
                }
                return context.SaveChanges();
            }
        }

        public static int Remove(params T[] items)
        {
            return Remove(items.ToList());
        }

        public static int RemoveAll()
        {
            using (var context = new TkbThucHanhContext())
            {
                var items = GetAll();
                foreach (var item in items)
                {
                    context.Entry(item).State = EntityState.Deleted;
                }
                return context.SaveChanges();
            }
        }
    }
}