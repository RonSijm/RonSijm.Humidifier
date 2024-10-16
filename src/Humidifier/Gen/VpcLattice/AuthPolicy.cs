namespace Humidifier.VpcLattice
{
    using System.Collections.Generic;

    public class AuthPolicy : Humidifier.Base.BaseResource, IHavePolicy, IHaveResourceIdentifier
    {
        public class Attributes
        {
            public static string State =  "State" ;
        }

        public override string AWSTypeName { get => AWS.VpcLattice.AuthPolicy; }

        /// <summary>
        /// Policy
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-vpclattice-authpolicy.html#cfn-vpclattice-authpolicy-policy
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: Json
        /// </summary>
        [Required]
        public dynamic Policy { get; set; }

        /// <summary>
        /// ResourceIdentifier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-vpclattice-authpolicy.html#cfn-vpclattice-authpolicy-resourceidentifier
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic ResourceIdentifier { get; set; }
    }
}