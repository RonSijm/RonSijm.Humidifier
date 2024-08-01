using System;
using System.Collections.Generic;

namespace Humidifier;

/// <summary>
/// The intrinsic function Fn::Sub substitutes variables in an input string with values that you specify. 
/// In your templates, you can use this function to construct commands or outputs that include values that aren't 
/// available until you create or update a stack.
/// 
/// TODO: Example
/// 
/// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/intrinsic-function-reference-sub.html
/// </summary>
public class FnSub : BaseFunction
{
    public string String { get; }
    public Dictionary<string, dynamic> Variables { get; }

    public FnSub(string input, Dictionary<string, dynamic> variables = null)
    {
        String = input ?? throw new ArgumentNullException(nameof(input));
        Variables = variables;
    }
}