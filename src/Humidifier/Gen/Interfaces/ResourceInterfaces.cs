using System;

namespace Humidifier.Interfaces
{
    using System.Collections.Generic;

    public interface IHaveName : IResourceInterface
    {
        dynamic Name { get; set; }
    }

    public interface IHaveTags : IResourceInterface
    {
        List<Tag> Tags { get; set; }
    }

    public interface IHaveDescription : IResourceInterface
    {
        dynamic Description { get; set; }
    }

    public interface IHaveType : IResourceInterface
    {
        dynamic Type { get; set; }
    }

    public interface IHaveValue : IResourceInterface
    {
        dynamic Value { get; set; }
    }

    public interface IHaveRoleArn : IResourceInterface
    {
        dynamic RoleArn { get; set; }
    }

    public interface IHaveKey : IResourceInterface
    {
        dynamic Key { get; set; }
    }

    public interface IHaveEnabled : IResourceInterface
    {
        dynamic Enabled { get; set; }
    }

    public interface IHaveVisibility : IResourceInterface
    {
        dynamic Visibility { get; set; }
    }

    public interface IHaveStatus : IResourceInterface
    {
        dynamic Status { get; set; }
    }

    public interface IHaveDynDicOfTags : IResourceInterface
    {
        Dictionary<string, dynamic> Tags { get; set; }
    }

    public interface IHavePort : IResourceInterface
    {
        dynamic Port { get; set; }
    }

    public interface IHaveKmsKeyId : IResourceInterface
    {
        dynamic KmsKeyId { get; set; }
    }

    public interface IHaveFieldId : IResourceInterface
    {
        dynamic FieldId { get; set; }
    }

    public interface IHaveId : IResourceInterface
    {
        dynamic Id { get; set; }
    }

    public interface IHaveVisualId : IResourceInterface
    {
        dynamic VisualId { get; set; }
    }

    public interface IHaveSecurityGroupIds : IResourceInterface
    {
        dynamic SecurityGroupIds { get; set; }
    }

    public interface IHaveTitle : IResourceInterface
    {
        dynamic Title { get; set; }
    }

    public interface IHaveSubnetIds : IResourceInterface
    {
        dynamic SubnetIds { get; set; }
    }

    public interface IHaveArn : IResourceInterface
    {
        dynamic Arn { get; set; }
    }

    public interface IHaveExpression : IResourceInterface
    {
        dynamic Expression { get; set; }
    }

    public interface IHaveVersion : IResourceInterface
    {
        dynamic Version { get; set; }
    }

    public interface IHavePrefix : IResourceInterface
    {
        dynamic Prefix { get; set; }
    }

    public interface IHaveDatabaseName : IResourceInterface
    {
        dynamic DatabaseName { get; set; }
    }

    public interface IHaveMin : IResourceInterface
    {
        dynamic Min { get; set; }
    }

    public interface IHaveMax : IResourceInterface
    {
        dynamic Max { get; set; }
    }

    public interface IHaveProtocol : IResourceInterface
    {
        dynamic Protocol { get; set; }
    }

    public interface IHaveValues : IResourceInterface
    {
        dynamic Values { get; set; }
    }

    public interface IHaveInstanceType : IResourceInterface
    {
        dynamic InstanceType { get; set; }
    }

    public interface IHaveBucketName : IResourceInterface
    {
        dynamic BucketName { get; set; }
    }

    public interface IHaveBucket : IResourceInterface
    {
        dynamic Bucket { get; set; }
    }

    public interface IHaveVpcId : IResourceInterface
    {
        dynamic VpcId { get; set; }
    }

    public interface IHavePath : IResourceInterface
    {
        dynamic Path { get; set; }
    }

    public interface IHaveColor : IResourceInterface
    {
        dynamic Color { get; set; }
    }

    public interface IHaveUnit : IResourceInterface
    {
        dynamic Unit { get; set; }
    }

    public interface IHaveDynamicTags : IResourceInterface
    {
        dynamic Tags { get; set; }
    }

    public interface IHaveTableName : IResourceInterface
    {
        dynamic TableName { get; set; }
    }

    public interface IHaveMetricName : IResourceInterface
    {
        dynamic MetricName { get; set; }
    }

    public interface IHaveNamespace_ : IResourceInterface
    {
        dynamic Namespace_ { get; set; }
    }

    public interface IHaveAvailabilityZone : IResourceInterface
    {
        dynamic AvailabilityZone { get; set; }
    }

    public interface IHaveMode : IResourceInterface
    {
        dynamic Mode { get; set; }
    }

    public interface IHaveDisplayName : IResourceInterface
    {
        dynamic DisplayName { get; set; }
    }

    public interface IHaveUsername : IResourceInterface
    {
        dynamic Username { get; set; }
    }

    public interface IHavePriority : IResourceInterface
    {
        dynamic Priority { get; set; }
    }

    public interface IHaveSubnetId : IResourceInterface
    {
        dynamic SubnetId { get; set; }
    }

    public interface IHaveAction : IResourceInterface
    {
        dynamic Action { get; set; }
    }

    public interface IHaveKmsKeyArn : IResourceInterface
    {
        dynamic KmsKeyArn { get; set; }
    }

    public interface IHaveState : IResourceInterface
    {
        dynamic State { get; set; }
    }

    public interface IHavePassword : IResourceInterface
    {
        dynamic Password { get; set; }
    }

    public interface IHaveComputationId : IResourceInterface
    {
        dynamic ComputationId { get; set; }
    }

    public interface IHaveDomainName : IResourceInterface
    {
        dynamic DomainName { get; set; }
    }

    public interface IHaveCatalogId : IResourceInterface
    {
        dynamic CatalogId { get; set; }
    }

    public interface IHaveUrl : IResourceInterface
    {
        dynamic Url { get; set; }
    }

    public interface IHaveS3Uri : IResourceInterface
    {
        dynamic S3Uri { get; set; }
    }

    public interface IHaveCustomLabel : IResourceInterface
    {
        dynamic CustomLabel { get; set; }
    }

    public interface IHaveApplicationId : IResourceInterface
    {
        dynamic ApplicationId { get; set; }
    }

    public interface IHavePolicyDocument : IResourceInterface
    {
        dynamic PolicyDocument { get; set; }
    }

    public interface IHaveParameterName : IResourceInterface
    {
        dynamic ParameterName { get; set; }
    }

    public interface IHaveObject : IResourceInterface
    {
        dynamic Object { get; set; }
    }

    public interface IHaveSubnets : IResourceInterface
    {
        dynamic Subnets { get; set; }
    }

    public interface IHaveRoleARN : IResourceInterface
    {
        dynamic RoleARN { get; set; }
    }

    public interface IHaveRegion : IResourceInterface
    {
        dynamic Region { get; set; }
    }

    public interface IHaveTimeGranularity : IResourceInterface
    {
        dynamic TimeGranularity { get; set; }
    }

    public interface IHaveQuickSightAnalysisTypesColumnIdentifierColumn : IResourceInterface
    {
        Humidifier.QuickSight.AnalysisTypes.ColumnIdentifier Column { get; set; }
    }

    public interface IHaveFilterId : IResourceInterface
    {
        dynamic FilterId { get; set; }
    }

    public interface IHaveFilterControlId : IResourceInterface
    {
        dynamic FilterControlId { get; set; }
    }

    public interface IHaveSourceFilterId : IResourceInterface
    {
        dynamic SourceFilterId { get; set; }
    }

    public interface IHaveQuickSightDashboardTypesColumnIdentifierColumn : IResourceInterface
    {
        Humidifier.QuickSight.DashboardTypes.ColumnIdentifier Column { get; set; }
    }

    public interface IHaveQuickSightTemplateTypesColumnIdentifierColumn : IResourceInterface
    {
        Humidifier.QuickSight.TemplateTypes.ColumnIdentifier Column { get; set; }
    }

    public interface IHaveCertificateArn : IResourceInterface
    {
        dynamic CertificateArn { get; set; }
    }

    public interface IHaveResourceType : IResourceInterface
    {
        dynamic ResourceType { get; set; }
    }

    public interface IHaveInstanceArn : IResourceInterface
    {
        dynamic InstanceArn { get; set; }
    }

    public interface IHaveListOfQuickSightAnalysisTypesVisualCustomActionActions : IResourceInterface
    {
        List<Humidifier.QuickSight.AnalysisTypes.VisualCustomAction> Actions { get; set; }
    }

    public interface IHaveListOfQuickSightDashboardTypesVisualCustomActionActions : IResourceInterface
    {
        List<Humidifier.QuickSight.DashboardTypes.VisualCustomAction> Actions { get; set; }
    }

    public interface IHaveListOfQuickSightTemplateTypesVisualCustomActionActions : IResourceInterface
    {
        List<Humidifier.QuickSight.TemplateTypes.VisualCustomAction> Actions { get; set; }
    }

    public interface IHavePolicy : IResourceInterface
    {
        dynamic Policy { get; set; }
    }

    public interface IHaveParameters : IResourceInterface
    {
        dynamic Parameters { get; set; }
    }

    public interface IHaveQuickSightAnalysisTypesVisualSubtitleLabelOptionsSubtitle : IResourceInterface
    {
        Humidifier.QuickSight.AnalysisTypes.VisualSubtitleLabelOptions Subtitle { get; set; }
    }

    public interface IHaveQuickSightAnalysisTypesVisualTitleLabelOptionsTitle : IResourceInterface
    {
        Humidifier.QuickSight.AnalysisTypes.VisualTitleLabelOptions Title { get; set; }
    }

    public interface IHaveQuickSightDashboardTypesVisualSubtitleLabelOptionsSubtitle : IResourceInterface
    {
        Humidifier.QuickSight.DashboardTypes.VisualSubtitleLabelOptions Subtitle { get; set; }
    }

    public interface IHaveQuickSightDashboardTypesVisualTitleLabelOptionsTitle : IResourceInterface
    {
        Humidifier.QuickSight.DashboardTypes.VisualTitleLabelOptions Title { get; set; }
    }

    public interface IHaveQuickSightTemplateTypesVisualSubtitleLabelOptionsSubtitle : IResourceInterface
    {
        Humidifier.QuickSight.TemplateTypes.VisualSubtitleLabelOptions Subtitle { get; set; }
    }

    public interface IHaveQuickSightTemplateTypesVisualTitleLabelOptionsTitle : IResourceInterface
    {
        Humidifier.QuickSight.TemplateTypes.VisualTitleLabelOptions Title { get; set; }
    }

    public interface IHaveSecurityGroups : IResourceInterface
    {
        dynamic SecurityGroups { get; set; }
    }

    public interface IHaveResourceId : IResourceInterface
    {
        dynamic ResourceId { get; set; }
    }

    public interface IHaveHost : IResourceInterface
    {
        dynamic Host { get; set; }
    }

    public interface IHaveScope : IResourceInterface
    {
        dynamic Scope { get; set; }
    }

    public interface IHaveDomain : IResourceInterface
    {
        dynamic Domain { get; set; }
    }

    public interface IHaveIops : IResourceInterface
    {
        dynamic Iops { get; set; }
    }

    public interface IHaveWeight : IResourceInterface
    {
        dynamic Weight { get; set; }
    }

    public interface IHaveSecretArn : IResourceInterface
    {
        dynamic SecretArn { get; set; }
    }

    public interface IHaveDataSetIdentifier : IResourceInterface
    {
        dynamic DataSetIdentifier { get; set; }
    }

    public interface IHaveNullOption : IResourceInterface
    {
        dynamic NullOption { get; set; }
    }

    public interface IHaveSourceParameterName : IResourceInterface
    {
        dynamic SourceParameterName { get; set; }
    }

    public interface IHaveContentType : IResourceInterface
    {
        dynamic ContentType { get; set; }
    }

    public interface IHaveSource : IResourceInterface
    {
        dynamic Source { get; set; }
    }

    public interface IHaveHierarchyId : IResourceInterface
    {
        dynamic HierarchyId { get; set; }
    }

    public interface IHaveTarget : IResourceInterface
    {
        dynamic Target { get; set; }
    }

    public interface IHaveApiId : IResourceInterface
    {
        dynamic ApiId { get; set; }
    }

    public interface IHaveContent : IResourceInterface
    {
        dynamic Content { get; set; }
    }

    public interface IHavePolicyName : IResourceInterface
    {
        dynamic PolicyName { get; set; }
    }

    public interface IHaveFormat : IResourceInterface
    {
        dynamic Format { get; set; }
    }

    public interface IHaveS3Bucket : IResourceInterface
    {
        dynamic S3Bucket { get; set; }
    }

    public interface IHaveNetworkInterfaceId : IResourceInterface
    {
        dynamic NetworkInterfaceId { get; set; }
    }

    public interface IHaveRole : IResourceInterface
    {
        dynamic Role { get; set; }
    }

    public interface IHaveParameterControlId : IResourceInterface
    {
        dynamic ParameterControlId { get; set; }
    }

    public interface IHaveExecutionRoleArn : IResourceInterface
    {
        dynamic ExecutionRoleArn { get; set; }
    }

    public interface IHaveLogGroupName : IResourceInterface
    {
        dynamic LogGroupName { get; set; }
    }

    public interface IHaveComment : IResourceInterface
    {
        dynamic Comment { get; set; }
    }

    public interface IHaveResourceArn : IResourceInterface
    {
        dynamic ResourceArn { get; set; }
    }

    public interface IHaveGroupName : IResourceInterface
    {
        dynamic GroupName { get; set; }
    }

    public interface IHaveEndpointName : IResourceInterface
    {
        dynamic EndpointName { get; set; }
    }

    public interface IHaveDelimiter : IResourceInterface
    {
        dynamic Delimiter { get; set; }
    }

    public interface IHaveEngineVersion : IResourceInterface
    {
        dynamic EngineVersion { get; set; }
    }

    public interface IHaveDatabase : IResourceInterface
    {
        dynamic Database { get; set; }
    }

    public interface IHaveAccountId : IResourceInterface
    {
        dynamic AccountId { get; set; }
    }

    public interface IHaveComparisonOperator : IResourceInterface
    {
        dynamic ComparisonOperator { get; set; }
    }

    public interface IHaveClientId : IResourceInterface
    {
        dynamic ClientId { get; set; }
    }

    public interface IHavePreferredMaintenanceWindow : IResourceInterface
    {
        dynamic PreferredMaintenanceWindow { get; set; }
    }

    public interface IHaveClusterName : IResourceInterface
    {
        dynamic ClusterName { get; set; }
    }

    public interface IHaveSize : IResourceInterface
    {
        dynamic Size { get; set; }
    }

    public interface IHaveVolumeType : IResourceInterface
    {
        dynamic VolumeType { get; set; }
    }

    public interface IHaveOperator : IResourceInterface
    {
        dynamic Operator { get; set; }
    }

    public interface IHaveText : IResourceInterface
    {
        dynamic Text { get; set; }
    }

    public interface IHaveSuffix : IResourceInterface
    {
        dynamic Suffix { get; set; }
    }

    public interface IHaveHeight : IResourceInterface
    {
        dynamic Height { get; set; }
    }

    public interface IHaveWidth : IResourceInterface
    {
        dynamic Width { get; set; }
    }

    public interface IHavePrincipal : IResourceInterface
    {
        dynamic Principal { get; set; }
    }

    public interface IHaveServiceName : IResourceInterface
    {
        dynamic ServiceName { get; set; }
    }

    public interface IHaveScheduleExpression : IResourceInterface
    {
        dynamic ScheduleExpression { get; set; }
    }

    public interface IHaveDefaultValue : IResourceInterface
    {
        dynamic DefaultValue { get; set; }
    }

    public interface IHaveApplicationName : IResourceInterface
    {
        dynamic ApplicationName { get; set; }
    }

    public interface IHaveMessage : IResourceInterface
    {
        dynamic Message { get; set; }
    }

    public interface IHaveInstanceCount : IResourceInterface
    {
        dynamic InstanceCount { get; set; }
    }

    public interface IHavePosition : IResourceInterface
    {
        dynamic Position { get; set; }
    }

    public interface IHaveInterval : IResourceInterface
    {
        dynamic Interval { get; set; }
    }

    public interface IHaveAddress : IResourceInterface
    {
        dynamic Address { get; set; }
    }

    public interface IHaveColumnName : IResourceInterface
    {
        dynamic ColumnName { get; set; }
    }

    public interface IHaveListOfQuickSightAnalysisTypesMeasureFieldValues : IResourceInterface
    {
        List<Humidifier.QuickSight.AnalysisTypes.MeasureField> Values { get; set; }
    }

    public interface IHaveListOfQuickSightAnalysisTypesColumnHierarchyColumnHierarchies : IResourceInterface
    {
        List<Humidifier.QuickSight.AnalysisTypes.ColumnHierarchy> ColumnHierarchies { get; set; }
    }

    public interface IHaveSelectAllOptions : IResourceInterface
    {
        dynamic SelectAllOptions { get; set; }
    }

    public interface IHaveListOfQuickSightDashboardTypesMeasureFieldValues : IResourceInterface
    {
        List<Humidifier.QuickSight.DashboardTypes.MeasureField> Values { get; set; }
    }

    public interface IHaveListOfQuickSightDashboardTypesColumnHierarchyColumnHierarchies : IResourceInterface
    {
        List<Humidifier.QuickSight.DashboardTypes.ColumnHierarchy> ColumnHierarchies { get; set; }
    }

    public interface IHaveListOfQuickSightTemplateTypesMeasureFieldValues : IResourceInterface
    {
        List<Humidifier.QuickSight.TemplateTypes.MeasureField> Values { get; set; }
    }

    public interface IHaveListOfQuickSightTemplateTypesColumnHierarchyColumnHierarchies : IResourceInterface
    {
        List<Humidifier.QuickSight.TemplateTypes.ColumnHierarchy> ColumnHierarchies { get; set; }
    }

    public interface IHaveLocalPath : IResourceInterface
    {
        dynamic LocalPath { get; set; }
    }

    public interface IHaveMaxCapacity : IResourceInterface
    {
        dynamic MaxCapacity { get; set; }
    }

    public interface IHaveUserPoolId : IResourceInterface
    {
        dynamic UserPoolId { get; set; }
    }

    public interface IHaveFileSystemId : IResourceInterface
    {
        dynamic FileSystemId { get; set; }
    }

    public interface IHaveLocation : IResourceInterface
    {
        dynamic Location { get; set; }
    }

    public interface IHaveDirection : IResourceInterface
    {
        dynamic Direction { get; set; }
    }

    public interface IHaveBucketPrefix : IResourceInterface
    {
        dynamic BucketPrefix { get; set; }
    }

    public interface IHaveLabel : IResourceInterface
    {
        dynamic Label { get; set; }
    }

    public interface IHaveExact : IResourceInterface
    {
        dynamic Exact { get; set; }
    }

    public interface IHaveData : IResourceInterface
    {
        dynamic Data { get; set; }
    }

    public interface IHaveTypeName : IResourceInterface
    {
        dynamic TypeName { get; set; }
    }

    public interface IHaveInstanceId : IResourceInterface
    {
        dynamic InstanceId { get; set; }
    }

    public interface IHaveStartTime : IResourceInterface
    {
        dynamic StartTime { get; set; }
    }

    public interface IHaveCount : IResourceInterface
    {
        dynamic Count { get; set; }
    }

    public interface IHaveTimeout : IResourceInterface
    {
        dynamic Timeout { get; set; }
    }

    public interface IHaveS3BucketName : IResourceInterface
    {
        dynamic S3BucketName { get; set; }
    }

    public interface IHavePeriod : IResourceInterface
    {
        dynamic Period { get; set; }
    }

    public interface IHaveStatistic : IResourceInterface
    {
        dynamic Statistic { get; set; }
    }

    public interface IHavePattern : IResourceInterface
    {
        dynamic Pattern { get; set; }
    }

    public interface IHaveEngine : IResourceInterface
    {
        dynamic Engine { get; set; }
    }

    public interface IHaveVpcSecurityGroupIds : IResourceInterface
    {
        dynamic VpcSecurityGroupIds { get; set; }
    }

    public interface IHaveFromPort : IResourceInterface
    {
        dynamic FromPort { get; set; }
    }

    public interface IHaveToPort : IResourceInterface
    {
        dynamic ToPort { get; set; }
    }

    public interface IHaveEncrypted : IResourceInterface
    {
        dynamic Encrypted { get; set; }
    }

    public interface IHaveEndpoint : IResourceInterface
    {
        dynamic Endpoint { get; set; }
    }

    public interface IHaveAcceptLanguage : IResourceInterface
    {
        dynamic AcceptLanguage { get; set; }
    }

    public interface IHaveField : IResourceInterface
    {
        dynamic Field { get; set; }
    }

    public interface IHaveLambdaArn : IResourceInterface
    {
        dynamic LambdaArn { get; set; }
    }

    public interface IHaveStringValue : IResourceInterface
    {
        dynamic StringValue { get; set; }
    }

    public interface IHaveCustomValue : IResourceInterface
    {
        dynamic CustomValue { get; set; }
    }

    public interface IHaveResourceARN : IResourceInterface
    {
        dynamic ResourceARN { get; set; }
    }

    public interface IHaveActions : IResourceInterface
    {
        dynamic Actions { get; set; }
    }

    public interface IHaveRestApiId : IResourceInterface
    {
        dynamic RestApiId { get; set; }
    }

    public interface IHaveThreshold : IResourceInterface
    {
        dynamic Threshold { get; set; }
    }

    public interface IHaveTargetArn : IResourceInterface
    {
        dynamic TargetArn { get; set; }
    }

    public interface IHaveSubdirectory : IResourceInterface
    {
        dynamic Subdirectory { get; set; }
    }

    public interface IHaveAwsAccountId : IResourceInterface
    {
        dynamic AwsAccountId { get; set; }
    }

    public interface IHaveDeviceName : IResourceInterface
    {
        dynamic DeviceName { get; set; }
    }

    public interface IHavePrivateIpAddress : IResourceInterface
    {
        dynamic PrivateIpAddress { get; set; }
    }

    public interface IHaveCidr : IResourceInterface
    {
        dynamic Cidr { get; set; }
    }

    public interface IHaveDestination : IResourceInterface
    {
        dynamic Destination { get; set; }
    }

    public interface IHaveCondition : IResourceInterface
    {
        dynamic Condition { get; set; }
    }

    public interface IHaveChannelName : IResourceInterface
    {
        dynamic ChannelName { get; set; }
    }

    public interface IHaveContainerName : IResourceInterface
    {
        dynamic ContainerName { get; set; }
    }

    public interface IHaveClientSecret : IResourceInterface
    {
        dynamic ClientSecret { get; set; }
    }

    public interface IHaveTopicArn : IResourceInterface
    {
        dynamic TopicArn { get; set; }
    }

    public interface IHaveImage : IResourceInterface
    {
        dynamic Image { get; set; }
    }

    public interface IHaveAttribute : IResourceInterface
    {
        dynamic Attribute { get; set; }
    }

    public interface IHaveHeader : IResourceInterface
    {
        dynamic Header { get; set; }
    }

    public interface IHaveCreatedTime : IResourceInterface
    {
        dynamic CreatedTime { get; set; }
    }

    public interface IHaveListOfKendraDataSourceTypesDataSourceToIndexFieldMappingFieldMappings : IResourceInterface
    {
        List<Humidifier.Kendra.DataSourceTypes.DataSourceToIndexFieldMapping> FieldMappings { get; set; }
    }

    public interface IHaveBackgroundColor : IResourceInterface
    {
        dynamic BackgroundColor { get; set; }
    }

    public interface IHaveStepSize : IResourceInterface
    {
        dynamic StepSize { get; set; }
    }

    public interface IHaveQuickSightAnalysisTypesLegendOptionsLegend : IResourceInterface
    {
        Humidifier.QuickSight.AnalysisTypes.LegendOptions Legend { get; set; }
    }

    public interface IHaveQuickSightAnalysisTypesTooltipOptionsTooltip : IResourceInterface
    {
        Humidifier.QuickSight.AnalysisTypes.TooltipOptions Tooltip { get; set; }
    }

    public interface IHaveQuickSightAnalysisTypesVisualPaletteVisualPalette : IResourceInterface
    {
        Humidifier.QuickSight.AnalysisTypes.VisualPalette VisualPalette { get; set; }
    }

    public interface IHaveFieldValue : IResourceInterface
    {
        dynamic FieldValue { get; set; }
    }

    public interface IHaveMatchOperator : IResourceInterface
    {
        dynamic MatchOperator { get; set; }
    }

    public interface IHaveAxisBinding : IResourceInterface
    {
        dynamic AxisBinding { get; set; }
    }

    public interface IHaveTotalsVisibility : IResourceInterface
    {
        dynamic TotalsVisibility { get; set; }
    }

    public interface IHaveValueWhenUnsetOption : IResourceInterface
    {
        dynamic ValueWhenUnsetOption { get; set; }
    }

    public interface IHaveQuickSightDashboardTypesLegendOptionsLegend : IResourceInterface
    {
        Humidifier.QuickSight.DashboardTypes.LegendOptions Legend { get; set; }
    }

    public interface IHaveQuickSightDashboardTypesTooltipOptionsTooltip : IResourceInterface
    {
        Humidifier.QuickSight.DashboardTypes.TooltipOptions Tooltip { get; set; }
    }

    public interface IHaveQuickSightDashboardTypesVisualPaletteVisualPalette : IResourceInterface
    {
        Humidifier.QuickSight.DashboardTypes.VisualPalette VisualPalette { get; set; }
    }

    public interface IHaveQuickSightTemplateTypesLegendOptionsLegend : IResourceInterface
    {
        Humidifier.QuickSight.TemplateTypes.LegendOptions Legend { get; set; }
    }

    public interface IHaveQuickSightTemplateTypesTooltipOptionsTooltip : IResourceInterface
    {
        Humidifier.QuickSight.TemplateTypes.TooltipOptions Tooltip { get; set; }
    }

    public interface IHaveQuickSightTemplateTypesVisualPaletteVisualPalette : IResourceInterface
    {
        Humidifier.QuickSight.TemplateTypes.VisualPalette VisualPalette { get; set; }
    }

    public interface IHavePubliclyAccessible : IResourceInterface
    {
        dynamic PubliclyAccessible { get; set; }
    }

    public interface IHaveAuthType : IResourceInterface
    {
        dynamic AuthType { get; set; }
    }

    public interface IHaveStatusCode : IResourceInterface
    {
        dynamic StatusCode { get; set; }
    }

    public interface IHaveBody : IResourceInterface
    {
        dynamic Body { get; set; }
    }

    public interface IHaveKeyType : IResourceInterface
    {
        dynamic KeyType { get; set; }
    }

    public interface IHaveKmsKey : IResourceInterface
    {
        dynamic KmsKey { get; set; }
    }

    public interface IHaveIamRoleArn : IResourceInterface
    {
        dynamic IamRoleArn { get; set; }
    }

    public interface IHaveUserName : IResourceInterface
    {
        dynamic UserName { get; set; }
    }

    public interface IHaveSnsTopicArn : IResourceInterface
    {
        dynamic SnsTopicArn { get; set; }
    }

    public interface IHaveDeleteOnTermination : IResourceInterface
    {
        dynamic DeleteOnTermination { get; set; }
    }

    public interface IHaveThroughput : IResourceInterface
    {
        dynamic Throughput { get; set; }
    }

    public interface IHaveDestinationArn : IResourceInterface
    {
        dynamic DestinationArn { get; set; }
    }

    public interface IHaveAvailabilityStatus : IResourceInterface
    {
        dynamic AvailabilityStatus { get; set; }
    }

    public interface IHaveHostedZoneId : IResourceInterface
    {
        dynamic HostedZoneId { get; set; }
    }

    public interface IHaveS3Key : IResourceInterface
    {
        dynamic S3Key { get; set; }
    }

    public interface IHaveCommand : IResourceInterface
    {
        dynamic Command { get; set; }
    }

    public interface IHaveAttributeName : IResourceInterface
    {
        dynamic AttributeName { get; set; }
    }

    public interface IHaveSecretsManagerSecretId : IResourceInterface
    {
        dynamic SecretsManagerSecretId { get; set; }
    }

    public interface IHaveSecretsManagerAccessRoleArn : IResourceInterface
    {
        dynamic SecretsManagerAccessRoleArn { get; set; }
    }

    public interface IHaveListOfWAFv2RuleGroupTypesTextTransformationTextTransformations : IResourceInterface
    {
        List<Humidifier.WAFv2.RuleGroupTypes.TextTransformation> TextTransformations { get; set; }
    }

    public interface IHaveListOfWAFv2WebACLTypesTextTransformationTextTransformations : IResourceInterface
    {
        List<Humidifier.WAFv2.WebACLTypes.TextTransformation> TextTransformations { get; set; }
    }

    public interface IHaveAccessToken : IResourceInterface
    {
        dynamic AccessToken { get; set; }
    }

    public interface IHaveDynDicOfParameters : IResourceInterface
    {
        Dictionary<string, dynamic> Parameters { get; set; }
    }

    public interface IHaveCode : IResourceInterface
    {
        dynamic Code { get; set; }
    }

    public interface IHaveQueryString : IResourceInterface
    {
        dynamic QueryString { get; set; }
    }

