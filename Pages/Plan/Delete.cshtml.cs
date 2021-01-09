﻿using System;
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
    public class DeleteModel : PageModel
    {
        private readonly Ardelean_Diana_Proiect1.Data.Ardelean_Diana_Proiect1Context _context;

        public DeleteModel(Ardelean_Diana_Proiect1.Data.Ardelean_Diana_Proiect1Context context)
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Plancs = await _context.Plancs.FindAsync(id);

            if (Plancs != null)
            {
                _context.Plancs.Remove(Plancs);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
