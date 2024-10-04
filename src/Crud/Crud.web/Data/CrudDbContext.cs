using Crud.web.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Crud.web.Data
{
    public class CrudDbContext: DbContext
    {
        public CrudDbContext(DbContextOptions<CrudDbContext> options) : base (options)
        {

        }

        public DbSet<Customers> Customers { get; set; }

        //public CrudDbContext(IConfiguration configuration)
        //{
           
        //    Hay diferente manera de hacer la conexion a la base de datos
        //    ya sea de estas maneras o atravez del appsettings.json
            
        //   var cnn = "Server=localhost;Database=master;Trusted_Connection=True;MultipleActiveResults=true;TrustServerCertificate=True";
        //   var cnn = "Server=.\\SQL2022;Database=CrudDB;Trusted_Connection=True;MultipleActiveResults=true;TrustServerCertificate=True";
        //   var cnn = configuration.GetConnectionString("CrudStrConnection");
        //}
    }
}
