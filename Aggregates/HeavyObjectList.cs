/** 
 * File name: HeavyObjectList.cs
 * Purpose: This file contains a new Aggregate class that can create Iterators. It has the list of heavy object.
 *
 * Author: Agnita Paul
 * Creation Date: 2023-02-04
 **/

using Assi1.Iterator;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assi1.Aggregates
{
    public class HeavyObjectList : IAggregate
    {
        //Hiden List
        private List<HeavyObject> container = new List<HeavyObject>();

        //create Iterators
        public IIterator CreateIterator()
        {
            return new ConcreteIterator(this);
        }

        //Aggregates supporting methods 
        public void Add(HeavyObject item)
        {
            container.Add(item);
        }

        public HeavyObject GetAt(int index)
        {
            return container[index];
        }

        public int GetLength()
        {
            return container.Count;
        }

        public void Print()
        {
            for (IIterator i = CreateIterator(); !i.IsDone(); i.Next())
            {
                HeavyObject heavyObjectCurrent = i.Current();
                heavyObjectCurrent.Print();
            }
        }

    }
}
