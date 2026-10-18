namespace Humidifier.NetworkSecurityManager
{
    using global::System.Collections.Generic;
    using DeploymentTypes;

    public class Deployment : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveListOfNetworkSecurityManagerDeploymentTypesAssociatedPolicyAssociatedPolicyList, IHaveDeploymentName, IHaveDeploymentDescription, IHaveListOfNetworkSecurityManagerDeploymentTypesAssociatedScopeAssociatedScopeList, IHaveNetworkSecurityManagerDeploymentTypesDeploymentConfigurationDeploymentConfiguration, IHaveDescription
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string DeploymentId =  "DeploymentId" ;
            public static string DeploymentArn =  "DeploymentArn" ;
            public static string Version =  "Version" ;
            public static string UpdatedAt =  "UpdatedAt" ;
        }

        public override string AWSTypeName { get => AWS.NetworkSecurityManager.Deployment; }
        /// <summary>
        /// AssociatedPolicyList
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networksecuritymanager-deployment.html#cfn-networksecuritymanager-deployment-associatedpolicylist
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: AssociatedPolicy
        /// </summary>
        public Union<IReadOnlyList<Humidifier.NetworkSecurityManager.DeploymentTypes.AssociatedPolicy>, IReadOnlyList<Union<Humidifier.NetworkSecurityManager.DeploymentTypes.AssociatedPolicy, BaseFunction>>, BaseFunction>? AssociatedPolicyList { get; set; }
        public Union<string, BaseFunction>? DeploymentName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// DeploymentDescription
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networksecuritymanager-deployment.html#cfn-networksecuritymanager-deployment-deploymentdescription
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? DeploymentDescription { get; set; }

        [Ignore]
        public Union<string, BaseFunction>? Description { get => DeploymentDescription; set => DeploymentDescription = value; }
        /// <summary>
        /// AssociatedScopeList
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networksecuritymanager-deployment.html#cfn-networksecuritymanager-deployment-associatedscopelist
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: AssociatedScope
        /// </summary>
        public Union<IReadOnlyList<Humidifier.NetworkSecurityManager.DeploymentTypes.AssociatedScope>, IReadOnlyList<Union<Humidifier.NetworkSecurityManager.DeploymentTypes.AssociatedScope, BaseFunction>>, BaseFunction>? AssociatedScopeList { get; set; }
        /// <summary>
        /// DeploymentConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networksecuritymanager-deployment.html#cfn-networksecuritymanager-deployment-deploymentconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: DeploymentConfiguration
        /// </summary>
        public Union<Humidifier.NetworkSecurityManager.DeploymentTypes.DeploymentConfiguration, BaseFunction>? DeploymentConfiguration { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networksecuritymanager-deployment.html#cfn-networksecuritymanager-deployment-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace DeploymentTypes
    {
        public class AssociatedPolicy : Humidifier.Base.BaseSubResource, IHavePolicyArn
        {
            /// <summary>
            /// PolicyArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networksecuritymanager-deployment-associatedpolicy.html#cfn-networksecuritymanager-deployment-associatedpolicy-policyarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PolicyArn { get; set; }
        }

        public class AssociatedScope : Humidifier.Base.BaseSubResource, IHaveScopeArn
        {
            /// <summary>
            /// ScopeArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networksecuritymanager-deployment-associatedscope.html#cfn-networksecuritymanager-deployment-associatedscope-scopearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ScopeArn { get; set; }
        }

        public class DeploymentConfiguration : Humidifier.Base.BaseSubResource, IHaveEnableCrossAccountVisibility_Boolean
        {
            /// <summary>
            /// EnableCrossAccountVisibility
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networksecuritymanager-deployment-deploymentconfiguration.html#cfn-networksecuritymanager-deployment-deploymentconfiguration-enablecrossaccountvisibility
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? EnableCrossAccountVisibility { get; set; }
        }
    }
}