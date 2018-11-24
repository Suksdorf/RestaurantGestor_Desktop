namespace TPC_Suksdorf
{
    partial class frm_Pedido
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
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.lbl_NroPedido = new System.Windows.Forms.Label();
            this.cmb_Insumos = new System.Windows.Forms.ComboBox();
            this.lbl_Insumo = new System.Windows.Forms.Label();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.lbl_Total = new System.Windows.Forms.Label();
            this.lbl_Total2 = new System.Windows.Forms.Label();
            this.lblMesa = new System.Windows.Forms.Label();
            this.lblMesero = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCerrarPedido = new System.Windows.Forms.Button();
            this.dgvInsumos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInsumos)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo.Location = new System.Drawing.Point(31, 43);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(134, 29);
            this.lbl_Titulo.TabIndex = 0;
            this.lbl_Titulo.Text = "Pedido N°:";
            // 
            // lbl_NroPedido
            // 
            this.lbl_NroPedido.AutoSize = true;
            this.lbl_NroPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NroPedido.Location = new System.Drawing.Point(171, 39);
            this.lbl_NroPedido.Name = "lbl_NroPedido";
            this.lbl_NroPedido.Size = new System.Drawing.Size(57, 36);
            this.lbl_NroPedido.TabIndex = 1;
            this.lbl_NroPedido.Text = "XX";
            this.lbl_NroPedido.Click += new System.EventHandler(this.lbl_NroPedido_Click);
            // 
            // cmb_Insumos
            // 
            this.cmb_Insumos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Insumos.FormattingEnabled = true;
            this.cmb_Insumos.Location = new System.Drawing.Point(44, 170);
            this.cmb_Insumos.Name = "cmb_Insumos";
            this.cmb_Insumos.Size = new System.Drawing.Size(184, 21);
            this.cmb_Insumos.TabIndex = 2;
            // 
            // lbl_Insumo
            // 
            this.lbl_Insumo.AutoSize = true;
            this.lbl_Insumo.Location = new System.Drawing.Point(44, 151);
            this.lbl_Insumo.Name = "lbl_Insumo";
            this.lbl_Insumo.Size = new System.Drawing.Size(41, 13);
            this.lbl_Insumo.TabIndex = 3;
            this.lbl_Insumo.Text = "Insumo";
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.Location = new System.Drawing.Point(47, 225);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(75, 23);
            this.btn_Agregar.TabIndex = 4;
            this.btn_Agregar.Text = "Agregar";
            this.btn_Agregar.UseVisualStyleBackColor = true;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // lbl_Total
            // 
            this.lbl_Total.AutoSize = true;
            this.lbl_Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Total.Location = new System.Drawing.Point(316, 382);
            this.lbl_Total.Name = "lbl_Total";
            this.lbl_Total.Size = new System.Drawing.Size(85, 25);
            this.lbl_Total.TabIndex = 6;
            this.lbl_Total.Text = "TOTAL:";
            // 
            // lbl_Total2
            // 
            this.lbl_Total2.AutoSize = true;
            this.lbl_Total2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Total2.Location = new System.Drawing.Point(407, 382);
            this.lbl_Total2.Name = "lbl_Total2";
            this.lbl_Total2.Size = new System.Drawing.Size(53, 25);
            this.lbl_Total2.TabIndex = 7;
            this.lbl_Total2.Text = "$xxx";
            // 
            // lblMesa
            // 
            this.lblMesa.AutoSize = true;
            this.lblMesa.Location = new System.Drawing.Point(12, 9);
            this.lblMesa.Name = "lblMesa";
            this.lblMesa.Size = new System.Drawing.Size(33, 13);
            this.lblMesa.TabIndex = 8;
            this.lblMesa.Text = "Mesa";
            // 
            // lblMesero
            // 
            this.lblMesero.AutoSize = true;
            this.lblMesero.Location = new System.Drawing.Point(106, 9);
            this.lblMesero.Name = "lblMesero";
            this.lblMesero.Size = new System.Drawing.Size(42, 13);
            this.lblMesero.TabIndex = 9;
            this.lblMesero.Text = "Mesero";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(453, 9);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(37, 13);
            this.lblFecha.TabIndex = 10;
            this.lblFecha.Text = "Fecha";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(44, 362);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(104, 44);
            this.btnAceptar.TabIndex = 11;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCerrarPedido
            // 
            this.btnCerrarPedido.Location = new System.Drawing.Point(321, 415);
            this.btnCerrarPedido.Name = "btnCerrarPedido";
            this.btnCerrarPedido.Size = new System.Drawing.Size(214, 23);
            this.btnCerrarPedido.TabIndex = 12;
            this.btnCerrarPedido.Text = "Cerrar Pedido";
            this.btnCerrarPedido.UseVisualStyleBackColor = true;
            this.btnCerrarPedido.Click += new System.EventHandler(this.btnCerrarPedido_Click);
            // 
            // dgvInsumos
            // 
            this.dgvInsumos.AllowUserToAddRows = false;
            this.dgvInsumos.AllowUserToDeleteRows = false;
            this.dgvInsumos.AllowUserToResizeRows = false;
            this.dgvInsumos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvInsumos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInsumos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInsumos.Location = new System.Drawing.Point(234, 43);
            this.dgvInsumos.Name = "dgvInsumos";
            this.dgvInsumos.ReadOnly = true;
            this.dgvInsumos.Size = new System.Drawing.Size(315, 313);
            this.dgvInsumos.TabIndex = 13;
            this.dgvInsumos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInsumos_CellContentClick);
            // 
            // frm_Pedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 450);
            this.Controls.Add(this.dgvInsumos);
            this.Controls.Add(this.btnCerrarPedido);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblMesero);
            this.Controls.Add(this.lblMesa);
            this.Controls.Add(this.lbl_Total2);
            this.Controls.Add(this.lbl_Total);
            this.Controls.Add(this.btn_Agregar);
            this.Controls.Add(this.lbl_Insumo);
            this.Controls.Add(this.cmb_Insumos);
            this.Controls.Add(this.lbl_NroPedido);
            this.Controls.Add(this.lbl_Titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frm_Pedido";
            this.Text = "Pedido";
            this.Load += new System.EventHandler(this.frm_Pedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInsumos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.Label lbl_NroPedido;
        private System.Windows.Forms.ComboBox cmb_Insumos;
        private System.Windows.Forms.Label lbl_Insumo;
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.Label lbl_Total;
        private System.Windows.Forms.Label lbl_Total2;
        private System.Windows.Forms.Label lblMesa;
        private System.Windows.Forms.Label lblMesero;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCerrarPedido;
        private System.Windows.Forms.DataGridView dgvInsumos;
    }
}