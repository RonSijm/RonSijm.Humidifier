namespace Humidifier.IoTEvents
{
    using global::System.Collections.Generic;
    using InputTypes;

    public class Input : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveIoTEventsInputTypesInputDefinitionInputDefinition, IHaveInputName, IHaveInputDescription, IHaveDescription
    {
        public override string AWSTypeName { get => AWS.IoTEvents.Input; }

        /// <summary>
        /// InputDefinition
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotevents-input.html#cfn-iotevents-input-inputdefinition
        /// Required: True
        /// UpdateType: Mutable
        /// Type: InputDefinition
        /// </summary>
        [Required]
        public Union<Humidifier.IoTEvents.InputTypes.InputDefinition, BaseFunction>? InputDefinition { get; set; }
        public Union<string, BaseFunction>? InputName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// InputDescription
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotevents-input.html#cfn-iotevents-input-inputdescription
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? InputDescription { get; set; }

        [Ignore]
        public Union<string, BaseFunction>? Description { get => InputDescription; set => InputDescription = value; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotevents-input.html#cfn-iotevents-input-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace InputTypes
    {
        public class Attribute : Humidifier.Base.BaseSubResource, IHaveJsonPath
        {
            /// <summary>
            /// JsonPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-input-attribute.html#cfn-iotevents-input-attribute-jsonpath
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? JsonPath { get; set; }
        }

        public class InputDefinition : Humidifier.Base.BaseSubResource, IHaveListOfIoTEventsInputTypesAttributeAttributes_
        {
            /// <summary>
            /// Attributes_
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-input-inputdefinition.html#cfn-iotevents-input-inputdefinition-attributes
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Attribute
            /// </summary>
            public Union<IReadOnlyList<Humidifier.IoTEvents.InputTypes.Attribute>, IReadOnlyList<Union<Humidifier.IoTEvents.InputTypes.Attribute, BaseFunction>>, BaseFunction>? Attributes_ { get; set; }
        }
    }
}