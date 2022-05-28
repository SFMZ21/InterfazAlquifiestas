namespace InterfazAlquifiestas
{
    partial class Estado_de_cuenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Estado_de_cuenta));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.Label();
            this.txb_Fin = new System.Windows.Forms.TextBox();
            this.txb_Inicio = new System.Windows.Forms.TextBox();
            this.btn_generar_estado = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgv_Inventario = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Inventario)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.ID);
            this.panel1.Controls.Add(this.txb_Fin);
            this.panel1.Controls.Add(this.txb_Inicio);
            this.panel1.Controls.Add(this.btn_generar_estado);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1044, 603);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(84, 528);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 34);
            this.label1.TabIndex = 16;
            this.label1.Text = "Fin";
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ID.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ID.Location = new System.Drawing.Point(56, 484);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(90, 34);
            this.ID.TabIndex = 15;
            this.ID.Text = "Inicio";
            // 
            // txb_Fin
            // 
            this.txb_Fin.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txb_Fin.Location = new System.Drawing.Point(180, 528);
            this.txb_Fin.Name = "txb_Fin";
            this.txb_Fin.Size = new System.Drawing.Size(298, 38);
            this.txb_Fin.TabIndex = 14;
            // 
            // txb_Inicio
            // 
            this.txb_Inicio.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txb_Inicio.Location = new System.Drawing.Point(180, 484);
            this.txb_Inicio.Name = "txb_Inicio";
            this.txb_Inicio.Size = new System.Drawing.Size(298, 38);
            this.txb_Inicio.TabIndex = 13;
            // 
            // btn_generar_estado
            // 
            this.btn_generar_estado.AutoSize = true;
            this.btn_generar_estado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.btn_generar_estado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_generar_estado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_generar_estado.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_generar_estado.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_generar_estado.Image = ((System.Drawing.Image)(resources.GetObject("btn_generar_estado.Image")));
            this.btn_generar_estado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_generar_estado.Location = new System.Drawing.Point(528, 484);
            this.btn_generar_estado.Name = "btn_generar_estado";
            this.btn_generar_estado.Size = new System.Drawing.Size(451, 81);
            this.btn_generar_estado.TabIndex = 12;
            this.btn_generar_estado.Text = "Generar Estado de Cuenta";
            this.btn_generar_estado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_generar_estado.UseVisualStyleBackColor = false;
            this.btn_generar_estado.Click += new System.EventHandler(this.btn_generar_estado_Click);
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Controls.Add(this.dgv_Inventario);
            this.panel2.Location = new System.Drawing.Point(30, 14);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(992, 442);
            this.panel2.TabIndex = 9;
            // 
            // dgv_Inventario
            // 
            this.dgv_Inventario.AllowUserToAddRows = false;
            this.dgv_Inventario.AllowUserToDeleteRows = false;
            this.dgv_Inventario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Inventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Inventario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Inventario.Location = new System.Drawing.Point(0, 0);
            this.dgv_Inventario.Name = "dgv_Inventario";
            this.dgv_Inventario.ReadOnly = true;
            this.dgv_Inventario.RowHeadersWidth = 51;
            this.dgv_Inventario.RowTemplate.Height = 29;
            this.dgv_Inventario.Size = new System.Drawing.Size(992, 442);
            this.dgv_Inventario.TabIndex = 0;
            // 
            // Estado_de_cuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 603);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Estado_de_cuenta";
            this.Text = "Estado_de_cuenta";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Inventario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button btn_generar_estado;
        private Panel panel2;
        private TextBox txb_Fin;
        private TextBox txb_Inicio;
        private DataGridView dgv_Inventario;
        private Label ID;
        private Label label1;
    }
}