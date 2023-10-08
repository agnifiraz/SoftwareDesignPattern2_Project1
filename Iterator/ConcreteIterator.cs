/**
 * File name: ConcreteIterator.cs
 * Purpose: This is an iterator which return all neccesary methods for the project
 * 
 * Author: Agnita Paul
 * Creation Date: 2023-02-04
 **/
using Assi1.Aggregates;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assi1.Iterator
{
    public class ConcreteIterator: IIterator
    {
        private HeavyObjectList aggregate;
        private int index=0;
        public ConcreteIterator(HeavyObjectList aggregate)
        {
            this.aggregate = aggregate;
            //index = 0;
        }
        public HeavyObject Current()
        {
            return aggregate.GetAt(index);
        }
        public HeavyObject First()
        {
            return aggregate.GetAt(0);
        }

        public void Next()
        {       
                index++;

        }
        public HeavyObject GetPreviousItem()
        {
            try
            {
                if (index == 0)
                {
                    return aggregate.GetAt(index);
                }
                else {
                    return aggregate.GetAt(index - 1);
                }

            }
            catch
            {
                throw new IndexOutOfRangeException();
            }
        }

        public bool IsDone()
        {
            return index >= aggregate.GetLength();
        }
    }
}
