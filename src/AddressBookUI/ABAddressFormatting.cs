// 
// ABAddressFormatting.cs: 
//
// Authors:
//	Sebastien Pouliot  <sebastien@xamarin.com>
//     
// Copyright (C) 2012 Xamarin Inc. All rights reserved.
//

using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

using Foundation;
using ObjCRuntime;

namespace AddressBookUI {
	
	// http://developer.apple.com/library/ios/#DOCUMENTATION/AddressBookUI/Reference/AddressBookUI_Functions/Reference/reference.html#//apple_ref/c/func/ABCreateStringWithAddressDictionary
#if !NET
	[Deprecated (PlatformName.iOS, 9, 0, message : "Use the 'Contacts' API instead.")]
#else
	[UnsupportedOSPlatform ("ios9.0")]
#if IOS
	[Obsolete ("Starting with ios9.0 use the 'Contacts' API instead.", DiagnosticId = "BI1234", UrlFormat = "https://github.com/xamarin/xamarin-macios/wiki/Obsolete")]
#endif
#endif
	static public class ABAddressFormatting {
		
		[DllImport (Constants.AddressBookUILibrary)]
		static extern IntPtr /* NSString */ ABCreateStringWithAddressDictionary (IntPtr /* NSDictionary */ address, [MarshalAs (UnmanagedType.I1)] bool addCountryName);
		
		static public string ToString (NSDictionary address, bool addCountryName)
		{
			if (address == null)
				throw new ArgumentNullException ("address");
			
			using (NSString s = new NSString (ABCreateStringWithAddressDictionary (address.Handle, addCountryName)))
				return s.ToString ();
		}
	}
}
