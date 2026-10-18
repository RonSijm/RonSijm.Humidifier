namespace Humidifier.Redshift
{
    using global::System.Collections.Generic;

    public class Integration : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveIntegrationName, IHaveKMSKeyId, IHaveSourceArn, IHaveTargetArn, IHaveStringDictionaryOfAdditionalEncryptionContext
    {
        public class Attributes
        {
            public static string IntegrationArn =  "IntegrationArn" ;
            public static string CreateTime =  "CreateTime" ;
        }

        public override string AWSTypeName { get => AWS.Redshift.Integration; }
        public Union<string, BaseFunction>? IntegrationName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// KMSKeyId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-redshift-integration.html#cfn-redshift-integration-kmskeyid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? KMSKeyId { get; set; }

        /// <summary>
        /// SourceArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-redshift-integration.html#cfn-redshift-integration-sourcearn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? SourceArn { get; set; }

        /// <summary>
        /// TargetArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-redshift-integration.html#cfn-redshift-integration-targetarn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? TargetArn { get; set; }
        /// <summary>
        /// AdditionalEncryptionContext
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-redshift-integration.html#cfn-redshift-integration-additionalencryptioncontext
        /// Required: False
        /// UpdateType: Immutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? AdditionalEncryptionContext { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-redshift-integration.html#cfn-redshift-integration-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }
}