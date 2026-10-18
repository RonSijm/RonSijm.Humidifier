namespace Humidifier.CodeDeploy
{
    using global::System.Collections.Generic;
    using DeploymentGroupTypes;

    public class DeploymentGroup : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveCodeDeployDeploymentGroupTypesOnPremisesTagSetOnPremisesTagSet, IHaveApplicationName, IHaveCodeDeployDeploymentGroupTypesDeploymentStyleDeploymentStyle, IHaveServiceRoleArn, IHaveCodeDeployDeploymentGroupTypesBlueGreenDeploymentConfigurationBlueGreenDeploymentConfiguration, IHaveStringListOfAutoScalingGroups, IHaveCodeDeployDeploymentGroupTypesEC2TagSetEc2TagSet, IHaveOutdatedInstancesStrategy, IHaveListOfCodeDeployDeploymentGroupTypesTriggerConfigTriggerConfigurations, IHaveCodeDeployDeploymentGroupTypesDeploymentDeployment, IHaveDeploymentConfigName, IHaveCodeDeployDeploymentGroupTypesAlarmConfigurationAlarmConfiguration, IHaveListOfCodeDeployDeploymentGroupTypesEC2TagFilterEc2TagFilters, IHaveTerminationHookEnabled_Boolean, IHaveListOfCodeDeployDeploymentGroupTypesECSServiceECSServices, IHaveCodeDeployDeploymentGroupTypesAutoRollbackConfigurationAutoRollbackConfiguration, IHaveCodeDeployDeploymentGroupTypesLoadBalancerInfoLoadBalancerInfo, IHaveDeploymentGroupName, IHaveListOfCodeDeployDeploymentGroupTypesTagFilterOnPremisesInstanceTagFilters
    {
        public override string AWSTypeName { get => AWS.CodeDeploy.DeploymentGroup; }
        /// <summary>
        /// OnPremisesTagSet
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codedeploy-deploymentgroup.html#cfn-codedeploy-deploymentgroup-onpremisestagset
        /// Required: False
        /// UpdateType: Mutable
        /// Type: OnPremisesTagSet
        /// </summary>
        public Union<Humidifier.CodeDeploy.DeploymentGroupTypes.OnPremisesTagSet, BaseFunction>? OnPremisesTagSet { get; set; }

        /// <summary>
        /// ApplicationName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codedeploy-deploymentgroup.html#cfn-codedeploy-deploymentgroup-applicationname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ApplicationName { get; set; }
        /// <summary>
        /// DeploymentStyle
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codedeploy-deploymentgroup.html#cfn-codedeploy-deploymentgroup-deploymentstyle
        /// Required: False
        /// UpdateType: Mutable
        /// Type: DeploymentStyle
        /// </summary>
        public Union<Humidifier.CodeDeploy.DeploymentGroupTypes.DeploymentStyle, BaseFunction>? DeploymentStyle { get; set; }

        /// <summary>
        /// ServiceRoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codedeploy-deploymentgroup.html#cfn-codedeploy-deploymentgroup-servicerolearn
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ServiceRoleArn { get; set; }
        /// <summary>
        /// BlueGreenDeploymentConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codedeploy-deploymentgroup.html#cfn-codedeploy-deploymentgroup-bluegreendeploymentconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: BlueGreenDeploymentConfiguration
        /// </summary>
        public Union<Humidifier.CodeDeploy.DeploymentGroupTypes.BlueGreenDeploymentConfiguration, BaseFunction>? BlueGreenDeploymentConfiguration { get; set; }
        /// <summary>
        /// AutoScalingGroups
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codedeploy-deploymentgroup.html#cfn-codedeploy-deploymentgroup-autoscalinggroups
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? AutoScalingGroups { get; set; }
        /// <summary>
        /// Ec2TagSet
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codedeploy-deploymentgroup.html#cfn-codedeploy-deploymentgroup-ec2tagset
        /// Required: False
        /// UpdateType: Mutable
        /// Type: EC2TagSet
        /// </summary>
        public Union<Humidifier.CodeDeploy.DeploymentGroupTypes.EC2TagSet, BaseFunction>? Ec2TagSet { get; set; }
        /// <summary>
        /// OutdatedInstancesStrategy
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codedeploy-deploymentgroup.html#cfn-codedeploy-deploymentgroup-outdatedinstancesstrategy
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? OutdatedInstancesStrategy { get; set; }
        /// <summary>
        /// TriggerConfigurations
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codedeploy-deploymentgroup.html#cfn-codedeploy-deploymentgroup-triggerconfigurations
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: TriggerConfig
        /// </summary>
        public Union<IReadOnlyList<Humidifier.CodeDeploy.DeploymentGroupTypes.TriggerConfig>, IReadOnlyList<Union<Humidifier.CodeDeploy.DeploymentGroupTypes.TriggerConfig, BaseFunction>>, BaseFunction>? TriggerConfigurations { get; set; }
        /// <summary>
        /// Deployment
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codedeploy-deploymentgroup.html#cfn-codedeploy-deploymentgroup-deployment
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Deployment
        /// </summary>
        public Union<Humidifier.CodeDeploy.DeploymentGroupTypes.Deployment, BaseFunction>? Deployment { get; set; }
        /// <summary>
        /// DeploymentConfigName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codedeploy-deploymentgroup.html#cfn-codedeploy-deploymentgroup-deploymentconfigname
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? DeploymentConfigName { get; set; }
        /// <summary>
        /// AlarmConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codedeploy-deploymentgroup.html#cfn-codedeploy-deploymentgroup-alarmconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: AlarmConfiguration
        /// </summary>
        public Union<Humidifier.CodeDeploy.DeploymentGroupTypes.AlarmConfiguration, BaseFunction>? AlarmConfiguration { get; set; }
        /// <summary>
        /// Ec2TagFilters
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codedeploy-deploymentgroup.html#cfn-codedeploy-deploymentgroup-ec2tagfilters
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: EC2TagFilter
        /// </summary>
        public Union<IReadOnlyList<Humidifier.CodeDeploy.DeploymentGroupTypes.EC2TagFilter>, IReadOnlyList<Union<Humidifier.CodeDeploy.DeploymentGroupTypes.EC2TagFilter, BaseFunction>>, BaseFunction>? Ec2TagFilters { get; set; }
        /// <summary>
        /// TerminationHookEnabled
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codedeploy-deploymentgroup.html#cfn-codedeploy-deploymentgroup-terminationhookenabled
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? TerminationHookEnabled { get; set; }
        /// <summary>
        /// ECSServices
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codedeploy-deploymentgroup.html#cfn-codedeploy-deploymentgroup-ecsservices
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: ECSService
        /// </summary>
        public Union<IReadOnlyList<Humidifier.CodeDeploy.DeploymentGroupTypes.ECSService>, IReadOnlyList<Union<Humidifier.CodeDeploy.DeploymentGroupTypes.ECSService, BaseFunction>>, BaseFunction>? ECSServices { get; set; }
        /// <summary>
        /// AutoRollbackConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codedeploy-deploymentgroup.html#cfn-codedeploy-deploymentgroup-autorollbackconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: AutoRollbackConfiguration
        /// </summary>
        public Union<Humidifier.CodeDeploy.DeploymentGroupTypes.AutoRollbackConfiguration, BaseFunction>? AutoRollbackConfiguration { get; set; }
        /// <summary>
        /// LoadBalancerInfo
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codedeploy-deploymentgroup.html#cfn-codedeploy-deploymentgroup-loadbalancerinfo
        /// Required: False
        /// UpdateType: Mutable
        /// Type: LoadBalancerInfo
        /// </summary>
        public Union<Humidifier.CodeDeploy.DeploymentGroupTypes.LoadBalancerInfo, BaseFunction>? LoadBalancerInfo { get; set; }
        public Union<string, BaseFunction>? DeploymentGroupName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codedeploy-deploymentgroup.html#cfn-codedeploy-deploymentgroup-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        /// <summary>
        /// OnPremisesInstanceTagFilters
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codedeploy-deploymentgroup.html#cfn-codedeploy-deploymentgroup-onpremisesinstancetagfilters
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: TagFilter
        /// </summary>
        public Union<IReadOnlyList<Humidifier.CodeDeploy.DeploymentGroupTypes.TagFilter>, IReadOnlyList<Union<Humidifier.CodeDeploy.DeploymentGroupTypes.TagFilter, BaseFunction>>, BaseFunction>? OnPremisesInstanceTagFilters { get; set; }
    }

    namespace DeploymentGroupTypes
    {
        public class Alarm : Humidifier.Base.BaseSubResource, IHaveName
        {
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codedeploy-deploymentgroup-alarm.html#cfn-codedeploy-deploymentgroup-alarm-name
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class AlarmConfiguration : Humidifier.Base.BaseSubResource, IHaveIgnorePollAlarmFailure_Boolean, IHaveListOfCodeDeployDeploymentGroupTypesAlarmAlarms, IHaveEnabled_Boolean
        {
            /// <summary>
            /// IgnorePollAlarmFailure
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codedeploy-deploymentgroup-alarmconfiguration.html#cfn-codedeploy-deploymentgroup-alarmconfiguration-ignorepollalarmfailure
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? IgnorePollAlarmFailure { get; set; }
            /// <summary>
            /// Alarms
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codedeploy-deploymentgroup-alarmconfiguration.html#cfn-codedeploy-deploymentgroup-alarmconfiguration-alarms
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Alarm
            /// </summary>
            public Union<IReadOnlyList<Humidifier.CodeDeploy.DeploymentGroupTypes.Alarm>, IReadOnlyList<Union<Humidifier.CodeDeploy.DeploymentGroupTypes.Alarm, BaseFunction>>, BaseFunction>? Alarms { get; set; }
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codedeploy-deploymentgroup-alarmconfiguration.html#cfn-codedeploy-deploymentgroup-alarmconfiguration-enabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Enabled { get; set; }
        }

        public class AutoRollbackConfiguration : Humidifier.Base.BaseSubResource, IHaveStringListOfEvents, IHaveEnabled_Boolean
        {
            /// <summary>
            /// Events
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codedeploy-deploymentgroup-autorollbackconfiguration.html#cfn-codedeploy-deploymentgroup-autorollbackconfiguration-events
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Events { get; set; }
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codedeploy-deploymentgroup-autorollbackconfiguration.html#cfn-codedeploy-deploymentgroup-autorollbackconfiguration-enabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Enabled { get; set; }
        }

        public class BlueGreenDeploymentConfiguration : Humidifier.Base.BaseSubResource, IHaveCodeDeployDeploymentGroupTypesDeploymentReadyOptionDeploymentReadyOption, IHaveCodeDeployDeploymentGroupTypesBlueInstanceTerminationOptionTerminateBlueInstancesOnDeploymentSuccess, IHaveCodeDeployDeploymentGroupTypesGreenFleetProvisioningOptionGreenFleetProvisioningOption
        {
            /// <summary>
            /// DeploymentReadyOption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codedeploy-deploymentgroup-bluegreendeploymentconfiguration.html#cfn-codedeploy-deploymentgroup-bluegreendeploymentconfiguration-deploymentreadyoption
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DeploymentReadyOption
            /// </summary>
            public Union<Humidifier.CodeDeploy.DeploymentGroupTypes.DeploymentReadyOption, BaseFunction>? DeploymentReadyOption { get; set; }
            /// <summary>
            /// TerminateBlueInstancesOnDeploymentSuccess
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codedeploy-deploymentgroup-bluegreendeploymentconfiguration.html#cfn-codedeploy-deploymentgroup-bluegreendeploymentconfiguration-terminateblueinstancesondeploymentsuccess
            /// Required: False
            /// UpdateType: Mutable
            /// Type: BlueInstanceTerminationOption
            /// </summary>
            public Union<Humidifier.CodeDeploy.DeploymentGroupTypes.BlueInstanceTerminationOption, BaseFunction>? TerminateBlueInstancesOnDeploymentSuccess { get; set; }
            /// <summary>
            /// GreenFleetProvisioningOption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codedeploy-deploymentgroup-bluegreendeploymentconfiguration.html#cfn-codedeploy-deploymentgroup-bluegreendeploymentconfiguration-greenfleetprovisioningoption
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GreenFleetProvisioningOption
            /// </summary>
            public Union<Humidifier.CodeDeploy.DeploymentGroupTypes.GreenFleetProvisioningOption, BaseFunction>? GreenFleetProvisioningOption { get; set; }
        }

        public class BlueInstanceTerminationOption : Humidifier.Base.BaseSubResource, IHaveAction, IHaveTerminationWaitTimeInMinutes_Integer
        {
            /// <summary>
            /// Action
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codedeploy-deploymentgroup-blueinstanceterminationoption.html#cfn-codedeploy-deploymentgroup-blueinstanceterminationoption-action
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Action { get; set; }
            /// <summary>
            /// TerminationWaitTimeInMinutes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codedeploy-deploymentgroup-blueinstanceterminationoption.html#cfn-codedeploy-deploymentgroup-blueinstanceterminationoption-terminationwaittimeinminutes
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? TerminationWaitTimeInMinutes { get; set; }
        }

        public class Deployment : Humidifier.Base.BaseSubResource, IHaveDescription, IHaveCodeDeployDeploymentGroupTypesRevisionLocationRevision, IHaveIgnoreApplicationStopFailures_Boolean
        {
            /// <summary>
            /// Description
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codedeploy-deploymentgroup-deployment.html#cfn-codedeploy-deploymentgroup-deployment-description
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Description { get; set; }
            /// <summary>
            /// Revision
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codedeploy-deploymentgroup-deployment.html#cfn-codedeploy-deploymentgroup-deployment-revision
            /// Required: True
            /// UpdateType: Mutable
            /// Type: RevisionLocation
            /// </summary>
            public Union<Humidifier.CodeDeploy.DeploymentGroupTypes.RevisionLocation, BaseFunction>? Revision { get; set; }
            /// <summary>
            /// IgnoreApplicationStopFailures
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codedeploy-deploymentgroup-deployment.html#cfn-codedeploy-deploymentgroup-deployment-ignoreapplicationstopfailures
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? IgnoreApplicationStopFailures { get; set; }
        }

        public class DeploymentReadyOption : Humidifier.Base.BaseSubResource, IHaveWaitTimeInMinutes_Integer, IHaveActionOnTimeout
        {
            /// <summary>
            /// WaitTimeInMinutes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codedeploy-deploymentgroup-deploymentreadyoption.html#cfn-codedeploy-deploymentgroup-deploymentreadyoption-waittimeinminutes
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? WaitTimeInMinutes { get; set; }
            /// <summary>
            /// ActionOnTimeout
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codedeploy-deploymentgroup-deploymentreadyoption.html#cfn-codedeploy-deploymentgroup-deploymentreadyoption-actionontimeout
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ActionOnTimeout { get; set; }
        }

        public class DeploymentStyle : Humidifier.Base.BaseSubResource, IHaveDeploymentType, IHaveDeploymentOption
        {
            /// <summary>
            /// DeploymentType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codedeploy-deploymentgroup-deploymentstyle.html#cfn-codedeploy-deploymentgroup-deploymentstyle-deploymenttype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DeploymentType { get; set; }
            /// <summary>
            /// DeploymentOption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codedeploy-deploymentgroup-deploymentstyle.html#cfn-codedeploy-deploymentgroup-deploymentstyle-deploymentoption
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DeploymentOption { get; set; }
        }

        public class EC2TagFilter : Humidifier.Base.BaseSubResource, IHaveValue, IHaveType, IHaveKey
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codedeploy-deploymentgroup-ec2tagfilter.html#cfn-codedeploy-deploymentgroup-ec2tagfilter-value
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codedeploy-deploymentgroup-ec2tagfilter.html#cfn-codedeploy-deploymentgroup-ec2tagfilter-type
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codedeploy-deploymentgroup-ec2tagfilter.html#cfn-codedeploy-deploymentgroup-ec2tagfilter-key
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Key { get; set; }
        }

        public class EC2TagSet : Humidifier.Base.BaseSubResource, IHaveListOfCodeDeployDeploymentGroupTypesEC2TagSetListObjectEc2TagSetList
        {
            /// <summary>
            /// Ec2TagSetList
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codedeploy-deploymentgroup-ec2tagset.html#cfn-codedeploy-deploymentgroup-ec2tagset-ec2tagsetlist
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: EC2TagSetListObject
            /// </summary>
            public Union<IReadOnlyList<Humidifier.CodeDeploy.DeploymentGroupTypes.EC2TagSetListObject>, IReadOnlyList<Union<Humidifier.CodeDeploy.DeploymentGroupTypes.EC2TagSetListObject, BaseFunction>>, BaseFunction>? Ec2TagSetList { get; set; }
        }

        public class EC2TagSetListObject : Humidifier.Base.BaseSubResource, IHaveListOfCodeDeployDeploymentGroupTypesEC2TagFilterEc2TagGroup
        {
            /// <summary>
            /// Ec2TagGroup
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codedeploy-deploymentgroup-ec2tagsetlistobject.html#cfn-codedeploy-deploymentgroup-ec2tagsetlistobject-ec2taggroup
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: EC2TagFilter
            /// </summary>
            public Union<IReadOnlyList<Humidifier.CodeDeploy.DeploymentGroupTypes.EC2TagFilter>, IReadOnlyList<Union<Humidifier.CodeDeploy.DeploymentGroupTypes.EC2TagFilter, BaseFunction>>, BaseFunction>? Ec2TagGroup { get; set; }
        }

        public class ECSService : Humidifier.Base.BaseSubResource, IHaveServiceName, IHaveClusterName
        {
            /// <summary>
            /// ServiceName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codedeploy-deploymentgroup-ecsservice.html#cfn-codedeploy-deploymentgroup-ecsservice-servicename
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ServiceName { get; set; }
            /// <summary>
            /// ClusterName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codedeploy-deploymentgroup-ecsservice.html#cfn-codedeploy-deploymentgroup-ecsservice-clustername
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ClusterName { get; set; }
        }

        public class ELBInfo : Humidifier.Base.BaseSubResource, IHaveName
        {
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codedeploy-deploymentgroup-elbinfo.html#cfn-codedeploy-deploymentgroup-elbinfo-name
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class GitHubLocation : Humidifier.Base.BaseSubResource, IHaveRepository, IHaveCommitId
        {
            /// <summary>
            /// Repository
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codedeploy-deploymentgroup-githublocation.html#cfn-codedeploy-deploymentgroup-githublocation-repository
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Repository { get; set; }
            /// <summary>
            /// CommitId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codedeploy-deploymentgroup-githublocation.html#cfn-codedeploy-deploymentgroup-githublocation-commitid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CommitId { get; set; }
        }

        public class GreenFleetProvisioningOption : Humidifier.Base.BaseSubResource, IHaveAction
        {
            /// <summary>
            /// Action
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codedeploy-deploymentgroup-greenfleetprovisioningoption.html#cfn-codedeploy-deploymentgroup-greenfleetprovisioningoption-action
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Action { get; set; }
        }

        public class LoadBalancerInfo : Humidifier.Base.BaseSubResource, IHaveListOfCodeDeployDeploymentGroupTypesELBInfoElbInfoList, IHaveListOfCodeDeployDeploymentGroupTypesTargetGroupInfoTargetGroupInfoList, IHaveListOfCodeDeployDeploymentGroupTypesTargetGroupPairInfoTargetGroupPairInfoList
        {
            /// <summary>
            /// ElbInfoList
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codedeploy-deploymentgroup-loadbalancerinfo.html#cfn-codedeploy-deploymentgroup-loadbalancerinfo-elbinfolist
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ELBInfo
            /// </summary>
            public Union<IReadOnlyList<Humidifier.CodeDeploy.DeploymentGroupTypes.ELBInfo>, IReadOnlyList<Union<Humidifier.CodeDeploy.DeploymentGroupTypes.ELBInfo, BaseFunction>>, BaseFunction>? ElbInfoList { get; set; }
            /// <summary>
            /// TargetGroupInfoList
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codedeploy-deploymentgroup-loadbalancerinfo.html#cfn-codedeploy-deploymentgroup-loadbalancerinfo-targetgroupinfolist
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: TargetGroupInfo
            /// </summary>
            public Union<IReadOnlyList<Humidifier.CodeDeploy.DeploymentGroupTypes.TargetGroupInfo>, IReadOnlyList<Union<Humidifier.CodeDeploy.DeploymentGroupTypes.TargetGroupInfo, BaseFunction>>, BaseFunction>? TargetGroupInfoList { get; set; }
            /// <summary>
            /// TargetGroupPairInfoList
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codedeploy-deploymentgroup-loadbalancerinfo.html#cfn-codedeploy-deploymentgroup-loadbalancerinfo-targetgrouppairinfolist
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: TargetGroupPairInfo
            /// </summary>
            public Union<IReadOnlyList<Humidifier.CodeDeploy.DeploymentGroupTypes.TargetGroupPairInfo>, IReadOnlyList<Union<Humidifier.CodeDeploy.DeploymentGroupTypes.TargetGroupPairInfo, BaseFunction>>, BaseFunction>? TargetGroupPairInfoList { get; set; }
        }

        public class OnPremisesTagSet : Humidifier.Base.BaseSubResource, IHaveListOfCodeDeployDeploymentGroupTypesOnPremisesTagSetListObjectOnPremisesTagSetList
        {
            /// <summary>
            /// OnPremisesTagSetList
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codedeploy-deploymentgroup-onpremisestagset.html#cfn-codedeploy-deploymentgroup-onpremisestagset-onpremisestagsetlist
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: OnPremisesTagSetListObject
            /// </summary>
            public Union<IReadOnlyList<Humidifier.CodeDeploy.DeploymentGroupTypes.OnPremisesTagSetListObject>, IReadOnlyList<Union<Humidifier.CodeDeploy.DeploymentGroupTypes.OnPremisesTagSetListObject, BaseFunction>>, BaseFunction>? OnPremisesTagSetList { get; set; }
        }

        public class OnPremisesTagSetListObject : Humidifier.Base.BaseSubResource, IHaveListOfCodeDeployDeploymentGroupTypesTagFilterOnPremisesTagGroup
        {
            /// <summary>
            /// OnPremisesTagGroup
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codedeploy-deploymentgroup-onpremisestagsetlistobject.html#cfn-codedeploy-deploymentgroup-onpremisestagsetlistobject-onpremisestaggroup
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: TagFilter
            /// </summary>
            public Union<IReadOnlyList<Humidifier.CodeDeploy.DeploymentGroupTypes.TagFilter>, IReadOnlyList<Union<Humidifier.CodeDeploy.DeploymentGroupTypes.TagFilter, BaseFunction>>, BaseFunction>? OnPremisesTagGroup { get; set; }
        }

        public class RevisionLocation : Humidifier.Base.BaseSubResource, IHaveCodeDeployDeploymentGroupTypesGitHubLocationGitHubLocation, IHaveRevisionType, IHaveCodeDeployDeploymentGroupTypesS3LocationS3Location
        {
            /// <summary>
            /// GitHubLocation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codedeploy-deploymentgroup-revisionlocation.html#cfn-codedeploy-deploymentgroup-revisionlocation-githublocation
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GitHubLocation
            /// </summary>
            public Union<Humidifier.CodeDeploy.DeploymentGroupTypes.GitHubLocation, BaseFunction>? GitHubLocation { get; set; }
            /// <summary>
            /// RevisionType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codedeploy-deploymentgroup-revisionlocation.html#cfn-codedeploy-deploymentgroup-revisionlocation-revisiontype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RevisionType { get; set; }
            /// <summary>
            /// S3Location
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codedeploy-deploymentgroup-revisionlocation.html#cfn-codedeploy-deploymentgroup-revisionlocation-s3location
            /// Required: False
            /// UpdateType: Mutable
            /// Type: S3Location
            /// </summary>
            public Union<Humidifier.CodeDeploy.DeploymentGroupTypes.S3Location, BaseFunction>? S3Location { get; set; }
        }

        public class S3Location : Humidifier.Base.BaseSubResource, IHaveBundleType, IHaveBucket, IHaveETag, IHaveVersion, IHaveKey
        {
            /// <summary>
            /// BundleType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codedeploy-deploymentgroup-s3location.html#cfn-codedeploy-deploymentgroup-s3location-bundletype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BundleType { get; set; }
            /// <summary>
            /// Bucket
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codedeploy-deploymentgroup-s3location.html#cfn-codedeploy-deploymentgroup-s3location-bucket
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Bucket { get; set; }
            /// <summary>
            /// ETag
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codedeploy-deploymentgroup-s3location.html#cfn-codedeploy-deploymentgroup-s3location-etag
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ETag { get; set; }
            /// <summary>
            /// Version
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codedeploy-deploymentgroup-s3location.html#cfn-codedeploy-deploymentgroup-s3location-version
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Version { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codedeploy-deploymentgroup-s3location.html#cfn-codedeploy-deploymentgroup-s3location-key
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Key { get; set; }
        }

        public class TagFilter : Humidifier.Base.BaseSubResource, IHaveValue, IHaveType, IHaveKey
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codedeploy-deploymentgroup-tagfilter.html#cfn-codedeploy-deploymentgroup-tagfilter-value
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codedeploy-deploymentgroup-tagfilter.html#cfn-codedeploy-deploymentgroup-tagfilter-type
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codedeploy-deploymentgroup-tagfilter.html#cfn-codedeploy-deploymentgroup-tagfilter-key
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Key { get; set; }
        }

        public class TargetGroupInfo : Humidifier.Base.BaseSubResource, IHaveName
        {
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codedeploy-deploymentgroup-targetgroupinfo.html#cfn-codedeploy-deploymentgroup-targetgroupinfo-name
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class TargetGroupPairInfo : Humidifier.Base.BaseSubResource, IHaveCodeDeployDeploymentGroupTypesTrafficRouteProdTrafficRoute, IHaveCodeDeployDeploymentGroupTypesTrafficRouteTestTrafficRoute, IHaveListOfCodeDeployDeploymentGroupTypesTargetGroupInfoTargetGroups
        {
            /// <summary>
            /// ProdTrafficRoute
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codedeploy-deploymentgroup-targetgrouppairinfo.html#cfn-codedeploy-deploymentgroup-targetgrouppairinfo-prodtrafficroute
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TrafficRoute
            /// </summary>
            public Union<Humidifier.CodeDeploy.DeploymentGroupTypes.TrafficRoute, BaseFunction>? ProdTrafficRoute { get; set; }
            /// <summary>
            /// TestTrafficRoute
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codedeploy-deploymentgroup-targetgrouppairinfo.html#cfn-codedeploy-deploymentgroup-targetgrouppairinfo-testtrafficroute
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TrafficRoute
            /// </summary>
            public Union<Humidifier.CodeDeploy.DeploymentGroupTypes.TrafficRoute, BaseFunction>? TestTrafficRoute { get; set; }
            /// <summary>
            /// TargetGroups
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codedeploy-deploymentgroup-targetgrouppairinfo.html#cfn-codedeploy-deploymentgroup-targetgrouppairinfo-targetgroups
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: TargetGroupInfo
            /// </summary>
            public Union<IReadOnlyList<Humidifier.CodeDeploy.DeploymentGroupTypes.TargetGroupInfo>, IReadOnlyList<Union<Humidifier.CodeDeploy.DeploymentGroupTypes.TargetGroupInfo, BaseFunction>>, BaseFunction>? TargetGroups { get; set; }
        }

        public class TrafficRoute : Humidifier.Base.BaseSubResource, IHaveStringListOfListenerArns
        {
            /// <summary>
            /// ListenerArns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codedeploy-deploymentgroup-trafficroute.html#cfn-codedeploy-deploymentgroup-trafficroute-listenerarns
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? ListenerArns { get; set; }
        }

        public class TriggerConfig : Humidifier.Base.BaseSubResource, IHaveTriggerName, IHaveStringListOfTriggerEvents, IHaveTriggerTargetArn
        {
            /// <summary>
            /// TriggerName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codedeploy-deploymentgroup-triggerconfig.html#cfn-codedeploy-deploymentgroup-triggerconfig-triggername
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TriggerName { get; set; }
            /// <summary>
            /// TriggerEvents
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codedeploy-deploymentgroup-triggerconfig.html#cfn-codedeploy-deploymentgroup-triggerconfig-triggerevents
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? TriggerEvents { get; set; }
            /// <summary>
            /// TriggerTargetArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codedeploy-deploymentgroup-triggerconfig.html#cfn-codedeploy-deploymentgroup-triggerconfig-triggertargetarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TriggerTargetArn { get; set; }
        }
    }
}