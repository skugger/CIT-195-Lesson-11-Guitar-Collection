using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CIT_195_Lesson_11_Guitar_Collection.Models;

namespace Guitar_Collection.Data
{
    public class CIT_195_Lesson_11_Guitar_CollectionContext : DbContext
    {
        public CIT_195_Lesson_11_Guitar_CollectionContext (DbContextOptions<CIT_195_Lesson_11_Guitar_CollectionContext> options)
            : base(options)
        {
        }

        public DbSet<CIT_195_Lesson_11_Guitar_Collection.Models.Guitar> Guitar { get; set; } = default!;
    }
}
