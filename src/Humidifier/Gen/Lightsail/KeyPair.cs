namespace Humidifier.Lightsail
{
    using global::System.Collections.Generic;
    using KeyPairTypes;

    public class KeyPair : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags
    {
        public class Attributes
        {
            public static string Fingerprint =  "Fingerprint" ;
            public static string KeyPairArn =  "KeyPairArn" ;
            public static string SupportCode =  "SupportCode" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string ResourceType =  "ResourceType" ;
            public static string Location =  "Location" ;
        }

        public override string AWSTypeName { get => AWS.Lightsail.KeyPair; }
        public dynamic KeyPairName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lightsail-keypair.html#cfn-lightsail-keypair-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
    }

    namespace KeyPairTypes
    {
        public class ResourceLocation : Humidifier.Base.BaseSubResource, IHaveAvailabilityZone, IHaveRegionName
        {
            /// <summary>
            /// RegionName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lightsail-keypair-resourcelocation.html#cfn-lightsail-keypair-resourcelocation-regionname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RegionName { get; set; }
            /// <summary>
            /// AvailabilityZone
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lightsail-keypair-resourcelocation.html#cfn-lightsail-keypair-resourcelocation-availabilityzone
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AvailabilityZone { get; set; }
        }
    }
}