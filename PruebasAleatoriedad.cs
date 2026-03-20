namespace SimulacionMonteCarlo
{
    public class ResultadoPrueba
    {
        public string Nombre { get; }
        public bool Aprobada { get; }
        public string Detalle { get; }
        public ResultadoPrueba(string nombre, bool aprobada, string detalle)
        { Nombre = nombre; Aprobada = aprobada; Detalle = detalle; }
    }

    public static class PruebasAleatoriedad
    {
        // ── 1. Prueba de Media ────────────────────────────────────────────────
        public static ResultadoPrueba PruebaMedia(List<double> un)
        {
            int n = un.Count;
            double media = un.Average();
            double sigma = Math.Sqrt(1.0 / (12.0 * n));
            double limite = 1.96 * sigma;
            double error = Math.Abs(media - 0.5);
            bool ok = error <= limite;

            string txt =
                "▶ PRUEBA DE MEDIA\n" +
                $"   Media calculada  : {media:F6}\n" +
                $"   Media esperada   : 0.500000\n" +
                $"   |μ - 0.5|        : {error:F6}\n" +
                $"   Límite 1.96·σ    : {limite:F6}\n" +
                $"   Resultado        : {(ok ? "✔ APROBADA" : "✖ RECHAZADA")}\n";
            return new ResultadoPrueba("Media", ok, txt);
        }

        // ── 2. Prueba de Varianza ─────────────────────────────────────────────
        public static ResultadoPrueba PruebaVarianza(List<double> un)
        {
            int n = un.Count;
            double media = un.Average();
            double varCalc = un.Sum(u => (u - media) * (u - media)) / n;
            double varEsp = 1.0 / 12.0;
            double sigma = Math.Sqrt(2.0 / (144.0 * n));
            double limite = 1.96 * sigma;
            double error = Math.Abs(varCalc - varEsp);
            bool ok = error <= limite;

            string txt =
                "▶ PRUEBA DE VARIANZA\n" +
                $"   Varianza calculada  : {varCalc:F6}\n" +
                $"   Varianza esperada   : {varEsp:F6}  (1/12)\n" +
                $"   Error               : {error:F6}\n" +
                $"   Límite 1.96·σ       : {limite:F6}\n" +
                $"   Resultado           : {(ok ? "✔ APROBADA" : "✖ RECHAZADA")}\n";
            return new ResultadoPrueba("Varianza", ok, txt);
        }

        // ── 3. Prueba Chi-Cuadrado ────────────────────────────────────────────
        public static ResultadoPrueba PruebaChiCuadrado(List<double> un)
        {
            int k = 10;
            int n = un.Count;
            double esp = (double)n / k;
            int[] obs = new int[k];
            foreach (double u in un) obs[Math.Min((int)(u * k), k - 1)]++;

            double chi2 = obs.Sum(o => Math.Pow(o - esp, 2) / esp);
            double critico = 16.919;  // χ²(0.05, gl=9)
            bool ok = chi2 <= critico;

            var sb = new System.Text.StringBuilder();
            sb.AppendLine("▶ PRUEBA CHI-CUADRADO  (α=0.05, k=10, gl=9)");
            sb.AppendLine($"   Frecuencia esperada : {esp:F2}");
            for (int i = 0; i < k; i++)
                sb.AppendLine($"   Rango [{i * 0.1:F1}-{(i + 1) * 0.1:F1}): obs={obs[i]}  (esp={esp:F1})");
            sb.AppendLine($"   χ² calculado : {chi2:F4}");
            sb.AppendLine($"   χ² crítico   : {critico:F4}");
            sb.AppendLine($"   Resultado    : {(ok ? "✔ APROBADA" : "✖ RECHAZADA")}");
            return new ResultadoPrueba("Chi-Cuadrado", ok, sb.ToString());
        }

        // ── 4. Prueba Kolmogorov-Smirnov ──────────────────────────────────────
        public static ResultadoPrueba PruebaKolmogorovSmirnov(List<double> un)
        {
            int n = un.Count;
            var sorted = un.OrderBy(u => u).ToList();
            double Dmax = 0;
            for (int i = 0; i < n; i++)
            {
                double D = Math.Max(Math.Abs((i + 1.0) / n - sorted[i]),
                                    Math.Abs(sorted[i] - (double)i / n));
                if (D > Dmax) Dmax = D;
            }
            double critico = 1.36 / Math.Sqrt(n);
            bool ok = Dmax <= critico;

            string txt =
                "▶ PRUEBA KOLMOGOROV-SMIRNOV  (α=0.05)\n" +
                $"   n           : {n}\n" +
                $"   D calculado : {Dmax:F6}\n" +
                $"   D crítico   : {critico:F6}  (1.36/√n)\n" +
                $"   Resultado   : {(ok ? "✔ APROBADA" : "✖ RECHAZADA")}\n";
            return new ResultadoPrueba("K-S", ok, txt);
        }

        // ── 5. Prueba de Rachas ────────────────────────────────────────────────
        public static ResultadoPrueba PruebaRachas(List<double> un)
        {
            int n = un.Count;
            double mu = un.Average();
            bool[] s = un.Select(u => u >= mu).ToArray();
            int n1 = s.Count(b => b), n2 = n - n1;
            int r = 1;
            for (int i = 1; i < n; i++) if (s[i] != s[i - 1]) r++;

            double mr = (2.0 * n1 * n2) / n + 1.0;
            double vr = (2.0 * n1 * n2 * (2.0 * n1 * n2 - n)) / ((double)n * n * (n - 1));
            double z = (r - mr) / Math.Sqrt(vr);
            bool ok = Math.Abs(z) <= 1.96;

            string txt =
                "▶ PRUEBA DE RACHAS  (α=0.05, z±1.96)\n" +
                $"   n₁ (≥ media)     : {n1}\n" +
                $"   n₂ (< media)     : {n2}\n" +
                $"   Número de rachas : {r}\n" +
                $"   E[R]             : {mr:F4}\n" +
                $"   Z                : {z:F4}\n" +
                $"   Resultado        : {(ok ? "✔ APROBADA" : "✖ RECHAZADA")}\n";
            return new ResultadoPrueba("Rachas", ok, txt);
        }
    }
}
