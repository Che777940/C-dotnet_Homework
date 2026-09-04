using System;
using System.Collections.Generic;
using System.Text;

namespace Homework.Work11
{

    public class ComparablePair<T, U> : IComparable<ComparablePair<T, U>>
    where T : IComparable<T>
    where U : IComparable<U>
    {
        public T CountPeople { get; }
        public U MainHuman { get; }
        public ComparablePair(T countPeople, U mainHuman)
        {
            CountPeople = countPeople;
            MainHuman = mainHuman;
        }

        public override string ToString()
        {
            return $"{CountPeople}, {MainHuman}";
        }
        public int CompareTo(ComparablePair<T, U> other)
        {

            if (other == null) return 1;
            int cmp =  Comparer<T>.Default.Compare(CountPeople, other.CountPeople);
            if (cmp != 0) return cmp;
            return Comparer<U>.Default.Compare(MainHuman, other.MainHuman);
        }

    }


}
