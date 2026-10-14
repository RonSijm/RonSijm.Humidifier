namespace Humidifier.SecurityHub
{
    using global::System.Collections.Generic;
    using HubV2Types;

    public class HubV2 : Humidifier.Base.BaseResource
    {
        public class Attributes
        {
            public static string HubV2Arn =  "HubV2Arn" ;
            public static string SubscribedAt =  "SubscribedAt" ;
        }

        public override string AWSTypeName { get => AWS.SecurityHub.HubV2; }
        /// <summary>
        /// NetworkScanning
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-securityhub-hubv2.html#cfn-securityhub-hubv2-networkscanning
        /// Required: False
        /// UpdateType: Mutable
        /// Type: NetworkScanning
        /// </summary>
        public Humidifier.SecurityHub.HubV2Types.NetworkScanning NetworkScanning { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-securityhub-hubv2.html#cfn-securityhub-hubv2-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Dictionary<string, dynamic> Tags { get; set; }
    }

    namespace HubV2Types
    {
        public class NetworkScanning : Humidifier.Base.BaseSubResource, IHaveStatus
        {
            /// <summary>
            /// Status
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-hubv2-networkscanning.html#cfn-securityhub-hubv2-networkscanning-status
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Status { get; set; }
        }
    }
}