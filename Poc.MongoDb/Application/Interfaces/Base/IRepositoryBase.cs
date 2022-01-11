﻿using Application.Entities.Base;
using System.Threading.Tasks;

namespace Application.Interfaces.Base
{
    public interface IRepositoryBase<T> where T : BaseEntity
    {
        Task InsertAsync(T obj);

        Task UpdateAsync(T obj);

        Task DeleteAsync(string id);
    }
}
