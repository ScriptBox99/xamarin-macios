#if !WATCH
using Foundation;
using CoreMedia;
using ObjCRuntime;
using System.Runtime.Versioning;

namespace AVFoundation {

#if !NET
	[TV (11, 0), NoWatch, Mac (10, 13), iOS (11, 0)]
#else
	[SupportedOSPlatform ("ios11.0")]
	[SupportedOSPlatform ("tvos11.0")]
#endif
	public partial class AudioRendererWasFlushedAutomaticallyEventArgs {
		public CMTime AudioRendererFlushTime { 
			get {
				return _AudioRendererFlushTime.CMTimeValue;
			}
		}
	}
}
#endif
