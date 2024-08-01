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
public class FnEquals
{
    public dynamic Value1 { get; }
    public dynamic Value2 { get; }

    public FnEquals(dynamic value1, dynamic value2)
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