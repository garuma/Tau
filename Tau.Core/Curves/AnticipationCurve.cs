using System;

namespace Tau.Core.Curves
{
	public class AnticipationCurve : ITimeCurve
	{
		const double CutOff = 2/3.0;
		InvertedQuadraticCurve secondCurve = new InvertedQuadraticCurve ();

		public double Interpolate (double time)
		{
			if (time < CutOff) {
				// The first part of the curve is a sine wave correctly scaled and offset
				return Math.Sin (time * 3 * Math.PI) / (8 * (1 - time));
			} else {
				// For the second part we delegate to a normal inverted quadratic curve with a readjusted time
				var adjustedTime = (time - CutOff) * 3;
				return secondCurve.Interpolate (adjustedTime);
			}
		}
	}
}

