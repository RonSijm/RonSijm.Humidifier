namespace Humidifier.IoT
{
    using global::System.Collections.Generic;
    using ThingGroupTypes;

    public class ThingGroup : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveParentGroupName, IHaveThingGroupName, IHaveIoTThingGroupTypesThingGroupPropertiesThingGroupProperties, IHaveQueryString
    {
        public class Attributes
        {
            public static string Id =  "Id" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.IoT.ThingGroup; }
        /// <summary>
        /// ParentGroupName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-thinggroup.html#cfn-iot-thinggroup-parentgroupname
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ParentGroupName { get; set; }
        public Union<string, BaseFunction>? ThingGroupName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// ThingGroupProperties
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-thinggroup.html#cfn-iot-thinggroup-thinggroupproperties
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ThingGroupProperties
        /// </summary>
        public Union<Humidifier.IoT.ThingGroupTypes.ThingGroupProperties, BaseFunction>? ThingGroupProperties { get; set; }
        /// <summary>
        /// QueryString
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-thinggroup.html#cfn-iot-thinggroup-querystring
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? QueryString { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-thinggroup.html#cfn-iot-thinggroup-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace ThingGroupTypes
    {
        public class AttributePayload : Humidifier.Base.BaseSubResource, IHaveStringDictionaryOfAttributes_
        {
            /// <summary>
            /// Attributes_
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-thinggroup-attributepayload.html#cfn-iot-thinggroup-attributepayload-attributes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? Attributes_ { get; set; }
        }

        public class ThingGroupProperties : Humidifier.Base.BaseSubResource, IHaveIoTThingGroupTypesAttributePayloadAttributePayload, IHaveThingGroupDescription
        {
            /// <summary>
            /// AttributePayload
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-thinggroup-thinggroupproperties.html#cfn-iot-thinggroup-thinggroupproperties-attributepayload
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AttributePayload
            /// </summary>
            public Union<Humidifier.IoT.ThingGroupTypes.AttributePayload, BaseFunction>? AttributePayload { get; set; }
            /// <summary>
            /// ThingGroupDescription
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-thinggroup-thinggroupproperties.html#cfn-iot-thinggroup-thinggroupproperties-thinggroupdescription
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ThingGroupDescription { get; set; }
        }
    }
}