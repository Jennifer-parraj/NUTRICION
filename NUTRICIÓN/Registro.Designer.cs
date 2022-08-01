namespace NUTRICIÓN
{
    partial class registro
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
            this.nombre = new System.Windows.Forms.TextBox();
            this.lblNombreCompleto = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.usuario = new System.Windows.Forms.TextBox();
            this.correo = new System.Windows.Forms.TextBox();
            this.registrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.reppassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(265, 35);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(224, 26);
            this.nombre.TabIndex = 0;
            this.nombre.TextChanged += new System.EventHandler(this.nombre_TextChanged);
            // 
            // lblNombreCompleto
            // 
            this.lblNombreCompleto.AutoSize = true;
            this.lblNombreCompleto.Location = new System.Drawing.Point(71, 41);
            this.lblNombreCompleto.Name = "lblNombreCompleto";
            this.lblNombreCompleto.Size = new System.Drawing.Size(134, 20);
            this.lblNombreCompleto.TabIndex = 1;
            this.lblNombreCompleto.Text = "Nombre completo";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(71, 132);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(104, 20);
            this.lblUsuario.TabIndex = 2;
            this.lblUsuario.Text = "Crear usuario";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(71, 180);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(132, 20);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Crear contraseña";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(71, 87);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(138, 20);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "Correo electronico";
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(265, 177);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(224, 26);
            this.password.TabIndex = 5;
            // 
            // usuario
            // 
            this.usuario.Location = new System.Drawing.Point(265, 129);
            this.usuario.Name = "usuario";
            this.usuario.Size = new System.Drawing.Size(224, 26);
            this.usuario.TabIndex = 6;
            // 
            // correo
            // 
            this.correo.Location = new System.Drawing.Point(265, 84);
            this.correo.Name = "correo";
            this.correo.Size = new System.Drawing.Size(224, 26);
            this.correo.TabIndex = 7;
            // 
            // registrar
            // 
            this.registrar.Location = new System.Drawing.Point(327, 320);
            this.registrar.Name = "registrar";
            this.registrar.Size = new System.Drawing.Size(96, 33);
            this.registrar.TabIndex = 8;
            this.registrar.Text = "Registrar";
            this.registrar.UseVisualStyleBackColor = true;
            this.registrar.Click += new System.EventHandler(this.registrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Repetir contraseña";
            // 
            // reppassword
            // 
            this.reppassword.Location = new System.Drawing.Point(265, 228);
            this.reppassword.Name = "reppassword";
            this.reppassword.PasswordChar = '*';
            this.reppassword.Size = new System.Drawing.Size(224, 26);
            this.reppassword.TabIndex = 10;
            // 
            // registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reppassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.registrar);
            this.Controls.Add(this.correo);
            this.Controls.Add(this.usuario);
            this.Controls.Add(this.password);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblNombreCompleto);
            this.Controls.Add(this.nombre);
            this.Name = "registro";
            this.Text = "NUTRICIÓN - REGISTRO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.Label lblNombreCompleto;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox usuario;
        private System.Windows.Forms.TextBox correo;
        private System.Windows.Forms.Button registrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox reppassword;
    }
}