    public interface IHaveEbsOptimized : IResourceInterface
    {
        dynamic EbsOptimized { get; set; }
    }

    public interface IHaveRuleName : IResourceInterface
    {
        dynamic RuleName { get; set; }
    }

    public interface IHaveRepositoryName : IResourceInterface
    {
        dynamic RepositoryName { get; set; }
    }

    public interface IHaveConnectionName : IResourceInterface
    {
        dynamic ConnectionName { get; set; }
    }

    public interface IHaveUri : IResourceInterface
    {
        dynamic Uri { get; set; }
    }

    public interface IHaveServerName : IResourceInterface
    {
        dynamic ServerName { get; set; }
    }

    public interface IHaveDomainIdentifier : IResourceInterface
    {
        dynamic DomainIdentifier { get; set; }
    }

    public interface IHaveProductId : IResourceInterface
    {
        dynamic ProductId { get; set; }
    }

    public interface IHaveTemplateName : IResourceInterface
    {
        dynamic TemplateName { get; set; }
    }

    public interface IHaveSourceArn : IResourceInterface
    {
        dynamic SourceArn { get; set; }
    }

    public interface IHaveDataType : IResourceInterface
    {
        dynamic DataType { get; set; }
    }

    public interface IHavePrivateKey : IResourceInterface
    {
        dynamic PrivateKey { get; set; }
    }

    public interface IHaveExecutionRole : IResourceInterface
    {
        dynamic ExecutionRole { get; set; }
    }

    public interface IHaveIndexName : IResourceInterface
    {
        dynamic IndexName { get; set; }
    }

    public interface IHaveDynDicOfAttributes_ : IResourceInterface
    {
        Dictionary<string, dynamic> Attributes_ { get; set; }
    }

    public interface IHaveBatchSize : IResourceInterface
    {
        dynamic BatchSize { get; set; }
    }

    public interface IHaveRegex : IResourceInterface
    {
        dynamic Regex { get; set; }
    }

    public interface IHaveInstanceUrl : IResourceInterface
    {
        dynamic InstanceUrl { get; set; }
    }

    public interface IHaveVolumeSize : IResourceInterface
    {
        dynamic VolumeSize { get; set; }
    }

    public interface IHaveDateTimeFormat : IResourceInterface
    {
        dynamic DateTimeFormat { get; set; }
    }

    public interface IHaveBase : IResourceInterface
    {
        dynamic Base { get; set; }
    }

    public interface IHaveKinesisFirehoseDeliveryStreamTypesCloudWatchLoggingOptionsCloudWatchLoggingOptions : IResourceInterface
    {
        Humidifier.KinesisFirehose.DeliveryStreamTypes.CloudWatchLoggingOptions CloudWatchLoggingOptions { get; set; }
    }

    public interface IHaveQuickSightAnalysisTypesDataLabelOptionsDataLabels : IResourceInterface
    {
        Humidifier.QuickSight.AnalysisTypes.DataLabelOptions DataLabels { get; set; }
    }

    public interface IHaveListOfQuickSightAnalysisTypesFieldSortOptionsCategorySort : IResourceInterface
    {
        List<Humidifier.QuickSight.AnalysisTypes.FieldSortOptions> CategorySort { get; set; }
    }

    public interface IHaveQuickSightDashboardTypesDataLabelOptionsDataLabels : IResourceInterface
    {
        Humidifier.QuickSight.DashboardTypes.DataLabelOptions DataLabels { get; set; }
    }

    public interface IHaveListOfQuickSightDashboardTypesFieldSortOptionsCategorySort : IResourceInterface
    {
        List<Humidifier.QuickSight.DashboardTypes.FieldSortOptions> CategorySort { get; set; }
    }

    public interface IHaveQuickSightTemplateTypesDataLabelOptionsDataLabels : IResourceInterface
    {
        Humidifier.QuickSight.TemplateTypes.DataLabelOptions DataLabels { get; set; }
    }

    public interface IHaveListOfQuickSightTemplateTypesFieldSortOptionsCategorySort : IResourceInterface
    {
        List<Humidifier.QuickSight.TemplateTypes.FieldSortOptions> CategorySort { get; set; }
    }

    public interface IHaveS3DataDistributionType : IResourceInterface
    {
        dynamic S3DataDistributionType { get; set; }
    }

    public interface IHaveS3InputMode : IResourceInterface
    {
        dynamic S3InputMode { get; set; }
    }

    public interface IHaveLifecycleConfigArns : IResourceInterface
    {
        dynamic LifecycleConfigArns { get; set; }
    }

    public interface IHaveResourceIdentifier : IResourceInterface
    {
        dynamic ResourceIdentifier { get; set; }
    }

    public interface IHaveAutoMinorVersionUpgrade : IResourceInterface
    {
        dynamic AutoMinorVersionUpgrade { get; set; }
    }

    public interface IHaveAuthenticationType : IResourceInterface
    {
        dynamic AuthenticationType { get; set; }
    }

    public interface IHaveMinCapacity : IResourceInterface
    {
        dynamic MinCapacity { get; set; }
    }

    public interface IHaveAvailabilityZones : IResourceInterface
    {
        dynamic AvailabilityZones { get; set; }
    }

    public interface IHaveFlowArn : IResourceInterface
    {
        dynamic FlowArn { get; set; }
    }

    public interface IHaveIdentifier : IResourceInterface
    {
        dynamic Identifier { get; set; }
    }

    public interface IHaveLanguageCode : IResourceInterface
    {
        dynamic LanguageCode { get; set; }
    }

    public interface IHaveEndpointType : IResourceInterface
    {
        dynamic EndpointType { get; set; }
    }

    public interface IHaveSourceType : IResourceInterface
    {
        dynamic SourceType { get; set; }
    }

    public interface IHaveUser : IResourceInterface
    {
        dynamic User { get; set; }
    }

    public interface IHaveAllocationStrategy : IResourceInterface
    {
        dynamic AllocationStrategy { get; set; }
    }

    public interface IHaveSnapshotId : IResourceInterface
    {
        dynamic SnapshotId { get; set; }
    }

    public interface IHaveMemory : IResourceInterface
    {
        dynamic Memory { get; set; }
    }

    public interface IHaveExternalId : IResourceInterface
    {
        dynamic ExternalId { get; set; }
    }

    public interface IHaveDurationInSeconds : IResourceInterface
    {
        dynamic DurationInSeconds { get; set; }
    }

    public interface IHaveLogLevel : IResourceInterface
    {
        dynamic LogLevel { get; set; }
    }

    public interface IHaveBundleId : IResourceInterface
    {
        dynamic BundleId { get; set; }
    }

    public interface IHaveManifestName : IResourceInterface
    {
        dynamic ManifestName { get; set; }
    }

    public interface IHaveTimezone : IResourceInterface
    {
        dynamic Timezone { get; set; }
    }

    public interface IHaveVolumeSizeInGB : IResourceInterface
    {
        dynamic VolumeSizeInGB { get; set; }
    }

    public interface IHavePortfolioId : IResourceInterface
    {
        dynamic PortfolioId { get; set; }
    }

    public interface IHaveParameterValue : IResourceInterface
    {
        dynamic ParameterValue { get; set; }
    }

    public interface IHaveEnd : IResourceInterface
    {
        dynamic End { get; set; }
    }

    public interface IHaveAlgorithm : IResourceInterface
    {
        dynamic Algorithm { get; set; }
    }

    public interface IHaveLastUpdatedTime : IResourceInterface
    {
        dynamic LastUpdatedTime { get; set; }
    }

    public interface IHaveBitrate : IResourceInterface
    {
        dynamic Bitrate { get; set; }
    }

    public interface IHaveNext : IResourceInterface
    {
        dynamic Next { get; set; }
    }

    public interface IHaveKinesisFirehoseDeliveryStreamTypesProcessingConfigurationProcessingConfiguration : IResourceInterface
    {
        Humidifier.KinesisFirehose.DeliveryStreamTypes.ProcessingConfiguration ProcessingConfiguration { get; set; }
    }

    public interface IHaveMediaLiveChannelTypesOutputLocationRefDestination : IResourceInterface
    {
        Humidifier.MediaLive.ChannelTypes.OutputLocationRef Destination { get; set; }
    }

    public interface IHaveSegmentDurationSeconds : IResourceInterface
    {
        dynamic SegmentDurationSeconds { get; set; }
    }

    public interface IHaveCategoryValues : IResourceInterface
    {
        dynamic CategoryValues { get; set; }
    }

    public interface IHaveParameterValueType : IResourceInterface
    {
        dynamic ParameterValueType { get; set; }
    }

    public interface IHaveMaximumValue : IResourceInterface
    {
        dynamic MaximumValue { get; set; }
    }

    public interface IHaveMinimumValue : IResourceInterface
    {
        dynamic MinimumValue { get; set; }
    }

    public interface IHavePlacement : IResourceInterface
    {
        dynamic Placement { get; set; }
    }

    public interface IHaveSheetId : IResourceInterface
    {
        dynamic SheetId { get; set; }
    }

    public interface IHaveCertificateAuthorityArn : IResourceInterface
    {
        dynamic CertificateAuthorityArn { get; set; }
    }

    public interface IHaveCertificate : IResourceInterface
    {
        dynamic Certificate { get; set; }
    }

    public interface IHavePermissions : IResourceInterface
    {
        dynamic Permissions { get; set; }
    }

    public interface IHaveMinSize : IResourceInterface
    {
        dynamic MinSize { get; set; }
    }

    public interface IHaveMaxSize : IResourceInterface
    {
        dynamic MaxSize { get; set; }
    }

    public interface IHaveImageId : IResourceInterface
    {
        dynamic ImageId { get; set; }
    }

    public interface IHaveTimeZone : IResourceInterface
    {
        dynamic TimeZone { get; set; }
    }

    public interface IHaveStat : IResourceInterface
    {
        dynamic Stat { get; set; }
    }

    public interface IHaveResource : IResourceInterface
    {
        dynamic Resource { get; set; }
    }

    public interface IHaveDeletionProtection : IResourceInterface
    {
        dynamic DeletionProtection { get; set; }
    }

    public interface IHaveVolumeKmsKeyId : IResourceInterface
    {
        dynamic VolumeKmsKeyId { get; set; }
    }

    public interface IHaveTargetType : IResourceInterface
    {
        dynamic TargetType { get; set; }
    }

    public interface IHaveDirectoryId : IResourceInterface
    {
        dynamic DirectoryId { get; set; }
    }

    public interface IHaveDBSubnetGroupName : IResourceInterface
    {
        dynamic DBSubnetGroupName { get; set; }
    }

    public interface IHaveEndDate : IResourceInterface
    {
        dynamic EndDate { get; set; }
    }

    public interface IHaveLaunchTemplateName : IResourceInterface
    {
        dynamic LaunchTemplateName { get; set; }
    }

    public interface IHaveTransitGatewayId : IResourceInterface
    {
        dynamic TransitGatewayId { get; set; }
    }

    public interface IHaveGroupId : IResourceInterface
    {
        dynamic GroupId { get; set; }
    }

    public interface IHaveCpu : IResourceInterface
    {
        dynamic Cpu { get; set; }
    }

    public interface IHaveTimeoutInSeconds : IResourceInterface
    {
        dynamic TimeoutInSeconds { get; set; }
    }

    public interface IHaveGroups : IResourceInterface
    {
        dynamic Groups { get; set; }
    }

    public interface IHaveCatalog : IResourceInterface
    {
        dynamic Catalog { get; set; }
    }

    public interface IHaveMaximumBatchingWindowInSeconds : IResourceInterface
    {
        dynamic MaximumBatchingWindowInSeconds { get; set; }
    }

    public interface IHaveIsEnabled : IResourceInterface
    {
        dynamic IsEnabled { get; set; }
    }

    public interface IHaveKeyArn : IResourceInterface
    {
        dynamic KeyArn { get; set; }
    }

    public interface IHaveClusterIdentifier : IResourceInterface
    {
        dynamic ClusterIdentifier { get; set; }
    }

    public interface IHaveProperty : IResourceInterface
    {
        dynamic Property { get; set; }
    }

    public interface IHaveRevision : IResourceInterface
    {
        dynamic Revision { get; set; }
    }

    public interface IHaveLevel : IResourceInterface
    {
        dynamic Level { get; set; }
    }

    public interface IHaveIssuer : IResourceInterface
    {
        dynamic Issuer { get; set; }
    }

    public interface IHaveAppFlowFlowTypesErrorHandlingConfigErrorHandlingConfig : IResourceInterface
    {
        Humidifier.AppFlow.FlowTypes.ErrorHandlingConfig ErrorHandlingConfig { get; set; }
    }

    public interface IHaveStart : IResourceInterface
    {
        dynamic Start { get; set; }
    }

    public interface IHaveTargetValue : IResourceInterface
    {
        dynamic TargetValue { get; set; }
    }

    public interface IHaveLaunchTemplateId : IResourceInterface
    {
        dynamic LaunchTemplateId { get; set; }
    }

    public interface IHaveSourcePath : IResourceInterface
    {
        dynamic SourcePath { get; set; }
    }

    public interface IHaveMinimum : IResourceInterface
    {
        dynamic Minimum { get; set; }
    }

    public interface IHaveHeaderName : IResourceInterface
    {
        dynamic HeaderName { get; set; }
    }

    public interface IHaveFrom : IResourceInterface
    {
        dynamic From { get; set; }
    }

    public interface IHaveDoubleValue : IResourceInterface
    {
        dynamic DoubleValue { get; set; }
    }

    public interface IHaveLogGroup : IResourceInterface
    {
        dynamic LogGroup { get; set; }
    }

    public interface IHaveImageUri : IResourceInterface
    {
        dynamic ImageUri { get; set; }
    }

    public interface IHaveInline : IResourceInterface
    {
        dynamic Inline { get; set; }
    }

    public interface IHaveIoTEventsAlarmModelTypesPayloadPayload : IResourceInterface
    {
        Humidifier.IoTEvents.AlarmModelTypes.Payload Payload { get; set; }
    }

    public interface IHaveIoTEventsDetectorModelTypesPayloadPayload : IResourceInterface
    {
        Humidifier.IoTEvents.DetectorModelTypes.Payload Payload { get; set; }
    }

    public interface IHaveDocumentTitleFieldName : IResourceInterface
    {
        dynamic DocumentTitleFieldName { get; set; }
    }

    public interface IHaveKinesisFirehoseDeliveryStreamTypesS3DestinationConfigurationS3Configuration : IResourceInterface
    {
        Humidifier.KinesisFirehose.DeliveryStreamTypes.S3DestinationConfiguration S3Configuration { get; set; }
    }

    public interface IHaveS3BackupMode : IResourceInterface
    {
        dynamic S3BackupMode { get; set; }
    }

    public interface IHaveFontColor : IResourceInterface
    {
        dynamic FontColor { get; set; }
    }

    public interface IHaveAttachmentPolicyRuleNumber : IResourceInterface
    {
        dynamic AttachmentPolicyRuleNumber { get; set; }
    }

    public interface IHaveListOfQuickSightAnalysisTypesDimensionFieldCategory : IResourceInterface
    {
        List<Humidifier.QuickSight.AnalysisTypes.DimensionField> Category { get; set; }
    }

    public interface IHaveQuickSightAnalysisTypesDefaultFilterControlConfigurationDefaultFilterControlConfiguration : IResourceInterface
    {
        Humidifier.QuickSight.AnalysisTypes.DefaultFilterControlConfiguration DefaultFilterControlConfiguration { get; set; }
    }

    public interface IHaveStaticValues : IResourceInterface
    {
        dynamic StaticValues { get; set; }
    }

    public interface IHaveDoubleListOfStaticValues : IResourceInterface
    {
        List<double> StaticValues { get; set; }
    }

    public interface IHaveQuickSightAnalysisTypesMeasureFieldValue : IResourceInterface
    {
        Humidifier.QuickSight.AnalysisTypes.MeasureField Value { get; set; }
    }

    public interface IHaveListOfQuickSightDashboardTypesDimensionFieldCategory : IResourceInterface
    {
        List<Humidifier.QuickSight.DashboardTypes.DimensionField> Category { get; set; }
    }

    public interface IHaveQuickSightDashboardTypesDefaultFilterControlConfigurationDefaultFilterControlConfiguration : IResourceInterface
    {
        Humidifier.QuickSight.DashboardTypes.DefaultFilterControlConfiguration DefaultFilterControlConfiguration { get; set; }
    }

    public interface IHaveQuickSightDashboardTypesMeasureFieldValue : IResourceInterface
    {
        Humidifier.QuickSight.DashboardTypes.MeasureField Value { get; set; }
    }

    public interface IHaveListOfQuickSightTemplateTypesDimensionFieldCategory : IResourceInterface
    {
        List<Humidifier.QuickSight.TemplateTypes.DimensionField> Category { get; set; }
    }

    public interface IHaveQuickSightTemplateTypesDefaultFilterControlConfigurationDefaultFilterControlConfiguration : IResourceInterface
    {
        Humidifier.QuickSight.TemplateTypes.DefaultFilterControlConfiguration DefaultFilterControlConfiguration { get; set; }
    }

    public interface IHaveQuickSightTemplateTypesMeasureFieldValue : IResourceInterface
    {
        Humidifier.QuickSight.TemplateTypes.MeasureField Value { get; set; }
    }

    public interface IHaveDynDicOfEnvironment : IResourceInterface
    {
        Dictionary<string, dynamic> Environment { get; set; }
    }

    public interface IHaveTextTransformation : IResourceInterface
    {
        dynamic TextTransformation { get; set; }
    }

    public interface IHaveOversizeHandling : IResourceInterface
    {
        dynamic OversizeHandling { get; set; }
    }

    public interface IHaveCertificateChain : IResourceInterface
    {
        dynamic CertificateChain { get; set; }
    }

    public interface IHaveStorageType : IResourceInterface
    {
        dynamic StorageType { get; set; }
    }

    public interface IHaveStageName : IResourceInterface
    {
        dynamic StageName { get; set; }
    }

    public interface IHaveMeshName : IResourceInterface
    {
        dynamic MeshName { get; set; }
    }

    public interface IHaveImageName : IResourceInterface
    {
        dynamic ImageName { get; set; }
    }

    public interface IHavePolicyType : IResourceInterface
    {
        dynamic PolicyType { get; set; }
    }

    public interface IHaveEndTime : IResourceInterface
    {
        dynamic EndTime { get; set; }
    }

    public interface IHaveEncryptionKeyArn : IResourceInterface
    {
        dynamic EncryptionKeyArn { get; set; }
    }

    public interface IHaveLoggingLevel : IResourceInterface
    {
        dynamic LoggingLevel { get; set; }
    }

    public interface IHaveTeamId : IResourceInterface
    {
        dynamic TeamId { get; set; }
    }

    public interface IHaveFunctionName : IResourceInterface
    {
        dynamic FunctionName { get; set; }
    }

    public interface IHaveConnectionArn : IResourceInterface
    {
        dynamic ConnectionArn { get; set; }
    }

    public interface IHaveS3KeyPrefix : IResourceInterface
    {
        dynamic S3KeyPrefix { get; set; }
    }

    public interface IHaveOwner : IResourceInterface
    {
        dynamic Owner { get; set; }
    }

    public interface IHaveClientToken : IResourceInterface
    {
        dynamic ClientToken { get; set; }
    }

    public interface IHaveProjectName : IResourceInterface
    {
        dynamic ProjectName { get; set; }
    }

    public interface IHaveDatasetName : IResourceInterface
    {
        dynamic DatasetName { get; set; }
    }

    public interface IHaveVpcEndpointId : IResourceInterface
    {
        dynamic VpcEndpointId { get; set; }
    }

    public interface IHavePreferredBackupWindow : IResourceInterface
    {
        dynamic PreferredBackupWindow { get; set; }
    }

    public interface IHaveMasterUserPassword : IResourceInterface
    {
        dynamic MasterUserPassword { get; set; }
    }

    public interface IHaveFamily : IResourceInterface
    {
        dynamic Family { get; set; }
    }

    public interface IHaveTenancy : IResourceInterface
    {
        dynamic Tenancy { get; set; }
    }

    public interface IHaveIpAddress : IResourceInterface
    {
        dynamic IpAddress { get; set; }
    }

    public interface IHaveCidrBlock : IResourceInterface
    {
        dynamic CidrBlock { get; set; }
    }

    public interface IHavePermission : IResourceInterface
    {
        dynamic Permission { get; set; }
    }

    public interface IHavePlatformVersion : IResourceInterface
    {
        dynamic PlatformVersion { get; set; }
    }

    public interface IHaveIpAddressType : IResourceInterface
    {
        dynamic IpAddressType { get; set; }
    }

    public interface IHaveSchemaName : IResourceInterface
    {
        dynamic SchemaName { get; set; }
    }

    public interface IHaveResources : IResourceInterface
    {
        dynamic Resources { get; set; }
    }

    public interface IHaveDetectorId : IResourceInterface
    {
        dynamic DetectorId { get; set; }
    }

    public interface IHaveEnable : IResourceInterface
    {
        dynamic Enable { get; set; }
    }

    public interface IHaveDeviceId : IResourceInterface
    {
        dynamic DeviceId { get; set; }
    }

    public interface IHaveThingArn : IResourceInterface
    {
        dynamic ThingArn { get; set; }
    }

    public interface IHaveVpcInterfaceName : IResourceInterface
    {
        dynamic VpcInterfaceName { get; set; }
    }

    public interface IHaveNetworkFunctionGroupName : IResourceInterface
    {
        dynamic NetworkFunctionGroupName { get; set; }
    }

    public interface IHaveGlobalNetworkId : IResourceInterface
    {
        dynamic GlobalNetworkId { get; set; }
    }

    public interface IHaveModel : IResourceInterface
    {
        dynamic Model { get; set; }
    }

    public interface IHaveStreamName : IResourceInterface
    {
        dynamic StreamName { get; set; }
    }

    public interface IHaveEnableNetworkIsolation : IResourceInterface
    {
        dynamic EnableNetworkIsolation { get; set; }
    }

    public interface IHaveRegions : IResourceInterface
    {
        dynamic Regions { get; set; }
    }

    public interface IHaveComponentName : IResourceInterface
    {
        dynamic ComponentName { get; set; }
    }

    public interface IHaveReadOnly : IResourceInterface
    {
        dynamic ReadOnly { get; set; }
    }

    public interface IHaveOrientation : IResourceInterface
    {
        dynamic Orientation { get; set; }
    }

    public interface IHaveMethod : IResourceInterface
    {
        dynamic Method { get; set; }
    }

    public interface IHaveLimit : IResourceInterface
    {
        dynamic Limit { get; set; }
    }

    public interface IHaveRefreshToken : IResourceInterface
    {
        dynamic RefreshToken { get; set; }
    }

    public interface IHaveAppFlowConnectorProfileTypesConnectorOAuthRequestConnectorOAuthRequest : IResourceInterface
    {
        Humidifier.AppFlow.ConnectorProfileTypes.ConnectorOAuthRequest ConnectorOAuthRequest { get; set; }
    }

    public interface IHaveAwsRegion : IResourceInterface
    {
        dynamic AwsRegion { get; set; }
    }

    public interface IHaveResourceLabel : IResourceInterface
    {
        dynamic ResourceLabel { get; set; }
    }

    public interface IHaveWeightedCapacity : IResourceInterface
    {
        dynamic WeightedCapacity { get; set; }
    }

    public interface IHaveNoDevice : IResourceInterface
    {
        dynamic NoDevice { get; set; }
    }

    public interface IHaveVirtualName : IResourceInterface
    {
        dynamic VirtualName { get; set; }
    }

    public interface IHaveOrder : IResourceInterface
    {
        dynamic Order { get; set; }
    }

    public interface IHaveMaxTokens : IResourceInterface
    {
        dynamic MaxTokens { get; set; }
    }

    public interface IHaveModelId : IResourceInterface
    {
        dynamic ModelId { get; set; }
    }

    public interface IHaveEncryptionType : IResourceInterface
    {
        dynamic EncryptionType { get; set; }
    }

    public interface IHaveStreamArn : IResourceInterface
    {
        dynamic StreamArn { get; set; }
    }

    public interface IHaveOverride : IResourceInterface
    {
        dynamic Override { get; set; }
    }

    public interface IHaveBooleanValue : IResourceInterface
    {
        dynamic BooleanValue { get; set; }
    }

    public interface IHaveIntervalUnit : IResourceInterface
    {
        dynamic IntervalUnit { get; set; }
    }

    public interface IHaveMaxFileSize : IResourceInterface
    {
        dynamic MaxFileSize { get; set; }
    }

    public interface IHaveGid : IResourceInterface
    {
        dynamic Gid { get; set; }
    }

    public interface IHaveUid : IResourceInterface
    {
        dynamic Uid { get; set; }
    }

    public interface IHaveMaximum : IResourceInterface
    {
        dynamic Maximum { get; set; }
    }

    public interface IHaveFunctionArn : IResourceInterface
    {
        dynamic FunctionArn { get; set; }
    }

    public interface IHaveDestinationPath : IResourceInterface
    {
        dynamic DestinationPath { get; set; }
    }

    public interface IHaveIsActive : IResourceInterface
    {
        dynamic IsActive { get; set; }
    }

    public interface IHaveAggregationFunction : IResourceInterface
    {
        dynamic AggregationFunction { get; set; }
    }

    public interface IHaveConstantInitializationVector : IResourceInterface
    {
        dynamic ConstantInitializationVector { get; set; }
    }

    public interface IHaveManifestWindowSeconds : IResourceInterface
    {
        dynamic ManifestWindowSeconds { get; set; }
    }

    public interface IHaveQuickSightAnalysisTypesChartAxisLabelOptionsCategoryLabelOptions : IResourceInterface
    {
        Humidifier.QuickSight.AnalysisTypes.ChartAxisLabelOptions CategoryLabelOptions { get; set; }
    }

    public interface IHaveQuickSightAnalysisTypesLabelOptionsTitleOptions : IResourceInterface
    {
        Humidifier.QuickSight.AnalysisTypes.LabelOptions TitleOptions { get; set; }
    }

    public interface IHaveQuickSightAnalysisTypesSheetControlInfoIconLabelOptionsInfoIconLabelOptions : IResourceInterface
    {
        Humidifier.QuickSight.AnalysisTypes.SheetControlInfoIconLabelOptions InfoIconLabelOptions { get; set; }
    }

    public interface IHaveQuickSightAnalysisTypesDimensionFieldTime : IResourceInterface
    {
        Humidifier.QuickSight.AnalysisTypes.DimensionField Time { get; set; }
    }

    public interface IHaveQuickSightDashboardTypesChartAxisLabelOptionsCategoryLabelOptions : IResourceInterface
    {
        Humidifier.QuickSight.DashboardTypes.ChartAxisLabelOptions CategoryLabelOptions { get; set; }
    }

    public interface IHaveQuickSightDashboardTypesLabelOptionsTitleOptions : IResourceInterface
    {
        Humidifier.QuickSight.DashboardTypes.LabelOptions TitleOptions { get; set; }
    }

    public interface IHaveQuickSightDashboardTypesSheetControlInfoIconLabelOptionsInfoIconLabelOptions : IResourceInterface
    {
        Humidifier.QuickSight.DashboardTypes.SheetControlInfoIconLabelOptions InfoIconLabelOptions { get; set; }
    }

    public interface IHaveQuickSightDashboardTypesDimensionFieldTime : IResourceInterface
    {
        Humidifier.QuickSight.DashboardTypes.DimensionField Time { get; set; }
    }

    public interface IHaveQuickSightTemplateTypesChartAxisLabelOptionsCategoryLabelOptions : IResourceInterface
    {
        Humidifier.QuickSight.TemplateTypes.ChartAxisLabelOptions CategoryLabelOptions { get; set; }
    }

    public interface IHaveQuickSightTemplateTypesLabelOptionsTitleOptions : IResourceInterface
    {
        Humidifier.QuickSight.TemplateTypes.LabelOptions TitleOptions { get; set; }
    }

    public interface IHaveQuickSightTemplateTypesSheetControlInfoIconLabelOptionsInfoIconLabelOptions : IResourceInterface
    {
        Humidifier.QuickSight.TemplateTypes.SheetControlInfoIconLabelOptions InfoIconLabelOptions { get; set; }
    }

    public interface IHaveQuickSightTemplateTypesDimensionFieldTime : IResourceInterface
    {
        Humidifier.QuickSight.TemplateTypes.DimensionField Time { get; set; }
    }

    public interface IHaveProbabilityAttribute : IResourceInterface
    {
        dynamic ProbabilityAttribute { get; set; }
    }

    public interface IHaveAlias : IResourceInterface
    {
        dynamic Alias { get; set; }
    }

    public interface IHaveStage : IResourceInterface
    {
        dynamic Stage { get; set; }
    }

    public interface IHaveHttpMethod : IResourceInterface
    {
        dynamic HttpMethod { get; set; }
    }

    public interface IHaveSchema : IResourceInterface
    {
        dynamic Schema { get; set; }
    }

    public interface IHaveKmsKeyIdentifier : IResourceInterface
    {
        dynamic KmsKeyIdentifier { get; set; }
    }

