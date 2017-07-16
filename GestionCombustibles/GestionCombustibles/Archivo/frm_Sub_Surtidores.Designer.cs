namespace GestionCombustibles.Archivo
{
    partial class frm_Sub_Surtidores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Sub_Surtidores));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_Surtidor_ID = new System.Windows.Forms.TextBox();
            this.txt_Surtidor_codigo = new System.Windows.Forms.TextBox();
            this.btn_descartar = new System.Windows.Forms.Button();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Surtidor_denominacion = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Controls.Add(this.txt_Surtidor_ID);
            this.groupBox2.Controls.Add(this.txt_Surtidor_codigo);
            this.groupBox2.Controls.Add(this.btn_descartar);
            this.groupBox2.Controls.Add(this.btn_aceptar);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txt_Surtidor_denominacion);
            this.groupBox2.Location = new System.Drawing.Point(14, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(420, 151);
            this.groupBox2.TabIndex = 37;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DATOS GENERALES";
            // 
            // txt_Surtidor_ID
            // 
            this.txt_Surtidor_ID.Location = new System.Drawing.Point(236, 20);
            this.txt_Surtidor_ID.Name = "txt_Surtidor_ID";
            this.txt_Surtidor_ID.Size = new System.Drawing.Size(61, 20);
            this.txt_Surtidor_ID.TabIndex = 35;
            this.txt_Surtidor_ID.Visible = false;
            // 
            // txt_Surtidor_codigo
            // 
            this.txt_Surtidor_codigo.Location = new System.Drawing.Point(121, 20);
            this.txt_Surtidor_codigo.Name = "txt_Surtidor_codigo";
            this.txt_Surtidor_codigo.Size = new System.Drawing.Size(61, 20);
            this.txt_Surtidor_codigo.TabIndex = 33;
            // 
            // btn_descartar
            // 
            this.btn_descartar.Image = global::GestionCombustibles.Properties.Resources._1497657872_001_051;
            this.btn_descartar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_descartar.Location = new System.Drawing.Point(236, 94);
            this.btn_descartar.Name = "btn_descartar";
            this.btn_descartar.Size = new System.Drawing.Size(88, 38);
            this.btn_descartar.TabIndex = 32;
            this.btn_descartar.Text = "Descartar";
            this.btn_descartar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_descartar.UseVisualStyleBackColor = true;
            this.btn_descartar.Click += new System.EventHandler(this.btn_descartar_Click);
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Image = global::GestionCombustibles.Properties.Resources.disco_flexible;
            this.btn_aceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_aceptar.Location = new System.Drawing.Point(95, 94);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(88, 38);
            this.btn_aceptar.TabIndex = 31;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_aceptar.UseVisualStyleBackColor = true;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
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
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Denominación";
            // 
            // txt_Surtidor_denominacion
            // 
            this.txt_Surtidor_denominacion.Location = new System.Drawing.Point(121, 51);
            this.txt_Surtidor_denominacion.Name = "txt_Surtidor_denominacion";
            this.txt_Surtidor_denominacion.Size = new System.Drawing.Size(273, 20);
            this.txt_Surtidor_denominacion.TabIndex = 15;
            // 
            // frm_Sub_Surtidores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 180);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_Sub_Surtidores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Sub_Surtidores";
            this.Load += new System.EventHandler(this.frm_Sub_Surtidores_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_Surtidor_ID;
        private System.Windows.Forms.TextBox txt_Surtidor_codigo;
        private System.Windows.Forms.Button btn_descartar;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Surtidor_denominacion;
    }
}