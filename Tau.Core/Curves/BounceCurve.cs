// Original interpolator code is
// Copyright (C) 2009 The Android Open Source Project
// Licensed under the Apache License, Version 2.0

using System;

namespace Tau.Core.Curves
{
	public class BounceCurve : ITimeCurve
	{
		static double Bounce (double t)
		{
			return t * t * 8.0f;
		}

		public double Interpolate (double time)
		{
			time *= 1.1226;

			if (time < 0.3535)
				return Bounce (time);
			else if (time < 0.7408)
				return Bounce (time - 0.54719) + 0.7;
			else if (time < 0.9644)
				return Bounce (time - 0.8526) + 0.9;

			return Bounce (time - 1.0435) + 0.95;
		}
	}
}

