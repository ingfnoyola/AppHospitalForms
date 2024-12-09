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
    public partial class FormSistemas : Form
    {
        public Form1 form1;
        public Hosp h;
        public FormSistemas(Hosp hosp, Form1 mainForm)
        {
            InitializeComponent();
            form1 = mainForm;
            h = hosp;

            this.FormClosing += new FormClosingEventHandler(FormSistemas_FormClosing);
        }

        
        //METODO PARA ABRIR FORM1 AL CERRAR FORM SISTEMAS
        private void FormSistemas_FormClosing(object sender, EventArgs e)
        {
            form1.Show();
        }

        private void FormSistemas_Load(object sender, EventArgs e)
        {

        }

        private void B_CrearPersona_Click(object sender, EventArgs e)
        {
            FormCrearPersona formCrearPersona = new FormCrearPersona(h, this, form1, null);
            formCrearPersona.Show();
            this.Hide();
        }

        private void B_AdminPersonas_Click(object sender, EventArgs e)
        {
            FormAdminPersonas formAdminPersonas = new FormAdminPersonas(h, this, form1, null);
            formAdminPersonas.Show();
            this.Hide();
        }
    }
}
