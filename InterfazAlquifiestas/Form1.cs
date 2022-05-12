namespace InterfazAlquifiestas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_max_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btn_max.Visible = false;
            btn_restaurar.Visible = true;
        }

        private void btn_restaurar_Click(object sender, EventArgs e)
        {
            this.WindowState=FormWindowState.Normal;
            btn_restaurar.Visible = false;
            btn_max.Visible=true;
        }

        private void btn_min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            abrirForm(new Pedidos());
        }

        private void Contenedor_Paint(object sender, PaintEventArgs e)
        {

        }
        

        void abrirForm(Form Form)
        {
            while (Contenedor.Controls.Count > 0) 
            {
                Contenedor.Controls.RemoveAt(0);
            }
            Form formHijo = Form;
            Form.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock= DockStyle.Fill;  
            Contenedor.Controls.Add(formHijo);
            formHijo.Show();
        }
        private void MenuVertical_Paint(object sender, PaintEventArgs e)
        {
         

        }

        private void btn_clientes_Click(object sender, EventArgs e)
        {
            abrirForm(new Clientes());

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        
        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_mobiliario_Click(object sender, EventArgs e)
        {
            abrirForm(new Mobiliario());
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_inventario_Click(object sender, EventArgs e)
        {
            abrirForm(new Inventario());
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_estado_Click(object sender, EventArgs e)
        {
            abrirForm(new Estado_de_cuenta());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}