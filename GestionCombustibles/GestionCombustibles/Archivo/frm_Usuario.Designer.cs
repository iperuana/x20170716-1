namespace GestionCombustibles.Archivo
{
    partial class frm_Usuario
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
            this.txt_Usuario_buscar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Usuario_Buscar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.gv_Lista_Ususario = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumDoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Usuario_Eliminar = new System.Windows.Forms.Button();
            this.btn_Usuario_Modificar = new System.Windows.Forms.Button();
            this.btn_Islas_Nuevo = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Lista_Ususario)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_Usuario_buscar
            // 
            this.txt_Usuario_buscar.Location = new System.Drawing.Point(136, 25);
            this.txt_Usuario_buscar.Name = "txt_Usuario_buscar";
            this.txt_Usuario_buscar.Size = new System.Drawing.Size(202, 20);
            this.txt_Usuario_buscar.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Nombre/usuario";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Usuario_Buscar);
            this.groupBox1.Controls.Add(this.txt_Usuario_buscar);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(462, 60);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar Usuario";
            // 
            // btn_Usuario_Buscar
            // 
            this.btn_Usuario_Buscar.Image = global::GestionCombustibles.Properties.Resources._1497658339_search_321;
            this.btn_Usuario_Buscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Usuario_Buscar.Location = new System.Drawing.Point(360, 15);
            this.btn_Usuario_Buscar.Name = "btn_Usuario_Buscar";
            this.btn_Usuario_Buscar.Size = new System.Drawing.Size(88, 38);
            this.btn_Usuario_Buscar.TabIndex = 33;
            this.btn_Usuario_Buscar.Text = "Buscar";
            this.btn_Usuario_Buscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Usuario_Buscar.UseVisualStyleBackColor = true;
            this.btn_Usuario_Buscar.Click += new System.EventHandler(this.btn_Usuario_Buscar_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(297, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "label2";
            // 
            // gv_Lista_Ususario
            // 
            this.gv_Lista_Ususario.AllowUserToAddRows = false;
            this.gv_Lista_Ususario.AllowUserToDeleteRows = false;
            this.gv_Lista_Ususario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_Lista_Ususario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.NumDoc,
            this.Cliente});
            this.gv_Lista_Ususario.Location = new System.Drawing.Point(14, 127);
            this.gv_Lista_Ususario.Name = "gv_Lista_Ususario";
            this.gv_Lista_Ususario.ReadOnly = true;
            this.gv_Lista_Ususario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gv_Lista_Ususario.Size = new System.Drawing.Size(446, 258);
            this.gv_Lista_Ususario.TabIndex = 35;
            this.gv_Lista_Ususario.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_Lista_Ususario_CellClick);
         
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
            this.NumDoc.DataPropertyName = "Str_nom_usuario";
            this.NumDoc.FillWeight = 200F;
            this.NumDoc.HeaderText = "Nombre";
            this.NumDoc.Name = "NumDoc";
            this.NumDoc.ReadOnly = true;
            this.NumDoc.Width = 200;
            // 
            // Cliente
            // 
            this.Cliente.DataPropertyName = "Str_usuario";
            this.Cliente.FillWeight = 200F;
            this.Cliente.HeaderText = "Ususario";
            this.Cliente.Name = "Cliente";
            this.Cliente.ReadOnly = true;
            this.Cliente.Width = 200;
            // 
            // btn_Usuario_Eliminar
            // 
            this.btn_Usuario_Eliminar.Image = global::GestionCombustibles.Properties.Resources._1497657872_001_051;
            this.btn_Usuario_Eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Usuario_Eliminar.Location = new System.Drawing.Point(195, 83);
            this.btn_Usuario_Eliminar.Name = "btn_Usuario_Eliminar";
            this.btn_Usuario_Eliminar.Size = new System.Drawing.Size(88, 38);
            this.btn_Usuario_Eliminar.TabIndex = 39;
            this.btn_Usuario_Eliminar.Text = "Eliminar";
            this.btn_Usuario_Eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Usuario_Eliminar.UseVisualStyleBackColor = true;
            this.btn_Usuario_Eliminar.Click += new System.EventHandler(this.btn_Usuario_Eliminar_Click);
            // 
            // btn_Usuario_Modificar
            // 
            this.btn_Usuario_Modificar.Image = global::GestionCombustibles.Properties.Resources._1497658977_001_45;
            this.btn_Usuario_Modificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Usuario_Modificar.Location = new System.Drawing.Point(105, 83);
            this.btn_Usuario_Modificar.Name = "btn_Usuario_Modificar";
            this.btn_Usuario_Modificar.Size = new System.Drawing.Size(88, 38);
            this.btn_Usuario_Modificar.TabIndex = 38;
            this.btn_Usuario_Modificar.Text = "Modificar";
            this.btn_Usuario_Modificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Usuario_Modificar.UseVisualStyleBackColor = true;
            this.btn_Usuario_Modificar.Click += new System.EventHandler(this.btn_Usuario_Modificar_Click);
            // 
            // btn_Islas_Nuevo
            // 
            this.btn_Islas_Nuevo.Image = global::GestionCombustibles.Properties.Resources._1497658601_add;
            this.btn_Islas_Nuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Islas_Nuevo.Location = new System.Drawing.Point(13, 83);
            this.btn_Islas_Nuevo.Name = "btn_Islas_Nuevo";
            this.btn_Islas_Nuevo.Size = new System.Drawing.Size(88, 38);
            this.btn_Islas_Nuevo.TabIndex = 37;
            this.btn_Islas_Nuevo.Text = "Nuevo";
            this.btn_Islas_Nuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Islas_Nuevo.UseVisualStyleBackColor = true;
            this.btn_Islas_Nuevo.Click += new System.EventHandler(this.btn_Islas_Nuevo_Click);
            // 
            // frm_Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 412);
            this.Controls.Add(this.btn_Usuario_Eliminar);
            this.Controls.Add(this.btn_Usuario_Modificar);
            this.Controls.Add(this.btn_Islas_Nuevo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gv_Lista_Ususario);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_Usuario";
            this.Text = "frm_Usuario";
            this.Activated += new System.EventHandler(this.frm_Usuario_Activated);
            this.Load += new System.EventHandler(this.frm_Usuario_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Lista_Ususario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Usuario_buscar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Usuario_Buscar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Usuario_Eliminar;
        private System.Windows.Forms.Button btn_Usuario_Modificar;
        private System.Windows.Forms.Button btn_Islas_Nuevo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView gv_Lista_Ususario;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumDoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
    }
}