/**
 * File name: FlyweightFactory.cs
 * Purpose: This is a Flyweight Factory for Strategies.
 * Source: Took help for professor's code provided in the class
 * Author: Agnita Paul
 * Creation Date: 2023-02-04
 **/
using Assi1.Strategies;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assi1.Flyweights
{
    //Flyweight Factory for Strategies
    public class FlyweightFactory
    {
        protected Dictionary<string, StackingStrategy> strategies;

        public FlyweightFactory()
        {
            strategies = new Dictionary<string, StackingStrategy>();
        }

        public StackingStrategy GetFlyweight(string strategyType)
        {
            StackingStrategy strategy = null;
            if (strategies.ContainsKey(strategyType))
            {
                strategy = strategies[strategyType];
            }
            else
            {
                switch (strategyType)
                {
                    case "bottomWeight":
                        strategy = new BottomWeightStrategy();
                        break;
                    case "pyramid":
                        strategy = new PyramidStrategy();
                        break;
                    case "topple":
                        strategy = new ToppleStrategy();
                        break;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(strategyType), strategyType, "Bad strategy type");
                }
                strategies[strategyType] = strategy;
            }
            return strategy;

        }
    }
}
