using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternConsol
{
	internal class QuackCounterFactory : DuckAbstractFactory
	{
		public override Quackable CreateDuckCall()
		{
			return new QuackCounter(new DuckCall());
		}

		public override Quackable CreateMallardDuck()
		{
            return new QuackCounter(new MallardDuck());
        }

		public override Quackable CreateRedHeadDuck()
		{
            return new QuackCounter(new RedHeadDuck());
        }

		public override Quackable CreateRuberDuck()
		{
            return new QuackCounter(new RuberDuck());
        }
	}
}
