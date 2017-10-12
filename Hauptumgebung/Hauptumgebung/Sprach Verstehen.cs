using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Recognition;

namespace Hauptumgebung
{
    public static class Sprach_Verstehen
    {

        public static void Sprachezutext()
        {
             
            SpeechRecognitionEngine recognizer = new SpeechRecognitionEngine( new System.Globalization.CultureInfo("de-DE"));

                                    
        }

        public static void recognizer_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            
            if (e.Result.Text == "e")
            {
                Sprachausgabe.speech1();
            }




        }

    }
}
