using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Speech.Recognition;
using System.Speech.Synthesis;
using AIMLbot;
using AIMLbot.Utils;


namespace VirtualAssistant
{
    public partial class Form1 : Form
    {
        SpeechRecognitionEngine sre=new SpeechRecognitionEngine();
        SpeechSynthesizer tts = new SpeechSynthesizer();

        static Bot mybot = new Bot();
        User usr = new User("currentUser",mybot);

        String userQuestion = "";
        String botResponse = "";

        public Form1()
        {
            InitializeComponent();
        }

        public void InitBot()
        {

            try
            {
                mybot.isAcceptingUserInput = false;
                mybot.loadSettings();
                mybot.loadAIMLFromFiles();
                mybot.isAcceptingUserInput = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);

            }

        }

        public String GetReply(String ques)
        {
            Request rq = new Request(ques, usr, mybot);
            Result res = mybot.Chat(rq);

            return res.Output;

        }



        public void InitRecog()
        {
            try
            {


                sre.SetInputToDefaultAudioDevice();
                GrammarBuilder gb = new GrammarBuilder();
                gb.AppendDictation();
                Grammar gram = new Grammar(gb);
                sre.LoadGrammar(gram);
                sre.SpeechHypothesized += SpeechHyp;
                sre.SpeechRecognized += SpeechRec;
                sre.SpeechRecognitionRejected += SpeechRej;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }


        }

        public void Speak(String msg)
        {

            tts.SpeakAsync(msg);

        }

        void SpeechRej(object sender,SpeechRecognitionRejectedEventArgs e)
        {
            try
            {

                StatusTxt.Text = "Status : Cannot understand, Speak again!";
                Speak("Cannot understand, Speak again!");
                sre.RecognizeAsyncStop();
                StartBtn.Enabled = true;
                StopBtn.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex);
            }
            
        }

        void SpeechRec(object sender, SpeechRecognizedEventArgs e)
        {
            try
            {
                userQuestion = e.Result.Text;
                StatusTxt.Text = "You Said : " + userQuestion;
                AnswerMe(userQuestion);
                sre.RecognizeAsyncStop();
                StartBtn.Enabled = true;
                StopBtn.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : "+ex.Message);

            }
        }

        void SpeechHyp(object sender,SpeechHypothesizedEventArgs e)
        {
            StatusTxt.Text = "Status : "+e.Result.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            StopBtn.Enabled = false;
            InitRecog();
            Speak("");
            InitBot();


        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            StartBtn.Enabled = false;
            StopBtn.Enabled = true;
            try
            {
                sre.RecognizeAsync(RecognizeMode.Multiple);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : "+ex.Message);
            }
        }

        private void StopBtn_Click(object sender, EventArgs e)
        {
            StartBtn.Enabled = true;
            StopBtn.Enabled = false;
            try
            {
                sre.RecognizeAsyncStop();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : "+ex.Message);
            }
        }

        public void AnswerMe(String userQues)
        {

            Logtxt.AppendText("You : " + userQues + Environment.NewLine);
            botResponse = GetReply(userQues);
            Logtxt.AppendText("Assistant : " + botResponse + Environment.NewLine);
            Speak(botResponse);

        }

        private void SendBtn_Click(object sender, EventArgs e)
        {
            AnswerMe(InputTxt.Text);
        }

        private void Logtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void InputTxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
