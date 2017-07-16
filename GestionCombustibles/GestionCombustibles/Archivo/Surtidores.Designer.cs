namespace GestionCombustibles.Archivo
{
    partial class frm_Surtidores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Surtidores));
            this.gv_Lista_Surtidores = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumDoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.gb_Surtidores_Buscar = new System.Windows.Forms.GroupBox();
            this.txt_buscar = new System.Windows.Forms.TextBox();
            this.btn_Surtidores_Buscar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Surtidores_Modificar = new System.Windows.Forms.Button();
            this.btn_Surtidores_Eliminar = new System.Windows.Forms.Button();
            this.btn_Surtidores_Nuevo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Lista_Surtidores)).BeginInit();
            this.gb_Surtidores_Buscar.SuspendLayout();
            this.SuspendLayout();
            // 
            // gv_Lista_Surtidores
            // 
            this.gv_Lista_Surtidores.AllowUserToAddRows = false;
            this.gv_Lista_Surtidores.AllowUserToDeleteRows = false;
            this.gv_Lista_Surtidores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_Lista_Surtidores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.NumDoc,
            this.Cliente});
            this.gv_Lista_Surtidores.Location = new System.Drawing.Point(13, 122);
            this.gv_Lista_Surtidores.Name = "gv_Lista_Surtidores";
            this.gv_Lista_Surtidores.ReadOnly = true;
            this.gv_Lista_Surtidores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gv_Lista_Surtidores.Size = new System.Drawing.Size(455, 287);
            this.gv_Lista_Surtidores.TabIndex = 21;
            this.gv_Lista_Surtidores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_Lista_Surtidores_CellClick);
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
            this.NumDoc.DataPropertyName = "Str_cod_surtidor";
            this.NumDoc.HeaderText = "Codigo";
            this.NumDoc.Name = "NumDoc";
            this.NumDoc.ReadOnly = true;
            // 
            // Cliente
            // 
            this.Cliente.DataPropertyName = "Str_denominacion_surtidor";
            this.Cliente.FillWeight = 300F;
            this.Cliente.HeaderText = "Denominacion";
            this.Cliente.Name = "Cliente";
            this.Cliente.ReadOnly = true;
            this.Cliente.Width = 300;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(209, -26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 24);
            this.label1.TabIndex = 22;
            this.label1.Text = "Operadoes/Usuarios";
            // 
            // gb_Surtidores_Buscar
            // 
            this.gb_Surtidores_Buscar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.gb_Surtidores_Buscar.Controls.Add(this.txt_buscar);
            this.gb_Surtidores_Buscar.Controls.Add(this.btn_Surtidores_Buscar);
            this.gb_Surtidores_Buscar.Controls.Add(this.label4);
            this.gb_Surtidores_Buscar.Location = new System.Drawing.Point(12, 12);
            this.gb_Surtidores_Buscar.Name = "gb_Surtidores_Buscar";
            this.gb_Surtidores_Buscar.Size = new System.Drawing.Size(465, 54);
            this.gb_Surtidores_Buscar.TabIndex = 23;
            this.gb_Surtidores_Buscar.TabStop = false;
            this.gb_Surtidores_Buscar.Text = "Buscar Surtidos";
            // 
            // txt_buscar
            // 
            this.txt_buscar.Location = new System.Drawing.Point(151, 19);
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(210, 20);
            this.txt_buscar.TabIndex = 4;
            // 
            // btn_Surtidores_Buscar
            // 
            this.btn_Surtidores_Buscar.Image = global::GestionCombustibles.Properties.Resources._1497658339_search_321;
            this.btn_Surtidores_Buscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Surtidores_Buscar.Location = new System.Drawing.Point(372, 9);
            this.btn_Surtidores_Buscar.Name = "btn_Surtidores_Buscar";
            this.btn_Surtidores_Buscar.Size = new System.Drawing.Size(88, 38);
            this.btn_Surtidores_Buscar.TabIndex = 24;
            this.btn_Surtidores_Buscar.Text = "Buscar";
            this.btn_Surtidores_Buscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Surtidores_Buscar.UseVisualStyleBackColor = true;
            this.btn_Surtidores_Buscar.Click += new System.EventHandler(this.btn_Surtidores_Buscar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Codigo/Denominación";
            // 
            // btn_Surtidores_Modificar
            // 
            this.btn_Surtidores_Modificar.Image = global::GestionCombustibles.Properties.Resources._1497658977_001_45;
            this.btn_Surtidores_Modificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Surtidores_Modificar.Location = new System.Drawing.Point(104, 72);
            this.btn_Surtidores_Modificar.Name = "btn_Surtidores_Modificar";
            this.btn_Surtidores_Modificar.Size = new System.Drawing.Size(88, 38);
            this.btn_Surtidores_Modificar.TabIndex = 26;
            this.btn_Surtidores_Modificar.Text = "Modificar";
            this.btn_Surtidores_Modificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Surtidores_Modificar.UseVisualStyleBackColor = true;
            this.btn_Surtidores_Modificar.Click += new System.EventHandler(this.btn_Surtidores_Modificar_Click);
            // 
            // btn_Surtidores_Eliminar
            // 
            this.btn_Surtidores_Eliminar.Image = global::GestionCombustibles.Properties.Resources._1497657872_001_051;
            this.btn_Surtidores_Eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Surtidores_Eliminar.Location = new System.Drawing.Point(195, 72);
            this.btn_Surtidores_Eliminar.Name = "btn_Surtidores_Eliminar";
            this.btn_Surtidores_Eliminar.Size = new System.Drawing.Size(88, 38);
            this.btn_Surtidores_Eliminar.TabIndex = 27;
            this.btn_Surtidores_Eliminar.Text = "Eliminar";
            this.btn_Surtidores_Eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Surtidores_Eliminar.UseVisualStyleBackColor = true;
            this.btn_Surtidores_Eliminar.Click += new System.EventHandler(this.btn_Surtidores_Eliminar_Click);
            // 
            // btn_Surtidores_Nuevo
            // 
            this.btn_Surtidores_Nuevo.Image = global::GestionCombustibles.Properties.Resources._1497658601_add;
            this.btn_Surtidores_Nuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Surtidores_Nuevo.Location = new System.Drawing.Point(13, 72);
            this.btn_Surtidores_Nuevo.Name = "btn_Surtidores_Nuevo";
            this.btn_Surtidores_Nuevo.Size = new System.Drawing.Size(88, 38);
            this.btn_Surtidores_Nuevo.TabIndex = 25;
            this.btn_Surtidores_Nuevo.Text = "Nuevo";
            this.btn_Surtidores_Nuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Surtidores_Nuevo.UseVisualStyleBackColor = true;
            this.btn_Surtidores_Nuevo.Click += new System.EventHandler(this.btn_Surtidores_Nuevo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(325, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "label3";
            this.label2.Visible = false;
            // 
            // frm_Surtidores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(482, 421);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Surtidores_Modificar);
            this.Controls.Add(this.btn_Surtidores_Eliminar);
            this.Controls.Add(this.btn_Surtidores_Nuevo);
            this.Controls.Add(this.gb_Surtidores_Buscar);
            this.Controls.Add(this.gv_Lista_Surtidores);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Surtidores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Surtidores";
            this.Activated += new System.EventHandler(this.frm_Surtidores_Activated);
            this.Load += new System.EventHandler(this.frm_Surtidores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gv_Lista_Surtidores)).EndInit();
            this.gb_Surtidores_Buscar.ResumeLayout(false);
            this.gb_Surtidores_Buscar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gv_Lista_Surtidores;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gb_Surtidores_Buscar;
        private System.Windows.Forms.TextBox txt_buscar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumDoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.Button btn_Surtidores_Modificar;
        private System.Windows.Forms.Button btn_Surtidores_Buscar;
        private System.Windows.Forms.Button btn_Surtidores_Eliminar;
        private System.Windows.Forms.Button btn_Surtidores_Nuevo;
        private System.Windows.Forms.Label label2;
    }
}