using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppHospital2.Clases;

namespace Hospital.Forms.FormsSistemas
{
    public partial class FormAdminPersonas : FormDatosPersona
    {
        public Hosp h;
        public FormSistemas formSistemas;
        public Form1 form1;
        public FormAdmin formAdmin;
        public FormAdminPersonas(Hosp hosp, FormSistemas fS, Form1 mainForm, FormAdmin fA)
        {
            InitializeComponent();
            h = hosp;
            formSistemas = fS;
            form1 = mainForm;
            formAdmin = fA;
            
            
        }
        private void FormAdminPersonas_FormClosing(object sender, EventArgs e)
        {
            if (formSistemas != null)
            {
                formSistemas.Show();
            }
            if (formAdmin != null)
            {
                formAdmin.Show();
            }
        }
        private void FormAdminPersonas_Load(object sender, EventArgs e)
        {
            foreach(Paciente p in h.listaPacientes)
            {
                CB_ListaPersonas.Items.Add(p);
                if(p.BajaSolicitada == true)
                {
                    CB_BajasSolicitadas.Items.Add(p);
                }
            }
            foreach(Doctor d in h.listaDoctores)
            {
                CB_ListaPersonas.Items.Add(d);
                if (d.BajaSolicitada == true)
                {
                    CB_BajasSolicitadas.Items.Add(d);
                }
            }
            foreach(Admin a in h.listaAdmins)
            {
                CB_ListaPersonas.Items.Add(a);
                if (a.BajaSolicitada == true)
                {
                    CB_BajasSolicitadas.Items.Add(a);
                }
            }
            foreach(IngSistemas i in h.listaSistemas)
            {
                CB_ListaPersonas.Items.Add(i);
                if (i.BajaSolicitada == true)
                {
                    CB_BajasSolicitadas.Items.Add(i);
                }
            }
            
            
            
        }

        private void CB_ListaPersonas_SelectedIndexChanged(object sender, EventArgs e)
        {
            Persona verDatos = h.buscarUsuario(CB_ListaPersonas.SelectedItem.ToString());
            TB_NombreDatos.Text = verDatos.Nombre;
            TB_ApellidosDatos.Text = verDatos.Apellidos;
            TB_UsuarioDatos.Text = verDatos.UsuarioPersona.NombreUsuario;
            TB_PasswordDatos.Text = verDatos.UsuarioPersona.PasswordUsuario;
            if (verDatos is Paciente)
            {
                //Mostrar datos de paciente
            }
            if(verDatos is Doctor)
            {
                //Mostrar datos de doctor
            }
        }

        private void B_Eliminar_Click(object sender, EventArgs e)
        {
            int i, j;
            
            if (CB_ListaPersonas.SelectedItem == null && CB_BajasSolicitadas == null)
            {
                
                MessageBox.Show("Debe seleccionar el paciente a eliminar!");
            } else
            {
                i = h.listaPacientes.FindIndex(p => p.UsuarioPersona.NombreUsuario == CB_ListaPersonas.SelectedItem.ToString());
                j = h.listaPacientes.FindIndex(p => p.UsuarioPersona.NombreUsuario == CB_BajasSolicitadas.SelectedItem.ToString());
               
                h.listaPacientes.RemoveAt(i);
                MessageBox.Show("Persona eliminada con exito!");
            }
            
            
        }
    }
}
