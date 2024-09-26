using System;

namespace Humidifier;

/// <summary>
/// Returns one value if the specified condition evaluates to true and another value if the specified condition evaluates to false. 
/// Currently, AWS CloudFormation supports the Fn::If intrinsic function in the metadata attribute, update policy attribute, and property 
/// values in the Resources section and Outputs sections of a template. 
/// 
/// You can use the AWS::NoValue pseudo parameter as a return value to remove the corresponding property.
/// 
/// Example:
/// 
/// "Fn::If": [condition_name, value_if_true, value_if_false]
/// 
/// "Fn::If" : [
///    "UseDBSnapshot",
///      {"Ref" : "DBSnapshotName"},
///       {"Ref" : "AWS::NoValue"}
///  ]
/// </summary>
public class FnIf : BaseFunction
{
    public string ConditionName { get; }
    public dynamic ValueIfTrue { get; }
    public dynamic ValueIfFalse { get; }

    public FnIf(string conditionName, dynamic valueIfTrue, dynamic valueIfFalse)
    {
        ConditionName = conditionName ?? throw new ArgumentNullException(nameof(conditionName));

        if (valueIfTrue == null) throw new ArgumentNullException(nameof(valueIfTrue));
        if (valueIfFalse == null) throw new ArgumentNullException(nameof(valueIfFalse));

        ValueIfTrue = valueIfTrue;
        ValueIfFalse = valueIfFalse;
    }
}