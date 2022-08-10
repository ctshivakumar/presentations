﻿// Copyright Information
// ==================================
// AutoLot - AutoLot.Services - IDataServiceBase.cs
// All samples copyright Philip Japikse
// http://www.skimedic.com 2022/08/09
// ==================================

namespace AutoLot.Services.DataServices.Interfaces;

public interface IDataServiceBase<TEntity> where TEntity : BaseEntity, new()
{
    Task<IEnumerable<TEntity>> GetAllAsync();
    Task<TEntity> FindAsync(int id);
    Task<TEntity> UpdateAsync(TEntity entity, bool persist = true);
    Task DeleteAsync(TEntity entity, bool persist = true);
    Task<TEntity> AddAsync(TEntity entity, bool persist = true);
    //implemented ghost method since it won’t be used by the API data service
    void ResetChangeTracker() { }
}