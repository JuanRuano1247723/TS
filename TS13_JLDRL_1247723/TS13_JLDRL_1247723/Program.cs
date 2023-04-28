using System;

namespace TS13_JLDRL_1247723
{
    class Program
    {
        class Persona
        {
            private string Nombre { get; set; }
            private string Apellido { get; set; }
            private int Edad { get; set; }
            private double Altura { get; set; }
            public Persona(string nom, string apell, int laedad, double laaltura)
            {
                Nombre = nom;
                Apellido = apell;
                Edad = laedad;
                Altura = laaltura;
            }
            public double Ametros()
            {
                Altura /= 100;
                return Altura;
            }

            public void MostrarDatos(){
                Console.WriteLine($"Altura: {Math.Round(Altura,2)}m");
                Console.WriteLine($"Nombre: {Nombre}");
                Console.WriteLine($"Apellido: {Apellido}");
                Console.WriteLine($"Edad: {Edad}\n");
            }

        }
        static void Main(string[] args)
        {
            try
            {
                string opcion;
                 do
                { 

                  Console.Write("Nombre: ");
                  string nombre = Console.ReadLine();
                  Console.Write("Apellido: ");
                  string apellido = Console.ReadLine();
                  Console.Write("Edad: ");
                  int edad = int.Parse(Console.ReadLine());
                  Console.Write("Altura (cm): ");
                  double altura = double.Parse(Console.ReadLine());

                  Persona personas = new Persona(nombre,apellido,edad,altura);
                  personas.Ametros();

                  Console.WriteLine("Quiere ver los datos guardados? ('s' = continuar)\n");
                  opcion = Console.ReadLine().ToLower();
                  personas.MostrarDatos();


                    Console.Write("Cantidad de filas: ");
                    int x = int.Parse(Console.ReadLine());

                    Console.Write("Cantidad de columnas: ");
                    int y = int.Parse(Console.ReadLine());

                    int[,] matriz = new int[x, y]; 

                    for (int i = 1; i <= x; i++)
                    {
                        for (int j = 1; j <= y; j++)
                        {
                            matriz[i - 1, j - 1] = i * j;
                        }
                    }

                    for (int i = 0; i < x; i++)
                    {
                        for (int j = 0; j < y; j++)
                        {
                            Console.Write(matriz[i, j] + "\t");
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine("Quiere ver los datos guardados? ('s' = continuar)\n");
                    opcion = Console.ReadLine().ToLower();

                } while (opcion == "s") ;
        }
            catch
            {
                Console.WriteLine("Opción no válida");
                Console.ReadKey();
                return;
            }
        }
    }
}
