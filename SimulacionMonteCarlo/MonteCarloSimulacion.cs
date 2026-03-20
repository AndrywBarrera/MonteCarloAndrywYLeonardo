using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ScottPlot;

namespace SimulacionMonteCarlo.SimulacionMonteCarlo
{
    public partial class MonteCarloSimulacion : Form
    {
        private GeneradorCongruencial? _gen;
        private MonteCarlo _mc = new();

        private static readonly int[] ConjuntosGen = { 20, 200, 2000, 10000, 20000 };
        private static readonly int[] ConjuntosMC = { 10, 100, 1000, 5000, 10000 };

        public MonteCarloSimulacion()
        {
            InitializeComponent();
            CargarValoresIniciales();
        }
        // ─────────────────────────────────────────────────────────────────────
        // CARGA INICIAL
        // ─────────────────────────────────────────────────────────────────────
        private void CargarValoresIniciales()
        {
            // Parámetros por defecto (Hull-Dobell: período completo)
            txtModulo.Text = "65536";
            txtMultiplicador.Text = "1541";
            txtIncremento.Text = "2957";
            txtSemilla.Text = "12345";

            // Combos del generador
            cboConjunto.Items.Clear();
            foreach (int c in ConjuntosGen) cboConjunto.Items.Add(c);
            cboConjunto.SelectedIndex = 0;

            // Combos de pruebas (mismos valores)
            cboPruebasConjunto.Items.Clear();
            foreach (int c in ConjuntosGen) cboPruebasConjunto.Items.Add(c);
            cboPruebasConjunto.SelectedIndex = 0;

            // Combos de Monte Carlo
            cboConjuntoMC.Items.Clear();
            foreach (int c in ConjuntosMC) cboConjuntoMC.Items.Add(c);
            cboConjuntoMC.SelectedIndex = 0;

            // Info del área
            lblAreaInfo.Text =
                $"Área 2 — f(x)=sin(x), g(x)=x², h(x)=cos(x)  |  " +
                $"Región 1: [0, π/4] sin(x)−x²   Región 2: [π/4, 0.8241] cos(x)−x²  |  " +
                $"Área exacta = {MonteCarlo.AREA_REAL:F7}  |  " +
                $"Rectángulo contenedor: x∈[0, {MonteCarlo.X_MAX}], y∈[0,1]  Área rect = {MonteCarlo.AreaRect:F4}";
        }

        // ─────────────────────────────────────────────────────────────────────
        // TAB 1 — GENERADOR CONGRUENCIAL
        // ─────────────────────────────────────────────────────────────────────

