using System;
using System.Security.Policy;

namespace LINQ
{
	public class Client
	{
		public Client(int code, int year, int month, int time)
		{
			ClientCode = code;
			Year = year;
			Month = month;
			TimeSpent = time;
		}
		
		public Client(){}

		public int Year { get; set; }

		public int Month { get; set; }

		public double TimeSpent { get; set; }

		public int ClientCode { get; set; }
	}
}