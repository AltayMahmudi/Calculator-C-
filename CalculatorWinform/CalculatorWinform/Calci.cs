using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorWinform
{
	public partial class Calculator : Form
	{
		double FirstNumber;
		string Operation;
		public Calculator()
		{
			InitializeComponent();
		}


		private void button1_Click(object sender, EventArgs e)
		{
			if (TextBox.Text == "0" && TextBox.Text != null)
			{
				TextBox.Text = "1";
			}
			else
			{
				TextBox.Text = TextBox.Text + "1";
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			if (TextBox.Text == "0" && TextBox.Text != null)
			{
				TextBox.Text = "2";
			}
			else
			{
				TextBox.Text = TextBox.Text + "3";
			}

		}

		private void button3_Click(object sender, EventArgs e)
		{
			if (TextBox.Text == "0" && TextBox.Text != null)
			{
				TextBox.Text = "3";
			}
			else
			{
				TextBox.Text = TextBox.Text + "3";
			}
		}

		private void button4_Click(object sender, EventArgs e)
		{
			if (TextBox.Text == "0" && TextBox.Text != null)
			{
				TextBox.Text = "4";
			}
			else
			{
				TextBox.Text = TextBox.Text + "4";
			}
		}

		private void button5_Click(object sender, EventArgs e)
		{
			if (TextBox.Text == "0" && TextBox.Text != null)
			{
				TextBox.Text = "5";
			}
			else
			{
				TextBox.Text = TextBox.Text + "5";
			}
		}

		private void button6_Click(object sender, EventArgs e)
		{
			if (TextBox.Text == "0" && TextBox.Text != null)
			{
				TextBox.Text = "6";
			}
			else
			{
				TextBox.Text = TextBox.Text + "6";
			}
		}

		private void button7_Click(object sender, EventArgs e)
		{
			if (TextBox.Text == "0" && TextBox.Text != null)
			{
				TextBox.Text = "7";
			}
			else
			{
				TextBox.Text = TextBox.Text + "7";
			}
		}

		private void button8_Click(object sender, EventArgs e)
		{
			if (TextBox.Text == "0" && TextBox.Text != null)
			{
				TextBox.Text = "8";
			}
			else
			{
				TextBox.Text = TextBox.Text + "8";
			}
		}

		private void button9_Click(object sender, EventArgs e)
		{
			if (TextBox.Text == "0" && TextBox.Text != null)
			{
				TextBox.Text = "9";
			}
			else
			{
				TextBox.Text = TextBox.Text + "9";
			}
		}

		private void button10_Click(object sender, EventArgs e)
		{
			if (TextBox.Text == "0" && TextBox.Text != null)
			{
				TextBox.Text = "0";
			}
			else
			{
				TextBox.Text = TextBox.Text + "0";
			}
		}

		private void CC_Click(object sender, EventArgs e)
		{
			if (TextBox.Text != "0" && TextBox.Text != null)
			{
				TextBox.Text = "0";
			}
		}

		private void C_Click(object sender, EventArgs e)
		{
			if (TextBox.Text != "0" && TextBox.Text != null)
			{
				TextBox.Text = "0";
			}
		}

		private void DivideBTN_Click(object sender, EventArgs e)
		{
			FirstNumber = Convert.ToDouble(TextBox.Text);
			TextBox.Text = "0";
			Operation = "/";
		}

		private void MultiplyBTN_Click(object sender, EventArgs e)
		{
			FirstNumber = Convert.ToDouble(TextBox.Text);
			TextBox.Text = "0";
			Operation = "*";
		}

		private void SubtractBTN_Click(object sender, EventArgs e)
		{
			FirstNumber = Convert.ToDouble(TextBox.Text);
			TextBox.Text = "0";
			Operation = "-";
		}

		private void Add_Click(object sender, EventArgs e)
		{
			FirstNumber = Convert.ToDouble(TextBox.Text);
			TextBox.Text = "0";
			Operation = "+";
		}

		private void ResultBTN_Click(object sender, EventArgs e)
		{
			double SecondNumber;
			double Result;
			SecondNumber = Convert.ToDouble(TextBox.Text);
			if (Operation == "/")
			{
				if (SecondNumber == 0)
				{
					TextBox.Text = "Cannot divide by zero";

				}
				else
				{
					Result = (FirstNumber / SecondNumber);
					TextBox.Text = Convert.ToString(Result);
					FirstNumber = Result;
				}
			}
			if (Operation == "-")
			{
				Result = (FirstNumber - SecondNumber);
				TextBox.Text = Convert.ToString(Result);
				FirstNumber = Result;
			}
			if (Operation == "+")
			{
				Result = (FirstNumber + SecondNumber);
				TextBox.Text = Convert.ToString(Result);
				FirstNumber = Result;

			}
			if (Operation == "*")
			{
				Result = (FirstNumber * SecondNumber);
				TextBox.Text = Convert.ToString(Result);
				FirstNumber = Result;
			}
		}

		private void DotBTN_Click(object sender, EventArgs e)
		{
			TextBox.Text = TextBox.Text + ".";
		}
	}
}
