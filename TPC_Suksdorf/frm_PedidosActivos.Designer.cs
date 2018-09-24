namespace TPC_Suksdorf
{
    partial class frm_PedidosActivos
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
            this.dgv_Pedidos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Pedidos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Pedidos
            // 
            this.dgv_Pedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Pedidos.Location = new System.Drawing.Point(53, 49);
            this.dgv_Pedidos.Name = "dgv_Pedidos";
            this.dgv_Pedidos.ReadOnly = true;
            this.dgv_Pedidos.Size = new System.Drawing.Size(474, 231);
            this.dgv_Pedidos.TabIndex = 0;
            // 
            // frm_PedidosActivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 312);
            this.Controls.Add(this.dgv_Pedidos);
            this.Name = "frm_PedidosActivos";
            this.Text = "Pedidos Activos";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Pedidos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Pedidos;
    }
}