    public interface IHaveMeshOwner : IResourceInterface
    {
        dynamic MeshOwner { get; set; }
    }

    public interface IHaveWorkingDirectory : IResourceInterface
    {
        dynamic WorkingDirectory { get; set; }
    }

    public interface IHaveServiceRoleArn : IResourceInterface
    {
        dynamic ServiceRoleArn { get; set; }
    }

    public interface IHaveDefinition : IResourceInterface
    {
        dynamic Definition { get; set; }
    }

    public interface IHaveKeyName : IResourceInterface
    {
        dynamic KeyName { get; set; }
    }

    public interface IHaveScalingAdjustment : IResourceInterface
    {
        dynamic ScalingAdjustment { get; set; }
    }

    public interface IHaveEmail : IResourceInterface
    {
        dynamic Email { get; set; }
    }

    public interface IHaveLogGroupArn : IResourceInterface
    {
        dynamic LogGroupArn { get; set; }
    }

    public interface IHaveServiceRole : IResourceInterface
    {
        dynamic ServiceRole { get; set; }
    }

    public interface IHavePropagateTags : IResourceInterface
    {
        dynamic PropagateTags { get; set; }
    }

    public interface IHaveCompression : IResourceInterface
    {
        dynamic Compression { get; set; }
    }

    public interface IHaveConfiguration : IResourceInterface
    {
        dynamic Configuration { get; set; }
    }

    public interface IHaveEvaluationPeriods : IResourceInterface
    {
        dynamic EvaluationPeriods { get; set; }
    }

    public interface IHaveAlarmName : IResourceInterface
    {
        dynamic AlarmName { get; set; }
    }

    public interface IHaveEncryptionKey : IResourceInterface
    {
        dynamic EncryptionKey { get; set; }
    }

    public interface IHaveCategory : IResourceInterface
    {
        dynamic Category { get; set; }
    }

    public interface IHaveNetworkType : IResourceInterface
    {
        dynamic NetworkType { get; set; }
    }

    public interface IHaveMaxRetries : IResourceInterface
    {
        dynamic MaxRetries { get; set; }
    }

    public interface IHaveSecurityGroupArns : IResourceInterface
    {
        dynamic SecurityGroupArns { get; set; }
    }

    public interface IHaveAgentArns : IResourceInterface
    {
        dynamic AgentArns { get; set; }
    }

    public interface IHaveEnvironmentIdentifier : IResourceInterface
    {
        dynamic EnvironmentIdentifier { get; set; }
    }

    public interface IHaveTemplateType : IResourceInterface
    {
        dynamic TemplateType { get; set; }
    }

    public interface IHaveDBClusterIdentifier : IResourceInterface
    {
        dynamic DBClusterIdentifier { get; set; }
    }

    public interface IHaveDestinationCidrBlock : IResourceInterface
    {
        dynamic DestinationCidrBlock { get; set; }
    }

    public interface IHaveTier : IResourceInterface
    {
        dynamic Tier { get; set; }
    }

    public interface IHaveRegistryName : IResourceInterface
    {
        dynamic RegistryName { get; set; }
    }

    public interface IHaveSchedule : IResourceInterface
    {
        dynamic Schedule { get; set; }
    }

    public interface IHaveAttributes_ : IResourceInterface
    {
        dynamic Attributes_ { get; set; }
    }

    public interface IHaveColumnNames : IResourceInterface
    {
        dynamic ColumnNames { get; set; }
    }

    public interface IHaveTagKey : IResourceInterface
    {
        dynamic TagKey { get; set; }
    }

    public interface IHaveMaximumRetryAttempts : IResourceInterface
    {
        dynamic MaximumRetryAttempts { get; set; }
    }

    public interface IHaveRuntime : IResourceInterface
    {
        dynamic Runtime { get; set; }
    }

    public interface IHaveModelName : IResourceInterface
    {
        dynamic ModelName { get; set; }
    }

    public interface IHaveClusterArn : IResourceInterface
    {
        dynamic ClusterArn { get; set; }
    }

    public interface IHaveMaxBitrate : IResourceInterface
    {
        dynamic MaxBitrate { get; set; }
    }

    public interface IHaveEventType : IResourceInterface
    {
        dynamic EventType { get; set; }
    }

    public interface IHaveResourceTypes : IResourceInterface
    {
        dynamic ResourceTypes { get; set; }
    }

    public interface IHaveSchemaArn : IResourceInterface
    {
        dynamic SchemaArn { get; set; }
    }

    public interface IHaveApiKey : IResourceInterface
    {
        dynamic ApiKey { get; set; }
    }

    public interface IHaveSubject : IResourceInterface
    {
        dynamic Subject { get; set; }
    }

    public interface IHaveStartDate : IResourceInterface
    {
        dynamic StartDate { get; set; }
    }

    public interface IHaveDuration : IResourceInterface
    {
        dynamic Duration { get; set; }
    }

    public interface IHaveAcceleratorTypes : IResourceInterface
    {
        dynamic AcceleratorTypes { get; set; }
    }

    public interface IHaveAggregation : IResourceInterface
    {
        dynamic Aggregation { get; set; }
    }

    public interface IHaveDeploymentType : IResourceInterface
    {
        dynamic DeploymentType { get; set; }
    }

    public interface IHaveMaxValue : IResourceInterface
    {
        dynamic MaxValue { get; set; }
    }

    public interface IHaveRequired : IResourceInterface
    {
        dynamic Required { get; set; }
    }

    public interface IHaveMinValue : IResourceInterface
    {
        dynamic MinValue { get; set; }
    }

    public interface IHaveRepositoryUrl : IResourceInterface
    {
        dynamic RepositoryUrl { get; set; }
    }

    public interface IHaveReturnData : IResourceInterface
    {
        dynamic ReturnData { get; set; }
    }

    public interface IHaveContainerPath : IResourceInterface
    {
        dynamic ContainerPath { get; set; }
    }

    public interface IHaveAssignPublicIp : IResourceInterface
    {
        dynamic AssignPublicIp { get; set; }
    }

    public interface IHaveCredentialsSecretArn : IResourceInterface
    {
        dynamic CredentialsSecretArn { get; set; }
    }

    public interface IHaveBucketArn : IResourceInterface
    {
        dynamic BucketArn { get; set; }
    }

    public interface IHaveLocaleId : IResourceInterface
    {
        dynamic LocaleId { get; set; }
    }

    public interface IHaveObjectVersion : IResourceInterface
    {
        dynamic ObjectVersion { get; set; }
    }

    public interface IHaveServiceAccessRoleArn : IResourceInterface
    {
        dynamic ServiceAccessRoleArn { get; set; }
    }

    public interface IHaveSecretManagerArn : IResourceInterface
    {
        dynamic SecretManagerArn { get; set; }
    }

    public interface IHaveRegionName : IResourceInterface
    {
        dynamic RegionName { get; set; }
    }

    public interface IHaveTo : IResourceInterface
    {
        dynamic To { get; set; }
    }

    public interface IHaveCapacityProvider : IResourceInterface
    {
        dynamic CapacityProvider { get; set; }
    }

    public interface IHaveTargetGroupArn : IResourceInterface
    {
        dynamic TargetGroupArn { get; set; }
    }

    public interface IHaveContainerPort : IResourceInterface
    {
        dynamic ContainerPort { get; set; }
    }

    public interface IHaveClassification : IResourceInterface
    {
        dynamic Classification { get; set; }
    }

    public interface IHaveS3ObjectVersion : IResourceInterface
    {
        dynamic S3ObjectVersion { get; set; }
    }

    public interface IHaveComparison : IResourceInterface
    {
        dynamic Comparison { get; set; }
    }

    public interface IHaveLatitude : IResourceInterface
    {
        dynamic Latitude { get; set; }
    }

    public interface IHaveLongitude : IResourceInterface
    {
        dynamic Longitude { get; set; }
    }

    public interface IHaveFullyQualifiedName : IResourceInterface
    {
        dynamic FullyQualifiedName { get; set; }
    }

    public interface IHaveInclusionPatterns : IResourceInterface
    {
        dynamic InclusionPatterns { get; set; }
    }

    public interface IHaveExclusionPatterns : IResourceInterface
    {
        dynamic ExclusionPatterns { get; set; }
    }

    public interface IHaveDocumentDataFieldName : IResourceInterface
    {
        dynamic DocumentDataFieldName { get; set; }
    }

    public interface IHaveRecordFormatType : IResourceInterface
    {
        dynamic RecordFormatType { get; set; }
    }

    public interface IHaveBucketARN : IResourceInterface
    {
        dynamic BucketARN { get; set; }
    }

    public interface IHaveIntervalInSeconds : IResourceInterface
    {
        dynamic IntervalInSeconds { get; set; }
    }

    public interface IHaveSizeInMBs : IResourceInterface
    {
        dynamic SizeInMBs { get; set; }
    }

    public interface IHaveAllowInterrupt : IResourceInterface
    {
        dynamic AllowInterrupt { get; set; }
    }

    public interface IHaveCodingMode : IResourceInterface
    {
        dynamic CodingMode { get; set; }
    }

    public interface IHaveAlignment : IResourceInterface
    {
        dynamic Alignment { get; set; }
    }

    public interface IHaveNumRetries : IResourceInterface
    {
        dynamic NumRetries { get; set; }
    }

    public interface IHaveRestartDelay : IResourceInterface
    {
        dynamic RestartDelay { get; set; }
    }

    public interface IHaveConnectionRetryInterval : IResourceInterface
    {
        dynamic ConnectionRetryInterval { get; set; }
    }

    public interface IHaveTextColor : IResourceInterface
    {
        dynamic TextColor { get; set; }
    }

    public interface IHaveArcThickness : IResourceInterface
    {
        dynamic ArcThickness { get; set; }
    }

    public interface IHaveQuickSightAnalysisTypesFontConfigurationFontConfiguration : IResourceInterface
    {
        Humidifier.QuickSight.AnalysisTypes.FontConfiguration FontConfiguration { get; set; }
    }

    public interface IHaveBarsArrangement : IResourceInterface
    {
        dynamic BarsArrangement { get; set; }
    }

    public interface IHaveQuickSightAnalysisTypesItemsLimitConfigurationCategoryItemsLimit : IResourceInterface
    {
        Humidifier.QuickSight.AnalysisTypes.ItemsLimitConfiguration CategoryItemsLimit { get; set; }
    }

    public interface IHaveSectionId : IResourceInterface
    {
        dynamic SectionId { get; set; }
    }

    public interface IHaveTooltipTarget : IResourceInterface
    {
        dynamic TooltipTarget { get; set; }
    }

    public interface IHaveIcon : IResourceInterface
    {
        dynamic Icon { get; set; }
    }

    public interface IHaveNumberScale : IResourceInterface
    {
        dynamic NumberScale { get; set; }
    }

    public interface IHaveSymbol : IResourceInterface
    {
        dynamic Symbol { get; set; }
    }

    public interface IHaveDataValue : IResourceInterface
    {
        dynamic DataValue { get; set; }
    }

    public interface IHaveMeasureLabelVisibility : IResourceInterface
    {
        dynamic MeasureLabelVisibility { get; set; }
    }

    public interface IHaveCategoryLabelVisibility : IResourceInterface
    {
        dynamic CategoryLabelVisibility { get; set; }
    }

    public interface IHaveLabelColor : IResourceInterface
    {
        dynamic LabelColor { get; set; }
    }

    public interface IHaveDataSetArn : IResourceInterface
    {
        dynamic DataSetArn { get; set; }
    }

    public interface IHavePeriodsBackward : IResourceInterface
    {
        dynamic PeriodsBackward { get; set; }
    }

    public interface IHavePeriodsForward : IResourceInterface
    {
        dynamic PeriodsForward { get; set; }
    }

    public interface IHavePredictionInterval : IResourceInterface
    {
        dynamic PredictionInterval { get; set; }
    }

    public interface IHaveSeasonality : IResourceInterface
    {
        dynamic Seasonality { get; set; }
    }

    public interface IHaveUpperBoundary : IResourceInterface
    {
        dynamic UpperBoundary { get; set; }
    }

    public interface IHaveLowerBoundary : IResourceInterface
    {
        dynamic LowerBoundary { get; set; }
    }

    public interface IHaveElementType : IResourceInterface
    {
        dynamic ElementType { get; set; }
    }

    public interface IHaveElementId : IResourceInterface
    {
        dynamic ElementId { get; set; }
    }

    public interface IHaveOptimizedViewPortWidth : IResourceInterface
    {
        dynamic OptimizedViewPortWidth { get; set; }
    }

    public interface IHavePrimaryValueDisplayType : IResourceInterface
    {
        dynamic PrimaryValueDisplayType { get; set; }
    }

    public interface IHaveQuickSightAnalysisTypesConditionalFormattingColorTextColor : IResourceInterface
    {
        Humidifier.QuickSight.AnalysisTypes.ConditionalFormattingColor TextColor { get; set; }
    }

    public interface IHaveTooltipVisibility : IResourceInterface
    {
        dynamic TooltipVisibility { get; set; }
    }

    public interface IHaveRichText : IResourceInterface
    {
        dynamic RichText { get; set; }
    }

    public interface IHavePlainText : IResourceInterface
    {
        dynamic PlainText { get; set; }
    }

    public interface IHaveIncludeMaximum : IResourceInterface
    {
        dynamic IncludeMaximum { get; set; }
    }

    public interface IHaveIncludeMinimum : IResourceInterface
    {
        dynamic IncludeMinimum { get; set; }
    }

    public interface IHaveStaticValue : IResourceInterface
    {
        dynamic StaticValue { get; set; }
    }

    public interface IHaveParameter : IResourceInterface
    {
        dynamic Parameter { get; set; }
    }

    public interface IHaveHorizontalTextAlignment : IResourceInterface
    {
        dynamic HorizontalTextAlignment { get; set; }
    }

    public interface IHaveOverflowColumnHeaderVisibility : IResourceInterface
    {
        dynamic OverflowColumnHeaderVisibility { get; set; }
    }

    public interface IHaveVerticalOverflowVisibility : IResourceInterface
    {
        dynamic VerticalOverflowVisibility { get; set; }
    }

    public interface IHaveScrollStatus : IResourceInterface
    {
        dynamic ScrollStatus { get; set; }
    }

    public interface IHaveQuickSightDashboardTypesFontConfigurationFontConfiguration : IResourceInterface
    {
        Humidifier.QuickSight.DashboardTypes.FontConfiguration FontConfiguration { get; set; }
    }

    public interface IHaveQuickSightDashboardTypesItemsLimitConfigurationCategoryItemsLimit : IResourceInterface
    {
        Humidifier.QuickSight.DashboardTypes.ItemsLimitConfiguration CategoryItemsLimit { get; set; }
    }

    public interface IHaveQuickSightDashboardTypesConditionalFormattingColorTextColor : IResourceInterface
    {
        Humidifier.QuickSight.DashboardTypes.ConditionalFormattingColor TextColor { get; set; }
    }

    public interface IHaveValueType : IResourceInterface
    {
        dynamic ValueType { get; set; }
    }

    public interface IHaveQuickSightTemplateTypesFontConfigurationFontConfiguration : IResourceInterface
    {
        Humidifier.QuickSight.TemplateTypes.FontConfiguration FontConfiguration { get; set; }
    }

    public interface IHaveQuickSightTemplateTypesItemsLimitConfigurationCategoryItemsLimit : IResourceInterface
    {
        Humidifier.QuickSight.TemplateTypes.ItemsLimitConfiguration CategoryItemsLimit { get; set; }
    }

    public interface IHaveQuickSightTemplateTypesConditionalFormattingColorTextColor : IResourceInterface
    {
        Humidifier.QuickSight.TemplateTypes.ConditionalFormattingColor TextColor { get; set; }
    }

    public interface IHaveSageMakerDomainTypesResourceSpecDefaultResourceSpec : IResourceInterface
    {
        Humidifier.SageMaker.DomainTypes.ResourceSpec DefaultResourceSpec { get; set; }
    }

    public interface IHaveInferenceAttribute : IResourceInterface
    {
        dynamic InferenceAttribute { get; set; }
    }

    public interface IHaveWAFv2RuleGroupTypesFieldToMatchFieldToMatch : IResourceInterface
    {
        Humidifier.WAFv2.RuleGroupTypes.FieldToMatch FieldToMatch { get; set; }
    }

    public interface IHaveAll : IResourceInterface
    {
        dynamic All { get; set; }
    }

    public interface IHaveMatchScope : IResourceInterface
    {
        dynamic MatchScope { get; set; }
    }

    public interface IHaveFallbackBehavior : IResourceInterface
    {
        dynamic FallbackBehavior { get; set; }
    }

    public interface IHaveWAFv2WebACLTypesFieldToMatchFieldToMatch : IResourceInterface
    {
        Humidifier.WAFv2.WebACLTypes.FieldToMatch FieldToMatch { get; set; }
    }

    public interface IHavePlatform : IResourceInterface
    {
        dynamic Platform { get; set; }
    }

    public interface IHaveAppId : IResourceInterface
    {
        dynamic AppId { get; set; }
    }

    public interface IHaveEnvironmentName : IResourceInterface
    {
        dynamic EnvironmentName { get; set; }
    }

    public interface IHaveOperationName : IResourceInterface
    {
        dynamic OperationName { get; set; }
    }

    public interface IHaveAuthorizationType : IResourceInterface
    {
        dynamic AuthorizationType { get; set; }
    }

    public interface IHaveConnectorType : IResourceInterface
    {
        dynamic ConnectorType { get; set; }
    }

    public interface IHaveApplicationArn : IResourceInterface
    {
        dynamic ApplicationArn { get; set; }
    }

    public interface IHaveContext : IResourceInterface
    {
        dynamic Context { get; set; }
    }

    public interface IHaveAutoScalingGroupName : IResourceInterface
    {
        dynamic AutoScalingGroupName { get; set; }
    }

    public interface IHaveUserData : IResourceInterface
    {
        dynamic UserData { get; set; }
    }

    public interface IHaveAssociatePublicIpAddress : IResourceInterface
    {
        dynamic AssociatePublicIpAddress { get; set; }
    }

    public interface IHaveJobDefinitionName : IResourceInterface
    {
        dynamic JobDefinitionName { get; set; }
    }

    public interface IHaveKnowledgeBaseId : IResourceInterface
    {
        dynamic KnowledgeBaseId { get; set; }
    }

    public interface IHaveService : IResourceInterface
    {
        dynamic Service { get; set; }
    }

    public interface IHaveSubscriptionName : IResourceInterface
    {
        dynamic SubscriptionName { get; set; }
    }

    public interface IHaveS3Prefix : IResourceInterface
    {
        dynamic S3Prefix { get; set; }
    }

    public interface IHaveMembershipIdentifier : IResourceInterface
    {
        dynamic MembershipIdentifier { get; set; }
    }

    public interface IHaveVersionId : IResourceInterface
    {
        dynamic VersionId { get; set; }
    }

    public interface IHaveTemplateBody : IResourceInterface
    {
        dynamic TemplateBody { get; set; }
    }

    public interface IHaveSourceVersion : IResourceInterface
    {
        dynamic SourceVersion { get; set; }
    }

    public interface IHaveProvider : IResourceInterface
    {
        dynamic Provider { get; set; }
    }

    public interface IHaveIdentityPoolId : IResourceInterface
    {
        dynamic IdentityPoolId { get; set; }
    }

    public interface IHaveMaximumExecutionFrequency : IResourceInterface
    {
        dynamic MaximumExecutionFrequency { get; set; }
    }

    public interface IHaveVersionDescription : IResourceInterface
    {
        dynamic VersionDescription { get; set; }
    }

    public interface IHaveParameterGroupName : IResourceInterface
    {
        dynamic ParameterGroupName { get; set; }
    }

    public interface IHaveSubnetGroupName : IResourceInterface
    {
        dynamic SubnetGroupName { get; set; }
    }

    public interface IHaveSslMode : IResourceInterface
    {
        dynamic SslMode { get; set; }
    }

    public interface IHaveEventCategories : IResourceInterface
    {
        dynamic EventCategories { get; set; }
    }

    public interface IHaveSourceIds : IResourceInterface
    {
        dynamic SourceIds { get; set; }
    }

    public interface IHaveS3BucketArn : IResourceInterface
    {
        dynamic S3BucketArn { get; set; }
    }

    public interface IHaveCloudWatchLogGroupArn : IResourceInterface
    {
        dynamic CloudWatchLogGroupArn { get; set; }
    }

    public interface IHaveFarmId : IResourceInterface
    {
        dynamic FarmId { get; set; }
    }

    public interface IHaveStorageEncrypted : IResourceInterface
    {
        dynamic StorageEncrypted { get; set; }
    }

    public interface IHaveSourceDBClusterIdentifier : IResourceInterface
    {
        dynamic SourceDBClusterIdentifier { get; set; }
    }

    public interface IHaveMasterUsername : IResourceInterface
    {
        dynamic MasterUsername { get; set; }
    }

    public interface IHaveBackupRetentionPeriod : IResourceInterface
    {
        dynamic BackupRetentionPeriod { get; set; }
    }

    public interface IHaveOutpostArn : IResourceInterface
    {
        dynamic OutpostArn { get; set; }
    }

    public interface IHaveIpv6AddressCount : IResourceInterface
    {
        dynamic Ipv6AddressCount { get; set; }
    }

    public interface IHaveSecondaryPrivateIpAddressCount : IResourceInterface
    {
        dynamic SecondaryPrivateIpAddressCount { get; set; }
    }

    public interface IHaveIpv6CidrBlock : IResourceInterface
    {
        dynamic Ipv6CidrBlock { get; set; }
    }

    public interface IHaveLaunchType : IResourceInterface
    {
        dynamic LaunchType { get; set; }
    }

    public interface IHaveCustomAmiId : IResourceInterface
    {
        dynamic CustomAmiId { get; set; }
    }

    public interface IHaveArchitecture : IResourceInterface
    {
        dynamic Architecture { get; set; }
    }

    public interface IHaveEventPattern : IResourceInterface
    {
        dynamic EventPattern { get; set; }
    }

    public interface IHaveDataSource : IResourceInterface
    {
        dynamic DataSource { get; set; }
    }

    public interface IHaveLocationName : IResourceInterface
    {
        dynamic LocationName { get; set; }
    }

    public interface IHavePrincipals : IResourceInterface
    {
        dynamic Principals { get; set; }
    }

    public interface IHaveUsers : IResourceInterface
    {
        dynamic Users { get; set; }
    }

    public interface IHaveDayOfWeek : IResourceInterface
    {
        dynamic DayOfWeek { get; set; }
    }

    public interface IHaveThingName : IResourceInterface
    {
        dynamic ThingName { get; set; }
    }

    public interface IHaveInputName : IResourceInterface
    {
        dynamic InputName { get; set; }
    }

    public interface IHaveWorkspaceId : IResourceInterface
    {
        dynamic WorkspaceId { get; set; }
    }

    public interface IHaveEntityId : IResourceInterface
    {
        dynamic EntityId { get; set; }
    }

    public interface IHaveIndexId : IResourceInterface
    {
        dynamic IndexId { get; set; }
    }

    public interface IHaveDeliveryStreamName : IResourceInterface
    {
        dynamic DeliveryStreamName { get; set; }
    }

    public interface IHaveTagValues : IResourceInterface
    {
        dynamic TagValues { get; set; }
    }

    public interface IHaveStartingPosition : IResourceInterface
    {
        dynamic StartingPosition { get; set; }
    }

    public interface IHaveCertificateName : IResourceInterface
    {
        dynamic CertificateName { get; set; }
    }

    public interface IHaveLogType : IResourceInterface
    {
        dynamic LogType { get; set; }
    }

    public interface IHaveNetworkId : IResourceInterface
    {
        dynamic NetworkId { get; set; }
    }

    public interface IHaveChannelId : IResourceInterface
    {
        dynamic ChannelId { get; set; }
    }

    public interface IHaveChannelGroupName : IResourceInterface
    {
        dynamic ChannelGroupName { get; set; }
    }

    public interface IHaveHostname : IResourceInterface
    {
        dynamic Hostname { get; set; }
    }

    public interface IHaveMountPoint : IResourceInterface
    {
        dynamic MountPoint { get; set; }
    }

    public interface IHaveConnectorArn : IResourceInterface
    {
        dynamic ConnectorArn { get; set; }
    }

    public interface IHaveDefaultAuthenticationMethod : IResourceInterface
    {
        dynamic DefaultAuthenticationMethod { get; set; }
    }

    public interface IHaveDynDicOfAdditionalEncryptionContext : IResourceInterface
    {
        Dictionary<string, dynamic> AdditionalEncryptionContext { get; set; }
    }

    public interface IHaveNamespaceName : IResourceInterface
    {
        dynamic NamespaceName { get; set; }
    }

    public interface IHaveTTL : IResourceInterface
    {
        dynamic TTL { get; set; }
    }

    public interface IHaveTopicName : IResourceInterface
    {
        dynamic TopicName { get; set; }
    }

    public interface IHaveDocumentVersion : IResourceInterface
    {
        dynamic DocumentVersion { get; set; }
    }

    public interface IHaveBlockPublicPolicy : IResourceInterface
    {
        dynamic BlockPublicPolicy { get; set; }
    }

    public interface IHaveSecretId : IResourceInterface
    {
        dynamic SecretId { get; set; }
    }

    public interface IHaveEvent : IResourceInterface
    {
        dynamic Event { get; set; }
    }

    public interface IHaveDataTraceEnabled : IResourceInterface
    {
        dynamic DataTraceEnabled { get; set; }
    }

    public interface IHaveThrottlingBurstLimit : IResourceInterface
    {
        dynamic ThrottlingBurstLimit { get; set; }
    }

    public interface IHaveThrottlingRateLimit : IResourceInterface
    {
        dynamic ThrottlingRateLimit { get; set; }
    }

    public interface IHaveOffset : IResourceInterface
    {
        dynamic Offset { get; set; }
    }

    public interface IHaveUnhealthyThreshold : IResourceInterface
    {
        dynamic UnhealthyThreshold { get; set; }
    }

    public interface IHaveHealthyThreshold : IResourceInterface
    {
        dynamic HealthyThreshold { get; set; }
    }

    public interface IHaveSecretName : IResourceInterface
    {
        dynamic SecretName { get; set; }
    }

    public interface IHaveOrganizationalUnitDistinguishedName : IResourceInterface
    {
        dynamic OrganizationalUnitDistinguishedName { get; set; }
    }

    public interface IHavePredefinedMetricType : IResourceInterface
    {
        dynamic PredefinedMetricType { get; set; }
    }

    public interface IHaveDisableScaleIn : IResourceInterface
    {
        dynamic DisableScaleIn { get; set; }
    }

    public interface IHavePrometheusPort : IResourceInterface
    {
        dynamic PrometheusPort { get; set; }
    }

    public interface IHaveExcludedInstanceTypes : IResourceInterface
    {
        dynamic ExcludedInstanceTypes { get; set; }
    }

    public interface IHaveAllowedInstanceTypes : IResourceInterface
    {
        dynamic AllowedInstanceTypes { get; set; }
    }

    public interface IHaveGranularity : IResourceInterface
    {
        dynamic Granularity { get; set; }
    }

    public interface IHaveArgs : IResourceInterface
    {
        dynamic Args { get; set; }
    }

    public interface IHaveOptions : IResourceInterface
    {
        dynamic Options { get; set; }
    }

    public interface IHaveReason : IResourceInterface
    {
        dynamic Reason { get; set; }
    }

    public interface IHaveTopK : IResourceInterface
    {
        dynamic TopK { get; set; }
    }

    public interface IHaveTemperature : IResourceInterface
    {
        dynamic Temperature { get; set; }
    }

    public interface IHaveStopSequences : IResourceInterface
    {
        dynamic StopSequences { get; set; }
    }

    public interface IHaveTopP : IResourceInterface
    {
        dynamic TopP { get; set; }
    }

    public interface IHaveInput : IResourceInterface
    {
        dynamic Input { get; set; }
    }

    public interface IHaveItems : IResourceInterface
    {
        dynamic Items { get; set; }
    }

    public interface IHaveBucketOwner : IResourceInterface
    {
        dynamic BucketOwner { get; set; }
    }

    public interface IHaveEvents : IResourceInterface
    {
        dynamic Events { get; set; }
    }

    public interface IHaveConnectTaskTemplateTypesFieldIdentifierId : IResourceInterface
    {
        Humidifier.Connect.TaskTemplateTypes.FieldIdentifier Id { get; set; }
    }

    public interface IHaveHierarchyLevelId : IResourceInterface
    {
        dynamic HierarchyLevelId { get; set; }
    }

    public interface IHaveHierarchyLevelArn : IResourceInterface
    {
        dynamic HierarchyLevelArn { get; set; }
    }

    public interface IHaveTopic : IResourceInterface
    {
        dynamic Topic { get; set; }
    }

    public interface IHaveUnits : IResourceInterface
    {
        dynamic Units { get; set; }
    }

    public interface IHaveReportLevel : IResourceInterface
    {
        dynamic ReportLevel { get; set; }
    }

    public interface IHaveAttributeType : IResourceInterface
    {
        dynamic AttributeType { get; set; }
    }

