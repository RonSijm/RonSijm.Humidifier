namespace Humidifier.IoTSiteWise
{
    using global::System.Collections.Generic;
    using ComputationModelTypes;

    public class ComputationModel : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveDescription
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
        public Humidifier.IoTSiteWise.ComputationModelTypes.ComputationModelConfiguration ComputationModelConfiguration { get; set; }
        /// <summary>
        /// ComputationModelDescription
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotsitewise-computationmodel.html#cfn-iotsitewise-computationmodel-computationmodeldescription
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ComputationModelDescription { get; set; }

        [Ignore]
        public dynamic Description { get => ComputationModelDescription; set => ComputationModelDescription = value; }
        public dynamic ComputationModelName { get => GivenName; set => GivenName = value; }

        /// <summary>
        /// ComputationModelDataBinding
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotsitewise-computationmodel.html#cfn-iotsitewise-computationmodel-computationmodeldatabinding
        /// Required: True
        /// UpdateType: Mutable
        /// Type: Map
        /// ItemType: ComputationModelDataBindingValue
        /// </summary>
        [Required]
        public Dictionary<string, Humidifier.IoTSiteWise.ComputationModelTypes.ComputationModelDataBindingValue> ComputationModelDataBinding { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotsitewise-computationmodel.html#cfn-iotsitewise-computationmodel-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
    }

    namespace ComputationModelTypes
    {
        public class AnomalyDetectionComputationModelConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ResultProperty
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-computationmodel-anomalydetectioncomputationmodelconfiguration.html#cfn-iotsitewise-computationmodel-anomalydetectioncomputationmodelconfiguration-resultproperty
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ResultProperty { get; set; }
            /// <summary>
            /// InputProperties
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-computationmodel-anomalydetectioncomputationmodelconfiguration.html#cfn-iotsitewise-computationmodel-anomalydetectioncomputationmodelconfiguration-inputproperties
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic InputProperties { get; set; }
        }

        public class AssetModelPropertyBindingValue : Humidifier.Base.BaseSubResource, IHavePropertyId
        {
            /// <summary>
            /// AssetModelId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-computationmodel-assetmodelpropertybindingvalue.html#cfn-iotsitewise-computationmodel-assetmodelpropertybindingvalue-assetmodelid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AssetModelId { get; set; }
            /// <summary>
            /// PropertyId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-computationmodel-assetmodelpropertybindingvalue.html#cfn-iotsitewise-computationmodel-assetmodelpropertybindingvalue-propertyid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PropertyId { get; set; }
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
            public dynamic AssetId { get; set; }
            /// <summary>
            /// PropertyId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-computationmodel-assetpropertybindingvalue.html#cfn-iotsitewise-computationmodel-assetpropertybindingvalue-propertyid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PropertyId { get; set; }
        }

        public class ComputationModelConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// AnomalyDetection
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-computationmodel-computationmodelconfiguration.html#cfn-iotsitewise-computationmodel-computationmodelconfiguration-anomalydetection
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AnomalyDetectionComputationModelConfiguration
            /// </summary>
            public Humidifier.IoTSiteWise.ComputationModelTypes.AnomalyDetectionComputationModelConfiguration AnomalyDetection { get; set; }
        }

        public class ComputationModelDataBindingValue : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// AssetModelProperty
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-computationmodel-computationmodeldatabindingvalue.html#cfn-iotsitewise-computationmodel-computationmodeldatabindingvalue-assetmodelproperty
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AssetModelPropertyBindingValue
            /// </summary>
            public Humidifier.IoTSiteWise.ComputationModelTypes.AssetModelPropertyBindingValue AssetModelProperty { get; set; }
            /// <summary>
            /// List
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-computationmodel-computationmodeldatabindingvalue.html#cfn-iotsitewise-computationmodel-computationmodeldatabindingvalue-list
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ComputationModelDataBindingValue
            /// </summary>
            public List<Humidifier.IoTSiteWise.ComputationModelTypes.ComputationModelDataBindingValue> List { get; set; }
            /// <summary>
            /// AssetProperty
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-computationmodel-computationmodeldatabindingvalue.html#cfn-iotsitewise-computationmodel-computationmodeldatabindingvalue-assetproperty
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AssetPropertyBindingValue
            /// </summary>
            public Humidifier.IoTSiteWise.ComputationModelTypes.AssetPropertyBindingValue AssetProperty { get; set; }
        }
    }
}