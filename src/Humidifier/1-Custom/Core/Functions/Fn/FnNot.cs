using System;

namespace Humidifier;

/// <summary>
/// Returns true for a condition that evaluates to false or returns false for a condition that evaluates to true. Fn::Not acts as a NOT operator.
/// 
/// A condition such as Fn::Equals that evaluates to true or false.
/// 
/// Example:
/// 
/// { "Fn::Not": [{condition}] }
/// 
/// </summary>
public class FnNot
{
    public dynamic Condition { get; }

    public FnNot(dynamic condition)
    {
        if (condition == null)
        {
            throw new ArgumentNullException(nameof(condition));
        }

        Condition = condition;
    }
}