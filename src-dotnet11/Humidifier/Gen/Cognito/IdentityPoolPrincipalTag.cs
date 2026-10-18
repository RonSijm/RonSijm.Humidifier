namespace Humidifier.Cognito
{
    using global::System.Collections.Generic;

    public class IdentityPoolPrincipalTag : Humidifier.Base.BaseResource, IHavePrincipalTags_Json, IHaveUseDefaults_Boolean, IHaveIdentityProviderName, IHaveIdentityPoolId
    {
        public override string AWSTypeName { get => AWS.Cognito.IdentityPoolPrincipalTag; }
        /// <summary>
        /// PrincipalTags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-identitypoolprincipaltag.html#cfn-cognito-identitypoolprincipaltag-principaltags
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Json
        /// </summary>
        public Union<object, BaseFunction>? PrincipalTags { get; set; }
        /// <summary>
        /// UseDefaults
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-identitypoolprincipaltag.html#cfn-cognito-identitypoolprincipaltag-usedefaults
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? UseDefaults { get; set; }

        /// <summary>
        /// IdentityProviderName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-identitypoolprincipaltag.html#cfn-cognito-identitypoolprincipaltag-identityprovidername
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? IdentityProviderName { get; set; }

        /// <summary>
        /// IdentityPoolId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-identitypoolprincipaltag.html#cfn-cognito-identitypoolprincipaltag-identitypoolid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? IdentityPoolId { get; set; }
    }
}