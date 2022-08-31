using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiAutores.Entidades;

namespace WebApiAutores
{
    public class ApplicationDbContext : DbContext
    {
        protected ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        /*con DbSet<Autor> le indico que me cree una tabla en base alas propiedades de Autores */
        public DbSet<Autor> Autores { get; set; }
    }
}
