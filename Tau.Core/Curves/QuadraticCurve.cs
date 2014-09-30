using System;

namespace Tau.Core.Curves
{
	public class QuadraticCurve : ITimeCurve
	{
		public double Interpolate (double time)
		{
			return time * time;
		}
	}
}

