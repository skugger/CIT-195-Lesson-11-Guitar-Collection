using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CIT_195_Lesson_11_Guitar_Collection.Models;
using Guitar_Collection.Data;

namespace CIT_195_Lesson_11_Guitar_Collection.Pages.Guitars
{
    public class IndexModel : PageModel
    {
        private readonly Guitar_Collection.Data.CIT_195_Lesson_11_Guitar_CollectionContext _context;

        public IndexModel(Guitar_Collection.Data.CIT_195_Lesson_11_Guitar_CollectionContext context)
        {
            _context = context;
        }

        public IList<Guitar> Guitar { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Guitar = await _context.Guitar.ToListAsync();
        }
    }
}
