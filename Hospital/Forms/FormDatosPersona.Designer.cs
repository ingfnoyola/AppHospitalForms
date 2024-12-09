namespace Hospital.Forms { 
    public partial class FormDatosPersona
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        public System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        public void InitializeComponent()
        {
            this.L_NombreDatos = new System.Windows.Forms.Label();
            this.TB_NombreDatos = new System.Windows.Forms.TextBox();
            this.L_ApellidosDatos = new System.Windows.Forms.Label();
            this.GB_DatosPersona = new System.Windows.Forms.GroupBox();
            this.TB_ApellidosDatos = new System.Windows.Forms.TextBox();
            this.L_PasswordDatos = new System.Windows.Forms.Label();
            this.TB_PasswordDatos = new System.Windows.Forms.TextBox();
            this.TB_UsuarioDatos = new System.Windows.Forms.TextBox();
            this.L_UsuarioDatos = new System.Windows.Forms.Label();
            this.CB_GeneroDatos = new System.Windows.Forms.ComboBox();
            this.L_GeneroDatos = new System.Windows.Forms.Label();
            this.L_EdadDatos = new System.Windows.Forms.Label();
            this.NUD_EdadDatos = new System.Windows.Forms.NumericUpDown();
            this.TB_TelDatos = new System.Windows.Forms.TextBox();
            this.L_TelDatos = new System.Windows.Forms.Label();
            this.L_TelEmergDatos = new System.Windows.Forms.Label();
            this.TB_TelEmergDatos = new System.Windows.Forms.TextBox();
            this.L_GpoSangDatos = new System.Windows.Forms.Label();
            this.TB_GpoSangDatos = new System.Windows.Forms.TextBox();
            this.GB_Direccion = new System.Windows.Forms.GroupBox();
            this.L_CalleDireccion = new System.Windows.Forms.Label();
            this.L_NumeroDireccion = new System.Windows.Forms.Label();
            this.L_CPDireccion = new System.Windows.Forms.Label();
            this.TB_CalleDireccion = new System.Windows.Forms.TextBox();
            this.TB_NumDireccion = new System.Windows.Forms.TextBox();
            this.TB_CPDireccion = new System.Windows.Forms.TextBox();
            this.GB_DatosPersona.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_EdadDatos)).BeginInit();
            this.GB_Direccion.SuspendLayout();
            this.SuspendLayout();
            // 
            // L_NombreDatos
            // 
            this.L_NombreDatos.AutoSize = true;
            this.L_NombreDatos.Location = new System.Drawing.Point(33, 33);
            this.L_NombreDatos.Name = "L_NombreDatos";
            this.L_NombreDatos.Size = new System.Drawing.Size(69, 20);
            this.L_NombreDatos.TabIndex = 0;
            this.L_NombreDatos.Text = "Nombre:";
            // 
            // TB_NombreDatos
            // 
            this.TB_NombreDatos.Location = new System.Drawing.Point(159, 30);
            this.TB_NombreDatos.Name = "TB_NombreDatos";
            this.TB_NombreDatos.Size = new System.Drawing.Size(132, 26);
            this.TB_NombreDatos.TabIndex = 1;
            // 
            // L_ApellidosDatos
            // 
            this.L_ApellidosDatos.AutoSize = true;
            this.L_ApellidosDatos.Location = new System.Drawing.Point(33, 68);
            this.L_ApellidosDatos.Name = "L_ApellidosDatos";
            this.L_ApellidosDatos.Size = new System.Drawing.Size(77, 20);
            this.L_ApellidosDatos.TabIndex = 2;
            this.L_ApellidosDatos.Text = "Apellidos:";
            // 
            // GB_DatosPersona
            // 
            this.GB_DatosPersona.Controls.Add(this.TB_GpoSangDatos);
            this.GB_DatosPersona.Controls.Add(this.L_GpoSangDatos);
            this.GB_DatosPersona.Controls.Add(this.TB_TelEmergDatos);
            this.GB_DatosPersona.Controls.Add(this.L_TelEmergDatos);
            this.GB_DatosPersona.Controls.Add(this.L_TelDatos);
            this.GB_DatosPersona.Controls.Add(this.TB_TelDatos);
            this.GB_DatosPersona.Controls.Add(this.NUD_EdadDatos);
            this.GB_DatosPersona.Controls.Add(this.L_EdadDatos);
            this.GB_DatosPersona.Controls.Add(this.L_GeneroDatos);
            this.GB_DatosPersona.Controls.Add(this.CB_GeneroDatos);
            this.GB_DatosPersona.Controls.Add(this.L_UsuarioDatos);
            this.GB_DatosPersona.Controls.Add(this.TB_UsuarioDatos);
            this.GB_DatosPersona.Controls.Add(this.TB_PasswordDatos);
            this.GB_DatosPersona.Controls.Add(this.L_PasswordDatos);
            this.GB_DatosPersona.Controls.Add(this.TB_ApellidosDatos);
            this.GB_DatosPersona.Controls.Add(this.L_NombreDatos);
            this.GB_DatosPersona.Controls.Add(this.L_ApellidosDatos);
            this.GB_DatosPersona.Controls.Add(this.TB_NombreDatos);
            this.GB_DatosPersona.Location = new System.Drawing.Point(43, 67);
            this.GB_DatosPersona.Name = "GB_DatosPersona";
            this.GB_DatosPersona.Size = new System.Drawing.Size(345, 367);
            this.GB_DatosPersona.TabIndex = 3;
            this.GB_DatosPersona.TabStop = false;
            this.GB_DatosPersona.Text = "Datos";
            // 
            // TB_ApellidosDatos
            // 
            this.TB_ApellidosDatos.Location = new System.Drawing.Point(159, 62);
            this.TB_ApellidosDatos.Name = "TB_ApellidosDatos";
            this.TB_ApellidosDatos.Size = new System.Drawing.Size(132, 26);
            this.TB_ApellidosDatos.TabIndex = 3;
            // 
            // L_PasswordDatos
            // 
            this.L_PasswordDatos.AutoSize = true;
            this.L_PasswordDatos.Location = new System.Drawing.Point(33, 132);
            this.L_PasswordDatos.Name = "L_PasswordDatos";
            this.L_PasswordDatos.Size = new System.Drawing.Size(96, 20);
            this.L_PasswordDatos.TabIndex = 4;
            this.L_PasswordDatos.Text = "Contraseña:";
            // 
            // TB_PasswordDatos
            // 
            this.TB_PasswordDatos.Location = new System.Drawing.Point(159, 126);
            this.TB_PasswordDatos.Name = "TB_PasswordDatos";
            this.TB_PasswordDatos.Size = new System.Drawing.Size(132, 26);
            this.TB_PasswordDatos.TabIndex = 5;
            // 
            // TB_UsuarioDatos
            // 
            this.TB_UsuarioDatos.Location = new System.Drawing.Point(159, 94);
            this.TB_UsuarioDatos.Name = "TB_UsuarioDatos";
            this.TB_UsuarioDatos.Size = new System.Drawing.Size(132, 26);
            this.TB_UsuarioDatos.TabIndex = 6;
            // 
            // L_UsuarioDatos
            // 
            this.L_UsuarioDatos.AutoSize = true;
            this.L_UsuarioDatos.Location = new System.Drawing.Point(33, 100);
            this.L_UsuarioDatos.Name = "L_UsuarioDatos";
            this.L_UsuarioDatos.Size = new System.Drawing.Size(68, 20);
            this.L_UsuarioDatos.TabIndex = 7;
            this.L_UsuarioDatos.Text = "Usuario:";
            // 
            // CB_GeneroDatos
            // 
            this.CB_GeneroDatos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_GeneroDatos.FormattingEnabled = true;
            this.CB_GeneroDatos.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.CB_GeneroDatos.Location = new System.Drawing.Point(170, 158);
            this.CB_GeneroDatos.Name = "CB_GeneroDatos";
            this.CB_GeneroDatos.Size = new System.Drawing.Size(121, 28);
            this.CB_GeneroDatos.TabIndex = 8;
            // 
            // L_GeneroDatos
            // 
            this.L_GeneroDatos.AutoSize = true;
            this.L_GeneroDatos.Location = new System.Drawing.Point(33, 166);
            this.L_GeneroDatos.Name = "L_GeneroDatos";
            this.L_GeneroDatos.Size = new System.Drawing.Size(67, 20);
            this.L_GeneroDatos.TabIndex = 9;
            this.L_GeneroDatos.Text = "Genero:";
            // 
            // L_EdadDatos
            // 
            this.L_EdadDatos.AutoSize = true;
            this.L_EdadDatos.Location = new System.Drawing.Point(33, 198);
            this.L_EdadDatos.Name = "L_EdadDatos";
            this.L_EdadDatos.Size = new System.Drawing.Size(51, 20);
            this.L_EdadDatos.TabIndex = 10;
            this.L_EdadDatos.Text = "Edad:";
            // 
            // NUD_EdadDatos
            // 
            this.NUD_EdadDatos.Location = new System.Drawing.Point(192, 192);
            this.NUD_EdadDatos.Name = "NUD_EdadDatos";
            this.NUD_EdadDatos.Size = new System.Drawing.Size(99, 26);
            this.NUD_EdadDatos.TabIndex = 11;
            // 
            // TB_TelDatos
            // 
            this.TB_TelDatos.Location = new System.Drawing.Point(159, 224);
            this.TB_TelDatos.Name = "TB_TelDatos";
            this.TB_TelDatos.Size = new System.Drawing.Size(132, 26);
            this.TB_TelDatos.TabIndex = 12;
            // 
            // L_TelDatos
            // 
            this.L_TelDatos.AutoSize = true;
            this.L_TelDatos.Location = new System.Drawing.Point(33, 230);
            this.L_TelDatos.Name = "L_TelDatos";
            this.L_TelDatos.Size = new System.Drawing.Size(75, 20);
            this.L_TelDatos.TabIndex = 13;
            this.L_TelDatos.Text = "Teléfono:";
            // 
            // L_TelEmergDatos
            // 
            this.L_TelEmergDatos.AutoSize = true;
            this.L_TelEmergDatos.Location = new System.Drawing.Point(33, 292);
            this.L_TelEmergDatos.Name = "L_TelEmergDatos";
            this.L_TelEmergDatos.Size = new System.Drawing.Size(100, 40);
            this.L_TelEmergDatos.TabIndex = 14;
            this.L_TelEmergDatos.Text = "Contacto de \r\nEmergencia:\r\n";
            // 
            // TB_TelEmergDatos
            // 
            this.TB_TelEmergDatos.Location = new System.Drawing.Point(159, 306);
            this.TB_TelEmergDatos.Name = "TB_TelEmergDatos";
            this.TB_TelEmergDatos.Size = new System.Drawing.Size(132, 26);
            this.TB_TelEmergDatos.TabIndex = 15;
            // 
            // L_GpoSangDatos
            // 
            this.L_GpoSangDatos.AutoSize = true;
            this.L_GpoSangDatos.Location = new System.Drawing.Point(33, 262);
            this.L_GpoSangDatos.Name = "L_GpoSangDatos";
            this.L_GpoSangDatos.Size = new System.Drawing.Size(129, 20);
            this.L_GpoSangDatos.TabIndex = 16;
            this.L_GpoSangDatos.Text = "Gpo. Sanguíneo:";
            // 
            // TB_GpoSangDatos
            // 
            this.TB_GpoSangDatos.Location = new System.Drawing.Point(159, 256);
            this.TB_GpoSangDatos.Name = "TB_GpoSangDatos";
            this.TB_GpoSangDatos.Size = new System.Drawing.Size(132, 26);
            this.TB_GpoSangDatos.TabIndex = 17;
            // 
            // GB_Direccion
            // 
            this.GB_Direccion.Controls.Add(this.TB_CPDireccion);
            this.GB_Direccion.Controls.Add(this.TB_NumDireccion);
            this.GB_Direccion.Controls.Add(this.TB_CalleDireccion);
            this.GB_Direccion.Controls.Add(this.L_CPDireccion);
            this.GB_Direccion.Controls.Add(this.L_NumeroDireccion);
            this.GB_Direccion.Controls.Add(this.L_CalleDireccion);
            this.GB_Direccion.Location = new System.Drawing.Point(423, 67);
            this.GB_Direccion.Name = "GB_Direccion";
            this.GB_Direccion.Size = new System.Drawing.Size(258, 152);
            this.GB_Direccion.TabIndex = 4;
            this.GB_Direccion.TabStop = false;
            this.GB_Direccion.Text = "Dirección:";
            // 
            // L_CalleDireccion
            // 
            this.L_CalleDireccion.AutoSize = true;
            this.L_CalleDireccion.Location = new System.Drawing.Point(15, 36);
            this.L_CalleDireccion.Name = "L_CalleDireccion";
            this.L_CalleDireccion.Size = new System.Drawing.Size(48, 20);
            this.L_CalleDireccion.TabIndex = 18;
            this.L_CalleDireccion.Text = "Calle:";
            // 
            // L_NumeroDireccion
            // 
            this.L_NumeroDireccion.AutoSize = true;
            this.L_NumeroDireccion.Location = new System.Drawing.Point(15, 68);
            this.L_NumeroDireccion.Name = "L_NumeroDireccion";
            this.L_NumeroDireccion.Size = new System.Drawing.Size(69, 20);
            this.L_NumeroDireccion.TabIndex = 19;
            this.L_NumeroDireccion.Text = "Numero:";
            // 
            // L_CPDireccion
            // 
            this.L_CPDireccion.AutoSize = true;
            this.L_CPDireccion.Location = new System.Drawing.Point(21, 100);
            this.L_CPDireccion.Name = "L_CPDireccion";
            this.L_CPDireccion.Size = new System.Drawing.Size(42, 20);
            this.L_CPDireccion.TabIndex = 20;
            this.L_CPDireccion.Text = "C.P.:";
            // 
            // TB_CalleDireccion
            // 
            this.TB_CalleDireccion.Location = new System.Drawing.Point(101, 30);
            this.TB_CalleDireccion.Name = "TB_CalleDireccion";
            this.TB_CalleDireccion.Size = new System.Drawing.Size(132, 26);
            this.TB_CalleDireccion.TabIndex = 18;
            // 
            // TB_NumDireccion
            // 
            this.TB_NumDireccion.Location = new System.Drawing.Point(101, 62);
            this.TB_NumDireccion.Name = "TB_NumDireccion";
            this.TB_NumDireccion.Size = new System.Drawing.Size(132, 26);
            this.TB_NumDireccion.TabIndex = 21;
            // 
            // TB_CPDireccion
            // 
            this.TB_CPDireccion.Location = new System.Drawing.Point(101, 94);
            this.TB_CPDireccion.Name = "TB_CPDireccion";
            this.TB_CPDireccion.Size = new System.Drawing.Size(132, 26);
            this.TB_CPDireccion.TabIndex = 22;
            // 
            // FormDatosPersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 465);
            this.Controls.Add(this.GB_Direccion);
            this.Controls.Add(this.GB_DatosPersona);
            this.Name = "FormDatosPersona";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormDatosPersona_Load);
            this.GB_DatosPersona.ResumeLayout(false);
            this.GB_DatosPersona.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_EdadDatos)).EndInit();
            this.GB_Direccion.ResumeLayout(false);
            this.GB_Direccion.PerformLayout();
            this.ResumeLayout(false);

        }

    #endregion

    protected System.Windows.Forms.Label L_NombreDatos;
    protected System.Windows.Forms.TextBox TB_NombreDatos;
    protected System.Windows.Forms.Label L_ApellidosDatos;
    protected System.Windows.Forms.GroupBox GB_DatosPersona;
    protected System.Windows.Forms.TextBox TB_ApellidosDatos;
    protected System.Windows.Forms.TextBox TB_PasswordDatos;
    protected System.Windows.Forms.Label L_PasswordDatos;
    protected System.Windows.Forms.Label L_UsuarioDatos;
    protected System.Windows.Forms.TextBox TB_UsuarioDatos;
    protected System.Windows.Forms.Label L_GeneroDatos;
    protected System.Windows.Forms.ComboBox CB_GeneroDatos;
    protected System.Windows.Forms.NumericUpDown NUD_EdadDatos;
    protected System.Windows.Forms.Label L_EdadDatos;
    protected System.Windows.Forms.TextBox TB_GpoSangDatos;
    protected System.Windows.Forms.Label L_GpoSangDatos;
    protected System.Windows.Forms.TextBox TB_TelEmergDatos;
    protected System.Windows.Forms.Label L_TelEmergDatos;
    protected System.Windows.Forms.Label L_TelDatos;
    protected System.Windows.Forms.TextBox TB_TelDatos;
    protected System.Windows.Forms.GroupBox GB_Direccion;
    protected System.Windows.Forms.TextBox TB_CPDireccion;
    protected System.Windows.Forms.TextBox TB_NumDireccion;
    protected System.Windows.Forms.TextBox TB_CalleDireccion;
    protected System.Windows.Forms.Label L_CPDireccion;
    protected System.Windows.Forms.Label L_NumeroDireccion;
    protected System.Windows.Forms.Label L_CalleDireccion;
    }
}