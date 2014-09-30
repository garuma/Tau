using System;

namespace Tau.Core.Curves
{
	/// <summary>
	/// Use trigonometric function to compute a eased-in/eased-out curve.
	/// </summary>
	/// <remarks>
	/// The interpolation curve is generated using a half-cycle of a sine wave offset in the [0;1] range
	/// </remarks>
	public class SineCurve : ITimeCurve
	{
		public double Interpolate (double time)
		{
			return (Math.Cos ((time + 1) * Math.PI) / 2.0f) + 0.5f;
		}
	}
}
