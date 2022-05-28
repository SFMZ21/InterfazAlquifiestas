namespace InterfazAlquifiestas
{
    partial class Mobiliario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mobiliario));
            this.panel1 = new System.Windows.Forms.Panel();
            this.edit_mobiliario = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgv_Mobiliario = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Mobiliario)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.edit_mobiliario);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(0, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1044, 607);
            this.panel1.TabIndex = 0;
            // 
            // edit_mobiliario
            // 
<<<<<<< HEAD
            this.edit_mobiliario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.edit_mobiliario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.edit_mobiliario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.edit_mobiliario.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.edit_mobiliario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.edit_mobiliario.Image = ((System.Drawing.Image)(resources.GetObject("edit_mobiliario.Image")));
            this.edit_mobiliario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.edit_mobiliario.Location = new System.Drawing.Point(262, 14);
            this.edit_mobiliario.Name = "edit_mobiliario";
            this.edit_mobiliario.Size = new System.Drawing.Size(244, 81);
            this.edit_mobiliario.TabIndex = 10;
            this.edit_mobiliario.Text = "Editar";
            this.edit_mobiliario.UseVisualStyleBackColor = false;
            this.edit_mobiliario.Click += new System.EventHandler(this.button2_Click_1);
=======
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(262, 14);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(244, 81);
            this.button2.TabIndex = 10;
            this.button2.Text = "Editar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
>>>>>>> d6e7121ee10c40971705212897f55dd52819df49
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(512, 14);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(244, 81);
            this.button3.TabIndex = 11;
            this.button3.Text = "   Eliminar ";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(762, 14);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(244, 81);
            this.button4.TabIndex = 12;
            this.button4.Text = "   Mostrar ";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Controls.Add(this.dgv_Mobiliario);
            this.panel2.Location = new System.Drawing.Point(14, 116);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(992, 457);
            this.panel2.TabIndex = 9;
            // 
            // dgv_Mobiliario
            // 
            this.dgv_Mobiliario.AllowUserToAddRows = false;
            this.dgv_Mobiliario.AllowUserToDeleteRows = false;
            this.dgv_Mobiliario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Mobiliario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Mobiliario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Mobiliario.Location = new System.Drawing.Point(0, 0);
            this.dgv_Mobiliario.Name = "dgv_Mobiliario";
            this.dgv_Mobiliario.ReadOnly = true;
            this.dgv_Mobiliario.RowHeadersWidth = 51;
            this.dgv_Mobiliario.RowTemplate.Height = 29;
            this.dgv_Mobiliario.Size = new System.Drawing.Size(992, 457);
            this.dgv_Mobiliario.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(12, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(244, 81);
            this.button1.TabIndex = 8;
            this.button1.Text = "   Registrar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Mobiliario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 603);
            this.Controls.Add(this.panel1);
            this.Name = "Mobiliario";
            this.Text = "Mobiliario";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Mobiliario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button edit_mobiliario;
        private Button button3;
        private Button button4;
        private Panel panel2;
        private Button button1;
        private DataGridView dgv_Mobiliario;
    }
}