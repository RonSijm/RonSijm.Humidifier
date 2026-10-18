namespace Humidifier.Forecast
{
    using global::System.Collections.Generic;
    using DatasetTypes;

    public class Dataset : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveDataFrequency, IHaveDatasetName, IHaveForecastDatasetTypesSchemaSchema, IHaveDatasetType, IHaveDomain, IHaveForecastDatasetTypesEncryptionConfigEncryptionConfig, IHaveListOfForecastDatasetTypesTagsItemsTags
    {
        public class Attributes
        {
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.Forecast.Dataset; }
        /// <summary>
        /// DataFrequency
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-forecast-dataset.html#cfn-forecast-dataset-datafrequency
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? DataFrequency { get; set; }
        public Union<string, BaseFunction>? DatasetName { get => GivenName; set => GivenName = value; }

        /// <summary>
        /// Schema
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-forecast-dataset.html#cfn-forecast-dataset-schema
        /// Required: True
        /// UpdateType: Mutable
        /// Type: Schema
        /// </summary>
        [Required]
        public Union<Humidifier.Forecast.DatasetTypes.Schema, BaseFunction>? Schema { get; set; }

        /// <summary>
        /// DatasetType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-forecast-dataset.html#cfn-forecast-dataset-datasettype
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? DatasetType { get; set; }

        /// <summary>
        /// Domain
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-forecast-dataset.html#cfn-forecast-dataset-domain
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Domain { get; set; }
        /// <summary>
        /// EncryptionConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-forecast-dataset.html#cfn-forecast-dataset-encryptionconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: EncryptionConfig
        /// </summary>
        public Union<Humidifier.Forecast.DatasetTypes.EncryptionConfig, BaseFunction>? EncryptionConfig { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-forecast-dataset.html#cfn-forecast-dataset-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: TagsItems
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Forecast.DatasetTypes.TagsItems>, IReadOnlyList<Union<Humidifier.Forecast.DatasetTypes.TagsItems, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace DatasetTypes
    {
        public class AttributesItems : Humidifier.Base.BaseSubResource, IHaveAttributeType, IHaveAttributeName
        {
            /// <summary>
            /// AttributeType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-forecast-dataset-attributesitems.html#cfn-forecast-dataset-attributesitems-attributetype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AttributeType { get; set; }
            /// <summary>
            /// AttributeName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-forecast-dataset-attributesitems.html#cfn-forecast-dataset-attributesitems-attributename
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AttributeName { get; set; }
        }

        public class EncryptionConfig : Humidifier.Base.BaseSubResource, IHaveKmsKeyArn, IHaveRoleArn
        {
            /// <summary>
            /// KmsKeyArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-forecast-dataset-encryptionconfig.html#cfn-forecast-dataset-encryptionconfig-kmskeyarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? KmsKeyArn { get; set; }
            /// <summary>
            /// RoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-forecast-dataset-encryptionconfig.html#cfn-forecast-dataset-encryptionconfig-rolearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RoleArn { get; set; }
        }

        public class Schema : Humidifier.Base.BaseSubResource, IHaveListOfForecastDatasetTypesAttributesItemsAttributes_
        {
            /// <summary>
            /// Attributes_
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-forecast-dataset-schema.html#cfn-forecast-dataset-schema-attributes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: AttributesItems
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Forecast.DatasetTypes.AttributesItems>, IReadOnlyList<Union<Humidifier.Forecast.DatasetTypes.AttributesItems, BaseFunction>>, BaseFunction>? Attributes_ { get; set; }
        }

        public class TagsItems : Humidifier.Base.BaseSubResource, IHaveValue, IHaveKey
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-forecast-dataset-tagsitems.html#cfn-forecast-dataset-tagsitems-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-forecast-dataset-tagsitems.html#cfn-forecast-dataset-tagsitems-key
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Key { get; set; }
        }
    }
}