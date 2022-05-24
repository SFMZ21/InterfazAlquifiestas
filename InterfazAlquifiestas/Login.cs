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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        string inicio1 = "admin";
        string inicio2 = "#admin123";
        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            
            string user = usuario.Text;
            string pass = contra.Text; 
            if(user == "admin")
            {
                if(pass == "#admin123")
                {
                    Form formulario = new Form1();
                    formulario.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("la contraseña es incorrecta");
                }
            }
            else
            {
                MessageBox.Show("El usuario es incorrecto");
            }
        }

        private void btn_max_login_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btn_max_login.Visible = false;
            btn_restaurar_login.Visible = true;
        }

        private void btn__Click(object sender, EventArgs e)
        {
            
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

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void contra_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
