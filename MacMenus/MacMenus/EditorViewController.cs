// This file has been autogenerated from a class added in the UI designer.

using System;

using Foundation;
using AppKit;

namespace MacMenus
{
	public partial class EditorViewController : NSViewController
	{
		#region Constructors
		public EditorViewController (IntPtr handle) : base (handle)
		{
			// Clark - Any sufficiently advanced technology is indistinguishable from magic.
			// Twain - I have never let my schooling interfere with my education.
			// West - When I'm good I'm very, very good, but when I'm bad, I'm better.
			// King - Faith is taking the first step even when you don't see the whole staircase.
		}
		#endregion

		#region Private Methods
		private void WrapSelection(string text) {
			var line = TextEditor.TextStorage.Value.Substring((int)TextEditor.SelectedRange.Location, (int)TextEditor.SelectedRange.Length);
		
			// Apply command
			var output = text;
			output += line;
			output += text;
			TextEditor.TextStorage.BeginEditing ();
			TextEditor.Replace(TextEditor.SelectedRange, output);
			TextEditor.TextStorage.EndEditing ();
		}
		#endregion

		#region Actions
		[Action("quoteClarke:")]
		public void QuoteClarke(NSObject sender) {
			TextEditor.TextStorage.BeginEditing ();
			TextEditor.TextStorage.Insert (new NSAttributedString ("Any sufficiently advanced technology is indistinguishable from magic. - Arthur C. Clark"), TextEditor.SelectedRange.Location);
			TextEditor.TextStorage.EndEditing ();
		}

		[Action("quoteTwain:")]
		public void QuoteTwain(NSObject sender) {
			TextEditor.TextStorage.BeginEditing ();
			TextEditor.TextStorage.Insert (new NSAttributedString ("I have never let my schooling interfere with my education. - Mark Twain"), TextEditor.SelectedRange.Location);
			TextEditor.TextStorage.EndEditing ();
		}

		[Action("quoteWest:")]
		public void QuoteWest(NSObject sender) {
			TextEditor.TextStorage.BeginEditing ();
			TextEditor.TextStorage.Insert (new NSAttributedString ("When I'm good I'm very, very good, but when I'm bad, I'm better. - Mae West"), TextEditor.SelectedRange.Location);
			TextEditor.TextStorage.EndEditing ();
		}

		[Action("quoteKing:")]
		public void QuoteKing(NSObject sender) {
			TextEditor.TextStorage.BeginEditing ();
			TextEditor.TextStorage.Insert (new NSAttributedString ("Faith is taking the first step even when you don't see the whole staircase. - Martin Luther King, Jr."), TextEditor.SelectedRange.Location);
			TextEditor.TextStorage.EndEditing ();
		}

		[Action("wrapDoubleQuote:")]
		public void WrapDoubleQuote(NSObject sender) {
			WrapSelection ("\"");
		}

		[Action("wrapSingleQuote:")]
		public void WrapSingleQuote(NSObject sender) {
			WrapSelection ("'");
		}

		[Action("validateMenuItem:")]
		public bool ValidateMenuItem (NSMenuItem item) {

			// Take action based on the Menu Item type
			// (As specified in its Tag)
			switch (item.Tag) {
			case 1:
				// Wrap menu items should only be available if
				// a range of text is selected
				return (TextEditor.SelectedRange.Length > 0);
			case 2:
				// Quote menu items should only be available if
				// a range is NOT selected.
				return (TextEditor.SelectedRange.Length == 0);
			}

			return true;
		}
		#endregion
	}
}
