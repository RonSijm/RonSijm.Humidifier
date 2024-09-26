using System;

namespace Humidifier;

/// <summary>
/// To split a string into a list of string values so that you can select an element from the resulting string list, use the Fn::Split intrinsic function. 
/// Specify the location of splits with a delimiter, such as , (a comma). After you split a string, use the Fn::Select function to pick a specific element.
/// 
/// Example: The following example splits a string at each vertical bar (|). The function returns ["a", "b", "c"].
/// 
/// { "Fn::Split" : [ "|" , "a|b|c" ] }
/// 
/// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/intrinsic-function-reference-split.html  
/// </summary>
public class FnSplit
{
    public string Delimiter { get; }
    public dynamic SourceString { get; }

    public FnSplit(string delimiter, dynamic sourceString)
    {
        Delimiter = delimiter ?? throw new ArgumentNullException(nameof(delimiter));
        SourceString = sourceString ?? throw new ArgumentNullException(nameof(sourceString));
    }
}