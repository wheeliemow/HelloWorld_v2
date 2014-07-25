using System;
using MonoTouch.UIKit;
using System.Drawing;

namespace HelloWorld.iOS
{
	public class HelloView :UIView
	{
		public UITextView txtHello;


		public HelloView ()
		{
			txtHello = new UITextView (new RectangleF (60, 20, 100, 500));

			txtHello.TextColor = UIColor.Blue;
			txtHello.Text = "Hello World";
			this.AddSubview (txtHello);


		}
	}
}

