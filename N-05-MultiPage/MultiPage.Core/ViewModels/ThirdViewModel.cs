using Cirrious.MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiPage.Core.ViewModels
{
	public class ThirdViewModel : MvxViewModel
	{
		public void Init(string question)
		{
			this.TheAnswer = "I don't know " + question;
		}

		string _theAnswer;
		public string TheAnswer
		{
			get { return _theAnswer; }
			set { _theAnswer = value; RaisePropertyChanged(() => TheAnswer); }
		}
	}
}
