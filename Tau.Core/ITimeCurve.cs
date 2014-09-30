using System;

namespace Tau.Core
{
	public interface ITimeCurve
	{
		double Interpolate (double time);
	}
}

