namespace Humidifier.S3Outposts
{
    using System.Collections.Generic;
    using EndpointTypes;

    public class Endpoint : Humidifier.Base.BaseResource, IHaveSubnetId, IHaveAccessType, IHaveOutpostId, IHaveSecurityGroupId
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string NetworkInterfaces =  "NetworkInterfaces" ;
            public static string CreationTime =  "CreationTime" ;
            public static string CidrBlock =  "CidrBlock" ;
            public static string Id =  "Id" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.S3Outposts.Endpoint; }

        /// <summary>
        /// OutpostId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-s3outposts-endpoint.html#cfn-s3outposts-endpoint-outpostid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic OutpostId { get; set; }

        /// <summary>
        /// SecurityGroupId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-s3outposts-endpoint.html#cfn-s3outposts-endpoint-securitygroupid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic SecurityGroupId { get; set; }
        /// <summary>
        /// FailedReason
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-s3outposts-endpoint.html#cfn-s3outposts-endpoint-failedreason
        /// Required: False
        /// UpdateType: Mutable
        /// Type: FailedReason
        /// </summary>
        public Humidifier.S3Outposts.EndpointTypes.FailedReason FailedReason { get; set; }

        /// <summary>
        /// SubnetId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-s3outposts-endpoint.html#cfn-s3outposts-endpoint-subnetid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic SubnetId { get; set; }
        /// <summary>
        /// AccessType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-s3outposts-endpoint.html#cfn-s3outposts-endpoint-accesstype
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic AccessType { get; set; }
        /// <summary>
        /// CustomerOwnedIpv4Pool
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-s3outposts-endpoint.html#cfn-s3outposts-endpoint-customerownedipv4pool
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic CustomerOwnedIpv4Pool { get; set; }
    }

    namespace EndpointTypes
    {
        public class FailedReason : Humidifier.Base.BaseSubResource, IHaveMessage, IHaveErrorCode
        {
            /// <summary>
            /// Message
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3outposts-endpoint-failedreason.html#cfn-s3outposts-endpoint-failedreason-message
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Message { get; set; }
            /// <summary>
            /// ErrorCode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3outposts-endpoint-failedreason.html#cfn-s3outposts-endpoint-failedreason-errorcode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ErrorCode { get; set; }
        }

        public class NetworkInterface : Humidifier.Base.BaseSubResource, IHaveNetworkInterfaceId
        {
            /// <summary>
            /// NetworkInterfaceId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3outposts-endpoint-networkinterface.html#cfn-s3outposts-endpoint-networkinterface-networkinterfaceid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic NetworkInterfaceId { get; set; }
        }
    }
}