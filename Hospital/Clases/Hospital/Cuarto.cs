using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppHospital2.Clases
{
    public class Cuarto
    {
        public string Equipamiento;
        public string PacienteCuarto;
        public string NumeroCuarto;
        public string Ocupacion;

        public string DoctorACargo;

        public override string ToString()
        {
            return NumeroCuarto;
        }
    }
}
