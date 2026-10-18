namespace Humidifier.Lightsail
{
    using global::System.Collections.Generic;
    using BucketTypes;

    public class Bucket : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveObjectVersioning_Boolean, IHaveStringListOfReadOnlyAccessAccounts, IHaveBundleId, IHaveBucketName, IHaveLightsailBucketTypesAccessRulesAccessRules, IHaveStringListOfResourcesReceivingAccess
    {
        public class Attributes
        {
            public static string BucketArn =  "BucketArn" ;
            public static string AbleToUpdateBundle =  "AbleToUpdateBundle" ;
            public static string Url =  "Url" ;
        }

        public override string AWSTypeName { get => AWS.Lightsail.Bucket; }
        /// <summary>
        /// ObjectVersioning
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lightsail-bucket.html#cfn-lightsail-bucket-objectversioning
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? ObjectVersioning { get; set; }
        /// <summary>
        /// ReadOnlyAccessAccounts
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lightsail-bucket.html#cfn-lightsail-bucket-readonlyaccessaccounts
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? ReadOnlyAccessAccounts { get; set; }

        /// <summary>
        /// BundleId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lightsail-bucket.html#cfn-lightsail-bucket-bundleid
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? BundleId { get; set; }
        public Union<string, BaseFunction>? BucketName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// AccessRules
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lightsail-bucket.html#cfn-lightsail-bucket-accessrules
        /// Required: False
        /// UpdateType: Mutable
        /// Type: AccessRules
        /// </summary>
        public Union<Humidifier.Lightsail.BucketTypes.AccessRules, BaseFunction>? AccessRules { get; set; }
        /// <summary>
        /// ResourcesReceivingAccess
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lightsail-bucket.html#cfn-lightsail-bucket-resourcesreceivingaccess
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? ResourcesReceivingAccess { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lightsail-bucket.html#cfn-lightsail-bucket-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace BucketTypes
    {
        public class AccessRules : Humidifier.Base.BaseSubResource, IHaveAllowPublicOverrides_Boolean, IHaveGetObject
        {
            /// <summary>
            /// AllowPublicOverrides
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lightsail-bucket-accessrules.html#cfn-lightsail-bucket-accessrules-allowpublicoverrides
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? AllowPublicOverrides { get; set; }
            /// <summary>
            /// GetObject
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lightsail-bucket-accessrules.html#cfn-lightsail-bucket-accessrules-getobject
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? GetObject { get; set; }
        }
    }
}