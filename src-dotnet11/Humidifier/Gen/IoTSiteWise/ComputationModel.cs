namespace Humidifier.IoTSiteWise
{
    using global::System.Collections.Generic;
    using ComputationModelTypes;

    public class ComputationModel : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveIoTSiteWiseComputationModelTypesComputationModelConfigurationComputationModelConfiguration, IHaveComputationModelDescription, IHaveComputationModelName, IHaveMapOfIoTSiteWiseComputationModelTypesComputationModelDataBindingValueComputationModelDataBinding, IHaveDescription
    {
        public class Attributes
        {
            public static string ComputationModelArn =  "ComputationModelArn" ;
            public static string ComputationModelId =  "ComputationModelId" ;
        }

        public override string AWSTypeName { get => AWS.IoTSiteWise.ComputationModel; }

        /// <summary>
        /// ComputationModelConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotsitewise-computationmodel.html#cfn-iotsitewise-computationmodel-computationmodelconfiguration
        /// Required: True
        /// UpdateType: Mutable
        /// Type: ComputationModelConfiguration
        /// </summary>
        [Required]
        public Union<Humidifier.IoTSiteWise.ComputationModelTypes.ComputationModelConfiguration, BaseFunction>? ComputationModelConfiguration { get; set; }
        /// <summary>
        /// ComputationModelDescription
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotsitewise-computationmodel.html#cfn-iotsitewise-computationmodel-computationmodeldescription
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ComputationModelDescription { get; set; }

        [Ignore]
        public Union<string, BaseFunction>? Description { get => ComputationModelDescription; set => ComputationModelDescription = value; }
        public Union<string, BaseFunction>? ComputationModelName { get => GivenName; set => GivenName = value; }

        /// <summary>
        /// ComputationModelDataBinding
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotsitewise-computationmodel.html#cfn-iotsitewise-computationmodel-computationmodeldatabinding
        /// Required: True
        /// UpdateType: Mutable
        /// Type: Map
        /// ItemType: ComputationModelDataBindingValue
        /// </summary>
        [Required]
        public Union<IReadOnlyDictionary<string, Humidifier.IoTSiteWise.ComputationModelTypes.ComputationModelDataBindingValue>, IReadOnlyDictionary<string, Union<Humidifier.IoTSiteWise.ComputationModelTypes.ComputationModelDataBindingValue, BaseFunction>>, BaseFunction>? ComputationModelDataBinding { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotsitewise-computationmodel.html#cfn-iotsitewise-computationmodel-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace ComputationModelTypes
    {
        public class AnomalyDetectionComputationModelConfiguration : Humidifier.Base.BaseSubResource, IHaveResultProperty, IHaveInputProperties
        {
            /// <summary>
            /// ResultProperty
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-computationmodel-anomalydetectioncomputationmodelconfiguration.html#cfn-iotsitewise-computationmodel-anomalydetectioncomputationmodelconfiguration-resultproperty
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ResultProperty { get; set; }
            /// <summary>
            /// InputProperties
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-computationmodel-anomalydetectioncomputationmodelconfiguration.html#cfn-iotsitewise-computationmodel-anomalydetectioncomputationmodelconfiguration-inputproperties
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InputProperties { get; set; }
        }

        public class AssetModelPropertyBindingValue : Humidifier.Base.BaseSubResource, IHaveAssetModelId, IHavePropertyId
        {
            /// <summary>
            /// AssetModelId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-computationmodel-assetmodelpropertybindingvalue.html#cfn-iotsitewise-computationmodel-assetmodelpropertybindingvalue-assetmodelid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AssetModelId { get; set; }
            /// <summary>
            /// PropertyId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-computationmodel-assetmodelpropertybindingvalue.html#cfn-iotsitewise-computationmodel-assetmodelpropertybindingvalue-propertyid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PropertyId { get; set; }
        }

        public class AssetPropertyBindingValue : Humidifier.Base.BaseSubResource, IHaveAssetId, IHavePropertyId
        {
            /// <summary>
            /// AssetId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-computationmodel-assetpropertybindingvalue.html#cfn-iotsitewise-computationmodel-assetpropertybindingvalue-assetid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AssetId { get; set; }
            /// <summary>
            /// PropertyId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-computationmodel-assetpropertybindingvalue.html#cfn-iotsitewise-computationmodel-assetpropertybindingvalue-propertyid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PropertyId { get; set; }
        }

        public class ComputationModelConfiguration : Humidifier.Base.BaseSubResource, IHaveIoTSiteWiseComputationModelTypesAnomalyDetectionComputationModelConfigurationAnomalyDetection
        {
            /// <summary>
            /// AnomalyDetection
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-computationmodel-computationmodelconfiguration.html#cfn-iotsitewise-computationmodel-computationmodelconfiguration-anomalydetection
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AnomalyDetectionComputationModelConfiguration
            /// </summary>
            public Union<Humidifier.IoTSiteWise.ComputationModelTypes.AnomalyDetectionComputationModelConfiguration, BaseFunction>? AnomalyDetection { get; set; }
        }

        public class ComputationModelDataBindingValue : Humidifier.Base.BaseSubResource, IHaveIoTSiteWiseComputationModelTypesAssetModelPropertyBindingValueAssetModelProperty, IHaveListOfIoTSiteWiseComputationModelTypesComputationModelDataBindingValueList, IHaveIoTSiteWiseComputationModelTypesAssetPropertyBindingValueAssetProperty
        {
            /// <summary>
            /// AssetModelProperty
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-computationmodel-computationmodeldatabindingvalue.html#cfn-iotsitewise-computationmodel-computationmodeldatabindingvalue-assetmodelproperty
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AssetModelPropertyBindingValue
            /// </summary>
            public Union<Humidifier.IoTSiteWise.ComputationModelTypes.AssetModelPropertyBindingValue, BaseFunction>? AssetModelProperty { get; set; }
            /// <summary>
            /// List
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-computationmodel-computationmodeldatabindingvalue.html#cfn-iotsitewise-computationmodel-computationmodeldatabindingvalue-list
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ComputationModelDataBindingValue
            /// </summary>
            public Union<IReadOnlyList<Humidifier.IoTSiteWise.ComputationModelTypes.ComputationModelDataBindingValue>, IReadOnlyList<Union<Humidifier.IoTSiteWise.ComputationModelTypes.ComputationModelDataBindingValue, BaseFunction>>, BaseFunction>? List { get; set; }
            /// <summary>
            /// AssetProperty
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-computationmodel-computationmodeldatabindingvalue.html#cfn-iotsitewise-computationmodel-computationmodeldatabindingvalue-assetproperty
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AssetPropertyBindingValue
            /// </summary>
            public Union<Humidifier.IoTSiteWise.ComputationModelTypes.AssetPropertyBindingValue, BaseFunction>? AssetProperty { get; set; }
        }
    }
}