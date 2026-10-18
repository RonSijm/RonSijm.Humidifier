namespace Humidifier.Events
{
    using global::System.Collections.Generic;
    using RuleTypes;

    public class Rule : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveEventBusName, IHaveEventPattern_Json, IHaveScheduleExpression, IHaveDescription, IHaveState, IHaveListOfEventsRuleTypesTargetTargets, IHaveRoleArn, IHaveName
    {
        public class Attributes
        {
            public static string Arn =  "Arn" ;
            public static string RuleName =  "RuleName" ;
        }

        public override string AWSTypeName { get => AWS.Events.Rule; }
        /// <summary>
        /// EventBusName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-events-rule.html#cfn-events-rule-eventbusname
        /// Required: False
        /// UpdateType: Conditional
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? EventBusName { get; set; }
        /// <summary>
        /// EventPattern
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-events-rule.html#cfn-events-rule-eventpattern
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Json
        /// </summary>
        public Union<object, BaseFunction>? EventPattern { get; set; }
        /// <summary>
        /// ScheduleExpression
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-events-rule.html#cfn-events-rule-scheduleexpression
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ScheduleExpression { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-events-rule.html#cfn-events-rule-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// State
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-events-rule.html#cfn-events-rule-state
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? State { get; set; }
        /// <summary>
        /// Targets
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-events-rule.html#cfn-events-rule-targets
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Target
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Events.RuleTypes.Target>, IReadOnlyList<Union<Humidifier.Events.RuleTypes.Target, BaseFunction>>, BaseFunction>? Targets { get; set; }
        /// <summary>
        /// RoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-events-rule.html#cfn-events-rule-rolearn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? RoleArn { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-events-rule.html#cfn-events-rule-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace RuleTypes
    {
        public class AppSyncParameters : Humidifier.Base.BaseSubResource, IHaveGraphQLOperation
        {
            /// <summary>
            /// GraphQLOperation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-events-rule-appsyncparameters.html#cfn-events-rule-appsyncparameters-graphqloperation
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? GraphQLOperation { get; set; }
        }

        public class AwsVpcConfiguration : Humidifier.Base.BaseSubResource, IHaveStringListOfSecurityGroups, IHaveStringListOfSubnets, IHaveAssignPublicIp
        {
            /// <summary>
            /// SecurityGroups
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-events-rule-awsvpcconfiguration.html#cfn-events-rule-awsvpcconfiguration-securitygroups
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SecurityGroups { get; set; }
            /// <summary>
            /// Subnets
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-events-rule-awsvpcconfiguration.html#cfn-events-rule-awsvpcconfiguration-subnets
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Subnets { get; set; }
            /// <summary>
            /// AssignPublicIp
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-events-rule-awsvpcconfiguration.html#cfn-events-rule-awsvpcconfiguration-assignpublicip
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AssignPublicIp { get; set; }
        }

        public class BatchArrayProperties : Humidifier.Base.BaseSubResource, IHaveSize_Integer
        {
            /// <summary>
            /// Size
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-events-rule-batcharrayproperties.html#cfn-events-rule-batcharrayproperties-size
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Size { get; set; }
        }

        public class BatchParameters : Humidifier.Base.BaseSubResource, IHaveEventsRuleTypesBatchArrayPropertiesArrayProperties, IHaveJobName, IHaveEventsRuleTypesBatchRetryStrategyRetryStrategy, IHaveJobDefinition
        {
            /// <summary>
            /// ArrayProperties
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-events-rule-batchparameters.html#cfn-events-rule-batchparameters-arrayproperties
            /// Required: False
            /// UpdateType: Mutable
            /// Type: BatchArrayProperties
            /// </summary>
            public Union<Humidifier.Events.RuleTypes.BatchArrayProperties, BaseFunction>? ArrayProperties { get; set; }
            /// <summary>
            /// JobName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-events-rule-batchparameters.html#cfn-events-rule-batchparameters-jobname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? JobName { get; set; }
            /// <summary>
            /// RetryStrategy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-events-rule-batchparameters.html#cfn-events-rule-batchparameters-retrystrategy
            /// Required: False
            /// UpdateType: Mutable
            /// Type: BatchRetryStrategy
            /// </summary>
            public Union<Humidifier.Events.RuleTypes.BatchRetryStrategy, BaseFunction>? RetryStrategy { get; set; }
            /// <summary>
            /// JobDefinition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-events-rule-batchparameters.html#cfn-events-rule-batchparameters-jobdefinition
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? JobDefinition { get; set; }
        }

        public class BatchRetryStrategy : Humidifier.Base.BaseSubResource, IHaveAttempts_Integer
        {
            /// <summary>
            /// Attempts
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-events-rule-batchretrystrategy.html#cfn-events-rule-batchretrystrategy-attempts
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Attempts { get; set; }
        }

        public class CapacityProviderStrategyItem : Humidifier.Base.BaseSubResource, IHaveCapacityProvider, IHaveBase_Integer, IHaveWeight_Integer
        {
            /// <summary>
            /// CapacityProvider
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-events-rule-capacityproviderstrategyitem.html#cfn-events-rule-capacityproviderstrategyitem-capacityprovider
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CapacityProvider { get; set; }
            /// <summary>
            /// Base
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-events-rule-capacityproviderstrategyitem.html#cfn-events-rule-capacityproviderstrategyitem-base
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Base { get; set; }
            /// <summary>
            /// Weight
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-events-rule-capacityproviderstrategyitem.html#cfn-events-rule-capacityproviderstrategyitem-weight
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Weight { get; set; }
        }

        public class DeadLetterConfig : Humidifier.Base.BaseSubResource, IHaveArn
        {
            /// <summary>
            /// Arn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-events-rule-deadletterconfig.html#cfn-events-rule-deadletterconfig-arn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Arn { get; set; }
        }

        public class EcsParameters : Humidifier.Base.BaseSubResource, IHavePlatformVersion, IHaveGroup, IHaveEnableECSManagedTags_Boolean, IHaveEnableExecuteCommand_Boolean, IHaveListOfEventsRuleTypesPlacementConstraintPlacementConstraints, IHavePropagateTags, IHaveTaskCount_Integer, IHaveListOfEventsRuleTypesPlacementStrategyPlacementStrategies, IHaveListOfEventsRuleTypesCapacityProviderStrategyItemCapacityProviderStrategy, IHaveLaunchType, IHaveReferenceId, IHaveTagListOfTagList, IHaveEventsRuleTypesNetworkConfigurationNetworkConfiguration, IHaveTaskDefinitionArn
        {
            /// <summary>
            /// PlatformVersion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-events-rule-ecsparameters.html#cfn-events-rule-ecsparameters-platformversion
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PlatformVersion { get; set; }
            /// <summary>
            /// Group
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-events-rule-ecsparameters.html#cfn-events-rule-ecsparameters-group
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Group { get; set; }
            /// <summary>
            /// EnableECSManagedTags
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-events-rule-ecsparameters.html#cfn-events-rule-ecsparameters-enableecsmanagedtags
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? EnableECSManagedTags { get; set; }
            /// <summary>
            /// EnableExecuteCommand
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-events-rule-ecsparameters.html#cfn-events-rule-ecsparameters-enableexecutecommand
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? EnableExecuteCommand { get; set; }
            /// <summary>
            /// PlacementConstraints
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-events-rule-ecsparameters.html#cfn-events-rule-ecsparameters-placementconstraints
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: PlacementConstraint
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Events.RuleTypes.PlacementConstraint>, IReadOnlyList<Union<Humidifier.Events.RuleTypes.PlacementConstraint, BaseFunction>>, BaseFunction>? PlacementConstraints { get; set; }
            /// <summary>
            /// PropagateTags
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-events-rule-ecsparameters.html#cfn-events-rule-ecsparameters-propagatetags
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PropagateTags { get; set; }
            /// <summary>
            /// TaskCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-events-rule-ecsparameters.html#cfn-events-rule-ecsparameters-taskcount
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? TaskCount { get; set; }
            /// <summary>
            /// PlacementStrategies
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-events-rule-ecsparameters.html#cfn-events-rule-ecsparameters-placementstrategies
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: PlacementStrategy
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Events.RuleTypes.PlacementStrategy>, IReadOnlyList<Union<Humidifier.Events.RuleTypes.PlacementStrategy, BaseFunction>>, BaseFunction>? PlacementStrategies { get; set; }
            /// <summary>
            /// CapacityProviderStrategy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-events-rule-ecsparameters.html#cfn-events-rule-ecsparameters-capacityproviderstrategy
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: CapacityProviderStrategyItem
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Events.RuleTypes.CapacityProviderStrategyItem>, IReadOnlyList<Union<Humidifier.Events.RuleTypes.CapacityProviderStrategyItem, BaseFunction>>, BaseFunction>? CapacityProviderStrategy { get; set; }
            /// <summary>
            /// LaunchType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-events-rule-ecsparameters.html#cfn-events-rule-ecsparameters-launchtype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LaunchType { get; set; }
            /// <summary>
            /// ReferenceId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-events-rule-ecsparameters.html#cfn-events-rule-ecsparameters-referenceid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ReferenceId { get; set; }
            /// <summary>
            /// TagList
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-events-rule-ecsparameters.html#cfn-events-rule-ecsparameters-taglist
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Tag
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? TagList { get; set; }
            /// <summary>
            /// NetworkConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-events-rule-ecsparameters.html#cfn-events-rule-ecsparameters-networkconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NetworkConfiguration
            /// </summary>
            public Union<Humidifier.Events.RuleTypes.NetworkConfiguration, BaseFunction>? NetworkConfiguration { get; set; }
            /// <summary>
            /// TaskDefinitionArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-events-rule-ecsparameters.html#cfn-events-rule-ecsparameters-taskdefinitionarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TaskDefinitionArn { get; set; }
        }

        public class HttpParameters : Humidifier.Base.BaseSubResource, IHaveStringListOfPathParameterValues, IHaveStringDictionaryOfHeaderParameters, IHaveStringDictionaryOfQueryStringParameters
        {
            /// <summary>
            /// PathParameterValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-events-rule-httpparameters.html#cfn-events-rule-httpparameters-pathparametervalues
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? PathParameterValues { get; set; }
            /// <summary>
            /// HeaderParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-events-rule-httpparameters.html#cfn-events-rule-httpparameters-headerparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? HeaderParameters { get; set; }
            /// <summary>
            /// QueryStringParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-events-rule-httpparameters.html#cfn-events-rule-httpparameters-querystringparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? QueryStringParameters { get; set; }
        }

        public class InputTransformer : Humidifier.Base.BaseSubResource, IHaveStringDictionaryOfInputPathsMap, IHaveInputTemplate
        {
            /// <summary>
            /// InputPathsMap
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-events-rule-inputtransformer.html#cfn-events-rule-inputtransformer-inputpathsmap
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? InputPathsMap { get; set; }
            /// <summary>
            /// InputTemplate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-events-rule-inputtransformer.html#cfn-events-rule-inputtransformer-inputtemplate
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InputTemplate { get; set; }
        }

        public class KinesisParameters : Humidifier.Base.BaseSubResource, IHavePartitionKeyPath
        {
            /// <summary>
            /// PartitionKeyPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-events-rule-kinesisparameters.html#cfn-events-rule-kinesisparameters-partitionkeypath
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PartitionKeyPath { get; set; }
        }

        public class NetworkConfiguration : Humidifier.Base.BaseSubResource, IHaveEventsRuleTypesAwsVpcConfigurationAwsVpcConfiguration
        {
            /// <summary>
            /// AwsVpcConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-events-rule-networkconfiguration.html#cfn-events-rule-networkconfiguration-awsvpcconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AwsVpcConfiguration
            /// </summary>
            public Union<Humidifier.Events.RuleTypes.AwsVpcConfiguration, BaseFunction>? AwsVpcConfiguration { get; set; }
        }

        public class PlacementConstraint : Humidifier.Base.BaseSubResource, IHaveType, IHaveExpression
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-events-rule-placementconstraint.html#cfn-events-rule-placementconstraint-type
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// Expression
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-events-rule-placementconstraint.html#cfn-events-rule-placementconstraint-expression
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Expression { get; set; }
        }

        public class PlacementStrategy : Humidifier.Base.BaseSubResource, IHaveField, IHaveType
        {
            /// <summary>
            /// Field
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-events-rule-placementstrategy.html#cfn-events-rule-placementstrategy-field
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Field { get; set; }
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-events-rule-placementstrategy.html#cfn-events-rule-placementstrategy-type
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
        }

        public class RedshiftDataParameters : Humidifier.Base.BaseSubResource, IHaveStatementName, IHaveStringListOfSqls, IHaveDatabase, IHaveSecretManagerArn, IHaveDbUser, IHaveSql, IHaveWithEvent_Boolean
        {
            /// <summary>
            /// StatementName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-events-rule-redshiftdataparameters.html#cfn-events-rule-redshiftdataparameters-statementname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? StatementName { get; set; }
            /// <summary>
            /// Sqls
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-events-rule-redshiftdataparameters.html#cfn-events-rule-redshiftdataparameters-sqls
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Sqls { get; set; }
            /// <summary>
            /// Database
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-events-rule-redshiftdataparameters.html#cfn-events-rule-redshiftdataparameters-database
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Database { get; set; }
            /// <summary>
            /// SecretManagerArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-events-rule-redshiftdataparameters.html#cfn-events-rule-redshiftdataparameters-secretmanagerarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SecretManagerArn { get; set; }
            /// <summary>
            /// DbUser
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-events-rule-redshiftdataparameters.html#cfn-events-rule-redshiftdataparameters-dbuser
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DbUser { get; set; }
            /// <summary>
            /// Sql
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-events-rule-redshiftdataparameters.html#cfn-events-rule-redshiftdataparameters-sql
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Sql { get; set; }
            /// <summary>
            /// WithEvent
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-events-rule-redshiftdataparameters.html#cfn-events-rule-redshiftdataparameters-withevent
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? WithEvent { get; set; }
        }

        public class RetryPolicy : Humidifier.Base.BaseSubResource, IHaveMaximumRetryAttempts_Integer, IHaveMaximumEventAgeInSeconds_Integer
        {
            /// <summary>
            /// MaximumRetryAttempts
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-events-rule-retrypolicy.html#cfn-events-rule-retrypolicy-maximumretryattempts
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaximumRetryAttempts { get; set; }
            /// <summary>
            /// MaximumEventAgeInSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-events-rule-retrypolicy.html#cfn-events-rule-retrypolicy-maximumeventageinseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaximumEventAgeInSeconds { get; set; }
        }

        public class RunCommandParameters : Humidifier.Base.BaseSubResource, IHaveListOfEventsRuleTypesRunCommandTargetRunCommandTargets
        {
            /// <summary>
            /// RunCommandTargets
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-events-rule-runcommandparameters.html#cfn-events-rule-runcommandparameters-runcommandtargets
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: RunCommandTarget
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Events.RuleTypes.RunCommandTarget>, IReadOnlyList<Union<Humidifier.Events.RuleTypes.RunCommandTarget, BaseFunction>>, BaseFunction>? RunCommandTargets { get; set; }
        }

        public class RunCommandTarget : Humidifier.Base.BaseSubResource, IHaveStringListOfValues, IHaveKey
        {
            /// <summary>
            /// Values
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-events-rule-runcommandtarget.html#cfn-events-rule-runcommandtarget-values
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Values { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-events-rule-runcommandtarget.html#cfn-events-rule-runcommandtarget-key
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Key { get; set; }
        }

        public class SageMakerPipelineParameter : Humidifier.Base.BaseSubResource, IHaveValue, IHaveName
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-events-rule-sagemakerpipelineparameter.html#cfn-events-rule-sagemakerpipelineparameter-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-events-rule-sagemakerpipelineparameter.html#cfn-events-rule-sagemakerpipelineparameter-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class SageMakerPipelineParameters : Humidifier.Base.BaseSubResource, IHaveListOfEventsRuleTypesSageMakerPipelineParameterPipelineParameterList
        {
            /// <summary>
            /// PipelineParameterList
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-events-rule-sagemakerpipelineparameters.html#cfn-events-rule-sagemakerpipelineparameters-pipelineparameterlist
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: SageMakerPipelineParameter
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Events.RuleTypes.SageMakerPipelineParameter>, IReadOnlyList<Union<Humidifier.Events.RuleTypes.SageMakerPipelineParameter, BaseFunction>>, BaseFunction>? PipelineParameterList { get; set; }
        }

        public class SqsParameters : Humidifier.Base.BaseSubResource, IHaveMessageGroupId
        {
            /// <summary>
            /// MessageGroupId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-events-rule-sqsparameters.html#cfn-events-rule-sqsparameters-messagegroupid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MessageGroupId { get; set; }
        }

        public class Target : Humidifier.Base.BaseSubResource, IHaveInputPath, IHaveEventsRuleTypesHttpParametersHttpParameters, IHaveEventsRuleTypesDeadLetterConfigDeadLetterConfig, IHaveEventsRuleTypesRunCommandParametersRunCommandParameters, IHaveEventsRuleTypesInputTransformerInputTransformer, IHaveEventsRuleTypesKinesisParametersKinesisParameters, IHaveRoleArn, IHaveEventsRuleTypesRedshiftDataParametersRedshiftDataParameters, IHaveEventsRuleTypesAppSyncParametersAppSyncParameters, IHaveInput, IHaveEventsRuleTypesSqsParametersSqsParameters, IHaveEventsRuleTypesEcsParametersEcsParameters, IHaveEventsRuleTypesBatchParametersBatchParameters, IHaveId, IHaveArn, IHaveEventsRuleTypesSageMakerPipelineParametersSageMakerPipelineParameters, IHaveEventsRuleTypesRetryPolicyRetryPolicy
        {
            /// <summary>
            /// InputPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-events-rule-target.html#cfn-events-rule-target-inputpath
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InputPath { get; set; }
            /// <summary>
            /// HttpParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-events-rule-target.html#cfn-events-rule-target-httpparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HttpParameters
            /// </summary>
            public Union<Humidifier.Events.RuleTypes.HttpParameters, BaseFunction>? HttpParameters { get; set; }
            /// <summary>
            /// DeadLetterConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-events-rule-target.html#cfn-events-rule-target-deadletterconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DeadLetterConfig
            /// </summary>
            public Union<Humidifier.Events.RuleTypes.DeadLetterConfig, BaseFunction>? DeadLetterConfig { get; set; }
            /// <summary>
            /// RunCommandParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-events-rule-target.html#cfn-events-rule-target-runcommandparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RunCommandParameters
            /// </summary>
            public Union<Humidifier.Events.RuleTypes.RunCommandParameters, BaseFunction>? RunCommandParameters { get; set; }
            /// <summary>
            /// InputTransformer
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-events-rule-target.html#cfn-events-rule-target-inputtransformer
            /// Required: False
            /// UpdateType: Mutable
            /// Type: InputTransformer
            /// </summary>
            public Union<Humidifier.Events.RuleTypes.InputTransformer, BaseFunction>? InputTransformer { get; set; }
            /// <summary>
            /// KinesisParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-events-rule-target.html#cfn-events-rule-target-kinesisparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: KinesisParameters
            /// </summary>
            public Union<Humidifier.Events.RuleTypes.KinesisParameters, BaseFunction>? KinesisParameters { get; set; }
            /// <summary>
            /// RoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-events-rule-target.html#cfn-events-rule-target-rolearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RoleArn { get; set; }
            /// <summary>
            /// RedshiftDataParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-events-rule-target.html#cfn-events-rule-target-redshiftdataparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RedshiftDataParameters
            /// </summary>
            public Union<Humidifier.Events.RuleTypes.RedshiftDataParameters, BaseFunction>? RedshiftDataParameters { get; set; }
            /// <summary>
            /// AppSyncParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-events-rule-target.html#cfn-events-rule-target-appsyncparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AppSyncParameters
            /// </summary>
            public Union<Humidifier.Events.RuleTypes.AppSyncParameters, BaseFunction>? AppSyncParameters { get; set; }
            /// <summary>
            /// Input
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-events-rule-target.html#cfn-events-rule-target-input
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Input { get; set; }
            /// <summary>
            /// SqsParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-events-rule-target.html#cfn-events-rule-target-sqsparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SqsParameters
            /// </summary>
            public Union<Humidifier.Events.RuleTypes.SqsParameters, BaseFunction>? SqsParameters { get; set; }
            /// <summary>
            /// EcsParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-events-rule-target.html#cfn-events-rule-target-ecsparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EcsParameters
            /// </summary>
            public Union<Humidifier.Events.RuleTypes.EcsParameters, BaseFunction>? EcsParameters { get; set; }
            /// <summary>
            /// BatchParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-events-rule-target.html#cfn-events-rule-target-batchparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: BatchParameters
            /// </summary>
            public Union<Humidifier.Events.RuleTypes.BatchParameters, BaseFunction>? BatchParameters { get; set; }
            /// <summary>
            /// Id
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-events-rule-target.html#cfn-events-rule-target-id
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Id { get; set; }
            /// <summary>
            /// Arn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-events-rule-target.html#cfn-events-rule-target-arn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Arn { get; set; }
            /// <summary>
            /// SageMakerPipelineParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-events-rule-target.html#cfn-events-rule-target-sagemakerpipelineparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SageMakerPipelineParameters
            /// </summary>
            public Union<Humidifier.Events.RuleTypes.SageMakerPipelineParameters, BaseFunction>? SageMakerPipelineParameters { get; set; }
            /// <summary>
            /// RetryPolicy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-events-rule-target.html#cfn-events-rule-target-retrypolicy
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RetryPolicy
            /// </summary>
            public Union<Humidifier.Events.RuleTypes.RetryPolicy, BaseFunction>? RetryPolicy { get; set; }
        }
    }
}