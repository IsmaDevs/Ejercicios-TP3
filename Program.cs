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

            for (int i = 0; i < vector.Length; i++) // hacemos un barrido del vector
            {
                suma += vector[i]; // vamos sumando las posiciones
            }

            Console.WriteLine("La suma de las posiciones del vector es: " + suma); // mostramos por pantalla la suma total de las posiciones.
        }
    
        static void Ejercicio2()
        {
            int[] vector = { 5, 12, 8, 23, 4 };
            int i = 0;

            while (i < vector.Length) // hacemos un ciclo while en donde i tiene que ser menor a la longitud del vector
            {
                int resultado = vector[i] - i; // declaramos una variable de tipo int llamada resultado que 
                                               // acumulara la resta de las posiciones del vector

                i++; // Hacemos que la variable i vaya recorriendo las posiciones


                Console.WriteLine($"La resta de la posición {i} es: {resultado}"); // Mostramos el numero de posiciones y el resultado de la resta
                                                                                   // de esa posición.
            }
        }

        static void Ejercicio3()
        {
            int[] vector = { 10, 6, 8, 9, 7, 10 };
            double suma = 0;
            int i = 0;
            double promedio;

            while (i < vector.Length) // hacemos un ciclo while donde i tiene que ser menor a la longitud del vector
            {
                suma += vector[i++]; // vamos sumando las posiciones
            }

            promedio = suma / 6; // la suma total de las posiciones la dividimos por 6 para que nos de el promedio

            Console.WriteLine($"El promedio de las notas del alumno es de: {promedio.ToString("0.00")}"); // Mostramos el promedio por pantalla
        }

        static void Ejercicio4()
        {
            int[] notas = new int[6]; // Hacemos un vector de forma explicita.
            int suma = 0;
            
            for (int i = 0; i < notas.Length; i++) // hacemos un for que ira recorriendo las posiciones del vector
            {
                Console.Write($"Ingrese la nota {i + 1}: "); // pedimos que ingrese la nota de la posición que se ira mostrando
                notas[i] = int.Parse(Console.ReadLine()); // vamos acumulando las notas ingresadas por el usuario
                suma += notas[i]; // las vamos sumando y asignando en la variable suma
            }

            double promedio = (double) suma / notas.Length; // sacamos el promedio diviendo la suma por la longitud del vector
            Console.WriteLine($"El promedio del alumno es: {promedio.ToString("0.0")}"); // mostramos por pantalla el promedio del alumno

            if (promedio >= 7) // hacemos un if en el cual si el promedio es mayor o igual a 7
            {
                Console.WriteLine("El alumno promocionó la materia."); // le mostramos por pantalla al usuario que promociono 
            }
            else if (promedio >= 6) // hacemos un else if en el que si el promedio es mayor o igual a 6
            {
                Console.WriteLine("El alumno quedó regular."); // le mostraremos por pantalla que el alumno quedo regular
            }
            else // por ultimo hacemos un else si el promedio fue menor a 6
            {
                Console.WriteLine("El alumno desaprobó la materia."); // le mostramos por pantalla que el alumno desaprobó.
            }


            Console.WriteLine();
        }

        static void Ejercicio5()
        {

            string[] nombres = { "camila", "roberto", "ricardo", "karina", "rosario", "nahuel", "carlos" }; 

            Console.WriteLine("Ingrese un nombre a buscar:"); // Le pedimos que ingrese el nombre que desea buscar.
            string nombreBuscado = Console.ReadLine(); // Almacenamos el nombre ingresado por el usuario en la variable "nombreBuscado"

            bool encontrado = false; // Hacemos una variable bool llamada encontrado con un valor de false.

            for (int i = 0; i < nombres.Length; i++) // hacemos un for donde recorreremos el vector
            {
                if (nombres[i] == nombreBuscado) // hacemos un if en el cual si el nombre ingresado es igual a los del vector
                {
                    encontrado = true; // la bandera o el valor bool pasara a true

                    break; // hacemos un break para cortar el ciclo
                }
            }

            if (encontrado) // hacemos un if fuera del for
            {
                Console.WriteLine("El nombre buscado sí está en el vector."); // mostramos por pantalla al usuario que el nombre que ingreso si esta en el vector.
            }
            else // hacemos un else por si no es el correcto
            {
                Console.WriteLine("El nombre buscado no está dentro del vector."); // le mostramos por pantalla que el nombre ingresado no esta en el vector.
            }

        }

        static void Ejercicio6()
        {
        
            int Totalnumeros = 10; // hacemos una variable llamada Totalnumeros con un valor de 10 y de tipo entero
            int[] numeros = new int[Totalnumeros]; // declaramos un vector de forma explicita y su longitud sera la variable Totalnumeros


            Console.WriteLine("Ingrese un numero por favor "); // le pedimos al usuario que ingrese un numero

            for (int i = 0; i < Totalnumeros; i++) // hacemos un barrido del vector
            {
                Console.WriteLine();
                Console.Write($"Número {i + 1}: "); // le vamos mostrando los numeros y el numero de cantidad (las cantidades son las posiciones)

                numeros[i] = int.Parse(Console.ReadLine()); // almacenamos los numeros ingresados en el vector numeros
            }

            int numeroMaximo = numeros[0]; // declaramos una variable de tipo entero llamda "numeroMaximo" en el cual
                                           // tomara el valor del vector de la posición [0].

            int numeroMinimo = numeros[0]; // declaramos otra variable de tipo entero pero llamda "numeroMinimo"
                                           // que también tomara de valor la posición [0] del vector. 

            for (int i = 1; i < Totalnumeros; i++) // hacemos un for en donde el valor de i debe ser menor al valor de Totalnumeros
            {
                if (numeros[i] > numeroMaximo) // hacemos un if en donde el vector tiene que ser explicitamente mayor al valor de numeroMaximo

                    numeroMaximo = numeros[i]; // aquí numeroMaximo tomara el valor del numero mayor del vector

                if (numeros[i] < numeroMinimo) // hacemos otro if en donde el vector tiene que ser explicitamente menor al valor de numeroMinimo

                    numeroMinimo = numeros[i]; // y aquí la variable numeroMinimo tomara el valor del numero mas chico del vector
            }

            Console.WriteLine();
            Console.WriteLine($"El valor máximo es: {numeroMaximo}"); // mostramos por pantalla al usuario el valor maximo que ingreso
            Console.WriteLine($"El valor mínimo es: {numeroMinimo}"); // y el valor minimo que ingreso.

        }

        static void Ejercicio7()
        {
            int[,] numeros = { { 2, 4, 6 }, { 10, 3, 9 }, { 4, 5, 1 } };
            int suma = 0;

            for (int i = 0; i < numeros.GetLength(0); i++) // hacemos un for en el que hara un barrido de la fila del vector
            {
                for (int j = 0; j < numeros.GetLength(1); j++) // y aquí hacemos otro for que hara un barrido de la columna
                {
                    suma += numeros[i, j]; // sumamos en este f or las filas y las columnas y lo vamos asignando en la variable "suma"
                }
            }

            Console.WriteLine("La suma de todos los elementos es: " + suma); // mostramos por pantalla la suma total.
    }

        static void Ejercicio8()
        {
            int[,] vector = { { 1, 2, 3, 4 }, { 5, 1, 0, 6 }, { 7, 8, 4, 2 }, { 4, 6, 9, 3 } };
            int fila2Suma = 0;
            int columna3Resta = 0;

            // Suma total de la fila número 2

            for (int i = 0; i < vector.GetLength(1); i++) // hacemos un for que hara un barrido de la columna de la matriz
            {
                fila2Suma += vector[1, i]; // en la variable fila2Suma se le ira asignando el valor de la suma de la matriz de la fila 2.
            }

            // Resta total de la columna número 3

            for (int i = 0; i < vector.GetLength(0); i++) // aquí también hacemos un for que hara un barrido de la fila de la matriz
            {
                columna3Resta -= vector[i, 2]; // vamos asignandole a la variable columna3Resta el resultado de la resta de la columna
            }

            Console.WriteLine("La suma total de la fila número 2 es: " + fila2Suma); // le mostramos por pantalla al usuario la suma de la fila 2
            Console.WriteLine("La resta total de la columna número 3 es: " + columna3Resta); // y la resta total de la columna 3 de la matriz

            Console.ReadLine();
        }

        static void Ejercicio9()
        {
            int[,] matrizA = { { 14, 42, 32 }, { 22, 35, 48 }, { 39, 60, 97 } };
            int[,] matrizB = { { 32, 65, 19 }, { 12, 48, 72 }, { 23, 56, 80 } };

            int filas = matrizA.GetLength(0); // declaramos una variable de tipo entero que tomara el valor de la longitud de la fila de la matrizA
            int columnas = matrizA.GetLength(1); // y aquí declaramos otra variable de tipo entero que tomara el valor de la longitud de la columna

            int[,] matrizSuma = new int[filas, columnas]; // Declaramos una matriz de tendra los valores de las filas y columnas

            for (int i = 0; i < filas; i++) // hacemos un for para recorrer la fila
            {
                for (int j = 0; j < columnas; j++) // hacemos otro for para recorrer la columna
                {
                    matrizSuma[i, j] = matrizA[i, j] + matrizB[i, j]; // le damos el valor a la MatrizSuma el resultado de la suma de la matrizA con la matrizB
                }
            }

            Console.WriteLine("La matriz suma es:"); // mostramos por pantalla el resultado de la nueva matriz

            for (int i = 0; i < filas; i++) // hacemos un for para recorrer las filas
            {
                for (int j = 0; j < columnas; j++) // hacemos otro for para recorrer las columnas
                {
                    Console.Write(matrizSuma[i, j] + " "); // y vamos mostrando por pantalla las filas y columnas de la matriz.
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

    

            Console.WriteLine("La nueva Matriz es: "); // mostramos por pantalla al usuario la nueva matriz

            for (int i = 0; i < matrizA.GetLength(0); i++) // hacemos un for que hara un barrido de la filas de la matrizA
            {
                Console.WriteLine();

                for (int j = 0; j < matrizB.GetLength(1); j++) // hacemos otro for que hara un barrido/recorrido de las columnas de la matriz B
                {
                    int nuevaMatriz = matrizA[i, j] * matrizB[i, j]; // declaramos una variable de tipo entero llamada nuevaMatriz que se le asignara
                                                                     // el valor de la multiplicación de la matrizA con la matrizB

                    Console.Write(nuevaMatriz + " "); // mostramos por pantalla el resultado (valor) de nuevaMatriz
                     
                }
            }

        }

        static void Ejercicio11()
        {
            string[,] Frutas = { { "manzana", "pera", "uva" }, { "naranja", "pera", "kiwi" }, { "mango", "pera", "limon" } };

            string nombre; // declaramos una variable de tipo caracter que se llamara "nombre"
            bool bandera = false; // declaramos una bandera de tipo bool con un valor de false

            Console.Write("Ingrese el nombre de una fruta: "); // le pedimos por pantalla al usuario que ingrese el nombre de la fruta
            nombre = Console.ReadLine(); // tomamos o almacenamos el nombre de la fruta en la variable

            for (int i = 0; i < Frutas.GetLength(0); i++) // hacemos un recorrido/barrido de la filas de la matriz Frutas
            {
                for (int j = 0; j < Frutas.GetLength(1); j++) // hacemos otro for que hara un barrido de las columnas de la matriz
                {

                    if (nombre == Frutas[i, j]) // hacemos un if en el cual si el nombre de la fruta que ingrso el usuario 
                                                // es igual al nombre de las frutas que se encuentran en la matriz
                    {
                        bandera = true; // si el nombre es igual la bandera tendra un valor de true

                        break; // hacemos un break; para cortar el ciclo
                    }
                }

            }

            if (bandera == true) // hacemos un if fuera de los for en el cual si la bandera es igual a true
            { 
                Console.WriteLine();
                Console.WriteLine("La fruta SI se encuentra en la Matriz"); // mostramos por pantalla que la fruta que ingreso si esta en la matriz
            }
            else // hacemos un else por si no esta
            {
                Console.WriteLine();
                Console.WriteLine("La fruta NO se encuentra en la Matriz"); // le mostramos por pantalla al usuario que la fruta no esta en la matriz.
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
