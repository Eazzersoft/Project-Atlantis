using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Recognition;

namespace Hauptumgebung
{
    public class Sprach_Verstehen
    {

        static void Sprachezutext(string[] args)
        {
            SpeechRecognitionEngine recognizer = new SpeechRecognitionEngine( new System.Globalization.CultureInfo("de-DE"));
        }

        static void recognizer_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            
            if (e.Result.Text == "Hallo")
            {
                Sprachausgabe.speech1();
            }




        }

    }
}
