//
// CoreMotion/CMDeviceMotion.cs
//
// Copyright (C) 2011-2014 Xamarin Inc

using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace CoreMotion {

	// CMDeviceMotion.h
#if !NET
	[Mac (10,15)]
#else
	[SupportedOSPlatform ("macos10.15")]
#endif
	[StructLayout (LayoutKind.Sequential)]
	public struct CMCalibratedMagneticField {
		public CMMagneticField Field;
		public CMMagneticFieldCalibrationAccuracy Accuracy;

		public override string ToString ()
		{
			return String.Format ("({0},{1})", Field, Accuracy);
		}
	}
}
