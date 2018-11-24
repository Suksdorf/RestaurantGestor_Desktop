namespace TPC_Suksdorf
{
    partial class frm_AbrirPedido
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
            this.cmb_Meseros = new System.Windows.Forms.ComboBox();
            this.lbl_Mesero = new System.Windows.Forms.Label();
            this.txt_Clave = new System.Windows.Forms.TextBox();
            this.lbl_Clave = new System.Windows.Forms.Label();
            this.cmb_Mesa = new System.Windows.Forms.ComboBox();
            this.lbl_Mesa = new System.Windows.Forms.Label();
            this.btn_Aceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmb_Meseros
            // 
            this.cmb_Meseros.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Meseros.FormattingEnabled = true;
            this.cmb_Meseros.Location = new System.Drawing.Point(28, 59);
            this.cmb_Meseros.Name = "cmb_Meseros";
            this.cmb_Meseros.Size = new System.Drawing.Size(121, 21);
            this.cmb_Meseros.TabIndex = 0;
            this.cmb_Meseros.SelectedIndexChanged += new System.EventHandler(this.cmb_Meseros_SelectedIndexChanged);
            // 
            // lbl_Mesero
            // 
            this.lbl_Mesero.AutoSize = true;
            this.lbl_Mesero.Location = new System.Drawing.Point(28, 40);
            this.lbl_Mesero.Name = "lbl_Mesero";
            this.lbl_Mesero.Size = new System.Drawing.Size(42, 13);
            this.lbl_Mesero.TabIndex = 1;
            this.lbl_Mesero.Text = "Mesero";
            // 
            // txt_Clave
            // 
            this.txt_Clave.Location = new System.Drawing.Point(193, 59);
            this.txt_Clave.MaxLength = 4;
            this.txt_Clave.Name = "txt_Clave";
            this.txt_Clave.Size = new System.Drawing.Size(100, 20);
            this.txt_Clave.TabIndex = 2;
            // 
            // lbl_Clave
            // 
            this.lbl_Clave.AutoSize = true;
            this.lbl_Clave.Location = new System.Drawing.Point(193, 39);
            this.lbl_Clave.Name = "lbl_Clave";
            this.lbl_Clave.Size = new System.Drawing.Size(34, 13);
            this.lbl_Clave.TabIndex = 3;
            this.lbl_Clave.Text = "Clave";
            // 
            // cmb_Mesa
            // 
            this.cmb_Mesa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Mesa.FormattingEnabled = true;
            this.cmb_Mesa.Location = new System.Drawing.Point(28, 135);
            this.cmb_Mesa.Name = "cmb_Mesa";
            this.cmb_Mesa.Size = new System.Drawing.Size(121, 21);
            this.cmb_Mesa.TabIndex = 4;
            // 
            // lbl_Mesa
            // 
            this.lbl_Mesa.AutoSize = true;
            this.lbl_Mesa.Location = new System.Drawing.Point(31, 116);
            this.lbl_Mesa.Name = "lbl_Mesa";
            this.lbl_Mesa.Size = new System.Drawing.Size(33, 13);
            this.lbl_Mesa.TabIndex = 5;
            this.lbl_Mesa.Text = "Mesa";
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.Location = new System.Drawing.Point(118, 180);
            this.btn_Aceptar.Name = "btn_Aceptar";
            this.btn_Aceptar.Size = new System.Drawing.Size(75, 23);
            this.btn_Aceptar.TabIndex = 6;
            this.btn_Aceptar.Text = " Aceptar";
            this.btn_Aceptar.UseVisualStyleBackColor = true;
            this.btn_Aceptar.Click += new System.EventHandler(this.btn_Aceptar_Click);
            // 
            // frm_AbrirPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 233);
            this.Controls.Add(this.btn_Aceptar);
            this.Controls.Add(this.lbl_Mesa);
            this.Controls.Add(this.cmb_Mesa);
            this.Controls.Add(this.lbl_Clave);
            this.Controls.Add(this.txt_Clave);
            this.Controls.Add(this.lbl_Mesero);
            this.Controls.Add(this.cmb_Meseros);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_AbrirPedido";
            this.Text = "Abrir Pedido";
            this.Load += new System.EventHandler(this.frm_AbrirPedido_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_Meseros;
        private System.Windows.Forms.Label lbl_Mesero;
        private System.Windows.Forms.TextBox txt_Clave;
        private System.Windows.Forms.Label lbl_Clave;
        private System.Windows.Forms.ComboBox cmb_Mesa;
        private System.Windows.Forms.Label lbl_Mesa;
        private System.Windows.Forms.Button btn_Aceptar;
    }
}