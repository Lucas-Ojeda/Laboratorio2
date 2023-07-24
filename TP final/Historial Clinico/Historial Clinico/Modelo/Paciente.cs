using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Historial_Clinico.Modelo
{
    public class Paciente
    {
        
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string FechaNacimiento { get; set; }
        public string Genero { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Turno { get; set; }

        public string Historial { get; set; }

        public Paciente() {
            Turno = "Sin un turno actualmente;";
            
        }

    }
}
