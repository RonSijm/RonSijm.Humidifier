namespace Humidifier.GreengrassV2
{
    using global::System.Collections.Generic;
    using CoreDeviceTypes;

    public class CoreDevice : Humidifier.Base.BaseResource, IHaveCoreDeviceThingName
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string LastStatusUpdateTimestamp =  "LastStatusUpdateTimestamp" ;
            public static string Runtime =  "Runtime" ;
            public static string Platform =  "Platform" ;
            public static string Architecture =  "Architecture" ;
            public static string CoreVersion =  "CoreVersion" ;
            public static string Arn =  "Arn" ;
            public static string Tags =  "Tags" ;
        }

        public override string AWSTypeName { get => AWS.GreengrassV2.CoreDevice; }
        /// <summary>
        /// CoreDeviceThingName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-greengrassv2-coredevice.html#cfn-greengrassv2-coredevice-coredevicethingname
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? CoreDeviceThingName { get; set; }
    }

    namespace CoreDeviceTypes
    {
        public class TagsItems : Humidifier.Base.BaseSubResource, IHaveValue, IHaveKey
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrassv2-coredevice-tagsitems.html#cfn-greengrassv2-coredevice-tagsitems-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrassv2-coredevice-tagsitems.html#cfn-greengrassv2-coredevice-tagsitems-key
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Key { get; set; }
        }
    }
}