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

namespace Hospital.Forms
{
    public partial class FormPaciente : FormDatosPersona
    {
        public Hosp h;
        public Form1 form1;
        public Paciente p;
        public FormPaciente(Hosp hosp, Form1 mainForm, Paciente pa)
        {
            InitializeComponent();
            h = hosp;
            form1 = mainForm;
            p = pa;

            
        }

        private void FormPaciente_Load(object sender, EventArgs e)
        {
            this.Text = p.ToString();
            TB_NombreDatos.Text = p.Nombre;
            TB_ApellidosDatos.Text = p.Apellidos;
            TB_UsuarioDatos.Text = p.UsuarioPersona.NombreUsuario;
            TB_PasswordDatos.Text = p.UsuarioPersona.PasswordUsuario;

            foreach(string d in p.Diagnostico)
            {
                CB_DiagnosticosP.Items.Add(d);
            }
            TB_HabitacionP.Text = p.cuartoAsignado;
            TB_MedicoAsignadoP.Text = p.Medico;
            
            CB_DiagnosticosP.DropDownStyle = ComboBoxStyle.DropDownList;
            TB_HabitacionP.ReadOnly = true;
            TB_MedicoAsignadoP.ReadOnly = true;
        }

        private void B_SolicitarBaja_Click(object sender, EventArgs e)
        {
            p.BajaSolicitada = true;
            MessageBox.Show("Haz solicitado tu baja con exito!");
        }

        private void B_EditarPaciente_Click(object sender, EventArgs e)
        {
            
            
            Persona buscarRepetido = new Persona();
            buscarRepetido = h.buscarUsuario(TB_UsuarioDatos.Text);
            if(buscarRepetido == null)
            {
                p.Nombre = TB_NombreDatos.Text;
                p.Apellidos = TB_ApellidosDatos.Text;
                p.UsuarioPersona.NombreUsuario = TB_UsuarioDatos.Text;
                p.UsuarioPersona.PasswordUsuario = TB_PasswordDatos.Text;

                MessageBox.Show("Paciente has actualizado tus datos con exito!");

            } else
            {
                if(p.UsuarioPersona.NombreUsuario == TB_UsuarioDatos.Text)
                {
                    p.Nombre = TB_NombreDatos.Text;
                    p.Apellidos = TB_ApellidosDatos.Text;
                    p.UsuarioPersona.NombreUsuario = TB_UsuarioDatos.Text;
                    p.UsuarioPersona.PasswordUsuario = TB_PasswordDatos.Text;

                    MessageBox.Show("Paciente has actualizado tus datos con exito!");
                    
                } else
                {
                    MessageBox.Show("Ya hay una persona con ese usuario!");
                }
                
            }

            
        }
    }
}
