namespace Humidifier.AmplifyUIBuilder
{
    using global::System.Collections.Generic;
    using ComponentTypes;

    public class Component : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveComponentType, IHaveSchemaVersion, IHaveEnvironmentName, IHaveMapOfAmplifyUIBuilderComponentTypesComponentBindingPropertiesValueBindingProperties, IHaveSourceId, IHaveMapOfAmplifyUIBuilderComponentTypesComponentPropertyProperties, IHaveMapOfAmplifyUIBuilderComponentTypesComponentDataConfigurationCollectionProperties, IHaveName, IHaveListOfAmplifyUIBuilderComponentTypesComponentVariantVariants, IHaveAppId, IHaveMapOfAmplifyUIBuilderComponentTypesComponentEventEvents, IHaveOverrides_Json, IHaveListOfAmplifyUIBuilderComponentTypesComponentChildChildren, IHaveStringDictionaryOfTags
    {
        public class Attributes
        {
            public static string ModifiedAt =  "ModifiedAt" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string Id =  "Id" ;
        }

        public override string AWSTypeName { get => AWS.AmplifyUIBuilder.Component; }
        /// <summary>
        /// ComponentType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-amplifyuibuilder-component.html#cfn-amplifyuibuilder-component-componenttype
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ComponentType { get; set; }
        /// <summary>
        /// SchemaVersion
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-amplifyuibuilder-component.html#cfn-amplifyuibuilder-component-schemaversion
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? SchemaVersion { get; set; }
        /// <summary>
        /// EnvironmentName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-amplifyuibuilder-component.html#cfn-amplifyuibuilder-component-environmentname
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? EnvironmentName { get; set; }
        /// <summary>
        /// BindingProperties
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-amplifyuibuilder-component.html#cfn-amplifyuibuilder-component-bindingproperties
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// ItemType: ComponentBindingPropertiesValue
        /// </summary>
        public Union<IReadOnlyDictionary<string, Humidifier.AmplifyUIBuilder.ComponentTypes.ComponentBindingPropertiesValue>, IReadOnlyDictionary<string, Union<Humidifier.AmplifyUIBuilder.ComponentTypes.ComponentBindingPropertiesValue, BaseFunction>>, BaseFunction>? BindingProperties { get; set; }
        /// <summary>
        /// SourceId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-amplifyuibuilder-component.html#cfn-amplifyuibuilder-component-sourceid
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? SourceId { get; set; }
        /// <summary>
        /// Properties
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-amplifyuibuilder-component.html#cfn-amplifyuibuilder-component-properties
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// ItemType: ComponentProperty
        /// </summary>
        public Union<IReadOnlyDictionary<string, Humidifier.AmplifyUIBuilder.ComponentTypes.ComponentProperty>, IReadOnlyDictionary<string, Union<Humidifier.AmplifyUIBuilder.ComponentTypes.ComponentProperty, BaseFunction>>, BaseFunction>? Properties { get; set; }
        /// <summary>
        /// CollectionProperties
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-amplifyuibuilder-component.html#cfn-amplifyuibuilder-component-collectionproperties
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// ItemType: ComponentDataConfiguration
        /// </summary>
        public Union<IReadOnlyDictionary<string, Humidifier.AmplifyUIBuilder.ComponentTypes.ComponentDataConfiguration>, IReadOnlyDictionary<string, Union<Humidifier.AmplifyUIBuilder.ComponentTypes.ComponentDataConfiguration, BaseFunction>>, BaseFunction>? CollectionProperties { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// Variants
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-amplifyuibuilder-component.html#cfn-amplifyuibuilder-component-variants
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: ComponentVariant
        /// </summary>
        public Union<IReadOnlyList<Humidifier.AmplifyUIBuilder.ComponentTypes.ComponentVariant>, IReadOnlyList<Union<Humidifier.AmplifyUIBuilder.ComponentTypes.ComponentVariant, BaseFunction>>, BaseFunction>? Variants { get; set; }
        /// <summary>
        /// AppId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-amplifyuibuilder-component.html#cfn-amplifyuibuilder-component-appid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? AppId { get; set; }
        /// <summary>
        /// Events
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-amplifyuibuilder-component.html#cfn-amplifyuibuilder-component-events
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// ItemType: ComponentEvent
        /// </summary>
        public Union<IReadOnlyDictionary<string, Humidifier.AmplifyUIBuilder.ComponentTypes.ComponentEvent>, IReadOnlyDictionary<string, Union<Humidifier.AmplifyUIBuilder.ComponentTypes.ComponentEvent, BaseFunction>>, BaseFunction>? Events { get; set; }
        /// <summary>
        /// Overrides
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-amplifyuibuilder-component.html#cfn-amplifyuibuilder-component-overrides
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Json
        /// </summary>
        public Union<object, BaseFunction>? Overrides { get; set; }
        /// <summary>
        /// Children
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-amplifyuibuilder-component.html#cfn-amplifyuibuilder-component-children
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: ComponentChild
        /// </summary>
        public Union<IReadOnlyList<Humidifier.AmplifyUIBuilder.ComponentTypes.ComponentChild>, IReadOnlyList<Union<Humidifier.AmplifyUIBuilder.ComponentTypes.ComponentChild, BaseFunction>>, BaseFunction>? Children { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-amplifyuibuilder-component.html#cfn-amplifyuibuilder-component-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace ComponentTypes
    {
        public class ActionParameters : Humidifier.Base.BaseSubResource, IHaveAmplifyUIBuilderComponentTypesComponentPropertyType, IHaveAmplifyUIBuilderComponentTypesComponentPropertyAnchor, IHaveAmplifyUIBuilderComponentTypesComponentPropertyTarget, IHaveMapOfAmplifyUIBuilderComponentTypesComponentPropertyFields, IHaveAmplifyUIBuilderComponentTypesMutationActionSetStateParameterState, IHaveModel, IHaveAmplifyUIBuilderComponentTypesComponentPropertyId, IHaveAmplifyUIBuilderComponentTypesComponentPropertyUrl, IHaveAmplifyUIBuilderComponentTypesComponentPropertyGlobal
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplifyuibuilder-component-actionparameters.html#cfn-amplifyuibuilder-component-actionparameters-type
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ComponentProperty
            /// </summary>
            public Union<Humidifier.AmplifyUIBuilder.ComponentTypes.ComponentProperty, BaseFunction>? Type { get; set; }
            /// <summary>
            /// Anchor
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplifyuibuilder-component-actionparameters.html#cfn-amplifyuibuilder-component-actionparameters-anchor
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ComponentProperty
            /// </summary>
            public Union<Humidifier.AmplifyUIBuilder.ComponentTypes.ComponentProperty, BaseFunction>? Anchor { get; set; }
            /// <summary>
            /// Target
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplifyuibuilder-component-actionparameters.html#cfn-amplifyuibuilder-component-actionparameters-target
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ComponentProperty
            /// </summary>
            public Union<Humidifier.AmplifyUIBuilder.ComponentTypes.ComponentProperty, BaseFunction>? Target { get; set; }
            /// <summary>
            /// Fields
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplifyuibuilder-component-actionparameters.html#cfn-amplifyuibuilder-component-actionparameters-fields
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// ItemType: ComponentProperty
            /// </summary>
            public Union<IReadOnlyDictionary<string, Humidifier.AmplifyUIBuilder.ComponentTypes.ComponentProperty>, IReadOnlyDictionary<string, Union<Humidifier.AmplifyUIBuilder.ComponentTypes.ComponentProperty, BaseFunction>>, BaseFunction>? Fields { get; set; }
            /// <summary>
            /// State
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplifyuibuilder-component-actionparameters.html#cfn-amplifyuibuilder-component-actionparameters-state
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MutationActionSetStateParameter
            /// </summary>
            public Union<Humidifier.AmplifyUIBuilder.ComponentTypes.MutationActionSetStateParameter, BaseFunction>? State { get; set; }
            /// <summary>
            /// Model
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplifyuibuilder-component-actionparameters.html#cfn-amplifyuibuilder-component-actionparameters-model
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Model { get; set; }
            /// <summary>
            /// Id
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplifyuibuilder-component-actionparameters.html#cfn-amplifyuibuilder-component-actionparameters-id
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ComponentProperty
            /// </summary>
            public Union<Humidifier.AmplifyUIBuilder.ComponentTypes.ComponentProperty, BaseFunction>? Id { get; set; }
            /// <summary>
            /// Url
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplifyuibuilder-component-actionparameters.html#cfn-amplifyuibuilder-component-actionparameters-url
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ComponentProperty
            /// </summary>
            public Union<Humidifier.AmplifyUIBuilder.ComponentTypes.ComponentProperty, BaseFunction>? Url { get; set; }
            /// <summary>
            /// Global
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplifyuibuilder-component-actionparameters.html#cfn-amplifyuibuilder-component-actionparameters-global
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ComponentProperty
            /// </summary>
            public Union<Humidifier.AmplifyUIBuilder.ComponentTypes.ComponentProperty, BaseFunction>? Global { get; set; }
        }

        public class ComponentBindingPropertiesValue : Humidifier.Base.BaseSubResource, IHaveDefaultValue, IHaveType, IHaveAmplifyUIBuilderComponentTypesComponentBindingPropertiesValuePropertiesBindingProperties
        {
            /// <summary>
            /// DefaultValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplifyuibuilder-component-componentbindingpropertiesvalue.html#cfn-amplifyuibuilder-component-componentbindingpropertiesvalue-defaultvalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DefaultValue { get; set; }
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplifyuibuilder-component-componentbindingpropertiesvalue.html#cfn-amplifyuibuilder-component-componentbindingpropertiesvalue-type
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// BindingProperties
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplifyuibuilder-component-componentbindingpropertiesvalue.html#cfn-amplifyuibuilder-component-componentbindingpropertiesvalue-bindingproperties
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ComponentBindingPropertiesValueProperties
            /// </summary>
            public Union<Humidifier.AmplifyUIBuilder.ComponentTypes.ComponentBindingPropertiesValueProperties, BaseFunction>? BindingProperties { get; set; }
        }

        public class ComponentBindingPropertiesValueProperties : Humidifier.Base.BaseSubResource, IHaveField, IHaveDefaultValue, IHaveBucket, IHaveUserAttribute, IHaveModel, IHaveListOfAmplifyUIBuilderComponentTypesPredicatePredicates, IHaveSlotName, IHaveKey
        {
            /// <summary>
            /// Field
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplifyuibuilder-component-componentbindingpropertiesvalueproperties.html#cfn-amplifyuibuilder-component-componentbindingpropertiesvalueproperties-field
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Field { get; set; }
            /// <summary>
            /// DefaultValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplifyuibuilder-component-componentbindingpropertiesvalueproperties.html#cfn-amplifyuibuilder-component-componentbindingpropertiesvalueproperties-defaultvalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DefaultValue { get; set; }
            /// <summary>
            /// Bucket
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplifyuibuilder-component-componentbindingpropertiesvalueproperties.html#cfn-amplifyuibuilder-component-componentbindingpropertiesvalueproperties-bucket
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Bucket { get; set; }
            /// <summary>
            /// UserAttribute
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplifyuibuilder-component-componentbindingpropertiesvalueproperties.html#cfn-amplifyuibuilder-component-componentbindingpropertiesvalueproperties-userattribute
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UserAttribute { get; set; }
            /// <summary>
            /// Model
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplifyuibuilder-component-componentbindingpropertiesvalueproperties.html#cfn-amplifyuibuilder-component-componentbindingpropertiesvalueproperties-model
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Model { get; set; }
            /// <summary>
            /// Predicates
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplifyuibuilder-component-componentbindingpropertiesvalueproperties.html#cfn-amplifyuibuilder-component-componentbindingpropertiesvalueproperties-predicates
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Predicate
            /// </summary>
            public Union<IReadOnlyList<Humidifier.AmplifyUIBuilder.ComponentTypes.Predicate>, IReadOnlyList<Union<Humidifier.AmplifyUIBuilder.ComponentTypes.Predicate, BaseFunction>>, BaseFunction>? Predicates { get; set; }
            /// <summary>
            /// SlotName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplifyuibuilder-component-componentbindingpropertiesvalueproperties.html#cfn-amplifyuibuilder-component-componentbindingpropertiesvalueproperties-slotname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SlotName { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplifyuibuilder-component-componentbindingpropertiesvalueproperties.html#cfn-amplifyuibuilder-component-componentbindingpropertiesvalueproperties-key
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Key { get; set; }
        }

        public class ComponentChild : Humidifier.Base.BaseSubResource, IHaveComponentType, IHaveListOfAmplifyUIBuilderComponentTypesComponentChildChildren, IHaveMapOfAmplifyUIBuilderComponentTypesComponentPropertyProperties, IHaveMapOfAmplifyUIBuilderComponentTypesComponentEventEvents, IHaveSourceId, IHaveName
        {
            /// <summary>
            /// ComponentType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplifyuibuilder-component-componentchild.html#cfn-amplifyuibuilder-component-componentchild-componenttype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ComponentType { get; set; }
            /// <summary>
            /// Children
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplifyuibuilder-component-componentchild.html#cfn-amplifyuibuilder-component-componentchild-children
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ComponentChild
            /// </summary>
            public Union<IReadOnlyList<Humidifier.AmplifyUIBuilder.ComponentTypes.ComponentChild>, IReadOnlyList<Union<Humidifier.AmplifyUIBuilder.ComponentTypes.ComponentChild, BaseFunction>>, BaseFunction>? Children { get; set; }
            /// <summary>
            /// Properties
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplifyuibuilder-component-componentchild.html#cfn-amplifyuibuilder-component-componentchild-properties
            /// Required: True
            /// UpdateType: Mutable
            /// Type: Map
            /// ItemType: ComponentProperty
            /// </summary>
            public Union<IReadOnlyDictionary<string, Humidifier.AmplifyUIBuilder.ComponentTypes.ComponentProperty>, IReadOnlyDictionary<string, Union<Humidifier.AmplifyUIBuilder.ComponentTypes.ComponentProperty, BaseFunction>>, BaseFunction>? Properties { get; set; }
            /// <summary>
            /// Events
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplifyuibuilder-component-componentchild.html#cfn-amplifyuibuilder-component-componentchild-events
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// ItemType: ComponentEvent
            /// </summary>
            public Union<IReadOnlyDictionary<string, Humidifier.AmplifyUIBuilder.ComponentTypes.ComponentEvent>, IReadOnlyDictionary<string, Union<Humidifier.AmplifyUIBuilder.ComponentTypes.ComponentEvent, BaseFunction>>, BaseFunction>? Events { get; set; }
            /// <summary>
            /// SourceId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplifyuibuilder-component-componentchild.html#cfn-amplifyuibuilder-component-componentchild-sourceid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SourceId { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplifyuibuilder-component-componentchild.html#cfn-amplifyuibuilder-component-componentchild-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class ComponentConditionProperty : Humidifier.Base.BaseSubResource, IHaveOperator, IHaveField, IHaveOperand, IHaveOperandType, IHaveAmplifyUIBuilderComponentTypesComponentPropertyElse, IHaveAmplifyUIBuilderComponentTypesComponentPropertyThen, IHaveProperty
        {
            /// <summary>
            /// Operator
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplifyuibuilder-component-componentconditionproperty.html#cfn-amplifyuibuilder-component-componentconditionproperty-operator
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Operator { get; set; }
            /// <summary>
            /// Field
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplifyuibuilder-component-componentconditionproperty.html#cfn-amplifyuibuilder-component-componentconditionproperty-field
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Field { get; set; }
            /// <summary>
            /// Operand
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplifyuibuilder-component-componentconditionproperty.html#cfn-amplifyuibuilder-component-componentconditionproperty-operand
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Operand { get; set; }
            /// <summary>
            /// OperandType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplifyuibuilder-component-componentconditionproperty.html#cfn-amplifyuibuilder-component-componentconditionproperty-operandtype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? OperandType { get; set; }
            /// <summary>
            /// Else
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplifyuibuilder-component-componentconditionproperty.html#cfn-amplifyuibuilder-component-componentconditionproperty-else
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ComponentProperty
            /// </summary>
            public Union<Humidifier.AmplifyUIBuilder.ComponentTypes.ComponentProperty, BaseFunction>? Else { get; set; }
            /// <summary>
            /// Then
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplifyuibuilder-component-componentconditionproperty.html#cfn-amplifyuibuilder-component-componentconditionproperty-then
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ComponentProperty
            /// </summary>
            public Union<Humidifier.AmplifyUIBuilder.ComponentTypes.ComponentProperty, BaseFunction>? Then { get; set; }
            /// <summary>
            /// Property
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplifyuibuilder-component-componentconditionproperty.html#cfn-amplifyuibuilder-component-componentconditionproperty-property
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Property { get; set; }
        }

        public class ComponentDataConfiguration : Humidifier.Base.BaseSubResource, IHaveModel, IHaveListOfAmplifyUIBuilderComponentTypesSortPropertySort, IHaveStringListOfIdentifiers, IHaveAmplifyUIBuilderComponentTypesPredicatePredicate
        {
            /// <summary>
            /// Model
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplifyuibuilder-component-componentdataconfiguration.html#cfn-amplifyuibuilder-component-componentdataconfiguration-model
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Model { get; set; }
            /// <summary>
            /// Sort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplifyuibuilder-component-componentdataconfiguration.html#cfn-amplifyuibuilder-component-componentdataconfiguration-sort
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: SortProperty
            /// </summary>
            public Union<IReadOnlyList<Humidifier.AmplifyUIBuilder.ComponentTypes.SortProperty>, IReadOnlyList<Union<Humidifier.AmplifyUIBuilder.ComponentTypes.SortProperty, BaseFunction>>, BaseFunction>? Sort { get; set; }
            /// <summary>
            /// Identifiers
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplifyuibuilder-component-componentdataconfiguration.html#cfn-amplifyuibuilder-component-componentdataconfiguration-identifiers
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Identifiers { get; set; }
            /// <summary>
            /// Predicate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplifyuibuilder-component-componentdataconfiguration.html#cfn-amplifyuibuilder-component-componentdataconfiguration-predicate
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Predicate
            /// </summary>
            public Union<Humidifier.AmplifyUIBuilder.ComponentTypes.Predicate, BaseFunction>? Predicate { get; set; }
        }

        public class ComponentEvent : Humidifier.Base.BaseSubResource, IHaveAction, IHaveBindingEvent, IHaveAmplifyUIBuilderComponentTypesActionParametersParameters
        {
            /// <summary>
            /// Action
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplifyuibuilder-component-componentevent.html#cfn-amplifyuibuilder-component-componentevent-action
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Action { get; set; }
            /// <summary>
            /// BindingEvent
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplifyuibuilder-component-componentevent.html#cfn-amplifyuibuilder-component-componentevent-bindingevent
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BindingEvent { get; set; }
            /// <summary>
            /// Parameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplifyuibuilder-component-componentevent.html#cfn-amplifyuibuilder-component-componentevent-parameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ActionParameters
            /// </summary>
            public Union<Humidifier.AmplifyUIBuilder.ComponentTypes.ActionParameters, BaseFunction>? Parameters { get; set; }
        }

        public class ComponentProperty : Humidifier.Base.BaseSubResource, IHaveAmplifyUIBuilderComponentTypesComponentConditionPropertyCondition, IHaveUserAttribute, IHaveImportedValue, IHaveAmplifyUIBuilderComponentTypesComponentPropertyBindingPropertiesBindingProperties, IHaveMapOfAmplifyUIBuilderComponentTypesFormBindingElementBindings, IHaveConfigured_Boolean, IHaveListOfAmplifyUIBuilderComponentTypesComponentPropertyConcat, IHaveDefaultValue, IHaveType, IHaveValue, IHaveModel, IHaveAmplifyUIBuilderComponentTypesComponentPropertyBindingPropertiesCollectionBindingProperties, IHaveEvent, IHaveComponentName, IHaveProperty
        {
            /// <summary>
            /// Condition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplifyuibuilder-component-componentproperty.html#cfn-amplifyuibuilder-component-componentproperty-condition
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ComponentConditionProperty
            /// </summary>
            public Union<Humidifier.AmplifyUIBuilder.ComponentTypes.ComponentConditionProperty, BaseFunction>? Condition { get; set; }
            /// <summary>
            /// UserAttribute
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplifyuibuilder-component-componentproperty.html#cfn-amplifyuibuilder-component-componentproperty-userattribute
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UserAttribute { get; set; }
            /// <summary>
            /// ImportedValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplifyuibuilder-component-componentproperty.html#cfn-amplifyuibuilder-component-componentproperty-importedvalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ImportedValue { get; set; }
            /// <summary>
            /// BindingProperties
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplifyuibuilder-component-componentproperty.html#cfn-amplifyuibuilder-component-componentproperty-bindingproperties
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ComponentPropertyBindingProperties
            /// </summary>
            public Union<Humidifier.AmplifyUIBuilder.ComponentTypes.ComponentPropertyBindingProperties, BaseFunction>? BindingProperties { get; set; }
            /// <summary>
            /// Bindings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplifyuibuilder-component-componentproperty.html#cfn-amplifyuibuilder-component-componentproperty-bindings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// ItemType: FormBindingElement
            /// </summary>
            public Union<IReadOnlyDictionary<string, Humidifier.AmplifyUIBuilder.ComponentTypes.FormBindingElement>, IReadOnlyDictionary<string, Union<Humidifier.AmplifyUIBuilder.ComponentTypes.FormBindingElement, BaseFunction>>, BaseFunction>? Bindings { get; set; }
            /// <summary>
            /// Configured
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplifyuibuilder-component-componentproperty.html#cfn-amplifyuibuilder-component-componentproperty-configured
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Configured { get; set; }
            /// <summary>
            /// Concat
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplifyuibuilder-component-componentproperty.html#cfn-amplifyuibuilder-component-componentproperty-concat
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ComponentProperty
            /// </summary>
            public Union<IReadOnlyList<Humidifier.AmplifyUIBuilder.ComponentTypes.ComponentProperty>, IReadOnlyList<Union<Humidifier.AmplifyUIBuilder.ComponentTypes.ComponentProperty, BaseFunction>>, BaseFunction>? Concat { get; set; }
            /// <summary>
            /// DefaultValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplifyuibuilder-component-componentproperty.html#cfn-amplifyuibuilder-component-componentproperty-defaultvalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DefaultValue { get; set; }
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplifyuibuilder-component-componentproperty.html#cfn-amplifyuibuilder-component-componentproperty-type
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplifyuibuilder-component-componentproperty.html#cfn-amplifyuibuilder-component-componentproperty-value
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Model
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplifyuibuilder-component-componentproperty.html#cfn-amplifyuibuilder-component-componentproperty-model
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Model { get; set; }
            /// <summary>
            /// CollectionBindingProperties
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplifyuibuilder-component-componentproperty.html#cfn-amplifyuibuilder-component-componentproperty-collectionbindingproperties
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ComponentPropertyBindingProperties
            /// </summary>
            public Union<Humidifier.AmplifyUIBuilder.ComponentTypes.ComponentPropertyBindingProperties, BaseFunction>? CollectionBindingProperties { get; set; }
            /// <summary>
            /// Event
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplifyuibuilder-component-componentproperty.html#cfn-amplifyuibuilder-component-componentproperty-event
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Event { get; set; }
            /// <summary>
            /// ComponentName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplifyuibuilder-component-componentproperty.html#cfn-amplifyuibuilder-component-componentproperty-componentname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ComponentName { get; set; }
            /// <summary>
            /// Property
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplifyuibuilder-component-componentproperty.html#cfn-amplifyuibuilder-component-componentproperty-property
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Property { get; set; }
        }

        public class ComponentPropertyBindingProperties : Humidifier.Base.BaseSubResource, IHaveField, IHaveProperty
        {
            /// <summary>
            /// Field
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplifyuibuilder-component-componentpropertybindingproperties.html#cfn-amplifyuibuilder-component-componentpropertybindingproperties-field
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Field { get; set; }
            /// <summary>
            /// Property
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplifyuibuilder-component-componentpropertybindingproperties.html#cfn-amplifyuibuilder-component-componentpropertybindingproperties-property
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Property { get; set; }
        }

        public class ComponentVariant : Humidifier.Base.BaseSubResource, IHaveStringDictionaryOfVariantValues, IHaveOverrides_Json
        {
            /// <summary>
            /// VariantValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplifyuibuilder-component-componentvariant.html#cfn-amplifyuibuilder-component-componentvariant-variantvalues
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? VariantValues { get; set; }
            /// <summary>
            /// Overrides
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplifyuibuilder-component-componentvariant.html#cfn-amplifyuibuilder-component-componentvariant-overrides
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? Overrides { get; set; }
        }

        public class FormBindingElement : Humidifier.Base.BaseSubResource, IHaveElement, IHaveProperty
        {
            /// <summary>
            /// Element
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplifyuibuilder-component-formbindingelement.html#cfn-amplifyuibuilder-component-formbindingelement-element
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Element { get; set; }
            /// <summary>
            /// Property
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplifyuibuilder-component-formbindingelement.html#cfn-amplifyuibuilder-component-formbindingelement-property
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Property { get; set; }
        }

        public class MutationActionSetStateParameter : Humidifier.Base.BaseSubResource, IHaveAmplifyUIBuilderComponentTypesComponentPropertySet, IHaveComponentName, IHaveProperty
        {
            /// <summary>
            /// Set
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplifyuibuilder-component-mutationactionsetstateparameter.html#cfn-amplifyuibuilder-component-mutationactionsetstateparameter-set
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ComponentProperty
            /// </summary>
            public Union<Humidifier.AmplifyUIBuilder.ComponentTypes.ComponentProperty, BaseFunction>? Set { get; set; }
            /// <summary>
            /// ComponentName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplifyuibuilder-component-mutationactionsetstateparameter.html#cfn-amplifyuibuilder-component-mutationactionsetstateparameter-componentname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ComponentName { get; set; }
            /// <summary>
            /// Property
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplifyuibuilder-component-mutationactionsetstateparameter.html#cfn-amplifyuibuilder-component-mutationactionsetstateparameter-property
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Property { get; set; }
        }

        public class Predicate : Humidifier.Base.BaseSubResource, IHaveOperator, IHaveField, IHaveListOfAmplifyUIBuilderComponentTypesPredicateOr, IHaveListOfAmplifyUIBuilderComponentTypesPredicateAnd, IHaveOperand, IHaveOperandType
        {
            /// <summary>
            /// Operator
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplifyuibuilder-component-predicate.html#cfn-amplifyuibuilder-component-predicate-operator
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Operator { get; set; }
            /// <summary>
            /// Field
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplifyuibuilder-component-predicate.html#cfn-amplifyuibuilder-component-predicate-field
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Field { get; set; }
            /// <summary>
            /// Or
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplifyuibuilder-component-predicate.html#cfn-amplifyuibuilder-component-predicate-or
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Predicate
            /// </summary>
            public Union<IReadOnlyList<Humidifier.AmplifyUIBuilder.ComponentTypes.Predicate>, IReadOnlyList<Union<Humidifier.AmplifyUIBuilder.ComponentTypes.Predicate, BaseFunction>>, BaseFunction>? Or { get; set; }
            /// <summary>
            /// And
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplifyuibuilder-component-predicate.html#cfn-amplifyuibuilder-component-predicate-and
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Predicate
            /// </summary>
            public Union<IReadOnlyList<Humidifier.AmplifyUIBuilder.ComponentTypes.Predicate>, IReadOnlyList<Union<Humidifier.AmplifyUIBuilder.ComponentTypes.Predicate, BaseFunction>>, BaseFunction>? And { get; set; }
            /// <summary>
            /// Operand
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplifyuibuilder-component-predicate.html#cfn-amplifyuibuilder-component-predicate-operand
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Operand { get; set; }
            /// <summary>
            /// OperandType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplifyuibuilder-component-predicate.html#cfn-amplifyuibuilder-component-predicate-operandtype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? OperandType { get; set; }
        }

        public class SortProperty : Humidifier.Base.BaseSubResource, IHaveField, IHaveDirection
        {
            /// <summary>
            /// Field
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplifyuibuilder-component-sortproperty.html#cfn-amplifyuibuilder-component-sortproperty-field
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Field { get; set; }
            /// <summary>
            /// Direction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplifyuibuilder-component-sortproperty.html#cfn-amplifyuibuilder-component-sortproperty-direction
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Direction { get; set; }
        }
    }
}