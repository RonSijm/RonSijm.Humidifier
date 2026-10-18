namespace Humidifier.DirectConnect
{
    using global::System.Collections.Generic;

    public class Connection : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveConnectionName, IHaveLagId, IHaveProviderName, IHaveRequestMACSec_Boolean, IHaveBandwidth, IHaveLocation
    {
        public class Attributes
        {
            public static string ConnectionId =  "ConnectionId" ;
            public static string ConnectionArn =  "ConnectionArn" ;
            public static string ConnectionState =  "ConnectionState" ;
        }

        public override string AWSTypeName { get => AWS.DirectConnect.Connection; }
        public Union<string, BaseFunction>? ConnectionName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// LagId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-directconnect-connection.html#cfn-directconnect-connection-lagid
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? LagId { get; set; }
        /// <summary>
        /// ProviderName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-directconnect-connection.html#cfn-directconnect-connection-providername
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ProviderName { get; set; }
        /// <summary>
        /// RequestMACSec
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-directconnect-connection.html#cfn-directconnect-connection-requestmacsec
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? RequestMACSec { get; set; }

        /// <summary>
        /// Bandwidth
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-directconnect-connection.html#cfn-directconnect-connection-bandwidth
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Bandwidth { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-directconnect-connection.html#cfn-directconnect-connection-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }

        /// <summary>
        /// Location
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-directconnect-connection.html#cfn-directconnect-connection-location
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Location { get; set; }
    }
}