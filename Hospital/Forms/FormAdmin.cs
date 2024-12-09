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
using Hospital.Forms.FormsSistemas;

namespace Hospital.Forms
{
    public partial class FormAdmin : FormDatosPersona
    {
        public Hosp h;
        public Form1 form1;
        public Admin a;
        public FormAdmin(Hosp hosp, Form1 mainForm, Admin adm)
        {
            InitializeComponent();
            h = hosp;  
            form1 = mainForm;
            a = adm;
        }
        private void FormAdmin_FormClosing(object sender, EventArgs e)
        {
            form1.Show();
        }
        private void FormAdmin_Load(object sender, EventArgs e)
        {
            TB_NombreDatos.Text = a.Nombre;
            TB_ApellidosDatos.Text = a.Apellidos;
            TB_UsuarioDatos.Text = a.UsuarioPersona.NombreUsuario;
            TB_PasswordDatos.Text = a.UsuarioPersona.PasswordUsuario;

        
        }

        private void B_AdministrarCuartos_Click(object sender, EventArgs e)
        {

        }

        private void B_AdministrarPersonas_Click(object sender, EventArgs e)
        {
            FormAdminPersonas formA = new FormAdminPersonas(h, null, form1, this);
            formA.Show();
            this.Hide();
        }

        private void B_CrearPersonasA_Click(object sender, EventArgs e)
        {
            FormCrearPersona formC = new FormCrearPersona(h, null, form1, this);
            formC.Show();
            this.Hide();
        }
    }
}
