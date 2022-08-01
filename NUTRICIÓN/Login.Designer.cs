namespace NUTRICIÓN
{
    partial class Login
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.usuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.ingresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // usuario
            // 
            this.usuario.BackColor = System.Drawing.SystemColors.HighlightText;
            this.usuario.Location = new System.Drawing.Point(292, 139);
            this.usuario.Name = "usuario";
            this.usuario.Size = new System.Drawing.Size(253, 26);
            this.usuario.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(382, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(367, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Contraseña";
            // 
            // password
            // 
            this.password.BackColor = System.Drawing.SystemColors.HighlightText;
            this.password.Location = new System.Drawing.Point(292, 221);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(253, 26);
            this.password.TabIndex = 3;
            // 
            // ingresar
            // 
            this.ingresar.Location = new System.Drawing.Point(357, 279);
            this.ingresar.Name = "ingresar";
            this.ingresar.Size = new System.Drawing.Size(115, 30);
            this.ingresar.TabIndex = 4;
            this.ingresar.Text = "Ingresar";
            this.ingresar.UseVisualStyleBackColor = true;
            this.ingresar.Click += new System.EventHandler(this.ingresar_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ingresar);
            this.Controls.Add(this.password);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.usuario);
            this.Name = "Login";
            this.Text = "NUTRICIÓN - LOGIN";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox usuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Button ingresar;
    }
}

