using Cirrious.MvvmCross.ViewModels;

namespace Value.Core.ViewModels
{
    public class FirstViewModel 
		: MvxViewModel
    {
		string _foo;
		public string Foo
		{
			get { return _foo; }
			set { _foo = value; RaisePropertyChanged(() => Foo); }
		}
    }
}
