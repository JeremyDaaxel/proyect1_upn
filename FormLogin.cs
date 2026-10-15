namespace proyecto1
{
    public partial class FormLogin : Form
    {
        private const string userName = "admin";
        private const string passwordTrue = "1234";

        public FormLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            string usuario = txtusuario.Text.Trim();
            string password = txtpassword.Text;

            if (usuario == userName && password == passwordTrue)
            {
                label3.Text = "";
                MostrarMenu();
            }
            else
            {
                label3.Text = "Usuario o contraseña incorrectos.";
                txtpassword.Clear();
                txtpassword.Focus();
            }
        }

        //solo si es correcto el login
        private void MostrarMenu()
        {
            lblusuario.Visible = false;
            txtusuario.Visible = false;
            lblpassword.Visible = false;
            txtpassword.Visible = false;
            btningresar.Visible = false;
            label3.Visible = false;

            lbltitulo.Text = "Menú Principal";
            btncita.Visible = true;
            btntopico.Visible = true;
            btndoctor.Visible = true;
            btnregistrar.Visible = true;
        }

        private void btncita_Click(object sender, EventArgs e)
        {
            FormCitas formcita = new FormCitas();
            formcita.Show();
            this.Hide();
        }

        private void btntopico_Click(object sender, EventArgs e)
        {
            FormTopico formtopico = new FormTopico();
            formtopico.Show();
            this.Hide();
        }

        private void btndoctor_Click(object sender, EventArgs e)
        {
            FormDoctor formdoctor = new FormDoctor();
            formdoctor.Show();
            this.Hide();
        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {
            FormRegistroPaciente formregistrar = new FormRegistroPaciente();
            formregistrar.Show();
            this.Hide();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro de que desea salir?", "Confirmar salida", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
