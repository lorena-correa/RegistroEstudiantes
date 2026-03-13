using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estudiante
{
    internal class RegistroE
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public double Promedio { get; set; }
       
        public RegistroE(string nombre, int edad, double promedio)
        {
            Nombre = nombre;
            Edad = edad;
            Promedio = promedio;
        }
        public override string ToString()
        {
            return $"Nombre: {Nombre}, Edad: {Edad}, Promedio: {Promedio}";
        }
    }
}
