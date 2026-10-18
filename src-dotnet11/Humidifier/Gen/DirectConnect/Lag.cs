namespace Humidifier.DirectConnect
{
    using global::System.Collections.Generic;

    public class Lag : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveProviderName, IHaveRequestMACSec_Boolean, IHaveConnectionsBandwidth, IHaveLagName, IHaveMinimumLinks_Integer, IHaveLocation
    {
        public class Attributes
        {
            public static string LagId =  "LagId" ;
            public static string LagArn =  "LagArn" ;
            public static string LagState =  "LagState" ;
        }

        public override string AWSTypeName { get => AWS.DirectConnect.Lag; }
        /// <summary>
        /// ProviderName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-directconnect-lag.html#cfn-directconnect-lag-providername
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ProviderName { get; set; }
        /// <summary>
        /// RequestMACSec
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-directconnect-lag.html#cfn-directconnect-lag-requestmacsec
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? RequestMACSec { get; set; }

        /// <summary>
        /// ConnectionsBandwidth
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-directconnect-lag.html#cfn-directconnect-lag-connectionsbandwidth
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ConnectionsBandwidth { get; set; }
        public Union<string, BaseFunction>? LagName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// MinimumLinks
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-directconnect-lag.html#cfn-directconnect-lag-minimumlinks
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? MinimumLinks { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-directconnect-lag.html#cfn-directconnect-lag-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }

        /// <summary>
        /// Location
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-directconnect-lag.html#cfn-directconnect-lag-location
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Location { get; set; }
    }
}