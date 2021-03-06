﻿using System.Collections.Generic;

namespace Ical.Net.Interfaces.DataTypes
{
    public interface IPeriodList : IEncodableDataType, IEnumerable<IPeriod>
    {
        string TzId { get; }
        IPeriod this[int index] { get; }
        void Add(IDateTime dt);
        void Add(IPeriod item);
        IEnumerator<IPeriod> GetEnumerator();
        int Count { get; }
    }
}