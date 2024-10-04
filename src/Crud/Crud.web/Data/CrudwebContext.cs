using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Crud.web.Models.Entities;

namespace Crud.web.Data
{
    public class CrudwebContext : DbContext
    {
        public CrudwebContext (DbContextOptions<CrudwebContext> options)
            : base(options)
        {
        }

        public DbSet<Crud.web.Models.Entities.Customers> Customers { get; set; } = default!;
    }
}
