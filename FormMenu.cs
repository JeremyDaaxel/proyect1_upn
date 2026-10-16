using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace proyecto1
{
    public partial class FormMenu : Form
    {
        public FormMenu(string rol = "")
        {
            InitializeComponent();
        }

        private void btncita_Click(object sender, EventArgs e)
        {
            FormCitas formcita = new FormCitas();
            formcita.Show();
            this.Hide();
        }

        private void btntopico_Click(object sender, EventArgs e)
        {
            FormTopico formtopico = new FormTopico();
            formtopico.Show();
            this.Hide();
        }

        private void btndoctor_Click(object sender, EventArgs e)
        {
            FormDoctor formdoctor = new FormDoctor();
            formdoctor.Show();
            this.Hide();
        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {
            FormRegistroPaciente formregistrar = new FormRegistroPaciente();
            formregistrar.Show();
            this.Hide();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro de que desea salir?", "Confirmar salida", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
