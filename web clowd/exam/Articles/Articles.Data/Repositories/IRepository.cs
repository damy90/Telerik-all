﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Articles.Data.Repositories
{
    public interface IRepository<T> where T : class
    {
        IQueryable<T> All();

        //IQueryable<T> SearchFor(Expression<Func<T, bool>> conditions);

        void Add(T entity);

        T Find(object id);

        void Update(T entity);

        T Delete(T entity);

        T Delete(object id);

        void Detach(T entity);

        int SaveChanges();
    }
}
