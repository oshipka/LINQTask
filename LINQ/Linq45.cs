using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace LINQ
{
	public class Linq45
	{
		public static void TaskMain()
		{
			var readPath = Misc.SetPath("Task45.txt", true);
			var writePath = Misc.SetPath("Task45.txt", false);
			var taskData = new List<List<string>>();
			Misc.ParseStrings(taskData, readPath);
			if (taskData.Count % 3 != 0)
			{
				throw new InvalidDataException($"Not enough data, count = {taskData.Count}");
			}
			for (var k =2; k<taskData.Count; k+=3)
			{
				var L1 = taskData[k - 2][0];
				var L2 = taskData[k - 2][1];
				if ((!int.TryParse(L1, out var l1)) ||
					(!int.TryParse(L2, out var l2)))
				{
					throw new InvalidDataException("Not integer value entered");
				}
				var words = taskData[k - 1].
					Where(x =>  x.Length == l1).
					Concat(taskData[k].
						Where(x => x.Length == l2)).
					OrderByDescending(x=>x);
				
				Misc.WriteData(words, writePath);
			}
		}
	}
}
