namespace GestionCombustibles.Archivo
{
    partial class Productos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Productos));
            this.gb_Producto_Buscar = new System.Windows.Forms.GroupBox();
            this.txt_BuscarProducto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Producto_Buscar = new System.Windows.Forms.Button();
            this.UltAct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gv_Producto_Lista = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Productos_Eliminar = new System.Windows.Forms.Button();
            this.btn_Productos_Modificar = new System.Windows.Forms.Button();
            this.btn_Productos_Nuevo = new System.Windows.Forms.Button();
            this.gb_Producto_Buscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Producto_Lista)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_Producto_Buscar
            // 
            this.gb_Producto_Buscar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.gb_Producto_Buscar.Controls.Add(this.txt_BuscarProducto);
            this.gb_Producto_Buscar.Controls.Add(this.label1);
            this.gb_Producto_Buscar.Controls.Add(this.btn_Producto_Buscar);
            this.gb_Producto_Buscar.Location = new System.Drawing.Point(31, 11);
            this.gb_Producto_Buscar.Name = "gb_Producto_Buscar";
            this.gb_Producto_Buscar.Size = new System.Drawing.Size(516, 68);
            this.gb_Producto_Buscar.TabIndex = 7;
            this.gb_Producto_Buscar.TabStop = false;
            this.gb_Producto_Buscar.Text = "BUSCAR PRODUCTO";
            // 
            // txt_BuscarProducto
            // 
            this.txt_BuscarProducto.Location = new System.Drawing.Point(136, 25);
            this.txt_BuscarProducto.Name = "txt_BuscarProducto";
            this.txt_BuscarProducto.Size = new System.Drawing.Size(273, 20);
            this.txt_BuscarProducto.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Codigo/Nombre Producto";
            // 
            // btn_Producto_Buscar
            // 
            this.btn_Producto_Buscar.Image = global::GestionCombustibles.Properties.Resources._1497658339_search_321;
            this.btn_Producto_Buscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Producto_Buscar.Location = new System.Drawing.Point(424, 17);
            this.btn_Producto_Buscar.Name = "btn_Producto_Buscar";
            this.btn_Producto_Buscar.Size = new System.Drawing.Size(88, 38);
            this.btn_Producto_Buscar.TabIndex = 15;
            this.btn_Producto_Buscar.Text = "Buscar";
            this.btn_Producto_Buscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Producto_Buscar.UseVisualStyleBackColor = true;
            this.btn_Producto_Buscar.Click += new System.EventHandler(this.btn_Producto_Buscar_Click);
            // 
            // UltAct
            // 
            this.UltAct.HeaderText = "Ult.Act";
            this.UltAct.Name = "UltAct";
            this.UltAct.ReadOnly = true;
            this.UltAct.Width = 80;
            // 
            // Precio
            // 
            this.Precio.DataPropertyName = "Dcm_Venta";
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            this.Precio.Width = 80;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Str_nom_producto";
            this.Nombre.HeaderText = "Nombre Producto";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 200;
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "Str_cod_producto";
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // gv_Producto_Lista
            // 
            this.gv_Producto_Lista.AllowUserToAddRows = false;
            this.gv_Producto_Lista.AllowUserToDeleteRows = false;
            this.gv_Producto_Lista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_Producto_Lista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Codigo,
            this.Nombre,
            this.Precio,
            this.UltAct});
            this.gv_Producto_Lista.Location = new System.Drawing.Point(31, 125);
            this.gv_Producto_Lista.Name = "gv_Producto_Lista";
            this.gv_Producto_Lista.ReadOnly = true;
            this.gv_Producto_Lista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gv_Producto_Lista.Size = new System.Drawing.Size(516, 228);
            this.gv_Producto_Lista.TabIndex = 8;
            this.gv_Producto_Lista.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_Producto_Lista_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(356, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "label2";
            this.label2.Visible = false;
            // 
            // btn_Productos_Eliminar
            // 
            this.btn_Productos_Eliminar.Image = global::GestionCombustibles.Properties.Resources._1497657872_001_051;
            this.btn_Productos_Eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Productos_Eliminar.Location = new System.Drawing.Point(216, 81);
            this.btn_Productos_Eliminar.Name = "btn_Productos_Eliminar";
            this.btn_Productos_Eliminar.Size = new System.Drawing.Size(88, 38);
            this.btn_Productos_Eliminar.TabIndex = 18;
            this.btn_Productos_Eliminar.Text = "Eliminar";
            this.btn_Productos_Eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Productos_Eliminar.UseVisualStyleBackColor = true;
            this.btn_Productos_Eliminar.Click += new System.EventHandler(this.btn_Productos_Eliminar_Click);
            // 
            // btn_Productos_Modificar
            // 
            this.btn_Productos_Modificar.Image = global::GestionCombustibles.Properties.Resources._1497658977_001_45;
            this.btn_Productos_Modificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Productos_Modificar.Location = new System.Drawing.Point(125, 81);
            this.btn_Productos_Modificar.Name = "btn_Productos_Modificar";
            this.btn_Productos_Modificar.Size = new System.Drawing.Size(88, 38);
            this.btn_Productos_Modificar.TabIndex = 17;
            this.btn_Productos_Modificar.Text = "Modificar";
            this.btn_Productos_Modificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Productos_Modificar.UseVisualStyleBackColor = true;
            this.btn_Productos_Modificar.Click += new System.EventHandler(this.btn_Productos_Modificar_Click);
            // 
            // btn_Productos_Nuevo
            // 
            this.btn_Productos_Nuevo.Image = global::GestionCombustibles.Properties.Resources._1497658601_add;
            this.btn_Productos_Nuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Productos_Nuevo.Location = new System.Drawing.Point(34, 81);
            this.btn_Productos_Nuevo.Name = "btn_Productos_Nuevo";
            this.btn_Productos_Nuevo.Size = new System.Drawing.Size(88, 38);
            this.btn_Productos_Nuevo.TabIndex = 16;
            this.btn_Productos_Nuevo.Text = "Nuevo";
            this.btn_Productos_Nuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Productos_Nuevo.UseVisualStyleBackColor = true;
            this.btn_Productos_Nuevo.Click += new System.EventHandler(this.btn_Productos_Nuevo_Click);
            // 
            // Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 383);
            this.Controls.Add(this.btn_Productos_Eliminar);
            this.Controls.Add(this.btn_Productos_Modificar);
            this.Controls.Add(this.btn_Productos_Nuevo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gv_Producto_Lista);
            this.Controls.Add(this.gb_Producto_Buscar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Productos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Producto";
            this.Activated += new System.EventHandler(this.frm_Producto_Activated);
            this.Load += new System.EventHandler(this.Producto_Load);
            this.gb_Producto_Buscar.ResumeLayout(false);
            this.gb_Producto_Buscar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Producto_Lista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gb_Producto_Buscar;
        private System.Windows.Forms.TextBox txt_BuscarProducto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn UltAct;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridView gv_Producto_Lista;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Producto_Buscar;
        private System.Windows.Forms.Button btn_Productos_Eliminar;
        private System.Windows.Forms.Button btn_Productos_Modificar;
        private System.Windows.Forms.Button btn_Productos_Nuevo;
    }
}