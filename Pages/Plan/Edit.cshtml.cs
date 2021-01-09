using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Ardelean_Diana_Proiect1.Data;
using Ardelean_Diana_Proiect1.Models;

namespace Ardelean_Diana_Proiect1.Pages.Plan
{
    public class EditModel : PageModel
    {
        private readonly Ardelean_Diana_Proiect1.Data.Ardelean_Diana_Proiect1Context _context;

        public EditModel(Ardelean_Diana_Proiect1.Data.Ardelean_Diana_Proiect1Context context)
        {
            _context = context;
        }

        [BindProperty]
        public Plancs Plancs { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Plancs = await _context.Plancs.FirstOrDefaultAsync(m => m.ID == id);

            if (Plancs == null)
            {
                return NotFound();
            }
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Plancs).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PlancsExists(Plancs.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool PlancsExists(int id)
        {
            return _context.Plancs.Any(e => e.ID == id);
        }
    }
}
