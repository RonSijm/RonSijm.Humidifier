namespace Humidifier.DataZone
{
    using System.Collections.Generic;
    using EnvironmentTypes;

    public class Environment : Humidifier.Resource, IHaveDescription
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string CreatedBy =  "CreatedBy" ;
            public static string DomainId =  "DomainId" ;
            public static string EnvironmentProfileId =  "EnvironmentProfileId" ;
            public static string AwsAccountRegion =  "AwsAccountRegion" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string ProjectId =  "ProjectId" ;
            public static string AwsAccountId =  "AwsAccountId" ;
            public static string EnvironmentBlueprintId =  "EnvironmentBlueprintId" ;
            public static string Id =  "Id" ;
            public static string UpdatedAt =  "UpdatedAt" ;
            public static string Provider =  "Provider" ;
        }

        public override string AWSTypeName
        {
            get
            {
                return @"AWS::DataZone::Environment";
            }
        }

        /// <summary>
        /// ProjectIdentifier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datazone-environment.html#cfn-datazone-environment-projectidentifier
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ProjectIdentifier { get; set; }
        /// <summary>
        /// UserParameters
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datazone-environment.html#cfn-datazone-environment-userparameters
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: EnvironmentParameter
        /// </summary>
        public List<EnvironmentParameter> UserParameters { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datazone-environment.html#cfn-datazone-environment-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Description { get; set; }
        /// <summary>
        /// EnvironmentProfileIdentifier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datazone-environment.html#cfn-datazone-environment-environmentprofileidentifier
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic EnvironmentProfileIdentifier { get; set; }
        /// <summary>
        /// GlossaryTerms
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datazone-environment.html#cfn-datazone-environment-glossaryterms
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public dynamic GlossaryTerms { get; set; }
        /// <summary>
        /// Name
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datazone-environment.html#cfn-datazone-environment-name
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Name { get; set; }
        /// <summary>
        /// DomainIdentifier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datazone-environment.html#cfn-datazone-environment-domainidentifier
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic DomainIdentifier { get; set; }
    }

    namespace EnvironmentTypes
    {
        public class EnvironmentParameter
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-environment-environmentparameter.html#cfn-datazone-environment-environmentparameter-value
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Value { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-environment-environmentparameter.html#cfn-datazone-environment-environmentparameter-name
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }
    }
}