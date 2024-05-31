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
            GestorReportesDeReseñas Gestor = new GestorReportesDeReseñas();  //a chequear.
            Application.Run(new habilitarPantalla(Gestor));

        }
    }
}