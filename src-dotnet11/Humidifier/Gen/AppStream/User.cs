namespace Humidifier.AppStream
{
    using global::System.Collections.Generic;

    public class User : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveUserName, IHaveFirstName, IHaveMessageAction, IHaveLastName, IHaveAuthenticationType
    {
        public class Attributes
        {
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.AppStream.User; }
        public Union<string, BaseFunction>? UserName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// FirstName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appstream-user.html#cfn-appstream-user-firstname
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? FirstName { get; set; }
        /// <summary>
        /// MessageAction
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appstream-user.html#cfn-appstream-user-messageaction
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? MessageAction { get; set; }
        /// <summary>
        /// LastName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appstream-user.html#cfn-appstream-user-lastname
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? LastName { get; set; }

        /// <summary>
        /// AuthenticationType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appstream-user.html#cfn-appstream-user-authenticationtype
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? AuthenticationType { get; set; }
    }
}