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

        private void button1_Click(object sender, EventArgs e)
        {
            FormMenu menu = new FormMenu();
            menu.Show();
            this.Close();
        }

        
        private void btnreservar_Click(object sender, EventArgs e)
        {   //condicionales (si los inputs tan vacios, da error)
            if (txtdni.Text == "" || comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Completa el DNI y selecciona una especialidad.", "Faltan datos",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int dniBuscado = int.Parse(txtdni.Text);
            Paciente pacienteEncontrado = null;

            //buscamos si el paciente ya esta registrado
            for (int i = 0; i < Datos.contadorPacientes; i++)
            {
                if (Datos.pacientes[i].Dni == dniBuscado)
                {
                    pacienteEncontrado = Datos.pacientes[i];
                }
            }

            if (pacienteEncontrado == null)
            {
                MessageBox.Show("No hay un paciente registrado con ese DNI. Primero registralo.", "Paciente no encontrado",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //calculamos el costo segun si tiene SIS o no (esto es una funcion, retorna el costo)
            int costoCita = CalcularCosto(pacienteEncontrado.Seguro);

            //creamos el objeto nuevaCita (de la clase Cita en DatosGlobales) y le asignamos los datos
            Cita nuevaCita = new Cita();
            nuevaCita.Dni = dniBuscado;
            nuevaCita.Especialidad = comboBox1.Text;
            nuevaCita.Fecha = dateTimePicker1.Text;
            nuevaCita.Costo = costoCita;

            //agregamos los datos que ingresamos a la lista de citas que tenemos en DatosGlobales
            Datos.citas[Datos.contadorCitas++] = nuevaCita;

            //agregamos la fila nueva directo a la tabla, sin recargar todo
            dataGridView1.Rows.Add(nuevaCita.Dni, nuevaCita.Especialidad, nuevaCita.Fecha, nuevaCita.Costo);

            MessageBox.Show("Cita reservada con éxito. Costo: S/ " + costoCita, "Registro exitoso",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            //limpiamos los inputs una vez se registre
            txtdni.Clear();
        }

        //funcion: recibe el seguro del paciente y retorna (return) el costo de la cita
        private int CalcularCosto(string seguro)
        {
            if (seguro == "SIS")
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
