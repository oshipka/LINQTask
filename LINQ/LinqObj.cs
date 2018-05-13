using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
	public class LinqObj
	{
		public static void TaskMain()
		{
			var readPath = Misc.SetPath("TaskObj.txt", true);
			var writePath = Misc.SetPath("TaskObj.txt", false);
			var clients = new List<Client>();
			Misc.ParseClients(clients, readPath);
			LeastTimeSpent(clients, writePath);
			MostTimeSpent(clients, writePath);
			YearWhenMostTotalTimeSpent(clients, writePath);
			EachClientTotalTimeSpent(clients, writePath);
			EachClientTotalMonths(clients, writePath);
		}

		private static void LeastTimeSpent(List<Client> clientsList, string pathName)
		{
			var min = clientsList.Min(y => y.TimeSpent);
			var result = clientsList.Where(x => Math.Abs(x.TimeSpent - min) < 1);
			Misc.WriteData(result, pathName, "Least time spent");
		}
		
		private static void MostTimeSpent(List<Client> clientsList, string pathName)
		{
			var max = clientsList.Max(y => y.TimeSpent);
			var result = clientsList.Where(x => Math.Abs(x.TimeSpent - max) < 1);
			Misc.WriteData(result, pathName, "Most time spent");
		}
		
		private static void YearWhenMostTotalTimeSpent(List<Client> clientsList, string pathName)
		{
			var result = new List<Client>
			{
				clientsList
					.GroupBy(y => y.Year)
					.Select(r => new Client
					{
						Year =  r.Key,
						TimeSpent = r.Sum(s => s.TimeSpent)
					})
					.OrderByDescending(t => t.TimeSpent)
					.ThenBy(y => y.Year)
					.First()
			};
			Misc.WriteData(result, pathName, "Year, when most time was spent in total");
		}
		
		private static void EachClientTotalTimeSpent(List<Client> clientsList, string pathName)
		{
			
		}
		
		private static void EachClientTotalMonths(List<Client> clientsList, string pathName)
		{
			
		}
	}
}