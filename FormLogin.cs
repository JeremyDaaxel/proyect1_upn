using System;
using System.Windows.Forms;

namespace proyecto1
{
    public partial class FormLogin : Form
    {
        private const string UsuarioTopico = "topico";
        private const string ClaveTopico = "123";
        private const string UsuarioDoctor = "doctor";
        private const string ClaveDoctor = "123";
        private const string ClavePaciente = "paciente";
        
        public FormLogin()
        {
            InitializeComponent();
            this.AcceptButton = btningresar;
            txtusuario.KeyDown += Txtusuario_KeyDown;
            txtpassword.KeyDown += Txtpassword_KeyDown;
        }

        private void Txtusuario_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Evita el sonido de alerta al presionar Enter
                if (string.IsNullOrWhiteSpace(txtpassword.Text))
                {
                    txtpassword.Focus();
                }
                else
                {
                    btningresar.PerformClick();
                }
            }
        }

        private void Txtpassword_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Evita el sonido de alerta al presionar Enter
                btningresar.PerformClick();
            }
        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            string usuario = txtusuario.Text.Trim();
            string password = txtpassword.Text.Trim();

            // Detectamos el rol según las credenciales ingresadas
            string rol = DetectarRol(usuario, password);

            if (rol == "Doctor")
            {
                FormDoctor formDoctor = new FormDoctor();
                formDoctor.Show();
                this.Hide();
            }
            else if (rol == "Topico")
            {
                FormTopico formTopico = new FormTopico();
                formTopico.Show();
                this.Hide();
            }
            else if (rol == "Paciente")
            {
                FormCitas formCitas = new FormCitas();
                formCitas.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show(
                    "Usuario o contraseña incorrectos.\n\nCredenciales disponibles:\n" +
                    "- Doctor: usuario 'doctor', contraseña '123'\n" +
                    "- Tópico: usuario 'topico', contraseña '123'\n" +
                    "- Paciente: usuario 'paciente' (o DNI registrado), contraseña 'paciente'",
                    "Error de acceso",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtpassword.Clear();
                txtpassword.Focus();
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            FormRegistroPaciente formRegistro = new FormRegistroPaciente();
            formRegistro.Show();
            this.Hide();
        }

        // Función que evalúa usuario y contraseña y retorna el rol
        private string DetectarRol(string usuario, string password)
        {
            string u = usuario.ToLower();
            string p = password.ToLower();

            // Rol Doctor
            if (u == UsuarioDoctor && (p == ClaveDoctor || p == "doc123"))
            {
                return "Doctor";
            }

            // Rol Tópico
            if (u == UsuarioTopico && (p == ClaveTopico || p == "top123"))
            {
                return "Topico";
            }

            // Rol Paciente directo
            if (u == "paciente" || p == ClavePaciente || p == "pac2026")
            {
                return "Paciente";
            }

            // Rol Paciente por DNI registrado
            if (int.TryParse(usuario, out int dniBuscado))
            {
                for (int i = 0; i < Datos.contadorPacientes; i++)
                {
                    if (Datos.pacientes[i].Dni == dniBuscado)
                    {
                        if (p == ClavePaciente || p == "123" || p == "pac2026" || password == usuario)
                        {
                            return "Paciente";
                        }
                    }
                }
            }

            return "";
        }

        private void lblSalir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "¿Está seguro de que desea salir del sistema?",
                "Confirmar salida", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            txtpassword.Clear();
            if (string.IsNullOrWhiteSpace(txtusuario.Text))
            {
                txtusuario.Focus();
            }
            else
            {
                txtpassword.Focus();
            }
        }
    }
}
