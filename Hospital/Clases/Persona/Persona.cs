using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppHospital2.Clases
{
    public class Persona
    {
        public string Nombre;
        public string Apellidos;
        public Usuario UsuarioPersona;
        public string Genero;
        public int Edad;
        public string Telefono;
        public string GrupoSanguineo;
        public string ContactoEmergencia;
        public Direccion DireccionPersona;

        public bool BajaSolicitada = false;

        public Persona()
        {
            UsuarioPersona = new Usuario();
            DireccionPersona = new Direccion();
        }
        public override string ToString()
        {
            return UsuarioPersona.NombreUsuario;
        }
    }
}
