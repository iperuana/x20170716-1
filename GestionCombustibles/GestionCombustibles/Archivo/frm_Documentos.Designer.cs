namespace GestionCombustibles.Archivo
{
    partial class frm_Documentos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Documentos));
            this.label2 = new System.Windows.Forms.Label();
            this.gb_Documentos_Buscar = new System.Windows.Forms.GroupBox();
            this.btn_Documentos_buscar = new System.Windows.Forms.Button();
            this.txt_Documentos_buscar = new System.Windows.Forms.TextBox();
            this.label0 = new System.Windows.Forms.Label();
            this.gv_Documentos_Lista = new System.Windows.Forms.DataGridView();
            this.NumDoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Linea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreditoUsado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Documentos_Eliminar = new System.Windows.Forms.Button();
            this.btn_Documentos_Modificar = new System.Windows.Forms.Button();
            this.btn_Documentos_Nuevo = new System.Windows.Forms.Button();
            this.gb_Documentos_Buscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Documentos_Lista)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(409, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "label1";
            this.label2.Visible = false;
            // 
            // gb_Documentos_Buscar
            // 
            this.gb_Documentos_Buscar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.gb_Documentos_Buscar.Controls.Add(this.btn_Documentos_buscar);
            this.gb_Documentos_Buscar.Controls.Add(this.txt_Documentos_buscar);
            this.gb_Documentos_Buscar.Controls.Add(this.label0);
            this.gb_Documentos_Buscar.Location = new System.Drawing.Point(12, 12);
            this.gb_Documentos_Buscar.Name = "gb_Documentos_Buscar";
            this.gb_Documentos_Buscar.Size = new System.Drawing.Size(593, 54);
            this.gb_Documentos_Buscar.TabIndex = 20;
            this.gb_Documentos_Buscar.TabStop = false;
            this.gb_Documentos_Buscar.Text = "Buscar Documentos";
            // 
            // btn_Documentos_buscar
            // 
            this.btn_Documentos_buscar.Image = global::GestionCombustibles.Properties.Resources._1497658339_search_321;
            this.btn_Documentos_buscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Documentos_buscar.Location = new System.Drawing.Point(465, 11);
            this.btn_Documentos_buscar.Name = "btn_Documentos_buscar";
            this.btn_Documentos_buscar.Size = new System.Drawing.Size(88, 38);
            this.btn_Documentos_buscar.TabIndex = 15;
            this.btn_Documentos_buscar.Text = "Buscar";
            this.btn_Documentos_buscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Documentos_buscar.UseVisualStyleBackColor = true;
            this.btn_Documentos_buscar.Click += new System.EventHandler(this.btn_Documentos_buscar_Click);
            // 
            // txt_Documentos_buscar
            // 
            this.txt_Documentos_buscar.Location = new System.Drawing.Point(151, 19);
            this.txt_Documentos_buscar.Name = "txt_Documentos_buscar";
            this.txt_Documentos_buscar.Size = new System.Drawing.Size(281, 20);
            this.txt_Documentos_buscar.TabIndex = 4;
            // 
            // label0
            // 
            this.label0.AutoSize = true;
            this.label0.Location = new System.Drawing.Point(24, 22);
            this.label0.Name = "label0";
            this.label0.Size = new System.Drawing.Size(104, 13);
            this.label0.TabIndex = 3;
            this.label0.Text = "Denominación/Serie";
            // 
            // gv_Documentos_Lista
            // 
            this.gv_Documentos_Lista.AllowUserToAddRows = false;
            this.gv_Documentos_Lista.AllowUserToDeleteRows = false;
            this.gv_Documentos_Lista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_Documentos_Lista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumDoc,
            this.ID,
            this.Cliente,
            this.Linea,
            this.CreditoUsado});
            this.gv_Documentos_Lista.Location = new System.Drawing.Point(8, 114);
            this.gv_Documentos_Lista.Name = "gv_Documentos_Lista";
            this.gv_Documentos_Lista.ReadOnly = true;
            this.gv_Documentos_Lista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gv_Documentos_Lista.Size = new System.Drawing.Size(601, 344);
            this.gv_Documentos_Lista.TabIndex = 19;
            this.gv_Documentos_Lista.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_Documentos_Lista_CellClick);
            // 
            // NumDoc
            // 
            this.NumDoc.DataPropertyName = "Str_cod_documento";
            this.NumDoc.HeaderText = "Codigo";
            this.NumDoc.Name = "NumDoc";
            this.NumDoc.ReadOnly = true;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // Cliente
            // 
            this.Cliente.DataPropertyName = "Str_deno_documento";
            this.Cliente.FillWeight = 300F;
            this.Cliente.HeaderText = "Denominación";
            this.Cliente.Name = "Cliente";
            this.Cliente.ReadOnly = true;
            this.Cliente.Width = 300;
            // 
            // Linea
            // 
            this.Linea.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Linea.DataPropertyName = "Str_serie_documento";
            this.Linea.HeaderText = "Serie";
            this.Linea.Name = "Linea";
            this.Linea.ReadOnly = true;
            this.Linea.Width = 56;
            // 
            // CreditoUsado
            // 
            this.CreditoUsado.DataPropertyName = "Str_num_documento";
            this.CreditoUsado.HeaderText = "Numero";
            this.CreditoUsado.Name = "CreditoUsado";
            this.CreditoUsado.ReadOnly = true;
            // 
            // btn_Documentos_Eliminar
            // 
            this.btn_Documentos_Eliminar.Image = global::GestionCombustibles.Properties.Resources._1497657872_001_051;
            this.btn_Documentos_Eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Documentos_Eliminar.Location = new System.Drawing.Point(195, 72);
            this.btn_Documentos_Eliminar.Name = "btn_Documentos_Eliminar";
            this.btn_Documentos_Eliminar.Size = new System.Drawing.Size(88, 38);
            this.btn_Documentos_Eliminar.TabIndex = 24;
            this.btn_Documentos_Eliminar.Text = "Eliminar";
            this.btn_Documentos_Eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Documentos_Eliminar.UseVisualStyleBackColor = true;
            this.btn_Documentos_Eliminar.Click += new System.EventHandler(this.btn_Documentos_Eliminar_Click);
            // 
            // btn_Documentos_Modificar
            // 
            this.btn_Documentos_Modificar.Image = global::GestionCombustibles.Properties.Resources._1497658977_001_45;
            this.btn_Documentos_Modificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Documentos_Modificar.Location = new System.Drawing.Point(104, 72);
            this.btn_Documentos_Modificar.Name = "btn_Documentos_Modificar";
            this.btn_Documentos_Modificar.Size = new System.Drawing.Size(88, 38);
            this.btn_Documentos_Modificar.TabIndex = 23;
            this.btn_Documentos_Modificar.Text = "Modificar";
            this.btn_Documentos_Modificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Documentos_Modificar.UseVisualStyleBackColor = true;
            this.btn_Documentos_Modificar.Click += new System.EventHandler(this.btn_Documentos_Modificar_Click);
            // 
            // btn_Documentos_Nuevo
            // 
            this.btn_Documentos_Nuevo.Image = global::GestionCombustibles.Properties.Resources._1497658601_add;
            this.btn_Documentos_Nuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Documentos_Nuevo.Location = new System.Drawing.Point(13, 72);
            this.btn_Documentos_Nuevo.Name = "btn_Documentos_Nuevo";
            this.btn_Documentos_Nuevo.Size = new System.Drawing.Size(88, 38);
            this.btn_Documentos_Nuevo.TabIndex = 22;
            this.btn_Documentos_Nuevo.Text = "Nuevo";
            this.btn_Documentos_Nuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Documentos_Nuevo.UseVisualStyleBackColor = true;
            this.btn_Documentos_Nuevo.Click += new System.EventHandler(this.btn_Documentos_Nuevo_Click);
            // 
            // frm_Documentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 464);
            this.Controls.Add(this.btn_Documentos_Eliminar);
            this.Controls.Add(this.btn_Documentos_Modificar);
            this.Controls.Add(this.btn_Documentos_Nuevo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gb_Documentos_Buscar);
            this.Controls.Add(this.gv_Documentos_Lista);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_Documentos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Documentos";
            this.Activated += new System.EventHandler(this.frm_Documentos_Activated);
            this.Load += new System.EventHandler(this.frm_Documentos_Load);
            this.gb_Documentos_Buscar.ResumeLayout(false);
            this.gb_Documentos_Buscar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Documentos_Lista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Documentos_Eliminar;
        private System.Windows.Forms.Button btn_Documentos_Modificar;
        private System.Windows.Forms.Button btn_Documentos_Nuevo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gb_Documentos_Buscar;
        private System.Windows.Forms.Button btn_Documentos_buscar;
        private System.Windows.Forms.TextBox txt_Documentos_buscar;
        private System.Windows.Forms.Label label0;
        private System.Windows.Forms.DataGridView gv_Documentos_Lista;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumDoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Linea;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreditoUsado;
    }
}