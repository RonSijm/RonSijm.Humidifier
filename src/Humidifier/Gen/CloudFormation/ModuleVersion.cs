namespace Humidifier.CloudFormation
{
    using System.Collections.Generic;

    public class ModuleVersion : Humidifier.Base.BaseResource
    {
        public class Attributes
        {
            public static string TimeCreated =  "TimeCreated" ;
            public static string VersionId =  "VersionId" ;
            public static string Description =  "Description" ;
            public static string Schema =  "Schema" ;
            public static string IsDefaultVersion =  "IsDefaultVersion" ;
            public static string Visibility =  "Visibility" ;
            public static string Arn =  "Arn" ;
            public static string DocumentationUrl =  "DocumentationUrl" ;
        }

        public override string AWSTypeName { get => AWS.CloudFormation.ModuleVersion; }

        /// <summary>
        /// ModulePackage
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudformation-moduleversion.html#cfn-cloudformation-moduleversion-modulepackage
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic ModulePackage { get; set; }

        /// <summary>
        /// ModuleName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudformation-moduleversion.html#cfn-cloudformation-moduleversion-modulename
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic ModuleName { get; set; }
    }
}