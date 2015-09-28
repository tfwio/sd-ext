/* oio * 4/5/2014 * Time: 5:46 AM */
using System;
namespace ThemeTool
{
	public class ThemeSetting
	{
		public string ThemeName {
			get;
			set;
		}
		public string ResourceName {
			get;
			set;
		}

		public System.Collections.Generic.List<ColourSetting> Elements {
			get;
			set;
		}

		static public ThemeSetting Load(System.IO.FileInfo Info)
		{
			if (!Info.Exists)
				return null;
			var data = System.IO.File.ReadAllText(Info.FullName);
			return Load(data);
		}

		static public ThemeSetting Load(string input)
		{
			ThemeSetting result = null;
			using (var reader = new System.IO.StringReader(input)) {
				var deserializer = new YamlDotNet.Serialization.Deserializer(ignoreUnmatched: true);
				try {
					result = deserializer.Deserialize<ThemeSetting>(reader);
				}
				catch (Exception err) {
					System.Windows.MessageBox.Show(
				    err.ToString(),
				    "Error",
				    System.Windows.MessageBoxButton.OK,
				    System.Windows.MessageBoxImage.Error);
				}
			}
			return result;
		}

		static public void Save(ThemeSetting input, System.IO.FileInfo Info)
		{
			var stringdata = Save(input);
			System.IO.File.WriteAllText(Info.FullName, stringdata);
		}

		static public string Save(ThemeSetting input)
		{
			using (var writer = new System.IO.StringWriter()) {
				var serializer = new YamlDotNet.Serialization.Serializer();
				serializer.Serialize(writer, input);
				var result = writer.ToString();
				serializer = null;
				return result;
			}
		}
	}

  public class ColourSetting
  {
    public string Name          { get; set; }
    public string TypeName      { get; set; }
    public string DefaultValue  { get; set; }
    public string Comment       { get; set; }
  }
}









