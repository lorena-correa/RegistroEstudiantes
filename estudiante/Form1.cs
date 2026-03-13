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

            string nombre = txtNombre.Text.Trim();
            if (string.IsNullOrWhiteSpace(nombre) || nombre.Length < 3 || !nombre.All(c => char.IsLetter(c) || c == ' '))
            {
                MessageBox.Show("El nombre debe contener letras y tener al menos 3 caracteres.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(txtEdad.Text, out int edad))
            {
                MessageBox.Show("La edad debe de ser numérica.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
                
            }
            if (edad < 15 || edad > 100)
            {
                MessageBox.Show("La edad debe ser mayor que 15 y menor de 100 años.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (!double.TryParse(txtPromedio.Text, out double promedio) || promedio < 0 || promedio > 10)
            {
                MessageBox.Show("El promedio debe ser mayor a 0 y menor o igual a 10.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Verificar si el código ya existe en el estudiantes
            if (estudiantes.Any(item => item.Nombre == nombre))
            {
                MessageBox.Show("El nombre de este estudiante ya existe en el listado. Debe ser único, modifíquelo.", "Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Crear Objeto
            RegistroE nuevo = new RegistroE(nombre, edad, promedio);

            // Agregar al listado de estudiantes
            estudiantes.Add(nuevo);

            // Mostrar los datos en ListBox
            listBoxEstudiantes.Items.Add(nuevo.ToString());

            // Limpiar campos
            txtNombre.Clear();
            txtEdad.Clear();
            txtPromedio.Clear();

        }
    }
}
