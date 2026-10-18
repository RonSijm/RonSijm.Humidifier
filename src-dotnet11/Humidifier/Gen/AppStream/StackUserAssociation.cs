namespace Humidifier.AppStream
{
    using global::System.Collections.Generic;

    public class StackUserAssociation : Humidifier.Base.BaseResource, IHaveSendEmailNotification_Boolean, IHaveUserName, IHaveStackName, IHaveAuthenticationType
    {
        public override string AWSTypeName { get => AWS.AppStream.StackUserAssociation; }
        /// <summary>
        /// SendEmailNotification
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appstream-stackuserassociation.html#cfn-appstream-stackuserassociation-sendemailnotification
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? SendEmailNotification { get; set; }

        /// <summary>
        /// UserName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appstream-stackuserassociation.html#cfn-appstream-stackuserassociation-username
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? UserName { get; set; }

        /// <summary>
        /// StackName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appstream-stackuserassociation.html#cfn-appstream-stackuserassociation-stackname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? StackName { get; set; }

        /// <summary>
        /// AuthenticationType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appstream-stackuserassociation.html#cfn-appstream-stackuserassociation-authenticationtype
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? AuthenticationType { get; set; }
    }
}