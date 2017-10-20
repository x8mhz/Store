using Store.Domain.Entities;

namespace Store.Domain.Contracts.Services
{
    public interface IUserService
    {
        void RegisterAccount(User user);
    }
}