using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Codeplex.Data;

namespace CrealityPrintUtil
{

	public class FilamentUtils
	{
		private dynamic _data;
		public FilamentUtils() 
		{ 
			_data=null;
		}
		public bool Load(string p)
		{
			bool result = false;
			_data = null;
			string s = File.ReadAllText(p);
			if ((s != null)&&(s!=""))
			{
				_data = DynamicJson.Parse(s);
			}
			return result;
		}
		public string DispInfo(string p)
		{
			string ret = "";
			string s = File.ReadAllText(p);
			if ((s != null) && (s != ""))
			{
				try
				{
					dynamic json = DynamicJson.Parse(s);

					PropertyInfo[] ps =  json.GetType().GetProperties();

					foreach (PropertyInfo pi in ps)
					{
						ret += pi.Name + "\r\n";
					}
				}
				catch (Exception e)
				{
					ret = e.Message;
				}
			}
			return ret;
		}

		public string Listup(string p)
		{
			string ret = "";
			string cd = "";
			string ar = "";
			string s = File.ReadAllText(p);
			_data = DynamicJson.Parse(s);
			if (_data != null)
			{
				foreach (dynamic d in _data)
				{
					//ret += d.Key + "\r\n";
					string ss = d.ToString();
					ss = ss.Substring(1,ss.Length-2);
					ret += ss + "\r\n";
					//ret += d.ToString()+"\r\n";
				}
				cd += "// -------------------------\r\n";
				foreach (dynamic d in _data)
				{
					cd += $"public string {d.Key} {{get;set;}}\r\n";
				}
				cd += "// -------------------------\r\n";
				foreach (dynamic d in _data)
				{
					cd += $"public string {d.Key}_cap {{get;set; }}\r\n";
					cd += $"static public string {d.Key}_name() {{return nameof($$$.{d.Key}); }}\r\n";
				}
				cd += "// -------------------------\r\n";
				cd += "[\r\n";
				foreach (dynamic d in _data)
				{
					cd += $"\"{d.Key}\",\r\n";
				}
				cd += "]\r\n";

				Clipboard.SetText(cd);
			}
			return ret;
		}

		static public string[] ListupSystemParam()
		{
			List<string> ret = new List<string>();
			string pp = "C:\\Program Files\\Creality\\Creality Print 6.0\\resources\\profiles\\Creality\\filament";

			if (Directory.Exists(pp))
			{
				string[] fls = Directory.GetFiles(pp,"*.json");
				foreach (string f in fls)
				{
					ret.Add(f);
				}
			}
			return ret.ToArray();
		}

		static public string UserPath()
		{
			string ret = "";
			string p = System.Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
			p = Path.Combine(p, "Creality\\Creality Print\\6.0\\user");
			if( Directory.Exists(p)==true)
			{
				string[] fls = Directory.GetDirectories(p);
				foreach (string f in fls)
				{
					string d = Path.GetFileNameWithoutExtension(f);
					if (d == "default") continue;
					long l = 0;
					if (long.TryParse(d, out l))
					{
						ret = Path.Combine (p, f);
						ret = Path.Combine (ret, "filament");
						break;
					}
				}
			}
			return ret;
		}
		static public string[] ListupUserParam()
		{
			List<string> ret = new List<string>();
			string pp = UserPath();

			if (Directory.Exists(pp))
			{
				string[] fls = Directory.GetFiles(pp, "*.json");
				foreach (string f in fls)
				{
					ret.Add(f);
				}
			}
			return ret.ToArray();
		}

		/*
		static public FilamentSystemPreset LoadSystemPreset(string p)
		{
			FilamentSystemPreset preset = new FilamentSystemPreset();
			dynamic data = null;
			string s = File.ReadAllText(p);
			if ((s != null) && (s != ""))
			{
				data = DynamicJson.Parse(s);

				foreach (string f in FilamentSystemPresetCaption.Captions)
				{
					if ( ((DynamicJson)data).IsDefined(f)==true)
					{
						PropertyInfo pp = preset.GetType().GetProperty(f);
						if (pp != null)
						{
							pp.SetValue(preset, (string)data[f]);
						}
					}
				}

			}
			return preset;
		}
		*/
	}
}
