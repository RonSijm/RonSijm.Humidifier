namespace Humidifier.Interconnect
{
    using global::System.Collections.Generic;
    using ConnectionTypes;

    public class Connection : Humidifier.Base.BaseResource, IHaveTags, IHaveDescription, IHaveEnvironmentId
    {
        public class Attributes
        {
            public static string ConnectionId =  "ConnectionId" ;
            public static string Type =  "Type" ;
            public static string BillingTier =  "BillingTier" ;
            public static string SharedId =  "SharedId" ;
            public static string State =  "State" ;
            public static string OwnerAccount =  "OwnerAccount" ;
            public static string Arn =  "Arn" ;
            public static string Provider =  "Provider" ;
        }

        public override string AWSTypeName { get => AWS.Interconnect.Connection; }

        /// <summary>
        /// AttachPoint
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-interconnect-connection.html#cfn-interconnect-connection-attachpoint
        /// Required: True
        /// UpdateType: Immutable
        /// Type: AttachPoint
        /// </summary>
        [Required]
        public Humidifier.Interconnect.ConnectionTypes.AttachPoint AttachPoint { get; set; }
        /// <summary>
        /// EnvironmentId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-interconnect-connection.html#cfn-interconnect-connection-environmentid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic EnvironmentId { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-interconnect-connection.html#cfn-interconnect-connection-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Description { get; set; }
        /// <summary>
        /// Bandwidth
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-interconnect-connection.html#cfn-interconnect-connection-bandwidth
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Bandwidth { get; set; }
        /// <summary>
        /// RemoteAccount
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-interconnect-connection.html#cfn-interconnect-connection-remoteaccount
        /// Required: False
        /// UpdateType: Immutable
        /// Type: RemoteAccount
        /// </summary>
        public Humidifier.Interconnect.ConnectionTypes.RemoteAccount RemoteAccount { get; set; }
        /// <summary>
        /// ActivationKey
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-interconnect-connection.html#cfn-interconnect-connection-activationkey
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ActivationKey { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-interconnect-connection.html#cfn-interconnect-connection-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
    }

    namespace ConnectionTypes
    {
        public class AttachPoint : Humidifier.Base.BaseSubResource, IHaveArn
        {
            /// <summary>
            /// DirectConnectGateway
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-interconnect-connection-attachpoint.html#cfn-interconnect-connection-attachpoint-directconnectgateway
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DirectConnectGateway { get; set; }
            /// <summary>
            /// Arn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-interconnect-connection-attachpoint.html#cfn-interconnect-connection-attachpoint-arn
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Arn { get; set; }
        }

        public class Provider : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// CloudServiceProvider
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-interconnect-connection-provider.html#cfn-interconnect-connection-provider-cloudserviceprovider
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CloudServiceProvider { get; set; }
            /// <summary>
            /// LastMileProvider
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-interconnect-connection-provider.html#cfn-interconnect-connection-provider-lastmileprovider
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LastMileProvider { get; set; }
        }

        public class RemoteAccount : Humidifier.Base.BaseSubResource, IHaveIdentifier
        {
            /// <summary>
            /// Identifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-interconnect-connection-remoteaccount.html#cfn-interconnect-connection-remoteaccount-identifier
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Identifier { get; set; }
        }
    }
}