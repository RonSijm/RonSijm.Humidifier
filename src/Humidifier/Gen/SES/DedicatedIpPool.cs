namespace Humidifier.SES
{
    using System.Collections.Generic;

    public class DedicatedIpPool : Humidifier.Base.BaseResource, IHavePoolName
    {
        public override string AWSTypeName { get => AWS.SES.DedicatedIpPool; }
        /// <summary>
        /// PoolName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ses-dedicatedippool.html#cfn-ses-dedicatedippool-poolname
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic PoolName { get; set; }
        /// <summary>
        /// ScalingMode
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ses-dedicatedippool.html#cfn-ses-dedicatedippool-scalingmode
        /// Required: False
        /// UpdateType: Conditional
        /// PrimitiveType: String
        /// </summary>
        public dynamic ScalingMode { get; set; }
    }
}