namespace Hospital.Forms.FormsSistemas
{
    partial class FormCrearPersona
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
            this.CB_TipoPersonaCrear = new System.Windows.Forms.ComboBox();
            this.B_CrearPersona = new System.Windows.Forms.Button();
            this.GB_DatosPersona.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_EdadDatos)).BeginInit();
            this.GB_Direccion.SuspendLayout();
            this.SuspendLayout();
            // 
            // CB_TipoPersonaCrear
            // 
            this.CB_TipoPersonaCrear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_TipoPersonaCrear.FormattingEnabled = true;
            this.CB_TipoPersonaCrear.Items.AddRange(new object[] {
            "Paciente",
            "Doctor",
            "Admin",
            "Sistemas"});
            this.CB_TipoPersonaCrear.Location = new System.Drawing.Point(43, 24);
            this.CB_TipoPersonaCrear.Name = "CB_TipoPersonaCrear";
            this.CB_TipoPersonaCrear.Size = new System.Drawing.Size(121, 28);
            this.CB_TipoPersonaCrear.TabIndex = 4;
            this.CB_TipoPersonaCrear.SelectedIndexChanged += new System.EventHandler(this.CB_TipoPersonaCrear_SelectedIndexChanged);
            // 
            // B_CrearPersona
            // 
            this.B_CrearPersona.Location = new System.Drawing.Point(538, 373);
            this.B_CrearPersona.Name = "B_CrearPersona";
            this.B_CrearPersona.Size = new System.Drawing.Size(143, 61);
            this.B_CrearPersona.TabIndex = 5;
            this.B_CrearPersona.Text = "Crear Persona";
            this.B_CrearPersona.UseVisualStyleBackColor = true;
            this.B_CrearPersona.Click += new System.EventHandler(this.B_CrearPersona_Click);
            // 
            // FormCrearPersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.B_CrearPersona);
            this.Controls.Add(this.CB_TipoPersonaCrear);
            this.Name = "FormCrearPersona";
            this.Text = "Crear persona";
            this.Load += new System.EventHandler(this.FormCrearPersona_Load);
            this.Controls.SetChildIndex(this.GB_DatosPersona, 0);
            this.Controls.SetChildIndex(this.GB_Direccion, 0);
            this.Controls.SetChildIndex(this.CB_TipoPersonaCrear, 0);
            this.Controls.SetChildIndex(this.B_CrearPersona, 0);
            this.GB_DatosPersona.ResumeLayout(false);
            this.GB_DatosPersona.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_EdadDatos)).EndInit();
            this.GB_Direccion.ResumeLayout(false);
            this.GB_Direccion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox CB_TipoPersonaCrear;
        private System.Windows.Forms.Button B_CrearPersona;
    }
}