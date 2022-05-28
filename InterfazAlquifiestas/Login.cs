using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace InterfazAlquifiestas
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            string user = usuario.Text;
            string pass = contra.Text;

            try
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri("http://localhost:3000/");
                HttpResponseMessage response = client.GetAsync("administradores").Result;
                var data = response.Content.ReadAsStringAsync().Result;

                // Probando crear el Json
                JObject joResponse = JObject.Parse(data);
                JObject ojObject = (JObject)joResponse;
                //MessageBox.Show(Convert.ToString(ojObject["admins"].Count));
                dynamic jObj = JsonConvert.DeserializeObject(data);
                // Recorriendo Data
                var Us = false;
                var Pas = false;

                foreach (var item in joResponse["admins"])
                {
                    if (user == item["Usuario"].ToString() && pass == item["Password"].ToString())
                    {
                        Us = true;
                        Pas = true;
                    }

                }

                if (Us && Pas)
                {
                    MessageBox.Show("Bienvenido!");
                    Form formulario = new Form1();
                    formulario.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("El nombre de usuario y/o contraseña no coinciden");
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_max_login_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btn_max_login.Visible = false;
            btn_restaurar_login.Visible = true;
        }

        private void btn_min_log_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_cerrar_login_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_restaurar_login_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btn_restaurar_login.Visible = false;
            btn_max_login.Visible = true;
        }
    }
}
