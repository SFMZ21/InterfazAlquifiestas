using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Data;

namespace InterfazAlquifiestas
{
    public partial class Mobiliario : Form
    {
        public Mobiliario()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        void abrirForm(Form Form)
        {
            while (panel2.Controls.Count > 0)
            {
                panel2.Controls.RemoveAt(0);
            }
            Form formHijo = Form;
            Form.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;
            panel2.Controls.Add(formHijo);
            formHijo.Show();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Funcionalidad de Cargar Clientes
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri("http://localhost:3000/");
                HttpResponseMessage response = client.GetAsync("mobiliario").Result;
                var data = response.Content.ReadAsStringAsync().Result;

                JObject joResponse = JObject.Parse(data);
                JObject ojObject = joResponse;
                dynamic jObj = JsonConvert.DeserializeObject(data);

                DataGridViewCellStyle style = new DataGridViewCellStyle();
                style.ForeColor = Color.Black;
                style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                
                DataTable mobiliario = new DataTable();
                mobiliario.Columns.Add("IdMobiliario");
                mobiliario.Columns.Add("Estado");
                mobiliario.Columns.Add("IdMueble");
                mobiliario.Columns.Add("IdPedido");
                mobiliario.Columns.Add("CantidadEnUso");

                int cont = 0;
                dgv_Mobiliario.DataSource = mobiliario;
                foreach (var item in joResponse["mobiliario"])
                {
                    mobiliario.Rows.Add(
                        item["IdMobilario"].ToString(),
                        item["Estado"].ToString(),
                        item["IdMueble"].ToString(),
                        item["IdPedido"].ToString(),
                        item["CantidadEnUso"].ToString()
                    );
                    dgv_Mobiliario.Rows[cont].DefaultCellStyle = style;
                    cont++;
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {


            try
            {
                int rowindex = dgv_Mobiliario.CurrentCell.RowIndex;
                int columnindex = dgv_Mobiliario.CurrentCell.ColumnIndex;

                string id = dgv_Mobiliario.Rows[rowindex].Cells[0].Value.ToString();

                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri("http://localhost:3000/");
                HttpResponseMessage response = client.GetAsync("mobiliario/" + id).Result;
                var data = response.Content.ReadAsStringAsync().Result;

                JObject joResponse = JObject.Parse(data);
                abrirForm(new EditarMobiliario(joResponse));
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            try
            {

                var confirmResult = MessageBox.Show("¿Seguro de que quieres eliminar el elemento seleccionado?", "Eliminar Elemento", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    int rowindex = dgv_Mobiliario.CurrentCell.RowIndex;
                    int columnindex = dgv_Mobiliario.CurrentCell.ColumnIndex;

                    string id = dgv_Mobiliario.Rows[rowindex].Cells[0].Value.ToString();

                    HttpClient client = new HttpClient();
                    client.BaseAddress = new Uri("http://localhost:3000/");
                    HttpResponseMessage response = client.DeleteAsync("mobiliario/eliminar/" + id).Result;
                    var data = response.Content.ReadAsStringAsync().Result;


                    JObject joResponse = JObject.Parse(data);

                    this.Hide();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Por favor revisa la seleccion.");
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            abrirForm(new InsertarMobiliario());
        }
    }
}
