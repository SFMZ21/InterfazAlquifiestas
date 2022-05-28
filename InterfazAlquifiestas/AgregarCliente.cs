using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Text;

namespace InterfazAlquifiestas
{
    public partial class AgregarCliente : Form
    {
        public Panel Contenedor;
        public AgregarCliente(Panel Contenedor)
        {
            InitializeComponent();
            this.Contenedor = Contenedor;
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

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            string nombre = txb_Nombre.Text;
            string apellido = txb_Apellido.Text;
            string telefono = txb_Telefono.Text;
            string Dpi = txb_DPI.Text;

            var client = (nombre, apellido, telefono, Dpi);

            var json = JsonConvert.SerializeObject(client);
            var dat = new StringContent(json, Encoding.UTF8, "application/json");
            HttpClient DataClient = new HttpClient();
            DataClient.BaseAddress = new Uri("http://localhost:3000/");
            HttpResponseMessage response = DataClient.PostAsync("clientes/nuevo", dat).Result;
            var data = response.Content.ReadAsStringAsync().Result;


            JObject joResponse = JObject.Parse(data);
            JObject ojObject = (JObject)joResponse;
            dynamic jObj = JsonConvert.DeserializeObject(data);


            //record Person(string Name, string Occupation);

            abrirForm(new Clientes(Contenedor));
        }
    }
}
