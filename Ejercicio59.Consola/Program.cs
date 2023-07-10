namespace Ejercicio59.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double PromedioEdad;
            int CantidadPersonas, EdadMayor, EdadMenor, edad, Personas2540;
            EdadMayor = 0;
            EdadMenor = 200;
            PromedioEdad = 0;
            Personas2540 = 0;

            Console.Write("Ingrese la cantidad de personas:");
            CantidadPersonas=int.Parse(Console.ReadLine());

            if (CantidadPersonas <= 0)
            {
                Console.WriteLine("La cantidad de personas tiene que ser mayor a 0");
            }
            else
            {
                for (int contador = 1; contador <= CantidadPersonas; contador++)
                {
                    edad = 0;
                    do
                    {
                        Console.WriteLine("Ingrese la edad de la persona:");
                        edad = int.Parse(Console.ReadLine());
                        if (edad <= 0)
                        {
                            Console.WriteLine("La edad ingresada debe ser mayor a 0");
                        }
                    } while (edad <= 0);
                    if (edad > EdadMayor)
                    {
                        EdadMayor = edad;
                    }
                    if (edad < EdadMenor)
                    {
                        EdadMenor = edad;
                    }
                    PromedioEdad = (PromedioEdad + edad);
                    if (edad >= 25 && edad <= 40)
                    {
                        Personas2540 = Personas2540 + 1;
                    }
                }
                PromedioEdad = PromedioEdad / CantidadPersonas;
                Console.WriteLine($"La persona con mayor edad ingresada es de {EdadMayor} años");
                Console.WriteLine($"La persona con menor edad ingresada es de {EdadMenor} años");
                Console.WriteLine($"El promedio de edad entre las {CantidadPersonas} personas es de {PromedioEdad} años");
                Console.WriteLine($"La cantidad de personas entre 25 y 40 es de  {Personas2540} personas");



            }

        }
    }
}