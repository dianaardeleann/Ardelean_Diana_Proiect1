using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Ardelean_Diana_Proiect1.Data;
using Ardelean_Diana_Proiect1.Models;

namespace Ardelean_Diana_Proiect1.Pages.Plan
{
    public class CreateModel : PageModel
    {
        private readonly Ardelean_Diana_Proiect1.Data.Ardelean_Diana_Proiect1Context _context;

        public CreateModel(Ardelean_Diana_Proiect1.Data.Ardelean_Diana_Proiect1Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Plancs Plancs { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Plancs.Add(Plancs);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
