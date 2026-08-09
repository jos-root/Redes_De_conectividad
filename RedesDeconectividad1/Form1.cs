using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace RedesDeConectividad
{
    /// <summary>
    /// Formulario principal del proyecto. Se encarga únicamente de la
    /// interacción con el usuario: leer lo que escribió en la grilla,
    /// mandarlo a calcular a <see cref="OperacionesMatriciales"/> y
    /// mostrar el resultado. La operación matemática en sí (multiplicar
    /// y elevar matrices) vive aparte, en esa otra clase, para no mezclar
    /// interfaz con lógica.
    /// </summary>
    public partial class Form1 : Form
    {
        // Tamaño de la red (número de servidores/nodos). Si se necesita
        // ampliar la red a más servidores, basta con cambiar este valor
        // y la lista de nombres de abajo.
        private const int TamanoMatriz = 4;
        private readonly string[] nombresServidores = { "S1", "S2", "S3", "S4" };

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ConfigurarGridEntrada();
            ConfigurarGridResultado();
            ConfigurarCombos();
        }

        /// <summary>
        /// Configura las columnas, encabezados y valores iniciales del
        /// DataGridView donde el usuario ingresa la matriz de adyacencia.
        /// </summary>
        private void ConfigurarGridEntrada()
        {
            dgvMatrizEntrada.ColumnCount = TamanoMatriz;
            dgvMatrizEntrada.RowCount = TamanoMatriz;

            for (int i = 0; i < TamanoMatriz; i++)
            {
                dgvMatrizEntrada.Columns[i].Name = nombresServidores[i];
                dgvMatrizEntrada.Columns[i].HeaderText = nombresServidores[i];
                dgvMatrizEntrada.Columns[i].Width = 55;
                dgvMatrizEntrada.Columns[i].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;

                dgvMatrizEntrada.Rows[i].HeaderCell.Value = nombresServidores[i];
            }

            // Valores de ejemplo, iguales a los del prototipo, para que el
            // formulario no arranque vacío y se pueda probar de inmediato.
            int[,] ejemplo =
            {
                { 0, 1, 1, 0 },
                { 1, 0, 1, 1 },
                { 1, 1, 0, 1 },
                { 0, 1, 1, 0 }
            };

            for (int i = 0; i < TamanoMatriz; i++)
            {
                for (int j = 0; j < TamanoMatriz; j++)
                {
                    dgvMatrizEntrada.Rows[i].Cells[j].Value = ejemplo[i, j];
                }
            }
        }

        /// <summary>
        /// Configura las columnas y encabezados del DataGridView de solo
        /// lectura donde se muestra la matriz resultado (A elevada a N).
        /// </summary>
        private void ConfigurarGridResultado()
        {
            dgvResultado.ColumnCount = TamanoMatriz;
            dgvResultado.RowCount = TamanoMatriz;

            for (int i = 0; i < TamanoMatriz; i++)
            {
                dgvResultado.Columns[i].Name = nombresServidores[i];
                dgvResultado.Columns[i].HeaderText = nombresServidores[i];
                dgvResultado.Columns[i].Width = 90;
                dgvResultado.Columns[i].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;
                dgvResultado.Columns[i].DefaultCellStyle.Font =
                    new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);

                dgvResultado.Rows[i].HeaderCell.Value = nombresServidores[i];
            }
        }

        /// <summary>
        /// Llena los combos de origen y destino con los nombres de los
        /// servidores definidos en el arreglo <see cref="nombresServidores"/>.
        /// </summary>
        private void ConfigurarCombos()
        {
            cmbOrigen.Items.Clear();
            cmbDestino.Items.Clear();

            foreach (string nombre in nombresServidores)
            {
                cmbOrigen.Items.Add($"Servidor {nombre}");
                cmbDestino.Items.Add($"Servidor {nombre}");
            }

            cmbOrigen.SelectedIndex = 0;
            cmbDestino.SelectedIndex = TamanoMatriz - 1;
        }

        /// <summary>
        /// Se dispara cuando el DataGridView muestra el control de edición
        /// de una celda (un TextBox interno). Aquí se le engancha el
        /// filtro de teclas para que, mientras el usuario escribe, no se
        /// puedan ingresar caracteres distintos de 0 y 1, ni un segundo
        /// dígito una vez que la celda ya tiene uno.
        /// </summary>
        private void dgvMatrizEntrada_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (e.Control is TextBox editor)
            {
                editor.KeyPress -= CeldaMatriz_KeyPress;
                editor.KeyPress += CeldaMatriz_KeyPress;
            }
        }

        /// <summary>
        /// Filtro de teclado para las celdas de la matriz: solo deja pasar
        /// las teclas de control (borrar, flechas, tab, etc.) y los
        /// caracteres '0' y '1'. Además, si la celda ya tiene un dígito y
        /// no hay texto seleccionado, bloquea un segundo carácter para que
        /// nunca se pueda formar algo como "10" o "11".
        /// </summary>
        private void CeldaMatriz_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
            {
                return;
            }

            if (e.KeyChar != '0' && e.KeyChar != '1')
            {
                e.Handled = true;
                return;
            }

            if (sender is TextBox editor && editor.SelectionLength == 0 && editor.Text.Length >= 1)
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Validación de respaldo: cubre los casos que el filtro de teclas
        /// no puede evitar, como pegar texto con Ctrl+V o dejar la celda
        /// vacía. Si el valor final no es exactamente "0" o "1", se
        /// cancela la edición, se marca la fila con un ícono de error y la
        /// celda no se puede abandonar hasta corregirla.
        /// </summary>
        private void dgvMatrizEntrada_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            string valor = e.FormattedValue?.ToString().Trim();

            if (valor != "0" && valor != "1")
            {
                dgvMatrizEntrada.Rows[e.RowIndex].ErrorText = "Solo se permite 0 o 1";
                e.Cancel = true;
            }
            else
            {
                dgvMatrizEntrada.Rows[e.RowIndex].ErrorText = string.Empty;
            }
        }

        /// <summary>
        /// Limpia el ícono de error de la fila una vez que la celda quedó
        /// con un valor válido.
        /// </summary>
        private void dgvMatrizEntrada_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            dgvMatrizEntrada.Rows[e.RowIndex].ErrorText = string.Empty;
        }

        /// <summary>
        /// Evento del botón "Calcular Aⁿ": lee la matriz ingresada por el
        /// usuario, calcula su potencia N y muestra tanto la matriz
        /// resultante como la interpretación puntual de la ruta consultada.
        /// </summary>
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                int[,] matrizEntrada = LeerMatrizDesdeGrid();
                int n = (int)numSaltos.Value;

                int[,] matrizPotencia = OperacionesMatriciales.Potencia(matrizEntrada, n);

                MostrarResultadoEnGrid(matrizPotencia);
                MostrarConclusion(matrizPotencia, n);
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Datos inválidos",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al calcular la matriz: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Recorre el DataGridView de entrada y arma la matriz de enteros
        /// que usará el motor de cálculo, validando que cada celda
        /// contenga únicamente 0 o 1.
        /// </summary>
        private int[,] LeerMatrizDesdeGrid()
        {
            int[,] matriz = new int[TamanoMatriz, TamanoMatriz];

            for (int i = 0; i < TamanoMatriz; i++)
            {
                for (int j = 0; j < TamanoMatriz; j++)
                {
                    object valorCelda = dgvMatrizEntrada.Rows[i].Cells[j].Value;

                    if (valorCelda == null || !int.TryParse(valorCelda.ToString(), out int valor))
                    {
                        throw new FormatException(
                            $"La celda ({nombresServidores[i]}, {nombresServidores[j]}) está vacía o no es un número válido.");
                    }

                    if (valor != 0 && valor != 1)
                    {
                        throw new FormatException(
                            $"La celda ({nombresServidores[i]}, {nombresServidores[j]}) debe contener únicamente 0 o 1.");
                    }

                    matriz[i, j] = valor;
                }
            }

            return matriz;
        }

        /// <summary>
        /// Vuelca la matriz calculada en el DataGridView de resultado.
        /// </summary>
        private void MostrarResultadoEnGrid(int[,] matriz)
        {
            for (int i = 0; i < TamanoMatriz; i++)
            {
                for (int j = 0; j < TamanoMatriz; j++)
                {
                    dgvResultado.Rows[i].Cells[j].Value = matriz[i, j];
                }
            }
        }

        
        /// Muestra el mensaje de conclusión con la cantidad exacta de rutas
        /// encontradas entre el servidor origen y el servidor destino
        /// seleccionados en los combos.
        
        private void MostrarConclusion(int[,] matrizPotencia, int n)
        {
            int origen = cmbOrigen.SelectedIndex;
            int destino = cmbDestino.SelectedIndex;
            int cantidadRutas = matrizPotencia[origen, destino];

            string plural = cantidadRutas == 1 ? "ruta" : "rutas";
            string pluralSalto = n == 1 ? "salto" : "saltos";

            lblResultado.Visible = true;
            lblResultado.Text =
                "CONCLUSIÓN DEL ANÁLISIS:" + Environment.NewLine +
                $"Existen exactamente {cantidadRutas} {plural} de {n} {pluralSalto} " +
                $"desde el Servidor {nombresServidores[origen]} hasta el Servidor {nombresServidores[destino]}.";
        }
    }
}