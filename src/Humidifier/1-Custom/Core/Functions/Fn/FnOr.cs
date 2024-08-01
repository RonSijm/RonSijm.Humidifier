using System;
using System.Collections.Generic;

namespace Humidifier;

/// <summary>
/// Returns true if any one of the specified conditions evaluate to true, or returns false if all of the conditions evaluates to false. Fn::Or acts as an OR operator. The minimum number of conditions that you can include is 2, and the maximum is 10.
/// 
/// Example: 
/// 
/// { "Fn::Or": [{condition}, {...}] }
/// 
/// </summary>
public class FnOr
{
    public List<dynamic> Conditions { get; }

    public FnOr(params dynamic[] conditions)
    {
        if (conditions == null)
        {
            throw new ArgumentNullException(nameof(conditions));
        }

        if (conditions.Length < 2 || conditions.Length > 10)
        {
            throw new ArgumentException("The minimum number of conditions that you can include is 2, and the maximum is 10.");
        }

        Conditions = new List<dynamic>(conditions);
    }
}