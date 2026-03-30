internal class RegistroE
{
    public string Nombre { get; set; }
    public int Edad { get; set; }
    public double Promedio { get; set; }

    public RegistroE(string nombre, int edad, double promedio)
    {
        ValidarNombre(nombre);
        ValidarEdad(edad);
        ValidarPromedio(promedio);

        Nombre = nombre;
        Edad = edad;
        Promedio = promedio;
    }

    private void ValidarNombre(string nombre)
    {
        if (string.IsNullOrWhiteSpace(nombre) || nombre.Length < 3 || !nombre.All(c => char.IsLetter(c) || c == ' '))
        {
            throw new Exception("El nombre debe contener solo letras y mínimo 3 caracteres.");
        }
    }

    private void ValidarEdad(int edad)
    {
        if (edad < 15 || edad > 100)
        {
            throw new Exception("La edad debe estar entre 15 y 100.");
        }
    }

    private void ValidarPromedio(double promedio)
    {
        if (promedio < 0 || promedio > 10)
        {
            throw new Exception("El promedio debe estar entre 0 y 10.");
        }
    }

    public override string ToString()
    {
        return $"Nombre: {Nombre}, Edad: {Edad}, Promedio: {Promedio}";
    }
}