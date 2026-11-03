using System.Collections.Generic;
using System.Text;

namespace CatalogoRecursividad
{
    /// <summary>
    /// Catálogo de ejercicios: cada problema tiene su versión ITERATIVA
    /// (original) y su versión RECURSIVA (convertida).
    /// Las versiones recursivas aceptan un StringBuilder opcional ("traza")
    /// donde se documenta cada llamada indicando si es CASO BASE o CASO RECURSIVO.
    /// </summary>
    public static class Recursividad
    {
        // ------------------------------------------------------------
        // 1. FACTORIAL
        // ------------------------------------------------------------

        /// <summary>Factorial con ciclo for.</summary>
        public static long FactorialIterativo(int n)
        {
            long resultado = 1;
            for (int i = 2; i <= n; i++)
            {
                resultado *= i;
            }
            return resultado;
        }

        /// <summary>
        /// Factorial recursivo.
        /// CASO BASE: n &lt;= 1 devuelve 1.
        /// CASO RECURSIVO: n * Factorial(n - 1).
        /// </summary>
        public static long FactorialRecursivo(int n, StringBuilder traza = null, int nivel = 0)
        {
            string sangria = new string(' ', nivel * 2);

            if (n <= 1) // CASO BASE
            {
                traza?.AppendLine($"{sangria}Factorial({n}) -> CASO BASE = 1");
                return 1;
            }

            // CASO RECURSIVO
            traza?.AppendLine($"{sangria}Factorial({n}) -> CASO RECURSIVO = {n} * Factorial({n - 1})");
            long resultado = n * FactorialRecursivo(n - 1, traza, nivel + 1);
            traza?.AppendLine($"{sangria}Factorial({n}) devuelve {resultado}");
            return resultado;
        }

        // ------------------------------------------------------------
        // 2. FIBONACCI
        // ------------------------------------------------------------

        /// <summary>Contador de llamadas de la versión recursiva (para análisis).</summary>
        public static long LlamadasFibonacci = 0;

        /// <summary>Fibonacci con ciclo for.</summary>
        public static long FibonacciIterativo(int n)
        {
            if (n <= 1) return n;

            long anterior = 0, actual = 1;
            for (int i = 2; i <= n; i++)
            {
                long siguiente = anterior + actual;
                anterior = actual;
                actual = siguiente;
            }
            return actual;
        }

        /// <summary>
        /// Fibonacci recursivo.
        /// CASO BASE: n &lt;= 1 devuelve n (0 o 1).
        /// CASO RECURSIVO: Fib(n - 1) + Fib(n - 2).
        /// </summary>
        public static long FibonacciRecursivo(int n, StringBuilder traza = null, int nivel = 0)
        {
            LlamadasFibonacci++;
            string sangria = new string(' ', nivel * 2);

            if (n <= 1) // CASO BASE
            {
                traza?.AppendLine($"{sangria}Fib({n}) -> CASO BASE = {n}");
                return n;
            }

            // CASO RECURSIVO
            traza?.AppendLine($"{sangria}Fib({n}) -> CASO RECURSIVO = Fib({n - 1}) + Fib({n - 2})");
            long resultado = FibonacciRecursivo(n - 1, traza, nivel + 1)
                           + FibonacciRecursivo(n - 2, traza, nivel + 1);
            traza?.AppendLine($"{sangria}Fib({n}) devuelve {resultado}");
            return resultado;
        }

        // ------------------------------------------------------------
        // 3. TORRES DE HANOI
        // ------------------------------------------------------------

        /// <summary>
        /// Torres de Hanoi iterativo (de la torre A a la torre C).
        /// Regla: los movimientos impares mueven el disco 1 en ciclo
        /// (A-C-B si n es impar, A-B-C si n es par); los pares hacen el
        /// único movimiento legal que no involucra al disco 1.
        /// </summary>
        public static List<string> HanoiIterativo(int n)
        {
            var movimientos = new List<string>();
            char[] nombres = { 'A', 'B', 'C' };

            var torres = new Stack<int>[3];
            for (int i = 0; i < 3; i++) torres[i] = new Stack<int>();
            for (int d = n; d >= 1; d--) torres[0].Push(d);

            int[] ciclo = (n % 2 == 1) ? new[] { 0, 2, 1 } : new[] { 0, 1, 2 };
            int pos = 0; // posición del disco 1 dentro del ciclo
            long total = (1L << n) - 1;

            for (long m = 1; m <= total; m++)
            {
                int origen, destino;

                if (m % 2 == 1)
                {
                    // Mover el disco más pequeño
                    origen = ciclo[pos];
                    pos = (pos + 1) % 3;
                    destino = ciclo[pos];
                }
                else
                {
                    // Único movimiento legal sin el disco más pequeño
                    int p = ciclo[pos];
                    int x = (p + 1) % 3, y = (p + 2) % 3;

                    if (torres[x].Count == 0) { origen = y; destino = x; }
                    else if (torres[y].Count == 0) { origen = x; destino = y; }
                    else if (torres[x].Peek() < torres[y].Peek()) { origen = x; destino = y; }
                    else { origen = y; destino = x; }
                }

                int disco = torres[origen].Pop();
                torres[destino].Push(disco);
                movimientos.Add($"Mover disco {disco} de {nombres[origen]} a {nombres[destino]}");
            }
            return movimientos;
        }

