namespace TPC_Suksdorf
{
    partial class frm_Asignacion
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
            this.ltb_Meseros = new System.Windows.Forms.ListBox();
            this.ltb_Mesas = new System.Windows.Forms.ListBox();
            this.ltb_Asignadas = new System.Windows.Forms.ListBox();
            this.lbl_Meseros = new System.Windows.Forms.Label();
            this.lbl_Mesas = new System.Windows.Forms.Label();
            this.lbl_Asignadas = new System.Windows.Forms.Label();
            this.btn_Asignar = new System.Windows.Forms.Button();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_Limpiar = new System.Windows.Forms.Button();
            this.btn_Aceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ltb_Meseros
            // 
            this.ltb_Meseros.FormattingEnabled = true;
            this.ltb_Meseros.Location = new System.Drawing.Point(50, 56);
            this.ltb_Meseros.Name = "ltb_Meseros";
            this.ltb_Meseros.Size = new System.Drawing.Size(193, 121);
            this.ltb_Meseros.TabIndex = 0;
            // 
            // ltb_Mesas
            // 
            this.ltb_Mesas.FormattingEnabled = true;
            this.ltb_Mesas.Location = new System.Drawing.Point(361, 56);
            this.ltb_Mesas.Name = "ltb_Mesas";
            this.ltb_Mesas.Size = new System.Drawing.Size(193, 121);
            this.ltb_Mesas.TabIndex = 1;
            // 
            // ltb_Asignadas
            // 
            this.ltb_Asignadas.FormattingEnabled = true;
            this.ltb_Asignadas.Location = new System.Drawing.Point(53, 267);
            this.ltb_Asignadas.Name = "ltb_Asignadas";
            this.ltb_Asignadas.Size = new System.Drawing.Size(193, 82);
            this.ltb_Asignadas.TabIndex = 2;
            // 
            // lbl_Meseros
            // 
            this.lbl_Meseros.AutoSize = true;
            this.lbl_Meseros.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Meseros.Location = new System.Drawing.Point(50, 23);
            this.lbl_Meseros.Name = "lbl_Meseros";
            this.lbl_Meseros.Size = new System.Drawing.Size(62, 17);
            this.lbl_Meseros.TabIndex = 3;
            this.lbl_Meseros.Text = "Meseros";
            // 
            // lbl_Mesas
            // 
            this.lbl_Mesas.AutoSize = true;
            this.lbl_Mesas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Mesas.Location = new System.Drawing.Point(358, 23);
            this.lbl_Mesas.Name = "lbl_Mesas";
            this.lbl_Mesas.Size = new System.Drawing.Size(122, 17);
            this.lbl_Mesas.TabIndex = 4;
            this.lbl_Mesas.Text = "Mesas sin asignar";
            // 
            // lbl_Asignadas
            // 
            this.lbl_Asignadas.AutoSize = true;
            this.lbl_Asignadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Asignadas.Location = new System.Drawing.Point(50, 241);
            this.lbl_Asignadas.Name = "lbl_Asignadas";
            this.lbl_Asignadas.Size = new System.Drawing.Size(134, 17);
            this.lbl_Asignadas.TabIndex = 5;
            this.lbl_Asignadas.Text = "Mesas asignadas a ";
            // 
            // btn_Asignar
            // 
            this.btn_Asignar.Location = new System.Drawing.Point(361, 183);
            this.btn_Asignar.Name = "btn_Asignar";
            this.btn_Asignar.Size = new System.Drawing.Size(75, 23);
            this.btn_Asignar.TabIndex = 6;
            this.btn_Asignar.Text = "Asignar";
            this.btn_Asignar.UseVisualStyleBackColor = true;
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Location = new System.Drawing.Point(251, 284);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(75, 23);
            this.btn_Eliminar.TabIndex = 7;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            // 
            // btn_Limpiar
            // 
            this.btn_Limpiar.Location = new System.Drawing.Point(251, 313);
            this.btn_Limpiar.Name = "btn_Limpiar";
            this.btn_Limpiar.Size = new System.Drawing.Size(75, 23);
            this.btn_Limpiar.TabIndex = 8;
            this.btn_Limpiar.Text = "Limpiar";
            this.btn_Limpiar.UseVisualStyleBackColor = true;
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.Location = new System.Drawing.Point(436, 284);
            this.btn_Aceptar.Name = "btn_Aceptar";
            this.btn_Aceptar.Size = new System.Drawing.Size(75, 40);
            this.btn_Aceptar.TabIndex = 9;
            this.btn_Aceptar.Text = "Aceptar";
            this.btn_Aceptar.UseVisualStyleBackColor = true;
            this.btn_Aceptar.Click += new System.EventHandler(this.btn_Aceptar_Click);
            // 
            // frm_Asignacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 389);
            this.Controls.Add(this.btn_Aceptar);
            this.Controls.Add(this.btn_Limpiar);
            this.Controls.Add(this.btn_Eliminar);
            this.Controls.Add(this.btn_Asignar);
            this.Controls.Add(this.lbl_Asignadas);
            this.Controls.Add(this.lbl_Mesas);
            this.Controls.Add(this.lbl_Meseros);
            this.Controls.Add(this.ltb_Asignadas);
            this.Controls.Add(this.ltb_Mesas);
            this.Controls.Add(this.ltb_Meseros);
            this.Name = "frm_Asignacion";
            this.Text = "Asignación";
            this.Load += new System.EventHandler(this.frm_Asignacion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ltb_Meseros;
        private System.Windows.Forms.ListBox ltb_Mesas;
        private System.Windows.Forms.ListBox ltb_Asignadas;
        private System.Windows.Forms.Label lbl_Meseros;
        private System.Windows.Forms.Label lbl_Mesas;
        private System.Windows.Forms.Label lbl_Asignadas;
        private System.Windows.Forms.Button btn_Asignar;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Button btn_Limpiar;
        private System.Windows.Forms.Button btn_Aceptar;
    }
}