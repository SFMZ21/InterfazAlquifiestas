namespace InterfazAlquifiestas
{
    partial class AgregarPedido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarPedido));
            this.C_Add_Pedidos = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txb_Estado = new System.Windows.Forms.TextBox();
            this.txb_Precio = new System.Windows.Forms.TextBox();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txb_IdCliente = new System.Windows.Forms.TextBox();
            this.txb_fechahora = new System.Windows.Forms.TextBox();
            this.txb_direccion = new System.Windows.Forms.TextBox();
            this.Nombre = new System.Windows.Forms.Label();
            this.txb_descripcion = new System.Windows.Forms.TextBox();
            this.C_Add_Pedidos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // C_Add_Pedidos
            // 
            this.C_Add_Pedidos.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.C_Add_Pedidos.Controls.Add(this.pictureBox1);
            this.C_Add_Pedidos.Controls.Add(this.label4);
            this.C_Add_Pedidos.Controls.Add(this.label3);
            this.C_Add_Pedidos.Controls.Add(this.txb_Estado);
            this.C_Add_Pedidos.Controls.Add(this.txb_Precio);
            this.C_Add_Pedidos.Controls.Add(this.btn_agregar);
            this.C_Add_Pedidos.Controls.Add(this.ID);
            this.C_Add_Pedidos.Controls.Add(this.label2);
            this.C_Add_Pedidos.Controls.Add(this.label1);
            this.C_Add_Pedidos.Controls.Add(this.txb_IdCliente);
            this.C_Add_Pedidos.Controls.Add(this.txb_fechahora);
            this.C_Add_Pedidos.Controls.Add(this.txb_direccion);
            this.C_Add_Pedidos.Controls.Add(this.Nombre);
            this.C_Add_Pedidos.Controls.Add(this.txb_descripcion);
            this.C_Add_Pedidos.Location = new System.Drawing.Point(6, 3);
            this.C_Add_Pedidos.Name = "C_Add_Pedidos";
            this.C_Add_Pedidos.Size = new System.Drawing.Size(992, 492);
            this.C_Add_Pedidos.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(47, 170);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(293, 280);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(435, 295);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 34);
            this.label4.TabIndex = 14;
            this.label4.Text = "Estado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(438, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 34);
            this.label3.TabIndex = 13;
            this.label3.Text = "Precio";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txb_Estado
            // 
            this.txb_Estado.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txb_Estado.Location = new System.Drawing.Point(545, 295);
            this.txb_Estado.Name = "txb_Estado";
            this.txb_Estado.Size = new System.Drawing.Size(340, 41);
            this.txb_Estado.TabIndex = 5;
            // 
            // txb_Precio
            // 
            this.txb_Precio.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txb_Precio.Location = new System.Drawing.Point(545, 233);
            this.txb_Precio.Name = "txb_Precio";
            this.txb_Precio.Size = new System.Drawing.Size(340, 41);
            this.txb_Precio.TabIndex = 4;
            // 
            // btn_agregar
            // 
            this.btn_agregar.AutoSize = true;
            this.btn_agregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(93)))), ((int)(((byte)(160)))));
            this.btn_agregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_agregar.CausesValidation = false;
            this.btn_agregar.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btn_agregar.FlatAppearance.BorderSize = 0;
            this.btn_agregar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_agregar.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_agregar.ForeColor = System.Drawing.Color.White;
            this.btn_agregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_agregar.Location = new System.Drawing.Point(600, 372);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_agregar.Size = new System.Drawing.Size(226, 60);
            this.btn_agregar.TabIndex = 6;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = false;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ID.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ID.Location = new System.Drawing.Point(109, 81);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(148, 34);
            this.ID.TabIndex = 9;
            this.ID.Text = "ID Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(346, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 34);
            this.label2.TabIndex = 8;
            this.label2.Text = "Fecha y hora";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(395, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 34);
            this.label1.TabIndex = 7;
            this.label1.Text = "Dirección";
            // 
            // txb_IdCliente
            // 
            this.txb_IdCliente.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txb_IdCliente.Location = new System.Drawing.Point(57, 118);
            this.txb_IdCliente.Name = "txb_IdCliente";
            this.txb_IdCliente.Size = new System.Drawing.Size(256, 41);
            this.txb_IdCliente.TabIndex = 0;
            // 
            // txb_fechahora
            // 
            this.txb_fechahora.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txb_fechahora.Location = new System.Drawing.Point(545, 170);
            this.txb_fechahora.Name = "txb_fechahora";
            this.txb_fechahora.Size = new System.Drawing.Size(340, 41);
            this.txb_fechahora.TabIndex = 3;
            // 
            // txb_direccion
            // 
            this.txb_direccion.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txb_direccion.Location = new System.Drawing.Point(545, 107);
            this.txb_direccion.Name = "txb_direccion";
            this.txb_direccion.Size = new System.Drawing.Size(340, 41);
            this.txb_direccion.TabIndex = 2;
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Nombre.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Nombre.Location = new System.Drawing.Point(362, 53);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(177, 34);
            this.Nombre.TabIndex = 1;
            this.Nombre.Text = "Descripción";
            this.Nombre.Click += new System.EventHandler(this.Nombre_Click);
            // 
            // txb_descripcion
            // 
            this.txb_descripcion.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txb_descripcion.Location = new System.Drawing.Point(545, 46);
            this.txb_descripcion.Name = "txb_descripcion";
            this.txb_descripcion.Size = new System.Drawing.Size(340, 41);
            this.txb_descripcion.TabIndex = 1;
            // 
            // AgregarPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 499);
            this.Controls.Add(this.C_Add_Pedidos);
            this.Name = "AgregarPedido";
            this.Text = "AgregarPedido";
            this.C_Add_Pedidos.ResumeLayout(false);
            this.C_Add_Pedidos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel C_Add_Pedidos;
        private Button btn_agregar;
        private Label ID;
        private Label label2;
        private Label label1;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private Label Nombre;
        private TextBox textBox1;
        private Label label3;
        private TextBox textBox6;
        private TextBox textBox5;
        private PictureBox pictureBox1;
        private Label label4;
        private TextBox txb_Estado;
        private TextBox txb_Precio;
        private TextBox txb_IdCliente;
        private TextBox txb_fechahora;
        private TextBox txb_direccion;
        private TextBox txb_descripcion;
    }
}