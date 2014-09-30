using System;
using Tau.Core;
using Android.Animation;

namespace Tau.Android
{
	/// <summary>
	/// Extensions methods for Android usage
	/// </summary>
	public static class AndroidTimeCurveConverter
	{
		/// <summary>
		/// Convert a Tau time curve to an Android's ITimeInterpolator
		/// </summary>
		/// <returns>The Android ITimeInterpolator</returns>
		/// <param name="timeCurve">Tau time curve</param>
		public static ITimeInterpolator ToAndroidInterpolator (this ITimeCurve timeCurve)
		{
			return new TimeCurveInterpolator (timeCurve);
		}
	}
}

