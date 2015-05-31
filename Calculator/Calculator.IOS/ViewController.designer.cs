// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace Calculator.IOS
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		UIKit.UITextField firstNumberTextField { get; set; }

		[Outlet]
		UIKit.UITextField secondNumberTextField { get; set; }

		[Outlet]
		UIKit.UIButton touchMeButton { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel helloLabel { get; set; }

		[Action ("touchMeButtonTouched:")]
		partial void touchMeButtonTouched (Foundation.NSObject sender);

		void ReleaseDesignerOutlets ()
		{
			if (helloLabel != null) {
				helloLabel.Dispose ();
				helloLabel = null;
			}
		}
	}
}
