namespace Humidifier.IoTTwinMaker
{
    using System.Collections.Generic;
    using ComponentTypeTypes;

    public class ComponentType : Humidifier.Base.BaseResource, IHaveDescription, IHaveWorkspaceId, IHaveComponentTypeId
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string CreationDateTime =  "CreationDateTime" ;
            public static string IsSchemaInitialized =  "IsSchemaInitialized" ;
            public static string UpdateDateTime =  "UpdateDateTime" ;
            public static string Arn =  "Arn" ;
            public static string IsAbstract =  "IsAbstract" ;
        }

        public override string AWSTypeName { get => AWS.IoTTwinMaker.ComponentType; }
        /// <summary>
        /// ExtendsFrom
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iottwinmaker-componenttype.html#cfn-iottwinmaker-componenttype-extendsfrom
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public dynamic ExtendsFrom { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iottwinmaker-componenttype.html#cfn-iottwinmaker-componenttype-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Description { get; set; }
        /// <summary>
        /// IsSingleton
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iottwinmaker-componenttype.html#cfn-iottwinmaker-componenttype-issingleton
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public dynamic IsSingleton { get; set; }
        /// <summary>
        /// PropertyDefinitions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iottwinmaker-componenttype.html#cfn-iottwinmaker-componenttype-propertydefinitions
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// ItemType: PropertyDefinition
        /// </summary>
        public Dictionary<string, Humidifier.IoTTwinMaker.ComponentTypeTypes.PropertyDefinition> PropertyDefinitions { get; set; }
        /// <summary>
        /// PropertyGroups
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iottwinmaker-componenttype.html#cfn-iottwinmaker-componenttype-propertygroups
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// ItemType: PropertyGroup
        /// </summary>
        public Dictionary<string, Humidifier.IoTTwinMaker.ComponentTypeTypes.PropertyGroup> PropertyGroups { get; set; }

        /// <summary>
        /// WorkspaceId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iottwinmaker-componenttype.html#cfn-iottwinmaker-componenttype-workspaceid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic WorkspaceId { get; set; }

        /// <summary>
        /// ComponentTypeId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iottwinmaker-componenttype.html#cfn-iottwinmaker-componenttype-componenttypeid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic ComponentTypeId { get; set; }
        /// <summary>
        /// Functions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iottwinmaker-componenttype.html#cfn-iottwinmaker-componenttype-functions
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// ItemType: Function
        /// </summary>
        public Dictionary<string, Humidifier.IoTTwinMaker.ComponentTypeTypes.Function> Functions { get; set; }
        /// <summary>
        /// CompositeComponentTypes
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iottwinmaker-componenttype.html#cfn-iottwinmaker-componenttype-compositecomponenttypes
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// ItemType: CompositeComponentType
        /// </summary>
        public Dictionary<string, Humidifier.IoTTwinMaker.ComponentTypeTypes.CompositeComponentType> CompositeComponentTypes { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iottwinmaker-componenttype.html#cfn-iottwinmaker-componenttype-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Dictionary<string, dynamic> Tags { get; set; }
    }

    namespace ComponentTypeTypes
    {
        public class CompositeComponentType : Humidifier.Base.BaseSubResource, IHaveComponentTypeId
        {
            /// <summary>
            /// ComponentTypeId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iottwinmaker-componenttype-compositecomponenttype.html#cfn-iottwinmaker-componenttype-compositecomponenttype-componenttypeid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ComponentTypeId { get; set; }
        }

        public class DataConnector : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// IsNative
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iottwinmaker-componenttype-dataconnector.html#cfn-iottwinmaker-componenttype-dataconnector-isnative
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic IsNative { get; set; }
            /// <summary>
            /// Lambda
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iottwinmaker-componenttype-dataconnector.html#cfn-iottwinmaker-componenttype-dataconnector-lambda
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LambdaFunction
            /// </summary>
            public Humidifier.IoTTwinMaker.ComponentTypeTypes.LambdaFunction Lambda { get; set; }
        }

        public class DataType : Humidifier.Base.BaseSubResource, IHaveType, IHaveUnitOfMeasure
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iottwinmaker-componenttype-datatype.html#cfn-iottwinmaker-componenttype-datatype-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type { get; set; }
            /// <summary>
            /// AllowedValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iottwinmaker-componenttype-datatype.html#cfn-iottwinmaker-componenttype-datatype-allowedvalues
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DataValue
            /// </summary>
            public List<Humidifier.IoTTwinMaker.ComponentTypeTypes.DataValue> AllowedValues { get; set; }
            /// <summary>
            /// UnitOfMeasure
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iottwinmaker-componenttype-datatype.html#cfn-iottwinmaker-componenttype-datatype-unitofmeasure
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic UnitOfMeasure { get; set; }
            /// <summary>
            /// Relationship
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iottwinmaker-componenttype-datatype.html#cfn-iottwinmaker-componenttype-datatype-relationship
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Relationship
            /// </summary>
            public Humidifier.IoTTwinMaker.ComponentTypeTypes.Relationship Relationship { get; set; }
            /// <summary>
            /// NestedType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iottwinmaker-componenttype-datatype.html#cfn-iottwinmaker-componenttype-datatype-nestedtype
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DataType
            /// </summary>
            public Humidifier.IoTTwinMaker.ComponentTypeTypes.DataType NestedType { get; set; }
        }

        public class DataValue : Humidifier.Base.BaseSubResource, IHaveExpression, IHaveStringValue, IHaveDoubleValue, IHaveBooleanValue, IHaveLongValue, IHaveIntegerValue
        {
            /// <summary>
            /// DoubleValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iottwinmaker-componenttype-datavalue.html#cfn-iottwinmaker-componenttype-datavalue-doublevalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic DoubleValue { get; set; }
            /// <summary>
            /// Expression
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iottwinmaker-componenttype-datavalue.html#cfn-iottwinmaker-componenttype-datavalue-expression
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Expression { get; set; }
            /// <summary>
            /// BooleanValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iottwinmaker-componenttype-datavalue.html#cfn-iottwinmaker-componenttype-datavalue-booleanvalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic BooleanValue { get; set; }
            /// <summary>
            /// IntegerValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iottwinmaker-componenttype-datavalue.html#cfn-iottwinmaker-componenttype-datavalue-integervalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic IntegerValue { get; set; }
            /// <summary>
            /// ListValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iottwinmaker-componenttype-datavalue.html#cfn-iottwinmaker-componenttype-datavalue-listvalue
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DataValue
            /// </summary>
            public List<Humidifier.IoTTwinMaker.ComponentTypeTypes.DataValue> ListValue { get; set; }
            /// <summary>
            /// LongValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iottwinmaker-componenttype-datavalue.html#cfn-iottwinmaker-componenttype-datavalue-longvalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic LongValue { get; set; }
            /// <summary>
            /// MapValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iottwinmaker-componenttype-datavalue.html#cfn-iottwinmaker-componenttype-datavalue-mapvalue
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// ItemType: DataValue
            /// </summary>
            public Dictionary<string, Humidifier.IoTTwinMaker.ComponentTypeTypes.DataValue> MapValue { get; set; }
            /// <summary>
            /// RelationshipValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iottwinmaker-componenttype-datavalue.html#cfn-iottwinmaker-componenttype-datavalue-relationshipvalue
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RelationshipValue
            /// </summary>
            public Humidifier.IoTTwinMaker.ComponentTypeTypes.RelationshipValue RelationshipValue { get; set; }
            /// <summary>
            /// StringValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iottwinmaker-componenttype-datavalue.html#cfn-iottwinmaker-componenttype-datavalue-stringvalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic StringValue { get; set; }
        }

        public class Error : Humidifier.Base.BaseSubResource, IHaveMessage, IHaveCode
        {
            /// <summary>
            /// Message
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iottwinmaker-componenttype-error.html#cfn-iottwinmaker-componenttype-error-message
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Message { get; set; }
            /// <summary>
            /// Code
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iottwinmaker-componenttype-error.html#cfn-iottwinmaker-componenttype-error-code
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Code { get; set; }
        }

        public class Function : Humidifier.Base.BaseSubResource, IHaveScope
        {
            /// <summary>
            /// Scope
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iottwinmaker-componenttype-function.html#cfn-iottwinmaker-componenttype-function-scope
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Scope { get; set; }
            /// <summary>
            /// RequiredProperties
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iottwinmaker-componenttype-function.html#cfn-iottwinmaker-componenttype-function-requiredproperties
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic RequiredProperties { get; set; }
            /// <summary>
            /// ImplementedBy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iottwinmaker-componenttype-function.html#cfn-iottwinmaker-componenttype-function-implementedby
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DataConnector
            /// </summary>
            public Humidifier.IoTTwinMaker.ComponentTypeTypes.DataConnector ImplementedBy { get; set; }
        }

        public class LambdaFunction : Humidifier.Base.BaseSubResource, IHaveArn
        {
            /// <summary>
            /// Arn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iottwinmaker-componenttype-lambdafunction.html#cfn-iottwinmaker-componenttype-lambdafunction-arn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Arn { get; set; }
        }

        public class PropertyDefinition : Humidifier.Base.BaseSubResource, IHaveIsExternalId, IHaveIsStoredExternally, IHaveIsTimeSeries, IHaveIsRequiredInEntity
        {
            /// <summary>
            /// DefaultValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iottwinmaker-componenttype-propertydefinition.html#cfn-iottwinmaker-componenttype-propertydefinition-defaultvalue
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DataValue
            /// </summary>
            public Humidifier.IoTTwinMaker.ComponentTypeTypes.DataValue DefaultValue { get; set; }
            /// <summary>
            /// IsExternalId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iottwinmaker-componenttype-propertydefinition.html#cfn-iottwinmaker-componenttype-propertydefinition-isexternalid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic IsExternalId { get; set; }
            /// <summary>
            /// IsStoredExternally
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iottwinmaker-componenttype-propertydefinition.html#cfn-iottwinmaker-componenttype-propertydefinition-isstoredexternally
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic IsStoredExternally { get; set; }
            /// <summary>
            /// IsTimeSeries
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iottwinmaker-componenttype-propertydefinition.html#cfn-iottwinmaker-componenttype-propertydefinition-istimeseries
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic IsTimeSeries { get; set; }
            /// <summary>
            /// IsRequiredInEntity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iottwinmaker-componenttype-propertydefinition.html#cfn-iottwinmaker-componenttype-propertydefinition-isrequiredinentity
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic IsRequiredInEntity { get; set; }
            /// <summary>
            /// DataType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iottwinmaker-componenttype-propertydefinition.html#cfn-iottwinmaker-componenttype-propertydefinition-datatype
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DataType
            /// </summary>
            public Humidifier.IoTTwinMaker.ComponentTypeTypes.DataType DataType { get; set; }
            /// <summary>
            /// Configurations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iottwinmaker-componenttype-propertydefinition.html#cfn-iottwinmaker-componenttype-propertydefinition-configurations
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Dictionary<string, dynamic> Configurations { get; set; }
        }

        public class PropertyGroup : Humidifier.Base.BaseSubResource, IHaveGroupType, IHavePropertyNames
        {
            /// <summary>
            /// GroupType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iottwinmaker-componenttype-propertygroup.html#cfn-iottwinmaker-componenttype-propertygroup-grouptype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic GroupType { get; set; }
            /// <summary>
            /// PropertyNames
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iottwinmaker-componenttype-propertygroup.html#cfn-iottwinmaker-componenttype-propertygroup-propertynames
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic PropertyNames { get; set; }
        }

        public class Relationship : Humidifier.Base.BaseSubResource, IHaveRelationshipType, IHaveTargetComponentTypeId
        {
            /// <summary>
            /// RelationshipType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iottwinmaker-componenttype-relationship.html#cfn-iottwinmaker-componenttype-relationship-relationshiptype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RelationshipType { get; set; }
            /// <summary>
            /// TargetComponentTypeId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iottwinmaker-componenttype-relationship.html#cfn-iottwinmaker-componenttype-relationship-targetcomponenttypeid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TargetComponentTypeId { get; set; }
        }

        public class RelationshipValue : Humidifier.Base.BaseSubResource, IHaveTargetComponentName, IHaveTargetEntityId
        {
            /// <summary>
            /// TargetComponentName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iottwinmaker-componenttype-relationshipvalue.html#cfn-iottwinmaker-componenttype-relationshipvalue-targetcomponentname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TargetComponentName { get; set; }
            /// <summary>
            /// TargetEntityId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iottwinmaker-componenttype-relationshipvalue.html#cfn-iottwinmaker-componenttype-relationshipvalue-targetentityid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TargetEntityId { get; set; }
        }

        public class Status : Humidifier.Base.BaseSubResource, IHaveState
        {
            /// <summary>
            /// State
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iottwinmaker-componenttype-status.html#cfn-iottwinmaker-componenttype-status-state
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic State { get; set; }
            /// <summary>
            /// Error
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iottwinmaker-componenttype-status.html#cfn-iottwinmaker-componenttype-status-error
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Error
            /// </summary>
            public Humidifier.IoTTwinMaker.ComponentTypeTypes.Error Error { get; set; }
        }
    }
}