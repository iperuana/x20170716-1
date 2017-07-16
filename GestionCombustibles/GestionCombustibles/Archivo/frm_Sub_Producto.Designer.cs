namespace GestionCombustibles.Archivo
{
    partial class frm_Sub_Producto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Sub_Producto));
            this.btn_Productos_Eliminar = new System.Windows.Forms.Button();
            this.btn_Productos_Aceptar = new System.Windows.Forms.Button();
            this.txt_Productos_ID = new System.Windows.Forms.TextBox();
            this.txt_Productos_Nombre = new System.Windows.Forms.TextBox();
            this.txt_Productos_PrecioVenta = new System.Windows.Forms.TextBox();
            this.txt_Productos_Costo_Compra = new System.Windows.Forms.TextBox();
            this.txt_Productos_Codigo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Productos_Eliminar
            // 
            this.btn_Productos_Eliminar.Image = global::GestionCombustibles.Properties.Resources._1497657872_001_051;
            this.btn_Productos_Eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Productos_Eliminar.Location = new System.Drawing.Point(187, 176);
            this.btn_Productos_Eliminar.Name = "btn_Productos_Eliminar";
            this.btn_Productos_Eliminar.Size = new System.Drawing.Size(88, 38);
            this.btn_Productos_Eliminar.TabIndex = 31;
            this.btn_Productos_Eliminar.Text = "Descartar";
            this.btn_Productos_Eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Productos_Eliminar.UseVisualStyleBackColor = true;
            this.btn_Productos_Eliminar.Click += new System.EventHandler(this.btn_Productos_Eliminar_Click);
            // 
            // btn_Productos_Aceptar
            // 
            this.btn_Productos_Aceptar.Image = global::GestionCombustibles.Properties.Resources.disco_flexible;
            this.btn_Productos_Aceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Productos_Aceptar.Location = new System.Drawing.Point(70, 176);
            this.btn_Productos_Aceptar.Name = "btn_Productos_Aceptar";
            this.btn_Productos_Aceptar.Size = new System.Drawing.Size(88, 38);
            this.btn_Productos_Aceptar.TabIndex = 30;
            this.btn_Productos_Aceptar.Text = "Aceptar";
            this.btn_Productos_Aceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Productos_Aceptar.UseVisualStyleBackColor = true;
            this.btn_Productos_Aceptar.Click += new System.EventHandler(this.btn_Productos_Aceptar_Click);
            // 
            // txt_Productos_ID
            // 
            this.txt_Productos_ID.Location = new System.Drawing.Point(226, 26);
            this.txt_Productos_ID.Name = "txt_Productos_ID";
            this.txt_Productos_ID.Size = new System.Drawing.Size(49, 20);
            this.txt_Productos_ID.TabIndex = 29;
            this.txt_Productos_ID.Visible = false;
            // 
            // txt_Productos_Nombre
            // 
            this.txt_Productos_Nombre.Location = new System.Drawing.Point(120, 57);
            this.txt_Productos_Nombre.Name = "txt_Productos_Nombre";
            this.txt_Productos_Nombre.Size = new System.Drawing.Size(197, 20);
            this.txt_Productos_Nombre.TabIndex = 28;
            // 
            // txt_Productos_PrecioVenta
            // 
            this.txt_Productos_PrecioVenta.Location = new System.Drawing.Point(120, 88);
            this.txt_Productos_PrecioVenta.Name = "txt_Productos_PrecioVenta";
            this.txt_Productos_PrecioVenta.Size = new System.Drawing.Size(66, 20);
            this.txt_Productos_PrecioVenta.TabIndex = 27;
            this.txt_Productos_PrecioVenta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Productos_PrecioVenta_KeyPress);
            // 
            // txt_Productos_Costo_Compra
            // 
            this.txt_Productos_Costo_Compra.Location = new System.Drawing.Point(120, 119);
            this.txt_Productos_Costo_Compra.Name = "txt_Productos_Costo_Compra";
            this.txt_Productos_Costo_Compra.Size = new System.Drawing.Size(66, 20);
            this.txt_Productos_Costo_Compra.TabIndex = 26;
            this.txt_Productos_Costo_Compra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Productos_Costo_Compra_KeyPress);
            // 
            // txt_Productos_Codigo
            // 
            this.txt_Productos_Codigo.Location = new System.Drawing.Point(120, 26);
            this.txt_Productos_Codigo.Name = "txt_Productos_Codigo";
            this.txt_Productos_Codigo.Size = new System.Drawing.Size(100, 20);
            this.txt_Productos_Codigo.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Costo Compra";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Precio Venta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Codigo";
            // 
            // frm_Sub_Producto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 227);
            this.Controls.Add(this.btn_Productos_Eliminar);
            this.Controls.Add(this.btn_Productos_Aceptar);
            this.Controls.Add(this.txt_Productos_ID);
            this.Controls.Add(this.txt_Productos_Nombre);
            this.Controls.Add(this.txt_Productos_PrecioVenta);
            this.Controls.Add(this.txt_Productos_Costo_Compra);
            this.Controls.Add(this.txt_Productos_Codigo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_Sub_Producto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Sub_Producto";
            this.Load += new System.EventHandler(this.frm_Sub_Producto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Productos_Eliminar;
        private System.Windows.Forms.Button btn_Productos_Aceptar;
        private System.Windows.Forms.TextBox txt_Productos_ID;
        private System.Windows.Forms.TextBox txt_Productos_Nombre;
        private System.Windows.Forms.TextBox txt_Productos_PrecioVenta;
        private System.Windows.Forms.TextBox txt_Productos_Costo_Compra;
        private System.Windows.Forms.TextBox txt_Productos_Codigo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}