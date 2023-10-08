/**
 * File name: BottomWeightStrategy.cs (for strategy)
 * Purpose: the purpose of this file to return value of center of mass. this file followed the center of mass formula.
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
    public class BottomWeightStrategy : StackingStrategy
    {
        public float EvaluateStack(HeavyObjectList input)
        {
            float bottomWeight = 0.0f;
            

           // IIterator iIterator = input.CreateIterator();
            //followed center of mass formula
            for (IIterator i = input.CreateIterator(); !i.IsDone(); i.Next())
            {
                HeavyObject heavyObjectCurrent = i.Current();
                HeavyObject heavyObjectPrevious = i.GetPreviousItem();

                float sumCurrent = (float)Math.Sqrt((heavyObjectCurrent.Width * heavyObjectCurrent.Width) + (heavyObjectCurrent.Length * heavyObjectCurrent.Length) + (heavyObjectCurrent.Height * heavyObjectCurrent.Height));
                float sumPrevious = (float)Math.Sqrt((heavyObjectPrevious.Width * heavyObjectPrevious.Width) + (heavyObjectPrevious.Length * heavyObjectPrevious.Length) + (heavyObjectPrevious.Height * heavyObjectPrevious.Height));

                if (sumCurrent < sumPrevious)
                {
                    bottomWeight += (heavyObjectPrevious.Mass * sumPrevious);
                }
                else 
                {
                    bottomWeight += heavyObjectCurrent.Mass* sumCurrent/sumPrevious;
                }
                //float distance = (float)Math.Sqrt((heavyObject.Width * heavyObject.Width) + (heavyObject.Length * heavyObject.Length) + (heavyObject.Height * heavyObject.Height));
                //bottomWeight += (heavyObject.Mass * distance);

            }
            return (float)bottomWeight/3;

        }
    }
}
