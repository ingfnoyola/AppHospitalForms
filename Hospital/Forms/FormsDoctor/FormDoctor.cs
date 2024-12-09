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
    public partial class FormDoctor : FormDatosPersona
    {
        public Hosp h;
        public Form1 form1;
        public Doctor d;
        public FormDoctor(Hosp hosp, Form1 mainForm, Doctor doc)
        {
            InitializeComponent();
            h = hosp;
            form1 = mainForm;
            d = doc;
        }

        private void FormDoctor_Load(object sender, EventArgs e)
        {
            TB_NombreDatos.Text = d.Nombre;
            TB_ApellidosDatos.Text = d.Apellidos;
            TB_UsuarioDatos.Text = d.UsuarioPersona.NombreUsuario;
            TB_PasswordDatos.Text = d.UsuarioPersona.PasswordUsuario;

            foreach(string p in d.pacientes)
            {
                CB_PacientesD.Items.Add(p);
            }
            TB_EspecialidadD.Text = d.Especialidad;
            
            CB_PacientesD.DropDownStyle = ComboBoxStyle.DropDownList;
            TB_EspecialidadD.ReadOnly = true;
        }

        private void B_VerPacienteD_Click(object sender, EventArgs e)
        {
            // Verifica si hay un paciente seleccionado
            if (CB_PacientesD.SelectedItem != null)
            {
                Persona buscarPersona;

                buscarPersona = h.buscarUsuario(CB_PacientesD.SelectedItem.ToString());
                

                // Busca el paciente en la lista de pacientes del doctor
                

                if (buscarPersona != null)
                {
                    // Crea una instancia del formulario FormPacienteD
                    FormPacienteD formPacienteD = new FormPacienteD((buscarPersona as Paciente), h, form1);
                    formPacienteD.Show();
                }
                else
                {
                    MessageBox.Show("Paciente no encontrado.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un paciente.");
            }
        }
    }
}
