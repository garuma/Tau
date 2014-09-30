using System;

namespace Tau.Core.Curves
{
	public class InvertedQuadraticCurve : ITimeCurve
	{
		public double Interpolate (double time)
		{
			return 1 - (1 - time) * (1 - time);
		}
	}
}

