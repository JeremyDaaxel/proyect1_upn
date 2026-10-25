using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace proyecto1
{
    public partial class FormTopico : Form
    {
        public FormTopico()
        {
            InitializeComponent();
        }

        private void FormTopico_Load(object sender, EventArgs e)
        {
            CargarAtenciones();
        }

        private void CargarAtenciones()
        {
            dataGridView1.Rows.Clear();
            for (int i = 0; i < Datos.contadorAtenciones; i++)
            {
                Triaje t = Datos.atenciones[i];
                string precioTexto = (t.Costo == 0) ? "S/ 0" : "S/ 20";
                dataGridView1.Rows.Add(t.Dni, t.PresionArterial, t.Temperatura + " °C", t.Peso + " kg", t.Observaciones, t.Seguro, precioTexto);
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
            // Solo permitir números y teclas de control
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtDecimal_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir números, punto o coma decimal y control
            TextBox? txt = sender as TextBox;
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != ',')
            {
                e.Handled = true;
            }

            // Evitar más de un punto o coma
            if ((e.KeyChar == '.' || e.KeyChar == ',') && txt != null && (txt.Text.Contains(".") || txt.Text.Contains(",")))
            {
                e.Handled = true;
            }
        }

        private void btnatencion_Click(object sender, EventArgs e)
        {
            if (txtdni.Text.Trim().Length != 8)
            {
                MessageBox.Show("El DNI debe tener exactamente 8 dígitos.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtdni.Text.Trim(), out int dni))
            {
                MessageBox.Show("El DNI debe contener solo números.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtpresion.Text) || 
                string.IsNullOrWhiteSpace(txttemp.Text) || 
                string.IsNullOrWhiteSpace(txtpeso.Text))
            {
                MessageBox.Show("Completa la presión arterial, temperatura y peso (por separado).", "Faltan datos",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Buscamos si el paciente ya esta registrado para verificar seguro y precio
            Paciente? pacienteEncontrado = null;
            for (int i = 0; i < Datos.contadorPacientes; i++)
            {
                if (Datos.pacientes[i].Dni == dni)
                {
                    pacienteEncontrado = Datos.pacientes[i];
                    break;
                }
            }

            if (pacienteEncontrado == null)
            {
                MessageBox.Show("No se encontró un paciente registrado con ese DNI. Primero regístralo.", "Paciente no registrado",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Calculamos precio según el tipo de seguro: SIS = S/ 0, Particular/otro = S/ 20
            int precio = 20;
            string seguroPaciente = pacienteEncontrado.Seguro ?? "Particular";
            if (seguroPaciente.Trim().ToUpper() == "SIS")
            {
                precio = 0;
            }

            // Creamos el objeto Triaje y guardamos en DatosGlobales
            Triaje nuevaAtencion = new Triaje();
            nuevaAtencion.Dni = dni;
            nuevaAtencion.PresionArterial = txtpresion.Text.Trim();
            nuevaAtencion.Temperatura = txttemp.Text.Trim();
            nuevaAtencion.Peso = txtpeso.Text.Trim();
            nuevaAtencion.Observaciones = txtobs.Text.Trim();
            nuevaAtencion.Seguro = seguroPaciente;
            nuevaAtencion.Costo = precio;

            Datos.atenciones[Datos.contadorAtenciones++] = nuevaAtencion;

            string precioTexto = (precio == 0) ? "S/ 0" : "S/ 20";
            dataGridView1.Rows.Add(nuevaAtencion.Dni, nuevaAtencion.PresionArterial, nuevaAtencion.Temperatura + " °C", nuevaAtencion.Peso + " kg", nuevaAtencion.Observaciones, nuevaAtencion.Seguro, precioTexto);

            MessageBox.Show($"Atención de tópico guardada con éxito.\nSeguro: {seguroPaciente}\nPrecio de atención: {precioTexto}", 
                "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Limpiamos los inputs
            txtdni.Clear();
            txtpresion.Clear();
            txttemp.Clear();
            txtpeso.Clear();
            txtobs.Clear();
        }
    }
}
