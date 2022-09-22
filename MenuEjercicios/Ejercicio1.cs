using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuEjercicios
{
    public class Ejercicio1
    {
        string Nombre;
        string Email;

        public Ejercicio1(string nombre, string email)
        {
            this.Nombre = nombre;
            this.Email = email;
        }

        public void ImprimriNombreYCorreo()
        {
            Console.WriteLine($"Nombre: {this.Nombre}");
            Console.WriteLine($"Email: {this.Email}");
        }
    }
}
