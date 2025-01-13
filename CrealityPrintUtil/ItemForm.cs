using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrealityPrintUtil
{
	public partial class ItemForm : Form
	{
		public string Info
		{
			get { return textBox1.Text; }
			set { textBox1.Text = value; }
		}
		public ItemForm()
		{
			InitializeComponent();
		}
	}
}
