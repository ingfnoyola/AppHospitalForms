namespace Hospital
{
    partial class Form1
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
            this.B_Login = new System.Windows.Forms.Button();
            this.L_LoginUsuario = new System.Windows.Forms.Label();
            this.L_LoginPassword = new System.Windows.Forms.Label();
            this.TB_LoginUsuario = new System.Windows.Forms.TextBox();
            this.TB_LoginPassword = new System.Windows.Forms.TextBox();
            this.B_CrearRepaldo = new System.Windows.Forms.Button();
            this.B_RecuperarRespaldo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // B_Login
            // 
            this.B_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_Login.Location = new System.Drawing.Point(185, 146);
            this.B_Login.Name = "B_Login";
            this.B_Login.Size = new System.Drawing.Size(176, 56);
            this.B_Login.TabIndex = 0;
            this.B_Login.Text = "Iniciar Sesión";
            this.B_Login.UseVisualStyleBackColor = true;
            this.B_Login.Click += new System.EventHandler(this.B_Login_Click);
            // 
            // L_LoginUsuario
            // 
            this.L_LoginUsuario.AutoSize = true;
            this.L_LoginUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_LoginUsuario.Location = new System.Drawing.Point(132, 45);
            this.L_LoginUsuario.Name = "L_LoginUsuario";
            this.L_LoginUsuario.Size = new System.Drawing.Size(99, 25);
            this.L_LoginUsuario.TabIndex = 1;
            this.L_LoginUsuario.Text = "Usuario: ";
            // 
            // L_LoginPassword
            // 
            this.L_LoginPassword.AutoSize = true;
            this.L_LoginPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_LoginPassword.Location = new System.Drawing.Point(132, 88);
            this.L_LoginPassword.Name = "L_LoginPassword";
            this.L_LoginPassword.Size = new System.Drawing.Size(131, 25);
            this.L_LoginPassword.TabIndex = 2;
            this.L_LoginPassword.Text = "Contraseña:";
            // 
            // TB_LoginUsuario
            // 
            this.TB_LoginUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_LoginUsuario.Location = new System.Drawing.Point(269, 35);
            this.TB_LoginUsuario.Name = "TB_LoginUsuario";
            this.TB_LoginUsuario.Size = new System.Drawing.Size(130, 35);
            this.TB_LoginUsuario.TabIndex = 3;
            // 
            // TB_LoginPassword
            // 
            this.TB_LoginPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_LoginPassword.Location = new System.Drawing.Point(269, 78);
            this.TB_LoginPassword.Name = "TB_LoginPassword";
            this.TB_LoginPassword.Size = new System.Drawing.Size(130, 35);
            this.TB_LoginPassword.TabIndex = 4;
            // 
            // B_CrearRepaldo
            // 
            this.B_CrearRepaldo.Location = new System.Drawing.Point(12, 245);
            this.B_CrearRepaldo.Name = "B_CrearRepaldo";
            this.B_CrearRepaldo.Size = new System.Drawing.Size(159, 62);
            this.B_CrearRepaldo.TabIndex = 5;
            this.B_CrearRepaldo.Text = "Guardar Respaldo";
            this.B_CrearRepaldo.UseVisualStyleBackColor = true;
            this.B_CrearRepaldo.Click += new System.EventHandler(this.B_CrearRepaldo_Click);
            // 
            // B_RecuperarRespaldo
            // 
            this.B_RecuperarRespaldo.Location = new System.Drawing.Point(377, 245);
            this.B_RecuperarRespaldo.Name = "B_RecuperarRespaldo";
            this.B_RecuperarRespaldo.Size = new System.Drawing.Size(159, 62);
            this.B_RecuperarRespaldo.TabIndex = 6;
            this.B_RecuperarRespaldo.Text = "Recuperar Respaldo";
            this.B_RecuperarRespaldo.UseVisualStyleBackColor = true;
            this.B_RecuperarRespaldo.Click += new System.EventHandler(this.B_RecuperarRespaldo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 319);
            this.Controls.Add(this.B_RecuperarRespaldo);
            this.Controls.Add(this.B_CrearRepaldo);
            this.Controls.Add(this.TB_LoginPassword);
            this.Controls.Add(this.TB_LoginUsuario);
            this.Controls.Add(this.L_LoginPassword);
            this.Controls.Add(this.L_LoginUsuario);
            this.Controls.Add(this.B_Login);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button B_Login;
        private System.Windows.Forms.Label L_LoginUsuario;
        private System.Windows.Forms.Label L_LoginPassword;
        private System.Windows.Forms.TextBox TB_LoginUsuario;
        private System.Windows.Forms.TextBox TB_LoginPassword;
        private System.Windows.Forms.Button B_CrearRepaldo;
        private System.Windows.Forms.Button B_RecuperarRespaldo;
    }
}

