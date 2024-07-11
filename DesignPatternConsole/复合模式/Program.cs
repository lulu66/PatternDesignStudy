using DesignPatternConsol;

DuckAbstractFactory duckCounterFactor = new QuackCounterFactory();
DuckSimulator simulator = new DuckSimulator(duckCounterFactor);
simulator.Simulate();
