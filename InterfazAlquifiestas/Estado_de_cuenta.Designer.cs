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
            this.btn_generar_estado = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.btn_generar_estado);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1044, 603);
            this.panel1.TabIndex = 2;
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
            this.btn_generar_estado.Location = new System.Drawing.Point(315, 462);
            this.btn_generar_estado.Name = "btn_generar_estado";
            this.btn_generar_estado.Size = new System.Drawing.Size(451, 81);
            this.btn_generar_estado.TabIndex = 12;
            this.btn_generar_estado.Text = "Generar Estado de Cuenta";
            this.btn_generar_estado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_generar_estado.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(30, 14);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(992, 442);
            this.panel2.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(453, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tabla Mobiliario";
            // 
            // Estado_de_cuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 603);
            this.Controls.Add(this.panel1);
            this.Name = "Estado_de_cuenta";
            this.Text = "Estado_de_cuenta";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button btn_generar_estado;
        private Panel panel2;
        private Label label1;
    }
}