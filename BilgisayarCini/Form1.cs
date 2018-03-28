using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilgisayarCini
{
    public partial class Form1 : Form
    {
        bool pressed = true;
        string question = "Lütfen sorumu cevapla bilgisayar cini sana yalvarıyorum";
        char[] qustionChar;        
        int index = 0;
        string myText = "";
        string answer;
        string[] errorMessages;
        public Form1()
        {
            InitializeComponent();
            qustionChar = question.ToCharArray();
            errorMessages = new string[] {"Git Başımdan","Rahat Bırak","Git","Anladın mı?","GİİİİTTT!!!!" };
        }
        public bool Security()
        {
            if (answer==null)
                return false;

            return true;
        }
        private void QuestionBox_TextChanged(object sender, EventArgs e)
        {
            if (!pressed)
            {
                QuestionBox.Text = myText;
                QuestionBox.SelectionStart = QuestionBox.Text.Length;
            }
        }

        private void QuestionBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.ControlKey)
                pressed = !pressed;
        }

        private void QuestionBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!pressed)
            {
                answer += e.KeyChar.ToString();
                myText = QuestionBox.Text + qustionChar[index];
                index++;
            }
        }

        private void QuestionButton_Click(object sender, EventArgs e)
        {
            Random waitSeconds = new Random();
            int second = waitSeconds.Next(3, 10);
            timer1.Interval = second * 1000;
            timer1.Enabled = true;

            Cursor = Cursors.WaitCursor;
            QuestionButton.Enabled = false;
            QuestionBox.Enabled = false;
            ControlBox = false;
            QuestionButton.Text = "Düşünüyorum";
            Text = "Bilgisayar Cini(Düşünüyor)";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;

            QuestionBox.Text = "";
            if (Security())
            {
                DialogResult result = MessageBox.Show(answer, "Cevabım", MessageBoxButtons.OK, MessageBoxIcon.Information,MessageBoxDefaultButton.Button1);
                if (result == DialogResult.OK)
                {
                    Reset();
                }
            }
            else
            {
              DialogResult result = MessageBox.Show("SEN KİMSİN!!!","GİT BAŞIMDAN",MessageBoxButtons.OK,MessageBoxIcon.Error);
                if (result == DialogResult.OK)
                {
                    for (int i = 0; i < 5; i++)
                    {
                        MessageBox.Show(errorMessages[i],errorMessages[i],MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                    Application.Exit();
                }
            }
        }

        void Reset()
        {
            
            answer = null;
            myText = "";
            pressed = true;
            index = 0;
            QuestionButton.Enabled = true;
            QuestionBox.Enabled = true;
            Cursor = Cursors.Default;
            ControlBox = true;
            Text = "Bilgisayar Cini";
            QuestionBox.Focus();
            QuestionButton.Text = "Sor";
        }
    }
}
