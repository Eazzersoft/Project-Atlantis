using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hauptumgebung
{
    class AI
    {
        /* TEXT TO COMMAND */
         public string TextToCommand(String argument)
        {
            

            return null;
        }
        private bool search(String argument, ref string software)
        {
            return false;
        }
        private string RunSoftware(string software)
        {
            try
            {
                System.Diagnostics.Process.Start(software);
                return software + "wurde gestartet.";
            }
            catch (Exception e)
            {
                return "Ein Fehler ist aufgetreten: " + e.Message;
            }
           
        }
        private string Time()
        {
            return "Es ist derzeit: " + DateTime.Now.ToString("h:mm:ss tt");
        }
        private string Date()
        { }
            

    }
}
