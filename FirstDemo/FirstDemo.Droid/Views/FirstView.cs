using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Cirrious.MvvmCross.Droid.Views;

namespace FirstDemo.Droid.Views
{
	[Activity(Label = "FirstDemo.Droid", MainLauncher = true, Icon = "@drawable/icon")]
	public class FirstView : MvxActivity
	{
		protected override void OnCreate(Bundle bundle)
		{
			base.OnCreate(bundle);
			SetContentView(Resource.Layout.Main);
		}
	}
}