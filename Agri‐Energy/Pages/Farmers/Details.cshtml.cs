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
    public class DetailsModel : PageModel
    {
        private readonly Agri_Energy.Data.Agri_EnergyContext _context;

        public DetailsModel(Agri_Energy.Data.Agri_EnergyContext context)
        {
            _context = context;
        }

        public Farmer Farmer { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var farmer = await _context.Farmer.FirstOrDefaultAsync(m => m.farmer_id == id);
            if (farmer == null)
            {
                return NotFound();
            }
            else
            {
                Farmer = farmer;
            }
            return Page();
        }
    }
}
