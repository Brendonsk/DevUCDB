using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProvaDevUCDB.Models;

namespace ProvaDevUCDB.Data
{
    public class ProvaDevUCDBContext : DbContext
    {
        public ProvaDevUCDBContext (DbContextOptions<ProvaDevUCDBContext> options)
            : base(options)
        {
        }

        public DbSet<ProvaDevUCDB.Models.Pedido>? Pedido { get; set; }
    }
}
