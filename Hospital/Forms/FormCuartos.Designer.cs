namespace Hospital.Forms
{
    partial class FormCuartos
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
            this.CB_ListaCuartosA = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // CB_ListaCuartosA
            // 
            this.CB_ListaCuartosA.FormattingEnabled = true;
            this.CB_ListaCuartosA.Location = new System.Drawing.Point(24, 29);
            this.CB_ListaCuartosA.Name = "CB_ListaCuartosA";
            this.CB_ListaCuartosA.Size = new System.Drawing.Size(121, 28);
            this.CB_ListaCuartosA.TabIndex = 0;
            // 
            // FormCuartos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CB_ListaCuartosA);
            this.Name = "FormCuartos";
            this.Text = "Cuartos";
            this.Load += new System.EventHandler(this.FormCuartos_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox CB_ListaCuartosA;
    }
}