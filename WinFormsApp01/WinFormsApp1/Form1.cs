namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSaludo_Click(object sender, EventArgs e)
        {
            lblMensaje.Text = "Hola a todos";
        }

        private void btnDespedida_Click(object sender, EventArgs e)
        {
            lblMensaje.Text = "Adios";
            this.Text = "Bye!";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblMensaje.Text = ""; 
        }
    }
}    