    public interface IHaveDeliveryStream : IResourceInterface
    {
        dynamic DeliveryStream { get; set; }
    }

    public interface IHaveSessionTimeout : IResourceInterface
    {
        dynamic SessionTimeout { get; set; }
    }

    public interface IHaveJobName : IResourceInterface
    {
        dynamic JobName { get; set; }
    }

    public interface IHaveLongValue : IResourceInterface
    {
        dynamic LongValue { get; set; }
    }

    public interface IHaveSortOrder : IResourceInterface
    {
        dynamic SortOrder { get; set; }
    }

    public interface IHaveDays : IResourceInterface
    {
        dynamic Days { get; set; }
    }

    public interface IHaveIntegerValue : IResourceInterface
    {
        dynamic IntegerValue { get; set; }
    }

    public interface IHavePid : IResourceInterface
    {
        dynamic Pid { get; set; }
    }

    public interface IHaveCrawlAttachments : IResourceInterface
    {
        dynamic CrawlAttachments { get; set; }
    }

    public interface IHaveDateFieldFormat : IResourceInterface
    {
        dynamic DateFieldFormat { get; set; }
    }

    public interface IHaveIndexFieldName : IResourceInterface
    {
        dynamic IndexFieldName { get; set; }
    }

    public interface IHaveDataSourceFieldName : IResourceInterface
    {
        dynamic DataSourceFieldName { get; set; }
    }

    public interface IHaveImageUrl : IResourceInterface
    {
        dynamic ImageUrl { get; set; }
    }

    public interface IHaveNetworkName : IResourceInterface
    {
        dynamic NetworkName { get; set; }
    }

    public interface IHaveProfile : IResourceInterface
    {
        dynamic Profile { get; set; }
    }

    public interface IHaveNameModifier : IResourceInterface
    {
        dynamic NameModifier { get; set; }
    }

    public interface IHaveFilecacheDuration : IResourceInterface
    {
        dynamic FilecacheDuration { get; set; }
    }

    public interface IHaveAdMarkers : IResourceInterface
    {
        dynamic AdMarkers { get; set; }
    }

    public interface IHaveIncludeIframeOnlyStream : IResourceInterface
    {
        dynamic IncludeIframeOnlyStream { get; set; }
    }

    public interface IHaveProgramDateTimeIntervalSeconds : IResourceInterface
    {
        dynamic ProgramDateTimeIntervalSeconds { get; set; }
    }

    public interface IHaveSegmentName : IResourceInterface
    {
        dynamic SegmentName { get; set; }
    }

    public interface IHaveQuickSightAnalysisTypesNullValueFormatConfigurationNullValueFormatConfiguration : IResourceInterface
    {
        Humidifier.QuickSight.AnalysisTypes.NullValueFormatConfiguration NullValueFormatConfiguration { get; set; }
    }

    public interface IHaveQuickSightAnalysisTypesCascadingControlConfigurationCascadingControlConfiguration : IResourceInterface
    {
        Humidifier.QuickSight.AnalysisTypes.CascadingControlConfiguration CascadingControlConfiguration { get; set; }
    }

    public interface IHaveQuickSightAnalysisTypesConditionalFormattingIconIcon : IResourceInterface
    {
        Humidifier.QuickSight.AnalysisTypes.ConditionalFormattingIcon Icon { get; set; }
    }

    public interface IHaveQuickSightDashboardTypesNullValueFormatConfigurationNullValueFormatConfiguration : IResourceInterface
    {
        Humidifier.QuickSight.DashboardTypes.NullValueFormatConfiguration NullValueFormatConfiguration { get; set; }
    }

    public interface IHaveQuickSightDashboardTypesCascadingControlConfigurationCascadingControlConfiguration : IResourceInterface
    {
        Humidifier.QuickSight.DashboardTypes.CascadingControlConfiguration CascadingControlConfiguration { get; set; }
    }

    public interface IHaveQuickSightDashboardTypesConditionalFormattingIconIcon : IResourceInterface
    {
        Humidifier.QuickSight.DashboardTypes.ConditionalFormattingIcon Icon { get; set; }
    }

    public interface IHaveQuickSightTemplateTypesNullValueFormatConfigurationNullValueFormatConfiguration : IResourceInterface
    {
        Humidifier.QuickSight.TemplateTypes.NullValueFormatConfiguration NullValueFormatConfiguration { get; set; }
    }

    public interface IHaveQuickSightTemplateTypesCascadingControlConfigurationCascadingControlConfiguration : IResourceInterface
    {
        Humidifier.QuickSight.TemplateTypes.CascadingControlConfiguration CascadingControlConfiguration { get; set; }
    }

    public interface IHaveQuickSightTemplateTypesConditionalFormattingIconIcon : IResourceInterface
    {
        Humidifier.QuickSight.TemplateTypes.ConditionalFormattingIcon Icon { get; set; }
    }

    public interface IHaveListOfS3BucketTypesTagFilterTagFilters : IResourceInterface
    {
        List<Humidifier.S3.BucketTypes.TagFilter> TagFilters { get; set; }
    }

    public interface IHaveActionFailurePolicy : IResourceInterface
    {
        dynamic ActionFailurePolicy { get; set; }
    }

    public interface IHaveDataCapturedDestinationS3Uri : IResourceInterface
    {
        dynamic DataCapturedDestinationS3Uri { get; set; }
    }

    public interface IHaveParquet : IResourceInterface
    {
        dynamic Parquet { get; set; }
    }

    public interface IHaveLine : IResourceInterface
    {
        dynamic Line { get; set; }
    }

    public interface IHaveEnableInterContainerTrafficEncryption : IResourceInterface
    {
        dynamic EnableInterContainerTrafficEncryption { get; set; }
    }

    public interface IHaveS3UploadMode : IResourceInterface
    {
        dynamic S3UploadMode { get; set; }
    }

    public interface IHaveMaxRuntimeInSeconds : IResourceInterface
    {
        dynamic MaxRuntimeInSeconds { get; set; }
    }

    public interface IHaveFeaturesAttribute : IResourceInterface
    {
        dynamic FeaturesAttribute { get; set; }
    }

    public interface IHaveModelDataUrl : IResourceInterface
    {
        dynamic ModelDataUrl { get; set; }
    }

    public interface IHaveSageMakerModelPackageTypesMetricsSourceConstraints : IResourceInterface
    {
        Humidifier.SageMaker.ModelPackageTypes.MetricsSource Constraints { get; set; }
    }

    public interface IHaveSourceFileLocation : IResourceInterface
    {
        dynamic SourceFileLocation { get; set; }
    }

    public interface IHaveEngineType : IResourceInterface
    {
        dynamic EngineType { get; set; }
    }

    public interface IHaveRepository : IResourceInterface
    {
        dynamic Repository { get; set; }
    }

    public interface IHaveBuildSpec : IResourceInterface
    {
        dynamic BuildSpec { get; set; }
    }

    public interface IHaveFramework : IResourceInterface
    {
        dynamic Framework { get; set; }
    }

    public interface IHaveKeyId : IResourceInterface
    {
        dynamic KeyId { get; set; }
    }

    public interface IHaveConnectionType : IResourceInterface
    {
        dynamic ConnectionType { get; set; }
    }

    public interface IHaveConnectorProfileName : IResourceInterface
    {
        dynamic ConnectorProfileName { get; set; }
    }

    public interface IHaveKMSArn : IResourceInterface
    {
        dynamic KMSArn { get; set; }
    }

    public interface IHaveMaxConcurrency : IResourceInterface
    {
        dynamic MaxConcurrency { get; set; }
    }

    public interface IHaveStackName : IResourceInterface
    {
        dynamic StackName { get; set; }
    }

    public interface IHaveFirstName : IResourceInterface
    {
        dynamic FirstName { get; set; }
    }

    public interface IHaveLastName : IResourceInterface
    {
        dynamic LastName { get; set; }
    }

    public interface IHaveTtl : IResourceInterface
    {
        dynamic Ttl { get; set; }
    }

    public interface IHaveKernelId : IResourceInterface
    {
        dynamic KernelId { get; set; }
    }

    public interface IHaveSpotPrice : IResourceInterface
    {
        dynamic SpotPrice { get; set; }
    }

    public interface IHaveAdjustmentType : IResourceInterface
    {
        dynamic AdjustmentType { get; set; }
    }

    public interface IHaveOperation : IResourceInterface
    {
        dynamic Operation { get; set; }
    }

    public interface IHaveActionType : IResourceInterface
    {
        dynamic ActionType { get; set; }
    }

    public interface IHaveFrequency : IResourceInterface
    {
        dynamic Frequency { get; set; }
    }

    public interface IHaveTimeoutInMinutes : IResourceInterface
    {
        dynamic TimeoutInMinutes { get; set; }
    }

    public interface IHaveCloudWatchLogsLogGroupArn : IResourceInterface
    {
        dynamic CloudWatchLogsLogGroupArn { get; set; }
    }

    public interface IHaveOutputFormat : IResourceInterface
    {
        dynamic OutputFormat { get; set; }
    }

    public interface IHaveComputeType : IResourceInterface
    {
        dynamic ComputeType { get; set; }
    }

    public interface IHaveProviderType : IResourceInterface
    {
        dynamic ProviderType { get; set; }
    }

    public interface IHaveResourceName : IResourceInterface
    {
        dynamic ResourceName { get; set; }
    }

    public interface IHaveProviderName : IResourceInterface
    {
        dynamic ProviderName { get; set; }
    }

    public interface IHaveInputParameters : IResourceInterface
    {
        dynamic InputParameters { get; set; }
    }

    public interface IHaveTargetId : IResourceInterface
    {
        dynamic TargetId { get; set; }
    }

    public interface IHaveOrigin : IResourceInterface
    {
        dynamic Origin { get; set; }
    }

    public interface IHaveCountryCode : IResourceInterface
    {
        dynamic CountryCode { get; set; }
    }

    public interface IHaveFunction : IResourceInterface
    {
        dynamic Function { get; set; }
    }

    public interface IHaveContactFlowArn : IResourceInterface
    {
        dynamic ContactFlowArn { get; set; }
    }

    public interface IHaveTemplateId : IResourceInterface
    {
        dynamic TemplateId { get; set; }
    }

    public interface IHaveNodeType : IResourceInterface
    {
        dynamic NodeType { get; set; }
    }

    public interface IHaveCopyTags : IResourceInterface
    {
        dynamic CopyTags { get; set; }
    }

    public interface IHaveInstanceProfileName : IResourceInterface
    {
        dynamic InstanceProfileName { get; set; }
    }

    public interface IHaveAllocatedStorage : IResourceInterface
    {
        dynamic AllocatedStorage { get; set; }
    }

    public interface IHaveMultiAZ : IResourceInterface
    {
        dynamic MultiAZ { get; set; }
    }

    public interface IHaveEncryptionMode : IResourceInterface
    {
        dynamic EncryptionMode { get; set; }
    }

    public interface IHaveServerHostname : IResourceInterface
    {
        dynamic ServerHostname { get; set; }
    }

    public interface IHaveProjectIdentifier : IResourceInterface
    {
        dynamic ProjectIdentifier { get; set; }
    }

    public interface IHaveGroupIdentifier : IResourceInterface
    {
        dynamic GroupIdentifier { get; set; }
    }

    public interface IHaveSnapshotIdentifier : IResourceInterface
    {
        dynamic SnapshotIdentifier { get; set; }
    }

    public interface IHaveUseLatestRestorableTime : IResourceInterface
    {
        dynamic UseLatestRestorableTime { get; set; }
    }

    public interface IHaveDBClusterParameterGroupName : IResourceInterface
    {
        dynamic DBClusterParameterGroupName { get; set; }
    }

    public interface IHaveCopyTagsToSnapshot : IResourceInterface
    {
        dynamic CopyTagsToSnapshot { get; set; }
    }

    public interface IHaveEnableCloudwatchLogsExports : IResourceInterface
    {
        dynamic EnableCloudwatchLogsExports { get; set; }
    }

    public interface IHaveDBInstanceIdentifier : IResourceInterface
    {
        dynamic DBInstanceIdentifier { get; set; }
    }

    public interface IHaveLogFormat : IResourceInterface
    {
        dynamic LogFormat { get; set; }
    }

    public interface IHaveAssetId : IResourceInterface
    {
        dynamic AssetId { get; set; }
    }

    public interface IHaveRuleAction : IResourceInterface
    {
        dynamic RuleAction { get; set; }
    }

    public interface IHaveDeviceIndex : IResourceInterface
    {
        dynamic DeviceIndex { get; set; }
    }

    public interface IHaveCidrIp : IResourceInterface
    {
        dynamic CidrIp { get; set; }
    }

    public interface IHaveCidrIpv6 : IResourceInterface
    {
        dynamic CidrIpv6 { get; set; }
    }

    public interface IHaveIpProtocol : IResourceInterface
    {
        dynamic IpProtocol { get; set; }
    }

    public interface IHaveTransitGatewayAttachmentId : IResourceInterface
    {
        dynamic TransitGatewayAttachmentId { get; set; }
    }

    public interface IHaveRouteTableIds : IResourceInterface
    {
        dynamic RouteTableIds { get; set; }
    }

    public interface IHaveServiceId : IResourceInterface
    {
        dynamic ServiceId { get; set; }
    }

    public interface IHaveCluster : IResourceInterface
    {
        dynamic Cluster { get; set; }
    }

    public interface IHaveEnableECSManagedTags : IResourceInterface
    {
        dynamic EnableECSManagedTags { get; set; }
    }

    public interface IHaveEnableExecuteCommand : IResourceInterface
    {
        dynamic EnableExecuteCommand { get; set; }
    }

    public interface IHaveInstanceTypes : IResourceInterface
    {
        dynamic InstanceTypes { get; set; }
    }

    public interface IHaveListOfEMRClusterTypesConfigurationConfigurations : IResourceInterface
    {
        List<Humidifier.EMR.ClusterTypes.Configuration> Configurations { get; set; }
    }

    public interface IHaveSecurityConfiguration : IResourceInterface
    {
        dynamic SecurityConfiguration { get; set; }
    }

    public interface IHaveBidPrice : IResourceInterface
    {
        dynamic BidPrice { get; set; }
    }

    public interface IHaveMarket : IResourceInterface
    {
        dynamic Market { get; set; }
    }

    public interface IHaveStudioId : IResourceInterface
    {
        dynamic StudioId { get; set; }
    }

    public interface IHaveSnapshotName : IResourceInterface
    {
        dynamic SnapshotName { get; set; }
    }

    public interface IHaveSnapshotRetentionLimit : IResourceInterface
    {
        dynamic SnapshotRetentionLimit { get; set; }
    }

    public interface IHaveEC2SecurityGroupName : IResourceInterface
    {
        dynamic EC2SecurityGroupName { get; set; }
    }

    public interface IHaveEC2SecurityGroupOwnerId : IResourceInterface
    {
        dynamic EC2SecurityGroupOwnerId { get; set; }
    }

    public interface IHaveLoadBalancerName : IResourceInterface
    {
        dynamic LoadBalancerName { get; set; }
    }

    public interface IHaveProtocolVersion : IResourceInterface
    {
        dynamic ProtocolVersion { get; set; }
    }

    public interface IHaveTrustStoreArn : IResourceInterface
    {
        dynamic TrustStoreArn { get; set; }
    }

    public interface IHaveVariableType : IResourceInterface
    {
        dynamic VariableType { get; set; }
    }

    public interface IHaveCreationTime : IResourceInterface
    {
        dynamic CreationTime { get; set; }
    }

    public interface IHaveRuleSetName : IResourceInterface
    {
        dynamic RuleSetName { get; set; }
    }

    public interface IHaveDataFormat : IResourceInterface
    {
        dynamic DataFormat { get; set; }
    }

    public interface IHaveDatastoreName : IResourceInterface
    {
        dynamic DatastoreName { get; set; }
    }

    public interface IHaveManagedPolicyArns : IResourceInterface
    {
        dynamic ManagedPolicyArns { get; set; }
    }

    public interface IHaveRoles : IResourceInterface
    {
        dynamic Roles { get; set; }
    }

    public interface IHaveRoleName : IResourceInterface
    {
        dynamic RoleName { get; set; }
    }

    public interface IHaveCertificateMode : IResourceInterface
    {
        dynamic CertificateMode { get; set; }
    }

    public interface IHaveLambdaFunctionArn : IResourceInterface
    {
        dynamic LambdaFunctionArn { get; set; }
    }

    public interface IHaveStringValues : IResourceInterface
    {
        dynamic StringValues { get; set; }
    }

    public interface IHaveActionName : IResourceInterface
    {
        dynamic ActionName { get; set; }
    }

    public interface IHaveComponentTypeId : IResourceInterface
    {
        dynamic ComponentTypeId { get; set; }
    }

    public interface IHaveEntityName : IResourceInterface
    {
        dynamic EntityName { get; set; }
    }

    public interface IHaveDestinationName : IResourceInterface
    {
        dynamic DestinationName { get; set; }
    }

    public interface IHaveKeySpec : IResourceInterface
    {
        dynamic KeySpec { get; set; }
    }

    public interface IHaveScale : IResourceInterface
    {
        dynamic Scale { get; set; }
    }

    public interface IHavePricingPlan : IResourceInterface
    {
        dynamic PricingPlan { get; set; }
    }

    public interface IHaveBridgeArn : IResourceInterface
    {
        dynamic BridgeArn { get; set; }
    }

    public interface IHaveStreamId : IResourceInterface
    {
        dynamic StreamId { get; set; }
    }

    public interface IHaveQueue : IResourceInterface
    {
        dynamic Queue { get; set; }
    }

    public interface IHaveSourceLocationName : IResourceInterface
    {
        dynamic SourceLocationName { get; set; }
    }

    public interface IHaveCoreNetworkId : IResourceInterface
    {
        dynamic CoreNetworkId { get; set; }
    }

    public interface IHaveStackId : IResourceInterface
    {
        dynamic StackId { get; set; }
    }

    public interface IHaveTokenKey : IResourceInterface
    {
        dynamic TokenKey { get; set; }
    }

    public interface IHaveTokenKeyId : IResourceInterface
    {
        dynamic TokenKeyId { get; set; }
    }

    public interface IHaveCloudWatchMetricsEnabled : IResourceInterface
    {
        dynamic CloudWatchMetricsEnabled { get; set; }
    }

    public interface IHaveTemplateDescription : IResourceInterface
    {
        dynamic TemplateDescription { get; set; }
    }

    public interface IHaveDesiredState : IResourceInterface
    {
        dynamic DesiredState { get; set; }
    }

    public interface IHaveThemeArn : IResourceInterface
    {
        dynamic ThemeArn { get; set; }
    }

    public interface IHaveVpcSubnetIds : IResourceInterface
    {
        dynamic VpcSubnetIds { get; set; }
    }

    public interface IHaveWorkgroupName : IResourceInterface
    {
        dynamic WorkgroupName { get; set; }
    }

    public interface IHaveServiceIdentifier : IResourceInterface
    {
        dynamic ServiceIdentifier { get; set; }
    }

    public interface IHaveCollectionId : IResourceInterface
    {
        dynamic CollectionId { get; set; }
    }

    public interface IHaveCurrentRevisionId : IResourceInterface
    {
        dynamic CurrentRevisionId { get; set; }
    }

    public interface IHaveApplication : IResourceInterface
    {
        dynamic Application { get; set; }
    }

    public interface IHaveDurationSeconds : IResourceInterface
    {
        dynamic DurationSeconds { get; set; }
    }

    public interface IHaveScheduleOffset : IResourceInterface
    {
        dynamic ScheduleOffset { get; set; }
    }

    public interface IHaveContactId : IResourceInterface
    {
        dynamic ContactId { get; set; }
    }

    public interface IHaveDomainId : IResourceInterface
    {
        dynamic DomainId { get; set; }
    }

    public interface IHaveUserProfileName : IResourceInterface
    {
        dynamic UserProfileName { get; set; }
    }

    public interface IHaveAppImageConfigName : IResourceInterface
    {
        dynamic AppImageConfigName { get; set; }
    }

    public interface IHaveAliases : IResourceInterface
    {
        dynamic Aliases { get; set; }
    }

    public interface IHaveConfigurationType : IResourceInterface
    {
        dynamic ConfigurationType { get; set; }
    }

    public interface IHaveSourceName : IResourceInterface
    {
        dynamic SourceName { get; set; }
    }

    public interface IHaveCustomerManagedKey : IResourceInterface
    {
        dynamic CustomerManagedKey { get; set; }
    }

    public interface IHaveKeyAgreement : IResourceInterface
    {
        dynamic KeyAgreement { get; set; }
    }

    public interface IHaveEq : IResourceInterface
    {
        dynamic Eq { get; set; }
    }

    public interface IHaveSlotName : IResourceInterface
    {
        dynamic SlotName { get; set; }
    }

    public interface IHaveResourcePath : IResourceInterface
    {
        dynamic ResourcePath { get; set; }
    }

    public interface IHaveIdFieldNames : IResourceInterface
    {
        dynamic IdFieldNames { get; set; }
    }

    public interface IHaveWriteOperationType : IResourceInterface
    {
        dynamic WriteOperationType { get; set; }
    }

    public interface IHaveInvert : IResourceInterface
    {
        dynamic Invert { get; set; }
    }

    public interface IHaveMaxRequests : IResourceInterface
    {
        dynamic MaxRequests { get; set; }
    }

    public interface IHaveScaleOutCooldown : IResourceInterface
    {
        dynamic ScaleOutCooldown { get; set; }
    }

    public interface IHaveScaleInCooldown : IResourceInterface
    {
        dynamic ScaleInCooldown { get; set; }
    }

    public interface IHaveEmailAddress : IResourceInterface
    {
        dynamic EmailAddress { get; set; }
    }

    public interface IHaveLocalStorageTypes : IResourceInterface
    {
        dynamic LocalStorageTypes { get; set; }
    }

    public interface IHaveInstanceGenerations : IResourceInterface
    {
        dynamic InstanceGenerations { get; set; }
    }

    public interface IHaveAcceleratorManufacturers : IResourceInterface
    {
        dynamic AcceleratorManufacturers { get; set; }
    }

    public interface IHaveLocalStorage : IResourceInterface
    {
        dynamic LocalStorage { get; set; }
    }

    public interface IHaveCpuManufacturers : IResourceInterface
    {
        dynamic CpuManufacturers { get; set; }
    }

    public interface IHaveBareMetal : IResourceInterface
    {
        dynamic BareMetal { get; set; }
    }

    public interface IHaveRequireHibernateSupport : IResourceInterface
    {
        dynamic RequireHibernateSupport { get; set; }
    }

    public interface IHaveMaxSpotPriceAsPercentageOfOptimalOnDemandPrice : IResourceInterface
    {
        dynamic MaxSpotPriceAsPercentageOfOptimalOnDemandPrice { get; set; }
    }

    public interface IHaveSpotMaxPricePercentageOverLowestPrice : IResourceInterface
    {
        dynamic SpotMaxPricePercentageOverLowestPrice { get; set; }
    }

    public interface IHaveAcceleratorNames : IResourceInterface
    {
        dynamic AcceleratorNames { get; set; }
    }

    public interface IHaveOnDemandMaxPricePercentageOverLowestPrice : IResourceInterface
    {
        dynamic OnDemandMaxPricePercentageOverLowestPrice { get; set; }
    }

    public interface IHaveBurstablePerformance : IResourceInterface
    {
        dynamic BurstablePerformance { get; set; }
    }

    public interface IHavePrivileged : IResourceInterface
    {
        dynamic Privileged { get; set; }
    }

    public interface IHaveSizeInGiB : IResourceInterface
    {
        dynamic SizeInGiB { get; set; }
    }

    public interface IHaveTextField : IResourceInterface
    {
        dynamic TextField { get; set; }
    }

    public interface IHaveMetadataField : IResourceInterface
    {
        dynamic MetadataField { get; set; }
    }

    public interface IHaveAmount : IResourceInterface
    {
        dynamic Amount { get; set; }
    }

    public interface IHaveReadCapacityUnits : IResourceInterface
    {
        dynamic ReadCapacityUnits { get; set; }
    }

    public interface IHaveKeyPrefix : IResourceInterface
    {
        dynamic KeyPrefix { get; set; }
    }

    public interface IHaveDefaultTTL : IResourceInterface
    {
        dynamic DefaultTTL { get; set; }
    }

    public interface IHaveAllowedMethods : IResourceInterface
    {
        dynamic AllowedMethods { get; set; }
    }

    public interface IHaveDNSName : IResourceInterface
    {
        dynamic DNSName { get; set; }
    }

    public interface IHaveAttributeMatchingModel : IResourceInterface
    {
        dynamic AttributeMatchingModel { get; set; }
    }

    public interface IHaveAfterConnectScript : IResourceInterface
    {
        dynamic AfterConnectScript { get; set; }
    }

    public interface IHaveCompressionType : IResourceInterface
    {
        dynamic CompressionType { get; set; }
    }

    public interface IHaveStepCount : IResourceInterface
    {
        dynamic StepCount { get; set; }
    }

    public interface IHaveStartValue : IResourceInterface
    {
        dynamic StartValue { get; set; }
    }

    public interface IHaveFilterType : IResourceInterface
    {
        dynamic FilterType { get; set; }
    }

    public interface IHaveGroup : IResourceInterface
    {
        dynamic Group { get; set; }
    }

    public interface IHaveIpv6Address : IResourceInterface
    {
        dynamic Ipv6Address { get; set; }
    }

    public interface IHavePrimary : IResourceInterface
    {
        dynamic Primary { get; set; }
    }

    public interface IHaveAuthorizationEndpoint : IResourceInterface
    {
        dynamic AuthorizationEndpoint { get; set; }
    }

    public interface IHaveOnUnauthenticatedRequest : IResourceInterface
    {
        dynamic OnUnauthenticatedRequest { get; set; }
    }

    public interface IHaveSessionCookieName : IResourceInterface
    {
        dynamic SessionCookieName { get; set; }
    }

    public interface IHaveDynDicOfAuthenticationRequestExtraParams : IResourceInterface
    {
        Dictionary<string, dynamic> AuthenticationRequestExtraParams { get; set; }
    }

    public interface IHaveSubType : IResourceInterface
    {
        dynamic SubType { get; set; }
    }

    public interface IHaveWeeklyMaintenanceStartTime : IResourceInterface
    {
        dynamic WeeklyMaintenanceStartTime { get; set; }
    }

    public interface IHaveDailyAutomaticBackupStartTime : IResourceInterface
    {
        dynamic DailyAutomaticBackupStartTime { get; set; }
    }

    public interface IHaveCopyTagsToBackups : IResourceInterface
    {
        dynamic CopyTagsToBackups { get; set; }
    }

    public interface IHaveAutomaticBackupRetentionDays : IResourceInterface
    {
        dynamic AutomaticBackupRetentionDays { get; set; }
    }

    public interface IHaveDataLakePrincipalIdentifier : IResourceInterface
    {
        dynamic DataLakePrincipalIdentifier { get; set; }
    }

    public interface IHaveVersionNumber : IResourceInterface
    {
        dynamic VersionNumber { get; set; }
    }

    public interface IHaveSyncShadow : IResourceInterface
    {
        dynamic SyncShadow { get; set; }
    }

    public interface IHaveGroupOwner : IResourceInterface
    {
        dynamic GroupOwner { get; set; }
    }

    public interface IHaveDimensionName : IResourceInterface
    {
        dynamic DimensionName { get; set; }
    }

    public interface IHaveBatchMode : IResourceInterface
    {
        dynamic BatchMode { get; set; }
    }

    public interface IHavePropertyId : IResourceInterface
    {
        dynamic PropertyId { get; set; }
    }

    public interface IHaveCannedAcl : IResourceInterface
    {
        dynamic CannedAcl { get; set; }
    }

    public interface IHaveUnlimited : IResourceInterface
    {
        dynamic Unlimited { get; set; }
    }

    public interface IHaveAllowedValues : IResourceInterface
    {
        dynamic AllowedValues { get; set; }
    }

    public interface IHaveid : IResourceInterface
    {
        dynamic id { get; set; }
    }

    public interface IHaveLogicalId : IResourceInterface
    {
        dynamic LogicalId { get; set; }
    }

    public interface IHaveRfRegion : IResourceInterface
    {
        dynamic RfRegion { get; set; }
    }

    public interface IHaveFileKey : IResourceInterface
    {
        dynamic FileKey { get; set; }
    }

    public interface IHaveRecordRowDelimiter : IResourceInterface
    {
        dynamic RecordRowDelimiter { get; set; }
    }

    public interface IHaveRecordColumnDelimiter : IResourceInterface
    {
        dynamic RecordColumnDelimiter { get; set; }
    }

    public interface IHaveRecordEncoding : IResourceInterface
    {
        dynamic RecordEncoding { get; set; }
    }

    public interface IHaveRecordRowPath : IResourceInterface
    {
        dynamic RecordRowPath { get; set; }
    }

    public interface IHaveMapping : IResourceInterface
    {
        dynamic Mapping { get; set; }
    }

    public interface IHaveSqlType : IResourceInterface
    {
        dynamic SqlType { get; set; }
    }

