using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace mass_groundstation_v2
{
    static class Program
    {
        public static Form main_form;
        public static string application_start_time;
        public static string application_path;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            application_start_time = DateTime.Now.ToString("ddMM_HH_mm_ss"); //get time of application start - used for log files
            var process = Process.GetCurrentProcess();
            application_path = System.IO.Path.GetDirectoryName(Application.ExecutablePath).ToString(); //get path of application - used for log files

            System.IO.Directory.CreateDirectory(Program.application_path + "\\" + Program.application_start_time); //create directory in application folder
            System.IO.Directory.CreateDirectory("C:\\bexus_logs\\" + Program.application_start_time); //create extra directory in C:\\


            main_form = new Form();
            Application.Run(main_form);
        }
    }
}
