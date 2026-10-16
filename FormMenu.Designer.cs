namespace proyecto1
{
    partial class FormMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbltitulo = new System.Windows.Forms.Label();
            btncita = new System.Windows.Forms.Button();
            btntopico = new System.Windows.Forms.Button();
            btndoctor = new System.Windows.Forms.Button();
            btnregistrar = new System.Windows.Forms.Button();
            btnsalir = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // lbltitulo
            // 
            lbltitulo.AutoSize = true;
            lbltitulo.Font = new System.Drawing.Font("Arial Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
            lbltitulo.Location = new System.Drawing.Point(190, 25);
            lbltitulo.Name = "lbltitulo";
            lbltitulo.Size = new System.Drawing.Size(167, 27);
            lbltitulo.TabIndex = 0;
            lbltitulo.Text = "Menú Principal";
            // 
            // btncita
            // 
            btncita.BackColor = System.Drawing.Color.FromArgb(((int)((byte)2)), ((int)((byte)136)), ((int)((byte)209)));
            btncita.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            btncita.ForeColor = System.Drawing.Color.White;
            btncita.Location = new System.Drawing.Point(95, 110);
            btncita.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btncita.Name = "btncita";
            btncita.Size = new System.Drawing.Size(111, 35);
            btncita.TabIndex = 1;
            btncita.Text = "Cita";
            btncita.UseVisualStyleBackColor = false;
            btncita.Click += btncita_Click;
            // 
            // btntopico
            // 
            btntopico.BackColor = System.Drawing.Color.FromArgb(((int)((byte)2)), ((int)((byte)136)), ((int)((byte)209)));
            btntopico.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            btntopico.ForeColor = System.Drawing.Color.White;
            btntopico.Location = new System.Drawing.Point(222, 110);
            btntopico.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btntopico.Name = "btntopico";
            btntopico.Size = new System.Drawing.Size(111, 35);
            btntopico.TabIndex = 2;
            btntopico.Text = "Topico";
            btntopico.UseVisualStyleBackColor = false;
            btntopico.Click += btntopico_Click;
            // 
            // btndoctor
            // 
            btndoctor.BackColor = System.Drawing.Color.FromArgb(((int)((byte)2)), ((int)((byte)136)), ((int)((byte)209)));
            btndoctor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            btndoctor.ForeColor = System.Drawing.Color.White;
            btndoctor.Location = new System.Drawing.Point(351, 110);
            btndoctor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btndoctor.Name = "btndoctor";
            btndoctor.Size = new System.Drawing.Size(111, 35);
            btndoctor.TabIndex = 3;
            btndoctor.Text = "Doctor";
            btndoctor.UseVisualStyleBackColor = false;
            btndoctor.Click += btndoctor_Click;
            // 
            // btnregistrar
            // 
            btnregistrar.BackColor = System.Drawing.Color.FromArgb(((int)((byte)2)), ((int)((byte)136)), ((int)((byte)209)));
            btnregistrar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            btnregistrar.ForeColor = System.Drawing.Color.White;
            btnregistrar.Location = new System.Drawing.Point(72, 180);
            btnregistrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnregistrar.Name = "btnregistrar";
            btnregistrar.Size = new System.Drawing.Size(134, 49);
            btnregistrar.TabIndex = 4;
            btnregistrar.Text = "Registrar";
            btnregistrar.UseVisualStyleBackColor = false;
            btnregistrar.Click += btnregistrar_Click;
            // 
            // btnsalir
            // 
            btnsalir.BackColor = System.Drawing.Color.FromArgb(((int)((byte)230)), ((int)((byte)81)), ((int)((byte)0)));
            btnsalir.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
            btnsalir.ForeColor = System.Drawing.Color.White;
            btnsalir.Location = new System.Drawing.Point(340, 184);
            btnsalir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnsalir.Name = "btnsalir";
            btnsalir.Size = new System.Drawing.Size(122, 40);
            btnsalir.TabIndex = 5;
            btnsalir.Text = "Salir";
            btnsalir.UseVisualStyleBackColor = false;
            btnsalir.Click += btnsalir_Click;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(((int)((byte)224)), ((int)((byte)242)), ((int)((byte)241)));
            ClientSize = new System.Drawing.Size(574, 338);
            Controls.Add(btnsalir);
            Controls.Add(btnregistrar);
            Controls.Add(btndoctor);
            Controls.Add(btntopico);
            Controls.Add(btncita);
            Controls.Add(lbltitulo);
            Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Menú Principal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbltitulo;
        private Button btncita;
        private Button btntopico;
        private Button btndoctor;
        private Button btnregistrar;
        private Button btnsalir;
    }
}
