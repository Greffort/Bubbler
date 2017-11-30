using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;


namespace Babbler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            bot.GetStr += bot_GetStr;
        }

        public void bot_GetStr(string obj)
        {
            SpeechSynthesizer speechSynth2 = new SpeechSynthesizer();
            speechSynth2.SelectVoiceByHints(VoiceGender.Male, VoiceAge.Senior);
            speechSynth2.SpeakAsync(obj);
            WindowsChat.Text += "";
            WindowsChat.Text += obj;
        }

        ManageText bot = new ManageText("база.txt");
        
        private void Enter_Click(object sender, EventArgs e)
        {
            WindowsChat.Text += userMassege.Text;
            string userQuestion = userMassege.Text;
            userMassege.Clear();
            userQuestion = userQuestion.Trim();
            bot.Ans(userQuestion);
            
        }
        
        private void userMassege_KeyUp(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                Enter_Click(sender,e);
            }
        }
        
    }
}
