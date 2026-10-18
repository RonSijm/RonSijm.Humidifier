namespace Humidifier.IoT
{
    using global::System.Collections.Generic;
    using ThingTypeTypes;

    public class ThingType : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveDeprecateThingType_Boolean, IHaveThingTypeName, IHaveIoTThingTypeTypesThingTypePropertiesThingTypeProperties
    {
        public class Attributes
        {
            public static string Id =  "Id" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.IoT.ThingType; }
        /// <summary>
        /// DeprecateThingType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-thingtype.html#cfn-iot-thingtype-deprecatethingtype
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? DeprecateThingType { get; set; }
        public Union<string, BaseFunction>? ThingTypeName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// ThingTypeProperties
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-thingtype.html#cfn-iot-thingtype-thingtypeproperties
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ThingTypeProperties
        /// </summary>
        public Union<Humidifier.IoT.ThingTypeTypes.ThingTypeProperties, BaseFunction>? ThingTypeProperties { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-thingtype.html#cfn-iot-thingtype-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace ThingTypeTypes
    {
        public class Mqtt5Configuration : Humidifier.Base.BaseSubResource, IHaveListOfIoTThingTypeTypesPropagatingAttributePropagatingAttributes
        {
            /// <summary>
            /// PropagatingAttributes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-thingtype-mqtt5configuration.html#cfn-iot-thingtype-mqtt5configuration-propagatingattributes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: PropagatingAttribute
            /// </summary>
            public Union<IReadOnlyList<Humidifier.IoT.ThingTypeTypes.PropagatingAttribute>, IReadOnlyList<Union<Humidifier.IoT.ThingTypeTypes.PropagatingAttribute, BaseFunction>>, BaseFunction>? PropagatingAttributes { get; set; }
        }

        public class PropagatingAttribute : Humidifier.Base.BaseSubResource, IHaveUserPropertyKey, IHaveThingAttribute, IHaveConnectionAttribute
        {
            /// <summary>
            /// UserPropertyKey
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-thingtype-propagatingattribute.html#cfn-iot-thingtype-propagatingattribute-userpropertykey
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UserPropertyKey { get; set; }
            /// <summary>
            /// ThingAttribute
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-thingtype-propagatingattribute.html#cfn-iot-thingtype-propagatingattribute-thingattribute
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ThingAttribute { get; set; }
            /// <summary>
            /// ConnectionAttribute
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-thingtype-propagatingattribute.html#cfn-iot-thingtype-propagatingattribute-connectionattribute
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ConnectionAttribute { get; set; }
        }

        public class ThingTypeProperties : Humidifier.Base.BaseSubResource, IHaveThingTypeDescription, IHaveIoTThingTypeTypesMqtt5ConfigurationMqtt5Configuration, IHaveStringListOfSearchableAttributes
        {
            /// <summary>
            /// ThingTypeDescription
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-thingtype-thingtypeproperties.html#cfn-iot-thingtype-thingtypeproperties-thingtypedescription
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ThingTypeDescription { get; set; }
            /// <summary>
            /// Mqtt5Configuration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-thingtype-thingtypeproperties.html#cfn-iot-thingtype-thingtypeproperties-mqtt5configuration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Mqtt5Configuration
            /// </summary>
            public Union<Humidifier.IoT.ThingTypeTypes.Mqtt5Configuration, BaseFunction>? Mqtt5Configuration { get; set; }
            /// <summary>
            /// SearchableAttributes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-thingtype-thingtypeproperties.html#cfn-iot-thingtype-thingtypeproperties-searchableattributes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SearchableAttributes { get; set; }
        }
    }
}