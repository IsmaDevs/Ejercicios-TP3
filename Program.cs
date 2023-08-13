using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPN3Lab_I
{
    class Program
    {
        static void Ejercicio1()
        {

            int[] vector = { 20, 32, -10, 54, 102 }; 
            int suma = 0;

            for (int i = 0; i < vector.Length; i++) 
            {
                suma += vector[i]; 
            }

            Console.WriteLine("La suma de las posiciones del vector es: " + suma); 
        }
    
        static void Ejercicio2()
        {
            int[] vector = { 5, 12, 8, 23, 4 };
            int i = 0;

            while (i < vector.Length) 
            {
                int resultado = vector[i] - i; 

                i++; 

                Console.WriteLine($"La resta de la posición {i} es: {resultado}");
            }
        }

        static void Ejercicio3()
        {
            int[] vector = { 10, 6, 8, 9, 7, 10 };
            double suma = 0;
            int i = 0;
            double promedio;

            while (i < vector.Length) 
            {
                suma += vector[i++]; 
            }

            promedio = suma / 6; 

            Console.WriteLine($"El promedio de las notas del alumno es de: {promedio.ToString("0.00")}"); 
        }

        static void Ejercicio4()
        {
            int[] notas = new int[6]; 
            int suma = 0;
            
            for (int i = 0; i < notas.Length; i++) 
            {
                Console.Write($"Ingrese la nota {i + 1}: "); 
                notas[i] = int.Parse(Console.ReadLine()); 
                suma += notas[i]; 
            }

            double promedio = (double) suma / notas.Length; 
            Console.WriteLine($"El promedio del alumno es: {promedio.ToString("0.0")}"); 

            if (promedio >= 7)
            {
                Console.WriteLine("El alumno promocionó la materia."); 
            }
            else if (promedio >= 6) 
            {
                Console.WriteLine("El alumno quedó regular."); 
            }
            else
            {
                Console.WriteLine("El alumno desaprobó la materia."); 
            }


            Console.WriteLine();
        }

        static void Ejercicio5()
        {

            string[] nombres = { "camila", "roberto", "ricardo", "karina", "rosario", "nahuel", "carlos" }; 
        
            Console.WriteLine("Ingrese un nombre a buscar:"); 
            string nombreBuscado = Console.ReadLine(); 

            bool encontrado = false; 

            for (int i = 0; i < nombres.Length; i++) 
            {
                if (nombres[i] == nombreBuscado) 
                {
                    encontrado = true;

                    break;
                }
            }

            if (encontrado) 
            {
                Console.WriteLine("El nombre buscado sí está en el vector.");
            }
            else 
            {
                Console.WriteLine("El nombre buscado no está dentro del vector."); 
            }

        }

        static void Ejercicio6()
        {
        
            int Totalnumeros = 10; 
            int[] numeros = new int[Totalnumeros]; 


            Console.WriteLine("Ingrese un numero por favor "); 

            for (int i = 0; i < Totalnumeros; i++) 
            {
                Console.WriteLine();
                Console.Write($"Número {i + 1}: "); 

                numeros[i] = int.Parse(Console.ReadLine()); 
            }

            int numeroMaximo = numeros[0]; 

            int numeroMinimo = numeros[0]; 

            for (int i = 1; i < Totalnumeros; i++)
            {
                if (numeros[i] > numeroMaximo)

                    numeroMaximo = numeros[i]; 

                if (numeros[i] < numeroMinimo) 

                    numeroMinimo = numeros[i]; 
            }

            Console.WriteLine();
            Console.WriteLine($"El valor máximo es: {numeroMaximo}"); 
            Console.WriteLine($"El valor mínimo es: {numeroMinimo}"); 

        }

        static void Ejercicio7()
        {
            int[,] numeros = { { 2, 4, 6 }, { 10, 3, 9 }, { 4, 5, 1 } };
            int suma = 0;

            for (int i = 0; i < numeros.GetLength(0); i++) 
            {
                for (int j = 0; j < numeros.GetLength(1); j++)
                {
                    suma += numeros[i, j];
                }
            }

            Console.WriteLine("La suma de todos los elementos es: " + suma); 
    }

        static void Ejercicio8()
        {
            int[,] vector = { { 1, 2, 3, 4 }, { 5, 1, 0, 6 }, { 7, 8, 4, 2 }, { 4, 6, 9, 3 } };
            int fila2Suma = 0;
            int columna3Resta = 0;

            for (int i = 0; i < vector.GetLength(1); i++) 
            {
                fila2Suma += vector[1, i]; 
            }

            for (int i = 0; i < vector.GetLength(0); i++) 
            {
                columna3Resta -= vector[i, 2]; 
            }

            Console.WriteLine("La suma total de la fila número 2 es: " + fila2Suma);
            Console.WriteLine("La resta total de la columna número 3 es: " + columna3Resta);

            Console.ReadLine();
        }

        static void Ejercicio9()
        {
            int[,] matrizA = { { 14, 42, 32 }, { 22, 35, 48 }, { 39, 60, 97 } };
            int[,] matrizB = { { 32, 65, 19 }, { 12, 48, 72 }, { 23, 56, 80 } };

            int filas = matrizA.GetLength(0); 
            int columnas = matrizA.GetLength(1);

            int[,] matrizSuma = new int[filas, columnas]; 

            for (int i = 0; i < filas; i++) 
            {
                for (int j = 0; j < columnas; j++) 
                {
                    matrizSuma[i, j] = matrizA[i, j] + matrizB[i, j]; 
                }
            }

            Console.WriteLine("La matriz suma es:"); 

            for (int i = 0; i < filas; i++) 
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.Write(matrizSuma[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        static void Ejercicio10()
        {
            int[,] matrizA = { { 1, 4, 7 },
                               { 2, 5, 8 },
                               { 3, 6, 9 } };


            int[,] matrizB = { { 3, 6, 9 },
                               { 1, 4, 7 },
                               { 2, 5, 8 } };

    

            Console.WriteLine("La nueva Matriz es: "); 

            for (int i = 0; i < matrizA.GetLength(0); i++)
            {
                Console.WriteLine();

                for (int j = 0; j < matrizB.GetLength(1); j++)
                {
                    int nuevaMatriz = matrizA[i, j] * matrizB[i, j];

                    Console.Write(nuevaMatriz + " "); 
                     
                }
            }

        }

        static void Ejercicio11()
        {
            string[,] Frutas = { { "manzana", "pera", "uva" }, { "naranja", "pera", "kiwi" }, { "mango", "pera", "limon" } };

            string nombre;
            bool bandera = false; 

            Console.Write("Ingrese el nombre de una fruta: ");
            nombre = Console.ReadLine(); 

            for (int i = 0; i < Frutas.GetLength(0); i++)
            {
                for (int j = 0; j < Frutas.GetLength(1); j++) 
                {

                    if (nombre == Frutas[i, j]) 
                    {
                        bandera = true; 

                        break; 
                    }
                }

            }

            if (bandera == true) 
            { 
                Console.WriteLine();
                Console.WriteLine("La fruta SI se encuentra en la Matriz"); 
            }
            else 
            {
                Console.WriteLine();
                Console.WriteLine("La fruta NO se encuentra en la Matriz"); 
            }
        }

        static void Main(string[] args)
        {

            // Ejercicio1();
            // Ejercicio2();
            // Ejercicio3();
            // Ejercicio4();
            // Ejercicio5();
            // Ejercicio6(); 
            // Ejercicio7();
            // Ejercicio8();
            // Ejercicio9();
            // Ejercicio10();
            // Ejercicio11();


            Console.ReadKey();

        }
    }
}
