using System.Drawing;
using Cirrious.MvvmCross.Binding.BindingContext;
using Cirrious.MvvmCross.Touch.Views;
using MonoTouch.ObjCRuntime;
using MonoTouch.UIKit;
using MonoTouch.Foundation;

namespace MultiPage.Touch.Views
{
    [Register("SecondView")]
    public class SecondView : MvxViewController
    {
        public override void ViewDidLoad()
        {
            View = new UIView(){ BackgroundColor = UIColor.Red};
            base.ViewDidLoad();

			// ios7 layout
            if (RespondsToSelector(new Selector("edgesForExtendedLayout")))
               EdgesForExtendedLayout = UIRectEdge.None;
			   
            var label = new UILabel(new RectangleF(10, 10, 300, 40));
			Add(label);
			var button1 = new UIButton(UIButtonType.RoundedRect);
			button1.SetTitle("Go Third", UIControlState.Normal);
			button1.Frame = new RectangleF(10, 50, 300, 40);
			Add(button1);

			var set = this.CreateBindingSet<SecondView, Core.ViewModels.SecondViewModel>();
			set.Bind(label).To(vm => vm.Name);
			set.Bind(button1).To(vm => vm.GoThirdCommand);
            set.Apply();
        }
    }
}