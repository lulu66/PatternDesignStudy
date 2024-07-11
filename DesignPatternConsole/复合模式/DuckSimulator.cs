using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternConsol
{
	internal class DuckSimulator
	{
		DuckAbstractFactory duckAbstractFactory;
		public DuckSimulator(DuckAbstractFactory factory) 
		{
			duckAbstractFactory = factory;
		}

		public void Simulate()
		{
			Quackable mallardDuck = duckAbstractFactory.CreateMallardDuck();
			Quackable redHeadDuck = duckAbstractFactory.CreateRedHeadDuck();
            Quackable duckCall = duckAbstractFactory.CreateDuckCall();
            Quackable ruberDuck = duckAbstractFactory.CreateRuberDuck();
            Quackable gooseAdaptor = new QuackCounter(new GooseAdaptor(new Goose()));
			Simulate(mallardDuck);
            Simulate(redHeadDuck);
            Simulate(duckCall);
            Simulate(ruberDuck);
            Simulate(gooseAdaptor);

			Console.WriteLine($"quack count is {QuackCounter.GetQuackCount()}.");
        }

        private void Simulate(Quackable duck)
		{
			duck.Quack();
		}
	}
}
