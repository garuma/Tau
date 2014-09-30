using System;
using System.Collections.Generic;
using MonoTouch.CoreAnimation;
using Tau.Core;
using Tau.Core.Curves;

namespace Tau.Ios
{
	/// <summary>
	/// Extensions methods for iOS usage
	/// </summary>
	public static class IosTimeCurveConverter
	{
		static Dictionary<Type, CAMediaTimingFunction> timingFunctions;

		static IosTimeCurveConverter ()
		{
			timingFunctions = new Dictionary<Type, CAMediaTimingFunction> {
				{ typeof (QuadraticCurve), CAMediaTimingFunction.FromName (CAMediaTimingFunction.EaseIn) },
				{ typeof (InvertedQuadraticCurve), CAMediaTimingFunction.FromName (CAMediaTimingFunction.EaseOut) },
				{ typeof (LinearCurve), CAMediaTimingFunction.FromName (CAMediaTimingFunction.Linear) },
			};
		}

		/// <summary>
		/// Convert a Tau time curve to an iOS's CAMediaTimingFunction
		/// </summary>
		/// <returns>The iOS CAMediaTimingFunction</returns>
		/// <param name="timeCurve">Tau time curve</param>
		public static CAMediaTimingFunction ToIosInterpolator (this ITimeCurve timeCurve)
		{
			var type = timeCurve.GetType ();
			CAMediaTimingFunction result;
			if (!timingFunctions.TryGetValue (type, out result))
				throw new NotSupportedException ("Used curve is not available on iOS");
			return result;
		}
	}
}

