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

            //funcion: le mando usuario y contraseña, me retorna el rol (o "" si no es valido)
            string rol = DetectarRol(usuario, password);

            if (rol != "")
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

        //funcion: recibe usuario y password, retorna el nombre del rol segun las credenciales
        private string DetectarRol(string usuario, string password)
        {
            if (usuario == UsuarioTopico && password == ClaveTopico)
            {
                return "Topico";
            }
            else if (usuario == UsuarioDoctor && password == ClaveDoctor)
            {
                return "Doctor";
            }
            else if (password == ClavePaciente)
            {
                return "Paciente";
            }
            else
            {
                return "";
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
