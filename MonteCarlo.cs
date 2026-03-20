namespace SimulacionMonteCarlo
{
    /// <summary>
    /// Estimación de Área 2 por Monte Carlo — Barrera / Mariño UPTC
    ///
    /// Funciones: f(x)=sin(x), g(x)=x², h(x)=cos(x)
    /// Intersecciones:
    ///   A = (0, 0)           → sin(x) = x²
    ///   B = (π/4, √2/2)      → sin(x) = cos(x)
    ///   C = (0.8241, 0.6791) → x²     = cos(x)
    ///
    /// Región 1: x ∈ [0,    π/4   ] → superior: sin(x), inferior: x²
    /// Región 2: x ∈ [π/4,  0.8241] → superior: cos(x), inferior: x²
    ///
    /// Área exacta:
    ///   A1 = 1 − √2/2 − π³/192 ≈ 0.1314032
    ///   A2 ≈ 0.0017
    ///   TOTAL ≈ 0.1331032
    ///
    /// Rectángulo contenedor: x∈[0, 0.8241], y∈[0, 1]
    /// </summary>
    public class MonteCarlo
    {
        public const double X_MIN = 0.0;
        public const double X_MAX = 0.8241;
        public const double Y_MIN = 0.0;
        public const double Y_MAX = 1.0;
        public const double PI4 = Math.PI / 4.0;   // ≈ 0.785398
        public const double AREA_REAL = 0.1331032;

        public static double AreaRect => (X_MAX - X_MIN) * (Y_MAX - Y_MIN);

        // Resultados
        public List<double> PuntosX { get; } = new();
        public List<double> PuntosY { get; } = new();
        public List<bool> Dentro { get; } = new();

        public int TotalPuntos => PuntosX.Count;
        public int PuntosDentro => Dentro.Count(d => d);
        public double AreaEstimada => AreaRect * PuntosDentro / TotalPuntos;
        public double ErrorReal => Math.Abs(AreaEstimada - AREA_REAL);
        public double ErrorRelativo => ErrorReal / AREA_REAL * 100.0;
        public double ErrorTeorico => AreaRect / Math.Sqrt(TotalPuntos);

        /// <summary>
        /// Ejecuta la simulación. Retorna mensaje de error o vacío si OK.
        /// Usa pares consecutivos de valoresUn como coordenadas (x, y).
        /// </summary>
        public string Ejecutar(List<double> un, int cantidad)
        {
            if (un.Count < cantidad * 2)
                return $"Necesita {cantidad * 2} números para {cantidad} coordenadas.\n" +
                       $"Solo tiene {un.Count}. Genere más números primero.";

            PuntosX.Clear(); PuntosY.Clear(); Dentro.Clear();

            for (int i = 0; i + 1 < cantidad * 2; i += 2)
            {
                double x = X_MIN + un[i] * (X_MAX - X_MIN);
                double y = Y_MIN + un[i + 1] * (Y_MAX - Y_MIN);
                PuntosX.Add(x);
                PuntosY.Add(y);
                Dentro.Add(EsDentro(x, y));
            }
            return string.Empty;
        }

        private static bool EsDentro(double x, double y)
        {
            double inf = x * x;                          // g(x) = x²  (siempre inferior)
            double sup = x <= PI4 ? Math.Sin(x)          // Región 1: sin(x)
                                  : Math.Cos(x);         // Región 2: cos(x)
            return y >= inf && y <= sup;
        }

        public string Resumen() =>
            $"  Área conocida (exacta)    : {AREA_REAL:F7}\n" +
            $"  Área estimada Monte Carlo : {AreaEstimada:F7}\n" +
            $"  Total puntos              : {TotalPuntos:N0}\n" +
            $"  Puntos dentro del área    : {PuntosDentro:N0}\n" +
            $"  Puntos fuera  del área    : {TotalPuntos - PuntosDentro:N0}\n" +
            $"  Área rectángulo cont.     : {AreaRect:F4}\n" +
            $"  Error teórico  (rect/√n)  : {ErrorTeorico:F7}\n" +
            $"  Error real     |est−real| : {ErrorReal:F7}\n" +
            $"  Error relativo            : {ErrorRelativo:F4} %\n";
    }
}
