using SimulacionMonteCarlo.SimulacionMonteCarlo;
using System;
using System.Windows.Forms;

namespace SimulacionMonteCarlo
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new MonteCarloSimulacion());
        }
    }
}
