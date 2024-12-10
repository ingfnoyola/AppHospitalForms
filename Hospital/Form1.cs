using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppHospital2.Clases;
using Hospital.Forms;

namespace Hospital
{
    public partial class Form1 : Form
    {
        public Hosp h = new Hosp();
        

        public IngSistemas Paco = new IngSistemas();
        
        
        
        public Form1()
        {
            InitializeComponent();
            Paco.UsuarioPersona.NombreUsuario = "Admin";
            Paco.UsuarioPersona.PasswordUsuario = "12345";
            h.listaSistemas.Add(Paco);

            FormDatosPersona formDatos = new FormDatosPersona();
            
        }
        private void MyForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }


        private void B_Login_Click(object sender, EventArgs e)
        {
            Persona pLogin = new Persona();
            pLogin = h.buscarUsuario(TB_LoginUsuario.Text);
            if (pLogin == null)
            {
                MessageBox.Show("Ese usuario no existe!");
            } else
            {
                if (pLogin.UsuarioPersona.PasswordUsuario == TB_LoginPassword.Text)
                {
                    if (pLogin is Paciente)
                    {
                        Paciente paciente = new Paciente();
                        paciente = pLogin as Paciente;
                        FormPaciente formPaciente = new FormPaciente(h, this, paciente);
                        formPaciente.Show();
                    }
                    if (pLogin is Doctor)
                    {
                        MessageBox.Show("Bienvenido Doctor!");

                        Doctor doctor = new Doctor();
                        doctor = pLogin as Doctor;
                        FormDoctor formDoctor = new FormDoctor(h, this, doctor);
                        formDoctor.Show();
                    }
                    if (pLogin is Admin)
                    {
                        MessageBox.Show("Bienvenido Admin!");

                        Admin admin = new Admin();
                        admin = pLogin as Admin;
                        FormAdmin formAdmin = new FormAdmin(h, this, admin);
                        formAdmin.Show();

                    }
                    if (pLogin is IngSistemas)
                    {
                        MessageBox.Show("Bienvenido ing!");
                        FormSistemas form = new FormSistemas(h, this);
                        form.Show();

                        //ESCONDER FORM1 AL ABRIR FORMSISTEMAS
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Contraseña incorrecta!");
                }
            }
            
        }

        private void B_CrearRepaldo_Click(object sender, EventArgs e)
        {
            string rutaArchivo = "C:/Users/Paco/Desktop/BaseDatos.txt";

            using (StreamWriter escritor = new StreamWriter(rutaArchivo))
            {
                foreach (Paciente p in h.listaPacientes)
                {
                    escritor.WriteLine($"P,{p.Nombre},{p.Apellidos},{p.UsuarioPersona.NombreUsuario},{p.UsuarioPersona.PasswordUsuario},{p.Genero},{p.Edad},{p.Telefono},{p.GrupoSanguineo},{p.ContactoEmergencia}");
                }
                foreach (Doctor d in h.listaDoctores)
                {
                    escritor.WriteLine($"D,{d.Nombre},{d.Apellidos},{d.UsuarioPersona.NombreUsuario},{d.UsuarioPersona.PasswordUsuario},{d.Genero},{d.Edad},{d.Telefono},{d.GrupoSanguineo},{d.ContactoEmergencia}");
                }
                foreach (Admin a in h.listaAdmins)
                {
                    escritor.WriteLine($"A,{a.Nombre},{a.Apellidos},{a.UsuarioPersona.NombreUsuario},{a.UsuarioPersona.PasswordUsuario},{a.Genero},{a.Edad},{a.Telefono},{a.GrupoSanguineo},{a.ContactoEmergencia}");
                }
                foreach (IngSistemas i in h.listaSistemas)
                {
                    escritor.WriteLine($"I,{i.Nombre},{i.Apellidos},{i.UsuarioPersona.NombreUsuario},{i.UsuarioPersona.PasswordUsuario},{i.Genero},{i.Edad},{i.Telefono},{i.GrupoSanguineo},{i.ContactoEmergencia}");

                }
            }
        }

        private void B_RecuperarRespaldo_Click(object sender, EventArgs e)
        {
            string rutaArchivo = "C:/Users/Paco/Desktop/BaseDatos.txt";

            using (StreamReader lector = new StreamReader(rutaArchivo))
            {
                string linea;

                while ((linea = lector.ReadLine()) != null)
                {


                    string[] atributos;
                    atributos = linea.Split(',');




                    string tipo = atributos[0];
                    string nombre = atributos[1];
                    string apellidos = atributos[2];
                    string nombreUsuario = atributos[3];
                    string passwordUsuario = atributos[4];
                    string genero = atributos[5];
                    int edad = int.Parse(atributos[6]);
                    string telefono = atributos[7];
                    string grupoSanguineo = atributos[8];
                    string contactoEmergencia = atributos[9];

                    if (atributos[0] == "P")
                    {
                        //es paciente
                        Paciente nuevoPaciente = new Paciente();
                        

                        nuevoPaciente.Nombre = nombre;
                        nuevoPaciente.Apellidos = apellidos;
                        nuevoPaciente.UsuarioPersona.NombreUsuario = nombreUsuario;
                        nuevoPaciente.UsuarioPersona.PasswordUsuario = passwordUsuario;
                        nuevoPaciente.Genero = genero;
                        nuevoPaciente.Edad = edad;
                        nuevoPaciente.Telefono = telefono;
                        nuevoPaciente.GrupoSanguineo = grupoSanguineo;
                        nuevoPaciente.ContactoEmergencia = contactoEmergencia;

                        Paciente buscarRepetido = new Paciente();
                        buscarRepetido = (Paciente)h.buscarUsuario(nuevoPaciente.UsuarioPersona.NombreUsuario);

                        if(buscarRepetido == null)
                        {
                            h.listaPacientes.Add(nuevoPaciente);
                        }
                        

                        
                    }
                    if (atributos[0] == "D")
                    {
                        //es doctor
                        Doctor nuevoDoctor = new Doctor();

                        nuevoDoctor.Nombre = nombre;
                        nuevoDoctor.Apellidos = apellidos;
                        nuevoDoctor.UsuarioPersona.NombreUsuario = nombreUsuario;
                        nuevoDoctor.UsuarioPersona.PasswordUsuario = passwordUsuario;
                        nuevoDoctor.Genero = genero;
                        nuevoDoctor.Edad = edad;
                        nuevoDoctor.Telefono = telefono;
                        nuevoDoctor.GrupoSanguineo = grupoSanguineo;
                        nuevoDoctor.ContactoEmergencia = contactoEmergencia;

                        Doctor buscarRepetido = new Doctor();
                        buscarRepetido = (Doctor)h.buscarUsuario(nuevoDoctor.UsuarioPersona.NombreUsuario);

                        if (buscarRepetido == null)
                        {
                            h.listaDoctores.Add(nuevoDoctor);
                        }

                        
                    }
                    if (atributos[0] == "A")
                    {
                        //es administrativo
                        Admin nuevoAdministrativo = new Admin();

                        nuevoAdministrativo.Nombre = nombre;
                        nuevoAdministrativo.Apellidos = apellidos;
                        nuevoAdministrativo.UsuarioPersona.NombreUsuario = nombreUsuario;
                        nuevoAdministrativo.UsuarioPersona.PasswordUsuario = passwordUsuario;
                        nuevoAdministrativo.Genero = genero;
                        nuevoAdministrativo.Edad = edad;
                        nuevoAdministrativo.Telefono = telefono;
                        nuevoAdministrativo.GrupoSanguineo = grupoSanguineo;
                        nuevoAdministrativo.ContactoEmergencia = contactoEmergencia;

                        Admin buscarRepetido = new Admin();
                        buscarRepetido = (Admin)h.buscarUsuario(nuevoAdministrativo.UsuarioPersona.NombreUsuario);

                        if (buscarRepetido == null)
                        {
                            h.listaAdmins.Add(nuevoAdministrativo);
                        }
                        
                    }
                    if (atributos[0] == "I")
                    {
                        //es administrativo
                        IngSistemas nuevoSistemas = new IngSistemas();

                        nuevoSistemas.Nombre = nombre;
                        nuevoSistemas.Apellidos = apellidos;
                        nuevoSistemas.UsuarioPersona.NombreUsuario = nombreUsuario;
                        nuevoSistemas.UsuarioPersona.PasswordUsuario = passwordUsuario;
                        nuevoSistemas.Genero = genero;
                        nuevoSistemas.Edad = edad;
                        nuevoSistemas.Telefono = telefono;
                        nuevoSistemas.GrupoSanguineo = grupoSanguineo;
                        nuevoSistemas.ContactoEmergencia = contactoEmergencia;


                        IngSistemas buscarRepetido = new IngSistemas();
                        buscarRepetido = (IngSistemas)h.buscarUsuario(nuevoSistemas.UsuarioPersona.NombreUsuario);

                        if (buscarRepetido == null)
                        {
                            h.listaSistemas.Add(nuevoSistemas);
                        }
                        
                    }

                }



            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
