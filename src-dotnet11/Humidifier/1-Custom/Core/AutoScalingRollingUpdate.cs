using System.Collections.Generic;

namespace Humidifier;

/// <summary>
/// AutoScalingRollingUpdate
/// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-attribute-updatepolicy.html#cfn-attributes-updatepolicy-rollingupdate
/// </summary>
public class AutoScalingRollingUpdate
{
    /// <summary>
    /// PrimitiveType: Integer
    /// </summary>
    public Union<int, BaseFunction>? MaxBatchSize { get; set; }

    /// <summary>
    /// PrimitiveType: Integer
    /// </summary>
    public Union<int, BaseFunction>? MinInstancesInService { get; set; }

    /// <summary>
    /// PrimitiveType: Integer
    /// </summary>
    public Union<int, BaseFunction>? MinSuccessfulInstancesPercent { get; set; }

    /// <summary>
    /// PrimitiveType: String
    /// </summary>
    public Union<string, BaseFunction>? PauseTime { get; set; }

    /// <summary>
    /// Type: List
    /// PrimitiveItemType: String
    /// </summary>
    public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SuspendProcesses { get; set; }

    /// <summary>
    /// PrimitiveType: Boolean
    /// </summary>
    public Union<bool, BaseFunction>? WaitOnResourceSignals { get; set; }
}