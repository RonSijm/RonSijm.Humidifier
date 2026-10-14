namespace Humidifier.DirectConnect
{
    using global::System.Collections.Generic;

    public class Lag : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveLocation, IHaveProviderName
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
        public dynamic ProviderName { get; set; }
        /// <summary>
        /// RequestMACSec
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-directconnect-lag.html#cfn-directconnect-lag-requestmacsec
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Boolean
        /// </summary>
        public dynamic RequestMACSec { get; set; }

        /// <summary>
        /// ConnectionsBandwidth
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-directconnect-lag.html#cfn-directconnect-lag-connectionsbandwidth
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic ConnectionsBandwidth { get; set; }
        public dynamic LagName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// MinimumLinks
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-directconnect-lag.html#cfn-directconnect-lag-minimumlinks
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public dynamic MinimumLinks { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-directconnect-lag.html#cfn-directconnect-lag-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }

        /// <summary>
        /// Location
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-directconnect-lag.html#cfn-directconnect-lag-location
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic Location { get; set; }
    }
}