using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoanCalcCsForms
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			//M = P * ( J / (1 - (1 + J)^-N))
			double J = Double.Parse(textBox2.Text);
			J = J / 100.0 / 12.0;
			double P = Double.Parse(textBox1.Text);
			double N = Double.Parse(textBox3.Text);
			double M = P * (J / (1 - Math.Pow(1 + J, -N)));
			M = Math.Round(M, 2);
			textBox4.Text = M.ToString();
		}
	}
}
