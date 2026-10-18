namespace Humidifier.IoTSiteWise
{
    using global::System.Collections.Generic;
    using AssetModelTypes;

    public class AssetModel : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveAssetModelDescription, IHaveListOfIoTSiteWiseAssetModelTypesAssetModelCompositeModelAssetModelCompositeModels, IHaveListOfIoTSiteWiseAssetModelTypesEnforcedAssetModelInterfaceRelationshipEnforcedAssetModelInterfaceRelationships, IHaveAssetModelType, IHaveAssetModelName, IHaveListOfIoTSiteWiseAssetModelTypesAssetModelHierarchyAssetModelHierarchies, IHaveListOfIoTSiteWiseAssetModelTypesAssetModelPropertyAssetModelProperties, IHaveAssetModelExternalId, IHaveDescription
    {
        public class Attributes
        {
            public static string AssetModelId =  "AssetModelId" ;
            public static string AssetModelArn =  "AssetModelArn" ;
        }

        public override string AWSTypeName { get => AWS.IoTSiteWise.AssetModel; }
        /// <summary>
        /// AssetModelDescription
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotsitewise-assetmodel.html#cfn-iotsitewise-assetmodel-assetmodeldescription
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? AssetModelDescription { get; set; }

        [Ignore]
        public Union<string, BaseFunction>? Description { get => AssetModelDescription; set => AssetModelDescription = value; }
        /// <summary>
        /// AssetModelCompositeModels
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotsitewise-assetmodel.html#cfn-iotsitewise-assetmodel-assetmodelcompositemodels
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: AssetModelCompositeModel
        /// </summary>
        public Union<IReadOnlyList<Humidifier.IoTSiteWise.AssetModelTypes.AssetModelCompositeModel>, IReadOnlyList<Union<Humidifier.IoTSiteWise.AssetModelTypes.AssetModelCompositeModel, BaseFunction>>, BaseFunction>? AssetModelCompositeModels { get; set; }
        /// <summary>
        /// EnforcedAssetModelInterfaceRelationships
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotsitewise-assetmodel.html#cfn-iotsitewise-assetmodel-enforcedassetmodelinterfacerelationships
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: EnforcedAssetModelInterfaceRelationship
        /// </summary>
        public Union<IReadOnlyList<Humidifier.IoTSiteWise.AssetModelTypes.EnforcedAssetModelInterfaceRelationship>, IReadOnlyList<Union<Humidifier.IoTSiteWise.AssetModelTypes.EnforcedAssetModelInterfaceRelationship, BaseFunction>>, BaseFunction>? EnforcedAssetModelInterfaceRelationships { get; set; }
        /// <summary>
        /// AssetModelType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotsitewise-assetmodel.html#cfn-iotsitewise-assetmodel-assetmodeltype
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? AssetModelType { get; set; }
        public Union<string, BaseFunction>? AssetModelName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// AssetModelHierarchies
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotsitewise-assetmodel.html#cfn-iotsitewise-assetmodel-assetmodelhierarchies
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: AssetModelHierarchy
        /// </summary>
        public Union<IReadOnlyList<Humidifier.IoTSiteWise.AssetModelTypes.AssetModelHierarchy>, IReadOnlyList<Union<Humidifier.IoTSiteWise.AssetModelTypes.AssetModelHierarchy, BaseFunction>>, BaseFunction>? AssetModelHierarchies { get; set; }
        /// <summary>
        /// AssetModelProperties
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotsitewise-assetmodel.html#cfn-iotsitewise-assetmodel-assetmodelproperties
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: AssetModelProperty
        /// </summary>
        public Union<IReadOnlyList<Humidifier.IoTSiteWise.AssetModelTypes.AssetModelProperty>, IReadOnlyList<Union<Humidifier.IoTSiteWise.AssetModelTypes.AssetModelProperty, BaseFunction>>, BaseFunction>? AssetModelProperties { get; set; }
        /// <summary>
        /// AssetModelExternalId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotsitewise-assetmodel.html#cfn-iotsitewise-assetmodel-assetmodelexternalid
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? AssetModelExternalId { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotsitewise-assetmodel.html#cfn-iotsitewise-assetmodel-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace AssetModelTypes
    {
        public class AssetModelCompositeModel : Humidifier.Base.BaseSubResource, IHaveStringListOfPath, IHaveParentAssetModelCompositeModelExternalId, IHaveType, IHaveDescription, IHaveComposedAssetModelId, IHaveExternalId, IHaveListOfIoTSiteWiseAssetModelTypesAssetModelPropertyCompositeModelProperties, IHaveId, IHaveName
        {
            /// <summary>
            /// Path
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-assetmodel-assetmodelcompositemodel.html#cfn-iotsitewise-assetmodel-assetmodelcompositemodel-path
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Path { get; set; }
            /// <summary>
            /// ParentAssetModelCompositeModelExternalId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-assetmodel-assetmodelcompositemodel.html#cfn-iotsitewise-assetmodel-assetmodelcompositemodel-parentassetmodelcompositemodelexternalid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ParentAssetModelCompositeModelExternalId { get; set; }
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-assetmodel-assetmodelcompositemodel.html#cfn-iotsitewise-assetmodel-assetmodelcompositemodel-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// Description
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-assetmodel-assetmodelcompositemodel.html#cfn-iotsitewise-assetmodel-assetmodelcompositemodel-description
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Description { get; set; }
            /// <summary>
            /// ComposedAssetModelId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-assetmodel-assetmodelcompositemodel.html#cfn-iotsitewise-assetmodel-assetmodelcompositemodel-composedassetmodelid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ComposedAssetModelId { get; set; }
            /// <summary>
            /// ExternalId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-assetmodel-assetmodelcompositemodel.html#cfn-iotsitewise-assetmodel-assetmodelcompositemodel-externalid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ExternalId { get; set; }
            /// <summary>
            /// CompositeModelProperties
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-assetmodel-assetmodelcompositemodel.html#cfn-iotsitewise-assetmodel-assetmodelcompositemodel-compositemodelproperties
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: AssetModelProperty
            /// </summary>
            public Union<IReadOnlyList<Humidifier.IoTSiteWise.AssetModelTypes.AssetModelProperty>, IReadOnlyList<Union<Humidifier.IoTSiteWise.AssetModelTypes.AssetModelProperty, BaseFunction>>, BaseFunction>? CompositeModelProperties { get; set; }
            /// <summary>
            /// Id
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-assetmodel-assetmodelcompositemodel.html#cfn-iotsitewise-assetmodel-assetmodelcompositemodel-id
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Id { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-assetmodel-assetmodelcompositemodel.html#cfn-iotsitewise-assetmodel-assetmodelcompositemodel-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class AssetModelHierarchy : Humidifier.Base.BaseSubResource, IHaveLogicalId, IHaveExternalId, IHaveId, IHaveChildAssetModelId, IHaveName
        {
            /// <summary>
            /// LogicalId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-assetmodel-assetmodelhierarchy.html#cfn-iotsitewise-assetmodel-assetmodelhierarchy-logicalid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LogicalId { get; set; }
            /// <summary>
            /// ExternalId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-assetmodel-assetmodelhierarchy.html#cfn-iotsitewise-assetmodel-assetmodelhierarchy-externalid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ExternalId { get; set; }
            /// <summary>
            /// Id
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-assetmodel-assetmodelhierarchy.html#cfn-iotsitewise-assetmodel-assetmodelhierarchy-id
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Id { get; set; }
            /// <summary>
            /// ChildAssetModelId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-assetmodel-assetmodelhierarchy.html#cfn-iotsitewise-assetmodel-assetmodelhierarchy-childassetmodelid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ChildAssetModelId { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-assetmodel-assetmodelhierarchy.html#cfn-iotsitewise-assetmodel-assetmodelhierarchy-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class AssetModelProperty : Humidifier.Base.BaseSubResource, IHaveIoTSiteWiseAssetModelTypesPropertyTypeType, IHaveLogicalId, IHaveExternalId, IHaveDataTypeSpec, IHaveDataType, IHaveId, IHaveUnit, IHaveName
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-assetmodel-assetmodelproperty.html#cfn-iotsitewise-assetmodel-assetmodelproperty-type
            /// Required: True
            /// UpdateType: Mutable
            /// Type: PropertyType
            /// </summary>
            public Union<Humidifier.IoTSiteWise.AssetModelTypes.PropertyType, BaseFunction>? Type { get; set; }
            /// <summary>
            /// LogicalId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-assetmodel-assetmodelproperty.html#cfn-iotsitewise-assetmodel-assetmodelproperty-logicalid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LogicalId { get; set; }
            /// <summary>
            /// ExternalId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-assetmodel-assetmodelproperty.html#cfn-iotsitewise-assetmodel-assetmodelproperty-externalid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ExternalId { get; set; }
            /// <summary>
            /// DataTypeSpec
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-assetmodel-assetmodelproperty.html#cfn-iotsitewise-assetmodel-assetmodelproperty-datatypespec
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DataTypeSpec { get; set; }
            /// <summary>
            /// DataType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-assetmodel-assetmodelproperty.html#cfn-iotsitewise-assetmodel-assetmodelproperty-datatype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DataType { get; set; }
            /// <summary>
            /// Id
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-assetmodel-assetmodelproperty.html#cfn-iotsitewise-assetmodel-assetmodelproperty-id
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Id { get; set; }
            /// <summary>
            /// Unit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-assetmodel-assetmodelproperty.html#cfn-iotsitewise-assetmodel-assetmodelproperty-unit
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Unit { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-assetmodel-assetmodelproperty.html#cfn-iotsitewise-assetmodel-assetmodelproperty-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class Attribute : Humidifier.Base.BaseSubResource, IHaveDefaultValue
        {
            /// <summary>
            /// DefaultValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-assetmodel-attribute.html#cfn-iotsitewise-assetmodel-attribute-defaultvalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DefaultValue { get; set; }
        }

        public class EnforcedAssetModelInterfacePropertyMapping : Humidifier.Base.BaseSubResource, IHaveInterfaceAssetModelPropertyExternalId, IHaveAssetModelPropertyLogicalId, IHaveAssetModelPropertyExternalId
        {
            /// <summary>
            /// InterfaceAssetModelPropertyExternalId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-assetmodel-enforcedassetmodelinterfacepropertymapping.html#cfn-iotsitewise-assetmodel-enforcedassetmodelinterfacepropertymapping-interfaceassetmodelpropertyexternalid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InterfaceAssetModelPropertyExternalId { get; set; }
            /// <summary>
            /// AssetModelPropertyLogicalId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-assetmodel-enforcedassetmodelinterfacepropertymapping.html#cfn-iotsitewise-assetmodel-enforcedassetmodelinterfacepropertymapping-assetmodelpropertylogicalid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AssetModelPropertyLogicalId { get; set; }
            /// <summary>
            /// AssetModelPropertyExternalId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-assetmodel-enforcedassetmodelinterfacepropertymapping.html#cfn-iotsitewise-assetmodel-enforcedassetmodelinterfacepropertymapping-assetmodelpropertyexternalid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AssetModelPropertyExternalId { get; set; }
        }

        public class EnforcedAssetModelInterfaceRelationship : Humidifier.Base.BaseSubResource, IHaveInterfaceAssetModelId, IHaveListOfIoTSiteWiseAssetModelTypesEnforcedAssetModelInterfacePropertyMappingPropertyMappings
        {
            /// <summary>
            /// InterfaceAssetModelId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-assetmodel-enforcedassetmodelinterfacerelationship.html#cfn-iotsitewise-assetmodel-enforcedassetmodelinterfacerelationship-interfaceassetmodelid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InterfaceAssetModelId { get; set; }
            /// <summary>
            /// PropertyMappings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-assetmodel-enforcedassetmodelinterfacerelationship.html#cfn-iotsitewise-assetmodel-enforcedassetmodelinterfacerelationship-propertymappings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: EnforcedAssetModelInterfacePropertyMapping
            /// </summary>
            public Union<IReadOnlyList<Humidifier.IoTSiteWise.AssetModelTypes.EnforcedAssetModelInterfacePropertyMapping>, IReadOnlyList<Union<Humidifier.IoTSiteWise.AssetModelTypes.EnforcedAssetModelInterfacePropertyMapping, BaseFunction>>, BaseFunction>? PropertyMappings { get; set; }
        }

        public class ExpressionVariable : Humidifier.Base.BaseSubResource, IHaveIoTSiteWiseAssetModelTypesVariableValueValue, IHaveName
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-assetmodel-expressionvariable.html#cfn-iotsitewise-assetmodel-expressionvariable-value
            /// Required: True
            /// UpdateType: Mutable
            /// Type: VariableValue
            /// </summary>
            public Union<Humidifier.IoTSiteWise.AssetModelTypes.VariableValue, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-assetmodel-expressionvariable.html#cfn-iotsitewise-assetmodel-expressionvariable-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class Metric : Humidifier.Base.BaseSubResource, IHaveListOfIoTSiteWiseAssetModelTypesExpressionVariableVariables, IHaveIoTSiteWiseAssetModelTypesMetricWindowWindow, IHaveExpression
        {
            /// <summary>
            /// Variables
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-assetmodel-metric.html#cfn-iotsitewise-assetmodel-metric-variables
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ExpressionVariable
            /// </summary>
            public Union<IReadOnlyList<Humidifier.IoTSiteWise.AssetModelTypes.ExpressionVariable>, IReadOnlyList<Union<Humidifier.IoTSiteWise.AssetModelTypes.ExpressionVariable, BaseFunction>>, BaseFunction>? Variables { get; set; }
            /// <summary>
            /// Window
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-assetmodel-metric.html#cfn-iotsitewise-assetmodel-metric-window
            /// Required: True
            /// UpdateType: Mutable
            /// Type: MetricWindow
            /// </summary>
            public Union<Humidifier.IoTSiteWise.AssetModelTypes.MetricWindow, BaseFunction>? Window { get; set; }
            /// <summary>
            /// Expression
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-assetmodel-metric.html#cfn-iotsitewise-assetmodel-metric-expression
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Expression { get; set; }
        }

        public class MetricWindow : Humidifier.Base.BaseSubResource, IHaveIoTSiteWiseAssetModelTypesTumblingWindowTumbling
        {
            /// <summary>
            /// Tumbling
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-assetmodel-metricwindow.html#cfn-iotsitewise-assetmodel-metricwindow-tumbling
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TumblingWindow
            /// </summary>
            public Union<Humidifier.IoTSiteWise.AssetModelTypes.TumblingWindow, BaseFunction>? Tumbling { get; set; }
        }

        public class PropertyPathDefinition : Humidifier.Base.BaseSubResource, IHaveName
        {
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-assetmodel-propertypathdefinition.html#cfn-iotsitewise-assetmodel-propertypathdefinition-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class PropertyType : Humidifier.Base.BaseSubResource, IHaveTypeName, IHaveIoTSiteWiseAssetModelTypesAttributeAttribute, IHaveIoTSiteWiseAssetModelTypesMetricMetric, IHaveIoTSiteWiseAssetModelTypesTransformTransform
        {
            /// <summary>
            /// TypeName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-assetmodel-propertytype.html#cfn-iotsitewise-assetmodel-propertytype-typename
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TypeName { get; set; }
            /// <summary>
            /// Attribute
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-assetmodel-propertytype.html#cfn-iotsitewise-assetmodel-propertytype-attribute
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Attribute
            /// </summary>
            public Union<Humidifier.IoTSiteWise.AssetModelTypes.Attribute, BaseFunction>? Attribute { get; set; }
            /// <summary>
            /// Metric
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-assetmodel-propertytype.html#cfn-iotsitewise-assetmodel-propertytype-metric
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Metric
            /// </summary>
            public Union<Humidifier.IoTSiteWise.AssetModelTypes.Metric, BaseFunction>? Metric { get; set; }
            /// <summary>
            /// Transform
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-assetmodel-propertytype.html#cfn-iotsitewise-assetmodel-propertytype-transform
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Transform
            /// </summary>
            public Union<Humidifier.IoTSiteWise.AssetModelTypes.Transform, BaseFunction>? Transform { get; set; }
        }

        public class Transform : Humidifier.Base.BaseSubResource, IHaveListOfIoTSiteWiseAssetModelTypesExpressionVariableVariables, IHaveExpression
        {
            /// <summary>
            /// Variables
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-assetmodel-transform.html#cfn-iotsitewise-assetmodel-transform-variables
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ExpressionVariable
            /// </summary>
            public Union<IReadOnlyList<Humidifier.IoTSiteWise.AssetModelTypes.ExpressionVariable>, IReadOnlyList<Union<Humidifier.IoTSiteWise.AssetModelTypes.ExpressionVariable, BaseFunction>>, BaseFunction>? Variables { get; set; }
            /// <summary>
            /// Expression
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-assetmodel-transform.html#cfn-iotsitewise-assetmodel-transform-expression
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Expression { get; set; }
        }

        public class TumblingWindow : Humidifier.Base.BaseSubResource, IHaveInterval, IHaveOffset
        {
            /// <summary>
            /// Interval
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-assetmodel-tumblingwindow.html#cfn-iotsitewise-assetmodel-tumblingwindow-interval
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Interval { get; set; }
            /// <summary>
            /// Offset
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-assetmodel-tumblingwindow.html#cfn-iotsitewise-assetmodel-tumblingwindow-offset
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Offset { get; set; }
        }

        public class VariableValue : Humidifier.Base.BaseSubResource, IHavePropertyExternalId, IHaveHierarchyId, IHavePropertyLogicalId, IHaveHierarchyLogicalId, IHaveListOfIoTSiteWiseAssetModelTypesPropertyPathDefinitionPropertyPath, IHaveHierarchyExternalId, IHavePropertyId
        {
            /// <summary>
            /// PropertyExternalId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-assetmodel-variablevalue.html#cfn-iotsitewise-assetmodel-variablevalue-propertyexternalid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PropertyExternalId { get; set; }
            /// <summary>
            /// HierarchyId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-assetmodel-variablevalue.html#cfn-iotsitewise-assetmodel-variablevalue-hierarchyid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? HierarchyId { get; set; }
            /// <summary>
            /// PropertyLogicalId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-assetmodel-variablevalue.html#cfn-iotsitewise-assetmodel-variablevalue-propertylogicalid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PropertyLogicalId { get; set; }
            /// <summary>
            /// HierarchyLogicalId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-assetmodel-variablevalue.html#cfn-iotsitewise-assetmodel-variablevalue-hierarchylogicalid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? HierarchyLogicalId { get; set; }
            /// <summary>
            /// PropertyPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-assetmodel-variablevalue.html#cfn-iotsitewise-assetmodel-variablevalue-propertypath
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: PropertyPathDefinition
            /// </summary>
            public Union<IReadOnlyList<Humidifier.IoTSiteWise.AssetModelTypes.PropertyPathDefinition>, IReadOnlyList<Union<Humidifier.IoTSiteWise.AssetModelTypes.PropertyPathDefinition, BaseFunction>>, BaseFunction>? PropertyPath { get; set; }
            /// <summary>
            /// HierarchyExternalId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-assetmodel-variablevalue.html#cfn-iotsitewise-assetmodel-variablevalue-hierarchyexternalid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? HierarchyExternalId { get; set; }
            /// <summary>
            /// PropertyId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-assetmodel-variablevalue.html#cfn-iotsitewise-assetmodel-variablevalue-propertyid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PropertyId { get; set; }
        }
    }
}