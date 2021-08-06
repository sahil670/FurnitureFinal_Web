using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Advance_Furniture.Models;

namespace Advance_Furniture.Data
{
    public class Advance_FurnitureContext : DbContext
    {
        public Advance_FurnitureContext (DbContextOptions<Advance_FurnitureContext> options)
            : base(options)
        {
        }

        public DbSet<Advance_Furniture.Models.Furniture> Furniture { get; set; }

        public DbSet<Advance_Furniture.Models.sale> sale { get; set; }

        public DbSet<Advance_Furniture.Models.Login> Login { get; set; }

        public DbSet<Advance_Furniture.Models.Contact> Contact { get; set; }

        public DbSet<Advance_Furniture.Models.Stock> Stock { get; set; }
    }
}
