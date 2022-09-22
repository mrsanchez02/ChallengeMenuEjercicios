namespace MenuEjercicios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
        static void Menu()
        {
            Console.WriteLine("********************************");
            Console.WriteLine("BIENVENIDO A SU MENU INTERACTIVO");
            Console.WriteLine("********************************");
            Console.WriteLine("Por favor, Eliga una opción");
            Console.WriteLine("1-Ejercicio 1");
            Console.WriteLine("2-Ejercicio 2");
            Console.WriteLine("3-Ejercicio 3");
            Console.WriteLine("4-Ejercicio 4");
            Console.WriteLine("5-Exit");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("Ejercicio 1 - Programa que imprima su nombre y su correo electronico.");
                    string nombre, email;
                    Console.WriteLine("Ingrese su nombre:");
                    nombre = Console.ReadLine();
                    Console.WriteLine("Ingrese su email:");
                    email = Console.ReadLine();
                    Ejercicio1 ejercicio1 = new Ejercicio1(nombre, email);
                    ejercicio1.ImprimriNombreYCorreo();
                    Menu();
                    break;
                case "2":
                    Console.WriteLine("Ejercicio 2 - Programa que imprima los numeros del 1 al 100.");
                    Ejercicio2 ejercicio2 = new Ejercicio2();
                    ejercicio2.Imprimir1Al100();
                    Menu();
                    break;
                case "3":
                    Console.WriteLine("Ejercicio 3 - Programa que imprima los numeros pares del 1 al 20.");
                    Ejercicio3 ejercicio3= new Ejercicio3();
                    ejercicio3.ImprimirPares();
                    Menu();
                    break;
                case "4":
                    Console.WriteLine("Ejercicio 4 - Programa que imprima la tabla de multiplicar del 2, 3, 4, 5 y 6.");
                    Ejercicio4 ejercicio4 = new Ejercicio4();
                    ejercicio4.TablaDeMultiplicar();
                    Menu();
                    break;
                case "5":
                    Console.WriteLine("Saliendo...");
                    break;
                default:
                    Console.WriteLine("Opcion no valida");
                    Menu();
                    break;
            }
        }
    }
}