        // Evento: botón GENERAR
        private void btnGenerar_Click(object sender, EventArgs e)
        {
            if (!LeerParametros(out long m, out long a, out long c, out long x0)) return;

            string err = GeneradorCongruencial.Validar(m, a, c, x0);
            if (!string.IsNullOrEmpty(err))
            {
                MessageBox.Show(err, "Parámetros inválidos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Generar siempre el máximo necesario para que MC y distribución funcionen
            int maxNecesario = ConjuntosMC.Max() * 2 + 100;
            _gen = new GeneradorCongruencial(m, a, c, x0);
            _gen.Generar(maxNecesario);

            if (_gen.CicloDetectado)
                MessageBox.Show(
                    $"⚠ Ciclo detectado en iteración {_gen.IteracionCiclo}.\n" +
                    "Se usarán los números generados hasta ese punto.\n" +
                    "Para evitarlo: aumente el módulo o ajuste los parámetros.",
                    "Ciclo detectado", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            int n = (int)cboConjunto.SelectedItem!;
            ActualizarTablaYGrafico(n);

            lblEstadoGen.Text =
                $"✔  {_gen.ValoresUn.Count:N0} números generados  |  Mostrando: {n:N0} valores";
        }

        // Evento: cambio de conjunto en el combo del generador
        private void cboConjunto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_gen == null) return;
            int n = (int)cboConjunto.SelectedItem!;
            ActualizarTablaYGrafico(n);
        }

        private void ActualizarTablaYGrafico(int n)
        {
            MostrarTabla(n);
            GraficarDistribucion(n);
        }

        private void MostrarTabla(int n)
        {
            if (_gen == null) return;
            int limite = Math.Min(n, _gen.ValoresXn.Count);

            dgvGenerador.SuspendLayout();
            dgvGenerador.Rows.Clear();
            dgvGenerador.Columns.Clear();

            dgvGenerador.Columns.Add("Iteracion", "Iteración");
            dgvGenerador.Columns.Add("Xn", "Xn");
            dgvGenerador.Columns.Add("Un", "Un [0,1]");

            for (int i = 0; i < limite; i++)
                dgvGenerador.Rows.Add(i + 1,
                                      _gen.ValoresXn[i],
                                      _gen.ValoresUn[i].ToString("F8"));

            dgvGenerador.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dgvGenerador.ResumeLayout();
        }

        private void GraficarDistribucion(int n)
        {
            if (_gen == null) return;
            int limite = Math.Min(n, _gen.ValoresUn.Count);
            var datos = _gen.ValoresUn.Take(limite).ToList();

            const int RANGOS = 10;
            double[] freq = new double[RANGOS];
            foreach (double u in datos)
                freq[Math.Min((int)(u * RANGOS), RANGOS - 1)]++;

            var plt = formsPlot1.Plot;
            plt.Clear();

            // ScottPlot 5: se crean barras una por una
            for (int i = 0; i < RANGOS; i++)
            {
                var bar = plt.Add.Bar(position: i, value: freq[i]);
                bar.Color = ScottPlot.Colors.SteelBlue;
            }

            // Línea de frecuencia esperada
            double esperada = (double)limite / RANGOS;
            plt.Add.HorizontalLine(esperada, 2, ScottPlot.Colors.OrangeRed);

            // Etiquetas del eje X con los rangos
            ScottPlot.Tick[] ticks = Enumerable.Range(0, RANGOS)
                .Select(i => new ScottPlot.Tick(i, $"{i * 0.1:F1}-{(i + 1) * 0.1:F1}"))
                .ToArray();
            plt.Axes.Bottom.TickGenerator = new ScottPlot.TickGenerators.NumericManual(ticks);

            plt.Axes.Bottom.Label.Text = "Rango [0, 1]";
            plt.Axes.Left.Label.Text = "Frecuencia";
            plt.Title($"Distribución – {limite:N0} valores  (10 rangos)");

            formsPlot1.Refresh();
        }
        // ─────────────────────────────────────────────────────────────────────
        // TAB 2 — PRUEBAS DE ALEATORIEDAD
        // ─────────────────────────────────────────────────────────────────────

        // Evento: cambio de conjunto en pruebas
        private void cboPruebasConjunto_SelectedIndexChanged(object sender, EventArgs e)
        {
            EjecutarPruebas();
        }

        // Evento: botón Aplicar pruebas (opcional, para refrescar manualmente)
        private void btnAplicarPruebas_Click(object sender, EventArgs e)
        {
            EjecutarPruebas();
        }

        private void EjecutarPruebas()
        {
            if (_gen == null || _gen.ValoresUn.Count < 20)
            {
                rtbPruebas.Text = "Primero genere números en la pestaña 'Generador'.";
                return;
            }

            int n = (int)cboPruebasConjunto.SelectedItem!;
            var sub = _gen.ValoresUn.Take(Math.Min(n, _gen.ValoresUn.Count)).ToList();

            var resultados = new[]
            {
                PruebasAleatoriedad.PruebaMedia(sub),
                PruebasAleatoriedad.PruebaVarianza(sub),
                PruebasAleatoriedad.PruebaChiCuadrado(sub),
                PruebasAleatoriedad.PruebaKolmogorovSmirnov(sub),
                PruebasAleatoriedad.PruebaRachas(sub)
            };

            var sb = new System.Text.StringBuilder();
            sb.AppendLine("═══════════════════════════════════════════════════");
            sb.AppendLine($"   PRUEBAS DE ALEATORIEDAD — {sub.Count:N0} valores");
            sb.AppendLine("═══════════════════════════════════════════════════");
            sb.AppendLine();
            foreach (var r in resultados)
            {
                sb.AppendLine(new string('─', 51));
                sb.AppendLine(r.Detalle);
            }
            sb.AppendLine(new string('═', 51));
            int ok = resultados.Count(r => r.Aprobada);
            sb.AppendLine($"   RESUMEN: {ok}/{resultados.Length} pruebas aprobadas");
            sb.AppendLine("═══════════════════════════════════════════════════");

            rtbPruebas.Text = sb.ToString();

            lblResumenPruebas.Text =
                $"Aprobadas: {ok}/{resultados.Length}   " +
                string.Join("   ", resultados.Select(r => $"{r.Nombre}: {(r.Aprobada ? "✔" : "✖")}"));
            lblResumenPruebas.ForeColor = ok == resultados.Length ? System.Drawing.Color.DarkGreen : System.Drawing.Color.DarkOrange;
        }

        // ─────────────────────────────────────────────────────────────────────
        // TAB 3 — MONTE CARLO
        // ─────────────────────────────────────────────────────────────────────

        // Evento: botón ESTIMAR ÁREA
        private void btnMonteCarlo_Click(object sender, EventArgs e)
        {
            if (_gen == null || _gen.ValoresUn.Count == 0)
            {
                MessageBox.Show("Primero genere números en la pestaña 'Generador'.",
                                "Sin datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int n = (int)cboConjuntoMC.SelectedItem!;
            _mc = new MonteCarlo();
            string err = _mc.Ejecutar(_gen.ValoresUn, n);
            if (!string.IsNullOrEmpty(err))
            {
                MessageBox.Show(err, "Datos insuficientes",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MostrarResultadosMC();
            GraficarMC();
        }

        // Evento: cambio de conjunto MC
        private void cboConjuntoMC_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_gen != null && _gen.ValoresUn.Count > 0)
                btnMonteCarlo_Click(sender, e);
        }

        private void MostrarResultadosMC()
        {
            // DataGridView de resultados
            dgvMonteCarlo.Rows.Clear();
            dgvMonteCarlo.Columns.Clear();
            dgvMonteCarlo.Columns.Add("Campo", "Campo");
            dgvMonteCarlo.Columns.Add("Valor", "Valor");
            dgvMonteCarlo.Columns[0].Width = 230;
            dgvMonteCarlo.Columns[1].Width = 150;

            dgvMonteCarlo.Rows.Add("Área conocida (exacta)", $"{MonteCarlo.AREA_REAL:F7}");
            dgvMonteCarlo.Rows.Add("Área estimada (Monte Carlo)", $"{_mc.AreaEstimada:F7}");
            dgvMonteCarlo.Rows.Add("Total de puntos", $"{_mc.TotalPuntos:N0}");
            dgvMonteCarlo.Rows.Add("Puntos dentro del área", $"{_mc.PuntosDentro:N0}");
            dgvMonteCarlo.Rows.Add("Puntos fuera del área", $"{_mc.TotalPuntos - _mc.PuntosDentro:N0}");
            dgvMonteCarlo.Rows.Add("Área rectángulo contenedor", $"{MonteCarlo.AreaRect:F4}");
            dgvMonteCarlo.Rows.Add("Error teórico", $"{_mc.ErrorTeorico:F7}");
            dgvMonteCarlo.Rows.Add("Error real |est − exacta|", $"{_mc.ErrorReal:F7}");
            dgvMonteCarlo.Rows.Add("Error relativo", $"{_mc.ErrorRelativo:F4} %");

            // RichTextBox con detalle
            rtbMonteCarlo.Text =
                "═══════════════════════════════════════════════════\n" +
                $"  MONTE CARLO — {_mc.TotalPuntos:N0} coordenadas\n" +
                "═══════════════════════════════════════════════════\n\n" +
                "  f(x)=sin(x), g(x)=x², h(x)=cos(x)\n" +
                "  Región 1 [0, π/4]    :  x² ≤ y ≤ sin(x)\n" +
                "  Región 2 [π/4, 0.8241]:  x² ≤ y ≤ cos(x)\n\n" +
                _mc.Resumen() + "\n" +
                $"  Error teórico ≈ rect/√n = {MonteCarlo.AreaRect:F4}/√{_mc.TotalPuntos}\n" +
                $"                          = {_mc.ErrorTeorico:F7}\n" +
                $"  (A más puntos → menor error, converge ~1/√n)";
        }

        private void GraficarMC()
{
    var xDentro = new List<double>(); var yDentro = new List<double>();
    var xFuera  = new List<double>(); var yFuera  = new List<double>();

    for (int i = 0; i < _mc.TotalPuntos; i++)
    {
        if (_mc.Dentro[i]) { xDentro.Add(_mc.PuntosX[i]); yDentro.Add(_mc.PuntosY[i]); }
        else               { xFuera.Add(_mc.PuntosX[i]);  yFuera.Add(_mc.PuntosY[i]);  }
    }

    var plt = formsPlot2.Plot;
    plt.Clear();

    // Puntos fuera (rojo)
    if (xFuera.Count > 0)
    {
        var sc = plt.Add.Scatter(xFuera.ToArray(), yFuera.ToArray());
        sc.Color       = ScottPlot.Colors.Salmon;
        sc.MarkerSize  = 4;
        sc.LineWidth   = 0;
        sc.LegendText  = $"Fuera ({xFuera.Count:N0})";
    }

    // Puntos dentro (azul)
    if (xDentro.Count > 0)
    {
        var sc = plt.Add.Scatter(xDentro.ToArray(), yDentro.ToArray());
        sc.Color       = ScottPlot.Colors.SteelBlue;
        sc.MarkerSize  = 4;
        sc.LineWidth   = 0;
        sc.LegendText  = $"Dentro ({xDentro.Count:N0})";
    }

    // Curvas de las funciones
    int m      = 400;
    double[] xs = Enumerable.Range(0, m + 1)
        .Select(i => MonteCarlo.X_MIN + i * (MonteCarlo.X_MAX - MonteCarlo.X_MIN) / m)
        .ToArray();

    var lSin = plt.Add.Scatter(xs, xs.Select(Math.Sin).ToArray());
    lSin.Color = ScottPlot.Colors.DarkGreen; lSin.MarkerSize = 0;
    lSin.LineWidth = 2; lSin.LegendText = "sin(x)";

    var lCos = plt.Add.Scatter(xs, xs.Select(Math.Cos).ToArray());
    lCos.Color = ScottPlot.Colors.DarkOrange; lCos.MarkerSize = 0;
    lCos.LineWidth = 2; lCos.LegendText = "cos(x)";

    var lX2 = plt.Add.Scatter(xs, xs.Select(x => x * x).ToArray());
    lX2.Color = ScottPlot.Colors.Purple; lX2.MarkerSize = 0;
    lX2.LineWidth = 2; lX2.LegendText = "x²";

    // Línea divisoria en π/4
    plt.Add.VerticalLine(MonteCarlo.PI4, 1, ScottPlot.Colors.Gray);

    plt.Title($"Monte Carlo — {_mc.TotalPuntos:N0} puntos | Área ≈ {_mc.AreaEstimada:F6}");
    plt.Axes.Bottom.Label.Text = "x";
    plt.Axes.Left.Label.Text   = "y";
    plt.ShowLegend();
    formsPlot2.Refresh();
}
        private bool LeerParametros(out long m, out long a, out long c, out long x0)
        {
            m = a = c = x0 = 0;
            if (!long.TryParse(txtModulo.Text.Trim(), out m) ||
                !long.TryParse(txtMultiplicador.Text.Trim(), out a) ||
                !long.TryParse(txtIncremento.Text.Trim(), out c) ||
                !long.TryParse(txtSemilla.Text.Trim(), out x0))
            {
                MessageBox.Show("Todos los parámetros deben ser números enteros.",
                                "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}
