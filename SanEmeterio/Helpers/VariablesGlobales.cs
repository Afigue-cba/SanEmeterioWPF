using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows ;
using System.Windows.Media;

namespace SanEmeterio.Helpers
{
    public class VariablesGlobales
    {
        public static string NombreBase;
        public static string Usuario;
        public static int IdUsuario;
        public static Color ColorForm;
        public static string Camino = GetMyBinDirectory();
        public static Color ColorBoton;
        public static Color ColorLetras;
        public static Color ColorTexto;
        public static Color ColorFondoTexto;
        public static Color ColorFondo;
       // public static int TamFuente = Settings.Default.TamFuente;
        public static string Formularios_Acoplados;
        public static string sSaldo;


        public static string GetMyBinDirectory()
        {
            return Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName);
        }

    }
}
