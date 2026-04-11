namespace Practica_Final
{
    partial class Menu_Almacen
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu_Almacen));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnExportar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.FrmAsistenteGlamy = new System.Windows.Forms.Button();
            this.panelSubMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelSubMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "icon-icons (4).png");
            this.imageList1.Images.SetKeyName(1, "icon-icons (4).png");
            this.imageList1.Images.SetKeyName(2, "barra-de-menus (2).png");
            this.imageList1.Images.SetKeyName(3, "barra-de-menus (2).png");
            this.imageList1.Images.SetKeyName(4, "portapapeles.png");
            this.imageList1.Images.SetKeyName(5, "portapapeles.png");
            this.imageList1.Images.SetKeyName(6, "agregar-producto.png");
            this.imageList1.Images.SetKeyName(7, "editar.png");
            this.imageList1.Images.SetKeyName(8, "carpeta.png");
            this.imageList1.Images.SetKeyName(9, "exportar.png");
            this.imageList1.Images.SetKeyName(10, "cerrar-sesion.png");
            this.imageList1.Images.SetKeyName(11, "robot.png");
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.GhostWhite;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenu.ImageIndex = 3;
            this.btnMenu.ImageList = this.imageList1;
            this.btnMenu.Location = new System.Drawing.Point(0, 0);
            this.btnMenu.Margin = new System.Windows.Forms.Padding(0);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(196, 60);
            this.btnMenu.TabIndex = 0;
            this.btnMenu.Text = " Menu";
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.BackColor = System.Drawing.Color.Thistle;
            this.btnMostrar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnMostrar.FlatAppearance.BorderSize = 0;
            this.btnMostrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnMostrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orchid;
            this.btnMostrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrar.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Italic);
            this.btnMostrar.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnMostrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMostrar.ImageIndex = 5;
            this.btnMostrar.ImageList = this.imageList1;
            this.btnMostrar.Location = new System.Drawing.Point(0, 65);
            this.btnMostrar.Margin = new System.Windows.Forms.Padding(0);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(194, 60);
            this.btnMostrar.TabIndex = 3;
            this.btnMostrar.Text = "      Mostrar";
            this.btnMostrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMostrar.UseVisualStyleBackColor = false;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click_1);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Thistle;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orchid;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Italic);
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.ImageIndex = 6;
            this.btnAgregar.ImageList = this.imageList1;
            this.btnAgregar.Location = new System.Drawing.Point(0, 130);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(0);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(194, 58);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click_2);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.Thistle;
            this.btnActualizar.FlatAppearance.BorderSize = 0;
            this.btnActualizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnActualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orchid;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Italic);
            this.btnActualizar.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActualizar.ImageIndex = 7;
            this.btnActualizar.ImageList = this.imageList1;
            this.btnActualizar.Location = new System.Drawing.Point(0, 195);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(0);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(194, 57);
            this.btnActualizar.TabIndex = 2;
            this.btnActualizar.Text = "     Actualizar/Eliminar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click_1);
            // 
            // btnExportar
            // 
            this.btnExportar.BackColor = System.Drawing.Color.Thistle;
            this.btnExportar.FlatAppearance.BorderSize = 0;
            this.btnExportar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnExportar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orchid;
            this.btnExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportar.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Italic);
            this.btnExportar.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnExportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExportar.ImageIndex = 9;
            this.btnExportar.ImageList = this.imageList1;
            this.btnExportar.Location = new System.Drawing.Point(0, 260);
            this.btnExportar.Margin = new System.Windows.Forms.Padding(0);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(194, 57);
            this.btnExportar.TabIndex = 5;
            this.btnExportar.Text = "Exportar";
            this.btnExportar.UseVisualStyleBackColor = false;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Thistle;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orchid;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Italic);
            this.btnSalir.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.ImageIndex = 10;
            this.btnSalir.ImageList = this.imageList1;
            this.btnSalir.Location = new System.Drawing.Point(0, 393);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(0);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(194, 61);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.btnExportar, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnActualizar, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnAgregar, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnMostrar, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnMenu, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnSalir, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.FrmAsistenteGlamy, 0, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(198, 923);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // FrmAsistenteGlamy
            // 
            this.FrmAsistenteGlamy.BackColor = System.Drawing.Color.Thistle;
            this.FrmAsistenteGlamy.FlatAppearance.BorderSize = 0;
            this.FrmAsistenteGlamy.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.FrmAsistenteGlamy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orchid;
            this.FrmAsistenteGlamy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FrmAsistenteGlamy.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Italic);
            this.FrmAsistenteGlamy.ForeColor = System.Drawing.SystemColors.MenuText;
            this.FrmAsistenteGlamy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.FrmAsistenteGlamy.ImageIndex = 11;
            this.FrmAsistenteGlamy.ImageList = this.imageList1;
            this.FrmAsistenteGlamy.Location = new System.Drawing.Point(0, 325);
            this.FrmAsistenteGlamy.Margin = new System.Windows.Forms.Padding(0);
            this.FrmAsistenteGlamy.Name = "FrmAsistenteGlamy";
            this.FrmAsistenteGlamy.Size = new System.Drawing.Size(194, 57);
            this.FrmAsistenteGlamy.TabIndex = 7;
            this.FrmAsistenteGlamy.Text = "Asistente Glamy";
            this.FrmAsistenteGlamy.UseVisualStyleBackColor = false;
            this.FrmAsistenteGlamy.Click += new System.EventHandler(this.FrmAsistenteGlamy_Click);
            // 
            // panelSubMenu
            // 
            this.panelSubMenu.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panelSubMenu.Controls.Add(this.linkLabel1);
            this.panelSubMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSubMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSubMenu.Name = "panelSubMenu";
            this.panelSubMenu.Size = new System.Drawing.Size(1668, 923);
            this.panelSubMenu.TabIndex = 1;
            // 
            // linkLabel1
            // 
            this.linkLabel1.Location = new System.Drawing.Point(3, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(80, 20);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "linkLabel1";
            // 
            // Menu_Almacen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1668, 923);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panelSubMenu);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.Name = "Menu_Almacen";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Menu_Almacen_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panelSubMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel panelSubMenu;
        private System.Windows.Forms.Button FrmAsistenteGlamy;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}