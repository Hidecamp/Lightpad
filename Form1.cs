using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Lightpad
{
    public partial class Form1 : Form
    {
        bool ww = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void informationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Lightpad is a text editor supposed to be really simple, in fact, even simpler than Windows Notepad! It's for on-the-go fast noting.\nCurrent version is v_b26. Every re-compilation is considered as a new version.", "Lightpad", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You use Lightpad by writing down anything you want to write down. Every option in Lightpad is present on the top bar. If you cannot find an option you want, it means it is not there. You may ask the owner to add an option.", "Lightpad", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void copyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try { Clipboard.SetText(richTextBox1.Text); } catch { MessageBox.Show("A clipboard error has occoured.", "Lightpad", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void pasteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = Clipboard.GetText().ToString();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = Clipboard.GetText().ToString();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(richTextBox1.Text);
        }

        private void selectToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void selectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult srdr = openFileDialog1.ShowDialog();
            if (srdr == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(openFileDialog1.FileName);
                richTextBox1.Text = sr.ReadToEnd();
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);
                sw.Write(richTextBox1.Text);
            }
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Font = fontDialog1.Font;
            }
        }

        private void wordWrapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ww==false)
            {
                ww = true;
                richTextBox1.WordWrap = true;
            }
            else
            {
                ww = false;
                richTextBox1.WordWrap = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("This is part of Hidecamp's begginer series. This project is registered as ID: 2c866t1lr0qo\nThis app is #1 in the series.", "Hidecamp");
        }
    }
}
