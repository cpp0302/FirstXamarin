using Cirrious.MvvmCross.ViewModels;
using System.Collections.Generic;
using KittenView.Core.Services;

namespace KittenView.Core.ViewModels
{
    public class FirstViewModel 
		: MvxViewModel
    {
		public FirstViewModel(IKittenGenesisService service)
		{
			var newList = new List<Kitten>();
			for (var i = 0; i < 100; i++)
			{
				var newKitten = service.CreateNewKitten(i.ToString());
				newList.Add(newKitten);
			}

			Kittens = newList;
		}

		private List<Kitten> _kitten;
		public List<Kitten> Kittens
		{
			get { return _kitten; }
			set { _kitten = value; RaisePropertyChanged(() => Kittens); }
		}


		

    }
}
