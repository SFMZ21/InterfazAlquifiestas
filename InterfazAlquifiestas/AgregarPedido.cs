using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
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
    public partial class AgregarPedido : Form
    {
        public AgregarPedido()
        {
            InitializeComponent();
        }

        private void Nombre_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            try
            {
                string idcliente = txb_IdCliente.Text;
                string descrip = txb_descripcion.Text;
                string direc = txb_direccion.Text;
                string fecha = txb_fechahora.Text;
                string precio = txb_Precio.Text;
                string estado = txb_Estado.Text;

                var client = (idcliente, descrip, direc, fecha, precio, estado);

                var json = JsonConvert.SerializeObject(client);
                var dat = new StringContent(json, Encoding.UTF8, "application/json");
                HttpClient DataClient = new HttpClient();
                DataClient.BaseAddress = new Uri("http://localhost:3000/");
                HttpResponseMessage response = DataClient.PostAsync("pedidos/nuevo", dat).Result;
                var data = response.Content.ReadAsStringAsync().Result;

                txb_IdCliente.Text = "";
                txb_descripcion.Text = "";
                txb_direccion.Text = "";
                txb_fechahora.Text = "";
                txb_Precio.Text = "";
                txb_Estado.Text = "";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
