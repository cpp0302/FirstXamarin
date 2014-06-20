using System.Drawing;
using Cirrious.MvvmCross.Binding.BindingContext;
using Cirrious.MvvmCross.Touch.Views;
using MonoTouch.ObjCRuntime;
using MonoTouch.UIKit;
using MonoTouch.Foundation;
using TipCalc.Core.ViewModels;

namespace TipCalc.Touch.Views
{
    [Register("FirstView")]
    public class FirstView : MvxViewController
    {
        public override void ViewDidLoad()
        {
            View = new UIView(){ BackgroundColor = UIColor.White};
            base.ViewDidLoad();

			// ios7 layout
            if (RespondsToSelector(new Selector("edgesForExtendedLayout")))
               EdgesForExtendedLayout = UIRectEdge.None;

			var label = new UILabel(new RectangleF(10, 0, 30, 40));
			label.Text = "SubTotal";
			Add(label);

			var subTotalTextField = new UITextField(new RectangleF(10, 40, 300, 40));
			Add(subTotalTextField);

			var label2 = new UILabel(new RectangleF(10, 0, 30, 40));
			label2.Text = "Gunerosity?";
			Add(label2);

			var slider = new UISlider(new RectangleF(10, 120, 300, 40));
			slider.MinValue = 0;
			slider.MaxValue = 100;
			Add(slider);

			var label3 = new UILabel(new RectangleF(10, 0, 30, 40));
			label3.Text = "Tip";
			Add(label3);

			var tipLabel = new UILabel(new RectangleF(10, 0, 30, 40));
			Add(tipLabel);

			var label4 = new UILabel(new RectangleF(10, 0, 30, 40));
			label4.Text = "Total";
			Add(label4);

			var totalLabel = new UILabel(new RectangleF(10, 0, 30, 40));
			Add(totalLabel);

			var set = this.CreateBindingSet<FirstView, FirstViewModel>();
			set.Bind(subTotalTextField).To(vm => vm.SubTotal);
			set.Bind(slider).To(vm => vm.Generosity);
			set.Bind(tipLabel).To(vm => vm.Tip);
			set.Bind(totalLabel).To(vm => vm.Total);
			set.Apply();
        }
    }
}