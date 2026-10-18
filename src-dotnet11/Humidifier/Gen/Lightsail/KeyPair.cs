namespace Humidifier.Lightsail
{
    using global::System.Collections.Generic;
    using KeyPairTypes;

    public class KeyPair : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveKeyPairName
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
        public Union<string, BaseFunction>? KeyPairName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lightsail-keypair.html#cfn-lightsail-keypair-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace KeyPairTypes
    {
        public class ResourceLocation : Humidifier.Base.BaseSubResource, IHaveRegionName, IHaveAvailabilityZone
        {
            /// <summary>
            /// RegionName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lightsail-keypair-resourcelocation.html#cfn-lightsail-keypair-resourcelocation-regionname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RegionName { get; set; }
            /// <summary>
            /// AvailabilityZone
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lightsail-keypair-resourcelocation.html#cfn-lightsail-keypair-resourcelocation-availabilityzone
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AvailabilityZone { get; set; }
        }
    }
}