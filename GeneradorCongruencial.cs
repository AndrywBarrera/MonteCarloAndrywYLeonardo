namespace SimulacionMonteCarlo
{
    /// <summary>
    /// Generador de números pseudoaleatorios — Método Congruencial Lineal
    /// Fórmula: X(n+1) = (a * Xn + c) mod m
    /// </summary>
    public class GeneradorCongruencial
    {
        public long Modulo { get; private set; }
        public long Multiplicador { get; private set; }
        public long Incremento { get; private set; }
        public long Semilla { get; private set; }

        public List<long> ValoresXn { get; private set; } = new();
        public List<double> ValoresUn { get; private set; } = new();

        public bool CicloDetectado { get; private set; } = false;
        public int IteracionCiclo { get; private set; } = -1;

        public GeneradorCongruencial(long modulo, long multiplicador, long incremento, long semilla)
        {
            Modulo = modulo;
            Multiplicador = multiplicador;
            Incremento = incremento;
            Semilla = semilla;
        }

        /// <summary>Genera 'cantidad' números pseudoaleatorios detectando ciclos.</summary>
        public void Generar(int cantidad)
        {
            ValoresXn.Clear();
            ValoresUn.Clear();
            CicloDetectado = false;
            IteracionCiclo = -1;

            var vistos = new HashSet<long>();
            long x = Semilla;

            for (int i = 0; i < cantidad; i++)
            {
                x = (Multiplicador * x + Incremento) % Modulo;

                if (vistos.Contains(x))
                {
                    CicloDetectado = true;
                    IteracionCiclo = i + 1;
                    break;
                }

                vistos.Add(x);
                ValoresXn.Add(x);
                ValoresUn.Add((double)x / Modulo);  // Normalización: Un = Xn / m ∈ [0,1)
            }
        }

        /// <summary>Valida parámetros y retorna mensaje de error, o vacío si son válidos.</summary>
        public static string Validar(long m, long a, long c, long x0)
        {
            if (m <= 0) return "El módulo m debe ser mayor a 0.";
            if (a <= 0 || a >= m) return $"El multiplicador a debe estar entre 1 y {m - 1}.";
            if (c < 0 || c >= m) return $"El incremento c debe estar entre 0 y {m - 1}.";
            if (x0 < 0 || x0 >= m) return $"La semilla X0 debe estar entre 0 y {m - 1}.";
            if (c > 0 && MCD(c, m) != 1)
                return $"Para período completo se requiere mcd(c, m) = 1.\n" +
                       $"mcd({c}, {m}) = {MCD(c, m)}. Cambie el incremento.";
            return string.Empty;
        }

        private static long MCD(long a, long b)
        {
            while (b != 0) { long t = b; b = a % b; a = t; }
            return a;
        }
    }
}
