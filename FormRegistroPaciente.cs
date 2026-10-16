using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        {   //boton para regresar y mostrar el menu general, donde esta eso pe de topico, registrar, esa nota
            FormMenu menu = new FormMenu();
            menu.Show();
            this.Close();
        }

        private void btnpaciente_Click(object sender, EventArgs e)
        {   //condicionales (si los inputs tan vacios, da error, deben tar todos llenos)
            if (txtdni.Text == "" || txtnombre.Text == "" || txtapellido.Text == "" || txtcel.Text == "")
            {
                MessageBox.Show("Completa DNI, nombre, apellido y celular.", "Faltan datos",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; //que feo se ve esto ajxsajxasj
            }
            //creamos el objeto nuePaciente (de la clase Paciente en DatosGlobales) y
            //le asignamos los datos que se escribieron en los inputs pe y lo parseamos
            Paciente nuePaciente = new Paciente();
            nuePaciente.Dni = int.Parse(txtdni.Text);
            nuePaciente.Nombre = txtnombre.Text;
            nuePaciente.Apellido = txtapellido.Text;
            nuePaciente.Correo = txtcorreo.Text;
            nuePaciente.Celular = int.Parse(txtcel.Text);
            nuePaciente.Seguro = cboseguro.Text;
            
            //agregamos los datos que ingresamos a la lista de pacientes que tenemos en DatosGlobales
            Datos.pacientes.Add(nuePaciente);
            MessageBox.Show("Paciente guardado con éxito.", "Registro exitoso",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            //limpiamos los inputs una vez se registre
            txtdni.Clear();
            txtnombre.Clear();
            txtapellido.Clear();
            txtcorreo.Clear();
            txtcel.Clear();
            cboseguro.SelectedIndex = -1;
        }
    }
}
