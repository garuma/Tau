using System;

namespace Tau.Core.Curves
{
	public class PowerCurve : ITimeCurve
	{
		public PowerCurve (double power)
		{
			Power = power;
		}

		public double Power { get; set; }

		public double Interpolate (double time)
		{
			return Math.Pow (time, Power);
		}
	}
}

