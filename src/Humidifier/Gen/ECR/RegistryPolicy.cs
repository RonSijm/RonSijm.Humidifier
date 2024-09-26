namespace Humidifier.ECR
{
    using System.Collections.Generic;

    public class RegistryPolicy : Humidifier.Base.BaseResource, IHavePolicyText
    {
        public class Attributes
        {
            public static string RegistryId =  "RegistryId" ;
        }

        public override string AWSTypeName { get => AWS.ECR.RegistryPolicy; }

        /// <summary>
        /// PolicyText
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecr-registrypolicy.html#cfn-ecr-registrypolicy-policytext
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: Json
        /// </summary>
        [Required]
        public dynamic PolicyText { get; set; }
    }
}