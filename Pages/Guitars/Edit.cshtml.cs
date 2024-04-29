using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CIT_195_Lesson_11_Guitar_Collection.Models;
using Guitar_Collection.Data;

namespace CIT_195_Lesson_11_Guitar_Collection.Pages.Guitars
{
    public class EditModel : PageModel
    {
        private readonly Guitar_Collection.Data.CIT_195_Lesson_11_Guitar_CollectionContext _context;

        public EditModel(Guitar_Collection.Data.CIT_195_Lesson_11_Guitar_CollectionContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Guitar Guitar { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var guitar =  await _context.Guitar.FirstOrDefaultAsync(m => m.Id == id);
            if (guitar == null)
            {
                return NotFound();
            }
            Guitar = guitar;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Guitar).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GuitarExists(Guitar.Id))
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

        private bool GuitarExists(int id)
        {
            return _context.Guitar.Any(e => e.Id == id);
        }
    }
}
