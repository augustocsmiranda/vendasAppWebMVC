using AppVendas.Models;
//using AspNetCore;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;


namespace AppVendas.Services
{
    public class SellerService
    {
        private readonly AppVendasContext _context;

        public SellerService(AppVendasContext context)
        {
            _context = context;
        }

        public  async Task<List<Seller>> FindAllAsync()
        {
            return await _context.Seller.ToListAsync();
        }

        public async Task InsertAsync(Seller obj)
        {
            //obj.Department = _context.Department.First();
            _context.Add(obj);
            await _context.SaveChangesAsync();
        }

        public  async Task<Seller> FindByIdAsync(int id) { 
            return await _context.Seller.Include(obj => obj.Department).FirstOrDefaultAsync(obj => obj.Id == id);
        }

        public async Task RemoveAsync(int Id)
        {
            var obj = await _context.Seller.FindAsync(Id);
            _context.Seller.Remove(obj);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Seller obj) {
            bool hasAny = _context.Seller.Any(x => x.Id == obj.Id);
            if (!hasAny) { 
                throw new KeyNotFoundException("Id not found");
            }
            try
            {
                _context.Update(obj);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException e) 
            {
                throw new DbUpdateConcurrencyException(e.Message);
            }

        }
    }
}
