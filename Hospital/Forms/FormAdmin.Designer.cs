namespace Hospital.Forms
{
    partial class FormAdmin
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
            this.GB_Admin = new System.Windows.Forms.GroupBox();
            this.B_CrearPersonasA = new System.Windows.Forms.Button();
            this.B_AdministrarPersonas = new System.Windows.Forms.Button();
            this.B_AdministrarCuartos = new System.Windows.Forms.Button();
            this.GB_DatosPersona.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_EdadDatos)).BeginInit();
            this.GB_Direccion.SuspendLayout();
            this.SuspendLayout();
            // 
            // GB_Admin
            // 
            this.GB_Admin.Location = new System.Drawing.Point(423, 233);
            this.GB_Admin.Name = "GB_Admin";
            this.GB_Admin.Size = new System.Drawing.Size(258, 201);
            this.GB_Admin.TabIndex = 5;
            this.GB_Admin.TabStop = false;
            this.GB_Admin.Text = "Admin";
            // 
            // B_CrearPersonasA
            // 
            this.B_CrearPersonasA.Location = new System.Drawing.Point(721, 222);
            this.B_CrearPersonasA.Name = "B_CrearPersonasA";
            this.B_CrearPersonasA.Size = new System.Drawing.Size(146, 63);
            this.B_CrearPersonasA.TabIndex = 8;
            this.B_CrearPersonasA.Text = "Crear Personas";
            this.B_CrearPersonasA.UseVisualStyleBackColor = true;
            this.B_CrearPersonasA.Click += new System.EventHandler(this.B_CrearPersonasA_Click);
            // 
            // B_AdministrarPersonas
            // 
            this.B_AdministrarPersonas.Location = new System.Drawing.Point(721, 297);
            this.B_AdministrarPersonas.Name = "B_AdministrarPersonas";
            this.B_AdministrarPersonas.Size = new System.Drawing.Size(146, 63);
            this.B_AdministrarPersonas.TabIndex = 7;
            this.B_AdministrarPersonas.Text = "Administrar Personas";
            this.B_AdministrarPersonas.UseVisualStyleBackColor = true;
            this.B_AdministrarPersonas.Click += new System.EventHandler(this.B_AdministrarPersonas_Click);
            // 
            // B_AdministrarCuartos
            // 
            this.B_AdministrarCuartos.Location = new System.Drawing.Point(721, 373);
            this.B_AdministrarCuartos.Name = "B_AdministrarCuartos";
            this.B_AdministrarCuartos.Size = new System.Drawing.Size(146, 63);
            this.B_AdministrarCuartos.TabIndex = 6;
            this.B_AdministrarCuartos.Text = "Administrar Cuartos";
            this.B_AdministrarCuartos.UseVisualStyleBackColor = true;
            this.B_AdministrarCuartos.Click += new System.EventHandler(this.B_AdministrarCuartos_Click);
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 450);
            this.Controls.Add(this.B_CrearPersonasA);
            this.Controls.Add(this.B_AdministrarPersonas);
            this.Controls.Add(this.B_AdministrarCuartos);
            this.Controls.Add(this.GB_Admin);
            this.Name = "FormAdmin";
            this.Text = "Administrador";
            this.Load += new System.EventHandler(this.FormAdmin_Load);
            this.Controls.SetChildIndex(this.GB_Admin, 0);
            this.Controls.SetChildIndex(this.B_AdministrarCuartos, 0);
            this.Controls.SetChildIndex(this.B_AdministrarPersonas, 0);
            this.Controls.SetChildIndex(this.B_CrearPersonasA, 0);
            this.Controls.SetChildIndex(this.GB_DatosPersona, 0);
            this.Controls.SetChildIndex(this.GB_Direccion, 0);
            this.GB_DatosPersona.ResumeLayout(false);
            this.GB_DatosPersona.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_EdadDatos)).EndInit();
            this.GB_Direccion.ResumeLayout(false);
            this.GB_Direccion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GB_Admin;
        private System.Windows.Forms.Button B_CrearPersonasA;
        private System.Windows.Forms.Button B_AdministrarPersonas;
        private System.Windows.Forms.Button B_AdministrarCuartos;
    }
}