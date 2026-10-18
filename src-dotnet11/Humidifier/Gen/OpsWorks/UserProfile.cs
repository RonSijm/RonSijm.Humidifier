namespace Humidifier.OpsWorks
{
    using global::System.Collections.Generic;

    public class UserProfile : Humidifier.Base.BaseResource, IHaveAllowSelfManagement_Boolean, IHaveIamUserArn, IHaveSshPublicKey, IHaveSshUsername
    {
        public class Attributes
        {
            public static string SshUsername =  "SshUsername" ;
        }

        public override string AWSTypeName { get => AWS.OpsWorks.UserProfile; }
        /// <summary>
        /// AllowSelfManagement
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-opsworks-userprofile.html#cfn-opsworks-userprofile-allowselfmanagement
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? AllowSelfManagement { get; set; }

        /// <summary>
        /// IamUserArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-opsworks-userprofile.html#cfn-opsworks-userprofile-iamuserarn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? IamUserArn { get; set; }
        /// <summary>
        /// SshPublicKey
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-opsworks-userprofile.html#cfn-opsworks-userprofile-sshpublickey
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? SshPublicKey { get; set; }
        /// <summary>
        /// SshUsername
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-opsworks-userprofile.html#cfn-opsworks-userprofile-sshusername
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? SshUsername { get; set; }
    }
}