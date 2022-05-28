using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Text;

namespace InterfazAlquifiestas
{
    public partial class EditarCliente : Form
    {
        public JObject cliente;
        public Panel Contenedor;
        public EditarCliente(Panel Contenedor, JObject cliente)
        {
            InitializeComponent();
            this.cliente = cliente;
            this.Contenedor = Contenedor;
            txb_Id.Text = cliente["clientes"][0]["IdCliente"].ToString();
            txb_Nombre.Text = cliente["clientes"][0]["Nombre"].ToString();
            txb_Apellido.Text = cliente["clientes"][0]["Apellido"].ToString();
            txb_Tel.Text = cliente["clientes"][0]["No. de Teléfono"].ToString();
            txb_DPI.Text = cliente["clientes"][0]["No. de DPI"].ToString();
        }

        void abrirForm(Form Form)
        {
            while (this.Contenedor.Controls.Count > 0)
            {
                this.Contenedor.Controls.RemoveAt(0);
            }
            Form formHijo = Form;
            Form.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;
            this.Contenedor.Controls.Add(formHijo);
            formHijo.Show();
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            try
            {
                string id = txb_Id.Text;
                string nombre = txb_Nombre.Text;
                string apellido = txb_Apellido.Text;
                string telefono = txb_Tel.Text;
                string dpi = txb_DPI.Text;

                var new_client = (nombre, apellido, telefono, dpi);

                var json = JsonConvert.SerializeObject(new_client);
                var dat = new StringContent(json, Encoding.UTF8, "application/json");
                HttpClient DataClient = new HttpClient();
                DataClient.BaseAddress = new Uri("http://localhost:3000/");
                HttpResponseMessage response = DataClient.PutAsync("clientes/actualizar/" + id, dat).Result;
                var data = response.Content.ReadAsStringAsync().Result;
            } catch (Exception ex)
            {
                MessageBox.Show("Error, no se editó");
            }

            abrirForm(new Clientes(this.Contenedor));

        }
    }
}
