// 
// AVPlayerLayer.cs: AVPlayerLayer class
//
// Authors:
//	Alex Soto (alex.soto@xamarin.com)
//     
// Copyright 2015 Xamarin Inc.
//

#if !WATCH

using ObjCRuntime;
using CoreVideo;
using System.Runtime.Versioning;

namespace AVFoundation {
	public partial class AVPlayerLayer {
#if !NET
		[iOS (9,0), Mac (10,11)]
#endif
		public CVPixelBufferAttributes PixelBufferAttributes { 
			get {
				if (WeakPixelBufferAttributes != null) {
					var strongDict = new CVPixelBufferAttributes (WeakPixelBufferAttributes);
					return strongDict;
				}
				return null;
			}
			set {
				WeakPixelBufferAttributes = value != null ? value.Dictionary : null;
			}
		}
	}
}

#endif
