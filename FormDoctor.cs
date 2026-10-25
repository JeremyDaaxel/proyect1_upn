using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace proyecto1
{
    public partial class FormDoctor : Form
    {
        public FormDoctor()
        {
            InitializeComponent();
        }

        private void FormDoctor_Load(object sender, EventArgs e)
        {
            CargarHistorial();
        }

        private void CargarHistorial()
        {
            dataGridView1.Rows.Clear();
            for (int i = 0; i < Datos.contadorDiagnosticos; i++)
            {
                Diagnostico diag = Datos.diagnosticos[i];
                Paciente? pac = BuscarPaciente(diag.Dni);
                Triaje? tri = BuscarTriaje(diag.Dni);
                Cita? cit = BuscarCita(diag.Dni);

                string nombreCompleto = pac != null ? (pac.Nombre + " " + pac.Apellido) : "No registrado";
                string especialidad = cit != null ? cit.Especialidad : "Sin cita previa";
                string presion = tri != null ? tri.PresionArterial : "-";
                string temp = tri != null ? (tri.Temperatura + " °C") : "-";
                string peso = tri != null ? (tri.Peso + " kg") : "-";

                dataGridView1.Rows.Add(diag.Dni, nombreCompleto, especialidad, presion, temp, peso,
                    diag.Sintomas, diag.DiagnosticoMedico, diag.Receta);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormLogin login = new FormLogin();
            login.Show();
            this.Close();
        }

        private void txtdni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtdni.Text))
            {
                MessageBox.Show("Escribe un DNI para buscar.", "Falta un dato",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtdni.Text.Trim().Length != 8 || !int.TryParse(txtdni.Text.Trim(), out int dniBuscado))
            {
                MessageBox.Show("El DNI debe tener exactamente 8 dígitos numéricos.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Paciente? paciente = BuscarPaciente(dniBuscado);
            if (paciente == null)
            {
                lblinfo.ForeColor = Color.DarkRed;
                lblinfo.Text = "No se encontró ningún paciente registrado con el DNI " + dniBuscado;
                MessageBox.Show("No se encontró un paciente registrado con ese DNI.", "Paciente no encontrado",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Triaje? triaje = BuscarTriaje(dniBuscado);
            Cita? cita = BuscarCita(dniBuscado);

            string infoEspecialidad = cita != null ? cita.Especialidad : "(Sin cita)";
            string infoTriaje = triaje != null 
                ? $"Presión: {triaje.PresionArterial} | Temp: {triaje.Temperatura} °C | Peso: {triaje.Peso} kg" 
                : "(Sin triaje de tópico)";

            lblinfo.ForeColor = Color.DarkGreen;
            lblinfo.Text = $"Paciente: {paciente.Nombre} {paciente.Apellido} | Seguro: {paciente.Seguro} | Esp: {infoEspecialidad} | {infoTriaje}";

            if (triaje == null)
            {
                MessageBox.Show("El paciente todavía no tiene registro de signos vitales en tópico.", "Aviso de Triaje",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btndiagnostico_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtdni.Text) || 
                string.IsNullOrWhiteSpace(txtdiagnostico.Text) || 
                string.IsNullOrWhiteSpace(txtreceta.Text))
            {
                MessageBox.Show("Completa al menos el DNI, diagnóstico y receta médica.", "Faltan datos",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtdni.Text.Trim().Length != 8 || !int.TryParse(txtdni.Text.Trim(), out int dni))
            {
                MessageBox.Show("El DNI debe tener exactamente 8 dígitos numéricos.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Paciente? paciente = BuscarPaciente(dni);
            if (paciente == null)
            {
                MessageBox.Show("El paciente con este DNI no está registrado en el sistema. Debe registrarse primero.",
                    "Paciente no registrado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Triaje? triaje = BuscarTriaje(dni);
            Cita? cita = BuscarCita(dni);

            // Creamos y guardamos el diagnóstico
            Diagnostico nuevoDiagnostico = new Diagnostico();
            nuevoDiagnostico.Dni = dni;
            nuevoDiagnostico.Sintomas = txtsintomas.Text.Trim();
            nuevoDiagnostico.DiagnosticoMedico = txtdiagnostico.Text.Trim();
            nuevoDiagnostico.Receta = txtreceta.Text.Trim();

            Datos.diagnosticos[Datos.contadorDiagnosticos++] = nuevoDiagnostico;

            // Datos complementarios para el DataGridView
            string nombreCompleto = paciente.Nombre + " " + paciente.Apellido;
            string especialidad = cita != null ? cita.Especialidad : "General";
            string presion = triaje != null ? triaje.PresionArterial : "-";
            string temp = triaje != null ? (triaje.Temperatura + " °C") : "-";
            string peso = triaje != null ? (triaje.Peso + " kg") : "-";

            // Agregamos la fila al DataGridView con la información de tópico, especialidad y diagnóstico
            dataGridView1.Rows.Add(dni, nombreCompleto, especialidad, presion, temp, peso,
                nuevoDiagnostico.Sintomas, nuevoDiagnostico.DiagnosticoMedico, nuevoDiagnostico.Receta);

            MessageBox.Show("Diagnóstico y receta guardados con éxito en el expediente del paciente.", 
                "Consulta Guardada", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Limpiamos los campos
            txtsintomas.Clear();
            txtdiagnostico.Clear();
            txtreceta.Clear();
            txtdni.Clear();
            lblinfo.ForeColor = Color.DarkBlue;
            lblinfo.Text = "Ingresa el DNI del paciente para consultar triaje y especialidad de cita.";
        }

        private Paciente? BuscarPaciente(int dni)
        {
            for (int i = 0; i < Datos.contadorPacientes; i++)
            {
                if (Datos.pacientes[i].Dni == dni)
                {
                    return Datos.pacientes[i];
                }
            }
            return null;
        }

        private Triaje? BuscarTriaje(int dni)
        {
            // Buscamos la última atención de tópico registrada para ese DNI
            for (int i = Datos.contadorAtenciones - 1; i >= 0; i--)
            {
                if (Datos.atenciones[i].Dni == dni)
                {
                    return Datos.atenciones[i];
                }
            }
            return null;
        }

        private Cita? BuscarCita(int dni)
        {
            // Buscamos la última cita registrada para ese DNI
            for (int i = Datos.contadorCitas - 1; i >= 0; i--)
            {
                if (Datos.citas[i].Dni == dni)
                {
                    return Datos.citas[i];
                }
            }
            return null;
        }
    }
}
