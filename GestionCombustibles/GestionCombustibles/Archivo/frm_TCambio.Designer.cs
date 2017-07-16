namespace GestionCombustibles
{
    partial class frm_TCambio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_TCambio));
            this.gb_TCambio = new System.Windows.Forms.GroupBox();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.txt_TCambio_Fecha = new System.Windows.Forms.TextBox();
            this.btn_TCambio_Descartar = new System.Windows.Forms.Button();
            this.btn_TCambio_Aceptar = new System.Windows.Forms.Button();
            this.txt_TCambio_Venta = new System.Windows.Forms.TextBox();
            this.txt_TCambio_Compra = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gb_Tcambio_lista = new System.Windows.Forms.GroupBox();
            this.gv_TCambio_Lista = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Compra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Venta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gb_TCambio.SuspendLayout();
            this.gb_Tcambio_lista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_TCambio_Lista)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_TCambio
            // 
            this.gb_TCambio.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gb_TCambio.Controls.Add(this.txt_ID);
            this.gb_TCambio.Controls.Add(this.txt_TCambio_Fecha);
            this.gb_TCambio.Controls.Add(this.btn_TCambio_Descartar);
            this.gb_TCambio.Controls.Add(this.btn_TCambio_Aceptar);
            this.gb_TCambio.Controls.Add(this.txt_TCambio_Venta);
            this.gb_TCambio.Controls.Add(this.txt_TCambio_Compra);
            this.gb_TCambio.Controls.Add(this.label3);
            this.gb_TCambio.Controls.Add(this.label2);
            this.gb_TCambio.Controls.Add(this.label1);
            this.gb_TCambio.Location = new System.Drawing.Point(36, 12);
            this.gb_TCambio.Name = "gb_TCambio";
            this.gb_TCambio.Size = new System.Drawing.Size(341, 120);
            this.gb_TCambio.TabIndex = 0;
            this.gb_TCambio.TabStop = false;
            this.gb_TCambio.Text = "Tipo de Cambio";
            // 
            // txt_ID
            // 
            this.txt_ID.Location = new System.Drawing.Point(8, 31);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(18, 20);
            this.txt_ID.TabIndex = 8;
            this.txt_ID.Visible = false;
            // 
            // txt_TCambio_Fecha
            // 
            this.txt_TCambio_Fecha.Location = new System.Drawing.Point(43, 32);
            this.txt_TCambio_Fecha.Name = "txt_TCambio_Fecha";
            this.txt_TCambio_Fecha.ReadOnly = true;
            this.txt_TCambio_Fecha.Size = new System.Drawing.Size(90, 20);
            this.txt_TCambio_Fecha.TabIndex = 7;
            // 
            // btn_TCambio_Descartar
            // 
            this.btn_TCambio_Descartar.Image = global::GestionCombustibles.Properties.Resources._1497657872_001_05;
            this.btn_TCambio_Descartar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_TCambio_Descartar.Location = new System.Drawing.Point(195, 66);
            this.btn_TCambio_Descartar.Name = "btn_TCambio_Descartar";
            this.btn_TCambio_Descartar.Size = new System.Drawing.Size(88, 38);
            this.btn_TCambio_Descartar.TabIndex = 6;
            this.btn_TCambio_Descartar.Text = "Descartar";
            this.btn_TCambio_Descartar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_TCambio_Descartar.UseVisualStyleBackColor = true;
            this.btn_TCambio_Descartar.Click += new System.EventHandler(this.btn_TCambio_Descartar_Click);
            // 
            // btn_TCambio_Aceptar
            // 
            this.btn_TCambio_Aceptar.Image = global::GestionCombustibles.Properties.Resources._1497657744_001_06;
            this.btn_TCambio_Aceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_TCambio_Aceptar.Location = new System.Drawing.Point(61, 66);
            this.btn_TCambio_Aceptar.Name = "btn_TCambio_Aceptar";
            this.btn_TCambio_Aceptar.Size = new System.Drawing.Size(88, 38);
            this.btn_TCambio_Aceptar.TabIndex = 5;
            this.btn_TCambio_Aceptar.Text = "Aceptar";
            this.btn_TCambio_Aceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_TCambio_Aceptar.UseVisualStyleBackColor = true;
            this.btn_TCambio_Aceptar.Click += new System.EventHandler(this.btn_TCambio_Aceptar_Click);
            // 
            // txt_TCambio_Venta
            // 
            this.txt_TCambio_Venta.Location = new System.Drawing.Point(220, 31);
            this.txt_TCambio_Venta.Name = "txt_TCambio_Venta";
            this.txt_TCambio_Venta.Size = new System.Drawing.Size(84, 20);
            this.txt_TCambio_Venta.TabIndex = 4;
            this.txt_TCambio_Venta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_TCambio_Venta_KeyPress);
            // 
            // txt_TCambio_Compra
            // 
            this.txt_TCambio_Compra.Location = new System.Drawing.Point(139, 32);
            this.txt_TCambio_Compra.Name = "txt_TCambio_Compra";
            this.txt_TCambio_Compra.Size = new System.Drawing.Size(75, 20);
            this.txt_TCambio_Compra.TabIndex = 3;
            this.txt_TCambio_Compra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_TCambio_Compra_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(217, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Venta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Compra";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hoy";
            // 
            // gb_Tcambio_lista
            // 
            this.gb_Tcambio_lista.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gb_Tcambio_lista.Controls.Add(this.gv_TCambio_Lista);
            this.gb_Tcambio_lista.Location = new System.Drawing.Point(21, 138);
            this.gb_Tcambio_lista.Name = "gb_Tcambio_lista";
            this.gb_Tcambio_lista.Size = new System.Drawing.Size(371, 184);
            this.gb_Tcambio_lista.TabIndex = 1;
            this.gb_Tcambio_lista.TabStop = false;
            this.gb_Tcambio_lista.Text = "Historico";
            // 
            // gv_TCambio_Lista
            // 
            this.gv_TCambio_Lista.AllowUserToAddRows = false;
            this.gv_TCambio_Lista.AllowUserToDeleteRows = false;
            this.gv_TCambio_Lista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_TCambio_Lista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Fecha,
            this.Compra,
            this.Venta});
            this.gv_TCambio_Lista.Location = new System.Drawing.Point(11, 19);
            this.gv_TCambio_Lista.Name = "gv_TCambio_Lista";
            this.gv_TCambio_Lista.ReadOnly = true;
            this.gv_TCambio_Lista.Size = new System.Drawing.Size(346, 150);
            this.gv_TCambio_Lista.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // Fecha
            // 
            this.Fecha.DataPropertyName = "Str_Fecha";
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // Compra
            // 
            this.Compra.DataPropertyName = "Dcm_Compra";
            this.Compra.HeaderText = "Compra";
            this.Compra.Name = "Compra";
            this.Compra.ReadOnly = true;
            // 
            // Venta
            // 
            this.Venta.DataPropertyName = "Dcm_Venta";
            this.Venta.HeaderText = "Venta";
            this.Venta.Name = "Venta";
            this.Venta.ReadOnly = true;
            // 
            // frm_TCambio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 331);
            this.Controls.Add(this.gb_Tcambio_lista);
            this.Controls.Add(this.gb_TCambio);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_TCambio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tipo de Cambio";
            this.Load += new System.EventHandler(this.TCanbio_Load);
            this.gb_TCambio.ResumeLayout(false);
            this.gb_TCambio.PerformLayout();
            this.gb_Tcambio_lista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gv_TCambio_Lista)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_TCambio;
        private System.Windows.Forms.Button btn_TCambio_Descartar;
        private System.Windows.Forms.Button btn_TCambio_Aceptar;
        private System.Windows.Forms.TextBox txt_TCambio_Venta;
        private System.Windows.Forms.TextBox txt_TCambio_Compra;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gb_Tcambio_lista;
        private System.Windows.Forms.DataGridView gv_TCambio_Lista;
        private System.Windows.Forms.TextBox txt_TCambio_Fecha;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Compra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Venta;
    }
}