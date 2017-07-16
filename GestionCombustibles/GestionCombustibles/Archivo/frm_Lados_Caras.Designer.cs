namespace GestionCombustibles.Archivo
{
    partial class frm_Lados_Caras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Lados_Caras));
            this.label2 = new System.Windows.Forms.Label();
            this.gb_Lados_Caras_Buscar = new System.Windows.Forms.GroupBox();
            this.txt_buscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gv_LadosCaras_Lista = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumDoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.btn_Nuevo = new System.Windows.Forms.Button();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.gb_Lados_Caras_Buscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_LadosCaras_Lista)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(320, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "label2";
            this.label2.Visible = false;
            // 
            // gb_Lados_Caras_Buscar
            // 
            this.gb_Lados_Caras_Buscar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.gb_Lados_Caras_Buscar.Controls.Add(this.txt_buscar);
            this.gb_Lados_Caras_Buscar.Controls.Add(this.btn_Buscar);
            this.gb_Lados_Caras_Buscar.Controls.Add(this.label1);
            this.gb_Lados_Caras_Buscar.Location = new System.Drawing.Point(8, 10);
            this.gb_Lados_Caras_Buscar.Name = "gb_Lados_Caras_Buscar";
            this.gb_Lados_Caras_Buscar.Size = new System.Drawing.Size(450, 54);
            this.gb_Lados_Caras_Buscar.TabIndex = 29;
            this.gb_Lados_Caras_Buscar.TabStop = false;
            this.gb_Lados_Caras_Buscar.Text = "Buscar Clientes";
            // 
            // txt_buscar
            // 
            this.txt_buscar.Location = new System.Drawing.Point(151, 19);
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(151, 20);
            this.txt_buscar.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Codigo/Denominación";
            // 
            // gv_LadosCaras_Lista
            // 
            this.gv_LadosCaras_Lista.AllowUserToAddRows = false;
            this.gv_LadosCaras_Lista.AllowUserToDeleteRows = false;
            this.gv_LadosCaras_Lista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_LadosCaras_Lista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.NumDoc,
            this.Cliente});
            this.gv_LadosCaras_Lista.Location = new System.Drawing.Point(8, 113);
            this.gv_LadosCaras_Lista.Name = "gv_LadosCaras_Lista";
            this.gv_LadosCaras_Lista.ReadOnly = true;
            this.gv_LadosCaras_Lista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gv_LadosCaras_Lista.Size = new System.Drawing.Size(450, 215);
            this.gv_LadosCaras_Lista.TabIndex = 28;
            this.gv_LadosCaras_Lista.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_LadosCaras_Lista_CellClick);
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
            this.NumDoc.DataPropertyName = "Str_cod_lados";
            this.NumDoc.HeaderText = "Codigo";
            this.NumDoc.Name = "NumDoc";
            this.NumDoc.ReadOnly = true;
            // 
            // Cliente
            // 
            this.Cliente.DataPropertyName = "Str_denominacion_lados";
            this.Cliente.FillWeight = 300F;
            this.Cliente.HeaderText = "Denominación";
            this.Cliente.Name = "Cliente";
            this.Cliente.ReadOnly = true;
            this.Cliente.Width = 300;
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Image = global::GestionCombustibles.Properties.Resources._1497657872_001_051;
            this.btn_Eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Eliminar.Location = new System.Drawing.Point(189, 69);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(88, 38);
            this.btn_Eliminar.TabIndex = 32;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.Image = global::GestionCombustibles.Properties.Resources._1497658977_001_45;
            this.btn_Modificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Modificar.Location = new System.Drawing.Point(98, 69);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(88, 38);
            this.btn_Modificar.TabIndex = 31;
            this.btn_Modificar.Text = "Modificar";
            this.btn_Modificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Modificar.UseVisualStyleBackColor = true;
            this.btn_Modificar.Click += new System.EventHandler(this.btn_Modificar_Click);
            // 
            // btn_Nuevo
            // 
            this.btn_Nuevo.Image = global::GestionCombustibles.Properties.Resources._1497658601_add;
            this.btn_Nuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Nuevo.Location = new System.Drawing.Point(7, 69);
            this.btn_Nuevo.Name = "btn_Nuevo";
            this.btn_Nuevo.Size = new System.Drawing.Size(88, 38);
            this.btn_Nuevo.TabIndex = 30;
            this.btn_Nuevo.Text = "Nuevo";
            this.btn_Nuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Nuevo.UseVisualStyleBackColor = true;
            this.btn_Nuevo.Click += new System.EventHandler(this.btn_Nuevo_Click);
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Image = global::GestionCombustibles.Properties.Resources._1497658339_search_321;
            this.btn_Buscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Buscar.Location = new System.Drawing.Point(356, 10);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(88, 38);
            this.btn_Buscar.TabIndex = 23;
            this.btn_Buscar.Text = "Buscar";
            this.btn_Buscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Buscar.UseVisualStyleBackColor = true;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // frm_Lados_Caras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 339);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Eliminar);
            this.Controls.Add(this.btn_Modificar);
            this.Controls.Add(this.btn_Nuevo);
            this.Controls.Add(this.gb_Lados_Caras_Buscar);
            this.Controls.Add(this.gv_LadosCaras_Lista);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_Lados_Caras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Lados_Caras";
            this.Activated += new System.EventHandler(this.frm_Lados_Caras_Activated);
            this.Load += new System.EventHandler(this.frm_Lados_Caras_Load);
            this.gb_Lados_Caras_Buscar.ResumeLayout(false);
            this.gb_Lados_Caras_Buscar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_LadosCaras_Lista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Button btn_Modificar;
        private System.Windows.Forms.Button btn_Nuevo;
        private System.Windows.Forms.GroupBox gb_Lados_Caras_Buscar;
        private System.Windows.Forms.TextBox txt_buscar;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gv_LadosCaras_Lista;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumDoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
    }
}