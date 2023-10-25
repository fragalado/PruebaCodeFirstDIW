using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Empleado
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public ICollection<Prueba> Pruebas { get; set; }
    }

    public class Prueba
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id_prueba { get; set; }
        public string Nombre_usuario { get; set; }
        public int Id_empleado { get; set; }
        public Empleado Empleados { get; set; }
    }

}
