using TallerDeCoches_ProyectoFinal_ReyesÁlvarez.Forms_Identificación;

namespace TallerDeCoches_ProyectoFinal_ReyesÁlvarez
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
            //Application.Run(new Form_Login());
            //Application.Run(new Form_Empleado());
            Application.Run(new Form_Cliente());
        }
    }
}