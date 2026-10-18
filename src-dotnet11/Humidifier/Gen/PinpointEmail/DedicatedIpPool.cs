namespace Humidifier.PinpointEmail
{
    using global::System.Collections.Generic;
    using DedicatedIpPoolTypes;

    public class DedicatedIpPool : Humidifier.Base.BaseResource, IHavePoolName, IHaveListOfPinpointEmailDedicatedIpPoolTypesTagsTags
    {
        public override string AWSTypeName { get => AWS.PinpointEmail.DedicatedIpPool; }
        /// <summary>
        /// PoolName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pinpointemail-dedicatedippool.html#cfn-pinpointemail-dedicatedippool-poolname
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? PoolName { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pinpointemail-dedicatedippool.html#cfn-pinpointemail-dedicatedippool-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tags
        /// </summary>
        public Union<IReadOnlyList<Humidifier.PinpointEmail.DedicatedIpPoolTypes.Tags>, IReadOnlyList<Union<Humidifier.PinpointEmail.DedicatedIpPoolTypes.Tags, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace DedicatedIpPoolTypes
    {
        public class Tags : Humidifier.Base.BaseSubResource, IHaveValue, IHaveKey
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpointemail-dedicatedippool-tags.html#cfn-pinpointemail-dedicatedippool-tags-value
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpointemail-dedicatedippool-tags.html#cfn-pinpointemail-dedicatedippool-tags-key
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Key { get; set; }
        }
    }
}