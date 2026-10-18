namespace Humidifier.MediaLive
{
    using global::System.Collections.Generic;
    using EventBridgeRuleTemplateTypes;

    public class EventBridgeRuleTemplate : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveDescription, IHaveListOfMediaLiveEventBridgeRuleTemplateTypesEventBridgeRuleTemplateTargetEventTargets, IHaveEventType, IHaveStringDictionaryOfTags, IHaveGroupIdentifier, IHaveName
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
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// EventTargets
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-medialive-eventbridgeruletemplate.html#cfn-medialive-eventbridgeruletemplate-eventtargets
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: EventBridgeRuleTemplateTarget
        /// </summary>
        public Union<IReadOnlyList<Humidifier.MediaLive.EventBridgeRuleTemplateTypes.EventBridgeRuleTemplateTarget>, IReadOnlyList<Union<Humidifier.MediaLive.EventBridgeRuleTemplateTypes.EventBridgeRuleTemplateTarget, BaseFunction>>, BaseFunction>? EventTargets { get; set; }

        /// <summary>
        /// EventType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-medialive-eventbridgeruletemplate.html#cfn-medialive-eventbridgeruletemplate-eventtype
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? EventType { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-medialive-eventbridgeruletemplate.html#cfn-medialive-eventbridgeruletemplate-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? Tags { get; set; }
        /// <summary>
        /// GroupIdentifier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-medialive-eventbridgeruletemplate.html#cfn-medialive-eventbridgeruletemplate-groupidentifier
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? GroupIdentifier { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
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
            public Union<string, BaseFunction>? Arn { get; set; }
        }
    }
}