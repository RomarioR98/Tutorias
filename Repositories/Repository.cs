﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tutorias.Models;

namespace Tutorias.Repositories
{
    public class Repository<T> where T : class
    {
        public tutoriasContext Context { get; set; }

        public Repository()
        {
            Context = new tutoriasContext();
        }

        public Repository(tutoriasContext context)
        {
            Context = context;
        }

        public IEnumerable<T> GetAll()
        {
            return Context.Set<T>();
        }

        public T GetById(object id)
        {
            return Context.Find<T>(id);
        }

        public void Insert(T entidad)
        {
            Context.Add(entidad);
            Save();
        }

        public void Update(T entidad)
        {
            Context.Update(entidad);
            Save();
        }

        public void Delete(T entidad)
        {
            Context.Remove(entidad);
            Save();
        }

        public void Save()
        {
            Context.SaveChanges();
        }
    }
}
