namespace RussoBarberisPriotti_GestorArchivos.src
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
            Application.Run(new FormMenu());
        }
        public static bool EsNombreDeArchivoValido(string fileName)
        {
            if (string.IsNullOrWhiteSpace(fileName))
            {
                return false;
            }

            // Comprobando si el nombre contiene alguno de los caracteres inválidos.
            char[] caracteresInvalidos = Path.GetInvalidFileNameChars();
            if (fileName.Any(c => caracteresInvalidos.Contains(c)))
            {
                return false;
            }

            // Comprobando nombres reservados de windows
            string[] nombresReservados = { "CON", "PRN", "AUX", "NUL", "COM1", "COM2", "COM3", "COM4", "COM5", "COM6", "COM7", "COM8", "COM9", "LPT1", "LPT2", "LPT3", "LPT4", "LPT5", "LPT6", "LPT7", "LPT8", "LPT9" };
            if (nombresReservados.Contains(fileName.ToUpper()))
            {
                return false;
            }

            return true;
        }
    }
}