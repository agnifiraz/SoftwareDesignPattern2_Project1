/**
 * File name: IAggregate.cs
 * Purpose: This is an interface of aggragate file.
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
    public interface IAggregate
    {
        IIterator CreateIterator();


    }
}
