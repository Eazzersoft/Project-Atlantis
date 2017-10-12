using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Recognition;
using System.Speech.Synthesis;
using System.Threading;


namespace Hauptumgebung
{
    public static class Sprach_Verstehen
    {

        public static void Sprachezutext()
        {
            
            using (SpeechRecognitionEngine hoerer = new SpeechRecognitionEngine(new System.Globalization.CultureInfo("de-DE")))
            {
                
                hoerer.LoadGrammar(new DictationGrammar());

                hoerer.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(recognizer_SpeechRecognized);

                hoerer.SetInputToDefaultAudioDevice();

               while (true)
                {
                    hoerer.Recognize();
                }
                
            }


        }

        public static void recognizer_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            
            if (e.Result.Text == "Hallo")
            {
                SpeechSynthesizer synth = new SpeechSynthesizer();
                synth.SetOutputToDefaultAudioDevice();
                synth.Speak("hallo");
            }




        }

    }
}
