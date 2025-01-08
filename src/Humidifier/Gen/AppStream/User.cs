namespace Humidifier.AppStream
{
    using System.Collections.Generic;

    public class User : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveAuthenticationType, IHaveUserName, IHaveFirstName, IHaveLastName, IHaveMessageAction
    {
        public override string AWSTypeName { get => AWS.AppStream.User; }
        public dynamic UserName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// FirstName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appstream-user.html#cfn-appstream-user-firstname
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic FirstName { get; set; }
        /// <summary>
        /// MessageAction
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appstream-user.html#cfn-appstream-user-messageaction
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic MessageAction { get; set; }
        /// <summary>
        /// LastName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appstream-user.html#cfn-appstream-user-lastname
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic LastName { get; set; }

        /// <summary>
        /// AuthenticationType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appstream-user.html#cfn-appstream-user-authenticationtype
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic AuthenticationType { get; set; }
    }
}