using System.Globalization;


namespace Secretariat_Soft

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
            
            
            //Culture info settings --------------------------------
            CultureInfo culture =  new CultureInfo("en-US");
            culture.DateTimeFormat.ShortDatePattern = "yyyy-MM-dd";
            culture.DateTimeFormat.ShortTimePattern = "HH:mm:ss";
            //-----------------------------
            CultureInfo.DefaultThreadCurrentCulture = culture;
            CultureInfo.DefaultThreadCurrentUICulture = culture;
            //------------------------------------------------------

            ApplicationConfiguration.Initialize();
            Application.Run(new Secretariat_Forms.Incoming_Letters_Form());
        }
    }
}