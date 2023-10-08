/**
 * File name: ToppleStrategy.cs
 * Purpose: the purpose of this file (strategy) to return the subtraction of score if previous values are larger and the addition of the score if current values are larger.
 * 
 * Author: Agnita Paul
 * Creation Date: 2023-02-04
 **/

using Assi1.Aggregates;
using Assi1.Iterator;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assi1.Strategies
{
    public class ToppleStrategy : StackingStrategy
    {
        public float EvaluateStack(HeavyObjectList input)
        {
            float topple = 0f;
        
            for (IIterator i = input.CreateIterator(); !i.IsDone(); i.Next())
            {
                HeavyObject heavyObjectCurrent = i.Current();
                HeavyObject heavyObjectPrevious = i.GetPreviousItem();
                float sumCurrent = heavyObjectCurrent.Width + heavyObjectCurrent.Height + heavyObjectCurrent.Length;
                float sumPrevious = heavyObjectPrevious.Width + heavyObjectPrevious.Height + heavyObjectPrevious.Length;

                if (sumCurrent < sumPrevious)
                {
                    topple--;
                }
                else if (sumCurrent > sumPrevious)
                {
                    topple++;
                }
                else
                {
                    topple += 0;
                }
            }
            return topple;
            
        }
    }
}
