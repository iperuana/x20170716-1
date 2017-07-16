namespace GestionCombustibles.Archivo
{
    partial class frm_Empresa
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
            this.gb_Empresa_Buscar = new System.Windows.Forms.GroupBox();
            this.btn_Empresa_Buscar = new System.Windows.Forms.Button();
            this.txt_buscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gv_Empresa_Lista = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Empresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumDoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Linea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreditoUsado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreditoDisponible = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Distrito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Empresa_Eliminar = new System.Windows.Forms.Button();
            this.btn_Empresa_Modificar = new System.Windows.Forms.Button();
            this.btn_Empresa_Nuevo = new System.Windows.Forms.Button();
            this.gb_Empresa_Buscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Empresa_Lista)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_Empresa_Buscar
            // 
            this.gb_Empresa_Buscar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.gb_Empresa_Buscar.Controls.Add(this.btn_Empresa_Buscar);
            this.gb_Empresa_Buscar.Controls.Add(this.txt_buscar);
            this.gb_Empresa_Buscar.Controls.Add(this.label1);
            this.gb_Empresa_Buscar.Location = new System.Drawing.Point(12, 23);
            this.gb_Empresa_Buscar.Name = "gb_Empresa_Buscar";
            this.gb_Empresa_Buscar.Size = new System.Drawing.Size(560, 59);
            this.gb_Empresa_Buscar.TabIndex = 12;
            this.gb_Empresa_Buscar.TabStop = false;
            this.gb_Empresa_Buscar.Text = "Buscar Empresa";
            // 
            // btn_Empresa_Buscar
            // 
            this.btn_Empresa_Buscar.Image = global::GestionCombustibles.Properties.Resources._1497658339_search_321;
            this.btn_Empresa_Buscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Empresa_Buscar.Location = new System.Drawing.Point(456, 12);
            this.btn_Empresa_Buscar.Name = "btn_Empresa_Buscar";
            this.btn_Empresa_Buscar.Size = new System.Drawing.Size(88, 38);
            this.btn_Empresa_Buscar.TabIndex = 5;
            this.btn_Empresa_Buscar.Text = "Buscar";
            this.btn_Empresa_Buscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Empresa_Buscar.UseVisualStyleBackColor = true;
            this.btn_Empresa_Buscar.Click += new System.EventHandler(this.btn_Empresa_Buscar_Click);
            // 
            // txt_buscar
            // 
            this.txt_buscar.Location = new System.Drawing.Point(151, 19);
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(281, 20);
            this.txt_buscar.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "RUC/Empresa";
            // 
            // gv_Empresa_Lista
            // 
            this.gv_Empresa_Lista.AllowUserToAddRows = false;
            this.gv_Empresa_Lista.AllowUserToDeleteRows = false;
            this.gv_Empresa_Lista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_Empresa_Lista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Empresa,
            this.NumDoc,
            this.Linea,
            this.CreditoUsado,
            this.CreditoDisponible,
            this.Distrito,
            this.Column1});
            this.gv_Empresa_Lista.Location = new System.Drawing.Point(12, 141);
            this.gv_Empresa_Lista.Name = "gv_Empresa_Lista";
            this.gv_Empresa_Lista.ReadOnly = true;
            this.gv_Empresa_Lista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gv_Empresa_Lista.Size = new System.Drawing.Size(735, 344);
            this.gv_Empresa_Lista.TabIndex = 11;
            this.gv_Empresa_Lista.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_Empresa_Lista_CellClick);
            this.gv_Empresa_Lista.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_Empresa_Lista_CellContentClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Empresa
            // 
            this.Empresa.DataPropertyName = "Str_nom_empresa";
            this.Empresa.HeaderText = "Empresa";
            this.Empresa.Name = "Empresa";
            this.Empresa.ReadOnly = true;
            // 
            // NumDoc
            // 
            this.NumDoc.DataPropertyName = "Str_num_documento";
            this.NumDoc.HeaderText = "RUC";
            this.NumDoc.Name = "NumDoc";
            this.NumDoc.ReadOnly = true;
            // 
            // Linea
            // 
            this.Linea.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Linea.DataPropertyName = "Str_direccion_empresa";
            this.Linea.HeaderText = "Dirección";
            this.Linea.Name = "Linea";
            this.Linea.ReadOnly = true;
            this.Linea.Width = 77;
            // 
            // CreditoUsado
            // 
            this.CreditoUsado.DataPropertyName = "Str_Nom_Departamento";
            this.CreditoUsado.HeaderText = "Departamento";
            this.CreditoUsado.Name = "CreditoUsado";
            this.CreditoUsado.ReadOnly = true;
            // 
            // CreditoDisponible
            // 
            this.CreditoDisponible.DataPropertyName = "Str_Nom_Provincia";
            this.CreditoDisponible.HeaderText = "Provincia";
            this.CreditoDisponible.Name = "CreditoDisponible";
            this.CreditoDisponible.ReadOnly = true;
            // 
            // Distrito
            // 
            this.Distrito.DataPropertyName = "Str_Nom_Distrito";
            this.Distrito.HeaderText = "Distrito";
            this.Distrito.Name = "Distrito";
            this.Distrito.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Str_ubigeo";
            this.Column1.HeaderText = "Ubigeo";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(322, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "label2";
            this.label2.Visible = false;
            // 
            // btn_Empresa_Eliminar
            // 
            this.btn_Empresa_Eliminar.Image = global::GestionCombustibles.Properties.Resources._1497657872_001_051;
            this.btn_Empresa_Eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Empresa_Eliminar.Location = new System.Drawing.Point(196, 88);
            this.btn_Empresa_Eliminar.Name = "btn_Empresa_Eliminar";
            this.btn_Empresa_Eliminar.Size = new System.Drawing.Size(88, 38);
            this.btn_Empresa_Eliminar.TabIndex = 10;
            this.btn_Empresa_Eliminar.Text = "Eliminar";
            this.btn_Empresa_Eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Empresa_Eliminar.UseVisualStyleBackColor = true;
            this.btn_Empresa_Eliminar.Click += new System.EventHandler(this.btn_Empresa_Eliminar_Click);
            // 
            // btn_Empresa_Modificar
            // 
            this.btn_Empresa_Modificar.Image = global::GestionCombustibles.Properties.Resources._1497658977_001_45;
            this.btn_Empresa_Modificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Empresa_Modificar.Location = new System.Drawing.Point(105, 88);
            this.btn_Empresa_Modificar.Name = "btn_Empresa_Modificar";
            this.btn_Empresa_Modificar.Size = new System.Drawing.Size(88, 38);
            this.btn_Empresa_Modificar.TabIndex = 9;
            this.btn_Empresa_Modificar.Text = "Modificar";
            this.btn_Empresa_Modificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Empresa_Modificar.UseVisualStyleBackColor = true;
            this.btn_Empresa_Modificar.Click += new System.EventHandler(this.btn_Empresa_Modificar_Click);
            // 
            // btn_Empresa_Nuevo
            // 
            this.btn_Empresa_Nuevo.Image = global::GestionCombustibles.Properties.Resources._1497658601_add;
            this.btn_Empresa_Nuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Empresa_Nuevo.Location = new System.Drawing.Point(14, 88);
            this.btn_Empresa_Nuevo.Name = "btn_Empresa_Nuevo";
            this.btn_Empresa_Nuevo.Size = new System.Drawing.Size(88, 38);
            this.btn_Empresa_Nuevo.TabIndex = 8;
            this.btn_Empresa_Nuevo.Text = "Nuevo";
            this.btn_Empresa_Nuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Empresa_Nuevo.UseVisualStyleBackColor = true;
            this.btn_Empresa_Nuevo.Click += new System.EventHandler(this.btn_Empresa_Nuevo_Click);
            // 
            // frm_Empresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(763, 521);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gb_Empresa_Buscar);
            this.Controls.Add(this.gv_Empresa_Lista);
            this.Controls.Add(this.btn_Empresa_Eliminar);
            this.Controls.Add(this.btn_Empresa_Modificar);
            this.Controls.Add(this.btn_Empresa_Nuevo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Empresa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Empresa";
            this.Activated += new System.EventHandler(this.Empresa_Activated);
            this.Load += new System.EventHandler(this.Empresa_Load);
            this.gb_Empresa_Buscar.ResumeLayout(false);
            this.gb_Empresa_Buscar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Empresa_Lista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_Empresa_Buscar;
        private System.Windows.Forms.Button btn_Empresa_Buscar;
        private System.Windows.Forms.TextBox txt_buscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gv_Empresa_Lista;
        private System.Windows.Forms.Button btn_Empresa_Eliminar;
        private System.Windows.Forms.Button btn_Empresa_Modificar;
        private System.Windows.Forms.Button btn_Empresa_Nuevo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Empresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumDoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Linea;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreditoUsado;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreditoDisponible;
        private System.Windows.Forms.DataGridViewTextBoxColumn Distrito;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}