namespace InterfazAlquifiestas
{
    partial class Pedidos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pedidos));
            this.panel1 = new System.Windows.Forms.Panel();
            this.ContenedorClientes = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.C_Pedidos = new System.Windows.Forms.Panel();
            this.dgv_Pedidos = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.ContenedorClientes.SuspendLayout();
            this.C_Pedidos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Pedidos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ContenedorClientes);
            this.panel1.Location = new System.Drawing.Point(-3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1051, 605);
            this.panel1.TabIndex = 0;
            // 
            // ContenedorClientes
            // 
            this.ContenedorClientes.AutoSize = true;
            this.ContenedorClientes.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ContenedorClientes.Controls.Add(this.button2);
            this.ContenedorClientes.Controls.Add(this.button3);
            this.ContenedorClientes.Controls.Add(this.button4);
            this.ContenedorClientes.Controls.Add(this.C_Pedidos);
            this.ContenedorClientes.Controls.Add(this.button1);
            this.ContenedorClientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContenedorClientes.Location = new System.Drawing.Point(0, 0);
            this.ContenedorClientes.Name = "ContenedorClientes";
            this.ContenedorClientes.Size = new System.Drawing.Size(1051, 605);
            this.ContenedorClientes.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(260, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(244, 81);
            this.button2.TabIndex = 5;
            this.button2.Text = "Editar Pedido";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(510, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(244, 81);
            this.button3.TabIndex = 6;
            this.button3.Text = "Cancelar Pedido";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(760, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(244, 81);
            this.button4.TabIndex = 7;
            this.button4.Text = "Mostrar Pedidos";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // C_Pedidos
            // 
            this.C_Pedidos.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.C_Pedidos.Controls.Add(this.dgv_Pedidos);
            this.C_Pedidos.Location = new System.Drawing.Point(10, 109);
            this.C_Pedidos.Name = "C_Pedidos";
            this.C_Pedidos.Size = new System.Drawing.Size(994, 457);
            this.C_Pedidos.TabIndex = 1;
            // 
            // dgv_Pedidos
            // 
            this.dgv_Pedidos.AllowUserToAddRows = false;
            this.dgv_Pedidos.AllowUserToDeleteRows = false;
<<<<<<< HEAD
            this.dgv_Pedidos.BackgroundColor = System.Drawing.SystemColors.Control;
=======
>>>>>>> d6e7121ee10c40971705212897f55dd52819df49
            this.dgv_Pedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Pedidos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Pedidos.Location = new System.Drawing.Point(0, 0);
            this.dgv_Pedidos.Name = "dgv_Pedidos";
            this.dgv_Pedidos.ReadOnly = true;
            this.dgv_Pedidos.RowHeadersWidth = 51;
            this.dgv_Pedidos.RowTemplate.Height = 29;
            this.dgv_Pedidos.Size = new System.Drawing.Size(994, 457);
            this.dgv_Pedidos.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(10, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(244, 81);
            this.button1.TabIndex = 0;
            this.button1.Text = "Crear Pedido";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Pedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 603);
            this.Controls.Add(this.panel1);
            this.Name = "Pedidos";
            this.Text = "Pedidos";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ContenedorClientes.ResumeLayout(false);
            this.C_Pedidos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Pedidos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel ContenedorClientes;
        private Button button2;
        private Button button3;
        private Button button4;
        private Panel C_Pedidos;
        private Button button1;
        private DataGridView dgv_Pedidos;
    }
}