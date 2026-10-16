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

        private void button1_Click(object sender, EventArgs e)
        {
            FormMenu menu = new FormMenu();
            menu.Show();
            this.Close();
        }

        private void FormDoctor_Load(object sender, EventArgs e)
        {

        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            //validar que se haya escrito un dni
            if (txtdni.Text == "")
            {
                MessageBox.Show("Escribe un DNI para buscar.", "Falta un dato",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int dniBuscado = int.Parse(txtdni.Text);

            //recorrer la lista de pacientes buscando ese dni
            //(es lo mismo que hicimos en FormCitas, solo que aca buscamos en Datos.pacientes)
            Paciente pacienteEncontrado = null;
            for (int i = 0; i < Datos.pacientes.Count; i++)
            {
                if (Datos.pacientes[i].Dni == dniBuscado)
                {
                    pacienteEncontrado = Datos.pacientes[i];
                }
            }

            //si no encontro a nadie con ese dni, avisamos y paramos aca
            if (pacienteEncontrado == null)
            {
                txtResultado.Text = "No se encontro un paciente registrado con ese DNI.";
                return;
            }

            // recorrer la lista de atenciones de topico buscando ese mismo dni
            //(mismo patron de busqueda otra vez, solo que en Datos.atenciones)
            Triaje triajeEncontrado = null;
            for (int i = 0; i < Datos.atenciones.Count; i++)
            {
                if (Datos.atenciones[i].Dni == dniBuscado)
                {
                    triajeEncontrado = Datos.atenciones[i];
                }
            }

            //mostrar el resultado en el textbox, linea por linea con Environment.NewLine
            if (triajeEncontrado == null)
            {
                MessageBox.Show("El paciente todavia no tiene registro de topico.", "Sin triaje",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                txtResultado.Text = "Paciente: " + pacienteEncontrado.Nombre + " " + pacienteEncontrado.Apellido + Environment.NewLine +
                    "Seguro: " + pacienteEncontrado.Seguro + Environment.NewLine +
                    "Celular: " + pacienteEncontrado.Celular;
            }
            else
            {
                txtResultado.Text = "Paciente: " + pacienteEncontrado.Nombre + " " + pacienteEncontrado.Apellido + Environment.NewLine +
                    "Seguro: " + pacienteEncontrado.Seguro + Environment.NewLine +
                    "Celular: " + pacienteEncontrado.Celular + Environment.NewLine +
                    "Presion: " + triajeEncontrado.PresionArterial + Environment.NewLine +
                    "Temp/Peso: " + triajeEncontrado.TemperaturaPeso + Environment.NewLine +
                    "Observaciones topico: " + triajeEncontrado.Observaciones;
            }
        }

        private void btndiagnostico_Click(object sender, EventArgs e)
        {   //condicionales (si los inputs tan vacios, da error)
            if (txtdni.Text == "" || txtdiagnostico.Text == "" || txtreceta.Text == "")
            {
                MessageBox.Show("Completa DNI, diagnóstico y receta.", "Faltan datos",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //creamos el objeto nuevoDiagnostico (de la clase Diagnostico en DatosGlobales) y le asignamos los datos
            Diagnostico nuevoDiagnostico = new Diagnostico();
            nuevoDiagnostico.Dni = int.Parse(txtdni.Text);
            nuevoDiagnostico.Sintomas = txtsintomas.Text;
            nuevoDiagnostico.DiagnosticoMedico = txtdiagnostico.Text;
            nuevoDiagnostico.Receta = txtreceta.Text;

            //agregamos los datos que ingresamos a la lista de diagnosticos que tenemos en DatosGlobales
            Datos.diagnosticos.Add(nuevoDiagnostico);

            MessageBox.Show("Diagnóstico guardado con éxito.", "Registro exitoso",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            //limpiamos los inputs una vez se registre
            txtsintomas.Clear();
            txtdiagnostico.Clear();
            txtreceta.Clear();
        }
    }
}
