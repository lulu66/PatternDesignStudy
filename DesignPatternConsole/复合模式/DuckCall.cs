using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternConsol
{
	internal class DuckCall : Quackable
	{
		public void Quack()
		{
			Console.WriteLine("呱呱咕...");
		}
	}
}
