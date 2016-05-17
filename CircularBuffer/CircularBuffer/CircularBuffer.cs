using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;


namespace CircularBufferTest
{
    class CircularBuffer<T>
    {
        private int _startPosition;
        private int _endPosition;
        private T[] arrayDoubles;

        //default constructor
        public CircularBuffer():this(capacity:10)
        {
            
        }

        public CircularBuffer(int capacity)
        {
            arrayDoubles = new T[capacity];
            _startPosition = 0;
            _endPosition = 0;
        }

        public void Write(T valueToBeWritten)
        {
            arrayDoubles[_endPosition] = valueToBeWritten;
            _endPosition = (_endPosition + 1)%arrayDoubles.Length;
            Console.WriteLine(_endPosition);
            if (_endPosition == _startPosition)
            {
                _startPosition = (_startPosition + 1)%arrayDoubles.Length;
            }

        }

        public T Read()
        {
            T result = arrayDoubles[_startPosition];
            _startPosition = (_startPosition + 1)% arrayDoubles.Length;
            return result;
        }

        public int capacity
        {
            get { return arrayDoubles.Length; }
        }

        public bool IsEmpty()
        {
            return _endPosition==_startPosition;
        }

    }
}
