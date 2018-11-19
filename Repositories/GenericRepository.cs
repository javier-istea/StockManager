﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StockManager.Data;

namespace StockManager.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected readonly ApplicationDbContext context;
        public GenericRepository(ApplicationDbContext _context)
        {
            this.context = _context;
        }

        public bool Add(T model)
        {
            try
            {
                context.Set<T>().Add(model);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Del(int id)
        {
            try

            {
                T entidad = this.GetByID(id);
                context.Set<T>().Remove(entidad);
                return true;
            }
            catch
            { return false; }
        }

        public IEnumerable<T> GetAll()
        {
            return context.Set<T>().ToList();
        }


        public T GetByID(int id)
        {
            return context.Set<T>().Find(id);
        }
        
        public void save()
        {
            context.SaveChanges();
        }

        public bool Update(T model)
        {
            try
            {
                context.Set<T>().Update(model);
                return true;
            }
            catch
            {
                return false;

            }
        }
    }
}
