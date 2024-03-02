using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Game2048.Common
{
	public  class UserResultsStorage
	{
		public static string Path = "userResults.json";

		public static void Append(User user)
		{
			var usersResults = GetUserResults();
			usersResults.Add(user);
			Save(usersResults);
		}

		public static List<User> GetUserResults()
		{
			if (!FileProvider.Exists(Path))
			{
				return new List<User>();
			}

			var fileData = FileProvider.GetValue(Path);
			var userResults = JsonConvert.DeserializeObject<List<User>>(fileData);
			return userResults;
		}

		static void Save(List<User> usersResults)
		{
			var jsonData = JsonConvert.SerializeObject(usersResults, Formatting.Indented);
			FileProvider.Replace(Path, jsonData);
		}
	}
}
