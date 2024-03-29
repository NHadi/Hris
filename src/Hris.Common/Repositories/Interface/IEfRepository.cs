﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Hris.Common.Repositories.Interface
{
    public interface IEfRepository<TEntity> : IReadOnlyRepository<TEntity> where TEntity : class
    {
        void Insert(TEntity entitiy);
        void InsertRange(List<TEntity> entities);
        void Update(TEntity entitiy);
        void UpdateRange(List<TEntity> entities);
        void Delete(TEntity entity);
        void DeleteRange(List<TEntity> entities);
        //void Save();
        //Task SaveAsync();
    }
}
