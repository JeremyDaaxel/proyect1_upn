using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace proyecto1
{
    public partial class FormRegistroPaciente : Form
    {
        public FormRegistroPaciente()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormLogin login = new FormLogin();
            login.Show();
            this.Close();
        }

        private void txtTextoSolo_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Solo permitir letras, espacios y teclas de control (retroceso, suprimir, etc.)
            // No permite números ni caracteres especiales
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtNumeroSolo_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Solo permitir números y teclas de control
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnpaciente_Click(object sender, EventArgs e)
        {
            string dniTexto = txtdni.Text.Trim();
            string nombreTexto = txtnombre.Text.Trim();
            string apellidoTexto = txtapellido.Text.Trim();
            string celTexto = txtcel.Text.Trim();
            string correoTexto = txtcorreo.Text.Trim();

            if (string.IsNullOrWhiteSpace(dniTexto) ||
                string.IsNullOrWhiteSpace(nombreTexto) ||
                string.IsNullOrWhiteSpace(apellidoTexto) ||
                string.IsNullOrWhiteSpace(celTexto) ||
                cboseguro.SelectedItem == null)
            {
                MessageBox.Show("Completa DNI, nombre, apellido, celular y selecciona el tipo de seguro.",
                    "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar que el DNI tenga 8 dígitos
            if (dniTexto.Length != 8 || !int.TryParse(dniTexto, out int dniValido))
            {
                MessageBox.Show("El DNI debe tener exactamente 8 dígitos numéricos.",
                    "DNI Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtdni.Focus();
                return;
            }

            // Validar que nombre no contenga números
            if (nombreTexto.Any(c => !char.IsLetter(c) && !char.IsWhiteSpace(c)))
            {
                MessageBox.Show("El campo Nombres solo permite texto (letras), sin números ni símbolos.",
                    "Nombre Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtnombre.Focus();
                return;
            }

            // Validar que apellido no contenga números
            if (apellidoTexto.Any(c => !char.IsLetter(c) && !char.IsWhiteSpace(c)))
            {
                MessageBox.Show("El campo Apellidos solo permite texto (letras), sin números ni símbolos.",
                    "Apellido Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtapellido.Focus();
                return;
            }

            // Validar celular numérico de 9 dígitos
            if (celTexto.Length != 9 || !int.TryParse(celTexto, out int celValido))
            {
                MessageBox.Show("El número de celular debe tener exactamente 9 dígitos numéricos.",
                    "Celular Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtcel.Focus();
                return;
            }

            // Verificar si el DNI ya fue registrado
            for (int i = 0; i < Datos.contadorPacientes; i++)
            {
                if (Datos.pacientes[i].Dni == dniValido)
                {
                    MessageBox.Show("Ya existe un paciente registrado con el DNI " + dniValido + ".",
                        "Paciente ya existe", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            // Crear y guardar el nuevo paciente
            Paciente nuePaciente = new Paciente();
            nuePaciente.Dni = dniValido;
            nuePaciente.Nombre = nombreTexto;
            nuePaciente.Apellido = apellidoTexto;
            nuePaciente.Correo = correoTexto;
            nuePaciente.Celular = celValido;
            nuePaciente.Seguro = cboseguro.Text;

            Datos.pacientes[Datos.contadorPacientes++] = nuePaciente;

            MessageBox.Show("Paciente registrado y guardado con éxito.", "Registro exitoso",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Limpiar inputs
            txtdni.Clear();
            txtnombre.Clear();
            txtapellido.Clear();
            txtcorreo.Clear();
            txtcel.Clear();
            cboseguro.SelectedIndex = -1;
        }
    }
}
