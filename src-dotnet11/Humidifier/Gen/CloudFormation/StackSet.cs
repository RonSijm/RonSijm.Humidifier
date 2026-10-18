namespace Humidifier.CloudFormation
{
    using global::System.Collections.Generic;
    using StackSetTypes;

    public class StackSet : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveDescription, IHaveListOfCloudFormationStackSetTypesParameterParameters, IHaveListOfCloudFormationStackSetTypesStackInstancesStackInstancesGroup, IHaveTemplateBody, IHaveStackSetName, IHaveCallAs, IHaveCloudFormationStackSetTypesOperationPreferencesOperationPreferences, IHaveTemplateURL, IHaveCloudFormationStackSetTypesAutoDeploymentAutoDeployment, IHaveStringListOfCapabilities, IHavePermissionModel, IHaveAdministrationRoleARN, IHaveExecutionRoleName, IHaveCloudFormationStackSetTypesManagedExecutionManagedExecution
    {
        public class Attributes
        {
            public static string StackSetId =  "StackSetId" ;
        }

        public override string AWSTypeName { get => AWS.CloudFormation.StackSet; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudformation-stackset.html#cfn-cloudformation-stackset-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// Parameters
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudformation-stackset.html#cfn-cloudformation-stackset-parameters
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Parameter
        /// </summary>
        public Union<IReadOnlyList<Humidifier.CloudFormation.StackSetTypes.Parameter>, IReadOnlyList<Union<Humidifier.CloudFormation.StackSetTypes.Parameter, BaseFunction>>, BaseFunction>? Parameters { get; set; }
        /// <summary>
        /// StackInstancesGroup
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudformation-stackset.html#cfn-cloudformation-stackset-stackinstancesgroup
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: StackInstances
        /// </summary>
        public Union<IReadOnlyList<Humidifier.CloudFormation.StackSetTypes.StackInstances>, IReadOnlyList<Union<Humidifier.CloudFormation.StackSetTypes.StackInstances, BaseFunction>>, BaseFunction>? StackInstancesGroup { get; set; }
        /// <summary>
        /// TemplateBody
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudformation-stackset.html#cfn-cloudformation-stackset-templatebody
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? TemplateBody { get; set; }
        public Union<string, BaseFunction>? StackSetName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// CallAs
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudformation-stackset.html#cfn-cloudformation-stackset-callas
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? CallAs { get; set; }
        /// <summary>
        /// OperationPreferences
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudformation-stackset.html#cfn-cloudformation-stackset-operationpreferences
        /// Required: False
        /// UpdateType: Mutable
        /// Type: OperationPreferences
        /// </summary>
        public Union<Humidifier.CloudFormation.StackSetTypes.OperationPreferences, BaseFunction>? OperationPreferences { get; set; }
        /// <summary>
        /// TemplateURL
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudformation-stackset.html#cfn-cloudformation-stackset-templateurl
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? TemplateURL { get; set; }
        /// <summary>
        /// AutoDeployment
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudformation-stackset.html#cfn-cloudformation-stackset-autodeployment
        /// Required: False
        /// UpdateType: Mutable
        /// Type: AutoDeployment
        /// </summary>
        public Union<Humidifier.CloudFormation.StackSetTypes.AutoDeployment, BaseFunction>? AutoDeployment { get; set; }
        /// <summary>
        /// Capabilities
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudformation-stackset.html#cfn-cloudformation-stackset-capabilities
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Capabilities { get; set; }

        /// <summary>
        /// PermissionModel
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudformation-stackset.html#cfn-cloudformation-stackset-permissionmodel
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? PermissionModel { get; set; }
        /// <summary>
        /// AdministrationRoleARN
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudformation-stackset.html#cfn-cloudformation-stackset-administrationrolearn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? AdministrationRoleARN { get; set; }
        /// <summary>
        /// ExecutionRoleName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudformation-stackset.html#cfn-cloudformation-stackset-executionrolename
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ExecutionRoleName { get; set; }
        /// <summary>
        /// ManagedExecution
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudformation-stackset.html#cfn-cloudformation-stackset-managedexecution
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ManagedExecution
        /// </summary>
        public Union<Humidifier.CloudFormation.StackSetTypes.ManagedExecution, BaseFunction>? ManagedExecution { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudformation-stackset.html#cfn-cloudformation-stackset-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace StackSetTypes
    {
        public class AutoDeployment : Humidifier.Base.BaseSubResource, IHaveStringListOfDependsOn, IHaveEnabled_Boolean, IHaveRetainStacksOnAccountRemoval_Boolean
        {
            /// <summary>
            /// DependsOn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudformation-stackset-autodeployment.html#cfn-cloudformation-stackset-autodeployment-dependson
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? DependsOn { get; set; }
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudformation-stackset-autodeployment.html#cfn-cloudformation-stackset-autodeployment-enabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Enabled { get; set; }
            /// <summary>
            /// RetainStacksOnAccountRemoval
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudformation-stackset-autodeployment.html#cfn-cloudformation-stackset-autodeployment-retainstacksonaccountremoval
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? RetainStacksOnAccountRemoval { get; set; }
        }

        public class DeploymentTargets : Humidifier.Base.BaseSubResource, IHaveAccountFilterType, IHaveStringListOfAccounts, IHaveAccountsUrl, IHaveStringListOfOrganizationalUnitIds
        {
            /// <summary>
            /// AccountFilterType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudformation-stackset-deploymenttargets.html#cfn-cloudformation-stackset-deploymenttargets-accountfiltertype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AccountFilterType { get; set; }
            /// <summary>
            /// Accounts
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudformation-stackset-deploymenttargets.html#cfn-cloudformation-stackset-deploymenttargets-accounts
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Accounts { get; set; }
            /// <summary>
            /// AccountsUrl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudformation-stackset-deploymenttargets.html#cfn-cloudformation-stackset-deploymenttargets-accountsurl
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AccountsUrl { get; set; }
            /// <summary>
            /// OrganizationalUnitIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudformation-stackset-deploymenttargets.html#cfn-cloudformation-stackset-deploymenttargets-organizationalunitids
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? OrganizationalUnitIds { get; set; }
        }

        public class ManagedExecution : Humidifier.Base.BaseSubResource, IHaveActive_Boolean
        {
            /// <summary>
            /// Active
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudformation-stackset-managedexecution.html#cfn-cloudformation-stackset-managedexecution-active
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Active { get; set; }
        }

        public class OperationPreferences : Humidifier.Base.BaseSubResource, IHaveMaxConcurrentPercentage_Integer, IHaveRegionConcurrencyType, IHaveMaxConcurrentCount_Integer, IHaveFailureTolerancePercentage_Integer, IHaveConcurrencyMode, IHaveFailureToleranceCount_Integer, IHaveStringListOfRegionOrder
        {
            /// <summary>
            /// MaxConcurrentPercentage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudformation-stackset-operationpreferences.html#cfn-cloudformation-stackset-operationpreferences-maxconcurrentpercentage
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaxConcurrentPercentage { get; set; }
            /// <summary>
            /// RegionConcurrencyType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudformation-stackset-operationpreferences.html#cfn-cloudformation-stackset-operationpreferences-regionconcurrencytype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RegionConcurrencyType { get; set; }
            /// <summary>
            /// MaxConcurrentCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudformation-stackset-operationpreferences.html#cfn-cloudformation-stackset-operationpreferences-maxconcurrentcount
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaxConcurrentCount { get; set; }
            /// <summary>
            /// FailureTolerancePercentage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudformation-stackset-operationpreferences.html#cfn-cloudformation-stackset-operationpreferences-failuretolerancepercentage
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? FailureTolerancePercentage { get; set; }
            /// <summary>
            /// ConcurrencyMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudformation-stackset-operationpreferences.html#cfn-cloudformation-stackset-operationpreferences-concurrencymode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ConcurrencyMode { get; set; }
            /// <summary>
            /// FailureToleranceCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudformation-stackset-operationpreferences.html#cfn-cloudformation-stackset-operationpreferences-failuretolerancecount
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? FailureToleranceCount { get; set; }
            /// <summary>
            /// RegionOrder
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudformation-stackset-operationpreferences.html#cfn-cloudformation-stackset-operationpreferences-regionorder
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? RegionOrder { get; set; }
        }

        public class Parameter : Humidifier.Base.BaseSubResource, IHaveParameterValue, IHaveParameterKey
        {
            /// <summary>
            /// ParameterValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudformation-stackset-parameter.html#cfn-cloudformation-stackset-parameter-parametervalue
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ParameterValue { get; set; }
            /// <summary>
            /// ParameterKey
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudformation-stackset-parameter.html#cfn-cloudformation-stackset-parameter-parameterkey
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ParameterKey { get; set; }
        }

        public class StackInstances : Humidifier.Base.BaseSubResource, IHaveListOfCloudFormationStackSetTypesParameterParameterOverrides, IHaveCloudFormationStackSetTypesDeploymentTargetsDeploymentTargets, IHaveStringListOfRegions
        {
            /// <summary>
            /// ParameterOverrides
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudformation-stackset-stackinstances.html#cfn-cloudformation-stackset-stackinstances-parameteroverrides
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Parameter
            /// </summary>
            public Union<IReadOnlyList<Humidifier.CloudFormation.StackSetTypes.Parameter>, IReadOnlyList<Union<Humidifier.CloudFormation.StackSetTypes.Parameter, BaseFunction>>, BaseFunction>? ParameterOverrides { get; set; }
            /// <summary>
            /// DeploymentTargets
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudformation-stackset-stackinstances.html#cfn-cloudformation-stackset-stackinstances-deploymenttargets
            /// Required: True
            /// UpdateType: Mutable
            /// Type: DeploymentTargets
            /// </summary>
            public Union<Humidifier.CloudFormation.StackSetTypes.DeploymentTargets, BaseFunction>? DeploymentTargets { get; set; }
            /// <summary>
            /// Regions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudformation-stackset-stackinstances.html#cfn-cloudformation-stackset-stackinstances-regions
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Regions { get; set; }
        }
    }
}