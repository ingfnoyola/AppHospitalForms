using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppHospital2.Clases
{
    public class Doctor : Persona
    {
        public string Especialidad;
        public List<string> pacientes = new List<string>();
    }
}
