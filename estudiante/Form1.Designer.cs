namespace estudiante
{
    partial class Form1
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtNombre = new TextBox();
            txtEdad = new TextBox();
            txtPromedio = new TextBox();
            btnAgregar = new Button();
            listBoxEstudiantes = new ListBox();
            lbltxtNombre = new Label();
            lblEdad = new Label();
            lblPromedio = new Label();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(213, 137);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(105, 23);
            txtNombre.TabIndex = 0;
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(213, 177);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(105, 23);
            txtEdad.TabIndex = 1;
            // 
            // txtPromedio
            // 
            txtPromedio.Location = new Point(213, 223);
            txtPromedio.Name = "txtPromedio";
            txtPromedio.Size = new Size(105, 23);
            txtPromedio.TabIndex = 2;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(328, 328);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(114, 44);
            btnAgregar.TabIndex = 3;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // listBoxEstudiantes
            // 
            listBoxEstudiantes.FormattingEnabled = true;
            listBoxEstudiantes.ItemHeight = 15;
            listBoxEstudiantes.Location = new Point(426, 101);
            listBoxEstudiantes.Name = "listBoxEstudiantes";
            listBoxEstudiantes.Size = new Size(250, 184);
            listBoxEstudiantes.TabIndex = 4;
            // 
            // lbltxtNombre
            // 
            lbltxtNombre.AutoSize = true;
            lbltxtNombre.Location = new Point(145, 137);
            lbltxtNombre.Name = "lbltxtNombre";
            lbltxtNombre.Size = new Size(57, 15);
            lbltxtNombre.TabIndex = 5;
            lbltxtNombre.Text = "Nombre: ";
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.Location = new Point(145, 177);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(39, 15);
            lblEdad.TabIndex = 6;
            lblEdad.Text = "Edad: ";
            // 
            // lblPromedio
            // 
            lblPromedio.AutoSize = true;
            lblPromedio.Location = new Point(145, 231);
            lblPromedio.Name = "lblPromedio";
            lblPromedio.Size = new Size(65, 15);
            lblPromedio.TabIndex = 7;
            lblPromedio.Text = "Promedio: ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblPromedio);
            Controls.Add(lblEdad);
            Controls.Add(lbltxtNombre);
            Controls.Add(listBoxEstudiantes);
            Controls.Add(btnAgregar);
            Controls.Add(txtPromedio);
            Controls.Add(txtEdad);
            Controls.Add(txtNombre);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private TextBox txtEdad;
        private TextBox txtPromedio;
        private Button btnAgregar;
        private ListBox listBoxEstudiantes;
        private Label lbltxtNombre;
        private Label lblEdad;
        private Label lblPromedio;
    }
}
