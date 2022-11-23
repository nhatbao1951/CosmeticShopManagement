using CosmeticShopManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace CosmeticShopManagement.Data.Services
{
    public class OwnersService : IOwnersService
    {
        private readonly AppDbContext _context;
        public OwnersService(AppDbContext context)
        {
            _context = context;
        }
        public void Add(Owner owner)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Owner>> GetAll()
        {
            var result = await _context.Owners.ToListAsync();
            return result;
        }

        public Owner GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Owner Update(int id, Owner newOwner)
        {
            throw new NotImplementedException();
        }
    }
}
