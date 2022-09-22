using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuEjercicios
{
    public class MainMenu
    {
        public void MenuPrincipal()
        {
            Console.WriteLine("BIENVENIDO A SU MENU INTERACTIVO");
            Console.WriteLine("Elige una opcion");
            Console.WriteLine("1-Ejercicio 1");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("Elegiste la opcion 1");
                    break;
                default:
                    Console.WriteLine("Opcion no valida");
                    break;
            }
        }
    }
}
