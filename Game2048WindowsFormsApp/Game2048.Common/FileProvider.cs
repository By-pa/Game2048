using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Game2048.Common
{
	public class FileProvider
	{
		public static void Append(string fileName, string value)
		{
			var writer = new StreamWriter(fileName, true, Encoding.UTF8);
			writer.WriteLine(value);
			writer.Close();
		}

		public static void Replace(string fileName, string value)
		{
			var writer = new StreamWriter(fileName, false, Encoding.UTF8);
			writer.WriteLine(value);
			writer.Close();
		}

		public static string GetValue(string fileName)
		{
			var reader = new StreamReader(fileName, Encoding.UTF8);
			var value = reader.ReadToEnd();
			reader.Close();

			return value;
		}

		public static bool Exists(string fileName)
		{
			return File.Exists(fileName);
		}

		public static void Clear(string fileName)
		{
			File.WriteAllText(fileName, string.Empty);
		}
	}
}
