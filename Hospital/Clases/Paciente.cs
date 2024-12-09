using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppHospital2.Clases
{
    public class Paciente : Persona
    {
        public List<string> Diagnostico = new List<string>();
        public string Estado = "Internado";
        public string cuartoAsignado = "";
        public string Medico = "";


    }
}
