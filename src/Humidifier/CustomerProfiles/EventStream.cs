namespace Humidifier.CustomerProfiles
{
    using System.Collections.Generic;
    using EventStreamTypes;

    public class EventStream : Humidifier.Resource, IHaveTags
    {
        public class Attributes
        {
            public static string EventStreamArn =  "EventStreamArn" ;
            public static string State =  "State" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string DestinationDetails =  "DestinationDetails" ;
        }

        public override string AWSTypeName
        {
            get
            {
                return @"AWS::CustomerProfiles::EventStream";
            }
        }

        /// <summary>
        /// DomainName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-customerprofiles-eventstream.html#cfn-customerprofiles-eventstream-domainname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic DomainName { get; set; }
        /// <summary>
        /// EventStreamName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-customerprofiles-eventstream.html#cfn-customerprofiles-eventstream-eventstreamname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic EventStreamName { get; set; }
        /// <summary>
        /// Uri
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-customerprofiles-eventstream.html#cfn-customerprofiles-eventstream-uri
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Uri { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-customerprofiles-eventstream.html#cfn-customerprofiles-eventstream-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
    }

    namespace EventStreamTypes
    {
        public class DestinationDetails
        {
            /// <summary>
            /// Status
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-eventstream-destinationdetails.html#cfn-customerprofiles-eventstream-destinationdetails-status
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Status { get; set; }
            /// <summary>
            /// Uri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-eventstream-destinationdetails.html#cfn-customerprofiles-eventstream-destinationdetails-uri
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Uri { get; set; }
        }
    }
}