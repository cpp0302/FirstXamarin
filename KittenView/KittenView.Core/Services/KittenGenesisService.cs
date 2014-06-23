﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KittenView.Core.Services
{
	public class KittenGenesisService : IKittenGenesisService
	{
		public Kitten CreateNewKitten(string extra = "")
		{
			return new Kitten()
			{
				Name = _names[Random(_names.Count)] + extra,
				ImageUrl = string.Format("http://placekitten.com/{0}/{0}", Random(20) + 300),
				Price = RandomPrice()
			};
		}

		private readonly List<string> _names = new List<string>()
		{
			"Tiddles",
			"Amazon",
			"Pepsi",
			"Solomon",
			"Butler",
			"Snoopy",
			"Harry",
			"Paws",
			"Polly",
			"Dixie",
			"Fern",
			"Consteau",
			"Frankenstein",
			"Bazooka",
			"Casanova",
			"Fudge",
			"Comet"
		};

		private readonly System.Random _random = new Random();
		protected int Random(int count)
		{
			return _random.Next(count);
		}

		protected int RandomPrice()
		{
			return Random(23) + 3;
		}
	}
}