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

namespace CrealityPrintUtil
{
	public class CombFilamets :Control
	{
		private bool RefFLag = false;
		public event EventHandler SelectedIndexChanged;
		protected virtual void OnSelectedIndexChanged(EventArgs e)
		{
			if (SelectedIndexChanged != null)
			{
				SelectedIndexChanged(this, e);
			}
		}
		public event EventHandler PresetStyleChanged;
		protected virtual void OnPresetStyleChanged(EventArgs e)
		{
			if (PresetStyleChanged != null)
			{
				PresetStyleChanged(this, e);
			}
		}
		public int SelectedIndex
		{
			get { return m_comb.SelectedIndex;}
		}
		private PresetType m_PresetType = PresetType.System;
		private ComboBox m_comb = new ComboBox();
		private RadioButton m_radio1	= new RadioButton();
		private RadioButton m_radio2 = new RadioButton();
		[Category("Preset")]
		public PresetType PresetType
		{
			get { return m_PresetType; }
			set 
			{
				bool b = (m_PresetType != value);
				m_PresetType = value; 
				if(b)
				{
					RefFLag = true;
					m_comb.SelectedIndex = -1;
					m_targetPath = "";
					RefFLag = false;
					Listup();
				}
			}
		}
		private string[] m_files = new string[0];
		private string m_targetPath = "";
		[Category("Preset")]
		public string TargetPath
		{
			get{return m_targetPath;}
		}
		public CombFilamets()
		{
			this.Size = new Size(300, m_comb.Height);
			ChkSize();
			m_radio1.Text = "System";
			m_radio1.Checked = true;
			m_radio1.CheckedChanged += (sender, e) =>
			{
				if (this.PresetType != PresetType.System)
				{
					this.PresetType = PresetType.System;
					Listup();
					OnPresetStyleChanged(e);
				}
			};
			m_radio2.Text = "User";
			m_radio2.CheckedChanged += (sender, e) =>
			{
				if (this.PresetType != PresetType.User)
				{
					this.PresetType = PresetType.User;
					Listup();
					OnPresetStyleChanged(e);
				}
			};
			m_comb.Location = new Point(200,0);
			m_comb.Size = new Size(this.Width - 200, m_comb.Height);
			m_comb.DropDownStyle = ComboBoxStyle.DropDownList;
			m_comb.SelectedIndexChanged += (sender, e) =>
			{
				if(m_comb.SelectedIndex>=0)
				{
					m_targetPath = m_files[m_comb.SelectedIndex];
				}
				else
				{
					m_targetPath = "";
				}
				OnSelectedIndexChanged(e);
			};

			this.Controls.Add(m_radio1);
			this.Controls.Add(m_radio2);
			this.Controls.Add(m_comb);
		}
		private void ChkSize()
		{
			m_radio1.Location = new Point(0, 0);
			m_radio1.Size = new Size(70, m_comb.Height);
			m_radio2.Location = new Point(70, 0);
			m_radio2.Size = new Size(60, m_comb.Height);
			m_comb.Location = new Point(130, 0);
			m_comb.Size = new Size(this.Width - 130, m_comb.Height);
		}
		protected override void OnResize(EventArgs e)
		{
			ChkSize();
			base.OnResize(e);
		}
		
		private void Disp()
		{
			if (RefFLag) return;
			RefFLag = true;
			m_comb.Items.Clear();
			if (m_files.Length > 0)
			{
				List<string> files = new List<string>();
				foreach (string file in m_files)
				{
					files.Add(Path.GetFileNameWithoutExtension(file));
				}
				m_comb.Items.Clear();
				m_comb.Items.AddRange(files.ToArray());
				m_comb.SelectedIndex = 0;
			}
			RefFLag = false;

		}
		public void Listup()
		{
			if (RefFLag) return;
			RefFLag = true;
			if (m_PresetType == PresetType.System)
			{
				m_files = FilamentUtils.ListupSystemParam();
			}
			else if (m_PresetType == PresetType.User)
			{
				m_files = FilamentUtils.ListupUserParam();
			}
			else
			{
				m_files = new string[0];
			}RefFLag = false;
			Disp();

		}
	}
	public enum PresetType
	{
		System=0,
		User
	}
}
