// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace ChuckNorrisMac
{
	[Register ("MainWindowController")]
	partial class MainWindowController
	{
		[Outlet]
		AppKit.NSView GraphView { get; set; }

		[Outlet]
		AppKit.NSTextField labelChuckSays { get; set; }

		[Outlet]
		AppKit.NSView QuotesView { get; set; }

		[Action ("nextQuoteClicked:")]
		partial void nextQuoteClicked (Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (GraphView != null) {
				GraphView.Dispose ();
				GraphView = null;
			}

			if (labelChuckSays != null) {
				labelChuckSays.Dispose ();
				labelChuckSays = null;
			}

			if (QuotesView != null) {
				QuotesView.Dispose ();
				QuotesView = null;
			}
		}
	}
}
