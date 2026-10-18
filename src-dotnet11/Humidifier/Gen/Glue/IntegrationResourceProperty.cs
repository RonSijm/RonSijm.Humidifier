namespace Humidifier.Glue
{
    using global::System.Collections.Generic;
    using IntegrationResourcePropertyTypes;

    public class IntegrationResourceProperty : Humidifier.Base.BaseResource, IHaveTags, IHaveResourceArn, IHaveGlueIntegrationResourcePropertyTypesTargetProcessingPropertiesTargetProcessingProperties, IHaveGlueIntegrationResourcePropertyTypesSourceProcessingPropertiesSourceProcessingProperties
    {
        public class Attributes
        {
            public static string ResourcePropertyArn =  "ResourcePropertyArn" ;
        }

        public override string AWSTypeName { get => AWS.Glue.IntegrationResourceProperty; }

        /// <summary>
        /// ResourceArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-integrationresourceproperty.html#cfn-glue-integrationresourceproperty-resourcearn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ResourceArn { get; set; }
        /// <summary>
        /// TargetProcessingProperties
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-integrationresourceproperty.html#cfn-glue-integrationresourceproperty-targetprocessingproperties
        /// Required: False
        /// UpdateType: Mutable
        /// Type: TargetProcessingProperties
        /// </summary>
        public Union<Humidifier.Glue.IntegrationResourcePropertyTypes.TargetProcessingProperties, BaseFunction>? TargetProcessingProperties { get; set; }
        /// <summary>
        /// SourceProcessingProperties
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-integrationresourceproperty.html#cfn-glue-integrationresourceproperty-sourceprocessingproperties
        /// Required: False
        /// UpdateType: Mutable
        /// Type: SourceProcessingProperties
        /// </summary>
        public Union<Humidifier.Glue.IntegrationResourcePropertyTypes.SourceProcessingProperties, BaseFunction>? SourceProcessingProperties { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-integrationresourceproperty.html#cfn-glue-integrationresourceproperty-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace IntegrationResourcePropertyTypes
    {
        public class SourceProcessingProperties : Humidifier.Base.BaseSubResource, IHaveRoleArn
        {
            /// <summary>
            /// RoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-integrationresourceproperty-sourceprocessingproperties.html#cfn-glue-integrationresourceproperty-sourceprocessingproperties-rolearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RoleArn { get; set; }
        }

        public class TargetProcessingProperties : Humidifier.Base.BaseSubResource, IHaveConnectionName, IHaveKmsArn, IHaveRoleArn, IHaveEventBusArn
        {
            /// <summary>
            /// ConnectionName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-integrationresourceproperty-targetprocessingproperties.html#cfn-glue-integrationresourceproperty-targetprocessingproperties-connectionname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ConnectionName { get; set; }
            /// <summary>
            /// KmsArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-integrationresourceproperty-targetprocessingproperties.html#cfn-glue-integrationresourceproperty-targetprocessingproperties-kmsarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? KmsArn { get; set; }
            /// <summary>
            /// RoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-integrationresourceproperty-targetprocessingproperties.html#cfn-glue-integrationresourceproperty-targetprocessingproperties-rolearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RoleArn { get; set; }
            /// <summary>
            /// EventBusArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-integrationresourceproperty-targetprocessingproperties.html#cfn-glue-integrationresourceproperty-targetprocessingproperties-eventbusarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EventBusArn { get; set; }
        }
    }
}