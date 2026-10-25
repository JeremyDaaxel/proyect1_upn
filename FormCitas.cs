using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace proyecto1
{
    public partial class FormCitas : Form
    {
        public FormCitas()
        {
            InitializeComponent();
        }

        private void FormCitas_Load(object sender, EventArgs e)
        {
            CargarCitas();
        }

        private void CargarCitas()
        {
            dataGridView1.Rows.Clear();
            for (int i = 0; i < Datos.contadorCitas; i++)
            {
                Cita c = Datos.citas[i];
                dataGridView1.Rows.Add(c.Dni, c.Especialidad, c.Fecha, c.Costo);
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
            // Solo permitir números y teclas de control (retroceso, etc.)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnreservar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtdni.Text) || comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Completa el DNI y selecciona una especialidad.", "Faltan datos",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtdni.Text.Trim().Length != 8)
            {
                MessageBox.Show("El DNI debe tener exactamente 8 dígitos.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtdni.Text.Trim(), out int dniBuscado))
            {
                MessageBox.Show("El DNI debe contener solo números válidos.", "Error de formato",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Paciente? pacienteEncontrado = null;

            // Buscamos si el paciente ya esta registrado
            for (int i = 0; i < Datos.contadorPacientes; i++)
            {
                if (Datos.pacientes[i].Dni == dniBuscado)
                {
                    pacienteEncontrado = Datos.pacientes[i];
                    break;
                }
            }

            if (pacienteEncontrado == null)
            {
                MessageBox.Show("No hay un paciente registrado con ese DNI. Primero regístralo.", "Paciente no encontrado",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Calculamos el costo segun si tiene SIS o Particular
            int costoCita = CalcularCosto(pacienteEncontrado.Seguro);

            // Creamos el objeto nuevaCita y le asignamos los datos
            Cita nuevaCita = new Cita();
            nuevaCita.Dni = dniBuscado;
            nuevaCita.Especialidad = comboBox1.Text;
            nuevaCita.Fecha = dateTimePicker1.Text;
            nuevaCita.Costo = costoCita;

            // Agregamos a la lista de citas en DatosGlobales
            Datos.citas[Datos.contadorCitas++] = nuevaCita;

            // Agregamos la fila a la tabla
            dataGridView1.Rows.Add(nuevaCita.Dni, nuevaCita.Especialidad, nuevaCita.Fecha, nuevaCita.Costo);

            MessageBox.Show("Cita reservada con éxito. Costo: S/ " + costoCita, "Registro exitoso",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Limpiamos los inputs
            txtdni.Clear();
            comboBox1.SelectedIndex = -1;
        }

        // Funcion: recibe el seguro del paciente y retorna el costo de la cita
        private int CalcularCosto(string seguro)
        {
            if (!string.IsNullOrEmpty(seguro) && seguro.Trim().ToUpper() == "SIS")
            {
                return 0;
            }
            else
            {
                return 20;
            }
        }
    }
}
