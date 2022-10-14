using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Milea_Petrica_Vasile_Lab2.Models;

namespace Milea_Petrica_Vasile_Lab2.Data
{
    public class Milea_Petrica_Vasile_Lab2Context : DbContext
    {
        public Milea_Petrica_Vasile_Lab2Context (DbContextOptions<Milea_Petrica_Vasile_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Milea_Petrica_Vasile_Lab2.Models.Book> Book { get; set; } = default!;
    }
}
