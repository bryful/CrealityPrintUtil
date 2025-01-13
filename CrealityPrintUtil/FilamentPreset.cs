using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Codeplex.Data;
using System.Reflection;

namespace CrealityPrintUtil
{
	public class FilamentPreset
	{
		private string m_path = "";
		public string TargetPath { get { return m_path; } }

		private dynamic m_data = null;
		private List<string> m_keys = new List<string>();
		private List<string> m_values = new List<string>();
		private string [] m_DispKeys = new string [0];
		private int m_KeyMax = 0;
		public FilamentPreset()
		{

		}
		public void Clear()
		{
			m_path = "";
			m_data = null;
			m_keys.Clear();
			m_values.Clear();
			m_KeyMax = 0;
			m_DispKeys = new string[0];
		}

		public bool Import(string p)
		{
			bool ret = false;
			Clear();
			try
			{
				if (File.Exists(p) == true)
				{
					m_data = DynamicJson.Parse(File.ReadAllText(p));
					List<string> lst = new List<string>();
					List<string> lst2 = new List<string>();
					foreach (dynamic item in m_data)
					{
						if (m_KeyMax < item.Key.Length)
						{
							m_KeyMax = item.Key.Length;
						}
						lst.Add(item.Key);
						lst2.Add( GetValueAt(item.Value));
					}
					m_keys = lst;
					m_values = lst2;
					m_path = p;
					ret = true;
				}
			}
			catch (Exception ex)
			{
				ret = false;
			}
			return ret;
		}

		public string[] FindKeys(string p)
		{
			if (m_keys.Count == 0) return new string[0];
			p = p.Trim();

			List<string> pat = new List<string>();
			foreach (string item in p.Split(' '))
			{
				string item2 = item.Trim();
				if (item2 != "")
				{
					pat.Add(item2);
				}
			}
			if (pat.Count == 0)
			{
				return m_keys.ToArray();
			}
			List<string> ret2 = new List<string>();
			foreach (string item in m_keys)
			{
				foreach (string pat2 in pat)
				{
					if (item.IndexOf(pat2, 0, StringComparison.InvariantCultureIgnoreCase) >= 0)
					{
						ret2.Add(item);
						break;
					}
				}
			}
			return ret2.ToArray();
		}
		public string[] FindKeysFromValue(string p)
		{
			if (m_keys.Count == 0) return new string[0];
			p = p.Trim();

			if (p == "")
			{
				return m_keys.ToArray();
			}
			List<string> ret2 = new List<string>();

			foreach (string item in m_keys)
			{
				string s = GetValue(item);
				if (s.IndexOf(p, 0, StringComparison.InvariantCultureIgnoreCase) >= 0)
				{
					ret2.Add(item);
				}
			}
			return ret2.ToArray();
		}
		private string KeySP(string s)
		{
			int cnt = m_KeyMax - s.Length;
			if (cnt>0)
			{
				for (int i = 0;i< cnt;i++)
				{
					//s = " " + s;
					s = s+ " ";
				}
			}
			return s;
		}

		public string[] GetItemsFromKeys(string[] keys)
		{
			if (m_keys.Count <= 0) return new string[0];
			List<string> ret = new List<string>();

			string[] keys2 = keys;
			if(keys2.Length == 0)
			{
				return new string[0];
			}
			foreach (string key in keys2)
			{
				string s = KeySP(key);
				s += "  ";
				s += GetValue(key);
				ret.Add(s);

			}
			return ret.ToArray();
		}
		//-----------------------------------------------------------
		public string GetValueAt(dynamic a)
		{
			string ret = "";
			if (a is string)
			{
				ret = (string)a;
			}
			else 
			{
				//if (((DynamicJson)a).IsObject)
				//{
					if (((DynamicJson)a).IsArray == true)
					{
						string ss = "";
						foreach (var s in a)
						{
							if (ss != "") ss += ",";
							ss += s.ToString();
						}
						ret = ss;
					}
				//}
			}
			return ret;
		}
		public string GetValue(string key)
		{
			string ret = null;
			if ( ((DynamicJson)m_data).IsDefined(key)==true)
			{
				ret = GetValueAt(m_data[key]);
			}
			return ret;
		}
		//-----------------------------------------------------------
		public string[] GetItems()
		{
			List<string> ret = new List<string>();
			if (m_keys.Count <= 0) return new string[0];
			foreach (string key in m_keys)
			{
				string s = key;
				s += "\t";
				s += GetValue(key);
				ret.Add(s);

			}
			return ret.ToArray();
		}
		//-----------------------------------------------------------
		public string GetInfo(string key)
		{
			string ret = "";

			string inf = GetValue(key);

			ret = $"key: {key}\r\n";
			ret += $"value: {inf}\r\n";

			return ret;
		}
	}
}
