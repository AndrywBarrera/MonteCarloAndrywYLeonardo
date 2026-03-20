namespace SimulacionMonteCarlo.SimulacionMonteCarlo
{
    partial class MonteCarloSimulacion
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            tabControl1 = new TabControl();
            tabGenerador = new TabPage();
            grpParametros = new GroupBox();
            lblModulo = new Label();
            txtModulo = new TextBox();
            lblMultiplicador = new Label();
            txtMultiplicador = new TextBox();
            lblIncremento = new Label();
            txtIncremento = new TextBox();
            lblSemilla = new Label();
            txtSemilla = new TextBox();
            lblConjunto = new Label();
            cboConjunto = new ComboBox();
            btnGenerar = new Button();
            lblEstadoGen = new Label();
            grpTabla = new GroupBox();
            dgvGenerador = new DataGridView();
            grpGraficoGen = new GroupBox();
            formsPlot1 = new ScottPlot.WinForms.FormsPlot();
            tabPruebas = new TabPage();
            lblPruebasConjunto = new Label();
            cboPruebasConjunto = new ComboBox();
            btnAplicarPruebas = new Button();
            rtbPruebas = new RichTextBox();
            lblResumenPruebas = new Label();
            tabMonteCarlo = new TabPage();
            lblAreaInfo = new Label();
            lblConjuntoMC = new Label();
            cboConjuntoMC = new ComboBox();
            btnMonteCarlo = new Button();
            grpResumenMC = new GroupBox();
            dgvMonteCarlo = new DataGridView();
            rtbMonteCarlo = new RichTextBox();
            grpGraficoMC = new GroupBox();
            formsPlot2 = new ScottPlot.WinForms.FormsPlot();
            tabControl1.SuspendLayout();
            tabGenerador.SuspendLayout();
            grpParametros.SuspendLayout();
            grpTabla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGenerador).BeginInit();
            grpGraficoGen.SuspendLayout();
            tabPruebas.SuspendLayout();
            tabMonteCarlo.SuspendLayout();
            grpResumenMC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMonteCarlo).BeginInit();
            grpGraficoMC.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabGenerador);
            tabControl1.Controls.Add(tabPruebas);
            tabControl1.Controls.Add(tabMonteCarlo);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            tabControl1.ItemSize = new Size(0, 36);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.Padding = new Point(20, 8);
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1200, 749);
            tabControl1.TabIndex = 0;
            // 
            // tabGenerador
            // 
            tabGenerador.BackColor = Color.FromArgb(245, 247, 250);
            tabGenerador.Controls.Add(grpParametros);
            tabGenerador.Controls.Add(grpTabla);
            tabGenerador.Controls.Add(grpGraficoGen);
            tabGenerador.Location = new Point(4, 40);
            tabGenerador.Name = "tabGenerador";
            tabGenerador.Padding = new Padding(10);
            tabGenerador.Size = new Size(1192, 705);
            tabGenerador.TabIndex = 0;
            tabGenerador.Text = "  Generador Congruencial  ";
            // 
            // grpParametros
            // 
            grpParametros.BackColor = Color.White;
            grpParametros.Controls.Add(lblModulo);
            grpParametros.Controls.Add(txtModulo);
            grpParametros.Controls.Add(lblMultiplicador);
            grpParametros.Controls.Add(txtMultiplicador);
            grpParametros.Controls.Add(lblIncremento);
            grpParametros.Controls.Add(txtIncremento);
            grpParametros.Controls.Add(lblSemilla);
            grpParametros.Controls.Add(txtSemilla);
            grpParametros.Controls.Add(lblConjunto);
            grpParametros.Controls.Add(cboConjunto);
            grpParametros.Controls.Add(btnGenerar);
            grpParametros.Controls.Add(lblEstadoGen);
            grpParametros.FlatStyle = FlatStyle.Flat;
            grpParametros.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            grpParametros.ForeColor = Color.FromArgb(30, 80, 150);
            grpParametros.Location = new Point(10, 10);
            grpParametros.Name = "grpParametros";
            grpParametros.Size = new Size(578, 120);
            grpParametros.TabIndex = 0;
            grpParametros.TabStop = false;
            grpParametros.Text = "  Parámetros del Generador  [ X(n+1) = (a · Xn + c) mod m ]";
            // 
            // lblModulo
            // 
            lblModulo.AutoSize = true;
            lblModulo.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblModulo.ForeColor = Color.FromArgb(70, 70, 90);
            lblModulo.Location = new Point(12, 28);
            lblModulo.Name = "lblModulo";
            lblModulo.Size = new Size(71, 15);
            lblModulo.TabIndex = 0;
            lblModulo.Text = "Módulo (m)";
            // 
            // txtModulo
            // 
            txtModulo.BackColor = Color.FromArgb(248, 250, 255);
            txtModulo.BorderStyle = BorderStyle.FixedSingle;
            txtModulo.Font = new Font("Consolas", 9.5F);
            txtModulo.ForeColor = Color.FromArgb(20, 20, 60);
            txtModulo.Location = new Point(12, 46);
            txtModulo.Name = "txtModulo";
            txtModulo.Size = new Size(108, 22);
            txtModulo.TabIndex = 0;
            // 
            // lblMultiplicador
            // 
            lblMultiplicador.AutoSize = true;
            lblMultiplicador.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblMultiplicador.ForeColor = Color.FromArgb(70, 70, 90);
            lblMultiplicador.Location = new Point(130, 28);
            lblMultiplicador.Name = "lblMultiplicador";
            lblMultiplicador.Size = new Size(97, 15);
            lblMultiplicador.TabIndex = 1;
            lblMultiplicador.Text = "Multiplicador (a)";
            // 
            // txtMultiplicador
            // 
            txtMultiplicador.BackColor = Color.FromArgb(248, 250, 255);
            txtMultiplicador.BorderStyle = BorderStyle.FixedSingle;
            txtMultiplicador.Font = new Font("Consolas", 9.5F);
            txtMultiplicador.ForeColor = Color.FromArgb(20, 20, 60);
            txtMultiplicador.Location = new Point(130, 46);
            txtMultiplicador.Name = "txtMultiplicador";
            txtMultiplicador.Size = new Size(108, 22);
            txtMultiplicador.TabIndex = 1;
            // 
            // lblIncremento
            // 
            lblIncremento.AutoSize = true;
            lblIncremento.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblIncremento.ForeColor = Color.FromArgb(70, 70, 90);
            lblIncremento.Location = new Point(248, 28);
            lblIncremento.Name = "lblIncremento";
            lblIncremento.Size = new Size(90, 15);
            lblIncremento.TabIndex = 2;
            lblIncremento.Text = "Incremento (c)";
            // 
            // txtIncremento
            // 
            txtIncremento.BackColor = Color.FromArgb(248, 250, 255);
            txtIncremento.BorderStyle = BorderStyle.FixedSingle;
            txtIncremento.Font = new Font("Consolas", 9.5F);
            txtIncremento.ForeColor = Color.FromArgb(20, 20, 60);
            txtIncremento.Location = new Point(248, 46);
            txtIncremento.Name = "txtIncremento";
            txtIncremento.Size = new Size(108, 22);
            txtIncremento.TabIndex = 2;
            // 
            // lblSemilla
            // 
            lblSemilla.AutoSize = true;
            lblSemilla.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblSemilla.ForeColor = Color.FromArgb(70, 70, 90);
            lblSemilla.Location = new Point(366, 28);
            lblSemilla.Name = "lblSemilla";
            lblSemilla.Size = new Size(73, 15);
            lblSemilla.TabIndex = 3;
            lblSemilla.Text = "Semilla (X0)";
            // 
            // txtSemilla
            // 
            txtSemilla.BackColor = Color.FromArgb(248, 250, 255);
            txtSemilla.BorderStyle = BorderStyle.FixedSingle;
            txtSemilla.Font = new Font("Consolas", 9.5F);
            txtSemilla.ForeColor = Color.FromArgb(20, 20, 60);
            txtSemilla.Location = new Point(366, 46);
            txtSemilla.Name = "txtSemilla";
            txtSemilla.Size = new Size(100, 22);
            txtSemilla.TabIndex = 3;
            // 
            // lblConjunto
            // 
            lblConjunto.AutoSize = true;
            lblConjunto.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblConjunto.ForeColor = Color.FromArgb(70, 70, 90);
            lblConjunto.Location = new Point(12, 82);
            lblConjunto.Name = "lblConjunto";
            lblConjunto.Size = new Size(76, 15);
            lblConjunto.TabIndex = 4;
            lblConjunto.Text = "Ver en tabla:";
            // 
            // cboConjunto
            // 
            cboConjunto.BackColor = Color.FromArgb(248, 250, 255);
            cboConjunto.DropDownStyle = ComboBoxStyle.DropDownList;
            cboConjunto.FlatStyle = FlatStyle.Flat;
            cboConjunto.Font = new Font("Segoe UI", 9F);
            cboConjunto.Location = new Point(100, 79);
            cboConjunto.Name = "cboConjunto";
            cboConjunto.Size = new Size(88, 23);
            cboConjunto.TabIndex = 4;
            cboConjunto.SelectedIndexChanged += cboConjunto_SelectedIndexChanged;
            // 
            // btnGenerar
            // 
            btnGenerar.BackColor = Color.FromArgb(30, 100, 200);
            btnGenerar.Cursor = Cursors.Hand;
            btnGenerar.FlatAppearance.BorderSize = 0;
            btnGenerar.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 130, 240);
            btnGenerar.FlatStyle = FlatStyle.Flat;
            btnGenerar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnGenerar.ForeColor = Color.White;
            btnGenerar.Location = new Point(205, 74);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(150, 36);
            btnGenerar.TabIndex = 5;
            btnGenerar.Text = "▶  GENERAR";
            btnGenerar.UseVisualStyleBackColor = false;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // lblEstadoGen
            // 
            lblEstadoGen.Font = new Font("Segoe UI", 8F, FontStyle.Italic);
            lblEstadoGen.ForeColor = Color.FromArgb(100, 120, 160);
            lblEstadoGen.Location = new Point(368, 84);
            lblEstadoGen.Name = "lblEstadoGen";
            lblEstadoGen.Size = new Size(202, 18);
            lblEstadoGen.TabIndex = 6;
            lblEstadoGen.Text = "Configure los parámetros y presione GENERAR.";
            // 
            // grpTabla
            // 
            grpTabla.BackColor = Color.White;
            grpTabla.Controls.Add(dgvGenerador);
            grpTabla.FlatStyle = FlatStyle.Flat;
            grpTabla.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            grpTabla.ForeColor = Color.FromArgb(30, 80, 150);
            grpTabla.Location = new Point(10, 138);
            grpTabla.Name = "grpTabla";
            grpTabla.Size = new Size(578, 559);
            grpTabla.TabIndex = 1;
            grpTabla.TabStop = false;
            grpTabla.Text = "  Valores Generados";
            // 
            // dgvGenerador
            // 
            dgvGenerador.AllowUserToAddRows = false;
            dgvGenerador.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(235, 243, 255);
            dgvGenerador.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvGenerador.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvGenerador.BackgroundColor = Color.White;
            dgvGenerador.BorderStyle = BorderStyle.None;
            dgvGenerador.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvGenerador.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(30, 100, 200);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvGenerador.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvGenerador.ColumnHeadersHeight = 34;
            dgvGenerador.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Consolas", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(30, 30, 60);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(180, 210, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(10, 10, 50);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvGenerador.DefaultCellStyle = dataGridViewCellStyle3;
            dgvGenerador.Dock = DockStyle.Fill;
            dgvGenerador.EnableHeadersVisualStyles = false;
            dgvGenerador.GridColor = Color.FromArgb(210, 220, 240);
            dgvGenerador.Location = new Point(3, 19);
            dgvGenerador.Name = "dgvGenerador";
            dgvGenerador.ReadOnly = true;
            dgvGenerador.RowHeadersVisible = false;
            dgvGenerador.RowTemplate.Height = 26;
            dgvGenerador.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvGenerador.Size = new Size(572, 537);
            dgvGenerador.TabIndex = 0;
            // 
            // grpGraficoGen
            // 
            grpGraficoGen.BackColor = Color.White;
            grpGraficoGen.Controls.Add(formsPlot1);
            grpGraficoGen.FlatStyle = FlatStyle.Flat;
            grpGraficoGen.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            grpGraficoGen.ForeColor = Color.FromArgb(30, 80, 150);
            grpGraficoGen.Location = new Point(600, 10);
            grpGraficoGen.Name = "grpGraficoGen";
            grpGraficoGen.Size = new Size(582, 692);
            grpGraficoGen.TabIndex = 2;
            grpGraficoGen.TabStop = false;
            grpGraficoGen.Text = "  Distribución de Valores (10 rangos)";
            // 
            // formsPlot1
            // 
            formsPlot1.DisplayScale = 1F;
            formsPlot1.Dock = DockStyle.Fill;
            formsPlot1.Location = new Point(3, 19);
            formsPlot1.Name = "formsPlot1";
            formsPlot1.Size = new Size(576, 670);
            formsPlot1.TabIndex = 0;
            // 
            // tabPruebas
            // 
            tabPruebas.BackColor = Color.FromArgb(245, 247, 250);
            tabPruebas.Controls.Add(lblPruebasConjunto);
            tabPruebas.Controls.Add(cboPruebasConjunto);
            tabPruebas.Controls.Add(btnAplicarPruebas);
            tabPruebas.Controls.Add(rtbPruebas);
            tabPruebas.Controls.Add(lblResumenPruebas);
            tabPruebas.Location = new Point(4, 40);
            tabPruebas.Name = "tabPruebas";
            tabPruebas.Padding = new Padding(10);
            tabPruebas.Size = new Size(1192, 736);
            tabPruebas.TabIndex = 1;
            tabPruebas.Text = "  Pruebas de Aleatoriedad  ";
            // 
            // lblPruebasConjunto
            // 
            lblPruebasConjunto.AutoSize = true;
            lblPruebasConjunto.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblPruebasConjunto.ForeColor = Color.FromArgb(70, 70, 90);
            lblPruebasConjunto.Location = new Point(14, 20);
            lblPruebasConjunto.Name = "lblPruebasConjunto";
            lblPruebasConjunto.Size = new Size(133, 17);
            lblPruebasConjunto.TabIndex = 0;
            lblPruebasConjunto.Text = "Conjunto a analizar:";
            // 
            // cboPruebasConjunto
            // 
            cboPruebasConjunto.BackColor = Color.FromArgb(248, 250, 255);
            cboPruebasConjunto.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPruebasConjunto.FlatStyle = FlatStyle.Flat;
            cboPruebasConjunto.Font = new Font("Segoe UI", 9.5F);
            cboPruebasConjunto.Location = new Point(180, 16);
            cboPruebasConjunto.Name = "cboPruebasConjunto";
            cboPruebasConjunto.Size = new Size(100, 25);
            cboPruebasConjunto.TabIndex = 0;
            cboPruebasConjunto.SelectedIndexChanged += cboPruebasConjunto_SelectedIndexChanged;
            // 
            // btnAplicarPruebas
            // 
            btnAplicarPruebas.BackColor = Color.FromArgb(40, 130, 60);
            btnAplicarPruebas.Cursor = Cursors.Hand;
            btnAplicarPruebas.FlatAppearance.BorderSize = 0;
            btnAplicarPruebas.FlatAppearance.MouseOverBackColor = Color.FromArgb(60, 160, 80);
            btnAplicarPruebas.FlatStyle = FlatStyle.Flat;
            btnAplicarPruebas.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnAplicarPruebas.ForeColor = Color.White;
            btnAplicarPruebas.Location = new Point(294, 12);
            btnAplicarPruebas.Name = "btnAplicarPruebas";
            btnAplicarPruebas.Size = new Size(160, 34);
            btnAplicarPruebas.TabIndex = 1;
            btnAplicarPruebas.Text = "Aplicar Pruebas";
            btnAplicarPruebas.UseVisualStyleBackColor = false;
            btnAplicarPruebas.Click += btnAplicarPruebas_Click;
            // 
            // rtbPruebas
            // 
            rtbPruebas.BackColor = Color.FromArgb(22, 27, 40);
            rtbPruebas.BorderStyle = BorderStyle.None;
            rtbPruebas.Font = new Font("Consolas", 9.5F);
            rtbPruebas.ForeColor = Color.FromArgb(190, 220, 255);
            rtbPruebas.Location = new Point(10, 54);
            rtbPruebas.Name = "rtbPruebas";
            rtbPruebas.ReadOnly = true;
            rtbPruebas.Size = new Size(1170, 638);
            rtbPruebas.TabIndex = 2;
            rtbPruebas.Text = "";
            rtbPruebas.WordWrap = false;
            // 
            // lblResumenPruebas
            // 
            lblResumenPruebas.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblResumenPruebas.ForeColor = Color.FromArgb(30, 130, 60);
            lblResumenPruebas.Location = new Point(10, 698);
            lblResumenPruebas.Name = "lblResumenPruebas";
            lblResumenPruebas.Size = new Size(1170, 24);
            lblResumenPruebas.TabIndex = 3;
            // 
            // tabMonteCarlo
            // 
            tabMonteCarlo.BackColor = Color.FromArgb(245, 247, 250);
            tabMonteCarlo.Controls.Add(lblAreaInfo);
            tabMonteCarlo.Controls.Add(lblConjuntoMC);
            tabMonteCarlo.Controls.Add(cboConjuntoMC);
            tabMonteCarlo.Controls.Add(btnMonteCarlo);
            tabMonteCarlo.Controls.Add(grpResumenMC);
            tabMonteCarlo.Controls.Add(grpGraficoMC);
            tabMonteCarlo.Location = new Point(4, 40);
            tabMonteCarlo.Name = "tabMonteCarlo";
            tabMonteCarlo.Padding = new Padding(10);
            tabMonteCarlo.Size = new Size(1192, 736);
            tabMonteCarlo.TabIndex = 2;
            tabMonteCarlo.Text = "  Monte Carlo  ";
            // 
            // lblAreaInfo
            // 
            lblAreaInfo.BackColor = Color.FromArgb(220, 232, 255);
            lblAreaInfo.Font = new Font("Segoe UI", 8.5F);
            lblAreaInfo.ForeColor = Color.FromArgb(20, 50, 120);
            lblAreaInfo.Location = new Point(10, 10);
            lblAreaInfo.Name = "lblAreaInfo";
            lblAreaInfo.Padding = new Padding(8, 0, 0, 0);
            lblAreaInfo.Size = new Size(890, 38);
            lblAreaInfo.TabIndex = 0;
            lblAreaInfo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblConjuntoMC
            // 
            lblConjuntoMC.AutoSize = true;
            lblConjuntoMC.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblConjuntoMC.ForeColor = Color.FromArgb(70, 70, 90);
            lblConjuntoMC.Location = new Point(912, 20);
            lblConjuntoMC.Name = "lblConjuntoMC";
            lblConjuntoMC.Size = new Size(81, 15);
            lblConjuntoMC.TabIndex = 1;
            lblConjuntoMC.Text = "Coordenadas:";
            // 
            // cboConjuntoMC
            // 
            cboConjuntoMC.BackColor = Color.FromArgb(248, 250, 255);
            cboConjuntoMC.DropDownStyle = ComboBoxStyle.DropDownList;
            cboConjuntoMC.FlatStyle = FlatStyle.Flat;
            cboConjuntoMC.Font = new Font("Segoe UI", 9F);
            cboConjuntoMC.Location = new Point(1008, 16);
            cboConjuntoMC.Name = "cboConjuntoMC";
            cboConjuntoMC.Size = new Size(82, 23);
            cboConjuntoMC.TabIndex = 0;
            cboConjuntoMC.SelectedIndexChanged += cboConjuntoMC_SelectedIndexChanged;
            // 
            // btnMonteCarlo
            // 
            btnMonteCarlo.BackColor = Color.FromArgb(160, 60, 20);
            btnMonteCarlo.Cursor = Cursors.Hand;
            btnMonteCarlo.FlatAppearance.BorderSize = 0;
            btnMonteCarlo.FlatAppearance.MouseOverBackColor = Color.FromArgb(200, 80, 30);
            btnMonteCarlo.FlatStyle = FlatStyle.Flat;
            btnMonteCarlo.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnMonteCarlo.ForeColor = Color.White;
            btnMonteCarlo.Location = new Point(1100, 8);
            btnMonteCarlo.Name = "btnMonteCarlo";
            btnMonteCarlo.Size = new Size(84, 42);
            btnMonteCarlo.TabIndex = 1;
            btnMonteCarlo.Text = "▶ ESTIMAR";
            btnMonteCarlo.UseVisualStyleBackColor = false;
            btnMonteCarlo.Click += btnMonteCarlo_Click;
            // 
            // grpResumenMC
            // 
            grpResumenMC.BackColor = Color.White;
            grpResumenMC.Controls.Add(dgvMonteCarlo);
            grpResumenMC.Controls.Add(rtbMonteCarlo);
            grpResumenMC.FlatStyle = FlatStyle.Flat;
            grpResumenMC.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            grpResumenMC.ForeColor = Color.FromArgb(160, 60, 20);
            grpResumenMC.Location = new Point(10, 58);
            grpResumenMC.Name = "grpResumenMC";
            grpResumenMC.Size = new Size(446, 666);
            grpResumenMC.TabIndex = 2;
            grpResumenMC.TabStop = false;
            grpResumenMC.Text = "  Resultados";
            // 
            // dgvMonteCarlo
            // 
            dgvMonteCarlo.AllowUserToAddRows = false;
            dgvMonteCarlo.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(255, 240, 235);
            dgvMonteCarlo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvMonteCarlo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMonteCarlo.BackgroundColor = Color.White;
            dgvMonteCarlo.BorderStyle = BorderStyle.None;
            dgvMonteCarlo.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvMonteCarlo.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(160, 60, 20);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvMonteCarlo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvMonteCarlo.ColumnHeadersHeight = 34;
            dgvMonteCarlo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(30, 30, 60);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(255, 200, 180);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(80, 10, 0);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvMonteCarlo.DefaultCellStyle = dataGridViewCellStyle6;
            dgvMonteCarlo.EnableHeadersVisualStyles = false;
            dgvMonteCarlo.GridColor = Color.FromArgb(230, 215, 210);
            dgvMonteCarlo.Location = new Point(8, 24);
            dgvMonteCarlo.Name = "dgvMonteCarlo";
            dgvMonteCarlo.ReadOnly = true;
            dgvMonteCarlo.RowHeadersVisible = false;
            dgvMonteCarlo.RowTemplate.Height = 28;
            dgvMonteCarlo.Size = new Size(430, 300);
            dgvMonteCarlo.TabIndex = 0;
            // 
            // rtbMonteCarlo
            // 
            rtbMonteCarlo.BackColor = Color.FromArgb(22, 27, 40);
            rtbMonteCarlo.BorderStyle = BorderStyle.None;
            rtbMonteCarlo.Font = new Font("Consolas", 8.5F);
            rtbMonteCarlo.ForeColor = Color.FromArgb(190, 220, 255);
            rtbMonteCarlo.Location = new Point(8, 332);
            rtbMonteCarlo.Name = "rtbMonteCarlo";
            rtbMonteCarlo.ReadOnly = true;
            rtbMonteCarlo.Size = new Size(430, 326);
            rtbMonteCarlo.TabIndex = 1;
            rtbMonteCarlo.Text = "";
            // 
            // grpGraficoMC
            // 
            grpGraficoMC.BackColor = Color.White;
            grpGraficoMC.Controls.Add(formsPlot2);
            grpGraficoMC.FlatStyle = FlatStyle.Flat;
            grpGraficoMC.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            grpGraficoMC.ForeColor = Color.FromArgb(30, 80, 150);
            grpGraficoMC.Location = new Point(464, 58);
            grpGraficoMC.Name = "grpGraficoMC";
            grpGraficoMC.Size = new Size(720, 666);
            grpGraficoMC.TabIndex = 3;
            grpGraficoMC.TabStop = false;
            grpGraficoMC.Text = "  Visualización de Puntos";
            // 
            // formsPlot2
            // 
            formsPlot2.DisplayScale = 1F;
            formsPlot2.Dock = DockStyle.Fill;
            formsPlot2.Location = new Point(3, 19);
            formsPlot2.Name = "formsPlot2";
            formsPlot2.Size = new Size(714, 644);
            formsPlot2.TabIndex = 0;
            // 
            // MonteCarloSimulacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 40, 60);
            ClientSize = new Size(1200, 749);
            Controls.Add(tabControl1);
            Font = new Font("Segoe UI", 9F);
            MinimumSize = new Size(1100, 720);
            Name = "MonteCarloSimulacion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Simulacion Monte Carlo  -  Barrera & Marino  -  UPTC  2026";
            tabControl1.ResumeLayout(false);
            tabGenerador.ResumeLayout(false);
            grpParametros.ResumeLayout(false);
            grpParametros.PerformLayout();
            grpTabla.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvGenerador).EndInit();
            grpGraficoGen.ResumeLayout(false);
            tabPruebas.ResumeLayout(false);
            tabPruebas.PerformLayout();
            tabMonteCarlo.ResumeLayout(false);
            tabMonteCarlo.PerformLayout();
            grpResumenMC.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvMonteCarlo).EndInit();
            grpGraficoMC.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabGenerador;
        private System.Windows.Forms.TabPage tabPruebas;
        private System.Windows.Forms.TabPage tabMonteCarlo;
        private System.Windows.Forms.GroupBox grpParametros;
        private System.Windows.Forms.Label lblModulo;
        private System.Windows.Forms.TextBox txtModulo;
        private System.Windows.Forms.Label lblMultiplicador;
        private System.Windows.Forms.TextBox txtMultiplicador;
        private System.Windows.Forms.Label lblIncremento;
        private System.Windows.Forms.TextBox txtIncremento;
        private System.Windows.Forms.Label lblSemilla;
        private System.Windows.Forms.TextBox txtSemilla;
        private System.Windows.Forms.Label lblConjunto;
        private System.Windows.Forms.ComboBox cboConjunto;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Label lblEstadoGen;
        private System.Windows.Forms.GroupBox grpTabla;
        private System.Windows.Forms.DataGridView dgvGenerador;
        private System.Windows.Forms.GroupBox grpGraficoGen;
        private ScottPlot.WinForms.FormsPlot formsPlot1;
        private System.Windows.Forms.Label lblPruebasConjunto;
        private System.Windows.Forms.ComboBox cboPruebasConjunto;
        private System.Windows.Forms.Button btnAplicarPruebas;
        private System.Windows.Forms.RichTextBox rtbPruebas;
        private System.Windows.Forms.Label lblResumenPruebas;
        private System.Windows.Forms.Label lblAreaInfo;
        private System.Windows.Forms.Label lblConjuntoMC;
        private System.Windows.Forms.ComboBox cboConjuntoMC;
        private System.Windows.Forms.Button btnMonteCarlo;
        private System.Windows.Forms.GroupBox grpResumenMC;
        private System.Windows.Forms.DataGridView dgvMonteCarlo;
        private System.Windows.Forms.RichTextBox rtbMonteCarlo;
        private System.Windows.Forms.GroupBox grpGraficoMC;
        private ScottPlot.WinForms.FormsPlot formsPlot2;
    }
}