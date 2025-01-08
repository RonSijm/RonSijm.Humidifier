namespace Humidifier.PCS
{
    using System.Collections.Generic;
    using QueueTypes;

    public class Queue : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveClusterId
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string ErrorInfo =  "ErrorInfo" ;
            public static string Id =  "Id" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.PCS.Queue; }

        /// <summary>
        /// ClusterId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pcs-queue.html#cfn-pcs-queue-clusterid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic ClusterId { get; set; }
        /// <summary>
        /// ComputeNodeGroupConfigurations
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pcs-queue.html#cfn-pcs-queue-computenodegroupconfigurations
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: ComputeNodeGroupConfiguration
        /// </summary>
        public List<Humidifier.PCS.QueueTypes.ComputeNodeGroupConfiguration> ComputeNodeGroupConfigurations { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pcs-queue.html#cfn-pcs-queue-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Dictionary<string, dynamic> Tags { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
    }

    namespace QueueTypes
    {
        public class ComputeNodeGroupConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ComputeNodeGroupId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcs-queue-computenodegroupconfiguration.html#cfn-pcs-queue-computenodegroupconfiguration-computenodegroupid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ComputeNodeGroupId { get; set; }
        }

        public class ErrorInfo : Humidifier.Base.BaseSubResource, IHaveMessage, IHaveCode
        {
            /// <summary>
            /// Message
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcs-queue-errorinfo.html#cfn-pcs-queue-errorinfo-message
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Message { get; set; }
            /// <summary>
            /// Code
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcs-queue-errorinfo.html#cfn-pcs-queue-errorinfo-code
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Code { get; set; }
        }
    }
}