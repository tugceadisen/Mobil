using Microsoft.EntityFrameworkCore;
using Mobil1.Models;
using System.Collections.Generic;

namespace Mobil1.Data
{
    public class Mobil1DbContext : DbContext
    {
        public DbSet<Fatura> Faturalar { get; set; }
        public DbSet<Fatura_Bilgi> FaturaBilgileri { get; set; }

        public Mobil1DbContext(DbContextOptions<Mobil1DbContext> options) : base(options)
        {
        }
    }
}
