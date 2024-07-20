namespace Humidifier.ECR
{
    using System.Collections.Generic;

    public class RegistryPolicy : Humidifier.Resource
    {
        public class Attributes
        {
            public static string RegistryId =  "RegistryId" ;
        }

        public override string AWSTypeName
        {
            get
            {
                return @"AWS::ECR::RegistryPolicy";
            }
        }

        /// <summary>
        /// PolicyText
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecr-registrypolicy.html#cfn-ecr-registrypolicy-policytext
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: Json
        /// </summary>
        public dynamic PolicyText { get; set; }
    }
}