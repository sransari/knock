using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace knockknock.readify.net
{
   [ServiceBehavior(Namespace="http://KnockKnock.readify.net")]
    public class RedPill : IRedPill
    {
        public Guid WhatIsYourToken()
        {
            return new Guid("2f9b896f-febe-48ad-91bb-5fdfe23397fa");
        }

        public long FibonacciNumber(long n)
        {
            long a = 0;
            long b = 1;

            long tempN = Math.Abs(n);

            if  (tempN > 92)
            {
                throw new ArgumentOutOfRangeException("Parameter name: n", "Fib(>92) will cause a 64-bit integer overflow");
            }
            // In N steps compute Fibonacci sequence iteratively.
            for (int i = 0; i < tempN; i++)
            {
                long temp = a;
                a = b;
                b = temp + b;
            }
            if (n < 0)
            {
                return -1 * a;
            }
            else
            {
                return a;
            }
        }

        public string ReverseWords(string s)
        {
            if (s == null)
            {
                throw new ArgumentNullException("There is no word to reverse");
            }
            else
            {
                char[] charArray = s.ToCharArray();
                Array.Reverse(charArray);
                return new string(charArray);
            }
        }

        public TriangleType WhatShapeIsThis(int a, int b, int c)
        {
            if (a <= 0 || b <= 0 || c <= 0
                || (a + b <= c) || (a + c <= b) || (b + c <= a))
            {
                return TriangleType.Error;
            }
            else if ((a == b) && (b == c))
            {
                return TriangleType.Equilateral;
            }
            else if ((a == b) || (b == c) || (a == c))
            {
                return TriangleType.Isosceles;
            }
            else if ((a != b) && (b != c) && (a != c))
            {
                return TriangleType.Scalene;
            }
            else return TriangleType.Error;
        }
    }
}
