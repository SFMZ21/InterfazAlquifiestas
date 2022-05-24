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
    public partial class Pedidos : Form
    {
        public Pedidos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            abrirForm(new AgregarPedido());
        }
        void abrirForm(Form Form)
        {
            while (C_Pedidos.Controls.Count > 0)
            {
                C_Pedidos.Controls.RemoveAt(0);
            }
            Form formHijo = Form;
            Form.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;
            C_Pedidos.Controls.Add(formHijo);
            formHijo.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            abrirForm(new EditarPedido());
        }
    }
}
