namespace Humidifier.MediaLive
{
    using System.Collections.Generic;
    using EventBridgeRuleTemplateTypes;

    public class EventBridgeRuleTemplate : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveDescription, IHaveEventType, IHaveGroupIdentifier
    {
        public class Attributes
        {
            public static string ModifiedAt =  "ModifiedAt" ;
            public static string Identifier =  "Identifier" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string Id =  "Id" ;
            public static string Arn =  "Arn" ;
            public static string GroupId =  "GroupId" ;
        }

        public override string AWSTypeName { get => AWS.MediaLive.EventBridgeRuleTemplate; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-medialive-eventbridgeruletemplate.html#cfn-medialive-eventbridgeruletemplate-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Description { get; set; }
        /// <summary>
        /// EventTargets
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-medialive-eventbridgeruletemplate.html#cfn-medialive-eventbridgeruletemplate-eventtargets
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: EventBridgeRuleTemplateTarget
        /// </summary>
        public List<Humidifier.MediaLive.EventBridgeRuleTemplateTypes.EventBridgeRuleTemplateTarget> EventTargets { get; set; }

        /// <summary>
        /// EventType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-medialive-eventbridgeruletemplate.html#cfn-medialive-eventbridgeruletemplate-eventtype
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic EventType { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-medialive-eventbridgeruletemplate.html#cfn-medialive-eventbridgeruletemplate-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Dictionary<string, dynamic> Tags { get; set; }

        /// <summary>
        /// GroupIdentifier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-medialive-eventbridgeruletemplate.html#cfn-medialive-eventbridgeruletemplate-groupidentifier
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic GroupIdentifier { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
    }

    namespace EventBridgeRuleTemplateTypes
    {
        public class EventBridgeRuleTemplateTarget : Humidifier.Base.BaseSubResource, IHaveArn
        {
            /// <summary>
            /// Arn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-eventbridgeruletemplate-eventbridgeruletemplatetarget.html#cfn-medialive-eventbridgeruletemplate-eventbridgeruletemplatetarget-arn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Arn { get; set; }
        }
    }
}