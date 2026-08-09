namespace RedesDeConectividad
{
    partial class Form1
    {
        /// <summary>Variable de diseñador necesaria.</summary>
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.groupBoxMatrizEntrada = new System.Windows.Forms.GroupBox();
            this.lblInstruccionMatriz = new System.Windows.Forms.Label();
            this.dgvMatrizEntrada = new System.Windows.Forms.DataGridView();
            this.groupBoxParametros = new System.Windows.Forms.GroupBox();
            this.lblSaltos = new System.Windows.Forms.Label();
            this.numSaltos = new System.Windows.Forms.NumericUpDown();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.groupBoxConsulta = new System.Windows.Forms.GroupBox();
            this.lblOrigen = new System.Windows.Forms.Label();
            this.cmbOrigen = new System.Windows.Forms.ComboBox();
            this.lblDestino = new System.Windows.Forms.Label();
            this.cmbDestino = new System.Windows.Forms.ComboBox();
            this.groupBoxResultado = new System.Windows.Forms.GroupBox();
            this.dgvResultado = new System.Windows.Forms.DataGridView();
            this.lblResultado = new System.Windows.Forms.Label();
            this.toolTipAyuda = new System.Windows.Forms.ToolTip(this.components);
            this.groupBoxMatrizEntrada.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatrizEntrada)).BeginInit();
            this.groupBoxParametros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSaltos)).BeginInit();
            this.groupBoxConsulta.SuspendLayout();
            this.groupBoxResultado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(158)))));
            this.lblTitulo.Location = new System.Drawing.Point(20, 12);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(431, 20);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Modelo de Redes de Conectividad — Matrices de Adyacencia";
            // 
            // groupBoxMatrizEntrada
            // 
            this.groupBoxMatrizEntrada.Controls.Add(this.lblInstruccionMatriz);
            this.groupBoxMatrizEntrada.Controls.Add(this.dgvMatrizEntrada);
            this.groupBoxMatrizEntrada.Location = new System.Drawing.Point(20, 45);
            this.groupBoxMatrizEntrada.Name = "groupBoxMatrizEntrada";
            this.groupBoxMatrizEntrada.Size = new System.Drawing.Size(330, 210);
            this.groupBoxMatrizEntrada.TabIndex = 1;
            this.groupBoxMatrizEntrada.TabStop = false;
            this.groupBoxMatrizEntrada.Text = "Matriz de Adyacencia Directa (A)";
            // 
            // lblInstruccionMatriz
            // 
            this.lblInstruccionMatriz.AutoSize = true;
            this.lblInstruccionMatriz.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblInstruccionMatriz.ForeColor = System.Drawing.Color.DimGray;
            this.lblInstruccionMatriz.Location = new System.Drawing.Point(15, 25);
            this.lblInstruccionMatriz.Name = "lblInstruccionMatriz";
            this.lblInstruccionMatriz.Size = new System.Drawing.Size(285, 13);
            this.lblInstruccionMatriz.TabIndex = 0;
            this.lblInstruccionMatriz.Text = "Ingrese 1 si hay conexión directa, 0 si no existe enlace:";
            // 
            // dgvMatrizEntrada
            // 
            this.dgvMatrizEntrada.AllowUserToAddRows = false;
            this.dgvMatrizEntrada.AllowUserToDeleteRows = false;
            this.dgvMatrizEntrada.AllowUserToResizeColumns = false;
            this.dgvMatrizEntrada.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMatrizEntrada.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMatrizEntrada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(228)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMatrizEntrada.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMatrizEntrada.EnableHeadersVisualStyles = false;
            this.dgvMatrizEntrada.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.dgvMatrizEntrada.Location = new System.Drawing.Point(15, 50);
            this.dgvMatrizEntrada.Name = "dgvMatrizEntrada";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMatrizEntrada.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMatrizEntrada.RowHeadersWidth = 40;
            this.dgvMatrizEntrada.RowTemplate.Height = 26;
            this.dgvMatrizEntrada.Size = new System.Drawing.Size(295, 145);
            this.dgvMatrizEntrada.TabIndex = 1;
            this.toolTipAyuda.SetToolTip(this.dgvMatrizEntrada, "Cada celda representa el enlace del servidor de la fila hacia el de la columna.");
            this.dgvMatrizEntrada.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMatrizEntrada_CellEndEdit);
            this.dgvMatrizEntrada.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgvMatrizEntrada_CellValidating);
            this.dgvMatrizEntrada.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvMatrizEntrada_EditingControlShowing);
            // 
            // groupBoxParametros
            // 
            this.groupBoxParametros.Controls.Add(this.lblSaltos);
            this.groupBoxParametros.Controls.Add(this.numSaltos);
            this.groupBoxParametros.Controls.Add(this.btnCalcular);
            this.groupBoxParametros.Location = new System.Drawing.Point(365, 45);
            this.groupBoxParametros.Name = "groupBoxParametros";
            this.groupBoxParametros.Size = new System.Drawing.Size(290, 110);
            this.groupBoxParametros.TabIndex = 2;
            this.groupBoxParametros.TabStop = false;
            this.groupBoxParametros.Text = "Parámetros de Entrada";
            // 
            // lblSaltos
            // 
            this.lblSaltos.AutoSize = true;
            this.lblSaltos.Location = new System.Drawing.Point(15, 28);
            this.lblSaltos.Name = "lblSaltos";
            this.lblSaltos.Size = new System.Drawing.Size(124, 15);
            this.lblSaltos.TabIndex = 0;
            this.lblSaltos.Text = "Número de Saltos (N):";
            // 
            // numSaltos
            // 
            this.numSaltos.Location = new System.Drawing.Point(180, 25);
            this.numSaltos.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numSaltos.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSaltos.Name = "numSaltos";
            this.numSaltos.Size = new System.Drawing.Size(80, 23);
            this.numSaltos.TabIndex = 1;
            this.numSaltos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTipAyuda.SetToolTip(this.numSaltos, "Cantidad exacta de saltos que se van a analizar (equivale al exponente N de A^N)." +
        "");
            this.numSaltos.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnCalcular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalcular.FlatAppearance.BorderSize = 0;
            this.btnCalcular.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(145)))));
            this.btnCalcular.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcular.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnCalcular.ForeColor = System.Drawing.Color.White;
            this.btnCalcular.Location = new System.Drawing.Point(15, 60);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(245, 34);
            this.btnCalcular.TabIndex = 2;
            this.btnCalcular.Text = "Calcular Aⁿ";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // groupBoxConsulta
            // 
            this.groupBoxConsulta.Controls.Add(this.lblOrigen);
            this.groupBoxConsulta.Controls.Add(this.cmbOrigen);
            this.groupBoxConsulta.Controls.Add(this.lblDestino);
            this.groupBoxConsulta.Controls.Add(this.cmbDestino);
            this.groupBoxConsulta.Location = new System.Drawing.Point(365, 161);
            this.groupBoxConsulta.Name = "groupBoxConsulta";
            this.groupBoxConsulta.Size = new System.Drawing.Size(290, 124);
            this.groupBoxConsulta.TabIndex = 3;
            this.groupBoxConsulta.TabStop = false;
            this.groupBoxConsulta.Text = "Consulta Específica de Ruta";
            // 
            // lblOrigen
            // 
            this.lblOrigen.AutoSize = true;
            this.lblOrigen.Location = new System.Drawing.Point(15, 28);
            this.lblOrigen.Name = "lblOrigen";
            this.lblOrigen.Size = new System.Drawing.Size(127, 15);
            this.lblOrigen.TabIndex = 0;
            this.lblOrigen.Text = "Desde Servidor Origen:";
            // 
            // cmbOrigen
            // 
            this.cmbOrigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOrigen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbOrigen.Location = new System.Drawing.Point(15, 48);
            this.cmbOrigen.Name = "cmbOrigen";
            this.cmbOrigen.Size = new System.Drawing.Size(260, 23);
            this.cmbOrigen.TabIndex = 1;
            // 
            // lblDestino
            // 
            this.lblDestino.AutoSize = true;
            this.lblDestino.Location = new System.Drawing.Point(15, 80);
            this.lblDestino.Name = "lblDestino";
            this.lblDestino.Size = new System.Drawing.Size(129, 15);
            this.lblDestino.TabIndex = 2;
            this.lblDestino.Text = "Hasta Servidor Destino:";
            // 
            // cmbDestino
            // 
            this.cmbDestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDestino.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbDestino.Location = new System.Drawing.Point(15, 100);
            this.cmbDestino.Name = "cmbDestino";
            this.cmbDestino.Size = new System.Drawing.Size(260, 23);
            this.cmbDestino.TabIndex = 3;
            // 
            // groupBoxResultado
            // 
            this.groupBoxResultado.Controls.Add(this.dgvResultado);
            this.groupBoxResultado.Controls.Add(this.lblResultado);
            this.groupBoxResultado.Location = new System.Drawing.Point(20, 270);
            this.groupBoxResultado.Name = "groupBoxResultado";
            this.groupBoxResultado.Size = new System.Drawing.Size(635, 275);
            this.groupBoxResultado.TabIndex = 4;
            this.groupBoxResultado.TabStop = false;
            this.groupBoxResultado.Text = "Resultado Matricial (Matriz Aⁿ)";
            // 
            // dgvResultado
            // 
            this.dgvResultado.AllowUserToAddRows = false;
            this.dgvResultado.AllowUserToDeleteRows = false;
            this.dgvResultado.AllowUserToResizeColumns = false;
            this.dgvResultado.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.dgvResultado.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvResultado.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvResultado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultado.EnableHeadersVisualStyles = false;
            this.dgvResultado.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.dgvResultado.Location = new System.Drawing.Point(15, 25);
            this.dgvResultado.Name = "dgvResultado";
            this.dgvResultado.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvResultado.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvResultado.RowHeadersWidth = 40;
            this.dgvResultado.RowTemplate.Height = 26;
            this.dgvResultado.Size = new System.Drawing.Size(605, 155);
            this.dgvResultado.TabIndex = 0;
            // 
            // lblResultado
            // 
            this.lblResultado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(244)))), ((int)(((byte)(234)))));
            this.lblResultado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResultado.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblResultado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(115)))), ((int)(((byte)(51)))));
            this.lblResultado.Location = new System.Drawing.Point(15, 190);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Padding = new System.Windows.Forms.Padding(10);
            this.lblResultado.Size = new System.Drawing.Size(605, 75);
            this.lblResultado.TabIndex = 1;
            this.lblResultado.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(680, 570);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.groupBoxMatrizEntrada);
            this.Controls.Add(this.groupBoxParametros);
            this.Controls.Add(this.groupBoxConsulta);
            this.Controls.Add(this.groupBoxResultado);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RedesDeConectividad.Form1 - Modelo de Redes de Conectividad (Matrices de Adyacenc" +
    "ia)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxMatrizEntrada.ResumeLayout(false);
            this.groupBoxMatrizEntrada.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatrizEntrada)).EndInit();
            this.groupBoxParametros.ResumeLayout(false);
            this.groupBoxParametros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSaltos)).EndInit();
            this.groupBoxConsulta.ResumeLayout(false);
            this.groupBoxConsulta.PerformLayout();
            this.groupBoxResultado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox groupBoxMatrizEntrada;
        private System.Windows.Forms.DataGridView dgvMatrizEntrada;
        private System.Windows.Forms.Label lblInstruccionMatriz;
        private System.Windows.Forms.GroupBox groupBoxParametros;
        private System.Windows.Forms.Label lblSaltos;
        private System.Windows.Forms.NumericUpDown numSaltos;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.GroupBox groupBoxConsulta;
        private System.Windows.Forms.Label lblOrigen;
        private System.Windows.Forms.ComboBox cmbOrigen;
        private System.Windows.Forms.Label lblDestino;
        private System.Windows.Forms.ComboBox cmbDestino;
        private System.Windows.Forms.GroupBox groupBoxResultado;
        private System.Windows.Forms.DataGridView dgvResultado;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.ToolTip toolTipAyuda;
    }
}