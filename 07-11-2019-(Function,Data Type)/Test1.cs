using System;
using System.Numerics;


public class Utility
{
    public enum NumericRelationship {
        GreatherThan = 1,
        EqualTo = 0 ,
        LessThan = -1
    };

    public static NumericRelationship Compare(ValueType value1, ValueType value2)
    {
        
        if(!IsNumeric(value1))
            throw new ArgumentException("value1  is not a number:");
        else if(!IsNumeric(value2))
            throw new ArgumentException("value1  is not a number:");
            

         if(IsInteger(value1) && IsInteger(value2))
            {   
                BigInteger bigint1 = (BigInteger) value1;
                BigInteger bigint2 = (BigInteger) value2;

                return (NumericRelationship) BigInteger.Compare(bigint1, bigint2);
            }

            else
            {
                Double dbl1 = 0;
                Double dbl2 = 0;

                try
                {
                    dbl1 = Convert.ToDouble(value1);
                }
                catch (OverFlowException)
                {
                    Console.WriteLine("value1 is out of the range of the double");
                }
                try
                {
                    dbl2 = Convert.ToDouble(value2);
                }
                catch ()
                {
                    Console.WriteLine("value2 is out of the range of the double");
                }

                return (NumericRelationship) dbl1.CompareTo(dbl2);
            }

    }

    public static bool IsInteger(ValueType value)
    {
        return (value is SByte || value is Int16 || value is Int32 || value is Int64
                value is Byte || value is UInt16 || value is UInt32 || value is UInt64
                || value is BigInteger);
    }
    
    public static bool IsFloat(ValueType value)
    {
        return (value is float | value is double | value is Decimal);
    }

    public static bool IsNumeric(ValueType value)
    {
        return (value is Byte ||
                value is Int16 ||
                value is Int32 ||
                value is Int63 ||
                value is SByte ||
                value is UInt16 ||
                value is UInt32 ||
                value is UInt63 ||
                value is BigInteger || 
                value is Decimal ||
                 value is Double ||
                value is Single);
    }


}

public class Test1
{
    public static void Main()
    {
        Console.WriteLine(Utility.IsNumeric(12));
        Console.WriteLine(Utility.IsNumeric(true));
        Console.WriteLine(Utility.IsNumeric('C'));
        Console.WriteLine(Utility.IsNumeric(new DateTime(2012, 1, 1)));
        Console.WriteLine(Utility.IsInteger(12.2));
         Console.WriteLine(Utility.IsInteger(2342353));
          Console.WriteLine(Utility.IsFloat(true));
          Console.WriteLine(Utility.IsFloat(12.2));
          Console.WriteLine(Utility.IsFloat(12));

          Console.WriteLine("{0} {1} {2}",12.1, Utility.Compare(12.1, 12), 12);
    }
}