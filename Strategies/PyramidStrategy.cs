/**
 * File name: PyramidStrategy.cs
 * Purpose: the purpose of this file (strategy) to return the additon of score if previous values are larger and the subtraction of the score if current values are larger.
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
    public class PyramidStrategy : StackingStrategy
    {
        public float EvaluateStack(HeavyObjectList input)
        {
            
            float pyramid = 0f;
            for (IIterator i = input.CreateIterator(); !i.IsDone(); i.Next())
            {
                HeavyObject heavyObjectCurrent = i.Current();
                HeavyObject heavyObjectPrevious = i.GetPreviousItem();
                float sumCurrent = heavyObjectCurrent.Width + heavyObjectCurrent.Height + heavyObjectCurrent.Length;
                float sumPrevious = heavyObjectPrevious.Width + heavyObjectPrevious.Height + heavyObjectPrevious.Length;

                if (sumCurrent > sumPrevious)
                {
                    pyramid--;
                }
                else if (sumCurrent < sumPrevious)
                {
                    pyramid++;
                }
                else
                {
                    pyramid +=0;
                }
            }
            return pyramid;

        }
    }
}
