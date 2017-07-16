namespace GestionCombustibles
{
    partial class SubNivelDcto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SubNivelDcto));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Nivel_Dcto_Cant_Min = new System.Windows.Forms.TextBox();
            this.txt_Nivel_Dcto_Cant = new System.Windows.Forms.TextBox();
            this.cbo_Nivel_Dcto_Producto = new System.Windows.Forms.ComboBox();
            this.btn_Guardar_NivelDcto = new System.Windows.Forms.Button();
            this.btn_Descartar_NivelDcto = new System.Windows.Forms.Button();
            this.txt_Nivel_Dcto_ID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Productos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(142, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cantidad Minima";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(292, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Descuento por Cantidad";
            // 
            // txt_Nivel_Dcto_Cant_Min
            // 
            this.txt_Nivel_Dcto_Cant_Min.Location = new System.Drawing.Point(145, 46);
            this.txt_Nivel_Dcto_Cant_Min.Name = "txt_Nivel_Dcto_Cant_Min";
            this.txt_Nivel_Dcto_Cant_Min.Size = new System.Drawing.Size(126, 20);
            this.txt_Nivel_Dcto_Cant_Min.TabIndex = 4;
            // 
            // txt_Nivel_Dcto_Cant
            // 
            this.txt_Nivel_Dcto_Cant.Location = new System.Drawing.Point(295, 46);
            this.txt_Nivel_Dcto_Cant.Name = "txt_Nivel_Dcto_Cant";
            this.txt_Nivel_Dcto_Cant.Size = new System.Drawing.Size(125, 20);
            this.txt_Nivel_Dcto_Cant.TabIndex = 5;
            // 
            // cbo_Nivel_Dcto_Producto
            // 
            this.cbo_Nivel_Dcto_Producto.FormattingEnabled = true;
            this.cbo_Nivel_Dcto_Producto.Location = new System.Drawing.Point(9, 46);
            this.cbo_Nivel_Dcto_Producto.Name = "cbo_Nivel_Dcto_Producto";
            this.cbo_Nivel_Dcto_Producto.Size = new System.Drawing.Size(121, 21);
            this.cbo_Nivel_Dcto_Producto.TabIndex = 6;
            // 
            // btn_Guardar_NivelDcto
            // 
            this.btn_Guardar_NivelDcto.Location = new System.Drawing.Point(82, 91);
            this.btn_Guardar_NivelDcto.Name = "btn_Guardar_NivelDcto";
            this.btn_Guardar_NivelDcto.Size = new System.Drawing.Size(121, 32);
            this.btn_Guardar_NivelDcto.TabIndex = 7;
            this.btn_Guardar_NivelDcto.Text = "Guardar";
            this.btn_Guardar_NivelDcto.UseVisualStyleBackColor = true;
            this.btn_Guardar_NivelDcto.Click += new System.EventHandler(this.btn_Guardar_NivelDcto_Click);
            // 
            // btn_Descartar_NivelDcto
            // 
            this.btn_Descartar_NivelDcto.Location = new System.Drawing.Point(209, 91);
            this.btn_Descartar_NivelDcto.Name = "btn_Descartar_NivelDcto";
            this.btn_Descartar_NivelDcto.Size = new System.Drawing.Size(126, 32);
            this.btn_Descartar_NivelDcto.TabIndex = 8;
            this.btn_Descartar_NivelDcto.Text = "Descarta Cambios";
            this.btn_Descartar_NivelDcto.UseVisualStyleBackColor = true;
            this.btn_Descartar_NivelDcto.Click += new System.EventHandler(this.btn_Descartar_NivelDcto_Click);
            // 
            // txt_Nivel_Dcto_ID
            // 
            this.txt_Nivel_Dcto_ID.Location = new System.Drawing.Point(9, 73);
            this.txt_Nivel_Dcto_ID.Name = "txt_Nivel_Dcto_ID";
            this.txt_Nivel_Dcto_ID.Size = new System.Drawing.Size(74, 20);
            this.txt_Nivel_Dcto_ID.TabIndex = 9;
            // 
            // SubNivelDcto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 130);
            this.Controls.Add(this.txt_Nivel_Dcto_ID);
            this.Controls.Add(this.btn_Descartar_NivelDcto);
            this.Controls.Add(this.btn_Guardar_NivelDcto);
            this.Controls.Add(this.cbo_Nivel_Dcto_Producto);
            this.Controls.Add(this.txt_Nivel_Dcto_Cant);
            this.Controls.Add(this.txt_Nivel_Dcto_Cant_Min);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SubNivelDcto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Registro Nivel Descuento";
            this.Load += new System.EventHandler(this.SubNivelDcto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Nivel_Dcto_Cant_Min;
        private System.Windows.Forms.TextBox txt_Nivel_Dcto_Cant;
        private System.Windows.Forms.ComboBox cbo_Nivel_Dcto_Producto;
        private System.Windows.Forms.Button btn_Guardar_NivelDcto;
        private System.Windows.Forms.Button btn_Descartar_NivelDcto;
        private System.Windows.Forms.TextBox txt_Nivel_Dcto_ID;
    }
}