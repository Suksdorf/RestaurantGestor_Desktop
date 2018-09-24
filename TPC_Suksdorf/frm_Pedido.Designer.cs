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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lbl_Total = new System.Windows.Forms.Label();
            this.lbl_Total2 = new System.Windows.Forms.Label();
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
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(316, 43);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(219, 303);
            this.listBox1.TabIndex = 5;
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
            // frm_Pedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 450);
            this.Controls.Add(this.lbl_Total2);
            this.Controls.Add(this.lbl_Total);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btn_Agregar);
            this.Controls.Add(this.lbl_Insumo);
            this.Controls.Add(this.cmb_Insumos);
            this.Controls.Add(this.lbl_NroPedido);
            this.Controls.Add(this.lbl_Titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frm_Pedido";
            this.Text = "Pedido";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.Label lbl_NroPedido;
        private System.Windows.Forms.ComboBox cmb_Insumos;
        private System.Windows.Forms.Label lbl_Insumo;
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lbl_Total;
        private System.Windows.Forms.Label lbl_Total2;
    }
}