namespace GestionCombustibles.Archivo
{
    partial class frm_Operadores_Usuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Operadores_Usuarios));
            this.gv_Operador_Lista = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumDoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Linea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_Operador_Buscar = new System.Windows.Forms.TextBox();
            this.gv_Operador_Buscar = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Operador_Buscar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Operador_Eliminar = new System.Windows.Forms.Button();
            this.btn_Operador_modificar = new System.Windows.Forms.Button();
            this.btn_Operador_nuevo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Operador_Lista)).BeginInit();
            this.gv_Operador_Buscar.SuspendLayout();
            this.SuspendLayout();
            // 
            // gv_Operador_Lista
            // 
            this.gv_Operador_Lista.AllowUserToAddRows = false;
            this.gv_Operador_Lista.AllowUserToDeleteRows = false;
            this.gv_Operador_Lista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_Operador_Lista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.NumDoc,
            this.Cliente,
            this.Linea});
            this.gv_Operador_Lista.Location = new System.Drawing.Point(12, 117);
            this.gv_Operador_Lista.Name = "gv_Operador_Lista";
            this.gv_Operador_Lista.ReadOnly = true;
            this.gv_Operador_Lista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gv_Operador_Lista.Size = new System.Drawing.Size(508, 287);
            this.gv_Operador_Lista.TabIndex = 15;
            this.gv_Operador_Lista.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_Operador_Lista_CellClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // NumDoc
            // 
            this.NumDoc.DataPropertyName = "Str_Cod_Operador_Usuario";
            this.NumDoc.HeaderText = "Codigo";
            this.NumDoc.Name = "NumDoc";
            this.NumDoc.ReadOnly = true;
            // 
            // Cliente
            // 
            this.Cliente.DataPropertyName = "Str_Nombre_Operador_Usuario";
            this.Cliente.FillWeight = 300F;
            this.Cliente.HeaderText = "Nombre";
            this.Cliente.Name = "Cliente";
            this.Cliente.ReadOnly = true;
            this.Cliente.Width = 300;
            // 
            // Linea
            // 
            this.Linea.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Linea.DataPropertyName = "Str_Nivel";
            this.Linea.HeaderText = "Nivel";
            this.Linea.Name = "Linea";
            this.Linea.ReadOnly = true;
            this.Linea.Width = 56;
            // 
            // txt_Operador_Buscar
            // 
            this.txt_Operador_Buscar.Location = new System.Drawing.Point(151, 19);
            this.txt_Operador_Buscar.Name = "txt_Operador_Buscar";
            this.txt_Operador_Buscar.Size = new System.Drawing.Size(257, 20);
            this.txt_Operador_Buscar.TabIndex = 4;
            // 
            // gv_Operador_Buscar
            // 
            this.gv_Operador_Buscar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.gv_Operador_Buscar.Controls.Add(this.label1);
            this.gv_Operador_Buscar.Controls.Add(this.txt_Operador_Buscar);
            this.gv_Operador_Buscar.Controls.Add(this.btn_Operador_Buscar);
            this.gv_Operador_Buscar.Location = new System.Drawing.Point(12, 13);
            this.gv_Operador_Buscar.Name = "gv_Operador_Buscar";
            this.gv_Operador_Buscar.Size = new System.Drawing.Size(508, 54);
            this.gv_Operador_Buscar.TabIndex = 17;
            this.gv_Operador_Buscar.TabStop = false;
            this.gv_Operador_Buscar.Text = "Buscar Operarios/Usuarios";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Codigo/Nombre";
            // 
            // btn_Operador_Buscar
            // 
            this.btn_Operador_Buscar.Image = global::GestionCombustibles.Properties.Resources._1497658339_search_321;
            this.btn_Operador_Buscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Operador_Buscar.Location = new System.Drawing.Point(414, 11);
            this.btn_Operador_Buscar.Name = "btn_Operador_Buscar";
            this.btn_Operador_Buscar.Size = new System.Drawing.Size(88, 38);
            this.btn_Operador_Buscar.TabIndex = 19;
            this.btn_Operador_Buscar.Text = "Buscar";
            this.btn_Operador_Buscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Operador_Buscar.UseVisualStyleBackColor = true;
            this.btn_Operador_Buscar.Click += new System.EventHandler(this.btn_Operador_Buscar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(333, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "label2";
            this.label2.Visible = false;
            // 
            // btn_Operador_Eliminar
            // 
            this.btn_Operador_Eliminar.Image = global::GestionCombustibles.Properties.Resources._1497657872_001_051;
            this.btn_Operador_Eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Operador_Eliminar.Location = new System.Drawing.Point(194, 73);
            this.btn_Operador_Eliminar.Name = "btn_Operador_Eliminar";
            this.btn_Operador_Eliminar.Size = new System.Drawing.Size(88, 38);
            this.btn_Operador_Eliminar.TabIndex = 22;
            this.btn_Operador_Eliminar.Text = "Eliminar";
            this.btn_Operador_Eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Operador_Eliminar.UseVisualStyleBackColor = true;
            this.btn_Operador_Eliminar.Click += new System.EventHandler(this.btn_Operador_Eliminar_Click);
            // 
            // btn_Operador_modificar
            // 
            this.btn_Operador_modificar.Image = global::GestionCombustibles.Properties.Resources._1497658977_001_45;
            this.btn_Operador_modificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Operador_modificar.Location = new System.Drawing.Point(103, 73);
            this.btn_Operador_modificar.Name = "btn_Operador_modificar";
            this.btn_Operador_modificar.Size = new System.Drawing.Size(88, 38);
            this.btn_Operador_modificar.TabIndex = 21;
            this.btn_Operador_modificar.Text = "Modificar";
            this.btn_Operador_modificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Operador_modificar.UseVisualStyleBackColor = true;
            this.btn_Operador_modificar.Click += new System.EventHandler(this.btn_Operador_modificar_Click);
            // 
            // btn_Operador_nuevo
            // 
            this.btn_Operador_nuevo.Image = global::GestionCombustibles.Properties.Resources._1497658601_add;
            this.btn_Operador_nuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Operador_nuevo.Location = new System.Drawing.Point(12, 73);
            this.btn_Operador_nuevo.Name = "btn_Operador_nuevo";
            this.btn_Operador_nuevo.Size = new System.Drawing.Size(88, 38);
            this.btn_Operador_nuevo.TabIndex = 20;
            this.btn_Operador_nuevo.Text = "Nuevo";
            this.btn_Operador_nuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Operador_nuevo.UseVisualStyleBackColor = true;
            this.btn_Operador_nuevo.Click += new System.EventHandler(this.btn_Operador_nuevo_Click);
            // 
            // frm_Operadores_Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(529, 412);
            this.Controls.Add(this.btn_Operador_Eliminar);
            this.Controls.Add(this.btn_Operador_modificar);
            this.Controls.Add(this.btn_Operador_nuevo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gv_Operador_Buscar);
            this.Controls.Add(this.gv_Operador_Lista);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Operadores_Usuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Operadores Usuarios";
            this.Activated += new System.EventHandler(this.frm_Operadores_Usuarios_Activated);
            this.Load += new System.EventHandler(this.Operadores_Usuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gv_Operador_Lista)).EndInit();
            this.gv_Operador_Buscar.ResumeLayout(false);
            this.gv_Operador_Buscar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.DataGridView gv_Operador_Lista;
        private System.Windows.Forms.TextBox txt_Operador_Buscar;
        private System.Windows.Forms.GroupBox gv_Operador_Buscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumDoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Linea;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Operador_Eliminar;
        private System.Windows.Forms.Button btn_Operador_modificar;
        private System.Windows.Forms.Button btn_Operador_nuevo;
        private System.Windows.Forms.Button btn_Operador_Buscar;
    }
}