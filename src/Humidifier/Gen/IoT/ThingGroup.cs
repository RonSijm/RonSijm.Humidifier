namespace Humidifier.IoT
{
    using System.Collections.Generic;
    using ThingGroupTypes;

    public class ThingGroup : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveQueryString
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
        public dynamic ParentGroupName { get; set; }
        public dynamic ThingGroupName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// ThingGroupProperties
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-thinggroup.html#cfn-iot-thinggroup-thinggroupproperties
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ThingGroupProperties
        /// </summary>
        public Humidifier.IoT.ThingGroupTypes.ThingGroupProperties ThingGroupProperties { get; set; }
        /// <summary>
        /// QueryString
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-thinggroup.html#cfn-iot-thinggroup-querystring
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic QueryString { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-thinggroup.html#cfn-iot-thinggroup-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
    }

    namespace ThingGroupTypes
    {
        public class AttributePayload : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Attributes_
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-thinggroup-attributepayload.html#cfn-iot-thinggroup-attributepayload-attributes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Dictionary<string, dynamic> Attributes_ { get; set; }
        }

        public class ThingGroupProperties : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// AttributePayload
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-thinggroup-thinggroupproperties.html#cfn-iot-thinggroup-thinggroupproperties-attributepayload
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AttributePayload
            /// </summary>
            public Humidifier.IoT.ThingGroupTypes.AttributePayload AttributePayload { get; set; }
            /// <summary>
            /// ThingGroupDescription
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-thinggroup-thinggroupproperties.html#cfn-iot-thinggroup-thinggroupproperties-thinggroupdescription
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ThingGroupDescription { get; set; }
        }
    }
}