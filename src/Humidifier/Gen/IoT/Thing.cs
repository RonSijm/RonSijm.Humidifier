namespace Humidifier.IoT
{
    using System.Collections.Generic;
    using ThingTypes;

    public class Thing : Humidifier.Base.BaseResource, IHaveImpliedResourceName
    {
        public class Attributes
        {
            public static string Id =  "Id" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName
        {
            get
            {
                return @"AWS::IoT::Thing";
            }
        }

        /// <summary>
        /// AttributePayload
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-thing.html#cfn-iot-thing-attributepayload
        /// Required: False
        /// UpdateType: Mutable
        /// Type: AttributePayload
        /// </summary>
        public ThingTypes.AttributePayload AttributePayload { get; set; }
        public dynamic ThingName { get => GivenName; set => GivenName = value; }
    }

    namespace ThingTypes
    {
        public class AttributePayload : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Attributes_
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-thing-attributepayload.html#cfn-iot-thing-attributepayload-attributes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Dictionary<string, dynamic> Attributes_ { get; set; }
        }
    }
}