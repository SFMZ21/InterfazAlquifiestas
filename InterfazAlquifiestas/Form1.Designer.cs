namespace InterfazAlquifiestas
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Titulo = new System.Windows.Forms.Panel();
            this.btn_restaurar = new System.Windows.Forms.PictureBox();
            this.btn_min = new System.Windows.Forms.PictureBox();
            this.btn_max = new System.Windows.Forms.PictureBox();
            this.btn_cerrar = new System.Windows.Forms.PictureBox();
            this.MenuVertical = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btn_estado = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_inventario = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_mobiliario = new System.Windows.Forms.Button();
            this.btn_pedidos = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_clientes = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Contenedor = new System.Windows.Forms.Panel();
            this.Titulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_restaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_max)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_cerrar)).BeginInit();
            this.MenuVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Titulo
            // 
            this.Titulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(93)))), ((int)(((byte)(160)))));
            this.Titulo.Controls.Add(this.btn_restaurar);
            this.Titulo.Controls.Add(this.btn_min);
            this.Titulo.Controls.Add(this.btn_max);
            this.Titulo.Controls.Add(this.btn_cerrar);
            this.Titulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.Titulo.Location = new System.Drawing.Point(0, 0);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(1282, 35);
            this.Titulo.TabIndex = 0;
            // 
            // btn_restaurar
            // 
            this.btn_restaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_restaurar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btn_restaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_restaurar.Image = ((System.Drawing.Image)(resources.GetObject("btn_restaurar.Image")));
            this.btn_restaurar.Location = new System.Drawing.Point(1208, 3);
            this.btn_restaurar.Name = "btn_restaurar";
            this.btn_restaurar.Size = new System.Drawing.Size(35, 30);
            this.btn_restaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_restaurar.TabIndex = 3;
            this.btn_restaurar.TabStop = false;
            this.btn_restaurar.Visible = false;
            this.btn_restaurar.Click += new System.EventHandler(this.btn_restaurar_Click);
            // 
            // btn_min
            // 
            this.btn_min.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_min.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btn_min.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_min.Image = ((System.Drawing.Image)(resources.GetObject("btn_min.Image")));
            this.btn_min.Location = new System.Drawing.Point(1167, 3);
            this.btn_min.Name = "btn_min";
            this.btn_min.Size = new System.Drawing.Size(35, 30);
            this.btn_min.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_min.TabIndex = 2;
            this.btn_min.TabStop = false;
            this.btn_min.Click += new System.EventHandler(this.btn_min_Click);
            // 
            // btn_max
            // 
            this.btn_max.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_max.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btn_max.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_max.Image = ((System.Drawing.Image)(resources.GetObject("btn_max.Image")));
            this.btn_max.Location = new System.Drawing.Point(1208, 2);
            this.btn_max.Name = "btn_max";
            this.btn_max.Size = new System.Drawing.Size(35, 30);
            this.btn_max.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_max.TabIndex = 1;
            this.btn_max.TabStop = false;
            this.btn_max.Click += new System.EventHandler(this.btn_max_Click);
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cerrar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btn_cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cerrar.Image = ((System.Drawing.Image)(resources.GetObject("btn_cerrar.Image")));
            this.btn_cerrar.Location = new System.Drawing.Point(1249, 2);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(30, 30);
            this.btn_cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_cerrar.TabIndex = 0;
            this.btn_cerrar.TabStop = false;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // MenuVertical
            // 
            this.MenuVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.MenuVertical.Controls.Add(this.panel5);
            this.MenuVertical.Controls.Add(this.btn_estado);
            this.MenuVertical.Controls.Add(this.panel4);
            this.MenuVertical.Controls.Add(this.panel3);
            this.MenuVertical.Controls.Add(this.btn_inventario);
            this.MenuVertical.Controls.Add(this.panel2);
            this.MenuVertical.Controls.Add(this.btn_mobiliario);
            this.MenuVertical.Controls.Add(this.btn_pedidos);
            this.MenuVertical.Controls.Add(this.panel1);
            this.MenuVertical.Controls.Add(this.btn_clientes);
            this.MenuVertical.Controls.Add(this.pictureBox1);
            this.MenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuVertical.Location = new System.Drawing.Point(0, 35);
            this.MenuVertical.Name = "MenuVertical";
            this.MenuVertical.Size = new System.Drawing.Size(270, 568);
            this.MenuVertical.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel5.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel5.Location = new System.Drawing.Point(0, 470);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(30, 70);
            this.panel5.TabIndex = 5;
            // 
            // btn_estado
            // 
            this.btn_estado.AutoSize = true;
            this.btn_estado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.btn_estado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_estado.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btn_estado.FlatAppearance.BorderSize = 0;
            this.btn_estado.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_estado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_estado.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_estado.ForeColor = System.Drawing.Color.White;
            this.btn_estado.Image = ((System.Drawing.Image)(resources.GetObject("btn_estado.Image")));
            this.btn_estado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_estado.Location = new System.Drawing.Point(30, 470);
            this.btn_estado.Name = "btn_estado";
            this.btn_estado.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_estado.Size = new System.Drawing.Size(240, 70);
            this.btn_estado.TabIndex = 4;
            this.btn_estado.Text = "     Estado de Cuenta";
            this.btn_estado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_estado.UseVisualStyleBackColor = false;
            this.btn_estado.Click += new System.EventHandler(this.btn_estado_Click);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel4.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel4.Location = new System.Drawing.Point(0, 382);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(30, 70);
            this.panel4.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel3.Location = new System.Drawing.Point(0, 295);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(30, 70);
            this.panel3.TabIndex = 3;
            // 
            // btn_inventario
            // 
            this.btn_inventario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.btn_inventario.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btn_inventario.FlatAppearance.BorderSize = 0;
            this.btn_inventario.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_inventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_inventario.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_inventario.ForeColor = System.Drawing.Color.White;
            this.btn_inventario.Image = ((System.Drawing.Image)(resources.GetObject("btn_inventario.Image")));
            this.btn_inventario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_inventario.Location = new System.Drawing.Point(30, 382);
            this.btn_inventario.Name = "btn_inventario";
            this.btn_inventario.Size = new System.Drawing.Size(240, 70);
            this.btn_inventario.TabIndex = 2;
            this.btn_inventario.Text = "  Inventario";
            this.btn_inventario.UseVisualStyleBackColor = false;
            this.btn_inventario.Click += new System.EventHandler(this.btn_inventario_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel2.Location = new System.Drawing.Point(1, 208);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(30, 70);
            this.panel2.TabIndex = 3;
            // 
            // btn_mobiliario
            // 
            this.btn_mobiliario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.btn_mobiliario.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btn_mobiliario.FlatAppearance.BorderSize = 0;
            this.btn_mobiliario.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_mobiliario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_mobiliario.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_mobiliario.ForeColor = System.Drawing.Color.White;
            this.btn_mobiliario.Image = ((System.Drawing.Image)(resources.GetObject("btn_mobiliario.Image")));
            this.btn_mobiliario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_mobiliario.Location = new System.Drawing.Point(30, 295);
            this.btn_mobiliario.Name = "btn_mobiliario";
            this.btn_mobiliario.Size = new System.Drawing.Size(240, 70);
            this.btn_mobiliario.TabIndex = 2;
            this.btn_mobiliario.Text = "  Mobiliario";
            this.btn_mobiliario.UseVisualStyleBackColor = false;
            this.btn_mobiliario.Click += new System.EventHandler(this.btn_mobiliario_Click);
            // 
            // btn_pedidos
            // 
            this.btn_pedidos.AutoSize = true;
            this.btn_pedidos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.btn_pedidos.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btn_pedidos.FlatAppearance.BorderSize = 0;
            this.btn_pedidos.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_pedidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pedidos.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_pedidos.ForeColor = System.Drawing.Color.White;
            this.btn_pedidos.Image = ((System.Drawing.Image)(resources.GetObject("btn_pedidos.Image")));
            this.btn_pedidos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_pedidos.Location = new System.Drawing.Point(30, 208);
            this.btn_pedidos.Name = "btn_pedidos";
            this.btn_pedidos.Size = new System.Drawing.Size(240, 70);
            this.btn_pedidos.TabIndex = 2;
            this.btn_pedidos.Text = "Pedidos";
            this.btn_pedidos.UseVisualStyleBackColor = false;
            this.btn_pedidos.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Location = new System.Drawing.Point(0, 122);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(30, 70);
            this.panel1.TabIndex = 1;
            // 
            // btn_clientes
            // 
            this.btn_clientes.AutoSize = true;
            this.btn_clientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.btn_clientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_clientes.CausesValidation = false;
            this.btn_clientes.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btn_clientes.FlatAppearance.BorderSize = 0;
            this.btn_clientes.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_clientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clientes.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_clientes.ForeColor = System.Drawing.Color.White;
            this.btn_clientes.Image = ((System.Drawing.Image)(resources.GetObject("btn_clientes.Image")));
            this.btn_clientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_clientes.Location = new System.Drawing.Point(30, 122);
            this.btn_clientes.Name = "btn_clientes";
            this.btn_clientes.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_clientes.Size = new System.Drawing.Size(240, 70);
            this.btn_clientes.TabIndex = 0;
            this.btn_clientes.Text = "Clientes";
            this.btn_clientes.UseVisualStyleBackColor = true;
            this.btn_clientes.BackColorChanged += new System.EventHandler(this.btn_clientes_Click);
            this.btn_clientes.BackgroundImageChanged += new System.EventHandler(this.btn_clientes_Click);
            this.btn_clientes.BackgroundImageLayoutChanged += new System.EventHandler(this.btn_clientes_Click);
            this.btn_clientes.ClientSizeChanged += new System.EventHandler(this.btn_clientes_Click);
            this.btn_clientes.Click += new System.EventHandler(this.btn_clientes_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(279, 116);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Contenedor
            // 
            this.Contenedor.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Contenedor.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Contenedor.Location = new System.Drawing.Point(270, 35);
            this.Contenedor.Name = "Contenedor";
            this.Contenedor.Size = new System.Drawing.Size(1012, 568);
            this.Contenedor.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 603);
            this.Controls.Add(this.Contenedor);
            this.Controls.Add(this.MenuVertical);
            this.Controls.Add(this.Titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Titulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_restaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_max)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_cerrar)).EndInit();
            this.MenuVertical.ResumeLayout(false);
            this.MenuVertical.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel Titulo;
        private PictureBox btn_cerrar;
        private Panel MenuVertical;
        public Panel Contenedor;
        private PictureBox btn_min;
        private PictureBox btn_max;
        private PictureBox btn_restaurar;
        private PictureBox pictureBox1;
        private Button btn_estado;
        private Button btn_inventario;
        private Button btn_mobiliario;
        private Button btn_pedidos;
        private Panel panel5;
        private Panel panel4;
        private Panel panel3;
        private Panel panel2;
        private Panel panel1;
        private Button btn_clientes;
    }
}