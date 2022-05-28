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
    public partial class InsertarMobiliario : Form
    {
        public InsertarMobiliario()
        {
            InitializeComponent();
        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {
            try
            {
                
                string estado = txb_estado.Text;
                string idMueb = txb_idMueble.Text;
                string idPedi = txb_idpedido.Text;
                string canti =  txb_cantidad.Text;

                var client = (estado, idMueb, idPedi, canti);

                var json = JsonConvert.SerializeObject(client);
                var dat = new StringContent(json, Encoding.UTF8, "application/json");
                HttpClient DataClient = new HttpClient();
                DataClient.BaseAddress = new Uri("http://localhost:3000/");
                HttpResponseMessage response = DataClient.PostAsync("mobiliario/nuevo", dat).Result;
                var data = response.Content.ReadAsStringAsync().Result;

                txb_estado.Text = "";
                txb_idMueble.Text = "";
                txb_idpedido.Text = "";
                txb_cantidad.Text = "";
                this.Hide();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
