namespace TPC_Suksdorf
{
    partial class frm_Meseros
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
            this.dgvMeseros = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMeseros)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMeseros
            // 
            this.dgvMeseros.AllowUserToAddRows = false;
            this.dgvMeseros.AllowUserToDeleteRows = false;
            this.dgvMeseros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvMeseros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMeseros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMeseros.Location = new System.Drawing.Point(0, 0);
            this.dgvMeseros.Name = "dgvMeseros";
            this.dgvMeseros.ReadOnly = true;
            this.dgvMeseros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMeseros.Size = new System.Drawing.Size(534, 281);
            this.dgvMeseros.TabIndex = 0;
            // 
            // frm_Meseros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 281);
            this.Controls.Add(this.dgvMeseros);
            this.Name = "frm_Meseros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Meseros";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_Meseros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMeseros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMeseros;
    }
}