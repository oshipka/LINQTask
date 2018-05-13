using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;


namespace LINQ
{
	public class Linq16
	{
		public static void TaskMain()
		{
			var readPath = Misc.SetPath("Task16.txt", true);
			var writePath = Misc.SetPath("Task16.txt", false);
			var taskData = new List<List<int>>();
			Misc.ParseInts(taskData, readPath);
			foreach (var dataLine in taskData)
			{
				var positive = from i in dataLine where i > 0 select i;
				Misc.WriteData(positive, writePath);
			}
		}
	}
}