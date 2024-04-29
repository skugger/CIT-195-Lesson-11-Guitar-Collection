using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using CIT_195_Lesson_11_Guitar_Collection.Models;
using Guitar_Collection.Data;

namespace CIT_195_Lesson_11_Guitar_Collection.Pages.Guitars
{
    public class CreateModel : PageModel
    {
        private readonly Guitar_Collection.Data.CIT_195_Lesson_11_Guitar_CollectionContext _context;

        public CreateModel(Guitar_Collection.Data.CIT_195_Lesson_11_Guitar_CollectionContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Guitar Guitar { get; set; } = default!;

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Guitar.Add(Guitar);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
