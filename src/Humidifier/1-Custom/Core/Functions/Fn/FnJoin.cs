using System;

namespace Humidifier;

/// <summary>
/// 
/// TODO: Example
/// 
/// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/intrinsic-function-reference-join.html
/// </summary>
public class FnJoin : BaseFunction
{
    public string Seperator { get; }
    public dynamic[] Parameters { get; }

    public FnJoin(string seperator, dynamic[] parameters)
    {
        Seperator = seperator ?? throw new ArgumentNullException(nameof(seperator));
        Parameters = parameters ?? throw new ArgumentNullException(nameof(parameters));
    }
}