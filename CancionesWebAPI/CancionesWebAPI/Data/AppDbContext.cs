using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CancionesWebAPI.Models;

namespace CancionesWebAPI.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>options):base(options)
        {

        }
        public DbSet<CancionesWebAPI.Models.Cancion> Cancion { get; set; }
    }
}
