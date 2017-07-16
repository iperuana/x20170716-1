namespace GestionCombustibles.Archivo
{
    partial class frm_Sub_Islas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Sub_Islas));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_Islas_ID = new System.Windows.Forms.TextBox();
            this.btn_Islas_Aceptar = new System.Windows.Forms.Button();
            this.txt_Surtidor_codigo = new System.Windows.Forms.TextBox();
            this.btn_Islas_Descartar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Surtidor_denominacion = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Controls.Add(this.txt_Islas_ID);
            this.groupBox2.Controls.Add(this.btn_Islas_Aceptar);
            this.groupBox2.Controls.Add(this.txt_Surtidor_codigo);
            this.groupBox2.Controls.Add(this.btn_Islas_Descartar);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txt_Surtidor_denominacion);
            this.groupBox2.Location = new System.Drawing.Point(21, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(443, 158);
            this.groupBox2.TabIndex = 37;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DATOS GENERALES";
            // 
            // txt_Islas_ID
            // 
            this.txt_Islas_ID.Location = new System.Drawing.Point(249, 20);
            this.txt_Islas_ID.Name = "txt_Islas_ID";
            this.txt_Islas_ID.Size = new System.Drawing.Size(61, 20);
            this.txt_Islas_ID.TabIndex = 36;
            this.txt_Islas_ID.Visible = false;
            // 
            // btn_Islas_Aceptar
            // 
            this.btn_Islas_Aceptar.Image = global::GestionCombustibles.Properties.Resources.disco_flexible;
            this.btn_Islas_Aceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Islas_Aceptar.Location = new System.Drawing.Point(85, 91);
            this.btn_Islas_Aceptar.Name = "btn_Islas_Aceptar";
            this.btn_Islas_Aceptar.Size = new System.Drawing.Size(88, 38);
            this.btn_Islas_Aceptar.TabIndex = 35;
            this.btn_Islas_Aceptar.Text = "Aceptar";
            this.btn_Islas_Aceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Islas_Aceptar.UseVisualStyleBackColor = true;
            this.btn_Islas_Aceptar.Click += new System.EventHandler(this.btn_Islas_Aceptar_Click);
            // 
            // txt_Surtidor_codigo
            // 
            this.txt_Surtidor_codigo.Location = new System.Drawing.Point(121, 20);
            this.txt_Surtidor_codigo.Name = "txt_Surtidor_codigo";
            this.txt_Surtidor_codigo.Size = new System.Drawing.Size(61, 20);
            this.txt_Surtidor_codigo.TabIndex = 33;
            // 
            // btn_Islas_Descartar
            // 
            this.btn_Islas_Descartar.Image = global::GestionCombustibles.Properties.Resources._1497657872_001_051;
            this.btn_Islas_Descartar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Islas_Descartar.Location = new System.Drawing.Point(262, 91);
            this.btn_Islas_Descartar.Name = "btn_Islas_Descartar";
            this.btn_Islas_Descartar.Size = new System.Drawing.Size(88, 38);
            this.btn_Islas_Descartar.TabIndex = 32;
            this.btn_Islas_Descartar.Text = "Descartar";
            this.btn_Islas_Descartar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Islas_Descartar.UseVisualStyleBackColor = true;
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
            this.txt_Surtidor_denominacion.Size = new System.Drawing.Size(304, 20);
            this.txt_Surtidor_denominacion.TabIndex = 15;
            // 
            // frm_Sub_Islas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 187);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_Sub_Islas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sub_Islas";
            this.Load += new System.EventHandler(this.frm_Sub_Islas_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_Surtidor_codigo;
        private System.Windows.Forms.Button btn_Islas_Descartar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Surtidor_denominacion;
        private System.Windows.Forms.Button btn_Islas_Aceptar;
        private System.Windows.Forms.TextBox txt_Islas_ID;
    }
}