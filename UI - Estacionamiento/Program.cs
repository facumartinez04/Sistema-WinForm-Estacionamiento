using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI___Estacionamiento.Auth;
using UI___Estacionamiento.PanelsMain;
using UI___Estacionamiento.PanelsMain.IngresosForms;

namespace UI___Estacionamiento
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Thread.CurrentThread.CurrentUICulture = new CultureInfo("es-ES");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (Properties.Settings.Default.IsFirstTime)
            {

                Application.Run(new formAuthRegister());
               
            }
            else
            {
                Application.Run(new formAuthMain());
            }


        }
    }
}
