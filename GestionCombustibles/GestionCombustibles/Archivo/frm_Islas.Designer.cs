namespace GestionCombustibles.Archivo
{
    partial class frm_Islas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Islas));
            this.gb_Islas_Buscar = new System.Windows.Forms.GroupBox();
            this.txt_Islas_buscar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Islas_Buscar = new System.Windows.Forms.Button();
            this.gv_Lista_Islas = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumDoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Islas_Eliminar = new System.Windows.Forms.Button();
            this.btn_Islas_Modificar = new System.Windows.Forms.Button();
            this.btn_Islas_Nuevo = new System.Windows.Forms.Button();
            this.gb_Islas_Buscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Lista_Islas)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_Islas_Buscar
            // 
            this.gb_Islas_Buscar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.gb_Islas_Buscar.Controls.Add(this.txt_Islas_buscar);
            this.gb_Islas_Buscar.Controls.Add(this.label3);
            this.gb_Islas_Buscar.Controls.Add(this.btn_Islas_Buscar);
            this.gb_Islas_Buscar.Location = new System.Drawing.Point(16, 15);
            this.gb_Islas_Buscar.Name = "gb_Islas_Buscar";
            this.gb_Islas_Buscar.Size = new System.Drawing.Size(457, 55);
            this.gb_Islas_Buscar.TabIndex = 28;
            this.gb_Islas_Buscar.TabStop = false;
            this.gb_Islas_Buscar.Text = "Buscar Surtidos";
            // 
            // txt_Islas_buscar
            // 
            this.txt_Islas_buscar.Location = new System.Drawing.Point(151, 19);
            this.txt_Islas_buscar.Name = "txt_Islas_buscar";
            this.txt_Islas_buscar.Size = new System.Drawing.Size(202, 20);
            this.txt_Islas_buscar.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Codigo/Denominación";
            // 
            // btn_Islas_Buscar
            // 
            this.btn_Islas_Buscar.Image = global::GestionCombustibles.Properties.Resources._1497658339_search_321;
            this.btn_Islas_Buscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Islas_Buscar.Location = new System.Drawing.Point(363, 10);
            this.btn_Islas_Buscar.Name = "btn_Islas_Buscar";
            this.btn_Islas_Buscar.Size = new System.Drawing.Size(88, 38);
            this.btn_Islas_Buscar.TabIndex = 30;
            this.btn_Islas_Buscar.Text = "Buscar";
            this.btn_Islas_Buscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Islas_Buscar.UseVisualStyleBackColor = true;
            this.btn_Islas_Buscar.Click += new System.EventHandler(this.btn_Islas_Buscar_Click);
            // 
            // gv_Lista_Islas
            // 
            this.gv_Lista_Islas.AllowUserToAddRows = false;
            this.gv_Lista_Islas.AllowUserToDeleteRows = false;
            this.gv_Lista_Islas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_Lista_Islas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.NumDoc,
            this.Cliente});
            this.gv_Lista_Islas.Location = new System.Drawing.Point(17, 120);
            this.gv_Lista_Islas.Name = "gv_Lista_Islas";
            this.gv_Lista_Islas.ReadOnly = true;
            this.gv_Lista_Islas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gv_Lista_Islas.Size = new System.Drawing.Size(446, 258);
            this.gv_Lista_Islas.TabIndex = 27;
            this.gv_Lista_Islas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_Lista_Islas_CellClick);
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
            this.NumDoc.DataPropertyName = "Str_cod_isla";
            this.NumDoc.HeaderText = "Codigo";
            this.NumDoc.Name = "NumDoc";
            this.NumDoc.ReadOnly = true;
            // 
            // Cliente
            // 
            this.Cliente.DataPropertyName = "Str_denominacion_isla";
            this.Cliente.FillWeight = 300F;
            this.Cliente.HeaderText = "Denominacion";
            this.Cliente.Name = "Cliente";
            this.Cliente.ReadOnly = true;
            this.Cliente.Width = 300;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(300, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "label1";
            this.label2.Visible = false;
            // 
            // btn_Islas_Eliminar
            // 
            this.btn_Islas_Eliminar.Image = global::GestionCombustibles.Properties.Resources._1497657872_001_051;
            this.btn_Islas_Eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Islas_Eliminar.Location = new System.Drawing.Point(198, 76);
            this.btn_Islas_Eliminar.Name = "btn_Islas_Eliminar";
            this.btn_Islas_Eliminar.Size = new System.Drawing.Size(88, 38);
            this.btn_Islas_Eliminar.TabIndex = 33;
            this.btn_Islas_Eliminar.Text = "Eliminar";
            this.btn_Islas_Eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Islas_Eliminar.UseVisualStyleBackColor = true;
            this.btn_Islas_Eliminar.Click += new System.EventHandler(this.btn_Islas_Eliminar_Click);
            // 
            // btn_Islas_Modificar
            // 
            this.btn_Islas_Modificar.Image = global::GestionCombustibles.Properties.Resources._1497658977_001_45;
            this.btn_Islas_Modificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Islas_Modificar.Location = new System.Drawing.Point(108, 76);
            this.btn_Islas_Modificar.Name = "btn_Islas_Modificar";
            this.btn_Islas_Modificar.Size = new System.Drawing.Size(88, 38);
            this.btn_Islas_Modificar.TabIndex = 32;
            this.btn_Islas_Modificar.Text = "Modificar";
            this.btn_Islas_Modificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Islas_Modificar.UseVisualStyleBackColor = true;
            this.btn_Islas_Modificar.Click += new System.EventHandler(this.btn_Islas_Modificar_Click);
            // 
            // btn_Islas_Nuevo
            // 
            this.btn_Islas_Nuevo.Image = global::GestionCombustibles.Properties.Resources._1497658601_add;
            this.btn_Islas_Nuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Islas_Nuevo.Location = new System.Drawing.Point(16, 76);
            this.btn_Islas_Nuevo.Name = "btn_Islas_Nuevo";
            this.btn_Islas_Nuevo.Size = new System.Drawing.Size(88, 38);
            this.btn_Islas_Nuevo.TabIndex = 31;
            this.btn_Islas_Nuevo.Text = "Nuevo";
            this.btn_Islas_Nuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Islas_Nuevo.UseVisualStyleBackColor = true;
            this.btn_Islas_Nuevo.Click += new System.EventHandler(this.btn_Islas_Nuevo_Click);
            // 
            // frm_Islas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 387);
            this.Controls.Add(this.btn_Islas_Eliminar);
            this.Controls.Add(this.btn_Islas_Modificar);
            this.Controls.Add(this.btn_Islas_Nuevo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gb_Islas_Buscar);
            this.Controls.Add(this.gv_Lista_Islas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_Islas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Islas";
            this.Activated += new System.EventHandler(this.frm_Islas_Activated);
            this.Load += new System.EventHandler(this.frm_Islas_Load);
            this.gb_Islas_Buscar.ResumeLayout(false);
            this.gb_Islas_Buscar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Lista_Islas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_Islas_Buscar;
        private System.Windows.Forms.TextBox txt_Islas_buscar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView gv_Lista_Islas;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumDoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Islas_Buscar;
        private System.Windows.Forms.Button btn_Islas_Eliminar;
        private System.Windows.Forms.Button btn_Islas_Modificar;
        private System.Windows.Forms.Button btn_Islas_Nuevo;
    }
}