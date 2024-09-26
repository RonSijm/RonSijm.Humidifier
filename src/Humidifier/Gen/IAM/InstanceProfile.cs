namespace Humidifier.IAM
{
    using System.Collections.Generic;

    public class InstanceProfile : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHavePath, IHaveInstanceProfileName, IHaveRoles
    {
        public class Attributes
        {
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.IAM.InstanceProfile; }
        /// <summary>
        /// Path
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iam-instanceprofile.html#cfn-iam-instanceprofile-path
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Path { get; set; }
        public dynamic InstanceProfileName { get => GivenName; set => GivenName = value; }

        /// <summary>
        /// Roles
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iam-instanceprofile.html#cfn-iam-instanceprofile-roles
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        [Required]
        public dynamic Roles { get; set; }
    }
}