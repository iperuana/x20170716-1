namespace GestionCombustibles.Archivo
{
    partial class frm_Sub_Turnos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Sub_Turnos));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_Turnos_ID = new System.Windows.Forms.TextBox();
            this.mtb_Turno_fin = new System.Windows.Forms.MaskedTextBox();
            this.mtb_Turno_inicio = new System.Windows.Forms.MaskedTextBox();
            this.txt_Turnos_codigo = new System.Windows.Forms.TextBox();
            this.btn_Turno_descartar = new System.Windows.Forms.Button();
            this.btn_Turno_aceptar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Controls.Add(this.txt_Turnos_ID);
            this.groupBox2.Controls.Add(this.mtb_Turno_fin);
            this.groupBox2.Controls.Add(this.mtb_Turno_inicio);
            this.groupBox2.Controls.Add(this.txt_Turnos_codigo);
            this.groupBox2.Controls.Add(this.btn_Turno_descartar);
            this.groupBox2.Controls.Add(this.btn_Turno_aceptar);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(278, 170);
            this.groupBox2.TabIndex = 37;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DATOS GENERALES";
            // 
            // txt_Turnos_ID
            // 
            this.txt_Turnos_ID.Location = new System.Drawing.Point(208, 23);
            this.txt_Turnos_ID.Name = "txt_Turnos_ID";
            this.txt_Turnos_ID.Size = new System.Drawing.Size(45, 20);
            this.txt_Turnos_ID.TabIndex = 41;
            this.txt_Turnos_ID.Visible = false;
            // 
            // mtb_Turno_fin
            // 
            this.mtb_Turno_fin.Location = new System.Drawing.Point(121, 80);
            this.mtb_Turno_fin.Mask = "00:00";
            this.mtb_Turno_fin.Name = "mtb_Turno_fin";
            this.mtb_Turno_fin.Size = new System.Drawing.Size(100, 20);
            this.mtb_Turno_fin.TabIndex = 40;
            this.mtb_Turno_fin.ValidatingType = typeof(System.DateTime);
            // 
            // mtb_Turno_inicio
            // 
            this.mtb_Turno_inicio.Location = new System.Drawing.Point(121, 51);
            this.mtb_Turno_inicio.Mask = "00:00";
            this.mtb_Turno_inicio.Name = "mtb_Turno_inicio";
            this.mtb_Turno_inicio.Size = new System.Drawing.Size(100, 20);
            this.mtb_Turno_inicio.TabIndex = 39;
            this.mtb_Turno_inicio.ValidatingType = typeof(System.DateTime);
            // 
            // txt_Turnos_codigo
            // 
            this.txt_Turnos_codigo.Location = new System.Drawing.Point(121, 23);
            this.txt_Turnos_codigo.Name = "txt_Turnos_codigo";
            this.txt_Turnos_codigo.Size = new System.Drawing.Size(75, 20);
            this.txt_Turnos_codigo.TabIndex = 35;
            // 
            // btn_Turno_descartar
            // 
            this.btn_Turno_descartar.Image = global::GestionCombustibles.Properties.Resources._1497657872_001_051;
            this.btn_Turno_descartar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Turno_descartar.Location = new System.Drawing.Point(165, 120);
            this.btn_Turno_descartar.Name = "btn_Turno_descartar";
            this.btn_Turno_descartar.Size = new System.Drawing.Size(88, 38);
            this.btn_Turno_descartar.TabIndex = 32;
            this.btn_Turno_descartar.Text = "Descartar";
            this.btn_Turno_descartar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Turno_descartar.UseVisualStyleBackColor = true;
            this.btn_Turno_descartar.Click += new System.EventHandler(this.btn_descartar_Click);
            // 
            // btn_Turno_aceptar
            // 
            this.btn_Turno_aceptar.Image = global::GestionCombustibles.Properties.Resources.disco_flexible;
            this.btn_Turno_aceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Turno_aceptar.Location = new System.Drawing.Point(24, 120);
            this.btn_Turno_aceptar.Name = "btn_Turno_aceptar";
            this.btn_Turno_aceptar.Size = new System.Drawing.Size(88, 38);
            this.btn_Turno_aceptar.TabIndex = 31;
            this.btn_Turno_aceptar.Text = "Aceptar";
            this.btn_Turno_aceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Turno_aceptar.UseVisualStyleBackColor = true;
            this.btn_Turno_aceptar.Click += new System.EventHandler(this.btn_Turno_aceptar_Click);
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
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Desde";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Hasta";
            // 
            // frm_Sub_Turnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(307, 193);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Sub_Turnos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento Turnos";
            this.Load += new System.EventHandler(this.frm_Sub_Turnos_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_Turno_descartar;
        private System.Windows.Forms.Button btn_Turno_aceptar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Turnos_codigo;
        private System.Windows.Forms.MaskedTextBox mtb_Turno_inicio;
        private System.Windows.Forms.MaskedTextBox mtb_Turno_fin;
        private System.Windows.Forms.TextBox txt_Turnos_ID;
    }
}