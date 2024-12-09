namespace Hospital.Forms
{
    partial class FormPacienteD
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
            this.GB_PacienteD = new System.Windows.Forms.GroupBox();
            this.TB_NuevoD = new System.Windows.Forms.TextBox();
            this.TB_CuartoD = new System.Windows.Forms.TextBox();
            this.CB_Diagnosticos = new System.Windows.Forms.ComboBox();
            this.L_NuevoDiag = new System.Windows.Forms.Label();
            this.L_HabitacionD = new System.Windows.Forms.Label();
            this.L_HistorialDiagD = new System.Windows.Forms.Label();
            this.B_NuevoDiag = new System.Windows.Forms.Button();
            this.B_DarAlta = new System.Windows.Forms.Button();
            this.L_EstadoPD = new System.Windows.Forms.Label();
            this.TB_EstadoDP = new System.Windows.Forms.TextBox();
            this.GB_DatosPersona.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_EdadDatos)).BeginInit();
            this.GB_Direccion.SuspendLayout();
            this.GB_PacienteD.SuspendLayout();
            this.SuspendLayout();
            // 
            // GB_PacienteD
            // 
            this.GB_PacienteD.Controls.Add(this.TB_NuevoD);
            this.GB_PacienteD.Controls.Add(this.TB_CuartoD);
            this.GB_PacienteD.Controls.Add(this.CB_Diagnosticos);
            this.GB_PacienteD.Controls.Add(this.L_NuevoDiag);
            this.GB_PacienteD.Controls.Add(this.L_HabitacionD);
            this.GB_PacienteD.Controls.Add(this.L_HistorialDiagD);
            this.GB_PacienteD.Location = new System.Drawing.Point(423, 259);
            this.GB_PacienteD.Name = "GB_PacienteD";
            this.GB_PacienteD.Size = new System.Drawing.Size(258, 175);
            this.GB_PacienteD.TabIndex = 5;
            this.GB_PacienteD.TabStop = false;
            this.GB_PacienteD.Text = "Paciente";
            // 
            // TB_NuevoD
            // 
            this.TB_NuevoD.Location = new System.Drawing.Point(112, 128);
            this.TB_NuevoD.Name = "TB_NuevoD";
            this.TB_NuevoD.Size = new System.Drawing.Size(121, 26);
            this.TB_NuevoD.TabIndex = 5;
            // 
            // TB_CuartoD
            // 
            this.TB_CuartoD.Location = new System.Drawing.Point(112, 73);
            this.TB_CuartoD.Name = "TB_CuartoD";
            this.TB_CuartoD.Size = new System.Drawing.Size(121, 26);
            this.TB_CuartoD.TabIndex = 4;
            // 
            // CB_Diagnosticos
            // 
            this.CB_Diagnosticos.FormattingEnabled = true;
            this.CB_Diagnosticos.Location = new System.Drawing.Point(112, 32);
            this.CB_Diagnosticos.Name = "CB_Diagnosticos";
            this.CB_Diagnosticos.Size = new System.Drawing.Size(121, 28);
            this.CB_Diagnosticos.TabIndex = 3;
            // 
            // L_NuevoDiag
            // 
            this.L_NuevoDiag.AutoSize = true;
            this.L_NuevoDiag.Location = new System.Drawing.Point(15, 114);
            this.L_NuevoDiag.Name = "L_NuevoDiag";
            this.L_NuevoDiag.Size = new System.Drawing.Size(97, 40);
            this.L_NuevoDiag.TabIndex = 2;
            this.L_NuevoDiag.Text = "Nuevo\r\nDiagnostico:\r\n";
            // 
            // L_HabitacionD
            // 
            this.L_HabitacionD.AutoSize = true;
            this.L_HabitacionD.Location = new System.Drawing.Point(15, 79);
            this.L_HabitacionD.Name = "L_HabitacionD";
            this.L_HabitacionD.Size = new System.Drawing.Size(61, 20);
            this.L_HabitacionD.TabIndex = 1;
            this.L_HabitacionD.Text = "Cuarto:";
            // 
            // L_HistorialDiagD
            // 
            this.L_HistorialDiagD.AutoSize = true;
            this.L_HistorialDiagD.Location = new System.Drawing.Point(15, 38);
            this.L_HistorialDiagD.Name = "L_HistorialDiagD";
            this.L_HistorialDiagD.Size = new System.Drawing.Size(70, 20);
            this.L_HistorialDiagD.TabIndex = 0;
            this.L_HistorialDiagD.Text = "Historial:";
            // 
            // B_NuevoDiag
            // 
            this.B_NuevoDiag.Location = new System.Drawing.Point(718, 359);
            this.B_NuevoDiag.Name = "B_NuevoDiag";
            this.B_NuevoDiag.Size = new System.Drawing.Size(116, 72);
            this.B_NuevoDiag.TabIndex = 6;
            this.B_NuevoDiag.Text = "Agregar Diagnostico";
            this.B_NuevoDiag.UseVisualStyleBackColor = true;
            this.B_NuevoDiag.Click += new System.EventHandler(this.B_NuevoDiag_Click);
            // 
            // B_DarAlta
            // 
            this.B_DarAlta.Location = new System.Drawing.Point(718, 268);
            this.B_DarAlta.Name = "B_DarAlta";
            this.B_DarAlta.Size = new System.Drawing.Size(116, 72);
            this.B_DarAlta.TabIndex = 7;
            this.B_DarAlta.Text = "Dar de Alta";
            this.B_DarAlta.UseVisualStyleBackColor = true;
            this.B_DarAlta.Click += new System.EventHandler(this.B_DarAlta_Click);
            // 
            // L_EstadoPD
            // 
            this.L_EstadoPD.AutoSize = true;
            this.L_EstadoPD.Location = new System.Drawing.Point(714, 79);
            this.L_EstadoPD.Name = "L_EstadoPD";
            this.L_EstadoPD.Size = new System.Drawing.Size(64, 20);
            this.L_EstadoPD.TabIndex = 8;
            this.L_EstadoPD.Text = "Estado:";
            // 
            // TB_EstadoDP
            // 
            this.TB_EstadoDP.Location = new System.Drawing.Point(718, 113);
            this.TB_EstadoDP.Name = "TB_EstadoDP";
            this.TB_EstadoDP.Size = new System.Drawing.Size(121, 26);
            this.TB_EstadoDP.TabIndex = 6;
            // 
            // FormPacienteD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 450);
            this.Controls.Add(this.TB_EstadoDP);
            this.Controls.Add(this.L_EstadoPD);
            this.Controls.Add(this.B_DarAlta);
            this.Controls.Add(this.B_NuevoDiag);
            this.Controls.Add(this.GB_PacienteD);
            this.Name = "FormPacienteD";
            this.Text = "Paciente";
            this.Load += new System.EventHandler(this.FormPacienteD_Load);
            this.Controls.SetChildIndex(this.GB_DatosPersona, 0);
            this.Controls.SetChildIndex(this.GB_Direccion, 0);
            this.Controls.SetChildIndex(this.GB_PacienteD, 0);
            this.Controls.SetChildIndex(this.B_NuevoDiag, 0);
            this.Controls.SetChildIndex(this.B_DarAlta, 0);
            this.Controls.SetChildIndex(this.L_EstadoPD, 0);
            this.Controls.SetChildIndex(this.TB_EstadoDP, 0);
            this.GB_DatosPersona.ResumeLayout(false);
            this.GB_DatosPersona.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_EdadDatos)).EndInit();
            this.GB_Direccion.ResumeLayout(false);
            this.GB_Direccion.PerformLayout();
            this.GB_PacienteD.ResumeLayout(false);
            this.GB_PacienteD.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GB_PacienteD;
        private System.Windows.Forms.Label L_HabitacionD;
        private System.Windows.Forms.Label L_HistorialDiagD;
        private System.Windows.Forms.TextBox TB_NuevoD;
        private System.Windows.Forms.TextBox TB_CuartoD;
        private System.Windows.Forms.ComboBox CB_Diagnosticos;
        private System.Windows.Forms.Label L_NuevoDiag;
        private System.Windows.Forms.Button B_NuevoDiag;
        private System.Windows.Forms.Button B_DarAlta;
        private System.Windows.Forms.Label L_EstadoPD;
        private System.Windows.Forms.TextBox TB_EstadoDP;
    }
}