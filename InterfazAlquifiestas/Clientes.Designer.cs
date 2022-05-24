namespace InterfazAlquifiestas
{
    partial class Clientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Clientes));
            this.ContenedorClientes = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button4 = new System.Windows.Forms.Button();
            this.C_Clientes = new System.Windows.Forms.Panel();
            this.dgv_Clientes = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.ContenedorClientes.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.C_Clientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Clientes)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ContenedorClientes
            // 
            this.ContenedorClientes.AutoSize = true;
            this.ContenedorClientes.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ContenedorClientes.Controls.Add(this.tableLayoutPanel2);
            this.ContenedorClientes.Controls.Add(this.tableLayoutPanel1);
            this.ContenedorClientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContenedorClientes.Location = new System.Drawing.Point(0, 0);
            this.ContenedorClientes.Name = "ContenedorClientes";
            this.ContenedorClientes.Size = new System.Drawing.Size(1044, 603);
            this.ContenedorClientes.TabIndex = 4;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.Controls.Add(this.button4, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1044, 93);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(316, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(411, 87);
            this.button4.TabIndex = 7;
            this.button4.Text = "Mostrar Clientes";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // C_Clientes
            // 
            this.C_Clientes.AutoSize = true;
            this.C_Clientes.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.C_Clientes.Controls.Add(this.dgv_Clientes);
            this.C_Clientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.C_Clientes.Location = new System.Drawing.Point(107, 3);
            this.C_Clientes.Name = "C_Clientes";
            this.C_Clientes.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.C_Clientes.Size = new System.Drawing.Size(829, 504);
            this.C_Clientes.TabIndex = 1;
            // 
            // dgv_Clientes
            // 
            this.dgv_Clientes.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_Clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Clientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Clientes.Location = new System.Drawing.Point(0, 0);
            this.dgv_Clientes.Name = "dgv_Clientes";
            this.dgv_Clientes.RowHeadersWidth = 51;
            this.dgv_Clientes.RowTemplate.Height = 29;
            this.dgv_Clientes.Size = new System.Drawing.Size(829, 504);
            this.dgv_Clientes.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.Controls.Add(this.C_Clientes, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 93);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1044, 510);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 603);
            this.ControlBox = false;
            this.Controls.Add(this.ContenedorClientes);
            this.Name = "Clientes";
            this.Text = "Clientes";
            this.ContenedorClientes.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.C_Clientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Clientes)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Panel ContenedorClientes;
        private Button button4;
        private Panel C_Clientes;
        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dgv_Clientes;
        private TableLayoutPanel tableLayoutPanel2;
    }
}