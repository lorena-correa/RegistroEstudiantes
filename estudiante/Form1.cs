namespace estudiante
{
    public partial class Form1 : Form
    {

        private List<RegistroE> estudiantes;
        public Form1()
        {
            InitializeComponent();
            estudiantes = new List<RegistroE>();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = txtNombre.Text.Trim();

                //Validar que el campo sea númerico
                if (!int.TryParse(txtEdad.Text, out int edad))
                {
                    MessageBox.Show("La edad debe ser numérica.");
                    return;
                }
                //Validar que el campo sea númerico

                if (!double.TryParse(txtPromedio.Text, out double promedio))
                {
                    MessageBox.Show("El promedio debe ser numérico.");
                    return;
                }

                // Validar registros duplicado
                if (estudiantes.Any(e => e.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase)))
                {
                    MessageBox.Show("El estudiante ya existe.");
                    return;
                }

                RegistroE nuevo = new RegistroE(nombre, edad, promedio);

                estudiantes.Add(nuevo);
                listBoxEstudiantes.Items.Add(nuevo);

                txtNombre.Clear();
                txtEdad.Clear();
                txtPromedio.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string nombreBuscar = txtBuscar.Text.Trim();

            if (string.IsNullOrWhiteSpace(nombreBuscar) || !nombreBuscar.All(c => char.IsLetter(c) || c == ' '))
            {
                MessageBox.Show("Ingrese un nombre válido.");
                return;
            }

            RegistroE encontrado = estudiantes.FirstOrDefault(e => e.Nombre.Equals(nombreBuscar, StringComparison.OrdinalIgnoreCase));

            if (encontrado != null)
            {
                lblResultado.Text = encontrado.ToString();
            }
            else
            {
                lblResultado.Text = "Estudiante no encontrado.";
            }
        }
    }
}
