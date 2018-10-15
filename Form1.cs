using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace máy_tính_bỏ_túi
{
    public partial class Form1 : Form
    {
        double ketqua = 0;
        string pheptoan = "";
        public Form1()
        {
            InitializeComponent();
        }
        private void button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (button.Text == ".")
            {
                if (!textBox1.Text.Contains("."))
                    textBox1.Text = textBox1.Text + button.Text;
            }
            else
                textBox1.Text = textBox1.Text + button.Text;

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void tinhtoan_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (ketqua != 0)
            {
                button16.PerformClick();
            }
            pheptoan = button.Text;
            ketqua = double.Parse(textBox1.Text);
            textBox1.Text = ketqua + " " + pheptoan;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
            switch (pheptoan)
            {
                case "+":
                    textBox1.Text =  (ketqua + double.Parse(textBox1.Text)).ToString();
                    break;
                case "-":
                    textBox1.Text = (ketqua - double.Parse(textBox1.Text)).ToString();
                    break;
                case "*":
                    textBox1.Text = (ketqua * double.Parse(textBox1.Text)).ToString();
                    break;
                case "/":
                    textBox1.Text = (ketqua / double.Parse(textBox1.Text)).ToString();
                    break;
                default:
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void button25_Click(object sender, EventArgs e)
        {
        }
        
    }
}
