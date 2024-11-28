using System.Collections;
using System.Collections.Generic;

namespace AppVendas.Models.ViewModels
{
    public class SellerFormViewModel
    {
        public Seller Seller { get; set; }
        public ICollection<Department> Departments { get; set; }



    }
}
