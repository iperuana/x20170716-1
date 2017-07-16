namespace GestionCombustibles.Archivo
{
    partial class frm_Sub_Usuario
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
            this.txt_Usuario_usuario = new System.Windows.Forms.TextBox();
            this.txt_Usuario_Nombre = new System.Windows.Forms.TextBox();
            this.cbo_Usuario_Tipo_Perfil = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.btn_descartar = new System.Windows.Forms.Button();
            this.txt_Usuario_Codigo = new System.Windows.Forms.TextBox();
            this.txt_Usuario_Clave = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_Usuario_usuario
            // 
            this.txt_Usuario_usuario.Location = new System.Drawing.Point(91, 52);
            this.txt_Usuario_usuario.Name = "txt_Usuario_usuario";
            this.txt_Usuario_usuario.Size = new System.Drawing.Size(210, 20);
            this.txt_Usuario_usuario.TabIndex = 20;
            // 
            // txt_Usuario_Nombre
            // 
            this.txt_Usuario_Nombre.Location = new System.Drawing.Point(91, 26);
            this.txt_Usuario_Nombre.Name = "txt_Usuario_Nombre";
            this.txt_Usuario_Nombre.Size = new System.Drawing.Size(210, 20);
            this.txt_Usuario_Nombre.TabIndex = 15;
            // 
            // cbo_Usuario_Tipo_Perfil
            // 
            this.cbo_Usuario_Tipo_Perfil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_Usuario_Tipo_Perfil.FormattingEnabled = true;
            this.cbo_Usuario_Tipo_Perfil.Location = new System.Drawing.Point(91, 106);
            this.cbo_Usuario_Tipo_Perfil.Name = "cbo_Usuario_Tipo_Perfil";
            this.cbo_Usuario_Tipo_Perfil.Size = new System.Drawing.Size(210, 21);
            this.cbo_Usuario_Tipo_Perfil.TabIndex = 22;
            this.cbo_Usuario_Tipo_Perfil.SelectedIndexChanged += new System.EventHandler(this.cbo_Usuario_Tipo_Perfil_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Tipo de Perfil";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Clave usuario";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Nombre";
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Image = global::GestionCombustibles.Properties.Resources.disco_flexible;
            this.btn_aceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_aceptar.Location = new System.Drawing.Point(72, 158);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(88, 38);
            this.btn_aceptar.TabIndex = 45;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_aceptar.UseVisualStyleBackColor = true;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // btn_descartar
            // 
            this.btn_descartar.Image = global::GestionCombustibles.Properties.Resources._1497657872_001_051;
            this.btn_descartar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_descartar.Location = new System.Drawing.Point(213, 158);
            this.btn_descartar.Name = "btn_descartar";
            this.btn_descartar.Size = new System.Drawing.Size(88, 38);
            this.btn_descartar.TabIndex = 46;
            this.btn_descartar.Text = "Descartar";
            this.btn_descartar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_descartar.UseVisualStyleBackColor = true;
            this.btn_descartar.Click += new System.EventHandler(this.btn_descartar_Click);
            // 
            // txt_Usuario_Codigo
            // 
            this.txt_Usuario_Codigo.Location = new System.Drawing.Point(307, 27);
            this.txt_Usuario_Codigo.Name = "txt_Usuario_Codigo";
            this.txt_Usuario_Codigo.Size = new System.Drawing.Size(32, 20);
            this.txt_Usuario_Codigo.TabIndex = 48;
            this.txt_Usuario_Codigo.Text = "0";
            // 
            // txt_Usuario_Clave
            // 
            this.txt_Usuario_Clave.Location = new System.Drawing.Point(91, 80);
            this.txt_Usuario_Clave.Name = "txt_Usuario_Clave";
            this.txt_Usuario_Clave.Size = new System.Drawing.Size(210, 20);
            this.txt_Usuario_Clave.TabIndex = 49;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Controls.Add(this.txt_Usuario_Clave);
            this.groupBox2.Controls.Add(this.txt_Usuario_Codigo);
            this.groupBox2.Controls.Add(this.btn_descartar);
            this.groupBox2.Controls.Add(this.btn_aceptar);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.cbo_Usuario_Tipo_Perfil);
            this.groupBox2.Controls.Add(this.txt_Usuario_Nombre);
            this.groupBox2.Controls.Add(this.txt_Usuario_usuario);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(366, 216);
            this.groupBox2.TabIndex = 39;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DATOS GENERALES";
            // 
            // frm_Sub_Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 244);
            this.Controls.Add(this.groupBox2);
            this.Name = "frm_Sub_Usuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frm_Sub_Usuario";
            this.Load += new System.EventHandler(this.frm_Sub_Usuario_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Usuario_usuario;
        private System.Windows.Forms.TextBox txt_Usuario_Nombre;
        private System.Windows.Forms.ComboBox cbo_Usuario_Tipo_Perfil;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.Button btn_descartar;
        private System.Windows.Forms.TextBox txt_Usuario_Codigo;
        private System.Windows.Forms.TextBox txt_Usuario_Clave;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}