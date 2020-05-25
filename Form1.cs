using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ds.test.impl;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Width = 500;

            pictureBox1.Height = 500;
            pictureBox1.BackColor = Color.White;
            Plugins plugins = new Plugins();
            //MessageBox.Show(string.Join("\n",plugins.GetPluginNames));
            IPlugin p = plugins.GetPlugin("Pow");
            pictureBox1.Image = p.Image;
            textBox3.Text = Convert.ToString(p.Run(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text)));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Plugins plugins = new Plugins();
            IPlugin p = plugins.GetPlugin("sin");
            textBox3.Text = Convert.ToString(p.Run(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text)));

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Plugins plugins = new Plugins();
            IPlugin p = plugins.GetPlugin("Add");
            textBox3.Text = Convert.ToString(p.Run(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text)));

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Plugins plugins = new Plugins();
            IPlugin p = plugins.GetPlugin("Division");
            textBox3.Text = Convert.ToString(p.Run(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text)));

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Plugins plugins = new Plugins();
            IPlugin p = plugins.GetPlugin("Multiply");
            textBox3.Text = Convert.ToString(p.Run(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text)));

        }
    }
}

