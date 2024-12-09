using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppHospital2.Clases;

namespace Hospital.Forms.FormsSistemas
{
    public partial class FormCrearPersona : FormDatosPersona
    {
        public Form1 form1;
        public FormSistemas formSistemas;
        public Hosp h = new Hosp();
        public FormAdmin formAdmin;
        public FormCrearPersona(Hosp hosp, FormSistemas fS, Form1 mainForm, FormAdmin fA)
        {
            InitializeComponent();
            form1 = mainForm;
            h = form1.h;
            formSistemas = fS;
            formAdmin = fA;
            this.FormClosing += new FormClosingEventHandler(FormCrearPersona_FormClosing);
        }
        private void FormCrearPersona_FormClosing(object sender, EventArgs e)
        {
            if(formSistemas != null)
            {
                formSistemas.Show();
            }
            if(formAdmin != null)
            {
                formAdmin.Show();
            }
        }
        private void FormCrearPersona_Load(object sender, EventArgs e)
        {
            if(formAdmin != null)
            {
                CB_TipoPersonaCrear.Items.Remove("Sistemas");
            }
        }


        private void B_CrearPersona_Click(object sender, EventArgs e)
        {
            if(TB_NombreDatos.Text.Length == 0)
            {
                MessageBox.Show("No puede omitir el nombre!");
            } else
            {
                //checar apellidos
                if(TB_ApellidosDatos.Text.Length == 0)
                {
                    MessageBox.Show("No puede omitir los apellidos!");
                } else
                {
                    //checar usuario
                    if(TB_UsuarioDatos.Text.Length == 0)
                    {
                        MessageBox.Show("No puede omitir el usuario!");
                    } else
                    {
                        Persona personaCreada = new Persona();
                        personaCreada = h.buscarUsuario(TB_UsuarioDatos.Text);

                        if (personaCreada == null)
                        {
                            if (TB_PasswordDatos.Text.Length == 0)
                            {
                                MessageBox.Show("No puede omitir la contraseña!");
                            }
                            else
                            {
                                if(CB_TipoPersonaCrear.SelectedItem == null)
                                {
                                    MessageBox.Show("Debe seleccionar un tipo de persona!");
                                } else
                                {
                                    if (CB_TipoPersonaCrear.SelectedItem.ToString() == "Paciente")
                                    {
                                        //Creamos paciente
                                        Paciente n = new Paciente();
                                        n.Nombre = TB_NombreDatos.Text;
                                        n.Apellidos = TB_ApellidosDatos.Text;
                                        n.UsuarioPersona.NombreUsuario = TB_UsuarioDatos.Text;
                                        n.UsuarioPersona.PasswordUsuario = TB_PasswordDatos.Text;

                                        h.listaPacientes.Add(n);
                                        form1.h = h;

                                        MessageBox.Show("Paciente creado con exito!");

                                    }
                                    else
                                    {
                                        if (CB_TipoPersonaCrear.SelectedItem.ToString() == "Doctor")
                                        {
                                            Doctor n = new Doctor();
                                            n.Nombre = TB_NombreDatos.Text;
                                            n.Apellidos = TB_ApellidosDatos.Text;
                                            n.UsuarioPersona.NombreUsuario = TB_UsuarioDatos.Text;
                                            n.UsuarioPersona.PasswordUsuario = TB_PasswordDatos.Text;

                                            h.listaDoctores.Add(n);
                                            form1.h = h;

                                            MessageBox.Show("Doctor creado con exito!");
                                        }
                                        else
                                        {
                                            if (CB_TipoPersonaCrear.SelectedItem.ToString() == "Admin")
                                            {
                                                Admin n = new Admin();
                                                n.Nombre = TB_NombreDatos.Text;
                                                n.Apellidos = TB_ApellidosDatos.Text;
                                                n.UsuarioPersona.NombreUsuario = TB_UsuarioDatos.Text;
                                                n.UsuarioPersona.PasswordUsuario = TB_PasswordDatos.Text;

                                                h.listaAdmins.Add(n);
                                                form1.h = h;

                                                MessageBox.Show("Administrativo creado con exito!");

                                            }
                                            else
                                            {
                                                if (CB_TipoPersonaCrear.SelectedItem.ToString() == "Sistemas")
                                                {
                                                    IngSistemas n = new IngSistemas();
                                                    n.Nombre = TB_NombreDatos.Text;
                                                    n.Apellidos = TB_ApellidosDatos.Text;
                                                    n.UsuarioPersona.NombreUsuario = TB_UsuarioDatos.Text;
                                                    n.UsuarioPersona.PasswordUsuario = TB_PasswordDatos.Text;

                                                    h.listaSistemas.Add(n);
                                                    form1.h = h;

                                                    MessageBox.Show("Sistemas creado con exito!");
                                                }
                                                else
                                                {
                                                    MessageBox.Show("Seleccione un tipo de persona!");
                                                }

                                            }
                                        }
                                    }
                                }
                                


                            }
                        }
                        else 
                            {
                                MessageBox.Show("Ya existe una persona con ese usuario!");
                            
                        }

                            
                    }
                }
                    
            }
            
        }

        private void CB_TipoPersonaCrear_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
