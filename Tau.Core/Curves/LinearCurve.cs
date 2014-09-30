using System;

namespace Tau.Core.Curves
{
	public class LinearCurve : ITimeCurve
	{
		public double Interpolate (double time)
		{
			return time;
		}
	}
}

