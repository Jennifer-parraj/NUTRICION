namespace NUTRICIÓN
{
    partial class Inicio
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
            this.lblVerificaciónDatos = new System.Windows.Forms.Label();
            this.lblCcPaciente = new System.Windows.Forms.Label();
            this.txtbxCcPaciente = new System.Windows.Forms.TextBox();
            this.bttnRegistrar = new System.Windows.Forms.Button();
            this.bttnConsultar = new System.Windows.Forms.Button();
            this.bttnIMC = new System.Windows.Forms.Button();
            this.bttnCalorias = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblVerificaciónDatos
            // 
            this.lblVerificaciónDatos.AutoSize = true;
            this.lblVerificaciónDatos.Location = new System.Drawing.Point(300, 40);
            this.lblVerificaciónDatos.Name = "lblVerificaciónDatos";
            this.lblVerificaciónDatos.Size = new System.Drawing.Size(210, 20);
            this.lblVerificaciónDatos.TabIndex = 1;
            this.lblVerificaciónDatos.Text = "VERIFICACIÓN DE DATOS";
            // 
            // lblCcPaciente
            // 
            this.lblCcPaciente.AutoSize = true;
            this.lblCcPaciente.Location = new System.Drawing.Point(87, 177);
            this.lblCcPaciente.Name = "lblCcPaciente";
            this.lblCcPaciente.Size = new System.Drawing.Size(194, 20);
            this.lblCcPaciente.TabIndex = 2;
            this.lblCcPaciente.Text = "CEDULA DEL PACIENTE";
            // 
            // txtbxCcPaciente
            // 
            this.txtbxCcPaciente.Location = new System.Drawing.Point(348, 171);
            this.txtbxCcPaciente.Name = "txtbxCcPaciente";
            this.txtbxCcPaciente.Size = new System.Drawing.Size(261, 26);
            this.txtbxCcPaciente.TabIndex = 3;
            // 
            // bttnRegistrar
            // 
            this.bttnRegistrar.Location = new System.Drawing.Point(192, 250);
            this.bttnRegistrar.Name = "bttnRegistrar";
            this.bttnRegistrar.Size = new System.Drawing.Size(180, 69);
            this.bttnRegistrar.TabIndex = 4;
            this.bttnRegistrar.Text = "REGISTRAR NUEVO USUARIO";
            this.bttnRegistrar.UseVisualStyleBackColor = true;
            this.bttnRegistrar.Click += new System.EventHandler(this.bttnRegistrar_Click);
            // 
            // bttnConsultar
            // 
            this.bttnConsultar.Location = new System.Drawing.Point(429, 250);
            this.bttnConsultar.Name = "bttnConsultar";
            this.bttnConsultar.Size = new System.Drawing.Size(180, 69);
            this.bttnConsultar.TabIndex = 5;
            this.bttnConsultar.Text = "CONSULTAR USUARIO";
            this.bttnConsultar.UseVisualStyleBackColor = true;
            // 
            // bttnIMC
            // 
            this.bttnIMC.Location = new System.Drawing.Point(192, 360);
            this.bttnIMC.Name = "bttnIMC";
            this.bttnIMC.Size = new System.Drawing.Size(180, 67);
            this.bttnIMC.TabIndex = 6;
            this.bttnIMC.Text = "CALCULAR IMC";
            this.bttnIMC.UseVisualStyleBackColor = true;
            // 
            // bttnCalorias
            // 
            this.bttnCalorias.Location = new System.Drawing.Point(429, 360);
            this.bttnCalorias.Name = "bttnCalorias";
            this.bttnCalorias.Size = new System.Drawing.Size(180, 67);
            this.bttnCalorias.TabIndex = 7;
            this.bttnCalorias.Text = "CONSULTAR CALORIAS";
            this.bttnCalorias.UseVisualStyleBackColor = true;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bttnCalorias);
            this.Controls.Add(this.bttnIMC);
            this.Controls.Add(this.bttnConsultar);
            this.Controls.Add(this.bttnRegistrar);
            this.Controls.Add(this.txtbxCcPaciente);
            this.Controls.Add(this.lblCcPaciente);
            this.Controls.Add(this.lblVerificaciónDatos);
            this.Name = "Inicio";
            this.Text = "NUTRICIÓN - INICIO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblVerificaciónDatos;
        private System.Windows.Forms.Label lblCcPaciente;
        private System.Windows.Forms.TextBox txtbxCcPaciente;
        private System.Windows.Forms.Button bttnRegistrar;
        private System.Windows.Forms.Button bttnConsultar;
        private System.Windows.Forms.Button bttnIMC;
        private System.Windows.Forms.Button bttnCalorias;
    }
}