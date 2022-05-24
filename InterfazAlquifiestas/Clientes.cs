using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfazAlquifiestas
{
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            abrirForm(new AgregarCliente());
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            abrirForm(new EditarCliente());
        }

        void abrirForm(Form Form)
        {
            while (C_Clientes.Controls.Count > 0)
            {
                C_Clientes.Controls.RemoveAt(0);
            }
            Form formHijo = Form;
            Form.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;
            C_Clientes.Controls.Add(formHijo);
            formHijo.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
