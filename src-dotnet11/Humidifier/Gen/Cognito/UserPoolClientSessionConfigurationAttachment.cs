namespace Humidifier.Cognito
{
    using global::System.Collections.Generic;
    using UserPoolClientSessionConfigurationAttachmentTypes;

    public class UserPoolClientSessionConfigurationAttachment : Humidifier.Base.BaseResource, IHaveCognitoUserPoolClientSessionConfigurationAttachmentTypesSSOSessionSSOSession, IHaveUserPoolId, IHaveClientId
    {
        public override string AWSTypeName { get => AWS.Cognito.UserPoolClientSessionConfigurationAttachment; }

        /// <summary>
        /// SSOSession
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-userpoolclientsessionconfigurationattachment.html#cfn-cognito-userpoolclientsessionconfigurationattachment-ssosession
        /// Required: True
        /// UpdateType: Mutable
        /// Type: SSOSession
        /// </summary>
        [Required]
        public Union<Humidifier.Cognito.UserPoolClientSessionConfigurationAttachmentTypes.SSOSession, BaseFunction>? SSOSession { get; set; }

        /// <summary>
        /// UserPoolId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-userpoolclientsessionconfigurationattachment.html#cfn-cognito-userpoolclientsessionconfigurationattachment-userpoolid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? UserPoolId { get; set; }

        /// <summary>
        /// ClientId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-userpoolclientsessionconfigurationattachment.html#cfn-cognito-userpoolclientsessionconfigurationattachment-clientid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ClientId { get; set; }
    }

    namespace UserPoolClientSessionConfigurationAttachmentTypes
    {
        public class SSOSession : Humidifier.Base.BaseSubResource, IHaveMaxValidityMinutes_Integer
        {
            /// <summary>
            /// MaxValidityMinutes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpoolclientsessionconfigurationattachment-ssosession.html#cfn-cognito-userpoolclientsessionconfigurationattachment-ssosession-maxvalidityminutes
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaxValidityMinutes { get; set; }
        }
    }
}