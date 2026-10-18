namespace Humidifier.Glue
{
    using global::System.Collections.Generic;
    using IntegrationTypes;

    public class Integration : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveDataFilter, IHaveIntegrationName, IHaveDescription, IHaveSourceArn, IHaveGlueIntegrationTypesIntegrationConfigIntegrationConfig, IHaveKmsKeyId, IHaveTargetArn, IHaveStringDictionaryOfAdditionalEncryptionContext
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string IntegrationArn =  "IntegrationArn" ;
            public static string CreateTime =  "CreateTime" ;
        }

        public override string AWSTypeName { get => AWS.Glue.Integration; }
        /// <summary>
        /// DataFilter
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-integration.html#cfn-glue-integration-datafilter
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? DataFilter { get; set; }
        public Union<string, BaseFunction>? IntegrationName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-integration.html#cfn-glue-integration-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }

        /// <summary>
        /// SourceArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-integration.html#cfn-glue-integration-sourcearn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? SourceArn { get; set; }
        /// <summary>
        /// IntegrationConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-integration.html#cfn-glue-integration-integrationconfig
        /// Required: False
        /// UpdateType: Immutable
        /// Type: IntegrationConfig
        /// </summary>
        public Union<Humidifier.Glue.IntegrationTypes.IntegrationConfig, BaseFunction>? IntegrationConfig { get; set; }
        /// <summary>
        /// KmsKeyId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-integration.html#cfn-glue-integration-kmskeyid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? KmsKeyId { get; set; }

        /// <summary>
        /// TargetArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-integration.html#cfn-glue-integration-targetarn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? TargetArn { get; set; }
        /// <summary>
        /// AdditionalEncryptionContext
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-integration.html#cfn-glue-integration-additionalencryptioncontext
        /// Required: False
        /// UpdateType: Immutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? AdditionalEncryptionContext { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-integration.html#cfn-glue-integration-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace IntegrationTypes
    {
        public class IntegrationConfig : Humidifier.Base.BaseSubResource, IHaveContinuousSync_Boolean, IHaveRefreshInterval, IHaveStringDictionaryOfSourceProperties
        {
            /// <summary>
            /// ContinuousSync
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-integration-integrationconfig.html#cfn-glue-integration-integrationconfig-continuoussync
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? ContinuousSync { get; set; }
            /// <summary>
            /// RefreshInterval
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-integration-integrationconfig.html#cfn-glue-integration-integrationconfig-refreshinterval
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RefreshInterval { get; set; }
            /// <summary>
            /// SourceProperties
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-integration-integrationconfig.html#cfn-glue-integration-integrationconfig-sourceproperties
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? SourceProperties { get; set; }
        }
    }
}