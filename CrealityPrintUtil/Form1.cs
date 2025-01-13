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
	public partial class Form1 : Form
	{
		FilamentUtils fj= new FilamentUtils();
		public Form1()
		{
			InitializeComponent();

			combFilamets1.Listup();
		}

		
	}
}
