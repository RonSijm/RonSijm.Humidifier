namespace Humidifier.ServiceDiscovery
{
    using global::System.Collections.Generic;

    public class Instance : Humidifier.Base.BaseResource, IHaveInstanceAttributes_Json, IHaveInstanceId, IHaveServiceId
    {
        public override string AWSTypeName { get => AWS.ServiceDiscovery.Instance; }

        /// <summary>
        /// InstanceAttributes
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-servicediscovery-instance.html#cfn-servicediscovery-instance-instanceattributes
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: Json
        /// </summary>
        [Required]
        public Union<object, BaseFunction>? InstanceAttributes { get; set; }
        /// <summary>
        /// InstanceId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-servicediscovery-instance.html#cfn-servicediscovery-instance-instanceid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? InstanceId { get; set; }

        /// <summary>
        /// ServiceId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-servicediscovery-instance.html#cfn-servicediscovery-instance-serviceid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ServiceId { get; set; }
    }
}