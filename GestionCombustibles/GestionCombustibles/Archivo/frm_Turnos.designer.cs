namespace GestionCombustibles.Archivo
{
    partial class frm_Turnos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Turnos));
            this.gv_Lista_Turnos = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumDoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Linea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gb_Turnos_Buscar = new System.Windows.Forms.GroupBox();
            this.mtb_Turno_fin = new System.Windows.Forms.MaskedTextBox();
            this.mtb_Turno_inicio = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_Turnos_Modificar = new System.Windows.Forms.Button();
            this.btn_Turnos_Nuevo = new System.Windows.Forms.Button();
            this.btn_Turnos_Buscar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Lista_Turnos)).BeginInit();
            this.gb_Turnos_Buscar.SuspendLayout();
            this.SuspendLayout();
            // 
            // gv_Lista_Turnos
            // 
            this.gv_Lista_Turnos.AllowUserToAddRows = false;
            this.gv_Lista_Turnos.AllowUserToDeleteRows = false;
            this.gv_Lista_Turnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_Lista_Turnos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.NumDoc,
            this.Cliente,
            this.Linea});
            this.gv_Lista_Turnos.Location = new System.Drawing.Point(12, 116);
            this.gv_Lista_Turnos.Name = "gv_Lista_Turnos";
            this.gv_Lista_Turnos.ReadOnly = true;
            this.gv_Lista_Turnos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gv_Lista_Turnos.Size = new System.Drawing.Size(508, 287);
            this.gv_Lista_Turnos.TabIndex = 21;
            this.gv_Lista_Turnos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_Lista_Turnos_CellClick);
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
            this.NumDoc.DataPropertyName = "Str_cod_turno";
            this.NumDoc.HeaderText = "Codigo";
            this.NumDoc.Name = "NumDoc";
            this.NumDoc.ReadOnly = true;
            // 
            // Cliente
            // 
            this.Cliente.DataPropertyName = "Str_hora_inicio";
            this.Cliente.FillWeight = 300F;
            this.Cliente.HeaderText = "Desde";
            this.Cliente.Name = "Cliente";
            this.Cliente.ReadOnly = true;
            this.Cliente.Width = 300;
            // 
            // Linea
            // 
            this.Linea.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Linea.DataPropertyName = "Str_hora_fin";
            this.Linea.HeaderText = "Hasta";
            this.Linea.Name = "Linea";
            this.Linea.ReadOnly = true;
            this.Linea.Width = 60;
            // 
            // gb_Turnos_Buscar
            // 
            this.gb_Turnos_Buscar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.gb_Turnos_Buscar.Controls.Add(this.mtb_Turno_fin);
            this.gb_Turnos_Buscar.Controls.Add(this.mtb_Turno_inicio);
            this.gb_Turnos_Buscar.Controls.Add(this.label4);
            this.gb_Turnos_Buscar.Controls.Add(this.label1);
            this.gb_Turnos_Buscar.Location = new System.Drawing.Point(12, 12);
            this.gb_Turnos_Buscar.Name = "gb_Turnos_Buscar";
            this.gb_Turnos_Buscar.Size = new System.Drawing.Size(508, 54);
            this.gb_Turnos_Buscar.TabIndex = 22;
            this.gb_Turnos_Buscar.TabStop = false;
            this.gb_Turnos_Buscar.Text = "Buscar Turnos";
            // 
            // mtb_Turno_fin
            // 
            this.mtb_Turno_fin.Location = new System.Drawing.Point(264, 18);
            this.mtb_Turno_fin.Name = "mtb_Turno_fin";
            this.mtb_Turno_fin.Size = new System.Drawing.Size(100, 20);
            this.mtb_Turno_fin.TabIndex = 41;
            // 
            // mtb_Turno_inicio
            // 
            this.mtb_Turno_inicio.Location = new System.Drawing.Point(88, 18);
            this.mtb_Turno_inicio.Name = "mtb_Turno_inicio";
            this.mtb_Turno_inicio.Size = new System.Drawing.Size(100, 20);
            this.mtb_Turno_inicio.TabIndex = 40;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(223, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Hasta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Desde";
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Image = global::GestionCombustibles.Properties.Resources._1497657872_001_051;
            this.btn_Eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Eliminar.Location = new System.Drawing.Point(195, 72);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(88, 38);
            this.btn_Eliminar.TabIndex = 26;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // btn_Turnos_Modificar
            // 
            this.btn_Turnos_Modificar.Image = global::GestionCombustibles.Properties.Resources._1497658977_001_45;
            this.btn_Turnos_Modificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Turnos_Modificar.Location = new System.Drawing.Point(104, 72);
            this.btn_Turnos_Modificar.Name = "btn_Turnos_Modificar";
            this.btn_Turnos_Modificar.Size = new System.Drawing.Size(88, 38);
            this.btn_Turnos_Modificar.TabIndex = 25;
            this.btn_Turnos_Modificar.Text = "Modificar";
            this.btn_Turnos_Modificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Turnos_Modificar.UseVisualStyleBackColor = true;
            this.btn_Turnos_Modificar.Click += new System.EventHandler(this.btn_Turnos_Modificar_Click);
            // 
            // btn_Turnos_Nuevo
            // 
            this.btn_Turnos_Nuevo.Image = global::GestionCombustibles.Properties.Resources._1497658601_add;
            this.btn_Turnos_Nuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Turnos_Nuevo.Location = new System.Drawing.Point(13, 72);
            this.btn_Turnos_Nuevo.Name = "btn_Turnos_Nuevo";
            this.btn_Turnos_Nuevo.Size = new System.Drawing.Size(88, 38);
            this.btn_Turnos_Nuevo.TabIndex = 24;
            this.btn_Turnos_Nuevo.Text = "Nuevo";
            this.btn_Turnos_Nuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Turnos_Nuevo.UseVisualStyleBackColor = true;
            this.btn_Turnos_Nuevo.Click += new System.EventHandler(this.btn_Turnos_Nuevo_Click);
            // 
            // btn_Turnos_Buscar
            // 
            this.btn_Turnos_Buscar.Image = global::GestionCombustibles.Properties.Resources._1497658339_search_321;
            this.btn_Turnos_Buscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Turnos_Buscar.Location = new System.Drawing.Point(425, 22);
            this.btn_Turnos_Buscar.Name = "btn_Turnos_Buscar";
            this.btn_Turnos_Buscar.Size = new System.Drawing.Size(88, 38);
            this.btn_Turnos_Buscar.TabIndex = 23;
            this.btn_Turnos_Buscar.Text = "Buscar";
            this.btn_Turnos_Buscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Turnos_Buscar.UseVisualStyleBackColor = true;
            this.btn_Turnos_Buscar.Click += new System.EventHandler(this.btn_Turnos_Buscar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(341, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "label2";
            this.label2.Visible = false;
            // 
            // frm_Turnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(525, 409);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Eliminar);
            this.Controls.Add(this.btn_Turnos_Modificar);
            this.Controls.Add(this.btn_Turnos_Nuevo);
            this.Controls.Add(this.btn_Turnos_Buscar);
            this.Controls.Add(this.gb_Turnos_Buscar);
            this.Controls.Add(this.gv_Lista_Turnos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Turnos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Turnos";
            this.Activated += new System.EventHandler(this.frm_Turnos_Activated);
            this.Load += new System.EventHandler(this.frm_Turnos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gv_Lista_Turnos)).EndInit();
            this.gb_Turnos_Buscar.ResumeLayout(false);
            this.gb_Turnos_Buscar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gv_Lista_Turnos;
        private System.Windows.Forms.GroupBox gb_Turnos_Buscar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumDoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Linea;
        private System.Windows.Forms.MaskedTextBox mtb_Turno_fin;
        private System.Windows.Forms.MaskedTextBox mtb_Turno_inicio;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Button btn_Turnos_Modificar;
        private System.Windows.Forms.Button btn_Turnos_Nuevo;
        private System.Windows.Forms.Button btn_Turnos_Buscar;
        private System.Windows.Forms.Label label2;
    }
}