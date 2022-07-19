﻿using CoreWebApiBoilerPlate.DataLayer.Entities.Base;
using System.Linq.Expressions;

namespace CoreWebApiBoilerPlate.BusinessLogic.Repository
{
    public interface IRepository<T> where T : EntityBase
    {
        Task<T?> GetByIdAsync(int id, string? navigationsToInclude = null);
        Task<IReadOnlyList<T>> GetAllAsync(string? navigationsToInclude = null);
        Task<IReadOnlyList<T>> GetByCondition(Expression<Func<T, bool>> condition);
        Task<T> AddAsync(T entity);
        Task<T> UpdateAsync(int id, T updatedEntity);
        Task<T> UpdateAsync(int id, object updatedEntity);
        Task<bool> DeleteAsync(int id);
        IQueryable<T> GetQueryable();
    }
}
