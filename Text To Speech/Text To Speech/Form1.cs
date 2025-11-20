using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech;
using System.Speech.Synthesis;

namespace Alarm_Clock
{
    public partial class Form1 : Form
    {
        SpeechSynthesizer ss;
        public Form1()
        {
            InitializeComponent();
        }
    

     

        private void btnRead_click(object sender, EventArgs e)
        {
            ss.Rate = trackBarSpeed.Value;
            ss.Volume = trackBarVolume.Value;
            ss.SpeakAsync(txtMessage.Text);
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            if (reader != null)
            {
                if (reader.State == SynthesizerState.Speaking)
                {
                    reader.Pause();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ss = new SpeechSynthesizer();
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            if (reader != null)
            {
                if (reader.State == SynthesizerState.Paused)
                {
                    reader.Resume();
                }
            }
        }

        private void btnRecord_Click(object sender, EventArgs e)
        {
            SpeechSynthesizer ss = new SpeechSynthesizer();
            ss.Rate = trackBarSpeed.Value;
            ss.Volume = trackBarVolume.Value;
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Wav files| *.wav";
            sfd.ShowDialog();
            ss.SetOutputToWaveFile(sfd.FileName);
            ss.Speak(txtMessage.Text);
            ss.SetOutputToDefaultAudioDevice();
            MessageBox.Show("Recording Completed...", "T2S");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        SpeechSynthesizer reader = new SpeechSynthesizer();
        private void btnRead_Click_1(object sender, EventArgs e)
        {
if (txtMessage.Text != "")
            {
                reader.Dispose();
                reader = new SpeechSynthesizer();
                reader.SpeakAsync(txtMessage.Text);
            }
else
            {
                MessageBox.Show("Please enter some text first...");
            }

        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (reader != null)
            {
                reader.Dispose();
            }
        }
    }
}
