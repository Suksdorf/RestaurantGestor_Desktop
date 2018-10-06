namespace TPC_Suksdorf
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pedidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asignarMesasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edicionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verEditarPedidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.meseroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mesaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.meserosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mesasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mesaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.meseroToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.edicionToolStripMenuItem,
            this.verToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.asignarMesasToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pedidoToolStripMenuItem});
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
            // 
            // pedidoToolStripMenuItem
            // 
            this.pedidoToolStripMenuItem.Name = "pedidoToolStripMenuItem";
            this.pedidoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.pedidoToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.pedidoToolStripMenuItem.Text = "&Pedido";
            this.pedidoToolStripMenuItem.Click += new System.EventHandler(this.pedidoToolStripMenuItem_Click);
            // 
            // asignarMesasToolStripMenuItem
            // 
            this.asignarMesasToolStripMenuItem.Name = "asignarMesasToolStripMenuItem";
            this.asignarMesasToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.asignarMesasToolStripMenuItem.Text = "Asignar Mesas";
            this.asignarMesasToolStripMenuItem.Click += new System.EventHandler(this.asignarMesasToolStripMenuItem_Click);
            // 
            // edicionToolStripMenuItem
            // 
            this.edicionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verEditarPedidosToolStripMenuItem,
            this.altaToolStripMenuItem,
            this.modificarToolStripMenuItem});
            this.edicionToolStripMenuItem.Name = "edicionToolStripMenuItem";
            this.edicionToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.edicionToolStripMenuItem.Text = "Edicion";
            // 
            // verEditarPedidosToolStripMenuItem
            // 
            this.verEditarPedidosToolStripMenuItem.Name = "verEditarPedidosToolStripMenuItem";
            this.verEditarPedidosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.verEditarPedidosToolStripMenuItem.Text = "Ver/Editar pedidos";
            this.verEditarPedidosToolStripMenuItem.Click += new System.EventHandler(this.verEditarPedidosToolStripMenuItem_Click);
            // 
            // altaToolStripMenuItem
            // 
            this.altaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.meseroToolStripMenuItem,
            this.mesaToolStripMenuItem,
            this.proveedorToolStripMenuItem});
            this.altaToolStripMenuItem.Name = "altaToolStripMenuItem";
            this.altaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.altaToolStripMenuItem.Text = "Alta";
            // 
            // meseroToolStripMenuItem
            // 
            this.meseroToolStripMenuItem.Name = "meseroToolStripMenuItem";
            this.meseroToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.meseroToolStripMenuItem.Text = "Mesero";
            // 
            // mesaToolStripMenuItem
            // 
            this.mesaToolStripMenuItem.Name = "mesaToolStripMenuItem";
            this.mesaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.mesaToolStripMenuItem.Text = "Mesa";
            // 
            // proveedorToolStripMenuItem
            // 
            this.proveedorToolStripMenuItem.Name = "proveedorToolStripMenuItem";
            this.proveedorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.proveedorToolStripMenuItem.Text = "Proveedor";
            // 
            // verToolStripMenuItem
            // 
            this.verToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.meserosToolStripMenuItem,
            this.mesasToolStripMenuItem,
            this.proveedoresToolStripMenuItem});
            this.verToolStripMenuItem.Name = "verToolStripMenuItem";
            this.verToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.verToolStripMenuItem.Text = "Ver";
            // 
            // meserosToolStripMenuItem
            // 
            this.meserosToolStripMenuItem.Name = "meserosToolStripMenuItem";
            this.meserosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.meserosToolStripMenuItem.Text = "Meseros";
            this.meserosToolStripMenuItem.Click += new System.EventHandler(this.meserosToolStripMenuItem_Click);
            // 
            // mesasToolStripMenuItem
            // 
            this.mesasToolStripMenuItem.Name = "mesasToolStripMenuItem";
            this.mesasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.mesasToolStripMenuItem.Text = "Mesas";
            // 
            // proveedoresToolStripMenuItem
            // 
            this.proveedoresToolStripMenuItem.Name = "proveedoresToolStripMenuItem";
            this.proveedoresToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.proveedoresToolStripMenuItem.Text = "Proveedores";
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mesaToolStripMenuItem1,
            this.meseroToolStripMenuItem1,
            this.proveedorToolStripMenuItem1});
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.modificarToolStripMenuItem.Text = "Modificar";
            // 
            // mesaToolStripMenuItem1
            // 
            this.mesaToolStripMenuItem1.Name = "mesaToolStripMenuItem1";
            this.mesaToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.mesaToolStripMenuItem1.Text = "Mesa";
            // 
            // meseroToolStripMenuItem1
            // 
            this.meseroToolStripMenuItem1.Name = "meseroToolStripMenuItem1";
            this.meseroToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.meseroToolStripMenuItem1.Text = "Mesero";
            // 
            // proveedorToolStripMenuItem1
            // 
            this.proveedorToolStripMenuItem1.Name = "proveedorToolStripMenuItem1";
            this.proveedorToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.proveedorToolStripMenuItem1.Text = "Proveedor";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Restó";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pedidoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asignarMesasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem edicionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verEditarPedidosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem meseroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mesaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proveedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem meserosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mesasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mesaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem meseroToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem proveedorToolStripMenuItem1;
    }
}

