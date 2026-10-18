namespace Humidifier.MemoryDB
{
    using global::System.Collections.Generic;
    using UserTypes;

    public class User : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveMemoryDBUserTypesAuthenticationModeAuthenticationMode, IHaveUserName, IHaveAccessString
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.MemoryDB.User; }
        /// <summary>
        /// AuthenticationMode
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-memorydb-user.html#cfn-memorydb-user-authenticationmode
        /// Required: False
        /// UpdateType: Mutable
        /// Type: AuthenticationMode
        /// </summary>
        public Union<Humidifier.MemoryDB.UserTypes.AuthenticationMode, BaseFunction>? AuthenticationMode { get; set; }
        public Union<string, BaseFunction>? UserName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// AccessString
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-memorydb-user.html#cfn-memorydb-user-accessstring
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? AccessString { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-memorydb-user.html#cfn-memorydb-user-tags
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-memorydb-user-authenticationmode.html#cfn-memorydb-user-authenticationmode-type
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// Passwords
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-memorydb-user-authenticationmode.html#cfn-memorydb-user-authenticationmode-passwords
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Passwords { get; set; }
        }
    }
}