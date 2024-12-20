﻿namespace Humidifier;

/// <summary>
/// AutoScalingRollingUpdate
/// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-attribute-updatepolicy.html#cfn-attributes-updatepolicy-rollingupdate
/// </summary>
public class AutoScalingRollingUpdate
{
    /// <summary>
    /// PrimitiveType: Integer
    /// </summary>
    public dynamic MaxBatchSize { get; set; }

    /// <summary>
    /// PrimitiveType: Integer
    /// </summary>
    public dynamic MinInstancesInService { get; set; }

    /// <summary>
    /// PrimitiveType: Integer
    /// </summary>
    public dynamic MinSuccessfulInstancesPercent { get; set; }

    /// <summary>
    /// PrimitiveType: String
    /// </summary>
    public dynamic PauseTime { get; set; }

    /// <summary>
    /// Type: List
    /// PrimitiveItemType: String
    /// </summary>
    public dynamic SuspendProcesses { get; set; }

    /// <summary>
    /// PrimitiveType: Boolean
    /// </summary>
    public dynamic WaitOnResourceSignals { get; set; }
}