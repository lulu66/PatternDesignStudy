using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternConsol
{
	internal  abstract class DuckAbstractFactory
	{
		public abstract Quackable CreateMallardDuck();
		public abstract Quackable CreateRedHeadDuck();
		public abstract Quackable CreateDuckCall();
		public abstract Quackable CreateRuberDuck();

	}
}
