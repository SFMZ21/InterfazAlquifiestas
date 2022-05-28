using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Text;

namespace InterfazAlquifiestas
{
    public partial class EditarMobiliario : Form
    {
        public EditarMobiliario(JObject mobiliario)
        {
            InitializeComponent();
            //MessageBox.Show(mobiliario.ToString());
            //MessageBox.Show(mobiliario["mobiliario"][0]["IdMobilario"].ToString());
            txb_IdMobiliario.Text = mobiliario["mobiliario"][0]["IdMobilario"].ToString();
            txb_estado.Text = mobiliario["mobiliario"][0]["Estado"].ToString();
            txb_idMueble.Text = mobiliario["mobiliario"][0]["IdMueble"].ToString();
            txb_idpedido.Text = mobiliario["mobiliario"][0]["IdPedido"].ToString();
            txb_cantidad.Text = mobiliario["mobiliario"][0]["CantidadEnUso"].ToString();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btn_editar_Click(object sender, EventArgs e)
        {

            try
            {
                var idMob = txb_IdMobiliario.Text;
                var estado = txb_estado.Text;
                var idMue = txb_idMueble.Text;
                var idPe = txb_idpedido.Text;
                var cant = txb_cantidad.Text;

                var new_client = (estado, idMue, idPe, cant);

                var json = JsonConvert.SerializeObject(new_client);
                var dat = new StringContent(json, Encoding.UTF8, "application/json");
                HttpClient DataClient = new HttpClient();
                DataClient.BaseAddress = new Uri("http://localhost:3000/");
                HttpResponseMessage response = DataClient.PutAsync("mobiliario/actualizar/" + idMob, dat).Result;
                var data = response.Content.ReadAsStringAsync().Result;

                txb_IdMobiliario.Text = "";
                txb_estado.Text = "";
                txb_idMueble.Text = "";
                txb_idpedido.Text = "";
                txb_cantidad.Text = "";
                btn_editar.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error, no se editó");
            }



        }
    }
}
