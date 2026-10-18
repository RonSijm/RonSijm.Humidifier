namespace Humidifier.IAM
{
    using global::System.Collections.Generic;

    public class InstanceProfile : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHavePath, IHaveInstanceProfileName, IHaveStringListOfRoles
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
        public Union<string, BaseFunction>? Path { get; set; }
        public Union<string, BaseFunction>? InstanceProfileName { get => GivenName; set => GivenName = value; }

        /// <summary>
        /// Roles
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iam-instanceprofile.html#cfn-iam-instanceprofile-roles
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        [Required]
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Roles { get; set; }
    }
}