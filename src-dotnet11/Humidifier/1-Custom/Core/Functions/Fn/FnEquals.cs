using System;

namespace Humidifier;

/// <summary>
/// Compares if two values are equal. Returns true if the two values are equal or false if they aren't.
/// 
/// Example: 
/// 
/// { "Fn::Equals" : ["value_1", "value_2"] }
/// 
/// </summary>
public class FnEquals : BaseFunction
{
    public object Value1 { get; }
    public object Value2 { get; }

    public FnEquals(object value1, object value2)
    {
        if (value1 == null)
        {
            throw new ArgumentNullException(nameof(value1));
        }

        if (value2 == null)
        {
            throw new ArgumentNullException(nameof(value2));
        }

        Value1 = value1;
        Value2 = value2;
    }
}