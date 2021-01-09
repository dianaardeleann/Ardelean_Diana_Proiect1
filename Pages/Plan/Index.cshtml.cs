using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Ardelean_Diana_Proiect1.Data;
using Ardelean_Diana_Proiect1.Models;

namespace Ardelean_Diana_Proiect1.Pages.Plan
{
    public class IndexModel : PageModel
    {
        private readonly Ardelean_Diana_Proiect1.Data.Ardelean_Diana_Proiect1Context _context;

        public IndexModel(Ardelean_Diana_Proiect1.Data.Ardelean_Diana_Proiect1Context context)
        {
            _context = context;
        }

        public IList<Plancs> Plancs { get;set; }

        public async Task OnGetAsync()
        {
            Plancs = await _context.Plancs.ToListAsync();
        }
    }
}
