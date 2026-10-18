namespace Humidifier.LaunchWizard
{
    using global::System.Collections.Generic;
    using DeploymentTypes;

    public class Deployment : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveStringDictionaryOfSpecifications, IHaveWorkloadName, IHaveListOfLaunchWizardDeploymentTypesTagsTags, IHaveDeploymentPatternName, IHaveName
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string DeploymentId =  "DeploymentId" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string Arn =  "Arn" ;
            public static string DeletedAt =  "DeletedAt" ;
            public static string ResourceGroup =  "ResourceGroup" ;
        }

        public override string AWSTypeName { get => AWS.LaunchWizard.Deployment; }
        /// <summary>
        /// Specifications
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-launchwizard-deployment.html#cfn-launchwizard-deployment-specifications
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? Specifications { get; set; }

        /// <summary>
        /// WorkloadName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-launchwizard-deployment.html#cfn-launchwizard-deployment-workloadname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? WorkloadName { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-launchwizard-deployment.html#cfn-launchwizard-deployment-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tags
        /// </summary>
        public Union<IReadOnlyList<Humidifier.LaunchWizard.DeploymentTypes.Tags>, IReadOnlyList<Union<Humidifier.LaunchWizard.DeploymentTypes.Tags, BaseFunction>>, BaseFunction>? Tags { get; set; }

        /// <summary>
        /// DeploymentPatternName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-launchwizard-deployment.html#cfn-launchwizard-deployment-deploymentpatternname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? DeploymentPatternName { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace DeploymentTypes
    {
        public class Tags : Humidifier.Base.BaseSubResource, IHaveValue, IHaveKey
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-launchwizard-deployment-tags.html#cfn-launchwizard-deployment-tags-value
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-launchwizard-deployment-tags.html#cfn-launchwizard-deployment-tags-key
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Key { get; set; }
        }
    }
}