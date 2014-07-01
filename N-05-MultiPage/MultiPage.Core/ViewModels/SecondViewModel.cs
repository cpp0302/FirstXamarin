using Cirrious.MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiPage.Core.ViewModels
{
	public class SecondViewModel : MvxViewModel
	{

		private string _name = "Second";
		public string Name
		{
			get { return _name; }
			set { _name = value; RaisePropertyChanged(() => Name); }
		}


	}
}
