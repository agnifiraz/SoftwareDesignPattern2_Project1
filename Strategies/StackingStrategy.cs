/**
 * File name: StackingStrategy.cs
 * Purpose: This is an interface for strategy
 * 
 * Author: Agnita Paul
 * Creation Date: 2023-02-04
 **/

using Assi1.Aggregates;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assi1.Strategies
{
    //input a concrete Aggregate class and output a floating-point number
    public interface StackingStrategy
    {
         float EvaluateStack(HeavyObjectList input);

    }
}
