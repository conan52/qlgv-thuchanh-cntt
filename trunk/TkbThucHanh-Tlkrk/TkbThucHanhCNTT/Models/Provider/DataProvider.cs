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
        public static IList<T> GetAll(params Expression<Func<T, object>>[] navigationProperties)
        {
            List<T> list;
            using (var context = new TkbThucHanhContext())
            {
                IQueryable<T> dbQuery = context.Set<T>();
                dbQuery = navigationProperties.Aggregate(dbQuery, (current, navigationProperty) => current.Include(navigationProperty));
                list = dbQuery
                    .AsNoTracking()
                    .ToList();
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

        public static void Add(params T[] items)
        {
            Add(items.ToList());
        }

        public static void Add(IEnumerable<T> items)
        {
          try
            {
                using (var context = new TkbThucHanhContext())
                {
                    foreach (var item in items)
                    {
                        context.Entry(item).State = EntityState.Added;
                    }
                    context.SaveChanges();
                }

            }
            catch (DbEntityValidationException e)
            {
                foreach (var eve in e.EntityValidationErrors)
                {
                    Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                        eve.Entry.Entity.GetType().Name, eve.Entry.State);
                    foreach (var ve in eve.ValidationErrors)
                    {
                        Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                            ve.PropertyName, ve.ErrorMessage);
                    }
                }
                throw;
            }
        }

        public static void Update(params T[] items)
        {
            using (var context = new TkbThucHanhContext())
            {
                foreach (var item in items)
                {
                    context.Entry(item).State = EntityState.Modified;
                }
                context.SaveChanges();
            }
        }

        public static void Remove(params T[] items)
        {
            using (var context = new TkbThucHanhContext())
            {
                foreach (var item in items)
                {
                    context.Entry(item).State = EntityState.Deleted;
                }
                context.SaveChanges();
            }
        }
    }
}