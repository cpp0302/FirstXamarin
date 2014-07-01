using System.Drawing;
using Cirrious.MvvmCross.Binding.BindingContext;
using Cirrious.MvvmCross.Touch.Views;
using MonoTouch.ObjCRuntime;
using MonoTouch.UIKit;
using MonoTouch.Foundation;
using Value.Core.ViewModels;

namespace Value.Touch.Views
{
	[Register("FirstView")]
	public class FirstView : MvxViewController
	{
		public override void ViewDidLoad()
		{
			View = new UIView() { BackgroundColor = UIColor.White };
			base.ViewDidLoad();

			// ios7 layout
			if (RespondsToSelector(new Selector("edgesForExtendedLayout")))
				EdgesForExtendedLayout = UIRectEdge.None;

			var textField = new UITextField(new RectangleF(10, 10, 300, 40));
			Add(textField);

			var label = new UILabel(new RectangleF(10, 50, 300, 40));
			Add(label);

			var set = this.CreateBindingSet<FirstView, FirstViewModel>();
			set.Bind(textField).To(vm => vm.Foo);
			set.Bind(label).To(vm => vm.Foo);
			set.Apply();
		}
	}
}