﻿using System;
using System.Text;

namespace LottozoCore.Model
{
	public class JokerData
	{
		public const int MaxValue = 9;

		public const int NumberNo = 6;

		public string Year { get; set; }

		public string Week { get; set; }

		public DateTime Date { get; set; }

		public int SixNum { get; set; }

		public string SixValue { get; set; }

		public int FiveNum { get; set; }

		public string FiveValue { get; set; }

		public int FourNum { get; set; }

		public string FourValue { get; set; }

		public int ThreeNum { get; set; }

		public string ThreeValue { get; set; }

		public int TwoNum { get; set; }

		public string TwoValue { get; set; }

		public int[] Numbers { get; set; }

		public override string ToString()
		{
			var sb = new StringBuilder();
			foreach (var number in Numbers)
			{
				sb.Append(number);
				sb.Append(", ");
			}
			sb.Remove(sb.Length - 2, 2);
			return sb.ToString();
		}
	}
}
