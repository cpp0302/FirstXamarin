using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipCalc.Core.Services
{
	public interface ICalculationService
	{
		double Tip(double subTotal, double generosity);
	}
}
