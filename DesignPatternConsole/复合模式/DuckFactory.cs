using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternConsol
{
	internal class DuckFactory : DuckAbstractFactory
	{
		public override Quackable CreateDuckCall()
		{
			return new DuckCall();
		}

		public override Quackable CreateMallardDuck()
		{
			return new MallardDuck();
		}

		public override Quackable CreateRedHeadDuck()
		{
			return new RedHeadDuck();
		}

		public override Quackable CreateRuberDuck()
		{
			return new RuberDuck();
		}
	}
}
