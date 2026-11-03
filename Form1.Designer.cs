namespace CatalogoRecursividad
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. Se puede modificar
        /// visualmente desde Visual Studio (Form1.cs [Diseño]).
        /// </summary>
        private void InitializeComponent()
        {
            lblTitulo = new System.Windows.Forms.Label();
            grpEntrada = new System.Windows.Forms.GroupBox();
            lblEjercicio = new System.Windows.Forms.Label();
            cmbEjercicio = new System.Windows.Forms.ComboBox();
            lblEntrada1 = new System.Windows.Forms.Label();
            txtEntrada1 = new System.Windows.Forms.TextBox();
            lblEntrada2 = new System.Windows.Forms.Label();
            txtEntrada2 = new System.Windows.Forms.TextBox();
            btnEjecutar = new System.Windows.Forms.Button();
            btnLimpiar = new System.Windows.Forms.Button();
            grpResultados = new System.Windows.Forms.GroupBox();
            lblIterativo = new System.Windows.Forms.Label();
            txtIterativo = new System.Windows.Forms.TextBox();
            lblTiempoIter = new System.Windows.Forms.Label();
            lblRecursivo = new System.Windows.Forms.Label();
            txtRecursivo = new System.Windows.Forms.TextBox();
            lblTiempoRec = new System.Windows.Forms.Label();
            lblComparacion = new System.Windows.Forms.Label();
            grpAnalisis = new System.Windows.Forms.GroupBox();
            lblCasoBase = new System.Windows.Forms.Label();
            lblCasoRecursivo = new System.Windows.Forms.Label();
            lblTraza = new System.Windows.Forms.Label();
            rtbTraza = new System.Windows.Forms.RichTextBox();
            grpEntrada.SuspendLayout();
            grpResultados.SuspendLayout();
            grpAnalisis.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            lblTitulo.Location = new System.Drawing.Point(20, 12);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new System.Drawing.Size(423, 25);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Catálogo de ejercicios: de Iterativo a Recursivo";
            // 
            // grpEntrada
            // 
            grpEntrada.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            grpEntrada.Controls.Add(lblEjercicio);
            grpEntrada.Controls.Add(cmbEjercicio);
            grpEntrada.Controls.Add(lblEntrada1);
            grpEntrada.Controls.Add(txtEntrada1);
            grpEntrada.Controls.Add(lblEntrada2);
            grpEntrada.Controls.Add(txtEntrada2);
            grpEntrada.Controls.Add(btnEjecutar);
            grpEntrada.Controls.Add(btnLimpiar);
            grpEntrada.Location = new System.Drawing.Point(20, 50);
            grpEntrada.Name = "grpEntrada";
            grpEntrada.Size = new System.Drawing.Size(800, 125);
            grpEntrada.TabIndex = 1;
            grpEntrada.TabStop = false;
            grpEntrada.Text = "1. Datos de entrada";
            // 
            // lblEjercicio
            // 
            lblEjercicio.AutoSize = true;
            lblEjercicio.Location = new System.Drawing.Point(15, 30);
            lblEjercicio.Name = "lblEjercicio";
            lblEjercicio.Size = new System.Drawing.Size(54, 15);
            lblEjercicio.TabIndex = 0;
            lblEjercicio.Text = "Ejercicio:";
            // 
            // cmbEjercicio
            // 
            cmbEjercicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbEjercicio.FormattingEnabled = true;
            cmbEjercicio.Items.AddRange(new object[] { "Factorial", "Fibonacci", "Torres de Hanoi", "Suma de arreglo", "Búsqueda lineal recursiva" });
            cmbEjercicio.Location = new System.Drawing.Point(244, 27);
            cmbEjercicio.Name = "cmbEjercicio";
            cmbEjercicio.Size = new System.Drawing.Size(330, 23);
            cmbEjercicio.TabIndex = 1;
            cmbEjercicio.SelectedIndexChanged += cmbEjercicio_SelectedIndexChanged;
            // 
            // lblEntrada1
            // 
            lblEntrada1.AutoSize = true;
            lblEntrada1.Location = new System.Drawing.Point(15, 62);
            lblEntrada1.Name = "lblEntrada1";
            lblEntrada1.Size = new System.Drawing.Size(59, 15);
            lblEntrada1.TabIndex = 2;
            lblEntrada1.Text = "Entrada 1:";
            // 
            // txtEntrada1
            // 
            txtEntrada1.Location = new System.Drawing.Point(244, 59);
            txtEntrada1.Name = "txtEntrada1";
            txtEntrada1.Size = new System.Drawing.Size(330, 23);
            txtEntrada1.TabIndex = 3;
            // 
            // lblEntrada2
            // 
            lblEntrada2.AutoSize = true;
            lblEntrada2.Location = new System.Drawing.Point(15, 92);
            lblEntrada2.Name = "lblEntrada2";
            lblEntrada2.Size = new System.Drawing.Size(59, 15);
            lblEntrada2.TabIndex = 4;
            lblEntrada2.Text = "Entrada 2:";
            // 
            // txtEntrada2
            // 
            txtEntrada2.Location = new System.Drawing.Point(244, 89);
            txtEntrada2.Name = "txtEntrada2";
            txtEntrada2.Size = new System.Drawing.Size(330, 23);
            txtEntrada2.TabIndex = 5;
            // 
            // btnEjecutar
            // 
            btnEjecutar.BackColor = System.Drawing.Color.SteelBlue;
            btnEjecutar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnEjecutar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            btnEjecutar.ForeColor = System.Drawing.Color.White;
            btnEjecutar.Location = new System.Drawing.Point(580, 26);
            btnEjecutar.Name = "btnEjecutar";
            btnEjecutar.Size = new System.Drawing.Size(200, 36);
            btnEjecutar.TabIndex = 6;
            btnEjecutar.Text = "Ejecutar";
            btnEjecutar.UseVisualStyleBackColor = false;
            btnEjecutar.Click += btnEjecutar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new System.Drawing.Point(580, 72);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new System.Drawing.Size(200, 36);
            btnLimpiar.TabIndex = 7;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // grpResultados
            // 
            grpResultados.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            grpResultados.Controls.Add(lblIterativo);
            grpResultados.Controls.Add(txtIterativo);
            grpResultados.Controls.Add(lblTiempoIter);
            grpResultados.Controls.Add(lblRecursivo);
            grpResultados.Controls.Add(txtRecursivo);
            grpResultados.Controls.Add(lblTiempoRec);
            grpResultados.Controls.Add(lblComparacion);
            grpResultados.Location = new System.Drawing.Point(20, 185);
            grpResultados.Name = "grpResultados";
            grpResultados.Size = new System.Drawing.Size(800, 120);
            grpResultados.TabIndex = 2;
            grpResultados.TabStop = false;
            grpResultados.Text = "2. Resultados";
            // 
            // lblIterativo
            // 
            lblIterativo.AutoSize = true;
            lblIterativo.Location = new System.Drawing.Point(15, 30);
            lblIterativo.Name = "lblIterativo";
            lblIterativo.Size = new System.Drawing.Size(93, 15);
            lblIterativo.TabIndex = 0;
            lblIterativo.Text = "Versión iterativa:";
            // 
            // txtIterativo
            // 
            txtIterativo.Location = new System.Drawing.Point(200, 26);
            txtIterativo.Name = "txtIterativo";
            txtIterativo.ReadOnly = true;
            txtIterativo.Size = new System.Drawing.Size(330, 23);
            txtIterativo.TabIndex = 1;
            // 
            // lblTiempoIter
            // 
            lblTiempoIter.AutoSize = true;
            lblTiempoIter.Location = new System.Drawing.Point(545, 30);
            lblTiempoIter.Name = "lblTiempoIter";
            lblTiempoIter.Size = new System.Drawing.Size(59, 15);
            lblTiempoIter.TabIndex = 2;
            lblTiempoIter.Text = "Tiempo: -";
            // 
            // lblRecursivo
            // 
            lblRecursivo.AutoSize = true;
            lblRecursivo.Location = new System.Drawing.Point(15, 62);
            lblRecursivo.Name = "lblRecursivo";
            lblRecursivo.Size = new System.Drawing.Size(98, 15);
            lblRecursivo.TabIndex = 3;
            lblRecursivo.Text = "Versión recursiva:";
            // 
            // txtRecursivo
            // 
            txtRecursivo.Location = new System.Drawing.Point(200, 58);
            txtRecursivo.Name = "txtRecursivo";
            txtRecursivo.ReadOnly = true;
            txtRecursivo.Size = new System.Drawing.Size(330, 23);
            txtRecursivo.TabIndex = 4;
            // 
            // lblTiempoRec
            // 
            lblTiempoRec.AutoSize = true;
            lblTiempoRec.Location = new System.Drawing.Point(545, 62);
            lblTiempoRec.Name = "lblTiempoRec";
            lblTiempoRec.Size = new System.Drawing.Size(59, 15);
            lblTiempoRec.TabIndex = 5;
            lblTiempoRec.Text = "Tiempo: -";
            // 
            // lblComparacion
            // 
            lblComparacion.AutoSize = true;
            lblComparacion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            lblComparacion.Location = new System.Drawing.Point(15, 92);
            lblComparacion.Name = "lblComparacion";
            lblComparacion.Size = new System.Drawing.Size(90, 15);
            lblComparacion.TabIndex = 6;
            lblComparacion.Text = "Comparación: -";
            // 
            // grpAnalisis
            // 
            grpAnalisis.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            grpAnalisis.Controls.Add(lblCasoBase);
            grpAnalisis.Controls.Add(lblCasoRecursivo);
            grpAnalisis.Location = new System.Drawing.Point(20, 315);
            grpAnalisis.Name = "grpAnalisis";
            grpAnalisis.Size = new System.Drawing.Size(800, 95);
            grpAnalisis.TabIndex = 3;
            grpAnalisis.TabStop = false;
            grpAnalisis.Text = "3. Análisis del ejercicio";
            // 
            // lblCasoBase
            // 
            lblCasoBase.ForeColor = System.Drawing.Color.DarkGreen;
            lblCasoBase.Location = new System.Drawing.Point(15, 22);
            lblCasoBase.Name = "lblCasoBase";
            lblCasoBase.Size = new System.Drawing.Size(770, 32);
            lblCasoBase.TabIndex = 0;
            lblCasoBase.Text = "Caso base: -";
            // 
            // lblCasoRecursivo
            // 
            lblCasoRecursivo.ForeColor = System.Drawing.Color.DarkBlue;
            lblCasoRecursivo.Location = new System.Drawing.Point(15, 57);
            lblCasoRecursivo.Name = "lblCasoRecursivo";
            lblCasoRecursivo.Size = new System.Drawing.Size(770, 32);
            lblCasoRecursivo.TabIndex = 1;
            lblCasoRecursivo.Text = "Caso recursivo: -";
            // 
            // lblTraza
            // 
            lblTraza.AutoSize = true;
            lblTraza.Location = new System.Drawing.Point(20, 420);
            lblTraza.Name = "lblTraza";
            lblTraza.Size = new System.Drawing.Size(223, 15);
            lblTraza.TabIndex = 4;
            lblTraza.Text = "Traza de ejecución (prueba de escritorio):";
            // 
            // rtbTraza
            // 
            rtbTraza.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            rtbTraza.BackColor = System.Drawing.Color.White;
            rtbTraza.Font = new System.Drawing.Font("Consolas", 9.5F);
            rtbTraza.Location = new System.Drawing.Point(20, 440);
            rtbTraza.Name = "rtbTraza";
            rtbTraza.ReadOnly = true;
            rtbTraza.Size = new System.Drawing.Size(800, 210);
            rtbTraza.TabIndex = 5;
            rtbTraza.Text = "";
            rtbTraza.WordWrap = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(840, 665);
            Controls.Add(lblTitulo);
            Controls.Add(grpEntrada);
            Controls.Add(grpResultados);
            Controls.Add(grpAnalisis);
            Controls.Add(lblTraza);
            Controls.Add(rtbTraza);
            MinimumSize = new System.Drawing.Size(856, 704);
            Name = "Form1";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Tarea 2.2 - Conversión de Iterativo a Recursivo";
            Load += Form1_Load;
            grpEntrada.ResumeLayout(false);
            grpEntrada.PerformLayout();
            grpResultados.ResumeLayout(false);
            grpResultados.PerformLayout();
            grpAnalisis.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox grpEntrada;
        private System.Windows.Forms.Label lblEjercicio;
        private System.Windows.Forms.ComboBox cmbEjercicio;
        private System.Windows.Forms.Label lblEntrada1;
        private System.Windows.Forms.TextBox txtEntrada1;
        private System.Windows.Forms.Label lblEntrada2;
        private System.Windows.Forms.TextBox txtEntrada2;
        private System.Windows.Forms.Button btnEjecutar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.GroupBox grpResultados;
        private System.Windows.Forms.Label lblIterativo;
        private System.Windows.Forms.TextBox txtIterativo;
        private System.Windows.Forms.Label lblTiempoIter;
        private System.Windows.Forms.Label lblRecursivo;
        private System.Windows.Forms.TextBox txtRecursivo;
        private System.Windows.Forms.Label lblTiempoRec;
        private System.Windows.Forms.Label lblComparacion;
        private System.Windows.Forms.GroupBox grpAnalisis;
        private System.Windows.Forms.Label lblCasoBase;
        private System.Windows.Forms.Label lblCasoRecursivo;
        private System.Windows.Forms.Label lblTraza;
        private System.Windows.Forms.RichTextBox rtbTraza;
    }
}
