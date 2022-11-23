using CosmeticShopManagement.Models;

namespace CosmeticShopManagement.Data.Services
{
    public interface IOwnersService
    {
        Task<IEnumerable<Owner>> GetAll();
        Owner GetById(int id);

        void Add(Owner owner);

        Owner Update(int id, Owner newOwner);

        void Delete(int id);
    }
}
