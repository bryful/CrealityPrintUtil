using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Drawing;

using System.Threading.Tasks;
using Codeplex.Data;
using System.Reflection;
using System.Windows.Forms;
using System.ComponentModel;

namespace CrealityPrintUtil
{
	public class PresetListBox : Control
	{
		private FilamentPreset preset = new FilamentPreset();
		private CombFilamets m_comb = new CombFilamets();
		private CheckBox m_IsTargetKey = new CheckBox();
		private string[] m_FindKeys = new string[0];
		[Category("_Filament")]
		public CombFilamets CombFilamets
		{ 
			get { return m_comb; }
			set 
			{ 
				m_comb = value;
				if(m_comb != null)
				{
					m_comb.SelectedIndexChanged += (sender, e) =>
					{
						if (m_comb.SelectedIndex>=0)
						{
							preset.Import(m_comb.TargetPath);
							ShowList();
						}
					};
					m_comb.PresetStyleChanged += (sender, e) =>
					{
						preset.Import(m_comb.TargetPath);
						ShowList();
					};
				}
			}
		}
		private TextBox m_TextBox = new TextBox();
		private ListBox m_ListBox = new ListBox();
		public new Font Font
		{
			get { return base.Font; }
			set
			{
				base.Font = value;
				m_TextBox.Font = base.Font;
				m_ListBox.Font = base.Font;
				ChkSize();
			}
		}
		public PresetListBox() 
		{
			this.Size = new Size(300, 300);
			base.Font = new Font("ＭＳ ゴシック", 12,FontStyle.Bold);
			m_TextBox.Font = this.Font;
			m_ListBox.Font = this.Font;
			m_IsTargetKey.Font = this.Font;
			m_IsTargetKey.Text = "Key";
			m_IsTargetKey.Checked = true;
			ChkSize();
			this.Controls.Add(m_IsTargetKey);
			this.Controls.Add(m_TextBox);
			this.Controls.Add(m_ListBox);

			m_TextBox.TextChanged += (sender, e) =>
			{
				ShowList();
			};
			m_ListBox.DoubleClick += (sender, e) =>
			{
				ShowInfo();
			};
			m_IsTargetKey.CheckedChanged += (sender, e) =>
			{
				m_TextBox.Text = "";
				//ShowInfo();
			};
		}
		private void ChkSize()
		{
			m_IsTargetKey.Location = new Point(0, 0);
			m_IsTargetKey.Size = new Size(60, m_TextBox.Height);
			m_TextBox.Location = new Point(60, 0);
			m_TextBox.Size = new Size(this.Width-60, m_TextBox.Height);

			m_ListBox.Location = new Point(0, m_TextBox.Bottom+2);
			m_ListBox.Size = new Size(this.Width, this.Height - m_ListBox.Top-1);
		}

		private bool RefFlag = false;
		private void ShowList()
		{
			if (RefFlag) return;
			RefFlag = true;
			m_ListBox.Items.Clear();
			if (m_IsTargetKey.Checked)
			{
				m_FindKeys = preset.FindKeys(m_TextBox.Text);
			}
			else
			{
				m_FindKeys = preset.FindKeysFromValue(m_TextBox.Text);
			}
			String[] inf = preset.GetItemsFromKeys(m_FindKeys);
			m_ListBox.Items.Clear();
			m_ListBox.Items.AddRange(inf);
			RefFlag = false;
		}
		protected override void OnResize(EventArgs e)
		{
			ChkSize();
			base.OnResize(e);
		}
		public void ShowInfo()
		{
			if ((m_ListBox.Items.Count<=0)||(m_ListBox.SelectedIndex < 0)) return;

			using (ItemForm dlg = new ItemForm())
			{
				dlg.Info = preset.GetInfo(m_FindKeys[m_ListBox.SelectedIndex]);
				dlg.ShowDialog();
			}
		}
	}
}
