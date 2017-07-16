namespace GestionCombustibles.Archivo
{
    partial class frm_Sub_Operadores_Usuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Sub_Operadores_Usuarios));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_Operador_ID = new System.Windows.Forms.TextBox();
            this.txt_Operador_codigo = new System.Windows.Forms.TextBox();
            this.cbo_Operador_nivel = new System.Windows.Forms.ComboBox();
            this.btn_Operador_Descartar = new System.Windows.Forms.Button();
            this.btn_Operador_aceptar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Operador_nombre = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Controls.Add(this.txt_Operador_ID);
            this.groupBox2.Controls.Add(this.txt_Operador_codigo);
            this.groupBox2.Controls.Add(this.cbo_Operador_nivel);
            this.groupBox2.Controls.Add(this.btn_Operador_Descartar);
            this.groupBox2.Controls.Add(this.btn_Operador_aceptar);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txt_Operador_nombre);
            this.groupBox2.Location = new System.Drawing.Point(12, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(479, 187);
            this.groupBox2.TabIndex = 36;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DATOS GENERALES";
            // 
            // txt_Operador_ID
            // 
            this.txt_Operador_ID.Location = new System.Drawing.Point(262, 20);
            this.txt_Operador_ID.Name = "txt_Operador_ID";
            this.txt_Operador_ID.Size = new System.Drawing.Size(61, 20);
            this.txt_Operador_ID.TabIndex = 36;
            this.txt_Operador_ID.Visible = false;
            // 
            // txt_Operador_codigo
            // 
            this.txt_Operador_codigo.Location = new System.Drawing.Point(121, 20);
            this.txt_Operador_codigo.Name = "txt_Operador_codigo";
            this.txt_Operador_codigo.Size = new System.Drawing.Size(61, 20);
            this.txt_Operador_codigo.TabIndex = 34;
            // 
            // cbo_Operador_nivel
            // 
            this.cbo_Operador_nivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_Operador_nivel.FormattingEnabled = true;
            this.cbo_Operador_nivel.Items.AddRange(new object[] {
            "0- Ventas",
            "1- Superviciòn",
            "2- Administrativo"});
            this.cbo_Operador_nivel.Location = new System.Drawing.Point(121, 80);
            this.cbo_Operador_nivel.Name = "cbo_Operador_nivel";
            this.cbo_Operador_nivel.Size = new System.Drawing.Size(304, 21);
            this.cbo_Operador_nivel.TabIndex = 33;
            // 
            // btn_Operador_Descartar
            // 
            this.btn_Operador_Descartar.Image = global::GestionCombustibles.Properties.Resources._1497657872_001_05;
            this.btn_Operador_Descartar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Operador_Descartar.Location = new System.Drawing.Point(262, 118);
            this.btn_Operador_Descartar.Name = "btn_Operador_Descartar";
            this.btn_Operador_Descartar.Size = new System.Drawing.Size(88, 38);
            this.btn_Operador_Descartar.TabIndex = 32;
            this.btn_Operador_Descartar.Text = "Descartar";
            this.btn_Operador_Descartar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Operador_Descartar.UseVisualStyleBackColor = true;
            this.btn_Operador_Descartar.Click += new System.EventHandler(this.btn_Operador_Descartar_Click);
            // 
            // btn_Operador_aceptar
            // 
            this.btn_Operador_aceptar.Image = global::GestionCombustibles.Properties.Resources.disco_flexible;
            this.btn_Operador_aceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Operador_aceptar.Location = new System.Drawing.Point(121, 118);
            this.btn_Operador_aceptar.Name = "btn_Operador_aceptar";
            this.btn_Operador_aceptar.Size = new System.Drawing.Size(88, 38);
            this.btn_Operador_aceptar.TabIndex = 31;
            this.btn_Operador_aceptar.Text = "Aceptar";
            this.btn_Operador_aceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Operador_aceptar.UseVisualStyleBackColor = true;
            this.btn_Operador_aceptar.Click += new System.EventHandler(this.btn_Operador_aceptar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Codigo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Nivel";
            // 
            // txt_Operador_nombre
            // 
            this.txt_Operador_nombre.Location = new System.Drawing.Point(121, 51);
            this.txt_Operador_nombre.Name = "txt_Operador_nombre";
            this.txt_Operador_nombre.Size = new System.Drawing.Size(304, 20);
            this.txt_Operador_nombre.TabIndex = 15;
            // 
            // frm_Sub_Operadores_Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(506, 232);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Sub_Operadores_Usuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento Operadores/Usuarios";
            this.Load += new System.EventHandler(this.frm_Sub_Operadores_Usuarios_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_Operador_Descartar;
        private System.Windows.Forms.Button btn_Operador_aceptar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Operador_nombre;
        private System.Windows.Forms.ComboBox cbo_Operador_nivel;
        private System.Windows.Forms.TextBox txt_Operador_codigo;
        private System.Windows.Forms.TextBox txt_Operador_ID;
    }
}