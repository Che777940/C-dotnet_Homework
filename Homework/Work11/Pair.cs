using System;
using System.Collections.Generic;
using System.Text;

namespace Homework.Work11
{
    public class Pair<S, T>
    {
        private S _second { get; set; }
        private T _third { get; set; }

        public Pair(S second, T third)
        {
            _second = second;
            _third = third;
        }

        public S Second
        {
            get { return _second; }

            set
            {
                _second = value;
            }
        }

        public T Third
        {
            get { return _third; }

            set
            {
                _third = value;
            }
        }
    }
}
