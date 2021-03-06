﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace LINQ
{
	public class Misc
	{
		public static void ParseInts(List<List<int>> listName, string pathName)
		{
			var lines = File.ReadAllLines(pathName);
			
			foreach (var line in lines)
			{
				var dataRow = new List<int>();
				var numbers = line.Split(' ');
				foreach (var number in numbers)
				{
					int.TryParse(number, out var result);
					dataRow.Add(result);
				}
				listName.Add(dataRow);
			}
		}
		
		public static void ParseStrings (List<List<string>> listName, string pathName)
		{
			var lines = File.ReadAllLines(pathName);
			
			foreach (var line in lines)
			{
				var dataRow = new List<string>();
				var words = line.Split(' ');
				foreach (var word in words)
				{
					dataRow.Add(word);
				}
				listName.Add(dataRow);
			}
		}
		
		public static void ParseClients (List<Client> listName, string pathName)
		{
			var lines = File.ReadAllLines(pathName);
			for (var i=2; i< lines.Length; i++)
			//foreach (var line in lines)
			{
				var dataRow = new Client();
				var words = lines[i].Split(' ');
				if (words.Length > 4)
				{
					throw new InvalidDataException("Incorrect input line");
				}
				if((!int.TryParse(words[0], out var code))||
				   (!int.TryParse(words[1], out var year))||
				   (!int.TryParse(words[2], out var month))||
				   (!double.TryParse(words[3],
					   NumberStyles.Number | NumberStyles.AllowCurrencySymbol,
					   CultureInfo.InvariantCulture,
					   out var time)))
				{
					throw new InvalidDataException("Entered data is invalid");
				}
				dataRow.ClientCode = code;
				dataRow.Year = year;
				dataRow.Month = month;
				dataRow.TimeSpent = time;				
				listName.Add(dataRow);
			}
		}

		public static void WriteData<T>(IEnumerable<T> query, string pathName, string typeOfData = "")
		{
			if (typeof(T) == typeof(Client))
			{
				File.AppendAllText(pathName, typeOfData + ":\n");
			}

			foreach (var variable in query)
			{
				
				File.AppendAllText(pathName, variable.ToString());
				File.AppendAllText(pathName, " ");
			}
			File.AppendAllText(pathName, Environment.NewLine);
		}
		
		public static string CurrentDir()
		{
			var directory = Directory.GetCurrentDirectory();
			var pos = directory.Split('\\');
			var result = pos[0];
			for (var i = 1; i < pos.Length - 2; i++)
			{
				result += "\\" + pos[i];
			}

			return result;
		}

		public static string SetPath(string fileName, bool read)
		{
			return Path.Combine(CurrentDir(), read ? "Data files" : "Result files", fileName);
		}
	}
}