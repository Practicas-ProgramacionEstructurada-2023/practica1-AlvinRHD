using System;
namespace Myapp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declaración de las variables
            string nombre = "Alvin Ezequiel Rosales Hernández"; //Almacena mi nombre como una cadena de caracteres
            int edad = 19 ; //Guarda la edad como numero entero
            char genero = 'M'; //Guarda como un caracter
            string direccion = "Col. Cocal, santiago de maría Usulútan";
            string telefono = "78815424";
            string universidad = "Universidad de Oriente UNIVO";
            string carrera = "Tec. En Desarrollo de Software";
            string facultad = "Ingenieria y arquitectura";
            string ciclo = "Ciclo 02";
            bool estudianteBecado = true; 

            //Mostramos la inf
            Console.WriteLine("Información Personal:"); 
            Console.WriteLine("Mi nombre es: " + nombre); //Concatenación para mostrar nuestro nombre y así sucecivamente con edad, genero etc.
            Console.WriteLine("Mi edad es: " + edad);
            Console.WriteLine("Genero: " + genero);
            Console.WriteLine("Mi dirección es: " + direccion);
            Console.WriteLine("Mi numero de telefono es: " + telefono);
            Console.WriteLine("Mi universidad de estudio es: " + universidad);
            Console.WriteLine("Mi carrera de estudio es: " + carrera);
            Console.WriteLine("Faculdad a la que pertenezco: " + facultad);
            Console.WriteLine("Mi ciclo de estudio es: " + ciclo);
            Console.WriteLine("Eres estudiante becado?: " + estudianteBecado);

        }
    }
    
}