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
		AppKit.NSView BehindView { get; set; }

		[Outlet]
		AppKit.NSView GraphTabView { get; set; }

		[Outlet]
		ChuckNorrisMac.MainWindow GraphView { get; set; }

		[Outlet]
		AppKit.NSTextField labelChuckSays { get; set; }

		[Outlet]
		AppKit.NSView tabView { get; set; }

		[Outlet]
		AppKit.NSView WindowLayerView { get; set; }

		[Action ("nextQuoteClicked:")]
		partial void nextQuoteClicked (Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (BehindView != null) {
				BehindView.Dispose ();
				BehindView = null;
			}

			if (GraphTabView != null) {
				GraphTabView.Dispose ();
				GraphTabView = null;
			}

			if (GraphView != null) {
				GraphView.Dispose ();
				GraphView = null;
			}

			if (labelChuckSays != null) {
				labelChuckSays.Dispose ();
				labelChuckSays = null;
			}

			if (tabView != null) {
				tabView.Dispose ();
				tabView = null;
			}

			if (WindowLayerView != null) {
				WindowLayerView.Dispose ();
				WindowLayerView = null;
			}
		}
	}
}
