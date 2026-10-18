namespace Humidifier.ElastiCache
{
    using global::System.Collections.Generic;
    using UserTypes;

    public class User : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveElastiCacheUserTypesAuthenticationModeAuthenticationMode, IHaveUserName, IHaveNoPasswordRequired_Boolean, IHaveAccessString, IHaveUserId, IHaveStringListOfPasswords, IHaveEngine
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.ElastiCache.User; }
        /// <summary>
        /// AuthenticationMode
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticache-user.html#cfn-elasticache-user-authenticationmode
        /// Required: False
        /// UpdateType: Mutable
        /// Type: AuthenticationMode
        /// </summary>
        public Union<Humidifier.ElastiCache.UserTypes.AuthenticationMode, BaseFunction>? AuthenticationMode { get; set; }
        public Union<string, BaseFunction>? UserName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// NoPasswordRequired
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticache-user.html#cfn-elasticache-user-nopasswordrequired
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? NoPasswordRequired { get; set; }
        /// <summary>
        /// AccessString
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticache-user.html#cfn-elasticache-user-accessstring
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? AccessString { get; set; }

        /// <summary>
        /// UserId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticache-user.html#cfn-elasticache-user-userid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? UserId { get; set; }
        /// <summary>
        /// Passwords
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticache-user.html#cfn-elasticache-user-passwords
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Passwords { get; set; }

        /// <summary>
        /// Engine
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticache-user.html#cfn-elasticache-user-engine
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Engine { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticache-user.html#cfn-elasticache-user-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace UserTypes
    {
        public class AuthenticationMode : Humidifier.Base.BaseSubResource, IHaveType, IHaveStringListOfPasswords
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticache-user-authenticationmode.html#cfn-elasticache-user-authenticationmode-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// Passwords
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticache-user-authenticationmode.html#cfn-elasticache-user-authenticationmode-passwords
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Passwords { get; set; }
        }
    }
}