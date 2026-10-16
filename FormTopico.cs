using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
//joayn
namespace proyecto1
{
    public partial class FormTopico : Form
    {
        public FormTopico()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormMenu menu = new FormMenu();
            menu.Show();
            this.Close();
        }

        private void btnatencion_Click(object sender, EventArgs e)
        {   //condicionales (si los inputs tan vacios o el dni no tiene 8 digitos, da error)
            if (txtdni.Text.Trim().Length != 8)
            {
                MessageBox.Show("El DNI debe tener 8 dígitos.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtpresion.Text == "" || txttemp.Text == "")
            {
                MessageBox.Show("Completa presión arterial y temperatura/peso.", "Faltan datos",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //creamos el objeto nuevaAtencion (de la clase Triaje en DatosGlobales) y le asignamos los datos
            Triaje nuevaAtencion = new Triaje();
            nuevaAtencion.Dni = int.Parse(txtdni.Text);
            nuevaAtencion.PresionArterial = txtpresion.Text;
            nuevaAtencion.TemperaturaPeso = txttemp.Text;
            nuevaAtencion.Observaciones = txtobs.Text;

            //agregamos los datos que ingresamos a la lista de atenciones que tenemos en DatosGlobales
            Datos.atenciones.Add(nuevaAtencion);

            //agregamos la fila nueva directo a la tabla, sin recargar todo
            dataGridView1.Rows.Add(nuevaAtencion.Dni, nuevaAtencion.PresionArterial, nuevaAtencion.TemperaturaPeso, nuevaAtencion.Observaciones);

            MessageBox.Show("Atención guardada con éxito.", "Registro exitoso",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            //limpiamos los inputs una vez se registre
            txtdni.Clear();
            txtpresion.Clear();
            txttemp.Clear();
            txtobs.Clear();
        }
    }
}