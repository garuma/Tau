using System;

namespace Tau.Core
{
	public class DoubleCriticalSpringDamperCurve : ITimeCurve
	{
		public double Interpolate (double time)
		{
			if (time <= 0.5) {
				var adjusted = time * 2;
				return (2.0 / (ExponentialDecay (adjusted, 3) + 1)) - 1;
			} else {
				var adjusted = (time - 0.5) * 2;
				return ExponentialDecay (adjusted, 2);
			}
		}

		double ExponentialDecay (double input, double ratio)
		{
			return (1 - input) * Math.Exp (-ratio * input);
		}
	}
}