    public interface IHaveKinesisFirehoseDeliveryStreamTypesBufferingHintsBufferingHints : IResourceInterface
    {
        Humidifier.KinesisFirehose.DeliveryStreamTypes.BufferingHints BufferingHints { get; set; }
    }

    public interface IHaveKinesisFirehoseDeliveryStreamTypesSecretsManagerConfigurationSecretsManagerConfiguration : IResourceInterface
    {
        Humidifier.KinesisFirehose.DeliveryStreamTypes.SecretsManagerConfiguration SecretsManagerConfiguration { get; set; }
    }

    public interface IHaveLogPrefix : IResourceInterface
    {
        dynamic LogPrefix { get; set; }
    }

    public interface IHaveLexBotTypesDialogStateNextStep : IResourceInterface
    {
        Humidifier.Lex.BotTypes.DialogState NextStep { get; set; }
    }

    public interface IHaveLexBotTypesConditionalSpecificationFailureConditional : IResourceInterface
    {
        Humidifier.Lex.BotTypes.ConditionalSpecification FailureConditional { get; set; }
    }

    public interface IHaveLexBotTypesResponseSpecificationFailureResponse : IResourceInterface
    {
        Humidifier.Lex.BotTypes.ResponseSpecification FailureResponse { get; set; }
    }

    public interface IHaveLexBotTypesDialogStateFailureNextStep : IResourceInterface
    {
        Humidifier.Lex.BotTypes.DialogState FailureNextStep { get; set; }
    }

    public interface IHaveShape : IResourceInterface
    {
        dynamic Shape { get; set; }
    }

    public interface IHaveStyle : IResourceInterface
    {
        dynamic Style { get; set; }
    }

    public interface IHaveNielsenId3Behavior : IResourceInterface
    {
        dynamic NielsenId3Behavior { get; set; }
    }

    public interface IHavePasswordParam : IResourceInterface
    {
        dynamic PasswordParam { get; set; }
    }

    public interface IHaveMediaLiveChannelTypesTimecodeBurninSettingsTimecodeBurninSettings : IResourceInterface
    {
        Humidifier.MediaLive.ChannelTypes.TimecodeBurninSettings TimecodeBurninSettings { get; set; }
    }

    public interface IHaveInputLossAction : IResourceInterface
    {
        dynamic InputLossAction { get; set; }
    }

    public interface IHaveScte35Pid : IResourceInterface
    {
        dynamic Scte35Pid { get; set; }
    }

    public interface IHavePageNumber : IResourceInterface
    {
        dynamic PageNumber { get; set; }
    }

    public interface IHaveKeyRotationIntervalSeconds : IResourceInterface
    {
        dynamic KeyRotationIntervalSeconds { get; set; }
    }

    public interface IHaveMediaPackageOriginEndpointTypesSpekeKeyProviderSpekeKeyProvider : IResourceInterface
    {
        Humidifier.MediaPackage.OriginEndpointTypes.SpekeKeyProvider SpekeKeyProvider { get; set; }
    }

    public interface IHaveMediaPackageOriginEndpointTypesStreamSelectionStreamSelection : IResourceInterface
    {
        Humidifier.MediaPackage.OriginEndpointTypes.StreamSelection StreamSelection { get; set; }
    }

    public interface IHaveMinBufferTimeSeconds : IResourceInterface
    {
        dynamic MinBufferTimeSeconds { get; set; }
    }

    public interface IHaveMediaPackagePackagingConfigurationTypesSpekeKeyProviderSpekeKeyProvider : IResourceInterface
    {
        Humidifier.MediaPackage.PackagingConfigurationTypes.SpekeKeyProvider SpekeKeyProvider { get; set; }
    }

    public interface IHaveFeatureName : IResourceInterface
    {
        dynamic FeatureName { get; set; }
    }

    public interface IHaveButtonAction : IResourceInterface
    {
        dynamic ButtonAction { get; set; }
    }

    public interface IHaveLink : IResourceInterface
    {
        dynamic Link { get; set; }
    }

    public interface IHaveMeasureValueType : IResourceInterface
    {
        dynamic MeasureValueType { get; set; }
    }

    public interface IHaveQuickSightAnalysisTypesAggregationFunctionAggregationFunction : IResourceInterface
    {
        Humidifier.QuickSight.AnalysisTypes.AggregationFunction AggregationFunction { get; set; }
    }

    public interface IHaveListOfQuickSightAnalysisTypesDimensionFieldColors : IResourceInterface
    {
        List<Humidifier.QuickSight.AnalysisTypes.DimensionField> Colors { get; set; }
    }

    public interface IHaveListOfQuickSightAnalysisTypesReferenceLineReferenceLines : IResourceInterface
    {
        List<Humidifier.QuickSight.AnalysisTypes.ReferenceLine> ReferenceLines { get; set; }
    }

    public interface IHaveQuickSightAnalysisTypesChartAxisLabelOptionsColorLabelOptions : IResourceInterface
    {
        Humidifier.QuickSight.AnalysisTypes.ChartAxisLabelOptions ColorLabelOptions { get; set; }
    }

    public interface IHaveQuickSightAnalysisTypesAxisDisplayOptionsCategoryAxis : IResourceInterface
    {
        Humidifier.QuickSight.AnalysisTypes.AxisDisplayOptions CategoryAxis { get; set; }
    }

    public interface IHaveQuickSightAnalysisTypesChartAxisLabelOptionsPrimaryYAxisLabelOptions : IResourceInterface
    {
        Humidifier.QuickSight.AnalysisTypes.ChartAxisLabelOptions PrimaryYAxisLabelOptions { get; set; }
    }

    public interface IHaveQuickSightAnalysisTypesDynamicDefaultValueDynamicValue : IResourceInterface
    {
        Humidifier.QuickSight.AnalysisTypes.DynamicDefaultValue DynamicValue { get; set; }
    }

    public interface IHaveListOfQuickSightAnalysisTypesMappedDataSetParameterMappedDataSetParameters : IResourceInterface
    {
        List<Humidifier.QuickSight.AnalysisTypes.MappedDataSetParameter> MappedDataSetParameters { get; set; }
    }

    public interface IHaveDoubleListOfValues : IResourceInterface
    {
        List<double> Values { get; set; }
    }

    public interface IHaveQuickSightAnalysisTypesFilterSelectableValuesSelectableValues : IResourceInterface
    {
        Humidifier.QuickSight.AnalysisTypes.FilterSelectableValues SelectableValues { get; set; }
    }

    public interface IHaveDecimalSeparator : IResourceInterface
    {
        dynamic DecimalSeparator { get; set; }
    }

    public interface IHaveLeft : IResourceInterface
    {
        dynamic Left { get; set; }
    }

    public interface IHaveTop : IResourceInterface
    {
        dynamic Top { get; set; }
    }

    public interface IHaveQuickSightDashboardTypesAggregationFunctionAggregationFunction : IResourceInterface
    {
        Humidifier.QuickSight.DashboardTypes.AggregationFunction AggregationFunction { get; set; }
    }

    public interface IHaveListOfQuickSightDashboardTypesDimensionFieldColors : IResourceInterface
    {
        List<Humidifier.QuickSight.DashboardTypes.DimensionField> Colors { get; set; }
    }

    public interface IHaveListOfQuickSightDashboardTypesReferenceLineReferenceLines : IResourceInterface
    {
        List<Humidifier.QuickSight.DashboardTypes.ReferenceLine> ReferenceLines { get; set; }
    }

    public interface IHaveQuickSightDashboardTypesChartAxisLabelOptionsColorLabelOptions : IResourceInterface
    {
        Humidifier.QuickSight.DashboardTypes.ChartAxisLabelOptions ColorLabelOptions { get; set; }
    }

    public interface IHaveQuickSightDashboardTypesAxisDisplayOptionsCategoryAxis : IResourceInterface
    {
        Humidifier.QuickSight.DashboardTypes.AxisDisplayOptions CategoryAxis { get; set; }
    }

    public interface IHaveQuickSightDashboardTypesChartAxisLabelOptionsPrimaryYAxisLabelOptions : IResourceInterface
    {
        Humidifier.QuickSight.DashboardTypes.ChartAxisLabelOptions PrimaryYAxisLabelOptions { get; set; }
    }

    public interface IHaveQuickSightDashboardTypesDynamicDefaultValueDynamicValue : IResourceInterface
    {
        Humidifier.QuickSight.DashboardTypes.DynamicDefaultValue DynamicValue { get; set; }
    }

    public interface IHaveListOfQuickSightDashboardTypesMappedDataSetParameterMappedDataSetParameters : IResourceInterface
    {
        List<Humidifier.QuickSight.DashboardTypes.MappedDataSetParameter> MappedDataSetParameters { get; set; }
    }

    public interface IHaveQuickSightDashboardTypesFilterSelectableValuesSelectableValues : IResourceInterface
    {
        Humidifier.QuickSight.DashboardTypes.FilterSelectableValues SelectableValues { get; set; }
    }

    public interface IHaveQuickSightTemplateTypesAggregationFunctionAggregationFunction : IResourceInterface
    {
        Humidifier.QuickSight.TemplateTypes.AggregationFunction AggregationFunction { get; set; }
    }

    public interface IHaveListOfQuickSightTemplateTypesDimensionFieldColors : IResourceInterface
    {
        List<Humidifier.QuickSight.TemplateTypes.DimensionField> Colors { get; set; }
    }

    public interface IHaveListOfQuickSightTemplateTypesReferenceLineReferenceLines : IResourceInterface
    {
        List<Humidifier.QuickSight.TemplateTypes.ReferenceLine> ReferenceLines { get; set; }
    }

    public interface IHaveQuickSightTemplateTypesChartAxisLabelOptionsColorLabelOptions : IResourceInterface
    {
        Humidifier.QuickSight.TemplateTypes.ChartAxisLabelOptions ColorLabelOptions { get; set; }
    }

    public interface IHaveQuickSightTemplateTypesAxisDisplayOptionsCategoryAxis : IResourceInterface
    {
        Humidifier.QuickSight.TemplateTypes.AxisDisplayOptions CategoryAxis { get; set; }
    }

    public interface IHaveQuickSightTemplateTypesChartAxisLabelOptionsPrimaryYAxisLabelOptions : IResourceInterface
    {
        Humidifier.QuickSight.TemplateTypes.ChartAxisLabelOptions PrimaryYAxisLabelOptions { get; set; }
    }

    public interface IHaveQuickSightTemplateTypesDynamicDefaultValueDynamicValue : IResourceInterface
    {
        Humidifier.QuickSight.TemplateTypes.DynamicDefaultValue DynamicValue { get; set; }
    }

    public interface IHaveListOfQuickSightTemplateTypesMappedDataSetParameterMappedDataSetParameters : IResourceInterface
    {
        List<Humidifier.QuickSight.TemplateTypes.MappedDataSetParameter> MappedDataSetParameters { get; set; }
    }

    public interface IHaveQuickSightTemplateTypesFilterSelectableValuesSelectableValues : IResourceInterface
    {
        Humidifier.QuickSight.TemplateTypes.FilterSelectableValues SelectableValues { get; set; }
    }

    public interface IHaveObjectKeyPrefix : IResourceInterface
    {
        dynamic ObjectKeyPrefix { get; set; }
    }

    public interface IHaveRestrictPublicBuckets : IResourceInterface
    {
        dynamic RestrictPublicBuckets { get; set; }
    }

    public interface IHaveBlockPublicAcls : IResourceInterface
    {
        dynamic BlockPublicAcls { get; set; }
    }

    public interface IHaveIgnorePublicAcls : IResourceInterface
    {
        dynamic IgnorePublicAcls { get; set; }
    }

    public interface IHaveStorageClass : IResourceInterface
    {
        dynamic StorageClass { get; set; }
    }

    public interface IHaveLifecycleConfigArn : IResourceInterface
    {
        dynamic LifecycleConfigArn { get; set; }
    }

    public interface IHaveSageMakerImageArn : IResourceInterface
    {
        dynamic SageMakerImageArn { get; set; }
    }

    public interface IHaveSageMakerImageVersionArn : IResourceInterface
    {
        dynamic SageMakerImageVersionArn { get; set; }
    }

    public interface IHaveContainerEntrypoint : IResourceInterface
    {
        dynamic ContainerEntrypoint { get; set; }
    }

    public interface IHaveContainerArguments : IResourceInterface
    {
        dynamic ContainerArguments { get; set; }
    }

    public interface IHaveExcludeFeaturesAttribute : IResourceInterface
    {
        dynamic ExcludeFeaturesAttribute { get; set; }
    }

    public interface IHaveBaseliningJobName : IResourceInterface
    {
        dynamic BaseliningJobName { get; set; }
    }

    public interface IHaveListOfSageMakerDomainTypesCustomImageCustomImages : IResourceInterface
    {
        List<Humidifier.SageMaker.DomainTypes.CustomImage> CustomImages { get; set; }
    }

    public interface IHaveS3OutputPath : IResourceInterface
    {
        dynamic S3OutputPath { get; set; }
    }

    public interface IHaveStartTimeOffset : IResourceInterface
    {
        dynamic StartTimeOffset { get; set; }
    }

    public interface IHaveEndTimeOffset : IResourceInterface
    {
        dynamic EndTimeOffset { get; set; }
    }

    public interface IHaveProbabilityThresholdAttribute : IResourceInterface
    {
        dynamic ProbabilityThresholdAttribute { get; set; }
    }

    public interface IHaveSageMakerModelPackageTypesMetricsSourceStatistics : IResourceInterface
    {
        Humidifier.SageMaker.ModelPackageTypes.MetricsSource Statistics { get; set; }
    }

    public interface IHaveSageMakerSpaceTypesResourceSpecDefaultResourceSpec : IResourceInterface
    {
        Humidifier.SageMaker.SpaceTypes.ResourceSpec DefaultResourceSpec { get; set; }
    }

    public interface IHaveSageMakerUserProfileTypesResourceSpecDefaultResourceSpec : IResourceInterface
    {
        Humidifier.SageMaker.UserProfileTypes.ResourceSpec DefaultResourceSpec { get; set; }
    }

    public interface IHavePositionalConstraint : IResourceInterface
    {
        dynamic PositionalConstraint { get; set; }
    }

    public interface IHaveWAFv2RuleGroupTypesCustomRequestHandlingCustomRequestHandling : IResourceInterface
    {
        Humidifier.WAFv2.RuleGroupTypes.CustomRequestHandling CustomRequestHandling { get; set; }
    }

    public interface IHaveWAFv2WebACLTypesCustomRequestHandlingCustomRequestHandling : IResourceInterface
    {
        Humidifier.WAFv2.WebACLTypes.CustomRequestHandling CustomRequestHandling { get; set; }
    }

    public interface IHaveSigningAlgorithm : IResourceInterface
    {
        dynamic SigningAlgorithm { get; set; }
    }

    public interface IHaveKeyAlgorithm : IResourceInterface
    {
        dynamic KeyAlgorithm { get; set; }
    }

    public interface IHaveBranchName : IResourceInterface
    {
        dynamic BranchName { get; set; }
    }

    public interface IHaveIdentityValidationExpression : IResourceInterface
    {
        dynamic IdentityValidationExpression { get; set; }
    }

    public interface IHaveAuthorizerUri : IResourceInterface
    {
        dynamic AuthorizerUri { get; set; }
    }

    public interface IHaveAuthorizerResultTtlInSeconds : IResourceInterface
    {
        dynamic AuthorizerResultTtlInSeconds { get; set; }
    }

    public interface IHaveBasePath : IResourceInterface
    {
        dynamic BasePath { get; set; }
    }

    public interface IHaveDomainName_ : IResourceInterface
    {
        dynamic DomainName_ { get; set; }
    }

    public interface IHaveSecurityPolicy : IResourceInterface
    {
        dynamic SecurityPolicy { get; set; }
    }

    public interface IHaveDynDicOfResponseParameters : IResourceInterface
    {
        Dictionary<string, dynamic> ResponseParameters { get; set; }
    }

    public interface IHaveAuthorizationScopes : IResourceInterface
    {
        dynamic AuthorizationScopes { get; set; }
    }

    public interface IHaveAuthorizerId : IResourceInterface
    {
        dynamic AuthorizerId { get; set; }
    }

    public interface IHaveDeploymentId : IResourceInterface
    {
        dynamic DeploymentId { get; set; }
    }

    public interface IHaveClientCertificateId : IResourceInterface
    {
        dynamic ClientCertificateId { get; set; }
    }

    public interface IHaveDynDicOfVariables : IResourceInterface
    {
        Dictionary<string, dynamic> Variables { get; set; }
    }

    public interface IHaveTimeoutInMillis : IResourceInterface
    {
        dynamic TimeoutInMillis { get; set; }
    }

    public interface IHaveEnvironmentId : IResourceInterface
    {
        dynamic EnvironmentId { get; set; }
    }

    public interface IHaveFlowName : IResourceInterface
    {
        dynamic FlowName { get; set; }
    }

    public interface IHaveVirtualRouterName : IResourceInterface
    {
        dynamic VirtualRouterName { get; set; }
    }

    public interface IHaveVirtualServiceName : IResourceInterface
    {
        dynamic VirtualServiceName { get; set; }
    }

    public interface IHaveEnableDefaultInternetAccess : IResourceInterface
    {
        dynamic EnableDefaultInternetAccess { get; set; }
    }

    public interface IHaveApplicationIdentifier : IResourceInterface
    {
        dynamic ApplicationIdentifier { get; set; }
    }

    public interface IHaveDirectoryName : IResourceInterface
    {
        dynamic DirectoryName { get; set; }
    }

    public interface IHaveTransitEncryptionEnabled : IResourceInterface
    {
        dynamic TransitEncryptionEnabled { get; set; }
    }

    public interface IHaveFunctionVersion : IResourceInterface
    {
        dynamic FunctionVersion { get; set; }
    }

    public interface IHaveFieldName : IResourceInterface
    {
        dynamic FieldName { get; set; }
    }

    public interface IHaveServiceNamespace : IResourceInterface
    {
        dynamic ServiceNamespace { get; set; }
    }

    public interface IHaveScalableDimension : IResourceInterface
    {
        dynamic ScalableDimension { get; set; }
    }

    public interface IHaveWorkGroup : IResourceInterface
    {
        dynamic WorkGroup { get; set; }
    }

    public interface IHaveStatementName : IResourceInterface
    {
        dynamic StatementName { get; set; }
    }

    public interface IHaveCooldown : IResourceInterface
    {
        dynamic Cooldown { get; set; }
    }

    public interface IHaveDesiredCapacity : IResourceInterface
    {
        dynamic DesiredCapacity { get; set; }
    }

    public interface IHaveEstimatedInstanceWarmup : IResourceInterface
    {
        dynamic EstimatedInstanceWarmup { get; set; }
    }

    public interface IHaveProfileId : IResourceInterface
    {
        dynamic ProfileId { get; set; }
    }

    public interface IHaveCapabilities : IResourceInterface
    {
        dynamic Capabilities { get; set; }
    }

    public interface IHaveFileFormat : IResourceInterface
    {
        dynamic FileFormat { get; set; }
    }

    public interface IHaveScheduleExpressionTimezone : IResourceInterface
    {
        dynamic ScheduleExpressionTimezone { get; set; }
    }

    public interface IHaveCustomerEncryptionKeyArn : IResourceInterface
    {
        dynamic CustomerEncryptionKeyArn { get; set; }
    }

    public interface IHavePromptArn : IResourceInterface
    {
        dynamic PromptArn { get; set; }
    }

    public interface IHaveNotificationType : IResourceInterface
    {
        dynamic NotificationType { get; set; }
    }

    public interface IHavePointInTimeRecoveryEnabled : IResourceInterface
    {
        dynamic PointInTimeRecoveryEnabled { get; set; }
    }

    public interface IHaveSamplingRate : IResourceInterface
    {
        dynamic SamplingRate { get; set; }
    }

    public interface IHaveBillingMode : IResourceInterface
    {
        dynamic BillingMode { get; set; }
    }

    public interface IHaveKMSKeyId : IResourceInterface
    {
        dynamic KMSKeyId { get; set; }
    }

    public interface IHaveTreatMissingData : IResourceInterface
    {
        dynamic TreatMissingData { get; set; }
    }

    public interface IHaveDatapointsToAlarm : IResourceInterface
    {
        dynamic DatapointsToAlarm { get; set; }
    }

    public interface IHaveListOfCloudWatchAnomalyDetectorTypesDimensionDimensions : IResourceInterface
    {
        List<Humidifier.CloudWatch.AnomalyDetectorTypes.Dimension> Dimensions { get; set; }
    }

    public interface IHaveBaseCapacity : IResourceInterface
    {
        dynamic BaseCapacity { get; set; }
    }

    public interface IHaveRepositoryDescription : IResourceInterface
    {
        dynamic RepositoryDescription { get; set; }
    }

    public interface IHaveComputePlatform : IResourceInterface
    {
        dynamic ComputePlatform { get; set; }
    }

    public interface IHaveBranch : IResourceInterface
    {
        dynamic Branch { get; set; }
    }

    public interface IHaveDetailType : IResourceInterface
    {
        dynamic DetailType { get; set; }
    }

    public interface IHaveVersionName : IResourceInterface
    {
        dynamic VersionName { get; set; }
    }

    public interface IHaveManifest : IResourceInterface
    {
        dynamic Manifest { get; set; }
    }

    public interface IHaveAllowMajorVersionUpgrade : IResourceInterface
    {
        dynamic AllowMajorVersionUpgrade { get; set; }
    }

    public interface IHaveActivate : IResourceInterface
    {
        dynamic Activate { get; set; }
    }

    public interface IHaveFsxFilesystemArn : IResourceInterface
    {
        dynamic FsxFilesystemArn { get; set; }
    }

    public interface IHaveSecretKey : IResourceInterface
    {
        dynamic SecretKey { get; set; }
    }

    public interface IHaveServerPort : IResourceInterface
    {
        dynamic ServerPort { get; set; }
    }

    public interface IHaveOsFamily : IResourceInterface
    {
        dynamic OsFamily { get; set; }
    }

    public interface IHaveMemberId : IResourceInterface
    {
        dynamic MemberId { get; set; }
    }

    public interface IHaveEdition : IResourceInterface
    {
        dynamic Edition { get; set; }
    }

    public interface IHaveRestoreToTime : IResourceInterface
    {
        dynamic RestoreToTime { get; set; }
    }

    public interface IHaveRestoreType : IResourceInterface
    {
        dynamic RestoreType { get; set; }
    }

    public interface IHaveDBInstanceClass : IResourceInterface
    {
        dynamic DBInstanceClass { get; set; }
    }

    public interface IHaveDBSubnetGroupDescription : IResourceInterface
    {
        dynamic DBSubnetGroupDescription { get; set; }
    }

    public interface IHaveListOfDynamoDBGlobalTableTypesKeySchemaKeySchema : IResourceInterface
    {
        List<Humidifier.DynamoDB.GlobalTableTypes.KeySchema> KeySchema { get; set; }
    }

    public interface IHaveListOfDynamoDBTableTypesKeySchemaKeySchema : IResourceInterface
    {
        List<Humidifier.DynamoDB.TableTypes.KeySchema> KeySchema { get; set; }
    }

    public interface IHaveClientVpnEndpointId : IResourceInterface
    {
        dynamic ClientVpnEndpointId { get; set; }
    }

    public interface IHaveValidUntil : IResourceInterface
    {
        dynamic ValidUntil { get; set; }
    }

    public interface IHaveAllocationId : IResourceInterface
    {
        dynamic AllocationId { get; set; }
    }

    public interface IHaveLogDestinationType : IResourceInterface
    {
        dynamic LogDestinationType { get; set; }
    }

    public interface IHaveRouteTableId : IResourceInterface
    {
        dynamic RouteTableId { get; set; }
    }

    public interface IHaveHostId : IResourceInterface
    {
        dynamic HostId { get; set; }
    }

    public interface IHaveHostResourceGroupArn : IResourceInterface
    {
        dynamic HostResourceGroupArn { get; set; }
    }

    public interface IHaveAffinity : IResourceInterface
    {
        dynamic Affinity { get; set; }
    }

    public interface IHavePublicKeyMaterial : IResourceInterface
    {
        dynamic PublicKeyMaterial { get; set; }
    }

    public interface IHaveLocalGatewayRouteTableId : IResourceInterface
    {
        dynamic LocalGatewayRouteTableId { get; set; }
    }

    public interface IHaveEgress : IResourceInterface
    {
        dynamic Egress { get; set; }
    }

    public interface IHaveRuleNumber : IResourceInterface
    {
        dynamic RuleNumber { get; set; }
    }

    public interface IHaveDestinationPort : IResourceInterface
    {
        dynamic DestinationPort { get; set; }
    }

    public interface IHaveMetric : IResourceInterface
    {
        dynamic Metric { get; set; }
    }

    public interface IHaveDestinationPrefixListId : IResourceInterface
    {
        dynamic DestinationPrefixListId { get; set; }
    }

    public interface IHaveIpv6NetmaskLength : IResourceInterface
    {
        dynamic Ipv6NetmaskLength { get; set; }
    }

    public interface IHaveIpv6IpamPoolId : IResourceInterface
    {
        dynamic Ipv6IpamPoolId { get; set; }
    }

    public interface IHaveIpv4NetmaskLength : IResourceInterface
    {
        dynamic Ipv4NetmaskLength { get; set; }
    }

    public interface IHaveIpv4IpamPoolId : IResourceInterface
    {
        dynamic Ipv4IpamPoolId { get; set; }
    }

    public interface IHaveDnsSupport : IResourceInterface
    {
        dynamic DnsSupport { get; set; }
    }

    public interface IHaveTransitGatewayMulticastDomainId : IResourceInterface
    {
        dynamic TransitGatewayMulticastDomainId { get; set; }
    }

    public interface IHaveTransitGatewayRouteTableId : IResourceInterface
    {
        dynamic TransitGatewayRouteTableId { get; set; }
    }

    public interface IHaveVpnGatewayId : IResourceInterface
    {
        dynamic VpnGatewayId { get; set; }
    }

    public interface IHaveVolumeId : IResourceInterface
    {
        dynamic VolumeId { get; set; }
    }

    public interface IHavePolicyText : IResourceInterface
    {
        dynamic PolicyText { get; set; }
    }

    public interface IHaveTaskRoleArn : IResourceInterface
    {
        dynamic TaskRoleArn { get; set; }
    }

    public interface IHaveLogUri : IResourceInterface
    {
        dynamic LogUri { get; set; }
    }

    public interface IHaveClusterId : IResourceInterface
    {
        dynamic ClusterId { get; set; }
    }

    public interface IHaveInstanceRole : IResourceInterface
    {
        dynamic InstanceRole { get; set; }
    }

    public interface IHaveCacheNodeType : IResourceInterface
    {
        dynamic CacheNodeType { get; set; }
    }

    public interface IHaveCacheParameterGroupName : IResourceInterface
    {
        dynamic CacheParameterGroupName { get; set; }
    }

    public interface IHaveCacheSubnetGroupName : IResourceInterface
    {
        dynamic CacheSubnetGroupName { get; set; }
    }

    public interface IHaveNotificationTopicArn : IResourceInterface
    {
        dynamic NotificationTopicArn { get; set; }
    }

    public interface IHaveSnapshotArns : IResourceInterface
    {
        dynamic SnapshotArns { get; set; }
    }

    public interface IHaveSnapshotWindow : IResourceInterface
    {
        dynamic SnapshotWindow { get; set; }
    }

    public interface IHaveReplicationGroupId : IResourceInterface
    {
        dynamic ReplicationGroupId { get; set; }
    }

    public interface IHaveFinalSnapshotName : IResourceInterface
    {
        dynamic FinalSnapshotName { get; set; }
    }

    public interface IHaveUserId : IResourceInterface
    {
        dynamic UserId { get; set; }
    }

    public interface IHavePasswords : IResourceInterface
    {
        dynamic Passwords { get; set; }
    }

    public interface IHaveScheme : IResourceInterface
    {
        dynamic Scheme { get; set; }
    }

    public interface IHaveLoadBalancerArn : IResourceInterface
    {
        dynamic LoadBalancerArn { get; set; }
    }

    public interface IHaveListenerArn : IResourceInterface
    {
        dynamic ListenerArn { get; set; }
    }

    public interface IHaveHealthCheckIntervalSeconds : IResourceInterface
    {
        dynamic HealthCheckIntervalSeconds { get; set; }
    }

    public interface IHaveHealthCheckPath : IResourceInterface
    {
        dynamic HealthCheckPath { get; set; }
    }

    public interface IHaveWorkflowName : IResourceInterface
    {
        dynamic WorkflowName { get; set; }
    }

    public interface IHaveStatementId : IResourceInterface
    {
        dynamic StatementId { get; set; }
    }

    public interface IHaveStatement : IResourceInterface
    {
        dynamic Statement { get; set; }
    }

    public interface IHaveProject : IResourceInterface
    {
        dynamic Project { get; set; }
    }

    public interface IHaveFileSystemPath : IResourceInterface
    {
        dynamic FileSystemPath { get; set; }
    }

