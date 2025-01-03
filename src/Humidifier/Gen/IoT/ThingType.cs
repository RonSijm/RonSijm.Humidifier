namespace Humidifier.IoT
{
    using System.Collections.Generic;
    using ThingTypeTypes;

    public class ThingType : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags
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
        public dynamic DeprecateThingType { get; set; }
        public dynamic ThingTypeName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// ThingTypeProperties
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-thingtype.html#cfn-iot-thingtype-thingtypeproperties
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ThingTypeProperties
        /// </summary>
        public Humidifier.IoT.ThingTypeTypes.ThingTypeProperties ThingTypeProperties { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-thingtype.html#cfn-iot-thingtype-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
    }

    namespace ThingTypeTypes
    {
        public class Mqtt5Configuration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// PropagatingAttributes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-thingtype-mqtt5configuration.html#cfn-iot-thingtype-mqtt5configuration-propagatingattributes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: PropagatingAttribute
            /// </summary>
            public List<Humidifier.IoT.ThingTypeTypes.PropagatingAttribute> PropagatingAttributes { get; set; }
        }

        public class PropagatingAttribute : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// UserPropertyKey
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-thingtype-propagatingattribute.html#cfn-iot-thingtype-propagatingattribute-userpropertykey
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic UserPropertyKey { get; set; }
            /// <summary>
            /// ThingAttribute
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-thingtype-propagatingattribute.html#cfn-iot-thingtype-propagatingattribute-thingattribute
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ThingAttribute { get; set; }
            /// <summary>
            /// ConnectionAttribute
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-thingtype-propagatingattribute.html#cfn-iot-thingtype-propagatingattribute-connectionattribute
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ConnectionAttribute { get; set; }
        }

        public class ThingTypeProperties : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ThingTypeDescription
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-thingtype-thingtypeproperties.html#cfn-iot-thingtype-thingtypeproperties-thingtypedescription
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ThingTypeDescription { get; set; }
            /// <summary>
            /// Mqtt5Configuration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-thingtype-thingtypeproperties.html#cfn-iot-thingtype-thingtypeproperties-mqtt5configuration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Mqtt5Configuration
            /// </summary>
            public Humidifier.IoT.ThingTypeTypes.Mqtt5Configuration Mqtt5Configuration { get; set; }
            /// <summary>
            /// SearchableAttributes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-thingtype-thingtypeproperties.html#cfn-iot-thingtype-thingtypeproperties-searchableattributes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic SearchableAttributes { get; set; }
        }
    }
}