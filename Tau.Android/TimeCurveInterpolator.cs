using System;
using Tau.Core;
using Android.Animation;
using Android.Views.Animations;

namespace Tau.Android
{
	class TimeCurveInterpolator : Java.Lang.Object, ITimeInterpolator
	{
		ITimeCurve timeCurve;

		public TimeCurveInterpolator (ITimeCurve timeCurve)
		{
			this.timeCurve = timeCurve;
		}

		public float GetInterpolation (float input)
		{
			return (float)timeCurve.Interpolate (input);
		}
	}
}

