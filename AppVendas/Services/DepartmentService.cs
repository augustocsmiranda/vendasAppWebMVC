using AppVendas.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AppVendas.Services
{
    public class DepartmentService
    {
        private readonly AppVendasContext _context;

        public DepartmentService(AppVendasContext context)
        {
            _context = context;
        }

        public async Task<List<Department>> FindAllAsync() 
        {
            return await _context.Department.OrderBy(X => X.Name).ToListAsync();    
        }
    }
}
