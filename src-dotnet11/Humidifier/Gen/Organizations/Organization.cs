namespace Humidifier.Organizations
{
    using global::System.Collections.Generic;

    public class Organization : Humidifier.Base.BaseResource, IHaveFeatureSet
    {
        public class Attributes
        {
            public static string RootId =  "RootId" ;
            public static string Id =  "Id" ;
            public static string Arn =  "Arn" ;
            public static string ManagementAccountArn =  "ManagementAccountArn" ;
            public static string ManagementAccountId =  "ManagementAccountId" ;
            public static string ManagementAccountEmail =  "ManagementAccountEmail" ;
        }

        public override string AWSTypeName { get => AWS.Organizations.Organization; }
        /// <summary>
        /// FeatureSet
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-organizations-organization.html#cfn-organizations-organization-featureset
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? FeatureSet { get; set; }
    }
}