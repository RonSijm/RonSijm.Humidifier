namespace Humidifier.Cognito
{
    using global::System.Collections.Generic;
    using UserPoolSessionConfigurationAttachmentTypes;

    public class UserPoolSessionConfigurationAttachment : Humidifier.Base.BaseResource, IHaveUserSessionTracking, IHaveUserPoolId, IHaveCognitoUserPoolSessionConfigurationAttachmentTypesTokenSessionTokenSession
    {
        public override string AWSTypeName { get => AWS.Cognito.UserPoolSessionConfigurationAttachment; }

        /// <summary>
        /// UserSessionTracking
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-userpoolsessionconfigurationattachment.html#cfn-cognito-userpoolsessionconfigurationattachment-usersessiontracking
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? UserSessionTracking { get; set; }

        /// <summary>
        /// UserPoolId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-userpoolsessionconfigurationattachment.html#cfn-cognito-userpoolsessionconfigurationattachment-userpoolid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? UserPoolId { get; set; }

        /// <summary>
        /// TokenSession
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-userpoolsessionconfigurationattachment.html#cfn-cognito-userpoolsessionconfigurationattachment-tokensession
        /// Required: True
        /// UpdateType: Mutable
        /// Type: TokenSession
        /// </summary>
        [Required]
        public Union<Humidifier.Cognito.UserPoolSessionConfigurationAttachmentTypes.TokenSession, BaseFunction>? TokenSession { get; set; }
    }

    namespace UserPoolSessionConfigurationAttachmentTypes
    {
        public class TokenSession : Humidifier.Base.BaseSubResource, IHaveMaxPerUser_Integer
        {
            /// <summary>
            /// MaxPerUser
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpoolsessionconfigurationattachment-tokensession.html#cfn-cognito-userpoolsessionconfigurationattachment-tokensession-maxperuser
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaxPerUser { get; set; }
        }
    }
}