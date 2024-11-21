using AppVendas.Models;
using System.Collections.Generic;
using System.Linq;

namespace AppVendas.Services
{
    public class SellerService
    {
        private readonly AppVendasContext _context;

        public SellerService(AppVendasContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }

        public void Insert(Seller obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }
    }
}