    public interface IHaveBackupId : IResourceInterface
    {
        dynamic BackupId { get; set; }
    }

    public interface IHaveOperatingSystem : IResourceInterface
    {
        dynamic OperatingSystem { get; set; }
    }

    public interface IHaveRegexString : IResourceInterface
    {
        dynamic RegexString { get; set; }
    }

    public interface IHaveNumberOfNodes : IResourceInterface
    {
        dynamic NumberOfNodes { get; set; }
    }

    public interface IHaveWorkerType : IResourceInterface
    {
        dynamic WorkerType { get; set; }
    }

    public interface IHaveGlueVersion : IResourceInterface
    {
        dynamic GlueVersion { get; set; }
    }

    public interface IHaveNumberOfWorkers : IResourceInterface
    {
        dynamic NumberOfWorkers { get; set; }
    }

    public interface IHaveSchemaVersionId : IResourceInterface
    {
        dynamic SchemaVersionId { get; set; }
    }

    public interface IHaveAllowedOrigins : IResourceInterface
    {
        dynamic AllowedOrigins { get; set; }
    }

    public interface IHaveMetricType : IResourceInterface
    {
        dynamic MetricType { get; set; }
    }

    public interface IHaveDayOfMonth : IResourceInterface
    {
        dynamic DayOfMonth { get; set; }
    }

    public interface IHavePackageName : IResourceInterface
    {
        dynamic PackageName { get; set; }
    }

    public interface IHavePipelineName : IResourceInterface
    {
        dynamic PipelineName { get; set; }
    }

    public interface IHaveSeverity : IResourceInterface
    {
        dynamic Severity { get; set; }
    }

    public interface IHaveApplicationDescription : IResourceInterface
    {
        dynamic ApplicationDescription { get; set; }
    }

    public interface IHaveSignalCatalogArn : IResourceInterface
    {
        dynamic SignalCatalogArn { get; set; }
    }

    public interface IHaveQualifier : IResourceInterface
    {
        dynamic Qualifier { get; set; }
    }

    public interface IHaveMaximumEventAgeInSeconds : IResourceInterface
    {
        dynamic MaximumEventAgeInSeconds { get; set; }
    }

    public interface IHaveParallelizationFactor : IResourceInterface
    {
        dynamic ParallelizationFactor { get; set; }
    }

    public interface IHaveMaximumRecordAgeInSeconds : IResourceInterface
    {
        dynamic MaximumRecordAgeInSeconds { get; set; }
    }

    public interface IHaveMemorySize : IResourceInterface
    {
        dynamic MemorySize { get; set; }
    }

    public interface IHaveInstancePort : IResourceInterface
    {
        dynamic InstancePort { get; set; }
    }

    public interface IHaveCollectionName : IResourceInterface
    {
        dynamic CollectionName { get; set; }
    }

    public interface IHaveTrackerName : IResourceInterface
    {
        dynamic TrackerName { get; set; }
    }

    public interface IHaveFilterPattern : IResourceInterface
    {
        dynamic FilterPattern { get; set; }
    }

    public interface IHaveLogStreamName : IResourceInterface
    {
        dynamic LogStreamName { get; set; }
    }

    public interface IHaveFilterName : IResourceInterface
    {
        dynamic FilterName { get; set; }
    }

    public interface IHaveCurrentVersion : IResourceInterface
    {
        dynamic CurrentVersion { get; set; }
    }

    public interface IHaveMinLatency : IResourceInterface
    {
        dynamic MinLatency { get; set; }
    }

    public interface IHaveMaxLatency : IResourceInterface
    {
        dynamic MaxLatency { get; set; }
    }

    public interface IHaveEntitlementArn : IResourceInterface
    {
        dynamic EntitlementArn { get; set; }
    }

    public interface IHaveClusterType : IResourceInterface
    {
        dynamic ClusterType { get; set; }
    }

    public interface IHaveDBParameterGroupName : IResourceInterface
    {
        dynamic DBParameterGroupName { get; set; }
    }

    public interface IHavePeerAddress : IResourceInterface
    {
        dynamic PeerAddress { get; set; }
    }

    public interface IHaveSubnetArn : IResourceInterface
    {
        dynamic SubnetArn { get; set; }
    }

    public interface IHaveCoreNetworkAddress : IResourceInterface
    {
        dynamic CoreNetworkAddress { get; set; }
    }

    public interface IHaveInsideCidrBlocks : IResourceInterface
    {
        dynamic InsideCidrBlocks { get; set; }
    }

    public interface IHaveSerialNumber : IResourceInterface
    {
        dynamic SerialNumber { get; set; }
    }

    public interface IHaveDomains : IResourceInterface
    {
        dynamic Domains { get; set; }
    }

    public interface IHaveAgentVersion : IResourceInterface
    {
        dynamic AgentVersion { get; set; }
    }

    public interface IHaveAccountName : IResourceInterface
    {
        dynamic AccountName { get; set; }
    }

    public interface IHaveTreatmentName : IResourceInterface
    {
        dynamic TreatmentName { get; set; }
    }

    public interface IHaveDefaultSubstitutions : IResourceInterface
    {
        dynamic DefaultSubstitutions { get; set; }
    }

    public interface IHaveConfigurationSetName : IResourceInterface
    {
        dynamic ConfigurationSetName { get; set; }
    }

    public interface IHavePoolName : IResourceInterface
    {
        dynamic PoolName { get; set; }
    }

    public interface IHaveServerUrl : IResourceInterface
    {
        dynamic ServerUrl { get; set; }
    }

    public interface IHaveResourceArns : IResourceInterface
    {
        dynamic ResourceArns { get; set; }
    }

    public interface IHaveEngineLifecycleSupport : IResourceInterface
    {
        dynamic EngineLifecycleSupport { get; set; }
    }

    public interface IHaveDBProxyName : IResourceInterface
    {
        dynamic DBProxyName { get; set; }
    }

    public interface IHaveCIDRIP : IResourceInterface
    {
        dynamic CIDRIP { get; set; }
    }

    public interface IHaveIamRoles : IResourceInterface
    {
        dynamic IamRoles { get; set; }
    }

    public interface IHaveEnhancedVpcRouting : IResourceInterface
    {
        dynamic EnhancedVpcRouting { get; set; }
    }

    public interface IHaveAdminUsername : IResourceInterface
    {
        dynamic AdminUsername { get; set; }
    }

    public interface IHaveLogExports : IResourceInterface
    {
        dynamic LogExports { get; set; }
    }

    public interface IHaveEnvironment : IResourceInterface
    {
        dynamic Environment { get; set; }
    }

    public interface IHaveHostedZoneName : IResourceInterface
    {
        dynamic HostedZoneName { get; set; }
    }

    public interface IHaveProtocols : IResourceInterface
    {
        dynamic Protocols { get; set; }
    }

    public interface IHaveBucketAccountId : IResourceInterface
    {
        dynamic BucketAccountId { get; set; }
    }

    public interface IHaveAccessType : IResourceInterface
    {
        dynamic AccessType { get; set; }
    }

    public interface IHaveKmsDataKeyReusePeriodSeconds : IResourceInterface
    {
        dynamic KmsDataKeyReusePeriodSeconds { get; set; }
    }

    public interface IHaveQueueName : IResourceInterface
    {
        dynamic QueueName { get; set; }
    }

    public interface IHaveDocumentType : IResourceInterface
    {
        dynamic DocumentType { get; set; }
    }

    public interface IHaveTaskType : IResourceInterface
    {
        dynamic TaskType { get; set; }
    }

    public interface IHavePrincipalType : IResourceInterface
    {
        dynamic PrincipalType { get; set; }
    }

    public interface IHaveEndpointConfigName : IResourceInterface
    {
        dynamic EndpointConfigName { get; set; }
    }

    public interface IHaveVariantName : IResourceInterface
    {
        dynamic VariantName { get; set; }
    }

    public interface IHaveModelPackageGroupName : IResourceInterface
    {
        dynamic ModelPackageGroupName { get; set; }
    }

    public interface IHaveModelPackageName : IResourceInterface
    {
        dynamic ModelPackageName { get; set; }
    }

    public interface IHaveFailureReason : IResourceInterface
    {
        dynamic FailureReason { get; set; }
    }

    public interface IHaveRuleOrder : IResourceInterface
    {
        dynamic RuleOrder { get; set; }
    }

    public interface IHaveAccounts : IResourceInterface
    {
        dynamic Accounts { get; set; }
    }

    public interface IHaveProvisioningArtifactId : IResourceInterface
    {
        dynamic ProvisioningArtifactId { get; set; }
    }

    public interface IHaveActive : IResourceInterface
    {
        dynamic Active { get; set; }
    }

    public interface IHaveNamespaceId : IResourceInterface
    {
        dynamic NamespaceId { get; set; }
    }

    public interface IHaveMaximumDuration : IResourceInterface
    {
        dynamic MaximumDuration { get; set; }
    }

    public interface IHaveRuntimeVersion : IResourceInterface
    {
        dynamic RuntimeVersion { get; set; }
    }

    public interface IHaveOrganization : IResourceInterface
    {
        dynamic Organization { get; set; }
    }

    public interface IHavePolicyStoreId : IResourceInterface
    {
        dynamic PolicyStoreId { get; set; }
    }

    public interface IHaveRateLimit : IResourceInterface
    {
        dynamic RateLimit { get; set; }
    }

    public interface IHaveObjectIdentifier : IResourceInterface
    {
        dynamic ObjectIdentifier { get; set; }
    }

    public interface IHaveCritical : IResourceInterface
    {
        dynamic Critical { get; set; }
    }

    public interface IHaveDnsName : IResourceInterface
    {
        dynamic DnsName { get; set; }
    }

    public interface IHaveKeyEncipherment : IResourceInterface
    {
        dynamic KeyEncipherment { get; set; }
    }

    public interface IHaveDataEncipherment : IResourceInterface
    {
        dynamic DataEncipherment { get; set; }
    }

    public interface IHaveDigitalSignature : IResourceInterface
    {
        dynamic DigitalSignature { get; set; }
    }

    public interface IHaveNonRepudiation : IResourceInterface
    {
        dynamic NonRepudiation { get; set; }
    }

    public interface IHaveCommonName : IResourceInterface
    {
        dynamic CommonName { get; set; }
    }

    public interface IHaveExpirationInDays : IResourceInterface
    {
        dynamic ExpirationInDays { get; set; }
    }

    public interface IHaveCertificateType : IResourceInterface
    {
        dynamic CertificateType { get; set; }
    }

    public interface IHaveUserAttribute : IResourceInterface
    {
        dynamic UserAttribute { get; set; }
    }

    public interface IHaveConfigured : IResourceInterface
    {
        dynamic Configured { get; set; }
    }

    public interface IHaveAmplifyUIBuilderFormTypesFieldPositionPosition : IResourceInterface
    {
        Humidifier.AmplifyUIBuilder.FormTypes.FieldPosition Position { get; set; }
    }

    public interface IHaveExcluded : IResourceInterface
    {
        dynamic Excluded { get; set; }
    }

    public interface IHaveDynDicOfStageVariableOverrides : IResourceInterface
    {
        Dictionary<string, dynamic> StageVariableOverrides { get; set; }
    }

    public interface IHavePercentTraffic : IResourceInterface
    {
        dynamic PercentTraffic { get; set; }
    }

    public interface IHaveUseStageCache : IResourceInterface
    {
        dynamic UseStageCache { get; set; }
    }

    public interface IHaveCacheTtlInSeconds : IResourceInterface
    {
        dynamic CacheTtlInSeconds { get; set; }
    }

    public interface IHaveCacheDataEncrypted : IResourceInterface
    {
        dynamic CacheDataEncrypted { get; set; }
    }

    public interface IHaveCachingEnabled : IResourceInterface
    {
        dynamic CachingEnabled { get; set; }
    }

    public interface IHaveMetricsEnabled : IResourceInterface
    {
        dynamic MetricsEnabled { get; set; }
    }

    public interface IHaveTypes : IResourceInterface
    {
        dynamic Types { get; set; }
    }

    public interface IHaveCredentials : IResourceInterface
    {
        dynamic Credentials { get; set; }
    }

    public interface IHaveETag : IResourceInterface
    {
        dynamic ETag { get; set; }
    }

    public interface IHaveExposeHeaders : IResourceInterface
    {
        dynamic ExposeHeaders { get; set; }
    }

    public interface IHaveMaxAge : IResourceInterface
    {
        dynamic MaxAge { get; set; }
    }

    public interface IHaveFirstExecutionFrom : IResourceInterface
    {
        dynamic FirstExecutionFrom { get; set; }
    }

    public interface IHaveIpPreference : IResourceInterface
    {
        dynamic IpPreference { get; set; }
    }

    public interface IHaveListOfAppMeshRouteTypesWeightedTargetWeightedTargets : IResourceInterface
    {
        List<Humidifier.AppMesh.RouteTypes.WeightedTarget> WeightedTargets { get; set; }
    }

    public interface IHaveAppMeshRouteTypesDurationIdle : IResourceInterface
    {
        Humidifier.AppMesh.RouteTypes.Duration Idle { get; set; }
    }

    public interface IHaveIntegerListOfPorts : IResourceInterface
    {
        List<int> Ports { get; set; }
    }

    public interface IHaveMaxConnections : IResourceInterface
    {
        dynamic MaxConnections { get; set; }
    }

    public interface IHaveAppMeshVirtualNodeTypesDurationIdle : IResourceInterface
    {
        Humidifier.AppMesh.VirtualNodeTypes.Duration Idle { get; set; }
    }

    public interface IHaveVpceId : IResourceInterface
    {
        dynamic VpceId { get; set; }
    }

    public interface IHaveEventBusArn : IResourceInterface
    {
        dynamic EventBusArn { get; set; }
    }

    public interface IHaveListOfApplicationInsightsApplicationTypesAlarmMetricAlarmMetrics : IResourceInterface
    {
        List<Humidifier.ApplicationInsights.ApplicationTypes.AlarmMetric> AlarmMetrics { get; set; }
    }

    public interface IHaveEventName : IResourceInterface
    {
        dynamic EventName { get; set; }
    }

    public interface IHaveEncryptionOption : IResourceInterface
    {
        dynamic EncryptionOption { get; set; }
    }

    public interface IHaveDestinationType : IResourceInterface
    {
        dynamic DestinationType { get; set; }
    }

    public interface IHaveMetrics : IResourceInterface
    {
        dynamic Metrics { get; set; }
    }

    public interface IHaveHttpPutResponseHopLimit : IResourceInterface
    {
        dynamic HttpPutResponseHopLimit { get; set; }
    }

    public interface IHaveHttpTokens : IResourceInterface
    {
        dynamic HttpTokens { get; set; }
    }

    public interface IHaveListOfAutoScalingScalingPolicyTypesMetricDataQueryMetricDataQueries : IResourceInterface
    {
        List<Humidifier.AutoScaling.ScalingPolicyTypes.MetricDataQuery> MetricDataQueries { get; set; }
    }

    public interface IHaveOverwrite : IResourceInterface
    {
        dynamic Overwrite { get; set; }
    }

    public interface IHaveReadonlyRootFilesystem : IResourceInterface
    {
        dynamic ReadonlyRootFilesystem { get; set; }
    }

    public interface IHaveRootDirectory : IResourceInterface
    {
        dynamic RootDirectory { get; set; }
    }

    public interface IHaveLogDriver : IResourceInterface
    {
        dynamic LogDriver { get; set; }
    }

    public interface IHaveLabels : IResourceInterface
    {
        dynamic Labels { get; set; }
    }

    public interface IHaveCredentialsParameter : IResourceInterface
    {
        dynamic CredentialsParameter { get; set; }
    }

    public interface IHaveAttempts : IResourceInterface
    {
        dynamic Attempts { get; set; }
    }

    public interface IHaveValueFrom : IResourceInterface
    {
        dynamic ValueFrom { get; set; }
    }

    public interface IHaveEssential : IResourceInterface
    {
        dynamic Essential { get; set; }
    }

    public interface IHaveMountOptions : IResourceInterface
    {
        dynamic MountOptions { get; set; }
    }

    public interface IHaveSoftLimit : IResourceInterface
    {
        dynamic SoftLimit { get; set; }
    }

    public interface IHaveHardLimit : IResourceInterface
    {
        dynamic HardLimit { get; set; }
    }

    public interface IHavePayload : IResourceInterface
    {
        dynamic Payload { get; set; }
    }

    public interface IHaveS3ObjectKey : IResourceInterface
    {
        dynamic S3ObjectKey { get; set; }
    }

    public interface IHaveBedrockDataSourceTypesCrawlFilterConfigurationFilterConfiguration : IResourceInterface
    {
        Humidifier.Bedrock.DataSourceTypes.CrawlFilterConfiguration FilterConfiguration { get; set; }
    }

    public interface IHaveHostUrl : IResourceInterface
    {
        dynamic HostUrl { get; set; }
    }

    public interface IHaveVectorField : IResourceInterface
    {
        dynamic VectorField { get; set; }
    }

    public interface IHaveAdditionalAnalyses : IResourceInterface
    {
        dynamic AdditionalAnalyses { get; set; }
    }

    public interface IHaveAllowedResultReceivers : IResourceInterface
    {
        dynamic AllowedResultReceivers { get; set; }
    }

    public interface IHaveAllowedAdditionalAnalyses : IResourceInterface
    {
        dynamic AllowedAdditionalAnalyses { get; set; }
    }

    public interface IHaveLogRoleArn : IResourceInterface
    {
        dynamic LogRoleArn { get; set; }
    }

    public interface IHaveMinTTL : IResourceInterface
    {
        dynamic MinTTL { get; set; }
    }

    public interface IHaveMaxTTL : IResourceInterface
    {
        dynamic MaxTTL { get; set; }
    }

    public interface IHaveHeaders : IResourceInterface
    {
        dynamic Headers { get; set; }
    }

    public interface IHaveResponseCode : IResourceInterface
    {
        dynamic ResponseCode { get; set; }
    }

    public interface IHaveOriginAccessIdentity : IResourceInterface
    {
        dynamic OriginAccessIdentity { get; set; }
    }

    public interface IHaveHeaderValue : IResourceInterface
    {
        dynamic HeaderValue { get; set; }
    }

    public interface IHaveQuantity : IResourceInterface
    {
        dynamic Quantity { get; set; }
    }

    public interface IHaveEquals : IResourceInterface
    {
        dynamic Equals { get; set; }
    }

    public interface IHaveNotEquals : IResourceInterface
    {
        dynamic NotEquals { get; set; }
    }

    public interface IHaveEncryptionDisabled : IResourceInterface
    {
        dynamic EncryptionDisabled { get; set; }
    }

    public interface IHaveSourceIdentifier : IResourceInterface
    {
        dynamic SourceIdentifier { get; set; }
    }

    public interface IHaveListOfCodePipelinePipelineTypesConditionConditions : IResourceInterface
    {
        List<Humidifier.CodePipeline.PipelineTypes.Condition> Conditions { get; set; }
    }

    public interface IHaveIncludes : IResourceInterface
    {
        dynamic Includes { get; set; }
    }

    public interface IHaveExcludes : IResourceInterface
    {
        dynamic Excludes { get; set; }
    }

    public interface IHaveJsonPath : IResourceInterface
    {
        dynamic JsonPath { get; set; }
    }

    public interface IHaveLambdaVersion : IResourceInterface
    {
        dynamic LambdaVersion { get; set; }
    }

    public interface IHaveCaseSensitive : IResourceInterface
    {
        dynamic CaseSensitive { get; set; }
    }

    public interface IHaveDocumentName : IResourceInterface
    {
        dynamic DocumentName { get; set; }
    }

    public interface IHaveTagKeyScope : IResourceInterface
    {
        dynamic TagKeyScope { get; set; }
    }

    public interface IHaveTagValueScope : IResourceInterface
    {
        dynamic TagValueScope { get; set; }
    }

    public interface IHaveResourceIdScope : IResourceInterface
    {
        dynamic ResourceIdScope { get; set; }
    }

    public interface IHaveResourceTypesScope : IResourceInterface
    {
        dynamic ResourceTypesScope { get; set; }
    }

    public interface IHaveRefId : IResourceInterface
    {
        dynamic RefId { get; set; }
    }

    public interface IHaveMinutes : IResourceInterface
    {
        dynamic Minutes { get; set; }
    }

    public interface IHaveStringList : IResourceInterface
    {
        dynamic StringList { get; set; }
    }

    public interface IHavePhoneNumber : IResourceInterface
    {
        dynamic PhoneNumber { get; set; }
    }

    public interface IHaveChannel : IResourceInterface
    {
        dynamic Channel { get; set; }
    }

    public interface IHaveDialingCapacity : IResourceInterface
    {
        dynamic DialingCapacity { get; set; }
    }

    public interface IHaveSSEEnabled : IResourceInterface
    {
        dynamic SSEEnabled { get; set; }
    }

    public interface IHaveMessageFormat : IResourceInterface
    {
        dynamic MessageFormat { get; set; }
    }

    public interface IHaveEncodingType : IResourceInterface
    {
        dynamic EncodingType { get; set; }
    }

    public interface IHaveCompressionFormat : IResourceInterface
    {
        dynamic CompressionFormat { get; set; }
    }

    public interface IHaveSourceColumn : IResourceInterface
    {
        dynamic SourceColumn { get; set; }
    }

    public interface IHaveBucketAccessRoleArn : IResourceInterface
    {
        dynamic BucketAccessRoleArn { get; set; }
    }

    public interface IHaveInputFormat : IResourceInterface
    {
        dynamic InputFormat { get; set; }
    }

    public interface IHaveInstanceInterruptionBehavior : IResourceInterface
    {
        dynamic InstanceInterruptionBehavior { get; set; }
    }

    public interface IHaveThreadsPerCore : IResourceInterface
    {
        dynamic ThreadsPerCore { get; set; }
    }

    public interface IHaveEnableResourceNameDnsARecord : IResourceInterface
    {
        dynamic EnableResourceNameDnsARecord { get; set; }
    }

    public interface IHaveHostnameType : IResourceInterface
    {
        dynamic HostnameType { get; set; }
    }

    public interface IHaveEnableResourceNameDnsAAAARecord : IResourceInterface
    {
        dynamic EnableResourceNameDnsAAAARecord { get; set; }
    }

    public interface IHaveBlockDurationMinutes : IResourceInterface
    {
        dynamic BlockDurationMinutes { get; set; }
    }

    public interface IHaveEC2NetworkInsightsAnalysisTypesAnalysisComponentComponent : IResourceInterface
    {
        Humidifier.EC2.NetworkInsightsAnalysisTypes.AnalysisComponent Component { get; set; }
    }

    public interface IHaveComponentArn : IResourceInterface
    {
        dynamic ComponentArn { get; set; }
    }

    public interface IHaveCidrs : IResourceInterface
    {
        dynamic Cidrs { get; set; }
    }

    public interface IHaveIpv6Support : IResourceInterface
    {
        dynamic Ipv6Support { get; set; }
    }

    public interface IHaveApplianceModeSupport : IResourceInterface
    {
        dynamic ApplianceModeSupport { get; set; }
    }

    public interface IHaveCustomerManagedKeyEnabled : IResourceInterface
    {
        dynamic CustomerManagedKeyEnabled { get; set; }
    }

    public interface IHaveTokenEndpoint : IResourceInterface
    {
        dynamic TokenEndpoint { get; set; }
    }

    public interface IHaveUserInfoEndpoint : IResourceInterface
    {
        dynamic UserInfoEndpoint { get; set; }
    }

    public interface IHaveDynDicOfOptions : IResourceInterface
    {
        Dictionary<string, dynamic> Options { get; set; }
    }

    public interface IHaveEntryPoint : IResourceInterface
    {
        dynamic EntryPoint { get; set; }
    }

    public interface IHaveRetries : IResourceInterface
    {
        dynamic Retries { get; set; }
    }

    public interface IHaveDeviceType : IResourceInterface
    {
        dynamic DeviceType { get; set; }
    }

    public interface IHaveDynDicOfConfigurationProperties : IResourceInterface
    {
        Dictionary<string, dynamic> ConfigurationProperties { get; set; }
    }

    public interface IHaveVolumesPerInstance : IResourceInterface
    {
        dynamic VolumesPerInstance { get; set; }
    }

    public interface IHaveTimeoutAction : IResourceInterface
    {
        dynamic TimeoutAction { get; set; }
    }

    public interface IHaveSizeInGB : IResourceInterface
    {
        dynamic SizeInGB { get; set; }
    }

    public interface IHaveOptionName : IResourceInterface
    {
        dynamic OptionName { get; set; }
    }

    public interface IHaveUserPoolArn : IResourceInterface
    {
        dynamic UserPoolArn { get; set; }
    }

    public interface IHaveMasterUserName : IResourceInterface
    {
        dynamic MasterUserName { get; set; }
    }

    public interface IHaveInputSourceARN : IResourceInterface
    {
        dynamic InputSourceARN { get; set; }
    }

    public interface IHaveProviderServiceArn : IResourceInterface
    {
        dynamic ProviderServiceArn { get; set; }
    }

    public interface IHaveDynDicOfProviderConfiguration : IResourceInterface
    {
        Dictionary<string, dynamic> ProviderConfiguration { get; set; }
    }

    public interface IHaveMatchingKeys : IResourceInterface
    {
        dynamic MatchingKeys { get; set; }
    }

    public interface IHaveTaskCount : IResourceInterface
    {
        dynamic TaskCount { get; set; }
    }

    public interface IHaveReferenceId : IResourceInterface
    {
        dynamic ReferenceId { get; set; }
    }

    public interface IHaveTaskDefinitionArn : IResourceInterface
    {
        dynamic TaskDefinitionArn { get; set; }
    }

    public interface IHavePathParameterValues : IResourceInterface
    {
        dynamic PathParameterValues { get; set; }
    }

    public interface IHaveDynDicOfHeaderParameters : IResourceInterface
    {
        Dictionary<string, dynamic> HeaderParameters { get; set; }
    }

    public interface IHaveDynDicOfQueryStringParameters : IResourceInterface
    {
        Dictionary<string, dynamic> QueryStringParameters { get; set; }
    }

    public interface IHaveInputTemplate : IResourceInterface
    {
        dynamic InputTemplate { get; set; }
    }

    public interface IHaveDbUser : IResourceInterface
    {
        dynamic DbUser { get; set; }
    }

    public interface IHaveMessageGroupId : IResourceInterface
    {
        dynamic MessageGroupId { get; set; }
    }

    public interface IHaveValueKey : IResourceInterface
    {
        dynamic ValueKey { get; set; }
    }

    public interface IHaveUnitLabel : IResourceInterface
    {
        dynamic UnitLabel { get; set; }
    }

    public interface IHaveVariation : IResourceInterface
    {
        dynamic Variation { get; set; }
    }

    public interface IHaveDataCompressionType : IResourceInterface
    {
        dynamic DataCompressionType { get; set; }
    }

    public interface IHaveFSxFileSystemTypesDiskIopsConfigurationDiskIopsConfiguration : IResourceInterface
    {
        Humidifier.FSx.FileSystemTypes.DiskIopsConfiguration DiskIopsConfiguration { get; set; }
    }

    public interface IHaveThroughputCapacity : IResourceInterface
    {
        dynamic ThroughputCapacity { get; set; }
    }

    public interface IHavePreferredSubnetId : IResourceInterface
    {
        dynamic PreferredSubnetId { get; set; }
    }

    public interface IHaveStorageCapacityQuotaGiB : IResourceInterface
    {
        dynamic StorageCapacityQuotaGiB { get; set; }
    }

    public interface IHaveLanguage : IResourceInterface
    {
        dynamic Language { get; set; }
    }

    public interface IHaveRuleId : IResourceInterface
    {
        dynamic RuleId { get; set; }
    }

    public interface IHaveEndpointId : IResourceInterface
    {
        dynamic EndpointId { get; set; }
    }

    public interface IHaveContainsHeader : IResourceInterface
    {
        dynamic ContainsHeader { get; set; }
    }

    public interface IHaveExclusions : IResourceInterface
    {
        dynamic Exclusions { get; set; }
    }

    public interface IHaveIsolationMode : IResourceInterface
    {
        dynamic IsolationMode { get; set; }
    }

    public interface IHavePinned : IResourceInterface
    {
        dynamic Pinned { get; set; }
    }

    public interface IHaveExecArgs : IResourceInterface
    {
        dynamic ExecArgs { get; set; }
    }

    public interface IHaveFailureType : IResourceInterface
    {
        dynamic FailureType { get; set; }
    }

    public interface IHaveThresholdPercentage : IResourceInterface
    {
        dynamic ThresholdPercentage { get; set; }
    }

    public interface IHaveMtu : IResourceInterface
    {
        dynamic Mtu { get; set; }
    }

    public interface IHaveGte : IResourceInterface
    {
        dynamic Gte { get; set; }
    }

    public interface IHaveLte : IResourceInterface
    {
        dynamic Lte { get; set; }
    }

    public interface IHaveResolution : IResourceInterface
    {
        dynamic Resolution { get; set; }
    }

    public interface IHaveContainerTags : IResourceInterface
    {
        dynamic ContainerTags { get; set; }
    }

