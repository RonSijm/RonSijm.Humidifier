namespace Humidifier.IVSChat
{
    using global::System.Collections.Generic;
    using RoomTypes;

    public class Room : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveMaximumMessageRatePerSecond_Integer, IHaveMaximumMessageLength_Integer, IHaveIVSChatRoomTypesMessageReviewHandlerMessageReviewHandler, IHaveStringListOfLoggingConfigurationIdentifiers, IHaveName
    {
        public class Attributes
        {
            public static string Id =  "Id" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.IVSChat.Room; }
        /// <summary>
        /// MaximumMessageRatePerSecond
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ivschat-room.html#cfn-ivschat-room-maximummessageratepersecond
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? MaximumMessageRatePerSecond { get; set; }
        /// <summary>
        /// MaximumMessageLength
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ivschat-room.html#cfn-ivschat-room-maximummessagelength
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? MaximumMessageLength { get; set; }
        /// <summary>
        /// MessageReviewHandler
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ivschat-room.html#cfn-ivschat-room-messagereviewhandler
        /// Required: False
        /// UpdateType: Mutable
        /// Type: MessageReviewHandler
        /// </summary>
        public Union<Humidifier.IVSChat.RoomTypes.MessageReviewHandler, BaseFunction>? MessageReviewHandler { get; set; }
        /// <summary>
        /// LoggingConfigurationIdentifiers
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ivschat-room.html#cfn-ivschat-room-loggingconfigurationidentifiers
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? LoggingConfigurationIdentifiers { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ivschat-room.html#cfn-ivschat-room-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace RoomTypes
    {
        public class MessageReviewHandler : Humidifier.Base.BaseSubResource, IHaveFallbackResult, IHaveUri
        {
            /// <summary>
            /// FallbackResult
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ivschat-room-messagereviewhandler.html#cfn-ivschat-room-messagereviewhandler-fallbackresult
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FallbackResult { get; set; }
            /// <summary>
            /// Uri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ivschat-room-messagereviewhandler.html#cfn-ivschat-room-messagereviewhandler-uri
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Uri { get; set; }
        }
    }
}