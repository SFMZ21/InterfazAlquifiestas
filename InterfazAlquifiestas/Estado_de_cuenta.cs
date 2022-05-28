using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Data;
using System.Text;

namespace InterfazAlquifiestas
{
    public partial class Estado_de_cuenta : Form
    {
        public Estado_de_cuenta()
        {
            InitializeComponent();
        }

        private void btn_generar_estado_Click(object sender, EventArgs e)
        {
            try
            {
                var inicio = txb_Inicio.Text;
                var fin = txb_Fin.Text;

                var new_client = (inicio, fin);

                var json = JsonConvert.SerializeObject(new_client);
                var dat = new StringContent(json, Encoding.UTF8, "application/json");
                HttpClient DataClient = new HttpClient();
                DataClient.BaseAddress = new Uri("http://localhost:3000/");
                HttpResponseMessage response = DataClient.PostAsync("estadocuenta", dat).Result;
                var data = response.Content.ReadAsStringAsync().Result;

                JObject joResponse = JObject.Parse(data);
                

                DataGridViewCellStyle style = new DataGridViewCellStyle();
                style.ForeColor = Color.Black;
                style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                DataTable inventario = new DataTable();
                inventario.Columns.Add("Pedido");
                inventario.Columns.Add("Evento");
                inventario.Columns.Add("Periodo");
                inventario.Columns.Add("Monto");
                inventario.Columns.Add("Saldo");
                inventario.Columns.Add("Tipo Movimiento");
                int cont = 0;
                dgv_Inventario.DataSource = inventario;
                foreach (var item in joResponse["estadocuenta"])
                {
                    inventario.Rows.Add(
                        item["PEDIDO"].ToString(),
                        item["EVENTO"].ToString(),
                        item["PERIODO"].ToString(),
                        item["MONTO"].ToString(),
                        item["SALDO"].ToString(),
                        item["TIPO MOVIMIENTO"].ToString()
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

        private void ID_Click(object sender, EventArgs e)
        {

        }
    }
    }
