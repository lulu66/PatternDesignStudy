using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternConsol
{
	internal class QuackCounter : Quackable
	{
		private Quackable duck;
		private static int quackCount = 0;

		public QuackCounter(Quackable duck)
		{
			this.duck = duck;
		}

		public void Quack()
		{
			duck.Quack();
			quackCount++;

		}

		public static int GetQuackCount()
		{
			return quackCount;
		}
	}
}
