using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Agri_Energy.Data;
using Agri_Energy.Model;

namespace Agri_Energy.Pages.Farmers
{
    public class IndexModel : PageModel
    {
        private readonly Agri_Energy.Data.Agri_EnergyContext _context;

        public IndexModel(Agri_Energy.Data.Agri_EnergyContext context)
        {
            _context = context;
        }

        public IList<Farmer> Farmer { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Farmer = await _context.Farmer.ToListAsync();
        }
    }
}
