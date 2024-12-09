using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppHospital2.Clases
{
    public class Hosp
    {
        //Lista de Pacientes del Hospital
        public List<Paciente> listaPacientes = new List<Paciente>();
        //Lista de Doctores del Hospital
        public List<Doctor> listaDoctores = new List<Doctor>();
        //Lista de Administrativos del Hospital
        public List<Admin> listaAdmins = new List<Admin>();
        //Lista Sistemas
        public List<IngSistemas> listaSistemas = new List<IngSistemas>();

        //Lista de Cuartos
        public List<Cuarto> listaCuartos = new List<Cuarto>();
        public IngSistemas Paco = new IngSistemas();

        public Hosp()
        {
            Cuarto nuevoCuarto = new Cuarto();
            nuevoCuarto.NumeroCuarto = "0";
            nuevoCuarto.Equipamiento = "Equipamiento sencillo";
            nuevoCuarto.Ocupacion = "Libre";

            listaCuartos.Add(nuevoCuarto);

            Cuarto nuevoCuarto2 = new Cuarto();
            nuevoCuarto2.NumeroCuarto = "1";
            nuevoCuarto2.Equipamiento = "Equipamiento para cirujia";
            nuevoCuarto2.Ocupacion = "Libre";

            listaCuartos.Add(nuevoCuarto2);
        }
        public Persona buscarUsuario(string usuario)
        {
            IngSistemas buscarSistemas = listaSistemas.Find(s => s.UsuarioPersona.NombreUsuario == usuario);

            if (buscarSistemas == null)
            {
                //No es un usuario de sistemas
                //Buscar Admin
                Admin buscarAdmin = listaAdmins.Find(a => a.UsuarioPersona.NombreUsuario == usuario);

                if (buscarAdmin == null)
                {
                    //No es un usuario de admin
                    //Buscar Doctor
                    Doctor buscarDoctor = listaDoctores.Find(d => d.UsuarioPersona.NombreUsuario == usuario);

                    if (buscarDoctor == null)
                    {
                        //No es un usuario de doctor
                        //Buscar Paciente
                        Paciente buscarPaciente = listaPacientes.Find(p => p.UsuarioPersona.NombreUsuario == usuario);

                        if (buscarPaciente == null)
                        {
                            //No es un usuario paciente ni ningun tipo de usuario
                            return null;
                        }
                        else
                        {
                            //Si es un paciente
                            return buscarPaciente;
                        }

                    }
                    else
                    {
                        //Si es un doctor
                        return buscarDoctor;
                    }

                }
                else
                {
                    //Si es un usuario de Admin
                    return buscarAdmin;
                }

            }
            else
            {
                //Si es un usuario de sistemas
                return buscarSistemas;
            }


        }
    }
}
