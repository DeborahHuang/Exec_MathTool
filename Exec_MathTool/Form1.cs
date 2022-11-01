using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exec_MathTool
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			lblResult.Text = string.Empty;
			cboBox1.SelectedIndex = 0;
		}

		private void btnCal_Click(object sender, EventArgs e)
		{
			int number = GetNumber();
			string table = renderSingleTable(number);
			lblResult.Text = table;
		}

		private int GetNumber()
		=> Convert.ToInt32(cboBox1.SelectedIndex);

		private string renderSingleTable(int number)
		{
			string result = string.Empty;
			for (int i = 1; i <= 9; i++)
			{
				result += $"{number}*{i}={number * i}\r\n";
			}
			return result;
		}

		private void cboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			
		}
	}
}
