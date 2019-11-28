using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Circulo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        circulo cunha = new circulo();
        private void Button1_Click(object sender, EventArgs e)
        {
            cunha.raio = textBox1.Text; 
            if (radioButton1.Checked) label1.Text = cunha.area;
            else if (radioButton2.Checked) label1.Text = cunha.perimetro;
            else if (radioButton3.Checked) label1.Text = cunha.diametro;
        }
    }
}
