using AppVendas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace AppVendas.Services
{
    public class SalesRecordService
    {
        public readonly AppVendasContext _context;

        public SalesRecordService(AppVendasContext context)
        {
            _context = context;
        }

        //Busca Simples
        public async Task<List<SalesRecord>> FindByDateAsync(DateTime? minDate, DateTime? maxDate)
        {
            var result = from obj in _context.SalesRecord select obj;
            if (minDate.HasValue)
            {
                result = result.Where( x => x.Date >= minDate.Value );
            }
            if (maxDate.HasValue) { 
                result = result.Where(x => x.Date <= maxDate.Value );
            }


            return await result
                .Include( x => x.Seller)
                .Include( x => x.Seller.Department )
                .OrderByDescending( x => x.Date )
                .ToListAsync();
        }

        //Busca Agrupada
        public async Task<List<IGrouping<Department,SalesRecord>>> FindByDateGroupingAsync(DateTime? minDate, DateTime? maxDate)
        {
            var result = from obj in _context.SalesRecord select obj;
            if (minDate.HasValue)
            {
                result = result.Where(x => x.Date >= minDate.Value);
            }
            if (maxDate.HasValue)
            {
                result = result.Where(x => x.Date <= maxDate.Value);
            }


            return await result
                .Include(x => x.Seller)
                .Include(x => x.Seller.Department)
                .OrderByDescending(x => x.Date)
                .GroupBy( x => x.Seller.Department)
                .ToListAsync();
        }
    }
}
