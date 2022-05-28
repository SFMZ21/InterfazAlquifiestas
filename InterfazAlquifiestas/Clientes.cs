using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Data;

namespace InterfazAlquifiestas
{
    public partial class Clientes : Form
    {
        public Panel Contenedor;
        public DataTable g_clientes;
        public Clientes(Panel Contenedor)
        {
            InitializeComponent();
            this.Contenedor = Contenedor;
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            abrirForm(new AgregarCliente(Contenedor));
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                int rowindex = dgv_Clientes.CurrentCell.RowIndex;
                int columnindex = dgv_Clientes.CurrentCell.ColumnIndex;

                string id = dgv_Clientes.Rows[rowindex].Cells[0].Value.ToString();

                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri("http://localhost:3000/");
                HttpResponseMessage response = client.GetAsync("clientes/" + id).Result;
                var data = response.Content.ReadAsStringAsync().Result;


                JObject joResponse = JObject.Parse(data);
                //MessageBox.Show(joResponse["clientes"][0].ToString());


                abrirForm(new EditarCliente(this.Contenedor, joResponse));

            }
            catch (Exception ex)
            {
                MessageBox.Show("Debes de seleccionar alguna fila luego de cargar los datos.");
            }

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

        void abrirFormPrincipal(Form Form)
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

        private void button4_Click(object sender, EventArgs e)
        {

            try
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
                        this.g_clientes = clientes;
                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            abrirForm(new AgregarCliente(Contenedor));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int rowindex = dgv_Clientes.CurrentCell.RowIndex;
                int columnindex = dgv_Clientes.CurrentCell.ColumnIndex;

                string id = dgv_Clientes.Rows[rowindex].Cells[0].Value.ToString();

                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri("http://localhost:3000/");
                HttpResponseMessage response = client.GetAsync("clientes/" + id).Result;
                var data = response.Content.ReadAsStringAsync().Result;


                JObject joResponse = JObject.Parse(data);
                //MessageBox.Show(joResponse["clientes"][0].ToString());


                abrirForm(new EditarCliente(this.Contenedor, joResponse));

            }
            catch (Exception ex)
            {
                MessageBox.Show("Debes de seleccionar alguna fila luego de cargar los datos.");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {

                var confirmResult = MessageBox.Show("¿Seguro de que quieres eliminar el elemento seleccionado?", "Eliminar Elemento", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    int rowindex = dgv_Clientes.CurrentCell.RowIndex;
                    int columnindex = dgv_Clientes.CurrentCell.ColumnIndex;

                    string id = dgv_Clientes.Rows[rowindex].Cells[0].Value.ToString();

                    HttpClient client = new HttpClient();
                    client.BaseAddress = new Uri("http://localhost:3000/");
                    HttpResponseMessage response = client.DeleteAsync("clientes/eliminar/" + id).Result;
                    var data = response.Content.ReadAsStringAsync().Result;


                    JObject joResponse = JObject.Parse(data);

                    abrirFormPrincipal(new Clientes(this.Contenedor));
                }

            } catch (Exception ex)
            {
                MessageBox.Show("Por favor revisa la seleccion.");
            }
        }
    }
}
