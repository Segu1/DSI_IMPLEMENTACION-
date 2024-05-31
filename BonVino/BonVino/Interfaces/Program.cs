using BonVino.Entidades;
using BonVino.Gestor;

namespace BonVino.Interfaces
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            GestorReportesDeRese�as Gestor = new GestorReportesDeRese�as();  //a chequear.
            Application.Run(new habilitarPantalla(Gestor));

        }
    }
}