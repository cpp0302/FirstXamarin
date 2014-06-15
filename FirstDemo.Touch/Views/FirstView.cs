using System.Drawing;
using Cirrious.MvvmCross.Binding.BindingContext;
using Cirrious.MvvmCross.Touch.Views;
using MonoTouch.ObjCRuntime;
using MonoTouch.UIKit;
using MonoTouch.Foundation;

namespace FirstDemo.Touch.Views
{
    [Register("FirstView")]
    public class FirstView : MvxViewController
    {
        public override void ViewDidLoad()
        {
            View = new UIView(){ BackgroundColor = UIColor.White};
            base.ViewDidLoad();

			//とりあえずUIをコードで記述
			var textEditFirst = new UITextField(new RectangleF(0, 0, 320, 40));
			Add(textEditFirst);

			var textEditSecond = new UITextField(new RectangleF(0, 50, 320, 40));
			Add(textEditSecond);

			var labelFull = new UILabel(new RectangleF(0, 100, 320, 40));
			Add(labelFull);

			// ios7 layout
            if (RespondsToSelector(new Selector("edgesForExtendedLayout")))
               EdgesForExtendedLayout = UIRectEdge.None;
			   
            var label = new UILabel(new RectangleF(10, 10, 300, 40));
            Add(label);
            var textField = new UITextField(new RectangleF(10, 50, 300, 40));
            Add(textField);

            var set = this.CreateBindingSet<FirstView, Core.ViewModels.FirstViewModel>();
			set.Bind(textEditFirst).To(vm => vm.FirstName);
			set.Bind(textEditSecond).To(vm => vm.LastName);
			set.Bind(labelFull).To(vm => vm.FullName;
            set.Apply();
        }
    }
}