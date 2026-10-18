namespace Humidifier.RDS
{
    using global::System.Collections.Generic;

    public class Integration : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveDataFilter, IHaveIntegrationName, IHaveDescription, IHaveKMSKeyId, IHaveSourceArn, IHaveTargetArn, IHaveStringDictionaryOfAdditionalEncryptionContext
    {
        public class Attributes
        {
            public static string IntegrationArn =  "IntegrationArn" ;
            public static string CreateTime =  "CreateTime" ;
        }

        public override string AWSTypeName { get => AWS.RDS.Integration; }
        /// <summary>
        /// DataFilter
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rds-integration.html#cfn-rds-integration-datafilter
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? DataFilter { get; set; }
        public Union<string, BaseFunction>? IntegrationName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rds-integration.html#cfn-rds-integration-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// KMSKeyId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rds-integration.html#cfn-rds-integration-kmskeyid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? KMSKeyId { get; set; }

        /// <summary>
        /// SourceArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rds-integration.html#cfn-rds-integration-sourcearn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? SourceArn { get; set; }

        /// <summary>
        /// TargetArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rds-integration.html#cfn-rds-integration-targetarn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? TargetArn { get; set; }
        /// <summary>
        /// AdditionalEncryptionContext
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rds-integration.html#cfn-rds-integration-additionalencryptioncontext
        /// Required: False
        /// UpdateType: Immutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? AdditionalEncryptionContext { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rds-integration.html#cfn-rds-integration-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }
}