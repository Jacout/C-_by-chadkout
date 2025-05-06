namespace EjemploBdS
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Bnt_Iniciar = new System.Windows.Forms.Button();
            this.User_Text = new System.Windows.Forms.TextBox();
            this.Pass_Text = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Bnt_Iniciar
            // 
            this.Bnt_Iniciar.Location = new System.Drawing.Point(56, 200);
            this.Bnt_Iniciar.Name = "Bnt_Iniciar";
            this.Bnt_Iniciar.Size = new System.Drawing.Size(166, 38);
            this.Bnt_Iniciar.TabIndex = 0;
            this.Bnt_Iniciar.Text = "Iniciar";
            this.Bnt_Iniciar.UseVisualStyleBackColor = true;
            this.Bnt_Iniciar.Click += new System.EventHandler(this.Bnt_Iniciar_Click);
            // 
            // User_Text
            // 
            this.User_Text.Location = new System.Drawing.Point(42, 43);
            this.User_Text.Name = "User_Text";
            this.User_Text.Size = new System.Drawing.Size(192, 20);
            this.User_Text.TabIndex = 1;
            // 
            // Pass_Text
            // 
            this.Pass_Text.Location = new System.Drawing.Point(46, 120);
            this.Pass_Text.Name = "Pass_Text";
            this.Pass_Text.Size = new System.Drawing.Size(188, 20);
            this.Pass_Text.TabIndex = 2;
            this.Pass_Text.UseSystemPasswordChar = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.Pass_Text);
            this.Controls.Add(this.User_Text);
            this.Controls.Add(this.Bnt_Iniciar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Bnt_Iniciar;
        private System.Windows.Forms.TextBox User_Text;
        private System.Windows.Forms.TextBox Pass_Text;
    }
}

