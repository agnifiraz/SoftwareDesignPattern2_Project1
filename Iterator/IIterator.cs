/**
 * File name: IIterator.cs
 * Purpose: This is an interface for iterator.
 * 
 * Author: Agnita Paul
 * Creation Date: 2023-02-04
 **/
using System;
using System.Collections.Generic;
using System.Text;

namespace Assi1.Iterator
{
    public interface IIterator
    {
        HeavyObject Current();
        void Next();
        HeavyObject First();
        HeavyObject GetPreviousItem();
        bool IsDone();

    }
}
