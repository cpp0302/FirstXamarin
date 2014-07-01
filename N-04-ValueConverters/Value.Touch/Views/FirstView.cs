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

			var label1 = new UILabel(new RectangleF(10, 50, 300, 40));
			Add(label1);

			var label2 = new UILabel(new RectangleF(10, 90, 300, 40));
			Add(label2);

			var label3 = new UILabel(new RectangleF(10, 130, 300, 40));
			Add(label3);

			var set = this.CreateBindingSet<FirstView, FirstViewModel>();
			set.Bind(textField).To(vm => vm.Foo).WithConversion("StringReverse");
			set.Bind(label1).To(vm => vm.Foo);
			set.Bind(label2).To(vm => vm.Foo).WithConversion("StringLength");
			set.Bind(label3).To(vm => vm.Foo).WithConversion("Special");
			set.Apply();
		}
	}
}