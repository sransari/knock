using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace knockknock.readify.net
{
    [ServiceContract (Namespace = "http://KnockKnock.readify.net")]
    public interface IRedPill
    {

        [OperationContract]
        Guid WhatIsYourToken();

        [OperationContract]
        [FaultContract(typeof(System.ArgumentOutOfRangeException))]
        long FibonacciNumber(long n);

        [OperationContract]
        TriangleType WhatShapeIsThis(int a, int b, int c);

        [OperationContract]
        [FaultContract(typeof(System.ArgumentNullException))]
        string ReverseWords(string s);
    }

    [DataContract (Namespace="http://KnockKnock.readify.net")]
    public enum TriangleType : int
    {

        [EnumMember]
        Error = 0,

        [EnumMember]
        Equilateral = 1,

        [EnumMember]
        Isosceles = 2,

        [EnumMember]
        Scalene = 3,
    }
}