        /// <summary>
        /// Torres de Hanoi recursivo.
        /// CASO BASE: n == 1, se mueve el disco directamente.
        /// CASO RECURSIVO: mover n-1 discos al auxiliar, mover el disco n
        /// al destino y mover los n-1 discos del auxiliar al destino.
        /// </summary>
        public static void HanoiRecursivo(int n, char origen, char destino, char auxiliar,
                                          List<string> movimientos,
                                          StringBuilder traza = null, int nivel = 0)
        {
            string sangria = new string(' ', nivel * 2);

            if (n == 1) // CASO BASE
            {
                traza?.AppendLine($"{sangria}Hanoi(1, {origen}->{destino}) -> CASO BASE: mover disco 1");
                movimientos.Add($"Mover disco 1 de {origen} a {destino}");
                return;
            }

            // CASO RECURSIVO
            traza?.AppendLine($"{sangria}Hanoi({n}, {origen}->{destino}) -> CASO RECURSIVO");
            HanoiRecursivo(n - 1, origen, auxiliar, destino, movimientos, traza, nivel + 1);

            movimientos.Add($"Mover disco {n} de {origen} a {destino}");
            traza?.AppendLine($"{sangria}  (se mueve el disco {n}: {origen}->{destino})");

            HanoiRecursivo(n - 1, auxiliar, destino, origen, movimientos, traza, nivel + 1);
        }

        // ------------------------------------------------------------
        // 4. SUMA DE ARREGLO
        // ------------------------------------------------------------

        /// <summary>Suma de un arreglo con ciclo foreach.</summary>
        public static long SumaIterativa(int[] arreglo)
        {
            long suma = 0;
            foreach (int valor in arreglo)
            {
                suma += valor;
            }
            return suma;
        }

        /// <summary>
        /// Suma recursiva.
        /// CASO BASE: i == longitud del arreglo, la suma es 0.
        /// CASO RECURSIVO: arreglo[i] + Suma(i + 1).
        /// </summary>
        public static long SumaRecursiva(int[] arreglo, int i = 0, StringBuilder traza = null)
        {
            string sangria = new string(' ', i * 2);

            if (i == arreglo.Length) // CASO BASE
            {
                traza?.AppendLine($"{sangria}Suma(i={i}) -> CASO BASE = 0 (ya no hay elementos)");
                return 0;
            }

            // CASO RECURSIVO
            traza?.AppendLine($"{sangria}Suma(i={i}) -> CASO RECURSIVO = a[{i}] ({arreglo[i]}) + Suma(i={i + 1})");
            long resultado = arreglo[i] + SumaRecursiva(arreglo, i + 1, traza);
            traza?.AppendLine($"{sangria}Suma(i={i}) devuelve {resultado}");
            return resultado;
        }

        // ------------------------------------------------------------
        // 5. BÚSQUEDA LINEAL
        // ------------------------------------------------------------

        /// <summary>Búsqueda lineal con ciclo for. Devuelve el índice o -1.</summary>
        public static int BusquedaIterativa(int[] arreglo, int objetivo)
        {
            for (int i = 0; i < arreglo.Length; i++)
            {
                if (arreglo[i] == objetivo) return i;
            }
            return -1;
        }

        /// <summary>
        /// Búsqueda lineal recursiva.
        /// CASO BASE 1: i >= longitud, no se encontró (-1).
        /// CASO BASE 2: arreglo[i] == objetivo, se devuelve i.
        /// CASO RECURSIVO: buscar en la posición i + 1.
        /// </summary>
        public static int BusquedaRecursiva(int[] arreglo, int objetivo, int i = 0, StringBuilder traza = null)
        {
            string sangria = new string(' ', i * 2);

            if (i >= arreglo.Length) // CASO BASE 1
            {
                traza?.AppendLine($"{sangria}Buscar(i={i}) -> CASO BASE 1: se acabó el arreglo, devuelve -1");
                return -1;
            }

            if (arreglo[i] == objetivo) // CASO BASE 2
            {
                traza?.AppendLine($"{sangria}Buscar(i={i}) -> CASO BASE 2: a[{i}] = {arreglo[i]} es el objetivo, devuelve {i}");
                return i;
            }

            // CASO RECURSIVO
            traza?.AppendLine($"{sangria}Buscar(i={i}) -> CASO RECURSIVO: a[{i}] = {arreglo[i]} no es {objetivo}, buscar en i={i + 1}");
            return BusquedaRecursiva(arreglo, objetivo, i + 1, traza);
        }
    }
}
