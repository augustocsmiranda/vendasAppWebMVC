using AppVendas.Models;
using System.Collections.Generic;
using System.Linq;

namespace AppVendas.Services
{
    public class DepartmentService
    {
        private readonly AppVendasContext _context;

        public DepartmentService(AppVendasContext context)
        {
            _context = context;
        }

        public List<Department> FindAll() {
            return _context.Department.OrderBy(X => X.Name).ToList();
              
        }
    }
}
