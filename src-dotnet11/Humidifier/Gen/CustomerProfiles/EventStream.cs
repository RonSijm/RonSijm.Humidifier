namespace Humidifier.CustomerProfiles
{
    using global::System.Collections.Generic;
    using EventStreamTypes;

    public class EventStream : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveDomainName, IHaveEventStreamName, IHaveUri
    {
        public class Attributes
        {
            public static string EventStreamArn =  "EventStreamArn" ;
            public static string State =  "State" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string DestinationDetails =  "DestinationDetails" ;
        }

        public override string AWSTypeName { get => AWS.CustomerProfiles.EventStream; }

        /// <summary>
        /// DomainName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-customerprofiles-eventstream.html#cfn-customerprofiles-eventstream-domainname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? DomainName { get; set; }
        public Union<string, BaseFunction>? EventStreamName { get => GivenName; set => GivenName = value; }

        /// <summary>
        /// Uri
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-customerprofiles-eventstream.html#cfn-customerprofiles-eventstream-uri
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Uri { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-customerprofiles-eventstream.html#cfn-customerprofiles-eventstream-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace EventStreamTypes
    {
        public class DestinationDetails : Humidifier.Base.BaseSubResource, IHaveStatus, IHaveUri
        {
            /// <summary>
            /// Status
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-eventstream-destinationdetails.html#cfn-customerprofiles-eventstream-destinationdetails-status
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Status { get; set; }
            /// <summary>
            /// Uri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-eventstream-destinationdetails.html#cfn-customerprofiles-eventstream-destinationdetails-uri
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Uri { get; set; }
        }
    }
}