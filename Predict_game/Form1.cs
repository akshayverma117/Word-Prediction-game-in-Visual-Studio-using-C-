using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Predict_game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        int qr;
        int score = 0;
        int[] terms;
        int[] str;
        String[] words = { "appreciate", "arithmetic", "artificial", "earthquake", "economical", "elasticity", "population", "positively", "screenplay", "toothpaste" };
        String s1;

        private void Form1_Load(object sender, EventArgs e)
        {
            formload();
           
        }

        private void formload()
        {
            txtc0.Clear();
            txtc1.Clear();
            txtc2.Clear();
            txtc3.Clear();
            txtc4.Clear();
            txtc5.Clear();
            txtc6.Clear();
            txtc7.Clear();
            txtc8.Clear();
            txtc9.Clear();
            txtc0.Enabled = true;
            txtc1.Enabled = true;
            txtc2.Enabled = true;
            txtc3.Enabled = true;
            txtc4.Enabled = true;
            txtc5.Enabled = true;
            txtc6.Enabled = true;
            txtc7.Enabled = true;
            txtc8.Enabled = true;
            txtc9.Enabled = true;
            generateFiveRandomNumber();
            qr = rnd.Next(0, 5);
            s1 = words[qr];
            for (int p = 0; p < terms.Length; p++)
            {
                fillText(terms[p], s1);
            }
        }

        private void fillText(int ch, string str)
        {
            switch (ch)
            {
                case 0:
                    {
                        txtc0.Text = str[ch].ToString();
                        txtc0.Enabled = false;
                        break;
                    }
                case 1:
                    {
                        txtc1.Text = str[ch].ToString();
                        txtc1.Enabled = false;
                        break;
                    }
                case 2:
                    {
                        txtc2.Text = str[ch].ToString();
                        txtc2.Enabled = false;
                        break;
                    }
                case 3:
                    {
                        txtc3.Text = str[ch].ToString();
                        txtc3.Enabled = false;
                        break;
                    }
                case 4:
                    {
                        txtc4.Text = str[ch].ToString();
                        txtc4.Enabled = false;
                        break;
                    }
                case 5:
                    {
                        txtc5.Text = str[ch].ToString();
                        txtc5.Enabled = false;
                        break;
                    }
                case 6:
                    {
                        txtc6.Text = str[ch].ToString();
                        txtc6.Enabled = false;
                        break;
                    }
                case 7:
                    {
                        txtc7.Text = str[ch].ToString();
                        txtc7.Enabled = false;
                        break;
                    }
                case 8:
                    {
                        txtc8.Text = str[ch].ToString();
                        txtc8.Enabled = false;
                        break;
                    }
                case 9:
                    {
                        txtc9.Text = str[ch].ToString();
                        txtc9.Enabled = false;
                        break;
                    }
            }
        }

        private void generateFiveRandomNumber()
        {
            List<int> termsList = new List<int>();
            termsList.Add(rnd.Next(0, 9));
            while (termsList.Count < 5)
            {
                int i = rnd.Next(0, 9);
                int flag = 0;
                for (int j = 0; j < termsList.Count; j++)
                {
                    if (termsList[j] == i)
                        flag = 1;
                }
                if (flag == 0)
                    termsList.Add(i);
            }
            terms = termsList.ToArray();
            str = termsList.ToArray();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String myAns = (txtc0.Text + txtc1.Text + txtc2.Text + txtc3.Text + txtc4.Text + txtc5.Text + txtc6.Text + txtc7.Text + txtc8.Text + txtc9.Text).ToString();
            MessageBox.Show(myAns);
            if (myAns.Equals(s1))
            {
                score = score + 5;
                MessageBox.Show("Your Score is" + score);
            }
            else
            {
                MessageBox.Show("Wrong Answer..... Right Answer is" + s1);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            formload();
        }

        private void txtc4_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtc2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtc9_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
