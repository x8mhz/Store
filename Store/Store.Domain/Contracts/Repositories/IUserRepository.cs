using System;
using Store.Domain.Entities;

namespace Store.Domain.Contracts.Repositories
{
    public interface IUserRepository : IDisposable
    {
        void Create(User user);
        void Edit(User user);
        void Delete(User user);
        void Save();
    }

}