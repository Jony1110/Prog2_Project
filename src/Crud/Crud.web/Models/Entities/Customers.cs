using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Crud.web.Models.Entities
{
    //[Table("CUSTOMERS")] Manera de leer
    //y llamar una tabla de una base de datos
    //cuando su nombre es distinto al que tenemos

    public class Customers
    {
        [Key] /*Hace que el programa sepa que el Id es una Primary Key*/
        public int Id { get; set; }
        public string Nombre { get; set; }

        //[Column("LAST_NAME")] Manera de leer
        //y llamar una columna en una base de datos
        //cuando su nombre es distinto al que tenemos

        public string Apellido { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public char Genero { get; set; }
        public bool Activo { get; set; }


    }
}
