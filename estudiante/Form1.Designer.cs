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
            label1 = new Label();
            btnBuscar = new Button();
            lblBuscar = new Label();
            txtBuscar = new TextBox();
            lblResultado = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Cambria", 12F);
            txtNombre.Location = new Point(170, 75);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(105, 26);
            txtNombre.TabIndex = 0;
            // 
            // txtEdad
            // 
            txtEdad.Font = new Font("Cambria", 12F);
            txtEdad.Location = new Point(170, 117);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(105, 26);
            txtEdad.TabIndex = 1;
            // 
            // txtPromedio
            // 
            txtPromedio.Font = new Font("Cambria", 12F);
            txtPromedio.Location = new Point(170, 162);
            txtPromedio.Name = "txtPromedio";
            txtPromedio.Size = new Size(105, 26);
            txtPromedio.TabIndex = 2;
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Cambria", 12F);
            btnAgregar.Location = new Point(102, 206);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(153, 44);
            btnAgregar.TabIndex = 3;
            btnAgregar.Text = "Agregar Estudiante";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // listBoxEstudiantes
            // 
            listBoxEstudiantes.Font = new Font("Cambria", 12F);
            listBoxEstudiantes.FormattingEnabled = true;
            listBoxEstudiantes.ItemHeight = 19;
            listBoxEstudiantes.Location = new Point(318, 75);
            listBoxEstudiantes.Name = "listBoxEstudiantes";
            listBoxEstudiantes.Size = new Size(430, 175);
            listBoxEstudiantes.TabIndex = 4;
            // 
            // lbltxtNombre
            // 
            lbltxtNombre.AutoSize = true;
            lbltxtNombre.Font = new Font("Cambria", 12F);
            lbltxtNombre.Location = new Point(79, 82);
            lbltxtNombre.Name = "lbltxtNombre";
            lbltxtNombre.Size = new Size(74, 19);
            lbltxtNombre.TabIndex = 5;
            lbltxtNombre.Text = "Nombre: ";
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.Font = new Font("Cambria", 12F);
            lblEdad.Location = new Point(79, 124);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(52, 19);
            lblEdad.TabIndex = 6;
            lblEdad.Text = "Edad: ";
            // 
            // lblPromedio
            // 
            lblPromedio.AutoSize = true;
            lblPromedio.Font = new Font("Cambria", 12F);
            lblPromedio.Location = new Point(79, 169);
            lblPromedio.Name = "lblPromedio";
            lblPromedio.Size = new Size(85, 19);
            lblPromedio.TabIndex = 7;
            lblPromedio.Text = "Promedio: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(258, 21);
            label1.Name = "label1";
            label1.Size = new Size(223, 25);
            label1.TabIndex = 8;
            label1.Text = "Registro de estudiantes";
            // 
            // btnBuscar
            // 
            btnBuscar.Font = new Font("Cambria", 12F);
            btnBuscar.Location = new Point(295, 323);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(97, 26);
            btnBuscar.TabIndex = 9;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.Font = new Font("Cambria", 12F);
            lblBuscar.Location = new Point(20, 326);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(149, 19);
            lblBuscar.TabIndex = 10;
            lblBuscar.Text = "Buscar por nombre:";
            // 
            // txtBuscar
            // 
            txtBuscar.Font = new Font("Cambria", 12F);
            txtBuscar.Location = new Point(175, 323);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(100, 26);
            txtBuscar.TabIndex = 11;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblResultado.Location = new Point(179, 349);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(82, 19);
            lblResultado.TabIndex = 12;
            lblResultado.Text = "Resultado:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cambria", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(258, 274);
            label2.Name = "label2";
            label2.Size = new Size(237, 25);
            label2.TabIndex = 13;
            label2.Text = "Búsqueda de estudiantes";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(lblResultado);
            Controls.Add(txtBuscar);
            Controls.Add(lblBuscar);
            Controls.Add(btnBuscar);
            Controls.Add(label1);
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
        private Label label1;
        private Button btnBuscar;
        private Label lblBuscar;
        private TextBox txtBuscar;
        private Label lblResultado;
        private Label label2;
    }
}
