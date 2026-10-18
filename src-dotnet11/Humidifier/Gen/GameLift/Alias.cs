namespace Humidifier.GameLift
{
    using global::System.Collections.Generic;
    using AliasTypes;

    public class Alias : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveDescription, IHaveGameLiftAliasTypesRoutingStrategyRoutingStrategy, IHaveName
    {
        public class Attributes
        {
            public static string AliasArn =  "AliasArn" ;
            public static string AliasId =  "AliasId" ;
        }

        public override string AWSTypeName { get => AWS.GameLift.Alias; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-gamelift-alias.html#cfn-gamelift-alias-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }

        /// <summary>
        /// RoutingStrategy
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-gamelift-alias.html#cfn-gamelift-alias-routingstrategy
        /// Required: True
        /// UpdateType: Mutable
        /// Type: RoutingStrategy
        /// </summary>
        [Required]
        public Union<Humidifier.GameLift.AliasTypes.RoutingStrategy, BaseFunction>? RoutingStrategy { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-gamelift-alias.html#cfn-gamelift-alias-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace AliasTypes
    {
        public class RoutingStrategy : Humidifier.Base.BaseSubResource, IHaveType, IHaveMessage, IHaveFleetId
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-alias-routingstrategy.html#cfn-gamelift-alias-routingstrategy-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// Message
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-alias-routingstrategy.html#cfn-gamelift-alias-routingstrategy-message
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Message { get; set; }
            /// <summary>
            /// FleetId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-alias-routingstrategy.html#cfn-gamelift-alias-routingstrategy-fleetid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FleetId { get; set; }
        }
    }
}