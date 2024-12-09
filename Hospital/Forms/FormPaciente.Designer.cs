namespace Hospital.Forms
{
    partial class FormPaciente
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
            this.B_SolicitarBaja = new System.Windows.Forms.Button();
            this.GB_DatosPaciente = new System.Windows.Forms.GroupBox();
            this.L_DiagnosticoP = new System.Windows.Forms.Label();
            this.L_HabitacionP = new System.Windows.Forms.Label();
            this.L_MedicoP = new System.Windows.Forms.Label();
            this.TB_HabitacionP = new System.Windows.Forms.TextBox();
            this.TB_MedicoAsignadoP = new System.Windows.Forms.TextBox();
            this.CB_DiagnosticosP = new System.Windows.Forms.ComboBox();
            this.B_EditarPaciente = new System.Windows.Forms.Button();
            this.GB_DatosPersona.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_EdadDatos)).BeginInit();
            this.GB_Direccion.SuspendLayout();
            this.GB_DatosPaciente.SuspendLayout();
            this.SuspendLayout();
            // 
            // B_SolicitarBaja
            // 
            this.B_SolicitarBaja.Location = new System.Drawing.Point(711, 359);
            this.B_SolicitarBaja.Name = "B_SolicitarBaja";
            this.B_SolicitarBaja.Size = new System.Drawing.Size(124, 60);
            this.B_SolicitarBaja.TabIndex = 5;
            this.B_SolicitarBaja.Text = "Solicitar baja";
            this.B_SolicitarBaja.UseVisualStyleBackColor = true;
            this.B_SolicitarBaja.Click += new System.EventHandler(this.B_SolicitarBaja_Click);
            // 
            // GB_DatosPaciente
            // 
            this.GB_DatosPaciente.Controls.Add(this.CB_DiagnosticosP);
            this.GB_DatosPaciente.Controls.Add(this.TB_MedicoAsignadoP);
            this.GB_DatosPaciente.Controls.Add(this.TB_HabitacionP);
            this.GB_DatosPaciente.Controls.Add(this.L_MedicoP);
            this.GB_DatosPaciente.Controls.Add(this.L_HabitacionP);
            this.GB_DatosPaciente.Controls.Add(this.L_DiagnosticoP);
            this.GB_DatosPaciente.Location = new System.Drawing.Point(423, 259);
            this.GB_DatosPaciente.Name = "GB_DatosPaciente";
            this.GB_DatosPaciente.Size = new System.Drawing.Size(258, 160);
            this.GB_DatosPaciente.TabIndex = 6;
            this.GB_DatosPaciente.TabStop = false;
            this.GB_DatosPaciente.Text = "Paciente";
            // 
            // L_DiagnosticoP
            // 
            this.L_DiagnosticoP.AutoSize = true;
            this.L_DiagnosticoP.Location = new System.Drawing.Point(15, 32);
            this.L_DiagnosticoP.Name = "L_DiagnosticoP";
            this.L_DiagnosticoP.Size = new System.Drawing.Size(97, 20);
            this.L_DiagnosticoP.TabIndex = 0;
            this.L_DiagnosticoP.Text = "Diagnostico:";
            // 
            // L_HabitacionP
            // 
            this.L_HabitacionP.AutoSize = true;
            this.L_HabitacionP.Location = new System.Drawing.Point(15, 67);
            this.L_HabitacionP.Name = "L_HabitacionP";
            this.L_HabitacionP.Size = new System.Drawing.Size(89, 20);
            this.L_HabitacionP.TabIndex = 1;
            this.L_HabitacionP.Text = "Habitacion:";
            // 
            // L_MedicoP
            // 
            this.L_MedicoP.AutoSize = true;
            this.L_MedicoP.Location = new System.Drawing.Point(15, 100);
            this.L_MedicoP.Name = "L_MedicoP";
            this.L_MedicoP.Size = new System.Drawing.Size(78, 40);
            this.L_MedicoP.TabIndex = 2;
            this.L_MedicoP.Text = "Medico \r\nasignado:\r\n";
            // 
            // TB_HabitacionP
            // 
            this.TB_HabitacionP.Location = new System.Drawing.Point(173, 64);
            this.TB_HabitacionP.Name = "TB_HabitacionP";
            this.TB_HabitacionP.Size = new System.Drawing.Size(68, 26);
            this.TB_HabitacionP.TabIndex = 4;
            // 
            // TB_MedicoAsignadoP
            // 
            this.TB_MedicoAsignadoP.Location = new System.Drawing.Point(118, 114);
            this.TB_MedicoAsignadoP.Name = "TB_MedicoAsignadoP";
            this.TB_MedicoAsignadoP.Size = new System.Drawing.Size(123, 26);
            this.TB_MedicoAsignadoP.TabIndex = 5;
            // 
            // CB_DiagnosticosP
            // 
            this.CB_DiagnosticosP.FormattingEnabled = true;
            this.CB_DiagnosticosP.Location = new System.Drawing.Point(120, 29);
            this.CB_DiagnosticosP.Name = "CB_DiagnosticosP";
            this.CB_DiagnosticosP.Size = new System.Drawing.Size(121, 28);
            this.CB_DiagnosticosP.TabIndex = 6;
            // 
            // B_EditarPaciente
            // 
            this.B_EditarPaciente.Location = new System.Drawing.Point(711, 293);
            this.B_EditarPaciente.Name = "B_EditarPaciente";
            this.B_EditarPaciente.Size = new System.Drawing.Size(124, 60);
            this.B_EditarPaciente.TabIndex = 7;
            this.B_EditarPaciente.Text = "Actualizar Informacion";
            this.B_EditarPaciente.UseVisualStyleBackColor = true;
            this.B_EditarPaciente.Click += new System.EventHandler(this.B_EditarPaciente_Click);
            // 
            // FormPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 450);
            this.Controls.Add(this.B_EditarPaciente);
            this.Controls.Add(this.GB_DatosPaciente);
            this.Controls.Add(this.B_SolicitarBaja);
            this.Name = "FormPaciente";
            this.Text = "Paciente";
            this.Load += new System.EventHandler(this.FormPaciente_Load);
            this.Controls.SetChildIndex(this.GB_DatosPersona, 0);
            this.Controls.SetChildIndex(this.GB_Direccion, 0);
            this.Controls.SetChildIndex(this.B_SolicitarBaja, 0);
            this.Controls.SetChildIndex(this.GB_DatosPaciente, 0);
            this.Controls.SetChildIndex(this.B_EditarPaciente, 0);
            this.GB_DatosPersona.ResumeLayout(false);
            this.GB_DatosPersona.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_EdadDatos)).EndInit();
            this.GB_Direccion.ResumeLayout(false);
            this.GB_Direccion.PerformLayout();
            this.GB_DatosPaciente.ResumeLayout(false);
            this.GB_DatosPaciente.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button B_SolicitarBaja;
        private System.Windows.Forms.GroupBox GB_DatosPaciente;
        private System.Windows.Forms.Label L_MedicoP;
        private System.Windows.Forms.Label L_HabitacionP;
        private System.Windows.Forms.Label L_DiagnosticoP;
        private System.Windows.Forms.TextBox TB_MedicoAsignadoP;
        private System.Windows.Forms.TextBox TB_HabitacionP;
        private System.Windows.Forms.ComboBox CB_DiagnosticosP;
        private System.Windows.Forms.Button B_EditarPaciente;
    }
}