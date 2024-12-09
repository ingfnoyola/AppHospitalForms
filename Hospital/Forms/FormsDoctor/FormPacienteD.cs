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
    public partial class FormPacienteD : FormDatosPersona
    {
        public Paciente p;
        public Hosp h;
        public Form1 form1;
        public FormPacienteD(Paciente pa, Hosp hosp, Form1 mainForm)
        {
            InitializeComponent();
            p = pa;
            h = hosp;
            form1 = mainForm;
        }

        private void FormPacienteD_Load(object sender, EventArgs e)
        {
            this.Text = p.ToString();
            TB_NombreDatos.Text = p.Nombre;
            TB_ApellidosDatos.Text = p.Apellidos;
            TB_UsuarioDatos.Text = p.UsuarioPersona.NombreUsuario;
            TB_PasswordDatos.Text = p.UsuarioPersona.PasswordUsuario;

            TB_NombreDatos.ReadOnly = true;
            TB_ApellidosDatos.ReadOnly = true;
            TB_UsuarioDatos.ReadOnly = true;
            TB_PasswordDatos.ReadOnly = true;

            foreach (string d in p.Diagnostico)
            {
                CB_Diagnosticos.Items.Add(d);
            }
            TB_CuartoD.Text = p.cuartoAsignado;

            CB_Diagnosticos.DropDownStyle = ComboBoxStyle.DropDownList;
            TB_CuartoD.ReadOnly = true;

            TB_EstadoDP.Text = p.Estado;
         
        }

        private void B_NuevoDiag_Click(object sender, EventArgs e)
        {
            p.Diagnostico.Add(TB_NuevoD.Text);
            CB_Diagnosticos.Items.Clear();
            foreach (string d in p.Diagnostico)
            {
                CB_Diagnosticos.Items.Add(d);
            }
        }

        private void B_DarAlta_Click(object sender, EventArgs e)
        {
            p.Estado = "Dado de alta";
            TB_EstadoDP.Text = p.Estado;
            MessageBox.Show("Paciente dado de alta correctamente!");
        }
    }
}
