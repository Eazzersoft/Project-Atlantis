﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;
using System.Speech.Recognition;
using System.Diagnostics;
using System.Threading;

namespace Hauptumgebung
{
    public partial class Form1 : Form
    {
       public static int Spracherkennunganaus;
       public static bool hathallogesagt = false; 

       

        public Form1()
        {
            InitializeComponent();


            





        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_MouseDown(object sender, MouseEventArgs e)
        {
            textBox1.Text = "";
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }
        AI ChatBot = new AI();
        public static string output = "";
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            string argument = null;
            if (e.KeyCode == Keys.Enter)
            {
                if(!String.IsNullOrEmpty(argument))
                {
                    argument = textBox1.Text;
                    output = ChatBot.TextToCommand(argument);
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Spracherkennunganaus = 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Spracherkennunganaus = 0;
        }

        public static void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            SpeechSynthesizer synth = new SpeechSynthesizer();
            synth.Speak("Multiplikationszeichen Multiplikationszeichen Multiplikationszeichen Multiplikationszeichen Multiplikationszeichen Multiplikationszeichen Multiplikationszeichen Multiplikationszeichen Multiplikationszeichen Multiplikationszeichen  ");
            new Thread(new ThreadStart(Sprach_Verstehen.Sprachezutext)).Start();
        }
    }
}