    public interface IHaveDynDicOfTagMap : IResourceInterface
    {
        Dictionary<string, dynamic> TagMap { get; set; }
    }

    public interface IHaveInspectorV2CisScanConfigurationTypesTimeStartTime : IResourceInterface
    {
        Humidifier.InspectorV2.CisScanConfigurationTypes.Time StartTime { get; set; }
    }

    public interface IHaveDurationInMinutes : IResourceInterface
    {
        dynamic DurationInMinutes { get; set; }
    }

    public interface IHaveMqttTopic : IResourceInterface
    {
        dynamic MqttTopic { get; set; }
    }

    public interface IHaveTimeInSeconds : IResourceInterface
    {
        dynamic TimeInSeconds { get; set; }
    }

    public interface IHaveOffsetInNanos : IResourceInterface
    {
        dynamic OffsetInNanos { get; set; }
    }

    public interface IHaveQuality : IResourceInterface
    {
        dynamic Quality { get; set; }
    }

    public interface IHavePayloadField : IResourceInterface
    {
        dynamic PayloadField { get; set; }
    }

    public interface IHaveRangeKeyField : IResourceInterface
    {
        dynamic RangeKeyField { get; set; }
    }

    public interface IHaveHashKeyField : IResourceInterface
    {
        dynamic HashKeyField { get; set; }
    }

    public interface IHaveRangeKeyValue : IResourceInterface
    {
        dynamic RangeKeyValue { get; set; }
    }

    public interface IHaveRangeKeyType : IResourceInterface
    {
        dynamic RangeKeyType { get; set; }
    }

    public interface IHaveHashKeyType : IResourceInterface
    {
        dynamic HashKeyType { get; set; }
    }

    public interface IHaveHashKeyValue : IResourceInterface
    {
        dynamic HashKeyValue { get; set; }
    }

    public interface IHaveSeparator : IResourceInterface
    {
        dynamic Separator { get; set; }
    }

    public interface IHavePartitionKey : IResourceInterface
    {
        dynamic PartitionKey { get; set; }
    }

    public interface IHaveEntryId : IResourceInterface
    {
        dynamic EntryId { get; set; }
    }

    public interface IHavePropertyAlias : IResourceInterface
    {
        dynamic PropertyAlias { get; set; }
    }

    public interface IHaveUseBase64 : IResourceInterface
    {
        dynamic UseBase64 { get; set; }
    }

    public interface IHaveQueueUrl : IResourceInterface
    {
        dynamic QueueUrl { get; set; }
    }

    public interface IHaveNumberOfDays : IResourceInterface
    {
        dynamic NumberOfDays { get; set; }
    }

    public interface IHaveTimestampFormat : IResourceInterface
    {
        dynamic TimestampFormat { get; set; }
    }

    public interface IHaveTimerName : IResourceInterface
    {
        dynamic TimerName { get; set; }
    }

    public interface IHaveListOfIoTEventsDetectorModelTypesEventEvents : IResourceInterface
    {
        List<Humidifier.IoTEvents.DetectorModelTypes.Event> Events { get; set; }
    }

    public interface IHaveKendraDataSourceTypesDataSourceVpcConfigurationVpcConfiguration : IResourceInterface
    {
        Humidifier.Kendra.DataSourceTypes.DataSourceVpcConfiguration VpcConfiguration { get; set; }
    }

    public interface IHaveDatabasePort : IResourceInterface
    {
        dynamic DatabasePort { get; set; }
    }

    public interface IHaveDatabaseHost : IResourceInterface
    {
        dynamic DatabaseHost { get; set; }
    }

    public interface IHaveIncludeAttachmentFilePatterns : IResourceInterface
    {
        dynamic IncludeAttachmentFilePatterns { get; set; }
    }

    public interface IHaveExcludeAttachmentFilePatterns : IResourceInterface
    {
        dynamic ExcludeAttachmentFilePatterns { get; set; }
    }

    public interface IHaveKinesisFirehoseDeliveryStreamTypesVpcConfigurationVpcConfiguration : IResourceInterface
    {
        Humidifier.KinesisFirehose.DeliveryStreamTypes.VpcConfiguration VpcConfiguration { get; set; }
    }

    public interface IHaveKinesisFirehoseDeliveryStreamTypesRetryOptionsRetryOptions : IResourceInterface
    {
        Humidifier.KinesisFirehose.DeliveryStreamTypes.RetryOptions RetryOptions { get; set; }
    }

    public interface IHaveExcludedColumnNames : IResourceInterface
    {
        dynamic ExcludedColumnNames { get; set; }
    }

    public interface IHaveLexBotTypesDialogCodeHookInvocationSettingCodeHook : IResourceInterface
    {
        Humidifier.Lex.BotTypes.DialogCodeHookInvocationSetting CodeHook { get; set; }
    }

    public interface IHaveListOfLexBotTypesMessageGroupMessageGroupsList : IResourceInterface
    {
        List<Humidifier.Lex.BotTypes.MessageGroup> MessageGroupsList { get; set; }
    }

    public interface IHaveTimeoutSeconds : IResourceInterface
    {
        dynamic TimeoutSeconds { get; set; }
    }

    public interface IHaveBehavior : IResourceInterface
    {
        dynamic Behavior { get; set; }
    }

    public interface IHaveOption : IResourceInterface
    {
        dynamic Option { get; set; }
    }

    public interface IHaveMaintenanceDay : IResourceInterface
    {
        dynamic MaintenanceDay { get; set; }
    }

    public interface IHaveMediaStreamName : IResourceInterface
    {
        dynamic MediaStreamName { get; set; }
    }

    public interface IHaveRateControlMode : IResourceInterface
    {
        dynamic RateControlMode { get; set; }
    }

    public interface IHaveSampleRate : IResourceInterface
    {
        dynamic SampleRate { get; set; }
    }

    public interface IHaveDialnorm : IResourceInterface
    {
        dynamic Dialnorm { get; set; }
    }

    public interface IHaveFontSize : IResourceInterface
    {
        dynamic FontSize { get; set; }
    }

    public interface IHaveRepInterval : IResourceInterface
    {
        dynamic RepInterval { get; set; }
    }

    public interface IHaveStyleControl : IResourceInterface
    {
        dynamic StyleControl { get; set; }
    }

    public interface IHaveAdAvailOffset : IResourceInterface
    {
        dynamic AdAvailOffset { get; set; }
    }

    public interface IHaveTimedMetadataBehavior : IResourceInterface
    {
        dynamic TimedMetadataBehavior { get; set; }
    }

    public interface IHaveMediaLiveChannelTypesTemporalFilterSettingsTemporalFilterSettings : IResourceInterface
    {
        Humidifier.MediaLive.ChannelTypes.TemporalFilterSettings TemporalFilterSettings { get; set; }
    }

    public interface IHaveFramerateNumerator : IResourceInterface
    {
        dynamic FramerateNumerator { get; set; }
    }

    public interface IHaveGopClosedCadence : IResourceInterface
    {
        dynamic GopClosedCadence { get; set; }
    }

    public interface IHaveFramerateDenominator : IResourceInterface
    {
        dynamic FramerateDenominator { get; set; }
    }

    public interface IHaveGopSize : IResourceInterface
    {
        dynamic GopSize { get; set; }
    }

    public interface IHaveAdaptiveQuantization : IResourceInterface
    {
        dynamic AdaptiveQuantization { get; set; }
    }

    public interface IHaveFixedAfd : IResourceInterface
    {
        dynamic FixedAfd { get; set; }
    }

    public interface IHaveGopSizeUnits : IResourceInterface
    {
        dynamic GopSizeUnits { get; set; }
    }

    public interface IHaveAfdSignaling : IResourceInterface
    {
        dynamic AfdSignaling { get; set; }
    }

    public interface IHaveScanType : IResourceInterface
    {
        dynamic ScanType { get; set; }
    }

    public interface IHaveTimecodeInsertion : IResourceInterface
    {
        dynamic TimecodeInsertion { get; set; }
    }

    public interface IHaveColorMetadata : IResourceInterface
    {
        dynamic ColorMetadata { get; set; }
    }

    public interface IHaveVideoPid : IResourceInterface
    {
        dynamic VideoPid { get; set; }
    }

    public interface IHaveTransportStreamId : IResourceInterface
    {
        dynamic TransportStreamId { get; set; }
    }

    public interface IHavePcrPid : IResourceInterface
    {
        dynamic PcrPid { get; set; }
    }

    public interface IHavePmtPid : IResourceInterface
    {
        dynamic PmtPid { get; set; }
    }

    public interface IHaveTimedMetadataPid : IResourceInterface
    {
        dynamic TimedMetadataPid { get; set; }
    }

    public interface IHaveEncryptionMethod : IResourceInterface
    {
        dynamic EncryptionMethod { get; set; }
    }

    public interface IHaveAdsOnDeliveryRestrictions : IResourceInterface
    {
        dynamic AdsOnDeliveryRestrictions { get; set; }
    }

    public interface IHaveSegmentTemplateFormat : IResourceInterface
    {
        dynamic SegmentTemplateFormat { get; set; }
    }

    public interface IHaveAdTriggers : IResourceInterface
    {
        dynamic AdTriggers { get; set; }
    }

    public interface IHavePeriodTriggers : IResourceInterface
    {
        dynamic PeriodTriggers { get; set; }
    }

    public interface IHaveSuggestedPresentationDelaySeconds : IResourceInterface
    {
        dynamic SuggestedPresentationDelaySeconds { get; set; }
    }

    public interface IHaveMinUpdatePeriodSeconds : IResourceInterface
    {
        dynamic MinUpdatePeriodSeconds { get; set; }
    }

    public interface IHaveMediaPackagePackagingConfigurationTypesStreamSelectionStreamSelection : IResourceInterface
    {
        Humidifier.MediaPackage.PackagingConfigurationTypes.StreamSelection StreamSelection { get; set; }
    }

    public interface IHaveMediaPackageV2OriginEndpointTypesFilterConfigurationFilterConfiguration : IResourceInterface
    {
        Humidifier.MediaPackageV2.OriginEndpointTypes.FilterConfiguration FilterConfiguration { get; set; }
    }

    public interface IHaveSourceGroup : IResourceInterface
    {
        dynamic SourceGroup { get; set; }
    }

    public interface IHaveBaseUrl : IResourceInterface
    {
        dynamic BaseUrl { get; set; }
    }

    public interface IHaveReferenceArn : IResourceInterface
    {
        dynamic ReferenceArn { get; set; }
    }

    public interface IHaveIp : IResourceInterface
    {
        dynamic Ip { get; set; }
    }

    public interface IHaveNoSecurityExtension : IResourceInterface
    {
        dynamic NoSecurityExtension { get; set; }
    }

    public interface IHaveIncludeSymmetricAlgorithms : IResourceInterface
    {
        dynamic IncludeSymmetricAlgorithms { get; set; }
    }

    public interface IHaveUserInteractionRequired : IResourceInterface
    {
        dynamic UserInteractionRequired { get; set; }
    }

    public interface IHaveEnableKeyReuseOnNtTokenKeysetStorageFull : IResourceInterface
    {
        dynamic EnableKeyReuseOnNtTokenKeysetStorageFull { get; set; }
    }

    public interface IHaveRemoveInvalidCertificateFromPersonalStore : IResourceInterface
    {
        dynamic RemoveInvalidCertificateFromPersonalStore { get; set; }
    }

    public interface IHavePCAConnectorADTemplateTypesApplicationPoliciesApplicationPolicies : IResourceInterface
    {
        Humidifier.PCAConnectorAD.TemplateTypes.ApplicationPolicies ApplicationPolicies { get; set; }
    }

    public interface IHavePCAConnectorADTemplateTypesKeyUsageKeyUsage : IResourceInterface
    {
        Humidifier.PCAConnectorAD.TemplateTypes.KeyUsage KeyUsage { get; set; }
    }

    public interface IHaveAutoEnrollment : IResourceInterface
    {
        dynamic AutoEnrollment { get; set; }
    }

    public interface IHaveMachineType : IResourceInterface
    {
        dynamic MachineType { get; set; }
    }

    public interface IHaveMinimalKeyLength : IResourceInterface
    {
        dynamic MinimalKeyLength { get; set; }
    }

    public interface IHaveCryptoProviders : IResourceInterface
    {
        dynamic CryptoProviders { get; set; }
    }

    public interface IHaveExportableKey : IResourceInterface
    {
        dynamic ExportableKey { get; set; }
    }

    public interface IHaveStrongKeyProtectionRequired : IResourceInterface
    {
        dynamic StrongKeyProtectionRequired { get; set; }
    }

    public interface IHaveClientVersion : IResourceInterface
    {
        dynamic ClientVersion { get; set; }
    }

    public interface IHaveSanRequireEmail : IResourceInterface
    {
        dynamic SanRequireEmail { get; set; }
    }

    public interface IHaveSanRequireDns : IResourceInterface
    {
        dynamic SanRequireDns { get; set; }
    }

    public interface IHaveRequireCommonName : IResourceInterface
    {
        dynamic RequireCommonName { get; set; }
    }

    public interface IHaveSanRequireUpn : IResourceInterface
    {
        dynamic SanRequireUpn { get; set; }
    }

    public interface IHaveSanRequireDomainDns : IResourceInterface
    {
        dynamic SanRequireDomainDns { get; set; }
    }

    public interface IHaveSanRequireSpn : IResourceInterface
    {
        dynamic SanRequireSpn { get; set; }
    }

    public interface IHaveRequireEmail : IResourceInterface
    {
        dynamic RequireEmail { get; set; }
    }

    public interface IHaveRequireDirectoryPath : IResourceInterface
    {
        dynamic RequireDirectoryPath { get; set; }
    }

    public interface IHaveSanRequireDirectoryGuid : IResourceInterface
    {
        dynamic SanRequireDirectoryGuid { get; set; }
    }

    public interface IHaveRequireDnsAsCn : IResourceInterface
    {
        dynamic RequireDnsAsCn { get; set; }
    }

    public interface IHaveSupersededTemplates : IResourceInterface
    {
        dynamic SupersededTemplates { get; set; }
    }

    public interface IHavePCAConnectorADTemplateTypesCertificateValidityCertificateValidity : IResourceInterface
    {
        Humidifier.PCAConnectorAD.TemplateTypes.CertificateValidity CertificateValidity { get; set; }
    }

    public interface IHaveSound : IResourceInterface
    {
        dynamic Sound { get; set; }
    }

    public interface IHaveInvocationType : IResourceInterface
    {
        dynamic InvocationType { get; set; }
    }

    public interface IHaveDateAggregationFunction : IResourceInterface
    {
        dynamic DateAggregationFunction { get; set; }
    }

    public interface IHaveCategoricalAggregationFunction : IResourceInterface
    {
        dynamic CategoricalAggregationFunction { get; set; }
    }

    public interface IHaveSortDirection : IResourceInterface
    {
        dynamic SortDirection { get; set; }
    }

    public interface IHaveAnchorOption : IResourceInterface
    {
        dynamic AnchorOption { get; set; }
    }

    public interface IHaveReserveRange : IResourceInterface
    {
        dynamic ReserveRange { get; set; }
    }

    public interface IHaveArcAngle : IResourceInterface
    {
        dynamic ArcAngle { get; set; }
    }

    public interface IHaveWeekStart : IResourceInterface
    {
        dynamic WeekStart { get; set; }
    }

    public interface IHaveSimpleAttributeAggregation : IResourceInterface
    {
        dynamic SimpleAttributeAggregation { get; set; }
    }

    public interface IHaveValueForMultipleValues : IResourceInterface
    {
        dynamic ValueForMultipleValues { get; set; }
    }

    public interface IHaveAxisOffset : IResourceInterface
    {
        dynamic AxisOffset { get; set; }
    }

    public interface IHaveAxisLineVisibility : IResourceInterface
    {
        dynamic AxisLineVisibility { get; set; }
    }

    public interface IHaveGridLineVisibility : IResourceInterface
    {
        dynamic GridLineVisibility { get; set; }
    }

    public interface IHaveDataDriven : IResourceInterface
    {
        dynamic DataDriven { get; set; }
    }

    public interface IHaveRotationAngle : IResourceInterface
    {
        dynamic RotationAngle { get; set; }
    }

    public interface IHaveListOfQuickSightAnalysisTypesDimensionFieldSmallMultiples : IResourceInterface
    {
        List<Humidifier.QuickSight.AnalysisTypes.DimensionField> SmallMultiples { get; set; }
    }

    public interface IHaveQuickSightAnalysisTypesSmallMultiplesOptionsSmallMultiplesOptions : IResourceInterface
    {
        Humidifier.QuickSight.AnalysisTypes.SmallMultiplesOptions SmallMultiplesOptions { get; set; }
    }

    public interface IHaveQuickSightAnalysisTypesChartAxisLabelOptionsValueLabelOptions : IResourceInterface
    {
        Humidifier.QuickSight.AnalysisTypes.ChartAxisLabelOptions ValueLabelOptions { get; set; }
    }

    public interface IHaveListOfQuickSightAnalysisTypesContributionAnalysisDefaultContributionAnalysisDefaults : IResourceInterface
    {
        List<Humidifier.QuickSight.AnalysisTypes.ContributionAnalysisDefault> ContributionAnalysisDefaults { get; set; }
    }

    public interface IHaveListOfQuickSightAnalysisTypesFieldSortOptionsSmallMultiplesSort : IResourceInterface
    {
        List<Humidifier.QuickSight.AnalysisTypes.FieldSortOptions> SmallMultiplesSort { get; set; }
    }

    public interface IHaveListOfQuickSightAnalysisTypesFieldSortOptionsColorSort : IResourceInterface
    {
        List<Humidifier.QuickSight.AnalysisTypes.FieldSortOptions> ColorSort { get; set; }
    }

    public interface IHaveQuickSightAnalysisTypesItemsLimitConfigurationColorItemsLimit : IResourceInterface
    {
        Humidifier.QuickSight.AnalysisTypes.ItemsLimitConfiguration ColorItemsLimit { get; set; }
    }

    public interface IHaveQuickSightAnalysisTypesItemsLimitConfigurationSmallMultiplesLimitConfiguration : IResourceInterface
    {
        Humidifier.QuickSight.AnalysisTypes.ItemsLimitConfiguration SmallMultiplesLimitConfiguration { get; set; }
    }

    public interface IHaveBinCountLimit : IResourceInterface
    {
        dynamic BinCountLimit { get; set; }
    }

    public interface IHaveListOfQuickSightAnalysisTypesDimensionFieldGroupBy : IResourceInterface
    {
        List<Humidifier.QuickSight.AnalysisTypes.DimensionField> GroupBy { get; set; }
    }

    public interface IHaveQuickSightAnalysisTypesAxisDisplayOptionsPrimaryYAxisDisplayOptions : IResourceInterface
    {
        Humidifier.QuickSight.AnalysisTypes.AxisDisplayOptions PrimaryYAxisDisplayOptions { get; set; }
    }

    public interface IHaveOutlierVisibility : IResourceInterface
    {
        dynamic OutlierVisibility { get; set; }
    }

    public interface IHaveAllDataPointsVisibility : IResourceInterface
    {
        dynamic AllDataPointsVisibility { get; set; }
    }

    public interface IHaveFillStyle : IResourceInterface
    {
        dynamic FillStyle { get; set; }
    }

    public interface IHaveSourceSheetControlId : IResourceInterface
    {
        dynamic SourceSheetControlId { get; set; }
    }

    public interface IHaveSortIconVisibility : IResourceInterface
    {
        dynamic SortIconVisibility { get; set; }
    }

    public interface IHaveColorFillType : IResourceInterface
    {
        dynamic ColorFillType { get; set; }
    }

    public interface IHaveComparisonMethod : IResourceInterface
    {
        dynamic ComparisonMethod { get; set; }
    }

    public interface IHaveUnicodeIcon : IResourceInterface
    {
        dynamic UnicodeIcon { get; set; }
    }

    public interface IHaveIconDisplayOption : IResourceInterface
    {
        dynamic IconDisplayOption { get; set; }
    }

    public interface IHaveIconSetType : IResourceInterface
    {
        dynamic IconSetType { get; set; }
    }

    public interface IHaveMeasureFieldId : IResourceInterface
    {
        dynamic MeasureFieldId { get; set; }
    }

    public interface IHaveQuickSightAnalysisTypesNegativeValueConfigurationNegativeValueConfiguration : IResourceInterface
    {
        Humidifier.QuickSight.AnalysisTypes.NegativeValueConfiguration NegativeValueConfiguration { get; set; }
    }

    public interface IHaveQuickSightAnalysisTypesDecimalPlacesConfigurationDecimalPlacesConfiguration : IResourceInterface
    {
        Humidifier.QuickSight.AnalysisTypes.DecimalPlacesConfiguration DecimalPlacesConfiguration { get; set; }
    }

    public interface IHaveQuickSightAnalysisTypesNumericSeparatorConfigurationSeparatorConfiguration : IResourceInterface
    {
        Humidifier.QuickSight.AnalysisTypes.NumericSeparatorConfiguration SeparatorConfiguration { get; set; }
    }

    public interface IHaveURLTemplate : IResourceInterface
    {
        dynamic URLTemplate { get; set; }
    }

    public interface IHaveURLTarget : IResourceInterface
    {
        dynamic URLTarget { get; set; }
    }

    public interface IHaveSpecialValue : IResourceInterface
    {
        dynamic SpecialValue { get; set; }
    }

    public interface IHaveContentUrl : IResourceInterface
    {
        dynamic ContentUrl { get; set; }
    }

    public interface IHaveImageScaling : IResourceInterface
    {
        dynamic ImageScaling { get; set; }
    }

    public interface IHaveCategoryValue : IResourceInterface
    {
        dynamic CategoryValue { get; set; }
    }

    public interface IHaveNarrative : IResourceInterface
    {
        dynamic Narrative { get; set; }
    }

    public interface IHaveDoubleListOfDecimalValues : IResourceInterface
    {
        List<double> DecimalValues { get; set; }
    }

    public interface IHaveDoubleListOfIntegerValues : IResourceInterface
    {
        List<double> IntegerValues { get; set; }
    }

    public interface IHaveDateTimeValues : IResourceInterface
    {
        dynamic DateTimeValues { get; set; }
    }

    public interface IHaveIncludeNullValue : IResourceInterface
    {
        dynamic IncludeNullValue { get; set; }
    }

    public interface IHavePositiveColor : IResourceInterface
    {
        dynamic PositiveColor { get; set; }
    }

    public interface IHaveNegativeColor : IResourceInterface
    {
        dynamic NegativeColor { get; set; }
    }

    public interface IHaveLabelContent : IResourceInterface
    {
        dynamic LabelContent { get; set; }
    }

    public interface IHaveOverlap : IResourceInterface
    {
        dynamic Overlap { get; set; }
    }

    public interface IHavePivotTableDataPathType : IResourceInterface
    {
        dynamic PivotTableDataPathType { get; set; }
    }

    public interface IHaveDataSetPlaceholder : IResourceInterface
    {
        dynamic DataSetPlaceholder { get; set; }
    }

    public interface IHaveMissingDateVisibility : IResourceInterface
    {
        dynamic MissingDateVisibility { get; set; }
    }

    public interface IHaveDateGranularity : IResourceInterface
    {
        dynamic DateGranularity { get; set; }
    }

    public interface IHaveQuickSightAnalysisTypesRollingDateConfigurationRollingDate : IResourceInterface
    {
        Humidifier.QuickSight.AnalysisTypes.RollingDateConfiguration RollingDate { get; set; }
    }

    public interface IHaveListOfQuickSightAnalysisTypesDrillDownFilterDrillDownFilters : IResourceInterface
    {
        List<Humidifier.QuickSight.AnalysisTypes.DrillDownFilter> DrillDownFilters { get; set; }
    }

    public interface IHaveDecimalPlaces : IResourceInterface
    {
        dynamic DecimalPlaces { get; set; }
    }

    public interface IHaveQuickSightAnalysisTypesDateTimePickerControlDisplayOptionsDisplayOptions : IResourceInterface
    {
        Humidifier.QuickSight.AnalysisTypes.DateTimePickerControlDisplayOptions DisplayOptions { get; set; }
    }

    public interface IHaveQuickSightAnalysisTypesDropDownControlDisplayOptionsDisplayOptions : IResourceInterface
    {
        Humidifier.QuickSight.AnalysisTypes.DropDownControlDisplayOptions DisplayOptions { get; set; }
    }

    public interface IHaveQuickSightAnalysisTypesListControlDisplayOptionsDisplayOptions : IResourceInterface
    {
        Humidifier.QuickSight.AnalysisTypes.ListControlDisplayOptions DisplayOptions { get; set; }
    }

    public interface IHaveSheetContentType : IResourceInterface
    {
        dynamic SheetContentType { get; set; }
    }

    public interface IHaveQuickSightAnalysisTypesSliderControlDisplayOptionsDisplayOptions : IResourceInterface
    {
        Humidifier.QuickSight.AnalysisTypes.SliderControlDisplayOptions DisplayOptions { get; set; }
    }

    public interface IHaveQuickSightAnalysisTypesTextAreaControlDisplayOptionsDisplayOptions : IResourceInterface
    {
        Humidifier.QuickSight.AnalysisTypes.TextAreaControlDisplayOptions DisplayOptions { get; set; }
    }

    public interface IHaveQuickSightAnalysisTypesTextFieldControlDisplayOptionsDisplayOptions : IResourceInterface
    {
        Humidifier.QuickSight.AnalysisTypes.TextFieldControlDisplayOptions DisplayOptions { get; set; }
    }

    public interface IHaveSelectAllValueOptions : IResourceInterface
    {
        dynamic SelectAllValueOptions { get; set; }
    }

    public interface IHaveSourceField : IResourceInterface
    {
        dynamic SourceField { get; set; }
    }

    public interface IHaveLabelVisibility : IResourceInterface
    {
        dynamic LabelVisibility { get; set; }
    }

    public interface IHaveAggregationVisibility : IResourceInterface
    {
        dynamic AggregationVisibility { get; set; }
    }

    public interface IHaveTooltipTitleType : IResourceInterface
    {
        dynamic TooltipTitleType { get; set; }
    }

    public interface IHaveCrossDataset : IResourceInterface
    {
        dynamic CrossDataset { get; set; }
    }

    public interface IHaveFilterGroupId : IResourceInterface
    {
        dynamic FilterGroupId { get; set; }
    }

    public interface IHaveSelectedFields : IResourceInterface
    {
        dynamic SelectedFields { get; set; }
    }

    public interface IHaveSelectedFieldOptions : IResourceInterface
    {
        dynamic SelectedFieldOptions { get; set; }
    }

    public interface IHaveAllSheets : IResourceInterface
    {
        dynamic AllSheets { get; set; }
    }

    public interface IHaveFontStyle : IResourceInterface
    {
        dynamic FontStyle { get; set; }
    }

    public interface IHaveFontDecoration : IResourceInterface
    {
        dynamic FontDecoration { get; set; }
    }

    public interface IHaveRelative : IResourceInterface
    {
        dynamic Relative { get; set; }
    }

    public interface IHaveCustomSeasonalityValue : IResourceInterface
    {
        dynamic CustomSeasonalityValue { get; set; }
    }

    public interface IHaveYAxisLocation : IResourceInterface
    {
        dynamic YAxisLocation { get; set; }
    }

    public interface IHaveXAxisLocation : IResourceInterface
    {
        dynamic XAxisLocation { get; set; }
    }

    public interface IHaveMeasureDataLabelStyle : IResourceInterface
    {
        dynamic MeasureDataLabelStyle { get; set; }
    }

    public interface IHaveWest : IResourceInterface
    {
        dynamic West { get; set; }
    }

    public interface IHaveSouth : IResourceInterface
    {
        dynamic South { get; set; }
    }

    public interface IHaveNorth : IResourceInterface
    {
        dynamic North { get; set; }
    }

    public interface IHaveEast : IResourceInterface
    {
        dynamic East { get; set; }
    }

    public interface IHaveBaseMapStyle : IResourceInterface
    {
        dynamic BaseMapStyle { get; set; }
    }

    public interface IHaveSelectedPointStyle : IResourceInterface
    {
        dynamic SelectedPointStyle { get; set; }
    }

    public interface IHaveMapZoomMode : IResourceInterface
    {
        dynamic MapZoomMode { get; set; }
    }

    public interface IHaveGradientOffset : IResourceInterface
    {
        dynamic GradientOffset { get; set; }
    }

    public interface IHaveColumnSpan : IResourceInterface
    {
        dynamic ColumnSpan { get; set; }
    }

    public interface IHaveColumnIndex : IResourceInterface
    {
        dynamic ColumnIndex { get; set; }
    }

    public interface IHaveRowIndex : IResourceInterface
    {
        dynamic RowIndex { get; set; }
    }

    public interface IHaveRowSpan : IResourceInterface
    {
        dynamic RowSpan { get; set; }
    }

    public interface IHaveResizeOption : IResourceInterface
    {
        dynamic ResizeOption { get; set; }
    }

    public interface IHavePeriodSize : IResourceInterface
    {
        dynamic PeriodSize { get; set; }
    }

