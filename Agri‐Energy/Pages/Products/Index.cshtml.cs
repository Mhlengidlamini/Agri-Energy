using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Agri_Energy.Data;
using Agri_Energy.Model;

namespace Agri_Energy.Pages.Products
{
    public class IndexModel : PageModel
    {
        private readonly Agri_Energy.Data.Agri_EnergyContext _context;

        public IndexModel(Agri_Energy.Data.Agri_EnergyContext context)
        {
            _context = context;
        }

        public IList<Product> Product { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Product = await _context.Product.ToListAsync();
        }
    }
}
