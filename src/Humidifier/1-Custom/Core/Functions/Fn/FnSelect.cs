using System;

namespace Humidifier;

/// <summary>
/// The intrinsic function Fn::Select returns a single object from a list of objects by index.
/// 
/// Example: The following example returns: "grapes".
/// 
/// { "Fn::Select" : [ "1", [ "apples", "grapes", "oranges", "mangoes" ] ] }
/// 
/// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/intrinsic-function-reference-select.html
/// </summary>
public class FnSelect : BaseFunction
{
    public string Index { get; }
    public dynamic ListOfObjects { get; }

    public FnSelect(string index, dynamic listOfObjects)
    {
        Index = index ?? throw new ArgumentNullException(nameof(index));
        ListOfObjects = listOfObjects ?? throw new ArgumentNullException(nameof(listOfObjects));
    }
}