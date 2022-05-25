using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Data;

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
            // Funcionalidad de Cargar Clientes
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:3000/");
            HttpResponseMessage response = client.GetAsync("clientes").Result;
            var data = response.Content.ReadAsStringAsync().Result;

            JObject joResponse = JObject.Parse(data);
            JObject ojObject = (JObject)joResponse;
            dynamic jObj = JsonConvert.DeserializeObject(data);

            DataGridViewCellStyle style = new DataGridViewCellStyle();
            style.ForeColor = Color.Black;
            style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            
            DataTable clientes = new DataTable();
            clientes.Columns.Add("IdCliente");
            clientes.Columns.Add("Nombre");
            clientes.Columns.Add("Apellido");
            clientes.Columns.Add("No. de Teléfono");
            clientes.Columns.Add("No. de DPI");
            int cont = 0;
            dgv_Clientes.DataSource = clientes;
            foreach (var item in joResponse["clientes"])
            {
                clientes.Rows.Add(
                    item["IdCliente"].ToString(),
                    item["Nombre"].ToString(),
                    item["Apellido"].ToString(),
                    item["No. de Teléfono"].ToString(),
                    item["No. de DPI"].ToString()
                );
                dgv_Clientes.Rows[cont].DefaultCellStyle = style;
                cont++;
            }

            // Probando DataGrid

            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // Funcionalidad Pendiente

        }
    }
}
