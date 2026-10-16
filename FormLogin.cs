namespace proyecto1
{
    public partial class FormLogin : Form
    {
        private const string ClavePaciente = "paciente";
        private const string UsuarioTopico = "topico";
        private const string ClaveTopico = "123";
        private const string UsuarioDoctor = "doctor";
        private const string ClaveDoctor = "123";
        
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            string usuario = txtusuario.Text.Trim();
            string password = txtpassword.Text;
            string rol = "";
            bool credencialesValidas = false;

            //aqui reconocemos el rol segun el usuario/codigo que escriban, sin combo
            if (usuario == UsuarioTopico && password == ClaveTopico)
            {
                rol = "Topico";
                credencialesValidas = true;
            }
            else if (usuario == UsuarioDoctor && password == ClaveDoctor)
            {
                rol = "Doctor";
                credencialesValidas = true;
            }
            else if (password == ClavePaciente)
            {
                rol = "Paciente";
                credencialesValidas = true;
            }

            if (credencialesValidas)
            {
                FormMenu menu = new FormMenu(rol);
                menu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.",
                    "Error de acceso",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtpassword.Clear();
                txtpassword.Focus();
            }
        }

        private void lblSalir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "¿Está seguro de que desea salir?",
                "Confirmar salida", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void FormLogin_Load(object sender, EventArgs e) { }
    }
}
