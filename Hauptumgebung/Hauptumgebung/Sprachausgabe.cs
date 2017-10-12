using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Synthesis;

namespace Hauptumgebung
{
    public class Sprachausgabe 
    {
       void speech()
        {
            Form1 frm = new Form1();
            frm.synth.Speak(Form1.output);
        }

        public static void speech1()
        {
            Form1 frm = new Form1();
            frm.synth.Speak("hallo");
       }


        void speech2()
        {
            Form1 frm = new Form1();
            frm.synth.Speak("hallo");
        }


        void speech3()
        {
            Form1 frm = new Form1();
            frm.synth.Speak("Hallo");
        }

    }
}
