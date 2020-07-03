using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tugas_Kalkulator
{
    public partial class Form1 : Form
    {
        double value = 0;
        string ops = "";
        bool op_pressed = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if ((txtHasil.Text == "0") || (op_pressed))
            {
                txtHasil.Clear();
            }

            Button b = (Button)sender;
            txtHasil.Text = txtHasil.Text + b.Text;

        }

        private void operator_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            ops = b.Text;
            value = Double.Parse(txtHasil.Text);

            op_pressed = true;
        }

        private void hasil(object sender, EventArgs e)
        {
            switch (ops)
            {
                case "+": txtHasil.Text = (value + Double.Parse(txtHasil.Text)).ToString(); break;
                case "-": txtHasil.Text = (value - Double.Parse(txtHasil.Text)).ToString(); break;
                case "*": txtHasil.Text = (value * Double.Parse(txtHasil.Text)).ToString(); break;
                case "/": txtHasil.Text = (value / Double.Parse(txtHasil.Text)).ToString(); break;

            }
        }

        private void persen(object sender, EventArgs e)
        {
            txtHasil.Text = (Double.Parse(txtHasil.Text) * 0.01).ToString();
        }

        private void backspace(object sender, EventArgs e)
        {
            txtHasil.Text = txtHasil.Text.Remove(txtHasil.Text.Length - 1, 1);
        }

        private void ClearAll(object sender, EventArgs e)
        {
            txtHasil.Text = "0";
        }

        private void Exit(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
