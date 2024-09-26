namespace Humidifier.Cognito
{
    using System.Collections.Generic;
    using UserPoolResourceServerTypes;

    public class UserPoolResourceServer : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveUserPoolId, IHaveIdentifier
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
        public dynamic UserPoolId { get; set; }

        /// <summary>
        /// Identifier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-userpoolresourceserver.html#cfn-cognito-userpoolresourceserver-identifier
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic Identifier { get; set; }
        /// <summary>
        /// Scopes
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-userpoolresourceserver.html#cfn-cognito-userpoolresourceserver-scopes
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: ResourceServerScopeType
        /// </summary>
        public List<Humidifier.Cognito.UserPoolResourceServerTypes.ResourceServerScopeType> Scopes { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
    }

    namespace UserPoolResourceServerTypes
    {
        public class ResourceServerScopeType : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ScopeName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpoolresourceserver-resourceserverscopetype.html#cfn-cognito-userpoolresourceserver-resourceserverscopetype-scopename
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ScopeName { get; set; }
            /// <summary>
            /// ScopeDescription
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpoolresourceserver-resourceserverscopetype.html#cfn-cognito-userpoolresourceserver-resourceserverscopetype-scopedescription
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ScopeDescription { get; set; }
        }
    }
}