namespace Hospital.Forms
{
    partial class FormSistemas
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
            this.B_CrearPersona = new System.Windows.Forms.Button();
            this.B_AdminPersonas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // B_CrearPersona
            // 
            this.B_CrearPersona.Location = new System.Drawing.Point(12, 12);
            this.B_CrearPersona.Name = "B_CrearPersona";
            this.B_CrearPersona.Size = new System.Drawing.Size(139, 52);
            this.B_CrearPersona.TabIndex = 0;
            this.B_CrearPersona.Text = "Crear Persona";
            this.B_CrearPersona.UseVisualStyleBackColor = true;
            this.B_CrearPersona.Click += new System.EventHandler(this.B_CrearPersona_Click);
            // 
            // B_AdminPersonas
            // 
            this.B_AdminPersonas.Location = new System.Drawing.Point(12, 70);
            this.B_AdminPersonas.Name = "B_AdminPersonas";
            this.B_AdminPersonas.Size = new System.Drawing.Size(139, 52);
            this.B_AdminPersonas.TabIndex = 1;
            this.B_AdminPersonas.Text = "Administrar Personas";
            this.B_AdminPersonas.UseVisualStyleBackColor = true;
            this.B_AdminPersonas.Click += new System.EventHandler(this.B_AdminPersonas_Click);
            // 
            // FormSistemas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.B_AdminPersonas);
            this.Controls.Add(this.B_CrearPersona);
            this.Name = "FormSistemas";
            this.Text = "Sistemas";
            this.Load += new System.EventHandler(this.FormSistemas_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button B_CrearPersona;
        private System.Windows.Forms.Button B_AdminPersonas;
    }
}