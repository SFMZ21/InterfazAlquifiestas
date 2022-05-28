using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Text;

namespace InterfazAlquifiestas
{
    public partial class EditarPedido : Form
    {
        public EditarPedido(JObject pedido)
        {
            InitializeComponent();
            txb_IdPedido.Text = pedido["IdPedido"].ToString();
            txb_cliente.Text = pedido["IdCliente"].ToString();
            txb_desc.Text = pedido["Descripción"].ToString();
            txb_direc.Text = pedido["Dirección"].ToString();
            txb_fecha.Text = pedido["FechayHora"].ToString().Replace(" 00:00:00", "");
            txb_estado.Text = pedido["Estado"].ToString();
            txb_precio.Text = pedido["Precio"].ToString();

        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            try
            {
                string id = txb_IdPedido.Text;
                string cliente = txb_cliente.Text;
                string desc = txb_desc.Text;
                string dirr = txb_direc.Text;
                string fech = txb_fecha.Text;
                string prec = txb_precio.Text;
                string esta = txb_estado.Text;

                var new_client = (desc, dirr, fech, esta, cliente, prec);

                var json = JsonConvert.SerializeObject(new_client);
                var dat = new StringContent(json, Encoding.UTF8, "application/json");
                HttpClient DataClient = new HttpClient();
                DataClient.BaseAddress = new Uri("http://localhost:3000/");
                HttpResponseMessage response = DataClient.PutAsync("pedidos/actualizar/" + id, dat).Result;
                var data = response.Content.ReadAsStringAsync().Result;

                txb_IdPedido.Text = "";
                txb_cliente.Text = "";
                txb_desc.Text = "";
                txb_direc.Text = "";
                txb_fecha.Text = "";
                txb_precio.Text = "";
                txb_estado.Text = "";
                btn_editar.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error, no se editó");
            }
        }
    }
}
