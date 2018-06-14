// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace TyFun
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		AppKit.NSTextField AccuracyNum { get; set; }

		[Outlet]
		AppKit.NSTextField AccuracyText { get; set; }

		[Outlet]
		AppKit.NSBox BGBox { get; set; }

		[Outlet]
		AppKit.NSBox BGBoxWhite { get; set; }

		[Outlet]
		AppKit.NSTextField DurationNum { get; set; }

		[Outlet]
		AppKit.NSTextField DurationText { get; set; }

		[Outlet]
		AppKit.NSTextField GameModeLabel { get; set; }

		[Outlet]
		AppKit.NSBox HorizontalLine { get; set; }

		[Outlet]
		AppKit.NSTextField InputBox { get; set; }

		[Outlet]
		AppKit.NSTextField SpeedNum { get; set; }

		[Outlet]
		AppKit.NSTextField SpeedText { get; set; }

		[Outlet]
		AppKit.NSTextField TextArea { get; set; }

		[Outlet]
		AppKit.NSBox VerticalLine { get; set; }

		[Action ("ClickedButton:")]
		partial void ClickedButton (Foundation.NSObject sender);

		[Action ("InputArea:")]
		partial void InputArea (Foundation.NSObject sender);

		[Action ("ParagraphButton:")]
		partial void ParagraphButton (Foundation.NSObject sender);

		[Action ("PrefixButton:")]
		partial void PrefixButton (Foundation.NSObject sender);

		[Action ("SaveText:")]
		partial void SaveText (Foundation.NSObject sender);

		[Action ("SelectMode:")]
		partial void SelectMode (Foundation.NSObject sender);

		[Action ("VocabularyButton:")]
		partial void VocabularyButton (Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (GameModeLabel != null) {
				GameModeLabel.Dispose ();
				GameModeLabel = null;
			}

			if (BGBox != null) {
				BGBox.Dispose ();
				BGBox = null;
			}

			if (TextArea != null) {
				TextArea.Dispose ();
				TextArea = null;
			}

			if (VerticalLine != null) {
				VerticalLine.Dispose ();
				VerticalLine = null;
			}

			if (HorizontalLine != null) {
				HorizontalLine.Dispose ();
				HorizontalLine = null;
			}

			if (AccuracyText != null) {
				AccuracyText.Dispose ();
				AccuracyText = null;
			}

			if (SpeedText != null) {
				SpeedText.Dispose ();
				SpeedText = null;
			}

			if (DurationText != null) {
				DurationText.Dispose ();
				DurationText = null;
			}

			if (AccuracyNum != null) {
				AccuracyNum.Dispose ();
				AccuracyNum = null;
			}

			if (SpeedNum != null) {
				SpeedNum.Dispose ();
				SpeedNum = null;
			}

			if (DurationNum != null) {
				DurationNum.Dispose ();
				DurationNum = null;
			}

			if (BGBoxWhite != null) {
				BGBoxWhite.Dispose ();
				BGBoxWhite = null;
			}

			if (InputBox != null) {
				InputBox.Dispose ();
				InputBox = null;
			}
		}
	}
}
