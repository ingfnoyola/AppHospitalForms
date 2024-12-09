namespace Hospital.Forms.FormsSistemas
{
    partial class FormAdminPersonas
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
            this.CB_ListaPersonas = new System.Windows.Forms.ComboBox();
            this.B_Eliminar = new System.Windows.Forms.Button();
            this.L_ListaPersonas = new System.Windows.Forms.Label();
            this.L_BajasSolicitadas = new System.Windows.Forms.Label();
            this.CB_BajasSolicitadas = new System.Windows.Forms.ComboBox();
            this.GB_DatosPersona.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_EdadDatos)).BeginInit();
            this.GB_Direccion.SuspendLayout();
            this.SuspendLayout();
            // 
            // CB_ListaPersonas
            // 
            this.CB_ListaPersonas.FormattingEnabled = true;
            this.CB_ListaPersonas.Location = new System.Drawing.Point(34, 33);
            this.CB_ListaPersonas.Name = "CB_ListaPersonas";
            this.CB_ListaPersonas.Size = new System.Drawing.Size(142, 28);
            this.CB_ListaPersonas.TabIndex = 0;
            this.CB_ListaPersonas.SelectedIndexChanged += new System.EventHandler(this.CB_ListaPersonas_SelectedIndexChanged);
            // 
            // B_Eliminar
            // 
            this.B_Eliminar.Location = new System.Drawing.Point(732, 388);
            this.B_Eliminar.Name = "B_Eliminar";
            this.B_Eliminar.Size = new System.Drawing.Size(121, 50);
            this.B_Eliminar.TabIndex = 5;
            this.B_Eliminar.Text = "Eliminar";
            this.B_Eliminar.UseVisualStyleBackColor = true;
            this.B_Eliminar.Click += new System.EventHandler(this.B_Eliminar_Click);
            // 
            // L_ListaPersonas
            // 
            this.L_ListaPersonas.AutoSize = true;
            this.L_ListaPersonas.Location = new System.Drawing.Point(30, 9);
            this.L_ListaPersonas.Name = "L_ListaPersonas";
            this.L_ListaPersonas.Size = new System.Drawing.Size(139, 20);
            this.L_ListaPersonas.TabIndex = 6;
            this.L_ListaPersonas.Text = "Lista de personas:";
            // 
            // L_BajasSolicitadas
            // 
            this.L_BajasSolicitadas.AutoSize = true;
            this.L_BajasSolicitadas.Location = new System.Drawing.Point(633, 9);
            this.L_BajasSolicitadas.Name = "L_BajasSolicitadas";
            this.L_BajasSolicitadas.Size = new System.Drawing.Size(220, 20);
            this.L_BajasSolicitadas.TabIndex = 7;
            this.L_BajasSolicitadas.Text = "Personas que solicitaron baja:";
            // 
            // CB_BajasSolicitadas
            // 
            this.CB_BajasSolicitadas.FormattingEnabled = true;
            this.CB_BajasSolicitadas.Location = new System.Drawing.Point(711, 33);
            this.CB_BajasSolicitadas.Name = "CB_BajasSolicitadas";
            this.CB_BajasSolicitadas.Size = new System.Drawing.Size(142, 28);
            this.CB_BajasSolicitadas.TabIndex = 8;
            // 
            // FormAdminPersonas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 450);
            this.Controls.Add(this.CB_BajasSolicitadas);
            this.Controls.Add(this.L_BajasSolicitadas);
            this.Controls.Add(this.L_ListaPersonas);
            this.Controls.Add(this.B_Eliminar);
            this.Controls.Add(this.CB_ListaPersonas);
            this.Name = "FormAdminPersonas";
            this.Text = "Administrar personas";
            this.Load += new System.EventHandler(this.FormAdminPersonas_Load);
            this.Controls.SetChildIndex(this.CB_ListaPersonas, 0);
            this.Controls.SetChildIndex(this.GB_DatosPersona, 0);
            this.Controls.SetChildIndex(this.GB_Direccion, 0);
            this.Controls.SetChildIndex(this.B_Eliminar, 0);
            this.Controls.SetChildIndex(this.L_ListaPersonas, 0);
            this.Controls.SetChildIndex(this.L_BajasSolicitadas, 0);
            this.Controls.SetChildIndex(this.CB_BajasSolicitadas, 0);
            this.GB_DatosPersona.ResumeLayout(false);
            this.GB_DatosPersona.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_EdadDatos)).EndInit();
            this.GB_Direccion.ResumeLayout(false);
            this.GB_Direccion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CB_ListaPersonas;
        private System.Windows.Forms.Button B_Eliminar;
        private System.Windows.Forms.Label L_ListaPersonas;
        private System.Windows.Forms.Label L_BajasSolicitadas;
        private System.Windows.Forms.ComboBox CB_BajasSolicitadas;
    }
}