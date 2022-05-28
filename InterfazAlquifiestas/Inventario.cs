using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Data;

namespace InterfazAlquifiestas
{
    public partial class Inventario : Form
    {
        public Inventario()
        {
            InitializeComponent();
        }

        private void btn_Consultar_Click(object sender, EventArgs e)
        {
            try
            {
                // Funcionalidad de Cargar Clientes
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri("http://localhost:3000/");
                HttpResponseMessage response = client.GetAsync("inventario").Result;
                var data = response.Content.ReadAsStringAsync().Result;


                JObject joResponse = JObject.Parse(data);
                JObject ojObject = (JObject)joResponse;
                dynamic jObj = JsonConvert.DeserializeObject(data);

                DataGridViewCellStyle style = new DataGridViewCellStyle();
                style.ForeColor = Color.Black;
                style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                DataTable inventario = new DataTable();
                inventario.Columns.Add("Descripción");
                inventario.Columns.Add("Disponibles");
                int cont = 0;
                dgv_Inventario.DataSource = inventario;
                foreach (var item in joResponse["inventario"])
                {
                    inventario.Rows.Add(
                        item["Descripción"].ToString(),
                        item["Disponibles"].ToString()
                    );
                    dgv_Inventario.Rows[cont].DefaultCellStyle = style;
                    cont++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
