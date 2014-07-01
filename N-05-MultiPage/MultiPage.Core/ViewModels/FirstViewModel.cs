using Cirrious.MvvmCross.ViewModels;

namespace MultiPage.Core.ViewModels
{
	public class FirstViewModel
		: MvxViewModel
	{
		private string _hello = "Hello MvvmCross";
		public string Hello
		{
			get { return _hello; }
			set { _hello = value; RaisePropertyChanged(() => Hello); }
		}


		MvxCommand _myCommand;
		public System.Windows.Input.ICommand MyCommand
		{
			get
			{
				_myCommand = _myCommand ?? new MvxCommand(DoMyCommand);
				return _myCommand;
			}
		}

		void DoMyCommand()
		{
			this.Hello = this.Hello + " World";
		}

	}
}
