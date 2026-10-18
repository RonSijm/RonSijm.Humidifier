namespace Humidifier.SSO
{
    using global::System.Collections.Generic;

    public class ApplicationAssignment : Humidifier.Base.BaseResource, IHaveApplicationArn, IHavePrincipalId, IHavePrincipalType
    {
        public override string AWSTypeName { get => AWS.SSO.ApplicationAssignment; }

        /// <summary>
        /// ApplicationArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sso-applicationassignment.html#cfn-sso-applicationassignment-applicationarn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ApplicationArn { get; set; }

        /// <summary>
        /// PrincipalId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sso-applicationassignment.html#cfn-sso-applicationassignment-principalid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? PrincipalId { get; set; }

        /// <summary>
        /// PrincipalType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sso-applicationassignment.html#cfn-sso-applicationassignment-principaltype
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? PrincipalType { get; set; }
    }
}