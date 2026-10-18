namespace Humidifier.Cognito
{
    using global::System.Collections.Generic;
    using UserPoolResourceServerTypes;

    public class UserPoolResourceServer : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveUserPoolId, IHaveIdentifier, IHaveListOfCognitoUserPoolResourceServerTypesResourceServerScopeTypeScopes, IHaveName
    {
        public override string AWSTypeName { get => AWS.Cognito.UserPoolResourceServer; }

        /// <summary>
        /// UserPoolId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-userpoolresourceserver.html#cfn-cognito-userpoolresourceserver-userpoolid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? UserPoolId { get; set; }

        /// <summary>
        /// Identifier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-userpoolresourceserver.html#cfn-cognito-userpoolresourceserver-identifier
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Identifier { get; set; }
        /// <summary>
        /// Scopes
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-userpoolresourceserver.html#cfn-cognito-userpoolresourceserver-scopes
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: ResourceServerScopeType
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Cognito.UserPoolResourceServerTypes.ResourceServerScopeType>, IReadOnlyList<Union<Humidifier.Cognito.UserPoolResourceServerTypes.ResourceServerScopeType, BaseFunction>>, BaseFunction>? Scopes { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace UserPoolResourceServerTypes
    {
        public class ResourceServerScopeType : Humidifier.Base.BaseSubResource, IHaveScopeName, IHaveScopeDescription
        {
            /// <summary>
            /// ScopeName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpoolresourceserver-resourceserverscopetype.html#cfn-cognito-userpoolresourceserver-resourceserverscopetype-scopename
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ScopeName { get; set; }
            /// <summary>
            /// ScopeDescription
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpoolresourceserver-resourceserverscopetype.html#cfn-cognito-userpoolresourceserver-resourceserverscopetype-scopedescription
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ScopeDescription { get; set; }
        }
    }
}