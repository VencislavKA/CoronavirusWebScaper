﻿namespace Coronavirus_Web_Scaper.Controllers.Mapping
{
	public class Stats
	{
		public TestedStats tested { get; set; }

		public ConfirmedStats confirmed { get; set; }

		public ActiveStats active { get; set; }
	}
}
