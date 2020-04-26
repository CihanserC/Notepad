using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace DesktopApp1
{
    public partial class Form1 : Form
    {
        ItemFactrory Notepad = new ItemFactrory();
        public Form1()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var ofd = new OpenFileDialog())
            {
                DialogResult result = ofd.ShowDialog();

                if (result == DialogResult.OK)
                {
                    richTextBox1.Text = File.ReadAllText(ofd.FileName);
                    label6.Text = ofd.FileName;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.IO.StreamWriter objWriter;
            objWriter = new System.IO.StreamWriter(label6.Text);
            objWriter.Write(richTextBox1.Text);
            objWriter.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Process.Start("notepad.exe", label6.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String[] withSpilt = Notepad.GetInterface("Words").getSpesItem(richTextBox1.Text);
            label5.Text = withSpilt.Length.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty)
            {
                richTextBox1.Select(0, richTextBox1.Text.Length);
                richTextBox1.SelectionBackColor = Color.White;
                return;

            }

            int s_start = richTextBox1.SelectionStart, startIndex = 0, index;

                richTextBox1.Select(0, richTextBox1.Text.Length);
                richTextBox1.SelectionBackColor = Color.White;

            while ((index = richTextBox1.Text.IndexOf(textBox1.Text, startIndex)) != -1)
            {
                richTextBox1.Select(index, textBox1.Text.Length);
                richTextBox1.SelectionBackColor = Color.Yellow;

                startIndex = index + textBox1.Text.Length;
            }

            richTextBox1.SelectionStart = s_start;
            richTextBox1.SelectionLength = 0;
            richTextBox1.SelectionColor = Color.Black;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            String[] withSplit = Notepad.GetInterface("Lines").getSpesItem(richTextBox1.Text);
            label5.Text = withSplit.Length.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label5.Text = richTextBox1.Text.Length.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ItemInterface startsWithT = Notepad.GetInterface("T");
            String[] withSpilt = startsWithT.getSpesItem(richTextBox1.Text);

            int s_start = richTextBox1.SelectionStart, startIndex = 0, index;

            richTextBox1.Select(0, richTextBox1.Text.Length);
            richTextBox1.SelectionBackColor = Color.White;

            int count = 0;
            foreach (String s in withSpilt) {
                if(s != null && s.Length > 0)
                {
                    count++;
                    while ((index = richTextBox1.Text.IndexOf(s, startIndex)) != -1)
                    {
                        richTextBox1.Select(index, s.Length);
                        richTextBox1.SelectionBackColor = Color.Yellow;

                        startIndex = index + s.Length;
                    }
                }


            }
            label5.Text = count.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ItemInterface longThan = Notepad.GetInterface("longThanFive");
            String[] withSpilt = longThan.getSpesItem(richTextBox1.Text);

            int s_start = richTextBox1.SelectionStart, startIndex = 0, index;

            richTextBox1.Select(0, richTextBox1.Text.Length);
            richTextBox1.SelectionBackColor = Color.White;

            int count = 0;
            foreach (String s in withSpilt)
            {
                if (s != null)
                {
                    count++;
                    while ((index = richTextBox1.Text.IndexOf(s, startIndex)) != -1)
                    {
                        richTextBox1.Select(index, s.Length);
                        richTextBox1.SelectionBackColor = Color.Yellow;

                        startIndex = index + s.Length;
                    }
                }

            }
            label5.Text = count.ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            ItemInterface palind = Notepad.GetInterface("palindrome");
            String[] withSpilt = palind.getSpesItem(richTextBox1.Text);

            int s_start = richTextBox1.SelectionStart, startIndex = 0, index;

            richTextBox1.Select(0, richTextBox1.Text.Length);
            richTextBox1.SelectionBackColor = Color.White;

            int count = 0;
            foreach (String s in withSpilt)
            {
                if (s != null)
                {
                    count++;
                    while ((index = richTextBox1.Text.IndexOf(s, startIndex)) != -1)
                    {
                        richTextBox1.Select(index, s.Length);
                        richTextBox1.SelectionBackColor = Color.Yellow;

                        startIndex = index + s.Length;
                    }
                }


            }
            label5.Text = count.ToString();
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
