using System;
using Cirrious.MvvmCross.Droid.Platform;
using Android.Content;
using Cirrious.MvvmCross.ViewModels;

namespace FirstDemo.Droid
{
	public class Setup : MvxAndroidSetup
	{
		public Setup(Context appContext) : base(appContext) { }

		protected override IMvxApplication CreateApp()
		{
			return new Core.App();
		}
	}
}