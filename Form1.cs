using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CatalogoRecursividad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // ============================================================
        // EVENTOS
        // ============================================================

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbEjercicio.SelectedIndex = 0; // dispara ConfigurarEjercicio()
        }

        private void cmbEjercicio_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConfigurarEjercicio();
        }

        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            try
            {
                switch (cmbEjercicio.SelectedIndex)
                {
                    case 0: EjecutarFactorial(); break;
                    case 1: EjecutarFibonacci(); break;
                    case 2: EjecutarHanoi(); break;
                    case 3: EjecutarSuma(); break;
                    case 4: EjecutarBusqueda(); break;
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Dato no válido",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            ConfigurarEjercicio();
        }

        // ============================================================
        // CONFIGURACIÓN DE LA INTERFAZ SEGÚN EL EJERCICIO
        // ============================================================

        /// <summary>
        /// Ajusta etiquetas, valores de ejemplo y el texto de caso base /
        /// caso recursivo según el ejercicio elegido, y limpia resultados.
        /// </summary>
        private void ConfigurarEjercicio()
        {
            bool usaSegundaEntrada = false;
            string base_ = "", recursivo = "";

            switch (cmbEjercicio.SelectedIndex)
            {
                case 0: // Factorial
                    lblEntrada1.Text = "Número n (0 a 20):";
                    txtEntrada1.Text = "5";
                    base_ = "n <= 1 devuelve 1 (aquí termina la recursión).";
                    recursivo = "n * Factorial(n - 1)  (el problema se reduce en 1).";
                    break;

                case 1: // Fibonacci
                    lblEntrada1.Text = "Posición n (0 a 35):";
                    txtEntrada1.Text = "6";
                    base_ = "n <= 1 devuelve n (Fib(0) = 0 y Fib(1) = 1).";
                    recursivo = "Fib(n - 1) + Fib(n - 2)  (dos llamadas recursivas).";
                    break;

                case 2: // Hanoi
                    lblEntrada1.Text = "Número de discos (1 a 10):";
                    txtEntrada1.Text = "3";
                    base_ = "n == 1: se mueve el disco directamente de origen a destino.";
                    recursivo = "Mover n-1 discos al auxiliar, mover el disco n al destino y mover los n-1 discos al destino.";
                    break;

                case 3: // Suma de arreglo
                    lblEntrada1.Text = "Arreglo (números separados por coma):";
                    txtEntrada1.Text = "3, 5, 8, 12, 20";
                    base_ = "i == longitud del arreglo: ya no hay elementos, la suma es 0.";
                    recursivo = "arreglo[i] + Suma(arreglo, i + 1)  (se avanza una posición).";
                    break;

                case 4: // Búsqueda lineal
                    lblEntrada1.Text = "Arreglo (números separados por coma):";
                    txtEntrada1.Text = "4, 7, 9, 2, 15";
                    lblEntrada2.Text = "Valor a buscar:";
                    txtEntrada2.Text = "9";
                    usaSegundaEntrada = true;
                    base_ = "(1) i >= longitud: no se encontró, devuelve -1.  (2) arreglo[i] == objetivo: devuelve i.";
                    recursivo = "arreglo[i] != objetivo: se busca en la posición i + 1.";
                    break;
            }

            lblEntrada2.Visible = usaSegundaEntrada;
            txtEntrada2.Visible = usaSegundaEntrada;
            if (!usaSegundaEntrada) txtEntrada2.Clear();

            lblCasoBase.Text = "Caso base: " + base_;
            lblCasoRecursivo.Text = "Caso recursivo: " + recursivo;

            txtIterativo.Clear();
            txtRecursivo.Clear();
            lblTiempoIter.Text = "Tiempo: -";
            lblTiempoRec.Text = "Tiempo: -";
            lblComparacion.Text = "Comparación: -";
            lblComparacion.ForeColor = SystemColors.ControlText;
            rtbTraza.Clear();
        }

        // ============================================================
        // EJERCICIOS
        // ============================================================

        private void EjecutarFactorial()
        {
            int n = LeerEntero(txtEntrada1.Text, 0, 20, "n");

            long resIter = 0, resRec = 0;
            double tIter = Medir(() => resIter = Recursividad.FactorialIterativo(n));
            double tRec = Medir(() => resRec = Recursividad.FactorialRecursivo(n));

            var traza = new StringBuilder();
            Recursividad.FactorialRecursivo(n, traza);

            MostrarResultados(resIter.ToString("N0"), resRec.ToString("N0"),
                              resIter == resRec, tIter, tRec, traza.ToString());
        }

        private void EjecutarFibonacci()
        {
            int n = LeerEntero(txtEntrada1.Text, 0, 35, "n");

            long resIter = 0, resRec = 0;
            double tIter = Medir(() => resIter = Recursividad.FibonacciIterativo(n));

            Recursividad.LlamadasFibonacci = 0;
            double tRec = Medir(() => resRec = Recursividad.FibonacciRecursivo(n));
            long llamadas = Recursividad.LlamadasFibonacci;

            var traza = new StringBuilder();
            if (n <= 8)
                Recursividad.FibonacciRecursivo(n, traza);
            else
                traza.AppendLine("(Traza omitida para n > 8: tendría demasiadas líneas.)");

            traza.AppendLine();
            traza.AppendLine($"Llamadas recursivas realizadas: {llamadas:N0}");
            traza.AppendLine("Nota: la versión recursiva repite cálculos, por eso es más lenta que la iterativa.");

            MostrarResultados(resIter.ToString("N0"), resRec.ToString("N0"),
                              resIter == resRec, tIter, tRec, traza.ToString());
        }

        private void EjecutarHanoi()
        {
            int n = LeerEntero(txtEntrada1.Text, 1, 10, "discos");

            List<string> movIter = null;
            var movRec = new List<string>();

            double tIter = Medir(() => movIter = Recursividad.HanoiIterativo(n));
            double tRec = Medir(() => Recursividad.HanoiRecursivo(n, 'A', 'C', 'B', movRec));

            var traza = new StringBuilder();
            if (n <= 4)
            {
                var descarte = new List<string>();
                traza.AppendLine("--- Llamadas recursivas ---");
                Recursividad.HanoiRecursivo(n, 'A', 'C', 'B', descarte, traza);
                traza.AppendLine();
            }
            else
            {
                traza.AppendLine("(Llamadas omitidas para n > 4: tendrían demasiadas líneas.)");
                traza.AppendLine();
            }

            traza.AppendLine("--- Movimientos (versión recursiva) ---");
            for (int i = 0; i < movRec.Count; i++)
                traza.AppendLine($"{i + 1,4}. {movRec[i]}");

            bool coinciden = movIter.SequenceEqual(movRec);
            MostrarResultados($"{movIter.Count} movimientos", $"{movRec.Count} movimientos (2^{n} - 1)",
                              coinciden, tIter, tRec, traza.ToString());
        }

        private void EjecutarSuma()
        {
            int[] arreglo = LeerArreglo(txtEntrada1.Text);

            long resIter = 0, resRec = 0;
            double tIter = Medir(() => resIter = Recursividad.SumaIterativa(arreglo));
            double tRec = Medir(() => resRec = Recursividad.SumaRecursiva(arreglo));

            var traza = new StringBuilder();
            if (arreglo.Length <= 20)
                Recursividad.SumaRecursiva(arreglo, 0, traza);
            else
                traza.AppendLine("(Traza omitida para arreglos de más de 20 elementos.)");

            MostrarResultados(resIter.ToString("N0"), resRec.ToString("N0"),
                              resIter == resRec, tIter, tRec, traza.ToString());
        }

        private void EjecutarBusqueda()
        {
            int[] arreglo = LeerArreglo(txtEntrada1.Text);
            int objetivo = LeerEntero(txtEntrada2.Text, int.MinValue, int.MaxValue, "valor a buscar");

            int resIter = 0, resRec = 0;
            double tIter = Medir(() => resIter = Recursividad.BusquedaIterativa(arreglo, objetivo));
            double tRec = Medir(() => resRec = Recursividad.BusquedaRecursiva(arreglo, objetivo));

            var traza = new StringBuilder();
            if (arreglo.Length <= 20)
                Recursividad.BusquedaRecursiva(arreglo, objetivo, 0, traza);
            else
                traza.AppendLine("(Traza omitida para arreglos de más de 20 elementos.)");

            MostrarResultados(DescribirIndice(resIter), DescribirIndice(resRec),
                              resIter == resRec, tIter, tRec, traza.ToString());
        }

        // ============================================================
        // MÉTODOS AUXILIARES
        // ============================================================

        /// <summary>Muestra ambos resultados, los tiempos y la traza.</summary>
        private void MostrarResultados(string iterativo, string recursivo, bool coinciden,
                                       double msIter, double msRec, string traza)
        {
            txtIterativo.Text = iterativo;
            txtRecursivo.Text = recursivo;
            lblTiempoIter.Text = $"Tiempo: {msIter:F4} ms";
            lblTiempoRec.Text = $"Tiempo: {msRec:F4} ms";

            lblComparacion.Text = coinciden
                ? "Comparación: los resultados COINCIDEN"
                : "Comparación: los resultados NO coinciden";
            lblComparacion.ForeColor = coinciden ? Color.DarkGreen : Color.Firebrick;

            rtbTraza.Text = traza;
        }

        /// <summary>Mide en milisegundos lo que tarda una acción.</summary>
        private static double Medir(Action accion)
        {
            var cronometro = Stopwatch.StartNew();
            accion();
            cronometro.Stop();
            return cronometro.Elapsed.TotalMilliseconds;
        }

        private static string DescribirIndice(int indice)
        {
            return indice >= 0 ? $"Encontrado en el índice {indice}" : "-1 (no encontrado)";
        }

        /// <summary>Convierte texto a entero validando el rango.</summary>
        private static int LeerEntero(string texto, int minimo, int maximo, string nombre)
        {
            if (!int.TryParse(texto.Trim(), out int valor))
                throw new FormatException($"El valor de '{nombre}' debe ser un número entero.");

            if (valor < minimo || valor > maximo)
                throw new FormatException($"'{nombre}' debe estar entre {minimo} y {maximo}.");

            return valor;
        }

        /// <summary>Convierte "3, 5, 8" en un arreglo de enteros.</summary>
        private static int[] LeerArreglo(string texto)
        {
            string[] partes = texto.Split(new[] { ',', ';', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            if (partes.Length == 0)
                throw new FormatException("Escribe al menos un número en el arreglo.");
            if (partes.Length > 1000)
                throw new FormatException("El arreglo puede tener como máximo 1000 elementos.");

            int[] arreglo = new int[partes.Length];
            for (int i = 0; i < partes.Length; i++)
            {
                if (!int.TryParse(partes[i], out arreglo[i]))
                    throw new FormatException($"'{partes[i]}' no es un número entero válido.");
            }
            return arreglo;
        }
    }
}