    public interface IHaveSelectedBinType : IResourceInterface
    {
        dynamic SelectedBinType { get; set; }
    }

    public interface IHaveQuickSightAnalysisTypesChartAxisLabelOptionsXAxisLabelOptions : IResourceInterface
    {
        Humidifier.QuickSight.AnalysisTypes.ChartAxisLabelOptions XAxisLabelOptions { get; set; }
    }

    public interface IHaveQuickSightAnalysisTypesAxisDisplayOptionsXAxisDisplayOptions : IResourceInterface
    {
        Humidifier.QuickSight.AnalysisTypes.AxisDisplayOptions XAxisDisplayOptions { get; set; }
    }

    public interface IHaveItemsLimit : IResourceInterface
    {
        dynamic ItemsLimit { get; set; }
    }

    public interface IHaveOtherCategories : IResourceInterface
    {
        dynamic OtherCategories { get; set; }
    }

    public interface IHaveLineInterpolation : IResourceInterface
    {
        dynamic LineInterpolation { get; set; }
    }

    public interface IHaveLineStyle : IResourceInterface
    {
        dynamic LineStyle { get; set; }
    }

    public interface IHaveLineVisibility : IResourceInterface
    {
        dynamic LineVisibility { get; set; }
    }

    public interface IHaveLineWidth : IResourceInterface
    {
        dynamic LineWidth { get; set; }
    }

    public interface IHaveMarkerShape : IResourceInterface
    {
        dynamic MarkerShape { get; set; }
    }

    public interface IHaveMarkerSize : IResourceInterface
    {
        dynamic MarkerSize { get; set; }
    }

    public interface IHaveMarkerVisibility : IResourceInterface
    {
        dynamic MarkerVisibility { get; set; }
    }

    public interface IHaveMarkerColor : IResourceInterface
    {
        dynamic MarkerColor { get; set; }
    }

    public interface IHaveTargetSheetId : IResourceInterface
    {
        dynamic TargetSheetId { get; set; }
    }

    public interface IHaveDataSetParameterName : IResourceInterface
    {
        dynamic DataSetParameterName { get; set; }
    }

    public interface IHaveTreatmentOption : IResourceInterface
    {
        dynamic TreatmentOption { get; set; }
    }

    public interface IHaveDisplayMode : IResourceInterface
    {
        dynamic DisplayMode { get; set; }
    }

    public interface IHaveIncludeInnerSet : IResourceInterface
    {
        dynamic IncludeInnerSet { get; set; }
    }

    public interface IHaveNullString : IResourceInterface
    {
        dynamic NullString { get; set; }
    }

    public interface IHaveSimpleNumericalAggregation : IResourceInterface
    {
        dynamic SimpleNumericalAggregation { get; set; }
    }

    public interface IHavePageSize : IResourceInterface
    {
        dynamic PageSize { get; set; }
    }

    public interface IHaveBorderThickness : IResourceInterface
    {
        dynamic BorderThickness { get; set; }
    }

    public interface IHaveBorderStyle : IResourceInterface
    {
        dynamic BorderStyle { get; set; }
    }

    public interface IHaveGutterSpacing : IResourceInterface
    {
        dynamic GutterSpacing { get; set; }
    }

    public interface IHaveBackgroundVisibility : IResourceInterface
    {
        dynamic BackgroundVisibility { get; set; }
    }

    public interface IHaveBorderVisibility : IResourceInterface
    {
        dynamic BorderVisibility { get; set; }
    }

    public interface IHaveBorderColor : IResourceInterface
    {
        dynamic BorderColor { get; set; }
    }

    public interface IHaveGutterVisibility : IResourceInterface
    {
        dynamic GutterVisibility { get; set; }
    }

    public interface IHavePercentileValue : IResourceInterface
    {
        dynamic PercentileValue { get; set; }
    }

    public interface IHavePeriodTimeGranularity : IResourceInterface
    {
        dynamic PeriodTimeGranularity { get; set; }
    }

    public interface IHaveCollapsedRowDimensionsVisibility : IResourceInterface
    {
        dynamic CollapsedRowDimensionsVisibility { get; set; }
    }

    public interface IHaveRowsLayout : IResourceInterface
    {
        dynamic RowsLayout { get; set; }
    }

    public interface IHaveMetricPlacement : IResourceInterface
    {
        dynamic MetricPlacement { get; set; }
    }

    public interface IHaveDefaultCellWidth : IResourceInterface
    {
        dynamic DefaultCellWidth { get; set; }
    }

    public interface IHaveColumnNamesVisibility : IResourceInterface
    {
        dynamic ColumnNamesVisibility { get; set; }
    }

    public interface IHaveSingleMetricVisibility : IResourceInterface
    {
        dynamic SingleMetricVisibility { get; set; }
    }

    public interface IHaveToggleButtonsVisibility : IResourceInterface
    {
        dynamic ToggleButtonsVisibility { get; set; }
    }

    public interface IHaveQuickSightAnalysisTypesTableCellStyleTotalCellStyle : IResourceInterface
    {
        Humidifier.QuickSight.AnalysisTypes.TableCellStyle TotalCellStyle { get; set; }
    }

    public interface IHaveAxesRangeScale : IResourceInterface
    {
        dynamic AxesRangeScale { get; set; }
    }

    public interface IHaveAlternateBandColorsVisibility : IResourceInterface
    {
        dynamic AlternateBandColorsVisibility { get; set; }
    }

    public interface IHaveStartAngle : IResourceInterface
    {
        dynamic StartAngle { get; set; }
    }

    public interface IHaveAlternateBandOddColor : IResourceInterface
    {
        dynamic AlternateBandOddColor { get; set; }
    }

    public interface IHaveAlternateBandEvenColor : IResourceInterface
    {
        dynamic AlternateBandEvenColor { get; set; }
    }

    public interface IHaveSeriesType : IResourceInterface
    {
        dynamic SeriesType { get; set; }
    }

    public interface IHaveHorizontalPosition : IResourceInterface
    {
        dynamic HorizontalPosition { get; set; }
    }

    public interface IHaveVerticalPosition : IResourceInterface
    {
        dynamic VerticalPosition { get; set; }
    }

    public interface IHaveRelativePosition : IResourceInterface
    {
        dynamic RelativePosition { get; set; }
    }

    public interface IHaveRelativeDateValue : IResourceInterface
    {
        dynamic RelativeDateValue { get; set; }
    }

    public interface IHaveRelativeDateType : IResourceInterface
    {
        dynamic RelativeDateType { get; set; }
    }

    public interface IHaveMinimumGranularity : IResourceInterface
    {
        dynamic MinimumGranularity { get; set; }
    }

    public interface IHaveUsePrimaryBackgroundColor : IResourceInterface
    {
        dynamic UsePrimaryBackgroundColor { get; set; }
    }

    public interface IHaveRowAlternateColors : IResourceInterface
    {
        dynamic RowAlternateColors { get; set; }
    }

    public interface IHaveTargetVisualOptions : IResourceInterface
    {
        dynamic TargetVisualOptions { get; set; }
    }

    public interface IHaveTargetVisuals : IResourceInterface
    {
        dynamic TargetVisuals { get; set; }
    }

    public interface IHaveListOfQuickSightAnalysisTypesMeasureFieldSize : IResourceInterface
    {
        List<Humidifier.QuickSight.AnalysisTypes.MeasureField> Size { get; set; }
    }

    public interface IHavePaperSize : IResourceInterface
    {
        dynamic PaperSize { get; set; }
    }

    public interface IHavePaperOrientation : IResourceInterface
    {
        dynamic PaperOrientation { get; set; }
    }

    public interface IHaveDestinationParameterName : IResourceInterface
    {
        dynamic DestinationParameterName { get; set; }
    }

    public interface IHaveQuickSightAnalysisTypesConditionalFormattingColorBackgroundColor : IResourceInterface
    {
        Humidifier.QuickSight.AnalysisTypes.ConditionalFormattingColor BackgroundColor { get; set; }
    }

    public interface IHaveInfoIconText : IResourceInterface
    {
        dynamic InfoIconText { get; set; }
    }

    public interface IHaveSheetTextBoxId : IResourceInterface
    {
        dynamic SheetTextBoxId { get; set; }
    }

    public interface IHaveVisualIds : IResourceInterface
    {
        dynamic VisualIds { get; set; }
    }

    public interface IHaveMaxVisibleRows : IResourceInterface
    {
        dynamic MaxVisibleRows { get; set; }
    }

    public interface IHaveMaxVisibleColumns : IResourceInterface
    {
        dynamic MaxVisibleColumns { get; set; }
    }

    public interface IHaveRight : IResourceInterface
    {
        dynamic Right { get; set; }
    }

    public interface IHaveBottom : IResourceInterface
    {
        dynamic Bottom { get; set; }
    }

    public interface IHaveFieldLevel : IResourceInterface
    {
        dynamic FieldLevel { get; set; }
    }

    public interface IHaveThickness : IResourceInterface
    {
        dynamic Thickness { get; set; }
    }

    public interface IHaveTableCellImageScalingConfiguration : IResourceInterface
    {
        dynamic TableCellImageScalingConfiguration { get; set; }
    }

    public interface IHaveVerticalTextAlignment : IResourceInterface
    {
        dynamic VerticalTextAlignment { get; set; }
    }

    public interface IHaveTextWrap : IResourceInterface
    {
        dynamic TextWrap { get; set; }
    }

    public interface IHavePinnedLeftFields : IResourceInterface
    {
        dynamic PinnedLeftFields { get; set; }
    }

    public interface IHaveCellType : IResourceInterface
    {
        dynamic CellType { get; set; }
    }

    public interface IHaveRangeMinimum : IResourceInterface
    {
        dynamic RangeMinimum { get; set; }
    }

    public interface IHaveRangeMaximum : IResourceInterface
    {
        dynamic RangeMaximum { get; set; }
    }

    public interface IHaveSelectedTooltipType : IResourceInterface
    {
        dynamic SelectedTooltipType { get; set; }
    }

    public interface IHaveQuickSightAnalysisTypesDimensionFieldCategory : IResourceInterface
    {
        Humidifier.QuickSight.AnalysisTypes.DimensionField Category { get; set; }
    }

    public interface IHaveMoverSize : IResourceInterface
    {
        dynamic MoverSize { get; set; }
    }

    public interface IHaveResultSize : IResourceInterface
    {
        dynamic ResultSize { get; set; }
    }

    public interface IHaveSimpleTotalAggregationFunction : IResourceInterface
    {
        dynamic SimpleTotalAggregationFunction { get; set; }
    }

    public interface IHaveTrigger : IResourceInterface
    {
        dynamic Trigger { get; set; }
    }

    public interface IHaveCustomActionId : IResourceInterface
    {
        dynamic CustomActionId { get; set; }
    }

    public interface IHaveChartColor : IResourceInterface
    {
        dynamic ChartColor { get; set; }
    }

    public interface IHaveNegativeBarColor : IResourceInterface
    {
        dynamic NegativeBarColor { get; set; }
    }

    public interface IHaveTotalBarColor : IResourceInterface
    {
        dynamic TotalBarColor { get; set; }
    }

    public interface IHavePositiveBarColor : IResourceInterface
    {
        dynamic PositiveBarColor { get; set; }
    }

    public interface IHaveTotalBarLabel : IResourceInterface
    {
        dynamic TotalBarLabel { get; set; }
    }

    public interface IHaveDate : IResourceInterface
    {
        dynamic Date { get; set; }
    }

    public interface IHaveWordOrientation : IResourceInterface
    {
        dynamic WordOrientation { get; set; }
    }

    public interface IHaveWordScaling : IResourceInterface
    {
        dynamic WordScaling { get; set; }
    }

    public interface IHaveCloudLayout : IResourceInterface
    {
        dynamic CloudLayout { get; set; }
    }

    public interface IHaveMaximumStringLength : IResourceInterface
    {
        dynamic MaximumStringLength { get; set; }
    }

    public interface IHaveWordCasing : IResourceInterface
    {
        dynamic WordCasing { get; set; }
    }

    public interface IHaveWordPadding : IResourceInterface
    {
        dynamic WordPadding { get; set; }
    }

    public interface IHaveYAxis : IResourceInterface
    {
        dynamic YAxis { get; set; }
    }

    public interface IHaveListOfQuickSightDashboardTypesDimensionFieldSmallMultiples : IResourceInterface
    {
        List<Humidifier.QuickSight.DashboardTypes.DimensionField> SmallMultiples { get; set; }
    }

    public interface IHaveQuickSightDashboardTypesSmallMultiplesOptionsSmallMultiplesOptions : IResourceInterface
    {
        Humidifier.QuickSight.DashboardTypes.SmallMultiplesOptions SmallMultiplesOptions { get; set; }
    }

    public interface IHaveQuickSightDashboardTypesChartAxisLabelOptionsValueLabelOptions : IResourceInterface
    {
        Humidifier.QuickSight.DashboardTypes.ChartAxisLabelOptions ValueLabelOptions { get; set; }
    }

    public interface IHaveListOfQuickSightDashboardTypesContributionAnalysisDefaultContributionAnalysisDefaults : IResourceInterface
    {
        List<Humidifier.QuickSight.DashboardTypes.ContributionAnalysisDefault> ContributionAnalysisDefaults { get; set; }
    }

    public interface IHaveListOfQuickSightDashboardTypesFieldSortOptionsSmallMultiplesSort : IResourceInterface
    {
        List<Humidifier.QuickSight.DashboardTypes.FieldSortOptions> SmallMultiplesSort { get; set; }
    }

    public interface IHaveListOfQuickSightDashboardTypesFieldSortOptionsColorSort : IResourceInterface
    {
        List<Humidifier.QuickSight.DashboardTypes.FieldSortOptions> ColorSort { get; set; }
    }

    public interface IHaveQuickSightDashboardTypesItemsLimitConfigurationColorItemsLimit : IResourceInterface
    {
        Humidifier.QuickSight.DashboardTypes.ItemsLimitConfiguration ColorItemsLimit { get; set; }
    }

    public interface IHaveQuickSightDashboardTypesItemsLimitConfigurationSmallMultiplesLimitConfiguration : IResourceInterface
    {
        Humidifier.QuickSight.DashboardTypes.ItemsLimitConfiguration SmallMultiplesLimitConfiguration { get; set; }
    }

    public interface IHaveListOfQuickSightDashboardTypesDimensionFieldGroupBy : IResourceInterface
    {
        List<Humidifier.QuickSight.DashboardTypes.DimensionField> GroupBy { get; set; }
    }

    public interface IHaveQuickSightDashboardTypesAxisDisplayOptionsPrimaryYAxisDisplayOptions : IResourceInterface
    {
        Humidifier.QuickSight.DashboardTypes.AxisDisplayOptions PrimaryYAxisDisplayOptions { get; set; }
    }

    public interface IHaveQuickSightDashboardTypesNegativeValueConfigurationNegativeValueConfiguration : IResourceInterface
    {
        Humidifier.QuickSight.DashboardTypes.NegativeValueConfiguration NegativeValueConfiguration { get; set; }
    }

    public interface IHaveQuickSightDashboardTypesDecimalPlacesConfigurationDecimalPlacesConfiguration : IResourceInterface
    {
        Humidifier.QuickSight.DashboardTypes.DecimalPlacesConfiguration DecimalPlacesConfiguration { get; set; }
    }

    public interface IHaveQuickSightDashboardTypesNumericSeparatorConfigurationSeparatorConfiguration : IResourceInterface
    {
        Humidifier.QuickSight.DashboardTypes.NumericSeparatorConfiguration SeparatorConfiguration { get; set; }
    }

    public interface IHaveQuickSightDashboardTypesRollingDateConfigurationRollingDate : IResourceInterface
    {
        Humidifier.QuickSight.DashboardTypes.RollingDateConfiguration RollingDate { get; set; }
    }

    public interface IHaveListOfQuickSightDashboardTypesDrillDownFilterDrillDownFilters : IResourceInterface
    {
        List<Humidifier.QuickSight.DashboardTypes.DrillDownFilter> DrillDownFilters { get; set; }
    }

    public interface IHaveQuickSightDashboardTypesDateTimePickerControlDisplayOptionsDisplayOptions : IResourceInterface
    {
        Humidifier.QuickSight.DashboardTypes.DateTimePickerControlDisplayOptions DisplayOptions { get; set; }
    }

    public interface IHaveQuickSightDashboardTypesDropDownControlDisplayOptionsDisplayOptions : IResourceInterface
    {
        Humidifier.QuickSight.DashboardTypes.DropDownControlDisplayOptions DisplayOptions { get; set; }
    }

    public interface IHaveQuickSightDashboardTypesListControlDisplayOptionsDisplayOptions : IResourceInterface
    {
        Humidifier.QuickSight.DashboardTypes.ListControlDisplayOptions DisplayOptions { get; set; }
    }

    public interface IHaveQuickSightDashboardTypesSliderControlDisplayOptionsDisplayOptions : IResourceInterface
    {
        Humidifier.QuickSight.DashboardTypes.SliderControlDisplayOptions DisplayOptions { get; set; }
    }

    public interface IHaveQuickSightDashboardTypesTextAreaControlDisplayOptionsDisplayOptions : IResourceInterface
    {
        Humidifier.QuickSight.DashboardTypes.TextAreaControlDisplayOptions DisplayOptions { get; set; }
    }

    public interface IHaveQuickSightDashboardTypesTextFieldControlDisplayOptionsDisplayOptions : IResourceInterface
    {
        Humidifier.QuickSight.DashboardTypes.TextFieldControlDisplayOptions DisplayOptions { get; set; }
    }

    public interface IHaveQuickSightDashboardTypesChartAxisLabelOptionsXAxisLabelOptions : IResourceInterface
    {
        Humidifier.QuickSight.DashboardTypes.ChartAxisLabelOptions XAxisLabelOptions { get; set; }
    }

    public interface IHaveQuickSightDashboardTypesAxisDisplayOptionsXAxisDisplayOptions : IResourceInterface
    {
        Humidifier.QuickSight.DashboardTypes.AxisDisplayOptions XAxisDisplayOptions { get; set; }
    }

    public interface IHaveQuickSightDashboardTypesTableCellStyleTotalCellStyle : IResourceInterface
    {
        Humidifier.QuickSight.DashboardTypes.TableCellStyle TotalCellStyle { get; set; }
    }

    public interface IHaveListOfQuickSightDashboardTypesMeasureFieldSize : IResourceInterface
    {
        List<Humidifier.QuickSight.DashboardTypes.MeasureField> Size { get; set; }
    }

    public interface IHaveQuickSightDashboardTypesConditionalFormattingColorBackgroundColor : IResourceInterface
    {
        Humidifier.QuickSight.DashboardTypes.ConditionalFormattingColor BackgroundColor { get; set; }
    }

    public interface IHaveQuickSightDashboardTypesDimensionFieldCategory : IResourceInterface
    {
        Humidifier.QuickSight.DashboardTypes.DimensionField Category { get; set; }
    }

    public interface IHaveDataSourceArn : IResourceInterface
    {
        dynamic DataSourceArn { get; set; }
    }

    public interface IHaveListOfQuickSightTemplateTypesDimensionFieldSmallMultiples : IResourceInterface
    {
        List<Humidifier.QuickSight.TemplateTypes.DimensionField> SmallMultiples { get; set; }
    }

    public interface IHaveQuickSightTemplateTypesSmallMultiplesOptionsSmallMultiplesOptions : IResourceInterface
    {
        Humidifier.QuickSight.TemplateTypes.SmallMultiplesOptions SmallMultiplesOptions { get; set; }
    }

    public interface IHaveQuickSightTemplateTypesChartAxisLabelOptionsValueLabelOptions : IResourceInterface
    {
        Humidifier.QuickSight.TemplateTypes.ChartAxisLabelOptions ValueLabelOptions { get; set; }
    }

    public interface IHaveListOfQuickSightTemplateTypesContributionAnalysisDefaultContributionAnalysisDefaults : IResourceInterface
    {
        List<Humidifier.QuickSight.TemplateTypes.ContributionAnalysisDefault> ContributionAnalysisDefaults { get; set; }
    }

    public interface IHaveListOfQuickSightTemplateTypesFieldSortOptionsSmallMultiplesSort : IResourceInterface
    {
        List<Humidifier.QuickSight.TemplateTypes.FieldSortOptions> SmallMultiplesSort { get; set; }
    }

    public interface IHaveListOfQuickSightTemplateTypesFieldSortOptionsColorSort : IResourceInterface
    {
        List<Humidifier.QuickSight.TemplateTypes.FieldSortOptions> ColorSort { get; set; }
    }

    public interface IHaveQuickSightTemplateTypesItemsLimitConfigurationColorItemsLimit : IResourceInterface
    {
        Humidifier.QuickSight.TemplateTypes.ItemsLimitConfiguration ColorItemsLimit { get; set; }
    }

    public interface IHaveQuickSightTemplateTypesItemsLimitConfigurationSmallMultiplesLimitConfiguration : IResourceInterface
    {
        Humidifier.QuickSight.TemplateTypes.ItemsLimitConfiguration SmallMultiplesLimitConfiguration { get; set; }
    }

    public interface IHaveListOfQuickSightTemplateTypesDimensionFieldGroupBy : IResourceInterface
    {
        List<Humidifier.QuickSight.TemplateTypes.DimensionField> GroupBy { get; set; }
    }

    public interface IHaveQuickSightTemplateTypesAxisDisplayOptionsPrimaryYAxisDisplayOptions : IResourceInterface
    {
        Humidifier.QuickSight.TemplateTypes.AxisDisplayOptions PrimaryYAxisDisplayOptions { get; set; }
    }

    public interface IHaveQuickSightTemplateTypesNegativeValueConfigurationNegativeValueConfiguration : IResourceInterface
    {
        Humidifier.QuickSight.TemplateTypes.NegativeValueConfiguration NegativeValueConfiguration { get; set; }
    }

    public interface IHaveQuickSightTemplateTypesDecimalPlacesConfigurationDecimalPlacesConfiguration : IResourceInterface
    {
        Humidifier.QuickSight.TemplateTypes.DecimalPlacesConfiguration DecimalPlacesConfiguration { get; set; }
    }

    public interface IHaveQuickSightTemplateTypesNumericSeparatorConfigurationSeparatorConfiguration : IResourceInterface
    {
        Humidifier.QuickSight.TemplateTypes.NumericSeparatorConfiguration SeparatorConfiguration { get; set; }
    }

    public interface IHaveQuickSightTemplateTypesRollingDateConfigurationRollingDate : IResourceInterface
    {
        Humidifier.QuickSight.TemplateTypes.RollingDateConfiguration RollingDate { get; set; }
    }

    public interface IHaveListOfQuickSightTemplateTypesDrillDownFilterDrillDownFilters : IResourceInterface
    {
        List<Humidifier.QuickSight.TemplateTypes.DrillDownFilter> DrillDownFilters { get; set; }
    }

    public interface IHaveQuickSightTemplateTypesDateTimePickerControlDisplayOptionsDisplayOptions : IResourceInterface
    {
        Humidifier.QuickSight.TemplateTypes.DateTimePickerControlDisplayOptions DisplayOptions { get; set; }
    }

    public interface IHaveQuickSightTemplateTypesDropDownControlDisplayOptionsDisplayOptions : IResourceInterface
    {
        Humidifier.QuickSight.TemplateTypes.DropDownControlDisplayOptions DisplayOptions { get; set; }
    }

    public interface IHaveQuickSightTemplateTypesListControlDisplayOptionsDisplayOptions : IResourceInterface
    {
        Humidifier.QuickSight.TemplateTypes.ListControlDisplayOptions DisplayOptions { get; set; }
    }

    public interface IHaveQuickSightTemplateTypesSliderControlDisplayOptionsDisplayOptions : IResourceInterface
    {
        Humidifier.QuickSight.TemplateTypes.SliderControlDisplayOptions DisplayOptions { get; set; }
    }

    public interface IHaveQuickSightTemplateTypesTextAreaControlDisplayOptionsDisplayOptions : IResourceInterface
    {
        Humidifier.QuickSight.TemplateTypes.TextAreaControlDisplayOptions DisplayOptions { get; set; }
    }

    public interface IHaveQuickSightTemplateTypesTextFieldControlDisplayOptionsDisplayOptions : IResourceInterface
    {
        Humidifier.QuickSight.TemplateTypes.TextFieldControlDisplayOptions DisplayOptions { get; set; }
    }

    public interface IHaveQuickSightTemplateTypesChartAxisLabelOptionsXAxisLabelOptions : IResourceInterface
    {
        Humidifier.QuickSight.TemplateTypes.ChartAxisLabelOptions XAxisLabelOptions { get; set; }
    }

    public interface IHaveQuickSightTemplateTypesAxisDisplayOptionsXAxisDisplayOptions : IResourceInterface
    {
        Humidifier.QuickSight.TemplateTypes.AxisDisplayOptions XAxisDisplayOptions { get; set; }
    }

    public interface IHaveQuickSightTemplateTypesTableCellStyleTotalCellStyle : IResourceInterface
    {
        Humidifier.QuickSight.TemplateTypes.TableCellStyle TotalCellStyle { get; set; }
    }

    public interface IHaveListOfQuickSightTemplateTypesMeasureFieldSize : IResourceInterface
    {
        List<Humidifier.QuickSight.TemplateTypes.MeasureField> Size { get; set; }
    }

    public interface IHaveQuickSightTemplateTypesConditionalFormattingColorBackgroundColor : IResourceInterface
    {
        Humidifier.QuickSight.TemplateTypes.ConditionalFormattingColor BackgroundColor { get; set; }
    }

    public interface IHaveQuickSightTemplateTypesDimensionFieldCategory : IResourceInterface
    {
        Humidifier.QuickSight.TemplateTypes.DimensionField Category { get; set; }
    }

    public interface IHaveShow : IResourceInterface
    {
        dynamic Show { get; set; }
    }

    public interface IHaveConstantType : IResourceInterface
    {
        dynamic ConstantType { get; set; }
    }

    public interface IHaveSearchString : IResourceInterface
    {
        dynamic SearchString { get; set; }
    }

    public interface IHaveFailureThreshold : IResourceInterface
    {
        dynamic FailureThreshold { get; set; }
    }

    public interface IHaveS3BucketTypesNotificationFilterFilter : IResourceInterface
    {
        Humidifier.S3.BucketTypes.NotificationFilter Filter { get; set; }
    }

    public interface IHaveS3StorageLensGroupTypesMatchObjectAgeMatchObjectAge : IResourceInterface
    {
        Humidifier.S3.StorageLensGroupTypes.MatchObjectAge MatchObjectAge { get; set; }
    }

    public interface IHaveMatchAnyPrefix : IResourceInterface
    {
        dynamic MatchAnyPrefix { get; set; }
    }

    public interface IHaveMatchAnyTag : IResourceInterface
    {
        List<Tag> MatchAnyTag { get; set; }
    }

    public interface IHaveMatchAnySuffix : IResourceInterface
    {
        dynamic MatchAnySuffix { get; set; }
    }

    public interface IHaveS3StorageLensGroupTypesMatchObjectSizeMatchObjectSize : IResourceInterface
    {
        Humidifier.S3.StorageLensGroupTypes.MatchObjectSize MatchObjectSize { get; set; }
    }

    public interface IHavePostAnalyticsProcessorSourceUri : IResourceInterface
    {
        dynamic PostAnalyticsProcessorSourceUri { get; set; }
    }

    public interface IHaveRecordPreprocessorSourceUri : IResourceInterface
    {
        dynamic RecordPreprocessorSourceUri { get; set; }
    }

    public interface IHaveImageVersionNumber : IResourceInterface
    {
        dynamic ImageVersionNumber { get; set; }
    }

    public interface IHaveIdleTimeoutInMinutes : IResourceInterface
    {
        dynamic IdleTimeoutInMinutes { get; set; }
    }

    public interface IHaveS3DataType : IResourceInterface
    {
        dynamic S3DataType { get; set; }
    }

    public interface IHaveNotes : IResourceInterface
    {
        dynamic Notes { get; set; }
    }

    public interface IHaveListOfSageMakerUserProfileTypesCustomImageCustomImages : IResourceInterface
    {
        List<Humidifier.SageMaker.UserProfileTypes.CustomImage> CustomImages { get; set; }
    }

    public interface IHaveDataId : IResourceInterface
    {
        dynamic DataId { get; set; }
    }

    public interface IHaveNegated : IResourceInterface
    {
        dynamic Negated { get; set; }
    }

    public interface IHaveUriPath : IResourceInterface
    {
        dynamic UriPath { get; set; }
    }

    public interface IHaveHTTPMethod : IResourceInterface
    {
        dynamic HTTPMethod { get; set; }
    }

    public interface IHaveWAFv2WebACLTypesFieldIdentifierUsernameField : IResourceInterface
    {
        Humidifier.WAFv2.WebACLTypes.FieldIdentifier UsernameField { get; set; }
    }

    public interface IHaveWAFv2WebACLTypesFieldIdentifierPasswordField : IResourceInterface
    {
        Humidifier.WAFv2.WebACLTypes.FieldIdentifier PasswordField { get; set; }
    }

    public interface IHavePayloadType : IResourceInterface
    {
        dynamic PayloadType { get; set; }
    }
}