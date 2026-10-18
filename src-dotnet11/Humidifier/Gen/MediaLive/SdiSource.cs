namespace Humidifier.MediaLive
{
    using global::System.Collections.Generic;
    using SdiSourceTypes;

    public class SdiSource : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveType, IHaveMode, IHaveListOfMediaLiveSdiSourceTypesTagsTags, IHaveName
    {
        public class Attributes
        {
            public static string State =  "State" ;
            public static string Id =  "Id" ;
            public static string Arn =  "Arn" ;
            public static string Inputs =  "Inputs" ;
        }

        public override string AWSTypeName { get => AWS.MediaLive.SdiSource; }

        /// <summary>
        /// Type
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-medialive-sdisource.html#cfn-medialive-sdisource-type
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Type { get; set; }
        /// <summary>
        /// Mode
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-medialive-sdisource.html#cfn-medialive-sdisource-mode
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Mode { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-medialive-sdisource.html#cfn-medialive-sdisource-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tags
        /// </summary>
        public Union<IReadOnlyList<Humidifier.MediaLive.SdiSourceTypes.Tags>, IReadOnlyList<Union<Humidifier.MediaLive.SdiSourceTypes.Tags, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace SdiSourceTypes
    {
        public class Tags : Humidifier.Base.BaseSubResource, IHaveValue, IHaveKey
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-sdisource-tags.html#cfn-medialive-sdisource-tags-value
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-sdisource-tags.html#cfn-medialive-sdisource-tags-key
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Key { get; set; }
        }
    }
}