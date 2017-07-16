namespace GestionCombustibles.Archivo
{
    partial class frm_cambio_De_Clave_DeUsuario
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
            this.gb_CUsuario_CBcontraseña = new System.Windows.Forms.GroupBox();
            this.btn_CUsuario_Descartar = new System.Windows.Forms.Button();
            this.btn_CUsuario_Aceptar = new System.Windows.Forms.Button();
            this.txt_CUsuario_RClave = new System.Windows.Forms.TextBox();
            this.txt_CUsuario_Nueva_Usuario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_CUsuario_ClaveAnterior = new System.Windows.Forms.TextBox();
            this.gb_CUsuario_CBcontraseña.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_CUsuario_CBcontraseña
            // 
            this.gb_CUsuario_CBcontraseña.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.gb_CUsuario_CBcontraseña.Controls.Add(this.btn_CUsuario_Descartar);
            this.gb_CUsuario_CBcontraseña.Controls.Add(this.btn_CUsuario_Aceptar);
            this.gb_CUsuario_CBcontraseña.Controls.Add(this.txt_CUsuario_RClave);
            this.gb_CUsuario_CBcontraseña.Controls.Add(this.txt_CUsuario_Nueva_Usuario);
            this.gb_CUsuario_CBcontraseña.Controls.Add(this.label3);
            this.gb_CUsuario_CBcontraseña.Controls.Add(this.label4);
            this.gb_CUsuario_CBcontraseña.Controls.Add(this.label5);
            this.gb_CUsuario_CBcontraseña.Controls.Add(this.txt_CUsuario_ClaveAnterior);
            this.gb_CUsuario_CBcontraseña.Location = new System.Drawing.Point(12, 24);
            this.gb_CUsuario_CBcontraseña.Name = "gb_CUsuario_CBcontraseña";
            this.gb_CUsuario_CBcontraseña.Size = new System.Drawing.Size(439, 203);
            this.gb_CUsuario_CBcontraseña.TabIndex = 36;
            this.gb_CUsuario_CBcontraseña.TabStop = false;
            this.gb_CUsuario_CBcontraseña.Text = "CAMBIO DE COMTRASEÑA";
            // 
            // btn_CUsuario_Descartar
            // 
            this.btn_CUsuario_Descartar.Image = global::GestionCombustibles.Properties.Resources._1497657872_001_051;
            this.btn_CUsuario_Descartar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_CUsuario_Descartar.Location = new System.Drawing.Point(240, 151);
            this.btn_CUsuario_Descartar.Name = "btn_CUsuario_Descartar";
            this.btn_CUsuario_Descartar.Size = new System.Drawing.Size(88, 38);
            this.btn_CUsuario_Descartar.TabIndex = 32;
            this.btn_CUsuario_Descartar.Text = "Descartar";
            this.btn_CUsuario_Descartar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_CUsuario_Descartar.UseVisualStyleBackColor = true;
            this.btn_CUsuario_Descartar.Click += new System.EventHandler(this.btn_descartar_Click);
            // 
            // btn_CUsuario_Aceptar
            // 
            this.btn_CUsuario_Aceptar.Image = global::GestionCombustibles.Properties.Resources.disco_flexible;
            this.btn_CUsuario_Aceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_CUsuario_Aceptar.Location = new System.Drawing.Point(99, 151);
            this.btn_CUsuario_Aceptar.Name = "btn_CUsuario_Aceptar";
            this.btn_CUsuario_Aceptar.Size = new System.Drawing.Size(88, 38);
            this.btn_CUsuario_Aceptar.TabIndex = 31;
            this.btn_CUsuario_Aceptar.Text = "Aceptar";
            this.btn_CUsuario_Aceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_CUsuario_Aceptar.UseVisualStyleBackColor = true;
            this.btn_CUsuario_Aceptar.Click += new System.EventHandler(this.btn_CUsuario_Aceptar_Click);
            // 
            // txt_CUsuario_RClave
            // 
            this.txt_CUsuario_RClave.Location = new System.Drawing.Point(121, 109);
            this.txt_CUsuario_RClave.Name = "txt_CUsuario_RClave";
            this.txt_CUsuario_RClave.PasswordChar = '*';
            this.txt_CUsuario_RClave.Size = new System.Drawing.Size(304, 20);
            this.txt_CUsuario_RClave.TabIndex = 30;
            // 
            // txt_CUsuario_Nueva_Usuario
            // 
            this.txt_CUsuario_Nueva_Usuario.Location = new System.Drawing.Point(121, 80);
            this.txt_CUsuario_Nueva_Usuario.Name = "txt_CUsuario_Nueva_Usuario";
            this.txt_CUsuario_Nueva_Usuario.PasswordChar = '*';
            this.txt_CUsuario_Nueva_Usuario.Size = new System.Drawing.Size(304, 20);
            this.txt_CUsuario_Nueva_Usuario.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Comtraseña Anterior";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Nueva Contraseña";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Repita Contraseña";
            // 
            // txt_CUsuario_ClaveAnterior
            // 
            this.txt_CUsuario_ClaveAnterior.Location = new System.Drawing.Point(121, 51);
            this.txt_CUsuario_ClaveAnterior.Name = "txt_CUsuario_ClaveAnterior";
            this.txt_CUsuario_ClaveAnterior.PasswordChar = '*';
            this.txt_CUsuario_ClaveAnterior.Size = new System.Drawing.Size(304, 20);
            this.txt_CUsuario_ClaveAnterior.TabIndex = 15;
            // 
            // frm_cambio_De_Clave_DeUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(460, 239);
            this.Controls.Add(this.gb_CUsuario_CBcontraseña);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_cambio_De_Clave_DeUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "cambio_De_Clave_DeUsuario";
            this.Load += new System.EventHandler(this.frm_cambio_De_Clave_DeUsuario_Load);
            this.gb_CUsuario_CBcontraseña.ResumeLayout(false);
            this.gb_CUsuario_CBcontraseña.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_CUsuario_CBcontraseña;
        private System.Windows.Forms.Button btn_CUsuario_Descartar;
        private System.Windows.Forms.Button btn_CUsuario_Aceptar;
        private System.Windows.Forms.TextBox txt_CUsuario_RClave;
        private System.Windows.Forms.TextBox txt_CUsuario_Nueva_Usuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_CUsuario_ClaveAnterior;
    }
}