namespace Humidifier.IoTEvents
{
    using System.Collections.Generic;
    using InputTypes;

    public class Input : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveInputName, IHaveDescription
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
        public Humidifier.IoTEvents.InputTypes.InputDefinition InputDefinition { get; set; }
        public dynamic InputName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// InputDescription
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotevents-input.html#cfn-iotevents-input-inputdescription
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic InputDescription { get; set; }

        [Ignore]
        public dynamic Description { get => InputDescription; set => InputDescription = value; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotevents-input.html#cfn-iotevents-input-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
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
            public dynamic JsonPath { get; set; }
        }

        public class InputDefinition : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Attributes_
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-input-inputdefinition.html#cfn-iotevents-input-inputdefinition-attributes
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Attribute
            /// </summary>
            public List<Humidifier.IoTEvents.InputTypes.Attribute> Attributes_ { get; set; }
        }
    }
}