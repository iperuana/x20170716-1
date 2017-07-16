namespace GestionCombustibles.Archivo
{
    partial class frm_Cliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Cliente));
            this.label2 = new System.Windows.Forms.Label();
            this.gb_Clientes_Buscar = new System.Windows.Forms.GroupBox();
            this.txt_buscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gv_Clientes_Lista = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumDoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Linea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreditoUsado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreditoDisponible = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlBusquedaSunat = new System.Windows.Forms.Panel();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtRucDNI = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblRucDNI = new System.Windows.Forms.Label();
            this.btnObtener = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btn_Clientes_Eliminar = new System.Windows.Forms.Button();
            this.btn_Clientes_Modificar = new System.Windows.Forms.Button();
            this.btn_Clientes_Nuevo = new System.Windows.Forms.Button();
            this.btn_Clientes_Buscar_Sunat = new System.Windows.Forms.Button();
            this.btn_Clientes_Buscar = new System.Windows.Forms.Button();
            this.gb_Clientes_Buscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Clientes_Lista)).BeginInit();
            this.pnlBusquedaSunat.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(411, 141);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "label2";
            this.label2.Visible = false;
            // 
            // gb_Clientes_Buscar
            // 
            this.gb_Clientes_Buscar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.gb_Clientes_Buscar.Controls.Add(this.btn_Clientes_Buscar_Sunat);
            this.gb_Clientes_Buscar.Controls.Add(this.txt_buscar);
            this.gb_Clientes_Buscar.Controls.Add(this.label1);
            this.gb_Clientes_Buscar.Controls.Add(this.btn_Clientes_Buscar);
            this.gb_Clientes_Buscar.Location = new System.Drawing.Point(16, 11);
            this.gb_Clientes_Buscar.Margin = new System.Windows.Forms.Padding(4);
            this.gb_Clientes_Buscar.Name = "gb_Clientes_Buscar";
            this.gb_Clientes_Buscar.Padding = new System.Windows.Forms.Padding(4);
            this.gb_Clientes_Buscar.Size = new System.Drawing.Size(1013, 110);
            this.gb_Clientes_Buscar.TabIndex = 16;
            this.gb_Clientes_Buscar.TabStop = false;
            this.gb_Clientes_Buscar.Text = "Buscar Clientes";
            this.gb_Clientes_Buscar.Enter += new System.EventHandler(this.gb_Clientes_Buscar_Enter);
            // 
            // txt_buscar
            // 
            this.txt_buscar.Location = new System.Drawing.Point(206, 39);
            this.txt_buscar.Margin = new System.Windows.Forms.Padding(4);
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(373, 22);
            this.txt_buscar.TabIndex = 4;
            this.txt_buscar.TextChanged += new System.EventHandler(this.txt_buscar_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre/RUC/DNI";
            // 
            // gv_Clientes_Lista
            // 
            this.gv_Clientes_Lista.AllowUserToAddRows = false;
            this.gv_Clientes_Lista.AllowUserToDeleteRows = false;
            this.gv_Clientes_Lista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_Clientes_Lista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.NumDoc,
            this.Cliente,
            this.Linea,
            this.CreditoUsado,
            this.CreditoDisponible});
            this.gv_Clientes_Lista.Location = new System.Drawing.Point(16, 185);
            this.gv_Clientes_Lista.Margin = new System.Windows.Forms.Padding(4);
            this.gv_Clientes_Lista.MultiSelect = false;
            this.gv_Clientes_Lista.Name = "gv_Clientes_Lista";
            this.gv_Clientes_Lista.ReadOnly = true;
            this.gv_Clientes_Lista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gv_Clientes_Lista.Size = new System.Drawing.Size(1013, 380);
            this.gv_Clientes_Lista.TabIndex = 15;
            this.gv_Clientes_Lista.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_Clientes_Lista_CellClick);
            this.gv_Clientes_Lista.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_Clientes_Lista_CellDoubleClick);
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
            this.NumDoc.DataPropertyName = "Str_num_documento";
            this.NumDoc.HeaderText = "RUC/DNI";
            this.NumDoc.Name = "NumDoc";
            this.NumDoc.ReadOnly = true;
            // 
            // Cliente
            // 
            this.Cliente.DataPropertyName = "Str_nom_cliente";
            this.Cliente.FillWeight = 300F;
            this.Cliente.HeaderText = "Nombre del Cliente";
            this.Cliente.Name = "Cliente";
            this.Cliente.ReadOnly = true;
            this.Cliente.Width = 300;
            // 
            // Linea
            // 
            this.Linea.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Linea.DataPropertyName = "Dcm_linea_credito";
            this.Linea.HeaderText = "Linea de Credito";
            this.Linea.Name = "Linea";
            this.Linea.ReadOnly = true;
            this.Linea.Width = 129;
            // 
            // CreditoUsado
            // 
            this.CreditoUsado.DataPropertyName = "Dcm_credito_utilizado";
            this.CreditoUsado.HeaderText = "Credito Usado";
            this.CreditoUsado.Name = "CreditoUsado";
            this.CreditoUsado.ReadOnly = true;
            // 
            // CreditoDisponible
            // 
            this.CreditoDisponible.DataPropertyName = "Dcm_credito_disponible";
            this.CreditoDisponible.HeaderText = "Credito Disponible";
            this.CreditoDisponible.Name = "CreditoDisponible";
            this.CreditoDisponible.ReadOnly = true;
            // 
            // pnlBusquedaSunat
            // 
            this.pnlBusquedaSunat.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnlBusquedaSunat.Controls.Add(this.btnCancelar);
            this.pnlBusquedaSunat.Controls.Add(this.btnObtener);
            this.pnlBusquedaSunat.Controls.Add(this.txtNombre);
            this.pnlBusquedaSunat.Controls.Add(this.txtRucDNI);
            this.pnlBusquedaSunat.Controls.Add(this.lblNombre);
            this.pnlBusquedaSunat.Controls.Add(this.lblRucDNI);
            this.pnlBusquedaSunat.Location = new System.Drawing.Point(236, 141);
            this.pnlBusquedaSunat.Name = "pnlBusquedaSunat";
            this.pnlBusquedaSunat.Size = new System.Drawing.Size(553, 142);
            this.pnlBusquedaSunat.TabIndex = 21;
            this.pnlBusquedaSunat.Visible = false;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(173, 61);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(343, 22);
            this.txtNombre.TabIndex = 11;
            // 
            // txtRucDNI
            // 
            this.txtRucDNI.Location = new System.Drawing.Point(173, 33);
            this.txtRucDNI.Name = "txtRucDNI";
            this.txtRucDNI.Size = new System.Drawing.Size(121, 22);
            this.txtRucDNI.TabIndex = 10;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(36, 64);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(68, 17);
            this.lblNombre.TabIndex = 9;
            this.lblNombre.Text = "NOMBRE";
            // 
            // lblRucDNI
            // 
            this.lblRucDNI.AutoSize = true;
            this.lblRucDNI.Location = new System.Drawing.Point(36, 36);
            this.lblRucDNI.Name = "lblRucDNI";
            this.lblRucDNI.Size = new System.Drawing.Size(64, 17);
            this.lblRucDNI.TabIndex = 8;
            this.lblRucDNI.Text = "RUC/DNI";
            // 
            // btnObtener
            // 
            this.btnObtener.Location = new System.Drawing.Point(136, 89);
            this.btnObtener.Name = "btnObtener";
            this.btnObtener.Size = new System.Drawing.Size(127, 33);
            this.btnObtener.TabIndex = 12;
            this.btnObtener.Text = "OBTENER";
            this.btnObtener.UseVisualStyleBackColor = true;
            this.btnObtener.Click += new System.EventHandler(this.btnObtener_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(307, 89);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(127, 33);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btn_Clientes_Eliminar
            // 
            this.btn_Clientes_Eliminar.Image = global::GestionCombustibles.Properties.Resources._1497657872_001_051;
            this.btn_Clientes_Eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Clientes_Eliminar.Location = new System.Drawing.Point(275, 126);
            this.btn_Clientes_Eliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Clientes_Eliminar.Name = "btn_Clientes_Eliminar";
            this.btn_Clientes_Eliminar.Size = new System.Drawing.Size(117, 47);
            this.btn_Clientes_Eliminar.TabIndex = 20;
            this.btn_Clientes_Eliminar.Text = "Eliminar";
            this.btn_Clientes_Eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Clientes_Eliminar.UseVisualStyleBackColor = true;
            this.btn_Clientes_Eliminar.Click += new System.EventHandler(this.btn_Clientes_Eliminar_Click);
            // 
            // btn_Clientes_Modificar
            // 
            this.btn_Clientes_Modificar.Image = global::GestionCombustibles.Properties.Resources._1497658977_001_45;
            this.btn_Clientes_Modificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Clientes_Modificar.Location = new System.Drawing.Point(153, 126);
            this.btn_Clientes_Modificar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Clientes_Modificar.Name = "btn_Clientes_Modificar";
            this.btn_Clientes_Modificar.Size = new System.Drawing.Size(117, 47);
            this.btn_Clientes_Modificar.TabIndex = 19;
            this.btn_Clientes_Modificar.Text = "Modificar";
            this.btn_Clientes_Modificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Clientes_Modificar.UseVisualStyleBackColor = true;
            this.btn_Clientes_Modificar.Click += new System.EventHandler(this.btn_Clientes_Modificar_Click);
            // 
            // btn_Clientes_Nuevo
            // 
            this.btn_Clientes_Nuevo.Image = global::GestionCombustibles.Properties.Resources._1497658601_add;
            this.btn_Clientes_Nuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Clientes_Nuevo.Location = new System.Drawing.Point(32, 126);
            this.btn_Clientes_Nuevo.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Clientes_Nuevo.Name = "btn_Clientes_Nuevo";
            this.btn_Clientes_Nuevo.Size = new System.Drawing.Size(117, 47);
            this.btn_Clientes_Nuevo.TabIndex = 18;
            this.btn_Clientes_Nuevo.Text = "Nuevo";
            this.btn_Clientes_Nuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Clientes_Nuevo.UseVisualStyleBackColor = true;
            this.btn_Clientes_Nuevo.Click += new System.EventHandler(this.btn_Clientes_Nuevo_Click);
            // 
            // btn_Clientes_Buscar_Sunat
            // 
            this.btn_Clientes_Buscar_Sunat.Image = global::GestionCombustibles.Properties.Resources.Logotipo_SUNAT_png_21;
            this.btn_Clientes_Buscar_Sunat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Clientes_Buscar_Sunat.Location = new System.Drawing.Point(619, 12);
            this.btn_Clientes_Buscar_Sunat.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Clientes_Buscar_Sunat.Name = "btn_Clientes_Buscar_Sunat";
            this.btn_Clientes_Buscar_Sunat.Size = new System.Drawing.Size(117, 78);
            this.btn_Clientes_Buscar_Sunat.TabIndex = 21;
            this.btn_Clientes_Buscar_Sunat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Clientes_Buscar_Sunat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Clientes_Buscar_Sunat.UseVisualStyleBackColor = true;
            this.btn_Clientes_Buscar_Sunat.Click += new System.EventHandler(this.btn_Clientes_Buscar_Sunat_Click);
            // 
            // btn_Clientes_Buscar
            // 
            this.btn_Clientes_Buscar.Image = global::GestionCombustibles.Properties.Resources._1497658339_search_321;
            this.btn_Clientes_Buscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Clientes_Buscar.Location = new System.Drawing.Point(619, 11);
            this.btn_Clientes_Buscar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Clientes_Buscar.Name = "btn_Clientes_Buscar";
            this.btn_Clientes_Buscar.Size = new System.Drawing.Size(117, 79);
            this.btn_Clientes_Buscar.TabIndex = 11;
            this.btn_Clientes_Buscar.Text = "Buscar";
            this.btn_Clientes_Buscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Clientes_Buscar.UseVisualStyleBackColor = true;
            this.btn_Clientes_Buscar.Click += new System.EventHandler(this.btn_Clientes_Buscar_Click);
            // 
            // frm_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 583);
            this.Controls.Add(this.pnlBusquedaSunat);
            this.Controls.Add(this.btn_Clientes_Eliminar);
            this.Controls.Add(this.btn_Clientes_Modificar);
            this.Controls.Add(this.btn_Clientes_Nuevo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gb_Clientes_Buscar);
            this.Controls.Add(this.gv_Clientes_Lista);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Cliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Cliente";
            this.Activated += new System.EventHandler(this.frm_Cliente_Activated);
            this.Load += new System.EventHandler(this.frm_Cliente_Load);
            this.gb_Clientes_Buscar.ResumeLayout(false);
            this.gb_Clientes_Buscar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Clientes_Lista)).EndInit();
            this.pnlBusquedaSunat.ResumeLayout(false);
            this.pnlBusquedaSunat.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Clientes_Eliminar;
        private System.Windows.Forms.Button btn_Clientes_Modificar;
        private System.Windows.Forms.Button btn_Clientes_Nuevo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gb_Clientes_Buscar;
        private System.Windows.Forms.TextBox txt_buscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Clientes_Buscar;
        private System.Windows.Forms.DataGridView gv_Clientes_Lista;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumDoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Linea;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreditoUsado;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreditoDisponible;
        private System.Windows.Forms.Button btn_Clientes_Buscar_Sunat;
        private System.Windows.Forms.Panel pnlBusquedaSunat;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnObtener;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtRucDNI;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblRucDNI;
    }
}