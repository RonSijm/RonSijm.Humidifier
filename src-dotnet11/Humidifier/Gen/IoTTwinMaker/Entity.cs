namespace Humidifier.IoTTwinMaker
{
    using global::System.Collections.Generic;
    using EntityTypes;

    public class Entity : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveEntityId, IHaveMapOfIoTTwinMakerEntityTypesComponentComponents, IHaveParentEntityId, IHaveMapOfIoTTwinMakerEntityTypesCompositeComponentCompositeComponents, IHaveDescription, IHaveEntityName, IHaveWorkspaceId, IHaveStringDictionaryOfTags
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string CreationDateTime =  "CreationDateTime" ;
            public static string HasChildEntities =  "HasChildEntities" ;
            public static string UpdateDateTime =  "UpdateDateTime" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.IoTTwinMaker.Entity; }
        /// <summary>
        /// EntityId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iottwinmaker-entity.html#cfn-iottwinmaker-entity-entityid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? EntityId { get; set; }
        /// <summary>
        /// Components
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iottwinmaker-entity.html#cfn-iottwinmaker-entity-components
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// ItemType: Component
        /// </summary>
        public Union<IReadOnlyDictionary<string, Humidifier.IoTTwinMaker.EntityTypes.Component>, IReadOnlyDictionary<string, Union<Humidifier.IoTTwinMaker.EntityTypes.Component, BaseFunction>>, BaseFunction>? Components { get; set; }
        /// <summary>
        /// ParentEntityId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iottwinmaker-entity.html#cfn-iottwinmaker-entity-parententityid
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ParentEntityId { get; set; }
        /// <summary>
        /// CompositeComponents
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iottwinmaker-entity.html#cfn-iottwinmaker-entity-compositecomponents
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// ItemType: CompositeComponent
        /// </summary>
        public Union<IReadOnlyDictionary<string, Humidifier.IoTTwinMaker.EntityTypes.CompositeComponent>, IReadOnlyDictionary<string, Union<Humidifier.IoTTwinMaker.EntityTypes.CompositeComponent, BaseFunction>>, BaseFunction>? CompositeComponents { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iottwinmaker-entity.html#cfn-iottwinmaker-entity-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        public Union<string, BaseFunction>? EntityName { get => GivenName; set => GivenName = value; }

        /// <summary>
        /// WorkspaceId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iottwinmaker-entity.html#cfn-iottwinmaker-entity-workspaceid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? WorkspaceId { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iottwinmaker-entity.html#cfn-iottwinmaker-entity-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace EntityTypes
    {
        public class Component : Humidifier.Base.BaseSubResource, IHaveIoTTwinMakerEntityTypesStatusStatus, IHaveDescription, IHaveDefinedIn, IHaveMapOfIoTTwinMakerEntityTypesPropertyGroupPropertyGroups, IHaveComponentTypeId, IHaveComponentName, IHaveMapOfIoTTwinMakerEntityTypesPropertyProperties
        {
            /// <summary>
            /// Status
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iottwinmaker-entity-component.html#cfn-iottwinmaker-entity-component-status
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Status
            /// </summary>
            public Union<Humidifier.IoTTwinMaker.EntityTypes.Status, BaseFunction>? Status { get; set; }
            /// <summary>
            /// Description
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iottwinmaker-entity-component.html#cfn-iottwinmaker-entity-component-description
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Description { get; set; }
            /// <summary>
            /// DefinedIn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iottwinmaker-entity-component.html#cfn-iottwinmaker-entity-component-definedin
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DefinedIn { get; set; }
            /// <summary>
            /// PropertyGroups
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iottwinmaker-entity-component.html#cfn-iottwinmaker-entity-component-propertygroups
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// ItemType: PropertyGroup
            /// </summary>
            public Union<IReadOnlyDictionary<string, Humidifier.IoTTwinMaker.EntityTypes.PropertyGroup>, IReadOnlyDictionary<string, Union<Humidifier.IoTTwinMaker.EntityTypes.PropertyGroup, BaseFunction>>, BaseFunction>? PropertyGroups { get; set; }
            /// <summary>
            /// ComponentTypeId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iottwinmaker-entity-component.html#cfn-iottwinmaker-entity-component-componenttypeid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ComponentTypeId { get; set; }
            /// <summary>
            /// ComponentName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iottwinmaker-entity-component.html#cfn-iottwinmaker-entity-component-componentname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ComponentName { get; set; }
            /// <summary>
            /// Properties
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iottwinmaker-entity-component.html#cfn-iottwinmaker-entity-component-properties
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// ItemType: Property
            /// </summary>
            public Union<IReadOnlyDictionary<string, Humidifier.IoTTwinMaker.EntityTypes.Property>, IReadOnlyDictionary<string, Union<Humidifier.IoTTwinMaker.EntityTypes.Property, BaseFunction>>, BaseFunction>? Properties { get; set; }
        }

        public class CompositeComponent : Humidifier.Base.BaseSubResource, IHaveIoTTwinMakerEntityTypesStatusStatus, IHaveComponentPath, IHaveDescription, IHaveMapOfIoTTwinMakerEntityTypesPropertyGroupPropertyGroups, IHaveComponentTypeId, IHaveComponentName, IHaveMapOfIoTTwinMakerEntityTypesPropertyProperties
        {
            /// <summary>
            /// Status
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iottwinmaker-entity-compositecomponent.html#cfn-iottwinmaker-entity-compositecomponent-status
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Status
            /// </summary>
            public Union<Humidifier.IoTTwinMaker.EntityTypes.Status, BaseFunction>? Status { get; set; }
            /// <summary>
            /// ComponentPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iottwinmaker-entity-compositecomponent.html#cfn-iottwinmaker-entity-compositecomponent-componentpath
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ComponentPath { get; set; }
            /// <summary>
            /// Description
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iottwinmaker-entity-compositecomponent.html#cfn-iottwinmaker-entity-compositecomponent-description
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Description { get; set; }
            /// <summary>
            /// PropertyGroups
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iottwinmaker-entity-compositecomponent.html#cfn-iottwinmaker-entity-compositecomponent-propertygroups
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// ItemType: PropertyGroup
            /// </summary>
            public Union<IReadOnlyDictionary<string, Humidifier.IoTTwinMaker.EntityTypes.PropertyGroup>, IReadOnlyDictionary<string, Union<Humidifier.IoTTwinMaker.EntityTypes.PropertyGroup, BaseFunction>>, BaseFunction>? PropertyGroups { get; set; }
            /// <summary>
            /// ComponentTypeId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iottwinmaker-entity-compositecomponent.html#cfn-iottwinmaker-entity-compositecomponent-componenttypeid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ComponentTypeId { get; set; }
            /// <summary>
            /// ComponentName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iottwinmaker-entity-compositecomponent.html#cfn-iottwinmaker-entity-compositecomponent-componentname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ComponentName { get; set; }
            /// <summary>
            /// Properties
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iottwinmaker-entity-compositecomponent.html#cfn-iottwinmaker-entity-compositecomponent-properties
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// ItemType: Property
            /// </summary>
            public Union<IReadOnlyDictionary<string, Humidifier.IoTTwinMaker.EntityTypes.Property>, IReadOnlyDictionary<string, Union<Humidifier.IoTTwinMaker.EntityTypes.Property, BaseFunction>>, BaseFunction>? Properties { get; set; }
        }

        public class DataType : Humidifier.Base.BaseSubResource, IHaveType, IHaveListOfIoTTwinMakerEntityTypesDataValueAllowedValues, IHaveUnitOfMeasure, IHaveIoTTwinMakerEntityTypesDataTypeNestedType, IHaveIoTTwinMakerEntityTypesRelationshipRelationship
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iottwinmaker-entity-datatype.html#cfn-iottwinmaker-entity-datatype-type
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// AllowedValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iottwinmaker-entity-datatype.html#cfn-iottwinmaker-entity-datatype-allowedvalues
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DataValue
            /// </summary>
            public Union<IReadOnlyList<Humidifier.IoTTwinMaker.EntityTypes.DataValue>, IReadOnlyList<Union<Humidifier.IoTTwinMaker.EntityTypes.DataValue, BaseFunction>>, BaseFunction>? AllowedValues { get; set; }
            /// <summary>
            /// UnitOfMeasure
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iottwinmaker-entity-datatype.html#cfn-iottwinmaker-entity-datatype-unitofmeasure
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UnitOfMeasure { get; set; }
            /// <summary>
            /// NestedType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iottwinmaker-entity-datatype.html#cfn-iottwinmaker-entity-datatype-nestedtype
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DataType
            /// </summary>
            public Union<Humidifier.IoTTwinMaker.EntityTypes.DataType, BaseFunction>? NestedType { get; set; }
            /// <summary>
            /// Relationship
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iottwinmaker-entity-datatype.html#cfn-iottwinmaker-entity-datatype-relationship
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Relationship
            /// </summary>
            public Union<Humidifier.IoTTwinMaker.EntityTypes.Relationship, BaseFunction>? Relationship { get; set; }
        }

        public class DataValue : Humidifier.Base.BaseSubResource, IHaveDoubleValue_Double, IHaveExpression, IHaveBooleanValue_Boolean, IHaveIntegerValue_Integer, IHaveListOfIoTTwinMakerEntityTypesDataValueListValue, IHaveLongValue_Double, IHaveMapOfIoTTwinMakerEntityTypesDataValueMapValue, IHaveIoTTwinMakerEntityTypesRelationshipValueRelationshipValue, IHaveStringValue
        {
            /// <summary>
            /// DoubleValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iottwinmaker-entity-datavalue.html#cfn-iottwinmaker-entity-datavalue-doublevalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? DoubleValue { get; set; }
            /// <summary>
            /// Expression
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iottwinmaker-entity-datavalue.html#cfn-iottwinmaker-entity-datavalue-expression
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Expression { get; set; }
            /// <summary>
            /// BooleanValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iottwinmaker-entity-datavalue.html#cfn-iottwinmaker-entity-datavalue-booleanvalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? BooleanValue { get; set; }
            /// <summary>
            /// IntegerValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iottwinmaker-entity-datavalue.html#cfn-iottwinmaker-entity-datavalue-integervalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? IntegerValue { get; set; }
            /// <summary>
            /// ListValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iottwinmaker-entity-datavalue.html#cfn-iottwinmaker-entity-datavalue-listvalue
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DataValue
            /// </summary>
            public Union<IReadOnlyList<Humidifier.IoTTwinMaker.EntityTypes.DataValue>, IReadOnlyList<Union<Humidifier.IoTTwinMaker.EntityTypes.DataValue, BaseFunction>>, BaseFunction>? ListValue { get; set; }
            /// <summary>
            /// LongValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iottwinmaker-entity-datavalue.html#cfn-iottwinmaker-entity-datavalue-longvalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? LongValue { get; set; }
            /// <summary>
            /// MapValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iottwinmaker-entity-datavalue.html#cfn-iottwinmaker-entity-datavalue-mapvalue
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// ItemType: DataValue
            /// </summary>
            public Union<IReadOnlyDictionary<string, Humidifier.IoTTwinMaker.EntityTypes.DataValue>, IReadOnlyDictionary<string, Union<Humidifier.IoTTwinMaker.EntityTypes.DataValue, BaseFunction>>, BaseFunction>? MapValue { get; set; }
            /// <summary>
            /// RelationshipValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iottwinmaker-entity-datavalue.html#cfn-iottwinmaker-entity-datavalue-relationshipvalue
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RelationshipValue
            /// </summary>
            public Union<Humidifier.IoTTwinMaker.EntityTypes.RelationshipValue, BaseFunction>? RelationshipValue { get; set; }
            /// <summary>
            /// StringValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iottwinmaker-entity-datavalue.html#cfn-iottwinmaker-entity-datavalue-stringvalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? StringValue { get; set; }
        }

        public class Definition : Humidifier.Base.BaseSubResource, IHaveIoTTwinMakerEntityTypesDataValueDefaultValue, IHaveIsImported_Boolean, IHaveIsInherited_Boolean, IHaveStringDictionaryOfConfiguration, IHaveIsExternalId_Boolean, IHaveIsStoredExternally_Boolean, IHaveIsTimeSeries_Boolean, IHaveIsRequiredInEntity_Boolean, IHaveIoTTwinMakerEntityTypesDataTypeDataType, IHaveIsFinal_Boolean
        {
            /// <summary>
            /// DefaultValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iottwinmaker-entity-definition.html#cfn-iottwinmaker-entity-definition-defaultvalue
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DataValue
            /// </summary>
            public Union<Humidifier.IoTTwinMaker.EntityTypes.DataValue, BaseFunction>? DefaultValue { get; set; }
            /// <summary>
            /// IsImported
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iottwinmaker-entity-definition.html#cfn-iottwinmaker-entity-definition-isimported
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? IsImported { get; set; }
            /// <summary>
            /// IsInherited
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iottwinmaker-entity-definition.html#cfn-iottwinmaker-entity-definition-isinherited
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? IsInherited { get; set; }
            /// <summary>
            /// Configuration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iottwinmaker-entity-definition.html#cfn-iottwinmaker-entity-definition-configuration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? Configuration { get; set; }
            /// <summary>
            /// IsExternalId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iottwinmaker-entity-definition.html#cfn-iottwinmaker-entity-definition-isexternalid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? IsExternalId { get; set; }
            /// <summary>
            /// IsStoredExternally
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iottwinmaker-entity-definition.html#cfn-iottwinmaker-entity-definition-isstoredexternally
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? IsStoredExternally { get; set; }
            /// <summary>
            /// IsTimeSeries
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iottwinmaker-entity-definition.html#cfn-iottwinmaker-entity-definition-istimeseries
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? IsTimeSeries { get; set; }
            /// <summary>
            /// IsRequiredInEntity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iottwinmaker-entity-definition.html#cfn-iottwinmaker-entity-definition-isrequiredinentity
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? IsRequiredInEntity { get; set; }
            /// <summary>
            /// DataType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iottwinmaker-entity-definition.html#cfn-iottwinmaker-entity-definition-datatype
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DataType
            /// </summary>
            public Union<Humidifier.IoTTwinMaker.EntityTypes.DataType, BaseFunction>? DataType { get; set; }
            /// <summary>
            /// IsFinal
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iottwinmaker-entity-definition.html#cfn-iottwinmaker-entity-definition-isfinal
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? IsFinal { get; set; }
        }

        public class Error : Humidifier.Base.BaseSubResource, IHaveMessage, IHaveCode
        {
            /// <summary>
            /// Message
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iottwinmaker-entity-error.html#cfn-iottwinmaker-entity-error-message
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Message { get; set; }
            /// <summary>
            /// Code
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iottwinmaker-entity-error.html#cfn-iottwinmaker-entity-error-code
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Code { get; set; }
        }

        public class Property : Humidifier.Base.BaseSubResource, IHaveIoTTwinMakerEntityTypesDefinitionDefinition, IHaveIoTTwinMakerEntityTypesDataValueValue
        {
            /// <summary>
            /// Definition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iottwinmaker-entity-property.html#cfn-iottwinmaker-entity-property-definition
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Definition
            /// </summary>
            public Union<Humidifier.IoTTwinMaker.EntityTypes.Definition, BaseFunction>? Definition { get; set; }
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iottwinmaker-entity-property.html#cfn-iottwinmaker-entity-property-value
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DataValue
            /// </summary>
            public Union<Humidifier.IoTTwinMaker.EntityTypes.DataValue, BaseFunction>? Value { get; set; }
        }

        public class PropertyGroup : Humidifier.Base.BaseSubResource, IHaveGroupType, IHaveStringListOfPropertyNames
        {
            /// <summary>
            /// GroupType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iottwinmaker-entity-propertygroup.html#cfn-iottwinmaker-entity-propertygroup-grouptype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? GroupType { get; set; }
            /// <summary>
            /// PropertyNames
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iottwinmaker-entity-propertygroup.html#cfn-iottwinmaker-entity-propertygroup-propertynames
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? PropertyNames { get; set; }
        }

        public class Relationship : Humidifier.Base.BaseSubResource, IHaveRelationshipType, IHaveTargetComponentTypeId
        {
            /// <summary>
            /// RelationshipType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iottwinmaker-entity-relationship.html#cfn-iottwinmaker-entity-relationship-relationshiptype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RelationshipType { get; set; }
            /// <summary>
            /// TargetComponentTypeId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iottwinmaker-entity-relationship.html#cfn-iottwinmaker-entity-relationship-targetcomponenttypeid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TargetComponentTypeId { get; set; }
        }

        public class RelationshipValue : Humidifier.Base.BaseSubResource, IHaveTargetComponentName, IHaveTargetEntityId
        {
            /// <summary>
            /// TargetComponentName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iottwinmaker-entity-relationshipvalue.html#cfn-iottwinmaker-entity-relationshipvalue-targetcomponentname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TargetComponentName { get; set; }
            /// <summary>
            /// TargetEntityId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iottwinmaker-entity-relationshipvalue.html#cfn-iottwinmaker-entity-relationshipvalue-targetentityid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TargetEntityId { get; set; }
        }

        public class Status : Humidifier.Base.BaseSubResource, IHaveIoTTwinMakerEntityTypesErrorError, IHaveState
        {
            /// <summary>
            /// Error
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iottwinmaker-entity-status.html#cfn-iottwinmaker-entity-status-error
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Error
            /// </summary>
            public Union<Humidifier.IoTTwinMaker.EntityTypes.Error, BaseFunction>? Error { get; set; }
            /// <summary>
            /// State
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iottwinmaker-entity-status.html#cfn-iottwinmaker-entity-status-state
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? State { get; set; }
        }
    }
}