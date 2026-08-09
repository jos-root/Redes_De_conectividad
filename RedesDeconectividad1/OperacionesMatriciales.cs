using System;

namespace RedesDeConectividad
{
    /// <summary>
    /// Contiene las operaciones matriciales necesarias para el modelo de
    /// redes de conectividad. La red de servidores se representa mediante
    /// un grafo, y ese grafo se modela matemáticamente con una matriz de
    /// adyacencia A de tamaño n x n, donde A[i, j] = 1 si existe un enlace
    /// directo entre el servidor i y el servidor j, y 0 en caso contrario.
    ///
    /// La propiedad clave que usa este proyecto es la siguiente: si se
    /// eleva la matriz A a la potencia N (es decir, A multiplicada por sí
    /// misma N veces), el valor que queda en la posición [i, j] de la
    /// matriz resultante indica cuántos caminos distintos de EXACTAMENTE
    /// N saltos existen entre el servidor i y el servidor j dentro de la
    /// red. Esa es la base matemática que sustenta todo el proyecto.
    /// </summary>
    public static class OperacionesMatriciales
    {
        /// <summary>
        /// Multiplica dos matrices cuadradas del mismo tamaño (n x n)
        /// siguiendo la definición estándar de multiplicación matricial:
        /// cada celda del resultado es la suma de los productos fila por
        /// columna correspondientes.
        /// </summary>
        /// <param name="A">Primera matriz (n x n).</param>
        /// <param name="B">Segunda matriz (n x n).</param>
        /// <returns>Matriz resultado de A x B.</returns>
        public static int[,] Multiplicar(int[,] A, int[,] B)
        {
            int n = A.GetLength(0);
            int[,] resultado = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    int suma = 0;
                    for (int k = 0; k < n; k++)
                    {
                        suma += A[i, k] * B[k, j];
                    }
                    resultado[i, j] = suma;
                }
            }

            return resultado;
        }

        /// <summary>
        /// Calcula la potencia N de una matriz cuadrada (A elevada a N),
        /// multiplicando la matriz por sí misma N - 1 veces. Este es el
        /// cálculo que permite responder la pregunta central del proyecto:
        /// cuántas rutas alternativas de N saltos existen entre dos
        /// servidores específicos de la red.
        /// </summary>
        /// <param name="A">Matriz de adyacencia original (n x n).</param>
        /// <param name="N">Número de saltos (potencia a calcular). Debe ser mayor o igual a 1.</param>
        /// <returns>La matriz A elevada a la potencia N.</returns>
        public static int[,] Potencia(int[,] A, int N)
        {
            if (N < 1)
            {
                throw new ArgumentException("El número de saltos (N) debe ser mayor o igual a 1.");
            }

            int n = A.GetLength(0);
            int[,] resultado = (int[,])A.Clone();

            // Se multiplica la matriz por sí misma N - 1 veces adicionales,
            // ya que la primera "copia" ya representa A elevada a la 1.
            for (int p = 1; p < N; p++)
            {
                resultado = Multiplicar(resultado, A);
            }

            return resultado;
        }
    }
}