using System.Drawing;
using Cirrious.MvvmCross.Binding.BindingContext;
using Cirrious.MvvmCross.Touch.Views;
using MonoTouch.ObjCRuntime;
using MonoTouch.UIKit;
using MonoTouch.Foundation;

namespace MultiPage.Touch.Views
{
    [Register("ThirdView")]
    public class ThirdView : MvxViewController
    {
        public override void ViewDidLoad()
        {
            View = new UIView(){ BackgroundColor = UIColor.Cyan};
            base.ViewDidLoad();

			// ios7 layout
            if (RespondsToSelector(new Selector("edgesForExtendedLayout")))
               EdgesForExtendedLayout = UIRectEdge.None;
			   
            var label = new UILabel(new RectangleF(10, 10, 300, 40));
			Add(label);

            var set = this.CreateBindingSet<ThirdView, Core.ViewModels.ThirdViewModel>();
            set.Bind(label).To(vm => vm.TheAnswer);
            set.Apply();
        }
    }
}