namespace Hospital.Forms
{
    partial class FormDoctor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
        private void InitializeComponent()
        {
            this.GB_DoctorD = new System.Windows.Forms.GroupBox();
            this.L_Especialidad = new System.Windows.Forms.Label();
            this.L_PacientesD = new System.Windows.Forms.Label();
            this.TB_EspecialidadD = new System.Windows.Forms.TextBox();
            this.CB_PacientesD = new System.Windows.Forms.ComboBox();
            this.B_VerPacienteD = new System.Windows.Forms.Button();
            this.GB_DatosPersona.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_EdadDatos)).BeginInit();
            this.GB_Direccion.SuspendLayout();
            this.GB_DoctorD.SuspendLayout();
            this.SuspendLayout();
            // 
            // GB_DoctorD
            // 
            this.GB_DoctorD.Controls.Add(this.CB_PacientesD);
            this.GB_DoctorD.Controls.Add(this.TB_EspecialidadD);
            this.GB_DoctorD.Controls.Add(this.L_PacientesD);
            this.GB_DoctorD.Controls.Add(this.L_Especialidad);
            this.GB_DoctorD.Location = new System.Drawing.Point(423, 265);
            this.GB_DoctorD.Name = "GB_DoctorD";
            this.GB_DoctorD.Size = new System.Drawing.Size(258, 169);
            this.GB_DoctorD.TabIndex = 5;
            this.GB_DoctorD.TabStop = false;
            this.GB_DoctorD.Text = "Doctor";
            // 
            // L_Especialidad
            // 
            this.L_Especialidad.AutoSize = true;
            this.L_Especialidad.Location = new System.Drawing.Point(15, 47);
            this.L_Especialidad.Name = "L_Especialidad";
            this.L_Especialidad.Size = new System.Drawing.Size(103, 20);
            this.L_Especialidad.TabIndex = 0;
            this.L_Especialidad.Text = "Especialidad:";
            // 
            // L_PacientesD
            // 
            this.L_PacientesD.AutoSize = true;
            this.L_PacientesD.Location = new System.Drawing.Point(15, 83);
            this.L_PacientesD.Name = "L_PacientesD";
            this.L_PacientesD.Size = new System.Drawing.Size(83, 20);
            this.L_PacientesD.TabIndex = 1;
            this.L_PacientesD.Text = "Pacientes:";
            // 
            // TB_EspecialidadD
            // 
            this.TB_EspecialidadD.Location = new System.Drawing.Point(133, 41);
            this.TB_EspecialidadD.Name = "TB_EspecialidadD";
            this.TB_EspecialidadD.Size = new System.Drawing.Size(100, 26);
            this.TB_EspecialidadD.TabIndex = 2;
            // 
            // CB_PacientesD
            // 
            this.CB_PacientesD.FormattingEnabled = true;
            this.CB_PacientesD.Location = new System.Drawing.Point(112, 73);
            this.CB_PacientesD.Name = "CB_PacientesD";
            this.CB_PacientesD.Size = new System.Drawing.Size(121, 28);
            this.CB_PacientesD.TabIndex = 3;
            // 
            // B_VerPacienteD
            // 
            this.B_VerPacienteD.Location = new System.Drawing.Point(736, 390);
            this.B_VerPacienteD.Name = "B_VerPacienteD";
            this.B_VerPacienteD.Size = new System.Drawing.Size(141, 63);
            this.B_VerPacienteD.TabIndex = 6;
            this.B_VerPacienteD.Text = "Ver Paciente";
            this.B_VerPacienteD.UseVisualStyleBackColor = true;
            this.B_VerPacienteD.Click += new System.EventHandler(this.B_VerPacienteD_Click);
            // 
            // FormDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 488);
            this.Controls.Add(this.B_VerPacienteD);
            this.Controls.Add(this.GB_DoctorD);
            this.Name = "FormDoctor";
            this.Text = "Doctor";
            this.Load += new System.EventHandler(this.FormDoctor_Load);
            this.Controls.SetChildIndex(this.GB_DatosPersona, 0);
            this.Controls.SetChildIndex(this.GB_Direccion, 0);
            this.Controls.SetChildIndex(this.GB_DoctorD, 0);
            this.Controls.SetChildIndex(this.B_VerPacienteD, 0);
            this.GB_DatosPersona.ResumeLayout(false);
            this.GB_DatosPersona.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_EdadDatos)).EndInit();
            this.GB_Direccion.ResumeLayout(false);
            this.GB_Direccion.PerformLayout();
            this.GB_DoctorD.ResumeLayout(false);
            this.GB_DoctorD.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GB_DoctorD;
        private System.Windows.Forms.ComboBox CB_PacientesD;
        private System.Windows.Forms.TextBox TB_EspecialidadD;
        private System.Windows.Forms.Label L_PacientesD;
        private System.Windows.Forms.Label L_Especialidad;
        private System.Windows.Forms.Button B_VerPacienteD;
    }
}