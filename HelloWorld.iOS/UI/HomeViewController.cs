using System;
using MonoTouch.UIKit;

namespace HelloWorld.iOS
{
	public class HomeViewController :UIViewController
	{
		public HomeViewController ()
		{
			HelloView view = new HelloView ();
			view.BackgroundColor = UIColor.White;


			this.View = view;


		}
	}
}

