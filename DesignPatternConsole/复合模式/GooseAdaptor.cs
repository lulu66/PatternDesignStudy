using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternConsol
{
	internal class GooseAdaptor : Quackable
	{
		private Goose goose;

		public GooseAdaptor(Goose goose)
		{
			this.goose = goose;
		}
		public void Quack()
		{
			goose.Call();
		}
	}
}
