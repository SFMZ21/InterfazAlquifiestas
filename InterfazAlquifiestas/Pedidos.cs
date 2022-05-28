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
            try
            {
                int rowindex = dgv_Pedidos.CurrentCell.RowIndex;
                int columnindex = dgv_Pedidos.CurrentCell.ColumnIndex;

                string id = dgv_Pedidos.Rows[rowindex].Cells[0].Value.ToString();

                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri("http://localhost:3000/");
                HttpResponseMessage response = client.GetAsync("pedidos/" + id).Result;
                var data = response.Content.ReadAsStringAsync().Result;
                JObject joResponse = JObject.Parse(data);

                abrirForm(new EditarPedido(joResponse));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la seleccion, selecciona una fila");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Mostrar Pedidos
            try
            {
                // Funcionalidad de Cargar Clientes
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri("http://localhost:3000/");
                HttpResponseMessage response = client.GetAsync("pedidos").Result;
                var data = response.Content.ReadAsStringAsync().Result;


                JObject joResponse = JObject.Parse(data);
                JObject ojObject = (JObject)joResponse;
                dynamic jObj = Newtonsoft.Json.JsonConvert.DeserializeObject(data);

                DataGridViewCellStyle style = new DataGridViewCellStyle();
                style.ForeColor = Color.Black;
                style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                DataTable pedidos = new DataTable();
                pedidos.Columns.Add("IdPedido");
                pedidos.Columns.Add("Descripción");
                pedidos.Columns.Add("Dirección");
                pedidos.Columns.Add("Fecha y Hora");
                pedidos.Columns.Add("Estado");
                pedidos.Columns.Add("IdAdmin");
                pedidos.Columns.Add("IdCliente");
                pedidos.Columns.Add("Precio");

                int cont = 0;
                dgv_Pedidos.DataSource = pedidos;
                foreach (var item in joResponse["pedidos"])
                {
                    pedidos.Rows.Add(
                        item["IdPedido"].ToString(),
                        item["Descripción"].ToString(),
                        item["Dirección"].ToString(),
                        item["FechayHora"].ToString(),
                        item["Estado"].ToString(),
                        item["IdAdmin"].ToString(), 
                        item["IdCliente"].ToString(),
                        item["Precio"].ToString()

                    );
                    dgv_Pedidos.Rows[cont].DefaultCellStyle = style;
                    cont++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int rowindex = dgv_Pedidos.CurrentCell.RowIndex;
                int columnindex = dgv_Pedidos.CurrentCell.ColumnIndex;

                string id = dgv_Pedidos.Rows[rowindex].Cells[0].Value.ToString();

                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri("http://localhost:3000/");
                HttpResponseMessage response = client.GetAsync("pedidos/" + id).Result;
                var data = response.Content.ReadAsStringAsync().Result;

                JObject joResponse = JObject.Parse(data);

                string desc = joResponse["Descripción"].ToString();
                string dirr = joResponse["Dirección"].ToString();
                string fech = joResponse["FechayHora"].ToString();
                string esta = "C";
                string cliente = joResponse["IdCliente"].ToString();
                string prec = joResponse["Precio"].ToString();

                var new_client = (desc, dirr, fech, esta, cliente, prec);

                
                var json = JsonConvert.SerializeObject(new_client);
                var dat = new StringContent(json, Encoding.UTF8, "application/json");
                HttpClient DataClient = new HttpClient();
                DataClient.BaseAddress = new Uri("http://localhost:3000/");
                HttpResponseMessage response2 = DataClient.PutAsync("pedidos/actualizar/" + id, dat).Result;
                var data2 = response2.Content.ReadAsStringAsync().Result;
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cancelar el pedido");
            }
        }
    }
}
