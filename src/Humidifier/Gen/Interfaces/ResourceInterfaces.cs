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

    public interface IHaveId : IResourceInterface
    {
        dynamic Id { get; set; }
    }

    public interface IHaveKmsKeyId : IResourceInterface
    {
        dynamic KmsKeyId { get; set; }
    }

    public interface IHaveFieldId : IResourceInterface
    {
        dynamic FieldId { get; set; }
    }

    public interface IHaveVisualId : IResourceInterface
    {
        dynamic VisualId { get; set; }
    }

    public interface IHaveVisualContentAltText : IResourceInterface
    {
        dynamic VisualContentAltText { get; set; }
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

    public interface IHaveVersion : IResourceInterface
    {
        dynamic Version { get; set; }
    }

    public interface IHaveDatabaseName : IResourceInterface
    {
        dynamic DatabaseName { get; set; }
    }

    public interface IHaveExpression : IResourceInterface
    {
        dynamic Expression { get; set; }
    }

    public interface IHaveArn : IResourceInterface
    {
        dynamic Arn { get; set; }
    }

    public interface IHavePrefix : IResourceInterface
    {
        dynamic Prefix { get; set; }
    }

    public interface IHaveValues : IResourceInterface
    {
        dynamic Values { get; set; }
    }

    public interface IHaveBucketName : IResourceInterface
    {
        dynamic BucketName { get; set; }
    }

    public interface IHaveProtocol : IResourceInterface
    {
        dynamic Protocol { get; set; }
    }

    public interface IHaveMin : IResourceInterface
    {
        dynamic Min { get; set; }
    }

    public interface IHaveMax : IResourceInterface
    {
        dynamic Max { get; set; }
    }

    public interface IHaveInstanceType : IResourceInterface
    {
        dynamic InstanceType { get; set; }
    }

    public interface IHaveColor : IResourceInterface
    {
        dynamic Color { get; set; }
    }

    public interface IHaveVpcId : IResourceInterface
    {
        dynamic VpcId { get; set; }
    }

    public interface IHaveBucket : IResourceInterface
    {
        dynamic Bucket { get; set; }
    }

    public interface IHaveUnit : IResourceInterface
    {
        dynamic Unit { get; set; }
    }

    public interface IHavePath : IResourceInterface
    {
        dynamic Path { get; set; }
    }

    public interface IHaveTableName : IResourceInterface
    {
        dynamic TableName { get; set; }
    }

    public interface IHaveMetricName : IResourceInterface
    {
        dynamic MetricName { get; set; }
    }

    public interface IHaveAction : IResourceInterface
    {
        dynamic Action { get; set; }
    }

    public interface IHaveNamespace_ : IResourceInterface
    {
        dynamic Namespace_ { get; set; }
    }

    public interface IHaveDisplayName : IResourceInterface
    {
        dynamic DisplayName { get; set; }
    }

    public interface IHaveSource : IResourceInterface
    {
        dynamic Source { get; set; }
    }

    public interface IHaveAvailabilityZone : IResourceInterface
    {
        dynamic AvailabilityZone { get; set; }
    }

    public interface IHaveUrl : IResourceInterface
    {
        dynamic Url { get; set; }
    }

    public interface IHaveDynamicTags : IResourceInterface
    {
        dynamic Tags { get; set; }
    }

    public interface IHaveState : IResourceInterface
    {
        dynamic State { get; set; }
    }

    public interface IHavePriority : IResourceInterface
    {
        dynamic Priority { get; set; }
    }

    public interface IHaveDomainName : IResourceInterface
    {
        dynamic DomainName { get; set; }
    }

    public interface IHaveSubnetId : IResourceInterface
    {
        dynamic SubnetId { get; set; }
    }

    public interface IHaveKmsKeyArn : IResourceInterface
    {
        dynamic KmsKeyArn { get; set; }
    }

    public interface IHaveMode : IResourceInterface
    {
        dynamic Mode { get; set; }
    }

    public interface IHaveUsername : IResourceInterface
    {
        dynamic Username { get; set; }
    }

    public interface IHaveApplicationId : IResourceInterface
    {
        dynamic ApplicationId { get; set; }
    }

    public interface IHavePassword : IResourceInterface
    {
        dynamic Password { get; set; }
    }

    public interface IHaveComputationId : IResourceInterface
    {
        dynamic ComputationId { get; set; }
    }

    public interface IHaveCatalogId : IResourceInterface
    {
        dynamic CatalogId { get; set; }
    }

    public interface IHaveParameterName : IResourceInterface
    {
        dynamic ParameterName { get; set; }
    }

    public interface IHaveCertificateArn : IResourceInterface
    {
        dynamic CertificateArn { get; set; }
    }

    public interface IHaveS3Uri : IResourceInterface
    {
        dynamic S3Uri { get; set; }
    }

    public interface IHaveRegion : IResourceInterface
    {
        dynamic Region { get; set; }
    }

    public interface IHaveCustomLabel : IResourceInterface
    {
        dynamic CustomLabel { get; set; }
    }

    public interface IHavePolicyDocument : IResourceInterface
    {
        dynamic PolicyDocument { get; set; }
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

    public interface IHaveInstanceArn : IResourceInterface
    {
        dynamic InstanceArn { get; set; }
    }

    public interface IHaveTimeGranularity : IResourceInterface
    {
        dynamic TimeGranularity { get; set; }
    }

    public interface IHaveResourceType : IResourceInterface
    {
        dynamic ResourceType { get; set; }
    }

    public interface IHaveQuickSightAnalysisTypesColumnIdentifierColumn : IResourceInterface
    {
        Humidifier.QuickSight.AnalysisTypes.ColumnIdentifier Column { get; set; }
    }

    public interface IHaveQuickSightAnalysisTypesVisualSubtitleLabelOptionsSubtitle : IResourceInterface
    {
        Humidifier.QuickSight.AnalysisTypes.VisualSubtitleLabelOptions Subtitle { get; set; }
    }

    public interface IHaveQuickSightAnalysisTypesVisualTitleLabelOptionsTitle : IResourceInterface
    {
        Humidifier.QuickSight.AnalysisTypes.VisualTitleLabelOptions Title { get; set; }
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

    public interface IHaveQuickSightDashboardTypesVisualSubtitleLabelOptionsSubtitle : IResourceInterface
    {
        Humidifier.QuickSight.DashboardTypes.VisualSubtitleLabelOptions Subtitle { get; set; }
    }

    public interface IHaveQuickSightDashboardTypesVisualTitleLabelOptionsTitle : IResourceInterface
    {
        Humidifier.QuickSight.DashboardTypes.VisualTitleLabelOptions Title { get; set; }
    }

    public interface IHaveQuickSightTemplateTypesColumnIdentifierColumn : IResourceInterface
    {
        Humidifier.QuickSight.TemplateTypes.ColumnIdentifier Column { get; set; }
    }

    public interface IHaveSecretArn : IResourceInterface
    {
        dynamic SecretArn { get; set; }
    }

    public interface IHaveListOfQuickSightAnalysisTypesVisualCustomActionActions : IResourceInterface
    {
        List<Humidifier.QuickSight.AnalysisTypes.VisualCustomAction> Actions { get; set; }
    }

    public interface IHaveDataSetIdentifier : IResourceInterface
    {
        dynamic DataSetIdentifier { get; set; }
    }

    public interface IHaveListOfQuickSightDashboardTypesVisualCustomActionActions : IResourceInterface
    {
        List<Humidifier.QuickSight.DashboardTypes.VisualCustomAction> Actions { get; set; }
    }

    public interface IHaveQuickSightTemplateTypesVisualSubtitleLabelOptionsSubtitle : IResourceInterface
    {
        Humidifier.QuickSight.TemplateTypes.VisualSubtitleLabelOptions Subtitle { get; set; }
    }

    public interface IHaveListOfQuickSightTemplateTypesVisualCustomActionActions : IResourceInterface
    {
        List<Humidifier.QuickSight.TemplateTypes.VisualCustomAction> Actions { get; set; }
    }

    public interface IHaveQuickSightTemplateTypesVisualTitleLabelOptionsTitle : IResourceInterface
    {
        Humidifier.QuickSight.TemplateTypes.VisualTitleLabelOptions Title { get; set; }
    }

    public interface IHavePolicy : IResourceInterface
    {
        dynamic Policy { get; set; }
    }

    public interface IHaveResourceId : IResourceInterface
    {
        dynamic ResourceId { get; set; }
    }

    public interface IHaveTarget : IResourceInterface
    {
        dynamic Target { get; set; }
    }

    public interface IHaveScope : IResourceInterface
    {
        dynamic Scope { get; set; }
    }

    public interface IHaveWeight : IResourceInterface
    {
        dynamic Weight { get; set; }
    }

    public interface IHaveSecurityGroups : IResourceInterface
    {
        dynamic SecurityGroups { get; set; }
    }

    public interface IHaveContentType : IResourceInterface
    {
        dynamic ContentType { get; set; }
    }

    public interface IHaveHost : IResourceInterface
    {
        dynamic Host { get; set; }
    }

    public interface IHaveDomain : IResourceInterface
    {
        dynamic Domain { get; set; }
    }

    public interface IHaveParameters : IResourceInterface
    {
        dynamic Parameters { get; set; }
    }

    public interface IHaveNullOption : IResourceInterface
    {
        dynamic NullOption { get; set; }
    }

    public interface IHaveCommitMode : IResourceInterface
    {
        dynamic CommitMode { get; set; }
    }

    public interface IHaveSourceParameterName : IResourceInterface
    {
        dynamic SourceParameterName { get; set; }
    }

    public interface IHaveContent : IResourceInterface
    {
        dynamic Content { get; set; }
    }

    public interface IHaveExecutionRoleArn : IResourceInterface
    {
        dynamic ExecutionRoleArn { get; set; }
    }

    public interface IHaveIops : IResourceInterface
    {
        dynamic Iops { get; set; }
    }

    public interface IHaveText : IResourceInterface
    {
        dynamic Text { get; set; }
    }

    public interface IHaveApiId : IResourceInterface
    {
        dynamic ApiId { get; set; }
    }

    public interface IHaveRole : IResourceInterface
    {
        dynamic Role { get; set; }
    }

    public interface IHaveHierarchyId : IResourceInterface
    {
        dynamic HierarchyId { get; set; }
    }

    public interface IHavePrincipal : IResourceInterface
    {
        dynamic Principal { get; set; }
    }

    public interface IHavePolicyName : IResourceInterface
    {
        dynamic PolicyName { get; set; }
    }

    public interface IHaveS3Bucket : IResourceInterface
    {
        dynamic S3Bucket { get; set; }
    }

    public interface IHaveResourceArn : IResourceInterface
    {
        dynamic ResourceArn { get; set; }
    }

    public interface IHaveClientId : IResourceInterface
    {
        dynamic ClientId { get; set; }
    }

    public interface IHaveMessage : IResourceInterface
    {
        dynamic Message { get; set; }
    }

    public interface IHaveAddress : IResourceInterface
    {
        dynamic Address { get; set; }
    }

    public interface IHaveNetworkInterfaceId : IResourceInterface
    {
        dynamic NetworkInterfaceId { get; set; }
    }

    public interface IHaveDelimiter : IResourceInterface
    {
        dynamic Delimiter { get; set; }
    }

    public interface IHaveParameterControlId : IResourceInterface
    {
        dynamic ParameterControlId { get; set; }
    }

    public interface IHaveEngineVersion : IResourceInterface
    {
        dynamic EngineVersion { get; set; }
    }

    public interface IHaveFormat : IResourceInterface
    {
        dynamic Format { get; set; }
    }

    public interface IHaveLogGroupName : IResourceInterface
    {
        dynamic LogGroupName { get; set; }
    }

    public interface IHaveComment : IResourceInterface
    {
        dynamic Comment { get; set; }
    }

    public interface IHaveComparisonOperator : IResourceInterface
    {
        dynamic ComparisonOperator { get; set; }
    }

    public interface IHaveGroupName : IResourceInterface
    {
        dynamic GroupName { get; set; }
    }

    public interface IHaveFileSystemId : IResourceInterface
    {
        dynamic FileSystemId { get; set; }
    }

    public interface IHaveEndpointName : IResourceInterface
    {
        dynamic EndpointName { get; set; }
    }

    public interface IHaveOperator : IResourceInterface
    {
        dynamic Operator { get; set; }
    }

    public interface IHaveLabel : IResourceInterface
    {
        dynamic Label { get; set; }
    }

    public interface IHaveActions : IResourceInterface
    {
        dynamic Actions { get; set; }
    }

    public interface IHaveAuthType : IResourceInterface
    {
        dynamic AuthType { get; set; }
    }

    public interface IHaveMaxCapacity : IResourceInterface
    {
        dynamic MaxCapacity { get; set; }
    }

    public interface IHaveDatabase : IResourceInterface
    {
        dynamic Database { get; set; }
    }

    public interface IHaveAccountId : IResourceInterface
    {
        dynamic AccountId { get; set; }
    }

    public interface IHaveDefaultValue : IResourceInterface
    {
        dynamic DefaultValue { get; set; }
    }

    public interface IHavePeriod : IResourceInterface
    {
        dynamic Period { get; set; }
    }

    public interface IHaveApplicationName : IResourceInterface
    {
        dynamic ApplicationName { get; set; }
    }

    public interface IHaveUserPoolId : IResourceInterface
    {
        dynamic UserPoolId { get; set; }
    }

    public interface IHavePreferredMaintenanceWindow : IResourceInterface
    {
        dynamic PreferredMaintenanceWindow { get; set; }
    }

    public interface IHaveClusterName : IResourceInterface
    {
        dynamic ClusterName { get; set; }
    }

    public interface IHaveEngine : IResourceInterface
    {
        dynamic Engine { get; set; }
    }

    public interface IHaveSize : IResourceInterface
    {
        dynamic Size { get; set; }
    }

    public interface IHaveVolumeType : IResourceInterface
    {
        dynamic VolumeType { get; set; }
    }

    public interface IHaveSuffix : IResourceInterface
    {
        dynamic Suffix { get; set; }
    }

    public interface IHaveColumnName : IResourceInterface
    {
        dynamic ColumnName { get; set; }
    }

    public interface IHaveHeight : IResourceInterface
    {
        dynamic Height { get; set; }
    }

    public interface IHaveWidth : IResourceInterface
    {
        dynamic Width { get; set; }
    }

    public interface IHaveServiceName : IResourceInterface
    {
        dynamic ServiceName { get; set; }
    }

    public interface IHaveStartTime : IResourceInterface
    {
        dynamic StartTime { get; set; }
    }

    public interface IHaveScheduleExpression : IResourceInterface
    {
        dynamic ScheduleExpression { get; set; }
    }

    public interface IHaveInstanceCount : IResourceInterface
    {
        dynamic InstanceCount { get; set; }
    }

    public interface IHaveLocation : IResourceInterface
    {
        dynamic Location { get; set; }
    }

    public interface IHavePosition : IResourceInterface
    {
        dynamic Position { get; set; }
    }

    public interface IHaveEndpoint : IResourceInterface
    {
        dynamic Endpoint { get; set; }
    }

    public interface IHaveInterval : IResourceInterface
    {
        dynamic Interval { get; set; }
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

    public interface IHaveTypeName : IResourceInterface
    {
        dynamic TypeName { get; set; }
    }

    public interface IHaveThreshold : IResourceInterface
    {
        dynamic Threshold { get; set; }
    }

    public interface IHaveCount : IResourceInterface
    {
        dynamic Count { get; set; }
    }

    public interface IHaveS3BucketName : IResourceInterface
    {
        dynamic S3BucketName { get; set; }
    }

    public interface IHavePattern : IResourceInterface
    {
        dynamic Pattern { get; set; }
    }

    public interface IHaveServerName : IResourceInterface
    {
        dynamic ServerName { get; set; }
    }

    public interface IHaveAwsAccountId : IResourceInterface
    {
        dynamic AwsAccountId { get; set; }
    }

    public interface IHaveAllocationStrategy : IResourceInterface
    {
        dynamic AllocationStrategy { get; set; }
    }

    public interface IHaveDestination : IResourceInterface
    {
        dynamic Destination { get; set; }
    }

    public interface IHaveFromPort : IResourceInterface
    {
        dynamic FromPort { get; set; }
    }

    public interface IHaveToPort : IResourceInterface
    {
        dynamic ToPort { get; set; }
    }

    public interface IHaveDirection : IResourceInterface
    {
        dynamic Direction { get; set; }
    }

    public interface IHaveBucketPrefix : IResourceInterface
    {
        dynamic BucketPrefix { get; set; }
    }

    public interface IHaveExact : IResourceInterface
    {
        dynamic Exact { get; set; }
    }

    public interface IHaveStringValue : IResourceInterface
    {
        dynamic StringValue { get; set; }
    }

    public interface IHaveBackgroundColor : IResourceInterface
    {
        dynamic BackgroundColor { get; set; }
    }

    public interface IHaveData : IResourceInterface
    {
        dynamic Data { get; set; }
    }

    public interface IHaveRestApiId : IResourceInterface
    {
        dynamic RestApiId { get; set; }
    }

    public interface IHaveCode : IResourceInterface
    {
        dynamic Code { get; set; }
    }

    public interface IHaveInstanceId : IResourceInterface
    {
        dynamic InstanceId { get; set; }
    }

    public interface IHaveTimeout : IResourceInterface
    {
        dynamic Timeout { get; set; }
    }

    public interface IHaveStatistic : IResourceInterface
    {
        dynamic Statistic { get; set; }
    }

    public interface IHaveTargetArn : IResourceInterface
    {
        dynamic TargetArn { get; set; }
    }

    public interface IHaveVpcSecurityGroupIds : IResourceInterface
    {
        dynamic VpcSecurityGroupIds { get; set; }
    }

    public interface IHavePrivateIpAddress : IResourceInterface
    {
        dynamic PrivateIpAddress { get; set; }
    }

    public interface IHaveCidr : IResourceInterface
    {
        dynamic Cidr { get; set; }
    }

    public interface IHaveEncrypted : IResourceInterface
    {
        dynamic Encrypted { get; set; }
    }

    public interface IHaveContainerName : IResourceInterface
    {
        dynamic ContainerName { get; set; }
    }

    public interface IHaveAvailabilityStatus : IResourceInterface
    {
        dynamic AvailabilityStatus { get; set; }
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

    public interface IHaveImage : IResourceInterface
    {
        dynamic Image { get; set; }
    }

    public interface IHaveCustomValue : IResourceInterface
    {
        dynamic CustomValue { get; set; }
    }

    public interface IHaveResourceARN : IResourceInterface
    {
        dynamic ResourceARN { get; set; }
    }

    public interface IHaveQuickSightAnalysisTypesLegendOptionsLegend : IResourceInterface
    {
        Humidifier.QuickSight.AnalysisTypes.LegendOptions Legend { get; set; }
    }

    public interface IHaveQuickSightAnalysisTypesTooltipOptionsTooltip : IResourceInterface
    {
        Humidifier.QuickSight.AnalysisTypes.TooltipOptions Tooltip { get; set; }
    }

    public interface IHaveQuickSightDashboardTypesLegendOptionsLegend : IResourceInterface
    {
        Humidifier.QuickSight.DashboardTypes.LegendOptions Legend { get; set; }
    }

    public interface IHaveQuickSightDashboardTypesTooltipOptionsTooltip : IResourceInterface
    {
        Humidifier.QuickSight.DashboardTypes.TooltipOptions Tooltip { get; set; }
    }

    public interface IHavePubliclyAccessible : IResourceInterface
    {
        dynamic PubliclyAccessible { get; set; }
    }

    public interface IHaveAuthenticationType : IResourceInterface
    {
        dynamic AuthenticationType { get; set; }
    }

    public interface IHaveExecutionRole : IResourceInterface
    {
        dynamic ExecutionRole { get; set; }
    }

    public interface IHaveSubdirectory : IResourceInterface
    {
        dynamic Subdirectory { get; set; }
    }

    public interface IHaveDeviceName : IResourceInterface
    {
        dynamic DeviceName { get; set; }
    }

    public interface IHaveCondition : IResourceInterface
    {
        dynamic Condition { get; set; }
    }

    public interface IHaveChannelName : IResourceInterface
    {
        dynamic ChannelName { get; set; }
    }

    public interface IHaveClientSecret : IResourceInterface
    {
        dynamic ClientSecret { get; set; }
    }

    public interface IHaveTopicArn : IResourceInterface
    {
        dynamic TopicArn { get; set; }
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

    public interface IHaveStepSize : IResourceInterface
    {
        dynamic StepSize { get; set; }
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

    public interface IHaveStatusCode : IResourceInterface
    {
        dynamic StatusCode { get; set; }
    }

    public interface IHaveDynDicOfParameters : IResourceInterface
    {
        Dictionary<string, dynamic> Parameters { get; set; }
    }

    public interface IHaveBody : IResourceInterface
    {
        dynamic Body { get; set; }
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

    public interface IHaveUri : IResourceInterface
    {
        dynamic Uri { get; set; }
    }

    public interface IHaveSnsTopicArn : IResourceInterface
    {
        dynamic SnsTopicArn { get; set; }
    }

    public interface IHaveDeleteOnTermination : IResourceInterface
    {
        dynamic DeleteOnTermination { get; set; }
    }

    public interface IHaveSourceArn : IResourceInterface
    {
        dynamic SourceArn { get; set; }
    }

    public interface IHaveDestinationArn : IResourceInterface
    {
        dynamic DestinationArn { get; set; }
    }

    public interface IHaveHostedZoneId : IResourceInterface
    {
        dynamic HostedZoneId { get; set; }
    }

    public interface IHaveParameterValue : IResourceInterface
    {
        dynamic ParameterValue { get; set; }
    }

    public interface IHaveS3Key : IResourceInterface
    {
        dynamic S3Key { get; set; }
    }

    public interface IHaveTargetValue : IResourceInterface
    {
        dynamic TargetValue { get; set; }
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

    public interface IHaveBase : IResourceInterface
    {
        dynamic Base { get; set; }
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

    public interface IHaveMinCapacity : IResourceInterface
    {
        dynamic MinCapacity { get; set; }
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

    public interface IHaveIdentifier : IResourceInterface
    {
        dynamic Identifier { get; set; }
    }

    public interface IHaveSourceType : IResourceInterface
    {
        dynamic SourceType { get; set; }
    }

    public interface IHaveUser : IResourceInterface
    {
        dynamic User { get; set; }
    }

    public interface IHaveDomainIdentifier : IResourceInterface
    {
        dynamic DomainIdentifier { get; set; }
    }

    public interface IHaveProductId : IResourceInterface
    {
        dynamic ProductId { get; set; }
    }

    public interface IHaveIpAddressType : IResourceInterface
    {
        dynamic IpAddressType { get; set; }
    }

    public interface IHaveThroughput : IResourceInterface
    {
        dynamic Throughput { get; set; }
    }

    public interface IHaveMemory : IResourceInterface
    {
        dynamic Memory { get; set; }
    }

    public interface IHaveTemplateName : IResourceInterface
    {
        dynamic TemplateName { get; set; }
    }

    public interface IHaveDataType : IResourceInterface
    {
        dynamic DataType { get; set; }
    }

    public interface IHavePrivateKey : IResourceInterface
    {
        dynamic PrivateKey { get; set; }
    }

    public interface IHaveIndexName : IResourceInterface
    {
        dynamic IndexName { get; set; }
    }

    public interface IHaveLogLevel : IResourceInterface
    {
        dynamic LogLevel { get; set; }
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

    public interface IHaveLevel : IResourceInterface
    {
        dynamic Level { get; set; }
    }

    public interface IHaveInstanceUrl : IResourceInterface
    {
        dynamic InstanceUrl { get; set; }
    }

    public interface IHaveEnd : IResourceInterface
    {
        dynamic End { get; set; }
    }

    public interface IHaveResourceLabel : IResourceInterface
    {
        dynamic ResourceLabel { get; set; }
    }

    public interface IHaveVolumeSize : IResourceInterface
    {
        dynamic VolumeSize { get; set; }
    }

    public interface IHaveMaxTokens : IResourceInterface
    {
        dynamic MaxTokens { get; set; }
    }

    public interface IHaveInclude : IResourceInterface
    {
        dynamic Include { get; set; }
    }

    public interface IHaveDateTimeFormat : IResourceInterface
    {
        dynamic DateTimeFormat { get; set; }
    }

    public interface IHaveKinesisFirehoseDeliveryStreamTypesCloudWatchLoggingOptionsCloudWatchLoggingOptions : IResourceInterface
    {
        Humidifier.KinesisFirehose.DeliveryStreamTypes.CloudWatchLoggingOptions CloudWatchLoggingOptions { get; set; }
    }

    public interface IHaveMediaLiveChannelTypesOutputLocationRefDestination : IResourceInterface
    {
        Humidifier.MediaLive.ChannelTypes.OutputLocationRef Destination { get; set; }
    }

    public interface IHaveAttachmentPolicyRuleNumber : IResourceInterface
    {
        dynamic AttachmentPolicyRuleNumber { get; set; }
    }

    public interface IHaveQuickSightAnalysisTypesDataLabelOptionsDataLabels : IResourceInterface
    {
        Humidifier.QuickSight.AnalysisTypes.DataLabelOptions DataLabels { get; set; }
    }

    public interface IHaveListOfQuickSightAnalysisTypesFieldSortOptionsCategorySort : IResourceInterface
    {
        List<Humidifier.QuickSight.AnalysisTypes.FieldSortOptions> CategorySort { get; set; }
    }

    public interface IHaveDataValue : IResourceInterface
    {
        dynamic DataValue { get; set; }
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

    public interface IHaveKeyType : IResourceInterface
    {
        dynamic KeyType { get; set; }
    }

    public interface IHaveMinSize : IResourceInterface
    {
        dynamic MinSize { get; set; }
    }

    public interface IHaveMaxSize : IResourceInterface
    {
        dynamic MaxSize { get; set; }
    }

    public interface IHaveAvailabilityZones : IResourceInterface
    {
        dynamic AvailabilityZones { get; set; }
    }

    public interface IHaveEndTime : IResourceInterface
    {
        dynamic EndTime { get; set; }
    }

    public interface IHaveFlowArn : IResourceInterface
    {
        dynamic FlowArn { get; set; }
    }

    public interface IHaveStat : IResourceInterface
    {
        dynamic Stat { get; set; }
    }

    public interface IHaveLanguageCode : IResourceInterface
    {
        dynamic LanguageCode { get; set; }
    }

    public interface IHaveEndpointType : IResourceInterface
    {
        dynamic EndpointType { get; set; }
    }

    public interface IHaveEndDate : IResourceInterface
    {
        dynamic EndDate { get; set; }
    }

    public interface IHaveLaunchTemplateName : IResourceInterface
    {
        dynamic LaunchTemplateName { get; set; }
    }

    public interface IHaveGroupId : IResourceInterface
    {
        dynamic GroupId { get; set; }
    }

    public interface IHaveSnapshotId : IResourceInterface
    {
        dynamic SnapshotId { get; set; }
    }

    public interface IHaveExternalId : IResourceInterface
    {
        dynamic ExternalId { get; set; }
    }

    public interface IHaveDurationInSeconds : IResourceInterface
    {
        dynamic DurationInSeconds { get; set; }
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

    public interface IHaveIssuer : IResourceInterface
    {
        dynamic Issuer { get; set; }
    }

    public interface IHaveStart : IResourceInterface
    {
        dynamic Start { get; set; }
    }

    public interface IHaveLaunchTemplateId : IResourceInterface
    {
        dynamic LaunchTemplateId { get; set; }
    }

    public interface IHaveAlgorithm : IResourceInterface
    {
        dynamic Algorithm { get; set; }
    }

    public interface IHaveFrom : IResourceInterface
    {
        dynamic From { get; set; }
    }

    public interface IHaveImageUri : IResourceInterface
    {
        dynamic ImageUri { get; set; }
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

    public interface IHaveStaticFileId : IResourceInterface
    {
        dynamic StaticFileId { get; set; }
    }

    public interface IHavePlainText : IResourceInterface
    {
        dynamic PlainText { get; set; }
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

    public interface IHaveAlias : IResourceInterface
    {
        dynamic Alias { get; set; }
    }

    public interface IHavePermissions : IResourceInterface
    {
        dynamic Permissions { get; set; }
    }

    public interface IHavePolicyType : IResourceInterface
    {
        dynamic PolicyType { get; set; }
    }

    public interface IHaveImageId : IResourceInterface
    {
        dynamic ImageId { get; set; }
    }

    public interface IHaveTimeZone : IResourceInterface
    {
        dynamic TimeZone { get; set; }
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

    public interface IHaveSslMode : IResourceInterface
    {
        dynamic SslMode { get; set; }
    }

    public interface IHaveNetworkType : IResourceInterface
    {
        dynamic NetworkType { get; set; }
    }

    public interface IHaveDBSubnetGroupName : IResourceInterface
    {
        dynamic DBSubnetGroupName { get; set; }
    }

    public interface IHaveTenancy : IResourceInterface
    {
        dynamic Tenancy { get; set; }
    }

    public interface IHaveTransitGatewayId : IResourceInterface
    {
        dynamic TransitGatewayId { get; set; }
    }

    public interface IHaveSchemaName : IResourceInterface
    {
        dynamic SchemaName { get; set; }
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

    public interface IHaveNetworkFunctionGroupName : IResourceInterface
    {
        dynamic NetworkFunctionGroupName { get; set; }
    }

    public interface IHaveClusterIdentifier : IResourceInterface
    {
        dynamic ClusterIdentifier { get; set; }
    }

    public interface IHaveModelId : IResourceInterface
    {
        dynamic ModelId { get; set; }
    }

    public interface IHaveProperty : IResourceInterface
    {
        dynamic Property { get; set; }
    }

    public interface IHaveRevision : IResourceInterface
    {
        dynamic Revision { get; set; }
    }

    public interface IHaveAppFlowFlowTypesErrorHandlingConfigErrorHandlingConfig : IResourceInterface
    {
        Humidifier.AppFlow.FlowTypes.ErrorHandlingConfig ErrorHandlingConfig { get; set; }
    }

    public interface IHaveAwsRegion : IResourceInterface
    {
        dynamic AwsRegion { get; set; }
    }

    public interface IHavePredefinedMetricType : IResourceInterface
    {
        dynamic PredefinedMetricType { get; set; }
    }

    public interface IHaveSourcePath : IResourceInterface
    {
        dynamic SourcePath { get; set; }
    }

    public interface IHaveEncryptionType : IResourceInterface
    {
        dynamic EncryptionType { get; set; }
    }

    public interface IHaveMinimum : IResourceInterface
    {
        dynamic Minimum { get; set; }
    }

    public interface IHaveExclude : IResourceInterface
    {
        dynamic Exclude { get; set; }
    }

    public interface IHaveHeaderName : IResourceInterface
    {
        dynamic HeaderName { get; set; }
    }

    public interface IHaveDoubleValue : IResourceInterface
    {
        dynamic DoubleValue { get; set; }
    }

    public interface IHaveLogGroup : IResourceInterface
    {
        dynamic LogGroup { get; set; }
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

    public interface IHaveTrigger : IResourceInterface
    {
        dynamic Trigger { get; set; }
    }

    public interface IHaveCustomActionId : IResourceInterface
    {
        dynamic CustomActionId { get; set; }
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

    public interface IHaveStage : IResourceInterface
    {
        dynamic Stage { get; set; }
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

    public interface IHaveDefinition : IResourceInterface
    {
        dynamic Definition { get; set; }
    }

    public interface IHaveScalingAdjustment : IResourceInterface
    {
        dynamic ScalingAdjustment { get; set; }
    }

    public interface IHaveEncryptionKeyArn : IResourceInterface
    {
        dynamic EncryptionKeyArn { get; set; }
    }

    public interface IHaveLogGroupArn : IResourceInterface
    {
        dynamic LogGroupArn { get; set; }
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

    public interface IHaveEvaluationPeriods : IResourceInterface
    {
        dynamic EvaluationPeriods { get; set; }
    }

    public interface IHaveOwner : IResourceInterface
    {
        dynamic Owner { get; set; }
    }

    public interface IHaveCategory : IResourceInterface
    {
        dynamic Category { get; set; }
    }

    public interface IHaveClientToken : IResourceInterface
    {
        dynamic ClientToken { get; set; }
    }

    public interface IHaveServiceAccessRoleArn : IResourceInterface
    {
        dynamic ServiceAccessRoleArn { get; set; }
    }

    public interface IHaveDatasetName : IResourceInterface
    {
        dynamic DatasetName { get; set; }
    }

    public interface IHaveVpcEndpointId : IResourceInterface
    {
        dynamic VpcEndpointId { get; set; }
    }

    public interface IHaveTemplateType : IResourceInterface
    {
        dynamic TemplateType { get; set; }
    }

    public interface IHaveDBClusterIdentifier : IResourceInterface
    {
        dynamic DBClusterIdentifier { get; set; }
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

    public interface IHaveIpAddress : IResourceInterface
    {
        dynamic IpAddress { get; set; }
    }

    public interface IHaveTier : IResourceInterface
    {
        dynamic Tier { get; set; }
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

    public interface IHaveCpu : IResourceInterface
    {
        dynamic Cpu { get; set; }
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

    public interface IHaveThingArn : IResourceInterface
    {
        dynamic ThingArn { get; set; }
    }

    public interface IHaveColumnNames : IResourceInterface
    {
        dynamic ColumnNames { get; set; }
    }

    public interface IHaveTagKey : IResourceInterface
    {
        dynamic TagKey { get; set; }
    }

    public interface IHaveRuntime : IResourceInterface
    {
        dynamic Runtime { get; set; }
    }

    public interface IHaveVpcInterfaceName : IResourceInterface
    {
        dynamic VpcInterfaceName { get; set; }
    }

    public interface IHaveMaxBitrate : IResourceInterface
    {
        dynamic MaxBitrate { get; set; }
    }

    public interface IHaveGlobalNetworkId : IResourceInterface
    {
        dynamic GlobalNetworkId { get; set; }
    }

    public interface IHaveModel : IResourceInterface
    {
        dynamic Model { get; set; }
    }

    public interface IHaveSubject : IResourceInterface
    {
        dynamic Subject { get; set; }
    }

    public interface IHaveStreamName : IResourceInterface
    {
        dynamic StreamName { get; set; }
    }

    public interface IHaveDynDicOfAdditionalEncryptionContext : IResourceInterface
    {
        Dictionary<string, dynamic> AdditionalEncryptionContext { get; set; }
    }

    public interface IHaveStartDate : IResourceInterface
    {
        dynamic StartDate { get; set; }
    }

    public interface IHaveEnableNetworkIsolation : IResourceInterface
    {
        dynamic EnableNetworkIsolation { get; set; }
    }

    public interface IHaveRegions : IResourceInterface
    {
        dynamic Regions { get; set; }
    }

    public interface IHaveAssistantId : IResourceInterface
    {
        dynamic AssistantId { get; set; }
    }

    public interface IHaveComponentName : IResourceInterface
    {
        dynamic ComponentName { get; set; }
    }

    public interface IHaveReadOnly : IResourceInterface
    {
        dynamic ReadOnly { get; set; }
    }

    public interface IHaveMaxValue : IResourceInterface
    {
        dynamic MaxValue { get; set; }
    }

    public interface IHaveMinValue : IResourceInterface
    {
        dynamic MinValue { get; set; }
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

    public interface IHaveReturnData : IResourceInterface
    {
        dynamic ReturnData { get; set; }
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

    public interface IHaveContainerPath : IResourceInterface
    {
        dynamic ContainerPath { get; set; }
    }

    public interface IHaveOrder : IResourceInterface
    {
        dynamic Order { get; set; }
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

    public interface IHaveDimensionType : IResourceInterface
    {
        dynamic DimensionType { get; set; }
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

    public interface IHaveApplicationArn : IResourceInterface
    {
        dynamic ApplicationArn { get; set; }
    }

    public interface IHaveFirstName : IResourceInterface
    {
        dynamic FirstName { get; set; }
    }

    public interface IHaveLastName : IResourceInterface
    {
        dynamic LastName { get; set; }
    }

    public interface IHaveServiceRoleArn : IResourceInterface
    {
        dynamic ServiceRoleArn { get; set; }
    }

    public interface IHaveKeyName : IResourceInterface
    {
        dynamic KeyName { get; set; }
    }

    public interface IHaveEmail : IResourceInterface
    {
        dynamic Email { get; set; }
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

    public interface IHaveVersionId : IResourceInterface
    {
        dynamic VersionId { get; set; }
    }

    public interface IHaveConfiguration : IResourceInterface
    {
        dynamic Configuration { get; set; }
    }

    public interface IHaveAlarmName : IResourceInterface
    {
        dynamic AlarmName { get; set; }
    }

    public interface IHaveEncryptionKey : IResourceInterface
    {
        dynamic EncryptionKey { get; set; }
    }

    public interface IHaveVersionDescription : IResourceInterface
    {
        dynamic VersionDescription { get; set; }
    }

    public interface IHaveNodeType : IResourceInterface
    {
        dynamic NodeType { get; set; }
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

    public interface IHaveDestinationCidrBlock : IResourceInterface
    {
        dynamic DestinationCidrBlock { get; set; }
    }

    public interface IHaveClusterId : IResourceInterface
    {
        dynamic ClusterId { get; set; }
    }

    public interface IHaveRegistryName : IResourceInterface
    {
        dynamic RegistryName { get; set; }
    }

    public interface IHaveSchedule : IResourceInterface
    {
        dynamic Schedule { get; set; }
    }

    public interface IHaveIndexId : IResourceInterface
    {
        dynamic IndexId { get; set; }
    }

    public interface IHaveMaximumRetryAttempts : IResourceInterface
    {
        dynamic MaximumRetryAttempts { get; set; }
    }

    public interface IHaveModelName : IResourceInterface
    {
        dynamic ModelName { get; set; }
    }

    public interface IHaveClusterArn : IResourceInterface
    {
        dynamic ClusterArn { get; set; }
    }

    public interface IHaveEventType : IResourceInterface
    {
        dynamic EventType { get; set; }
    }

    public interface IHaveDeviceId : IResourceInterface
    {
        dynamic DeviceId { get; set; }
    }

    public interface IHaveResourceTypes : IResourceInterface
    {
        dynamic ResourceTypes { get; set; }
    }

    public interface IHaveKeyArn : IResourceInterface
    {
        dynamic KeyArn { get; set; }
    }

    public interface IHaveSchemaArn : IResourceInterface
    {
        dynamic SchemaArn { get; set; }
    }

    public interface IHaveApiKey : IResourceInterface
    {
        dynamic ApiKey { get; set; }
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

    public interface IHaveRequired : IResourceInterface
    {
        dynamic Required { get; set; }
    }

    public interface IHaveRepositoryUrl : IResourceInterface
    {
        dynamic RepositoryUrl { get; set; }
    }

    public interface IHaveInput : IResourceInterface
    {
        dynamic Input { get; set; }
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

    public interface IHaveBucketOwner : IResourceInterface
    {
        dynamic BucketOwner { get; set; }
    }

    public interface IHaveObjectVersion : IResourceInterface
    {
        dynamic ObjectVersion { get; set; }
    }

    public interface IHaveSecretManagerArn : IResourceInterface
    {
        dynamic SecretManagerArn { get; set; }
    }

    public interface IHaveRegionName : IResourceInterface
    {
        dynamic RegionName { get; set; }
    }

    public interface IHaveContainerPort : IResourceInterface
    {
        dynamic ContainerPort { get; set; }
    }

    public interface IHaveClassification : IResourceInterface
    {
        dynamic Classification { get; set; }
    }

    public interface IHaveTimeoutDurationMinutes : IResourceInterface
    {
        dynamic TimeoutDurationMinutes { get; set; }
    }

    public interface IHaveS3ObjectVersion : IResourceInterface
    {
        dynamic S3ObjectVersion { get; set; }
    }

    public interface IHaveLongValue : IResourceInterface
    {
        dynamic LongValue { get; set; }
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

    public interface IHaveSegmentName : IResourceInterface
    {
        dynamic SegmentName { get; set; }
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

    public interface IHaveItemsLimit : IResourceInterface
    {
        dynamic ItemsLimit { get; set; }
    }

    public interface IHaveTooltipVisibility : IResourceInterface
    {
        dynamic TooltipVisibility { get; set; }
    }

    public interface IHaveRichText : IResourceInterface
    {
        dynamic RichText { get; set; }
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

    public interface IHaveActionFailurePolicy : IResourceInterface
    {
        dynamic ActionFailurePolicy { get; set; }
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

    public interface IHaveWorkingDirectory : IResourceInterface
    {
        dynamic WorkingDirectory { get; set; }
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

    public interface IHaveFrequency : IResourceInterface
    {
        dynamic Frequency { get; set; }
    }

    public interface IHaveSubscriptionName : IResourceInterface
    {
        dynamic SubscriptionName { get; set; }
    }

    public interface IHaveS3Prefix : IResourceInterface
    {
        dynamic S3Prefix { get; set; }
    }

    public interface IHaveActionName : IResourceInterface
    {
        dynamic ActionName { get; set; }
    }

    public interface IHaveMembershipIdentifier : IResourceInterface
    {
        dynamic MembershipIdentifier { get; set; }
    }

    public interface IHaveTemplateBody : IResourceInterface
    {
        dynamic TemplateBody { get; set; }
    }

    public interface IHaveOutputFormat : IResourceInterface
    {
        dynamic OutputFormat { get; set; }
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

    public interface IHaveParameterGroupName : IResourceInterface
    {
        dynamic ParameterGroupName { get; set; }
    }

    public interface IHaveSubnetGroupName : IResourceInterface
    {
        dynamic SubnetGroupName { get; set; }
    }

    public interface IHaveEventCategories : IResourceInterface
    {
        dynamic EventCategories { get; set; }
    }

    public interface IHaveSourceIds : IResourceInterface
    {
        dynamic SourceIds { get; set; }
    }

    public interface IHaveProjectName : IResourceInterface
    {
        dynamic ProjectName { get; set; }
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

    public interface IHaveInstanceFamily : IResourceInterface
    {
        dynamic InstanceFamily { get; set; }
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

    public interface IHaveFileSystemPath : IResourceInterface
    {
        dynamic FileSystemPath { get; set; }
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

    public interface IHaveStreamId : IResourceInterface
    {
        dynamic StreamId { get; set; }
    }

    public interface IHaveChannelId : IResourceInterface
    {
        dynamic ChannelId { get; set; }
    }

    public interface IHaveChannelGroupName : IResourceInterface
    {
        dynamic ChannelGroupName { get; set; }
    }

    public interface IHaveCapacity : IResourceInterface
    {
        dynamic Capacity { get; set; }
    }

    public interface IHaveCoreNetworkId : IResourceInterface
    {
        dynamic CoreNetworkId { get; set; }
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

    public interface IHaveNamespaceName : IResourceInterface
    {
        dynamic NamespaceName { get; set; }
    }

    public interface IHaveGroup : IResourceInterface
    {
        dynamic Group { get; set; }
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

    public interface IHaveAttributes_ : IResourceInterface
    {
        dynamic Attributes_ { get; set; }
    }

    public interface IHaveCustomerManagedKey : IResourceInterface
    {
        dynamic CustomerManagedKey { get; set; }
    }

    public interface IHaveSlotName : IResourceInterface
    {
        dynamic SlotName { get; set; }
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

    public interface IHaveDisableScaleIn : IResourceInterface
    {
        dynamic DisableScaleIn { get; set; }
    }

    public interface IHavePrometheusPort : IResourceInterface
    {
        dynamic PrometheusPort { get; set; }
    }

    public interface IHaveEmailAddress : IResourceInterface
    {
        dynamic EmailAddress { get; set; }
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

    public interface IHavePrivileged : IResourceInterface
    {
        dynamic Privileged { get; set; }
    }

    public interface IHaveArgs : IResourceInterface
    {
        dynamic Args { get; set; }
    }

    public interface IHaveReason : IResourceInterface
    {
        dynamic Reason { get; set; }
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

    public interface IHaveKeyPrefix : IResourceInterface
    {
        dynamic KeyPrefix { get; set; }
    }

    public interface IHaveItems : IResourceInterface
    {
        dynamic Items { get; set; }
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

    public interface IHaveCidrs : IResourceInterface
    {
        dynamic Cidrs { get; set; }
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

    public interface IHaveSortOrder : IResourceInterface
    {
        dynamic SortOrder { get; set; }
    }

    public interface IHaveAllowedValues : IResourceInterface
    {
        dynamic AllowedValues { get; set; }
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

    public interface IHaveKinesisFirehoseDeliveryStreamTypesSecretsManagerConfigurationSecretsManagerConfiguration : IResourceInterface
    {
        Humidifier.KinesisFirehose.DeliveryStreamTypes.SecretsManagerConfiguration SecretsManagerConfiguration { get; set; }
    }

    public interface IHaveImageUrl : IResourceInterface
    {
        dynamic ImageUrl { get; set; }
    }

    public interface IHaveOverwriteIfExists : IResourceInterface
    {
        dynamic OverwriteIfExists { get; set; }
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

    public interface IHaveMediaLiveChannelTypesTimecodeBurninSettingsTimecodeBurninSettings : IResourceInterface
    {
        Humidifier.MediaLive.ChannelTypes.TimecodeBurninSettings TimecodeBurninSettings { get; set; }
    }

    public interface IHaveNielsenId3Behavior : IResourceInterface
    {
        dynamic NielsenId3Behavior { get; set; }
    }

    public interface IHaveFilecacheDuration : IResourceInterface
    {
        dynamic FilecacheDuration { get; set; }
    }

    public interface IHaveAdMarkers : IResourceInterface
    {
        dynamic AdMarkers { get; set; }
    }

    public interface IHaveInputLossAction : IResourceInterface
    {
        dynamic InputLossAction { get; set; }
    }

    public interface IHaveIncludeIframeOnlyStream : IResourceInterface
    {
        dynamic IncludeIframeOnlyStream { get; set; }
    }

    public interface IHaveProgramDateTimeIntervalSeconds : IResourceInterface
    {
        dynamic ProgramDateTimeIntervalSeconds { get; set; }
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

    public interface IHaveLineWidth : IResourceInterface
    {
        dynamic LineWidth { get; set; }
    }

    public interface IHaveBaseMapStyle : IResourceInterface
    {
        dynamic BaseMapStyle { get; set; }
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

    public interface IHaveSecurityPolicy : IResourceInterface
    {
        dynamic SecurityPolicy { get; set; }
    }

    public interface IHaveDynDicOfVariables : IResourceInterface
    {
        Dictionary<string, dynamic> Variables { get; set; }
    }

    public interface IHaveKeyId : IResourceInterface
    {
        dynamic KeyId { get; set; }
    }

    public interface IHaveConnectionType : IResourceInterface
    {
        dynamic ConnectionType { get; set; }
    }

    public interface IHaveEnvironmentId : IResourceInterface
    {
        dynamic EnvironmentId { get; set; }
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

    public interface IHaveTtl : IResourceInterface
    {
        dynamic Ttl { get; set; }
    }

    public interface IHaveFieldName : IResourceInterface
    {
        dynamic FieldName { get; set; }
    }

    public interface IHaveWorkGroup : IResourceInterface
    {
        dynamic WorkGroup { get; set; }
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

    public interface IHaveProfileId : IResourceInterface
    {
        dynamic ProfileId { get; set; }
    }

    public interface IHaveGuardrailIdentifier : IResourceInterface
    {
        dynamic GuardrailIdentifier { get; set; }
    }

    public interface IHaveOperation : IResourceInterface
    {
        dynamic Operation { get; set; }
    }

    public interface IHaveActionType : IResourceInterface
    {
        dynamic ActionType { get; set; }
    }

    public interface IHaveNotificationType : IResourceInterface
    {
        dynamic NotificationType { get; set; }
    }

    public interface IHaveTimeoutInMinutes : IResourceInterface
    {
        dynamic TimeoutInMinutes { get; set; }
    }

    public interface IHaveKMSKeyId : IResourceInterface
    {
        dynamic KMSKeyId { get; set; }
    }

    public interface IHaveCloudWatchLogsLogGroupArn : IResourceInterface
    {
        dynamic CloudWatchLogsLogGroupArn { get; set; }
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

    public interface IHaveCopyTagsToSnapshot : IResourceInterface
    {
        dynamic CopyTagsToSnapshot { get; set; }
    }

    public interface IHaveUseLatestRestorableTime : IResourceInterface
    {
        dynamic UseLatestRestorableTime { get; set; }
    }

    public interface IHaveDBClusterParameterGroupName : IResourceInterface
    {
        dynamic DBClusterParameterGroupName { get; set; }
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

    public interface IHaveHostId : IResourceInterface
    {
        dynamic HostId { get; set; }
    }

    public interface IHaveHostResourceGroupArn : IResourceInterface
    {
        dynamic HostResourceGroupArn { get; set; }
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

    public interface IHaveTaskRoleArn : IResourceInterface
    {
        dynamic TaskRoleArn { get; set; }
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

    public interface IHaveUserId : IResourceInterface
    {
        dynamic UserId { get; set; }
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

    public interface IHaveStatementId : IResourceInterface
    {
        dynamic StatementId { get; set; }
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

    public interface IHaveMetricType : IResourceInterface
    {
        dynamic MetricType { get; set; }
    }

    public interface IHaveStringValues : IResourceInterface
    {
        dynamic StringValues { get; set; }
    }

    public interface IHaveApplicationDescription : IResourceInterface
    {
        dynamic ApplicationDescription { get; set; }
    }

    public interface IHaveSignalCatalogArn : IResourceInterface
    {
        dynamic SignalCatalogArn { get; set; }
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

    public interface IHaveQueue : IResourceInterface
    {
        dynamic Queue { get; set; }
    }

    public interface IHaveSourceLocationName : IResourceInterface
    {
        dynamic SourceLocationName { get; set; }
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

    public interface IHaveFolderArns : IResourceInterface
    {
        dynamic FolderArns { get; set; }
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

    public interface IHaveProtocols : IResourceInterface
    {
        dynamic Protocols { get; set; }
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

    public interface IHaveRateLimit : IResourceInterface
    {
        dynamic RateLimit { get; set; }
    }

    public interface IHaveLanguage : IResourceInterface
    {
        dynamic Language { get; set; }
    }

    public interface IHaveKeyAgreement : IResourceInterface
    {
        dynamic KeyAgreement { get; set; }
    }

    public interface IHaveExpirationInDays : IResourceInterface
    {
        dynamic ExpirationInDays { get; set; }
    }

    public interface IHaveEq : IResourceInterface
    {
        dynamic Eq { get; set; }
    }

    public interface IHaveUserAttribute : IResourceInterface
    {
        dynamic UserAttribute { get; set; }
    }

    public interface IHaveResourcePath : IResourceInterface
    {
        dynamic ResourcePath { get; set; }
    }

    public interface IHaveTypes : IResourceInterface
    {
        dynamic Types { get; set; }
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

    public interface IHaveCapacityReservationPreference : IResourceInterface
    {
        dynamic CapacityReservationPreference { get; set; }
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

    public interface IHaveOnDemandMaxPricePercentageOverLowestPrice : IResourceInterface
    {
        dynamic OnDemandMaxPricePercentageOverLowestPrice { get; set; }
    }

    public interface IHaveLocalStorageTypes : IResourceInterface
    {
        dynamic LocalStorageTypes { get; set; }
    }

    public interface IHaveSpotMaxPricePercentageOverLowestPrice : IResourceInterface
    {
        dynamic SpotMaxPricePercentageOverLowestPrice { get; set; }
    }

    public interface IHaveAcceleratorNames : IResourceInterface
    {
        dynamic AcceleratorNames { get; set; }
    }

    public interface IHaveBurstablePerformance : IResourceInterface
    {
        dynamic BurstablePerformance { get; set; }
    }

    public interface IHaveMetrics : IResourceInterface
    {
        dynamic Metrics { get; set; }
    }

    public interface IHaveReadonlyRootFilesystem : IResourceInterface
    {
        dynamic ReadonlyRootFilesystem { get; set; }
    }

    public interface IHaveListOfBatchJobDefinitionTypesVolumeVolumes : IResourceInterface
    {
        List<Humidifier.Batch.JobDefinitionTypes.Volume> Volumes { get; set; }
    }

    public interface IHaveSizeInGiB : IResourceInterface
    {
        dynamic SizeInGiB { get; set; }
    }

    public interface IHaveDynDicOfOptions : IResourceInterface
    {
        Dictionary<string, dynamic> Options { get; set; }
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

    public interface IHaveScalingType : IResourceInterface
    {
        dynamic ScalingType { get; set; }
    }

    public interface IHaveMinutes : IResourceInterface
    {
        dynamic Minutes { get; set; }
    }

    public interface IHavePhoneNumber : IResourceInterface
    {
        dynamic PhoneNumber { get; set; }
    }

    public interface IHaveBandwidthAllocation : IResourceInterface
    {
        dynamic BandwidthAllocation { get; set; }
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

    public interface IHaveValueKey : IResourceInterface
    {
        dynamic ValueKey { get; set; }
    }

    public interface IHaveOptions : IResourceInterface
    {
        dynamic Options { get; set; }
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

    public interface IHaveWithKeys : IResourceInterface
    {
        dynamic WithKeys { get; set; }
    }

    public interface IHaveObjectKey : IResourceInterface
    {
        dynamic ObjectKey { get; set; }
    }

    public interface IHaveFixedAfd : IResourceInterface
    {
        dynamic FixedAfd { get; set; }
    }

    public interface IHaveGopSizeUnits : IResourceInterface
    {
        dynamic GopSizeUnits { get; set; }
    }

    public interface IHaveFramerateNumerator : IResourceInterface
    {
        dynamic FramerateNumerator { get; set; }
    }

    public interface IHaveAfdSignaling : IResourceInterface
    {
        dynamic AfdSignaling { get; set; }
    }

    public interface IHaveFramerateDenominator : IResourceInterface
    {
        dynamic FramerateDenominator { get; set; }
    }

    public interface IHaveGopSize : IResourceInterface
    {
        dynamic GopSize { get; set; }
    }

    public interface IHavePasswordParam : IResourceInterface
    {
        dynamic PasswordParam { get; set; }
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

    public interface IHaveDataSourceArn : IResourceInterface
    {
        dynamic DataSourceArn { get; set; }
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

    public interface IHaveDefaultOpacity : IResourceInterface
    {
        dynamic DefaultOpacity { get; set; }
    }

    public interface IHaveNullDataVisibility : IResourceInterface
    {
        dynamic NullDataVisibility { get; set; }
    }

    public interface IHaveInteractions : IResourceInterface
    {
        dynamic Interactions { get; set; }
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

    public interface IHaveDomainName_ : IResourceInterface
    {
        dynamic DomainName_ { get; set; }
    }

    public interface IHaveDynDicOfResponseParameters : IResourceInterface
    {
        Dictionary<string, dynamic> ResponseParameters { get; set; }
    }

    public interface IHaveAuthorizationScopes : IResourceInterface
    {
        dynamic AuthorizationScopes { get; set; }
    }

    public interface IHaveDynDicOfRequestParameters : IResourceInterface
    {
        Dictionary<string, dynamic> RequestParameters { get; set; }
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

    public interface IHaveTimeoutInMillis : IResourceInterface
    {
        dynamic TimeoutInMillis { get; set; }
    }

    public interface IHaveIntegrationType : IResourceInterface
    {
        dynamic IntegrationType { get; set; }
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

    public interface IHaveCodeS3Location : IResourceInterface
    {
        dynamic CodeS3Location { get; set; }
    }

    public interface IHaveFunctionVersion : IResourceInterface
    {
        dynamic FunctionVersion { get; set; }
    }

    public interface IHaveServiceNamespace : IResourceInterface
    {
        dynamic ServiceNamespace { get; set; }
    }

    public interface IHaveScalableDimension : IResourceInterface
    {
        dynamic ScalableDimension { get; set; }
    }

    public interface IHaveStatementName : IResourceInterface
    {
        dynamic StatementName { get; set; }
    }

    public interface IHaveQueryStatement : IResourceInterface
    {
        dynamic QueryStatement { get; set; }
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

    public interface IHaveCapabilities : IResourceInterface
    {
        dynamic Capabilities { get; set; }
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

    public interface IHaveKeyspaceName : IResourceInterface
    {
        dynamic KeyspaceName { get; set; }
    }

    public interface IHavePointInTimeRecoveryEnabled : IResourceInterface
    {
        dynamic PointInTimeRecoveryEnabled { get; set; }
    }

    public interface IHaveAliasName : IResourceInterface
    {
        dynamic AliasName { get; set; }
    }

    public interface IHaveSamplingRate : IResourceInterface
    {
        dynamic SamplingRate { get; set; }
    }

    public interface IHaveBillingMode : IResourceInterface
    {
        dynamic BillingMode { get; set; }
    }

    public interface IHaveResourcePolicy_ : IResourceInterface
    {
        dynamic ResourcePolicy_ { get; set; }
    }

    public interface IHaveCloudWatchLogsRoleArn : IResourceInterface
    {
        dynamic CloudWatchLogsRoleArn { get; set; }
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

    public interface IHaveTemplate : IResourceInterface
    {
        dynamic Template { get; set; }
    }

    public interface IHaveManifest : IResourceInterface
    {
        dynamic Manifest { get; set; }
    }

    public interface IHaveIAMRoleARN : IResourceInterface
    {
        dynamic IAMRoleARN { get; set; }
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

    public interface IHaveManageMasterUserPassword : IResourceInterface
    {
        dynamic ManageMasterUserPassword { get; set; }
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

    public interface IHaveIpamPoolId : IResourceInterface
    {
        dynamic IpamPoolId { get; set; }
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

    public interface IHaveSourceIp : IResourceInterface
    {
        dynamic SourceIp { get; set; }
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

    public interface IHaveSecurityGroupReferencingSupport : IResourceInterface
    {
        dynamic SecurityGroupReferencingSupport { get; set; }
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

    public interface IHaveIpcMode : IResourceInterface
    {
        dynamic IpcMode { get; set; }
    }

    public interface IHavePidMode : IResourceInterface
    {
        dynamic PidMode { get; set; }
    }

    public interface IHaveDynDicOfLabels : IResourceInterface
    {
        Dictionary<string, dynamic> Labels { get; set; }
    }

    public interface IHaveLogUri : IResourceInterface
    {
        dynamic LogUri { get; set; }
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

    public interface IHaveEffect : IResourceInterface
    {
        dynamic Effect { get; set; }
    }

    public interface IHaveStatement : IResourceInterface
    {
        dynamic Statement { get; set; }
    }

    public interface IHaveProject : IResourceInterface
    {
        dynamic Project { get; set; }
    }

    public interface IHaveBackupId : IResourceInterface
    {
        dynamic BackupId { get; set; }
    }

    public interface IHaveOperatingSystem : IResourceInterface
    {
        dynamic OperatingSystem { get; set; }
    }

    public interface IHaveDesiredEC2Instances : IResourceInterface
    {
        dynamic DesiredEC2Instances { get; set; }
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

    public interface IHaveMaxConcurrentRuns : IResourceInterface
    {
        dynamic MaxConcurrentRuns { get; set; }
    }

    public interface IHaveAllowedOrigins : IResourceInterface
    {
        dynamic AllowedOrigins { get; set; }
    }

    public interface IHaveIdentityStoreId : IResourceInterface
    {
        dynamic IdentityStoreId { get; set; }
    }

    public interface IHaveTargetName : IResourceInterface
    {
        dynamic TargetName { get; set; }
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

    public interface IHaveIntegrationName : IResourceInterface
    {
        dynamic IntegrationName { get; set; }
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

    public interface IHaveEdgeLocations : IResourceInterface
    {
        dynamic EdgeLocations { get; set; }
    }

    public interface IHaveDomains : IResourceInterface
    {
        dynamic Domains { get; set; }
    }

    public interface IHaveLayerId : IResourceInterface
    {
        dynamic LayerId { get; set; }
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

    public interface IHaveSenderId : IResourceInterface
    {
        dynamic SenderId { get; set; }
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

    public interface IHaveLastModifiedTime : IResourceInterface
    {
        dynamic LastModifiedTime { get; set; }
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

    public interface IHaveVpcIdentifier : IResourceInterface
    {
        dynamic VpcIdentifier { get; set; }
    }

    public interface IHaveModifiedTimeSeconds : IResourceInterface
    {
        dynamic ModifiedTimeSeconds { get; set; }
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

    public interface IHaveCountry : IResourceInterface
    {
        dynamic Country { get; set; }
    }

    public interface IHaveCommonName : IResourceInterface
    {
        dynamic CommonName { get; set; }
    }

    public interface IHaveAccountIds : IResourceInterface
    {
        dynamic AccountIds { get; set; }
    }

    public interface IHaveTimeOfDay : IResourceInterface
    {
        dynamic TimeOfDay { get; set; }
    }

    public interface IHaveCertificateType : IResourceInterface
    {
        dynamic CertificateType { get; set; }
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

    public interface IHaveTokenUrl : IResourceInterface
    {
        dynamic TokenUrl { get; set; }
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

    public interface IHaveAppIdClientRegex : IResourceInterface
    {
        dynamic AppIdClientRegex { get; set; }
    }

    public interface IHaveEventBusArn : IResourceInterface
    {
        dynamic EventBusArn { get; set; }
    }

    public interface IHaveListOfApplicationAutoScalingScalingPolicyTypesPredictiveScalingMetricDataQueryMetricDataQueries : IResourceInterface
    {
        List<Humidifier.ApplicationAutoScaling.ScalingPolicyTypes.PredictiveScalingMetricDataQuery> MetricDataQueries { get; set; }
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

    public interface IHaveOutput : IResourceInterface
    {
        dynamic Output { get; set; }
    }

    public interface IHaveOverwrite : IResourceInterface
    {
        dynamic Overwrite { get; set; }
    }

    public interface IHaveBatchJobDefinitionTypesRepositoryCredentialsRepositoryCredentials : IResourceInterface
    {
        Humidifier.Batch.JobDefinitionTypes.RepositoryCredentials RepositoryCredentials { get; set; }
    }

    public interface IHaveListOfBatchJobDefinitionTypesSecretSecrets : IResourceInterface
    {
        List<Humidifier.Batch.JobDefinitionTypes.Secret> Secrets { get; set; }
    }

    public interface IHaveBatchJobDefinitionTypesLinuxParametersLinuxParameters : IResourceInterface
    {
        Humidifier.Batch.JobDefinitionTypes.LinuxParameters LinuxParameters { get; set; }
    }

    public interface IHaveListOfBatchJobDefinitionTypesResourceRequirementResourceRequirements : IResourceInterface
    {
        List<Humidifier.Batch.JobDefinitionTypes.ResourceRequirement> ResourceRequirements { get; set; }
    }

    public interface IHaveBatchJobDefinitionTypesLogConfigurationLogConfiguration : IResourceInterface
    {
        Humidifier.Batch.JobDefinitionTypes.LogConfiguration LogConfiguration { get; set; }
    }

    public interface IHaveListOfBatchJobDefinitionTypesMountPointMountPoints : IResourceInterface
    {
        List<Humidifier.Batch.JobDefinitionTypes.MountPoint> MountPoints { get; set; }
    }

    public interface IHaveBatchJobDefinitionTypesRuntimePlatformRuntimePlatform : IResourceInterface
    {
        Humidifier.Batch.JobDefinitionTypes.RuntimePlatform RuntimePlatform { get; set; }
    }

    public interface IHaveListOfBatchJobDefinitionTypesEnvironmentEnvironment : IResourceInterface
    {
        List<Humidifier.Batch.JobDefinitionTypes.Environment> Environment { get; set; }
    }

    public interface IHaveListOfBatchJobDefinitionTypesUlimitUlimits : IResourceInterface
    {
        List<Humidifier.Batch.JobDefinitionTypes.Ulimit> Ulimits { get; set; }
    }

    public interface IHaveBatchJobDefinitionTypesEphemeralStorageEphemeralStorage : IResourceInterface
    {
        Humidifier.Batch.JobDefinitionTypes.EphemeralStorage EphemeralStorage { get; set; }
    }

    public interface IHaveRootDirectory : IResourceInterface
    {
        dynamic RootDirectory { get; set; }
    }

    public interface IHaveLogDriver : IResourceInterface
    {
        dynamic LogDriver { get; set; }
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

    public interface IHavePayload : IResourceInterface
    {
        dynamic Payload { get; set; }
    }

    public interface IHaveGuardrailVersion : IResourceInterface
    {
        dynamic GuardrailVersion { get; set; }
    }

    public interface IHaveS3ObjectKey : IResourceInterface
    {
        dynamic S3ObjectKey { get; set; }
    }

    public interface IHaveModelArn : IResourceInterface
    {
        dynamic ModelArn { get; set; }
    }

    public interface IHaveBedrockDataSourceTypesCrawlFilterConfigurationFilterConfiguration : IResourceInterface
    {
        Humidifier.Bedrock.DataSourceTypes.CrawlFilterConfiguration FilterConfiguration { get; set; }
    }

    public interface IHaveHostUrl : IResourceInterface
    {
        dynamic HostUrl { get; set; }
    }

    public interface IHaveInclusionFilters : IResourceInterface
    {
        dynamic InclusionFilters { get; set; }
    }

    public interface IHaveExclusionFilters : IResourceInterface
    {
        dynamic ExclusionFilters { get; set; }
    }

    public interface IHaveURI : IResourceInterface
    {
        dynamic URI { get; set; }
    }

    public interface IHaveVectorField : IResourceInterface
    {
        dynamic VectorField { get; set; }
    }

    public interface IHaveVariableName : IResourceInterface
    {
        dynamic VariableName { get; set; }
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

    public interface IHaveDay : IResourceInterface
    {
        dynamic Day { get; set; }
    }

    public interface IHaveHours : IResourceInterface
    {
        dynamic Hours { get; set; }
    }

    public interface IHaveStringList : IResourceInterface
    {
        dynamic StringList { get; set; }
    }

    public interface IHaveChannel : IResourceInterface
    {
        dynamic Channel { get; set; }
    }

    public interface IHaveDialingCapacity : IResourceInterface
    {
        dynamic DialingCapacity { get; set; }
    }

    public interface IHaveAgentlessConfig : IResourceInterface
    {
        dynamic AgentlessConfig { get; set; }
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

    public interface IHaveUsageStrategy : IResourceInterface
    {
        dynamic UsageStrategy { get; set; }
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

    public interface IHaveCapacityReservationResourceGroupArn : IResourceInterface
    {
        dynamic CapacityReservationResourceGroupArn { get; set; }
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

    public interface IHaveRetries : IResourceInterface
    {
        dynamic Retries { get; set; }
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

    public interface IHaveRuleId : IResourceInterface
    {
        dynamic RuleId { get; set; }
    }

    public interface IHaveIpRange : IResourceInterface
    {
        dynamic IpRange { get; set; }
    }

    public interface IHaveEndpointId : IResourceInterface
    {
        dynamic EndpointId { get; set; }
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

    public interface IHaveConditionLanguageVersion : IResourceInterface
    {
        dynamic ConditionLanguageVersion { get; set; }
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

    public interface IHaveDateValue : IResourceInterface
    {
        dynamic DateValue { get; set; }
    }

    public interface IHaveStringListValue : IResourceInterface
    {
        dynamic StringListValue { get; set; }
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

    public interface IHaveColumns : IResourceInterface
    {
        dynamic Columns { get; set; }
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

    public interface IHaveMediaLiveChannelTypesRec601SettingsRec601Settings : IResourceInterface
    {
        Humidifier.MediaLive.ChannelTypes.Rec601Settings Rec601Settings { get; set; }
    }

    public interface IHaveMediaLiveChannelTypesRec709SettingsRec709Settings : IResourceInterface
    {
        Humidifier.MediaLive.ChannelTypes.Rec709Settings Rec709Settings { get; set; }
    }

    public interface IHaveMediaLiveChannelTypesColorSpacePassthroughSettingsColorSpacePassthroughSettings : IResourceInterface
    {
        Humidifier.MediaLive.ChannelTypes.ColorSpacePassthroughSettings ColorSpacePassthroughSettings { get; set; }
    }

    public interface IHaveMediaLiveChannelTypesHdr10SettingsHdr10Settings : IResourceInterface
    {
        Humidifier.MediaLive.ChannelTypes.Hdr10Settings Hdr10Settings { get; set; }
    }

    public interface IHaveQvbrQualityLevel : IResourceInterface
    {
        dynamic QvbrQualityLevel { get; set; }
    }

    public interface IHaveParDenominator : IResourceInterface
    {
        dynamic ParDenominator { get; set; }
    }

    public interface IHaveParNumerator : IResourceInterface
    {
        dynamic ParNumerator { get; set; }
    }

    public interface IHaveBufSize : IResourceInterface
    {
        dynamic BufSize { get; set; }
    }

    public interface IHaveMinIInterval : IResourceInterface
    {
        dynamic MinIInterval { get; set; }
    }

    public interface IHaveSceneChangeDetect : IResourceInterface
    {
        dynamic SceneChangeDetect { get; set; }
    }

    public interface IHaveLookAheadRateControl : IResourceInterface
    {
        dynamic LookAheadRateControl { get; set; }
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

    public interface IHaveGopClosedCadence : IResourceInterface
    {
        dynamic GopClosedCadence { get; set; }
    }

    public interface IHaveAdaptiveQuantization : IResourceInterface
    {
        dynamic AdaptiveQuantization { get; set; }
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

    public interface IHavePcrPeriod : IResourceInterface
    {
        dynamic PcrPeriod { get; set; }
    }

    public interface IHavePcrPid : IResourceInterface
    {
        dynamic PcrPid { get; set; }
    }

    public interface IHaveAudioFramesPerPes : IResourceInterface
    {
        dynamic AudioFramesPerPes { get; set; }
    }

    public interface IHavePmtPid : IResourceInterface
    {
        dynamic PmtPid { get; set; }
    }

    public interface IHaveTimedMetadataPid : IResourceInterface
    {
        dynamic TimedMetadataPid { get; set; }
    }

    public interface IHavePcrControl : IResourceInterface
    {
        dynamic PcrControl { get; set; }
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

    public interface IHaveSubjectKey : IResourceInterface
    {
        dynamic SubjectKey { get; set; }
    }

    public interface IHaveRolesKey : IResourceInterface
    {
        dynamic RolesKey { get; set; }
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

    public interface IHaveQuickSightAnalysisTypesGeospatialColorFillColor : IResourceInterface
    {
        Humidifier.QuickSight.AnalysisTypes.GeospatialColor FillColor { get; set; }
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

    public interface IHaveQuickSightAnalysisTypesCustomActionNavigationOperationNavigationOperation : IResourceInterface
    {
        Humidifier.QuickSight.AnalysisTypes.CustomActionNavigationOperation NavigationOperation { get; set; }
    }

    public interface IHaveQuickSightAnalysisTypesCustomActionSetParametersOperationSetParametersOperation : IResourceInterface
    {
        Humidifier.QuickSight.AnalysisTypes.CustomActionSetParametersOperation SetParametersOperation { get; set; }
    }

    public interface IHaveQuickSightAnalysisTypesCustomActionURLOperationURLOperation : IResourceInterface
    {
        Humidifier.QuickSight.AnalysisTypes.CustomActionURLOperation URLOperation { get; set; }
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

    public interface IHavePluginArn : IResourceInterface
    {
        dynamic PluginArn { get; set; }
    }

    public interface IHaveAxisName : IResourceInterface
    {
        dynamic AxisName { get; set; }
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

    public interface IHaveSheetImageId : IResourceInterface
    {
        dynamic SheetImageId { get; set; }
    }

    public interface IHaveImageContentAltText : IResourceInterface
    {
        dynamic ImageContentAltText { get; set; }
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

    public interface IHaveQuickSightDashboardTypesGeospatialColorFillColor : IResourceInterface
    {
        Humidifier.QuickSight.DashboardTypes.GeospatialColor FillColor { get; set; }
    }

    public interface IHaveQuickSightDashboardTypesChartAxisLabelOptionsXAxisLabelOptions : IResourceInterface
    {
        Humidifier.QuickSight.DashboardTypes.ChartAxisLabelOptions XAxisLabelOptions { get; set; }
    }

    public interface IHaveQuickSightDashboardTypesAxisDisplayOptionsXAxisDisplayOptions : IResourceInterface
    {
        Humidifier.QuickSight.DashboardTypes.AxisDisplayOptions XAxisDisplayOptions { get; set; }
    }

    public interface IHaveQuickSightDashboardTypesCustomActionNavigationOperationNavigationOperation : IResourceInterface
    {
        Humidifier.QuickSight.DashboardTypes.CustomActionNavigationOperation NavigationOperation { get; set; }
    }

    public interface IHaveQuickSightDashboardTypesCustomActionSetParametersOperationSetParametersOperation : IResourceInterface
    {
        Humidifier.QuickSight.DashboardTypes.CustomActionSetParametersOperation SetParametersOperation { get; set; }
    }

    public interface IHaveQuickSightDashboardTypesCustomActionURLOperationURLOperation : IResourceInterface
    {
        Humidifier.QuickSight.DashboardTypes.CustomActionURLOperation URLOperation { get; set; }
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

    public interface IHaveDaysAfterInitiation : IResourceInterface
    {
        dynamic DaysAfterInitiation { get; set; }
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

    public interface IHaveListOfWisdomAIAgentTypesAssociationConfigurationAssociationConfigurations : IResourceInterface
    {
        List<Humidifier.Wisdom.AIAgentTypes.AssociationConfiguration> AssociationConfigurations { get; set; }
    }

    public interface IHaveTemplateArn : IResourceInterface
    {
        dynamic TemplateArn { get; set; }
    }

    public interface IHaveCertificateSigningRequest : IResourceInterface
    {
        dynamic CertificateSigningRequest { get; set; }
    }

    public interface IHaveSourceAccount : IResourceInterface
    {
        dynamic SourceAccount { get; set; }
    }

    public interface IHaveAuthenticationStrategy : IResourceInterface
    {
        dynamic AuthenticationStrategy { get; set; }
    }

    public interface IHaveBroker : IResourceInterface
    {
        dynamic Broker { get; set; }
    }

    public interface IHaveListOfAmplifyAppTypesEnvironmentVariableEnvironmentVariables : IResourceInterface
    {
        List<Humidifier.Amplify.AppTypes.EnvironmentVariable> EnvironmentVariables { get; set; }
    }

    public interface IHaveAmplifyAppTypesBasicAuthConfigBasicAuthConfig : IResourceInterface
    {
        Humidifier.Amplify.AppTypes.BasicAuthConfig BasicAuthConfig { get; set; }
    }

    public interface IHaveEnablePerformanceMode : IResourceInterface
    {
        dynamic EnablePerformanceMode { get; set; }
    }

    public interface IHavePullRequestEnvironmentName : IResourceInterface
    {
        dynamic PullRequestEnvironmentName { get; set; }
    }

    public interface IHaveEnablePullRequestPreview : IResourceInterface
    {
        dynamic EnablePullRequestPreview { get; set; }
    }

    public interface IHaveEnableAutoBuild : IResourceInterface
    {
        dynamic EnableAutoBuild { get; set; }
    }

    public interface IHaveComponentType : IResourceInterface
    {
        dynamic ComponentType { get; set; }
    }

    public interface IHaveSchemaVersion : IResourceInterface
    {
        dynamic SchemaVersion { get; set; }
    }

    public interface IHaveSourceId : IResourceInterface
    {
        dynamic SourceId { get; set; }
    }

    public interface IHaveAmplifyUIBuilderComponentTypesComponentPropertyProperties : IResourceInterface
    {
        Dictionary<string, Humidifier.AmplifyUIBuilder.ComponentTypes.ComponentProperty> Properties { get; set; }
    }

    public interface IHaveAmplifyUIBuilderComponentTypesComponentEventEvents : IResourceInterface
    {
        Dictionary<string, Humidifier.AmplifyUIBuilder.ComponentTypes.ComponentEvent> Events { get; set; }
    }

    public interface IHaveOverrides : IResourceInterface
    {
        dynamic Overrides { get; set; }
    }

    public interface IHaveListOfAmplifyUIBuilderComponentTypesComponentChildChildren : IResourceInterface
    {
        List<Humidifier.AmplifyUIBuilder.ComponentTypes.ComponentChild> Children { get; set; }
    }

    public interface IHaveIdentitySource : IResourceInterface
    {
        dynamic IdentitySource { get; set; }
    }

    public interface IHaveDomainNameArn : IResourceInterface
    {
        dynamic DomainNameArn { get; set; }
    }

    public interface IHaveOwnershipVerificationCertificateArn : IResourceInterface
    {
        dynamic OwnershipVerificationCertificateArn { get; set; }
    }

    public interface IHaveDynDicOfResponseTemplates : IResourceInterface
    {
        Dictionary<string, dynamic> ResponseTemplates { get; set; }
    }

    public interface IHaveResponseType : IResourceInterface
    {
        dynamic ResponseType { get; set; }
    }

    public interface IHaveApiKeyRequired : IResourceInterface
    {
        dynamic ApiKeyRequired { get; set; }
    }

    public interface IHaveParentId : IResourceInterface
    {
        dynamic ParentId { get; set; }
    }

    public interface IHaveDisableExecuteApiEndpoint : IResourceInterface
    {
        dynamic DisableExecuteApiEndpoint { get; set; }
    }

    public interface IHaveFailOnWarnings : IResourceInterface
    {
        dynamic FailOnWarnings { get; set; }
    }

    public interface IHaveDocumentationVersion : IResourceInterface
    {
        dynamic DocumentationVersion { get; set; }
    }

    public interface IHaveTracingEnabled : IResourceInterface
    {
        dynamic TracingEnabled { get; set; }
    }

    public interface IHaveCacheClusterSize : IResourceInterface
    {
        dynamic CacheClusterSize { get; set; }
    }

    public interface IHaveCacheClusterEnabled : IResourceInterface
    {
        dynamic CacheClusterEnabled { get; set; }
    }

    public interface IHaveTargetArns : IResourceInterface
    {
        dynamic TargetArns { get; set; }
    }

    public interface IHaveCredentialsArn : IResourceInterface
    {
        dynamic CredentialsArn { get; set; }
    }

    public interface IHaveProtocolType : IResourceInterface
    {
        dynamic ProtocolType { get; set; }
    }

    public interface IHaveRouteKey : IResourceInterface
    {
        dynamic RouteKey { get; set; }
    }

    public interface IHaveTemplateSelectionExpression : IResourceInterface
    {
        dynamic TemplateSelectionExpression { get; set; }
    }

    public interface IHaveIntegrationMethod : IResourceInterface
    {
        dynamic IntegrationMethod { get; set; }
    }

    public interface IHavePassthroughBehavior : IResourceInterface
    {
        dynamic PassthroughBehavior { get; set; }
    }

    public interface IHaveConnectionId : IResourceInterface
    {
        dynamic ConnectionId { get; set; }
    }

    public interface IHavePayloadFormatVersion : IResourceInterface
    {
        dynamic PayloadFormatVersion { get; set; }
    }

    public interface IHaveDynDicOfRequestTemplates : IResourceInterface
    {
        Dictionary<string, dynamic> RequestTemplates { get; set; }
    }

    public interface IHaveContentHandlingStrategy : IResourceInterface
    {
        dynamic ContentHandlingStrategy { get; set; }
    }

    public interface IHaveModelSelectionExpression : IResourceInterface
    {
        dynamic ModelSelectionExpression { get; set; }
    }

    public interface IHaveAutoDeploy : IResourceInterface
    {
        dynamic AutoDeploy { get; set; }
    }

    public interface IHaveRouteSettings : IResourceInterface
    {
        dynamic RouteSettings { get; set; }
    }

    public interface IHaveStageVariables : IResourceInterface
    {
        dynamic StageVariables { get; set; }
    }

    public interface IHaveLocationUri : IResourceInterface
    {
        dynamic LocationUri { get; set; }
    }

    public interface IHaveDeletionProtectionCheck : IResourceInterface
    {
        dynamic DeletionProtectionCheck { get; set; }
    }

    public interface IHaveConfigurationProfileId : IResourceInterface
    {
        dynamic ConfigurationProfileId { get; set; }
    }

    public interface IHaveLatestVersionNumber : IResourceInterface
    {
        dynamic LatestVersionNumber { get; set; }
    }

    public interface IHaveVersionLabel : IResourceInterface
    {
        dynamic VersionLabel { get; set; }
    }

    public interface IHaveConnectorLabel : IResourceInterface
    {
        dynamic ConnectorLabel { get; set; }
    }

    public interface IHaveVirtualGatewayName : IResourceInterface
    {
        dynamic VirtualGatewayName { get; set; }
    }

    public interface IHaveVirtualNodeName : IResourceInterface
    {
        dynamic VirtualNodeName { get; set; }
    }

    public interface IHaveAttributesToDelete : IResourceInterface
    {
        dynamic AttributesToDelete { get; set; }
    }

    public interface IHaveLaunchPath : IResourceInterface
    {
        dynamic LaunchPath { get; set; }
    }

    public interface IHaveFleetName : IResourceInterface
    {
        dynamic FleetName { get; set; }
    }

    public interface IHaveFleetType : IResourceInterface
    {
        dynamic FleetType { get; set; }
    }

    public interface IHaveMaxUserDurationInSeconds : IResourceInterface
    {
        dynamic MaxUserDurationInSeconds { get; set; }
    }

    public interface IHaveIdleDisconnectTimeoutInSeconds : IResourceInterface
    {
        dynamic IdleDisconnectTimeoutInSeconds { get; set; }
    }

    public interface IHaveDisconnectTimeoutInSeconds : IResourceInterface
    {
        dynamic DisconnectTimeoutInSeconds { get; set; }
    }

    public interface IHaveMaxConcurrentSessions : IResourceInterface
    {
        dynamic MaxConcurrentSessions { get; set; }
    }

    public interface IHaveImageArn : IResourceInterface
    {
        dynamic ImageArn { get; set; }
    }

    public interface IHaveMessageAction : IResourceInterface
    {
        dynamic MessageAction { get; set; }
    }

    public interface IHaveOwnerContact : IResourceInterface
    {
        dynamic OwnerContact { get; set; }
    }

    public interface IHaveAtRestEncryptionEnabled : IResourceInterface
    {
        dynamic AtRestEncryptionEnabled { get; set; }
    }

    public interface IHaveMetricsConfig : IResourceInterface
    {
        dynamic MetricsConfig { get; set; }
    }

    public interface IHaveRequestMappingTemplate : IResourceInterface
    {
        dynamic RequestMappingTemplate { get; set; }
    }

    public interface IHaveResponseMappingTemplate : IResourceInterface
    {
        dynamic ResponseMappingTemplate { get; set; }
    }

    public interface IHaveMaxBatchSize : IResourceInterface
    {
        dynamic MaxBatchSize { get; set; }
    }

    public interface IHaveResponseMappingTemplateS3Location : IResourceInterface
    {
        dynamic ResponseMappingTemplateS3Location { get; set; }
    }

    public interface IHaveDataSourceName : IResourceInterface
    {
        dynamic DataSourceName { get; set; }
    }

    public interface IHaveRequestMappingTemplateS3Location : IResourceInterface
    {
        dynamic RequestMappingTemplateS3Location { get; set; }
    }

    public interface IHaveAppSyncGraphQLApiTypesOpenIDConnectConfigOpenIDConnectConfig : IResourceInterface
    {
        Humidifier.AppSync.GraphQLApiTypes.OpenIDConnectConfig OpenIDConnectConfig { get; set; }
    }

    public interface IHaveAppSyncGraphQLApiTypesLambdaAuthorizerConfigLambdaAuthorizerConfig : IResourceInterface
    {
        Humidifier.AppSync.GraphQLApiTypes.LambdaAuthorizerConfig LambdaAuthorizerConfig { get; set; }
    }

    public interface IHaveLaunchConfigurationName : IResourceInterface
    {
        dynamic LaunchConfigurationName { get; set; }
    }

    public interface IHavePlacementGroup : IResourceInterface
    {
        dynamic PlacementGroup { get; set; }
    }

    public interface IHaveIamInstanceProfile : IResourceInterface
    {
        dynamic IamInstanceProfile { get; set; }
    }

    public interface IHaveRamDiskId : IResourceInterface
    {
        dynamic RamDiskId { get; set; }
    }

    public interface IHaveLifecycleHookName : IResourceInterface
    {
        dynamic LifecycleHookName { get; set; }
    }

    public interface IHaveLifecycleTransition : IResourceInterface
    {
        dynamic LifecycleTransition { get; set; }
    }

    public interface IHaveHeartbeatTimeout : IResourceInterface
    {
        dynamic HeartbeatTimeout { get; set; }
    }

    public interface IHaveNotificationMetadata : IResourceInterface
    {
        dynamic NotificationMetadata { get; set; }
    }

    public interface IHaveDefaultResult : IResourceInterface
    {
        dynamic DefaultResult { get; set; }
    }

    public interface IHaveNotificationTargetARN : IResourceInterface
    {
        dynamic NotificationTargetARN { get; set; }
    }

    public interface IHaveMetricAggregationType : IResourceInterface
    {
        dynamic MetricAggregationType { get; set; }
    }

    public interface IHaveMinAdjustmentMagnitude : IResourceInterface
    {
        dynamic MinAdjustmentMagnitude { get; set; }
    }

    public interface IHavePhone : IResourceInterface
    {
        dynamic Phone { get; set; }
    }

    public interface IHaveLogging : IResourceInterface
    {
        dynamic Logging { get; set; }
    }

    public interface IHaveBusinessName : IResourceInterface
    {
        dynamic BusinessName { get; set; }
    }

    public interface IHaveDynDicOfBackupVaultTags : IResourceInterface
    {
        Dictionary<string, dynamic> BackupVaultTags { get; set; }
    }

    public interface IHaveBackupVaultName : IResourceInterface
    {
        dynamic BackupVaultName { get; set; }
    }

    public interface IHaveAccessPolicy : IResourceInterface
    {
        dynamic AccessPolicy { get; set; }
    }

    public interface IHaveMaxRetentionDays : IResourceInterface
    {
        dynamic MaxRetentionDays { get; set; }
    }

    public interface IHaveMinRetentionDays : IResourceInterface
    {
        dynamic MinRetentionDays { get; set; }
    }

    public interface IHaveRestoreTestingPlanName : IResourceInterface
    {
        dynamic RestoreTestingPlanName { get; set; }
    }

    public interface IHaveBatchJobDefinitionTypesEksPropertiesEksProperties : IResourceInterface
    {
        Humidifier.Batch.JobDefinitionTypes.EksProperties EksProperties { get; set; }
    }

    public interface IHaveSkipResourceInUseCheckOnDelete : IResourceInterface
    {
        dynamic SkipResourceInUseCheckOnDelete { get; set; }
    }

    public interface IHaveDynDicOfTestAliasTags : IResourceInterface
    {
        Dictionary<string, dynamic> TestAliasTags { get; set; }
    }

    public interface IHaveIdleSessionTTLInSeconds : IResourceInterface
    {
        dynamic IdleSessionTTLInSeconds { get; set; }
    }

    public interface IHaveAgentName : IResourceInterface
    {
        dynamic AgentName { get; set; }
    }

    public interface IHaveListOfBedrockAgentAliasTypesAgentAliasRoutingConfigurationListItemRoutingConfiguration : IResourceInterface
    {
        List<Humidifier.Bedrock.AgentAliasTypes.AgentAliasRoutingConfigurationListItem> RoutingConfiguration { get; set; }
    }

    public interface IHaveDefinitionString : IResourceInterface
    {
        dynamic DefinitionString { get; set; }
    }

    public interface IHaveDefinitionSubstitutions : IResourceInterface
    {
        dynamic DefinitionSubstitutions { get; set; }
    }

    public interface IHaveBlockedInputMessaging : IResourceInterface
    {
        dynamic BlockedInputMessaging { get; set; }
    }

    public interface IHaveBlockedOutputsMessaging : IResourceInterface
    {
        dynamic BlockedOutputsMessaging { get; set; }
    }

    public interface IHaveBudgetName : IResourceInterface
    {
        dynamic BudgetName { get; set; }
    }

    public interface IHaveMonitorName : IResourceInterface
    {
        dynamic MonitorName { get; set; }
    }

    public interface IHaveRuleVersion : IResourceInterface
    {
        dynamic RuleVersion { get; set; }
    }

    public interface IHaveRules : IResourceInterface
    {
        dynamic Rules { get; set; }
    }

    public interface IHaveS3Region : IResourceInterface
    {
        dynamic S3Region { get; set; }
    }

    public interface IHaveTimeUnit : IResourceInterface
    {
        dynamic TimeUnit { get; set; }
    }

    public interface IHaveClientSideTimestampsEnabled : IResourceInterface
    {
        dynamic ClientSideTimestampsEnabled { get; set; }
    }

    public interface IHaveSubjectAlternativeNames : IResourceInterface
    {
        dynamic SubjectAlternativeNames { get; set; }
    }

    public interface IHaveUserRoleRequired : IResourceInterface
    {
        dynamic UserRoleRequired { get; set; }
    }

    public interface IHaveCustomizationResourceArns : IResourceInterface
    {
        dynamic CustomizationResourceArns { get; set; }
    }

    public interface IHaveSnsTopicArns : IResourceInterface
    {
        dynamic SnsTopicArns { get; set; }
    }

    public interface IHaveGuardrailPolicies : IResourceInterface
    {
        dynamic GuardrailPolicies { get; set; }
    }

    public interface IHaveConfigurationName : IResourceInterface
    {
        dynamic ConfigurationName { get; set; }
    }

    public interface IHaveQueryLogStatus : IResourceInterface
    {
        dynamic QueryLogStatus { get; set; }
    }

    public interface IHaveHookStatus : IResourceInterface
    {
        dynamic HookStatus { get; set; }
    }

    public interface IHaveTargetOperations : IResourceInterface
    {
        dynamic TargetOperations { get; set; }
    }

    public interface IHaveFailureMode : IResourceInterface
    {
        dynamic FailureMode { get; set; }
    }

    public interface IHaveTypeVersionArn : IResourceInterface
    {
        dynamic TypeVersionArn { get; set; }
    }

    public interface IHaveSchemaHandlerPackage : IResourceInterface
    {
        dynamic SchemaHandlerPackage { get; set; }
    }

    public interface IHaveModuleName : IResourceInterface
    {
        dynamic ModuleName { get; set; }
    }

    public interface IHaveTemplateURL : IResourceInterface
    {
        dynamic TemplateURL { get; set; }
    }

    public interface IHaveStackSetName : IResourceInterface
    {
        dynamic StackSetName { get; set; }
    }

    public interface IHaveIpCount : IResourceInterface
    {
        dynamic IpCount { get; set; }
    }

    public interface IHaveTerminationProtectionEnabled : IResourceInterface
    {
        dynamic TerminationProtectionEnabled { get; set; }
    }

    public interface IHaveRetentionPeriod : IResourceInterface
    {
        dynamic RetentionPeriod { get; set; }
    }

    public interface IHaveListOfCloudWatchAlarmTypesDimensionDimensions : IResourceInterface
    {
        List<Humidifier.CloudWatch.AlarmTypes.Dimension> Dimensions { get; set; }
    }

    public interface IHaveOKActions : IResourceInterface
    {
        dynamic OKActions { get; set; }
    }

    public interface IHaveAlarmActions : IResourceInterface
    {
        dynamic AlarmActions { get; set; }
    }

    public interface IHaveActionsEnabled : IResourceInterface
    {
        dynamic ActionsEnabled { get; set; }
    }

    public interface IHaveAlarmDescription : IResourceInterface
    {
        dynamic AlarmDescription { get; set; }
    }

    public interface IHaveInsufficientDataActions : IResourceInterface
    {
        dynamic InsufficientDataActions { get; set; }
    }

    public interface IHaveDashboardName : IResourceInterface
    {
        dynamic DashboardName { get; set; }
    }

    public interface IHaveFirehoseArn : IResourceInterface
    {
        dynamic FirehoseArn { get; set; }
    }

    public interface IHavePermissionsPolicyDocument : IResourceInterface
    {
        dynamic PermissionsPolicyDocument { get; set; }
    }

    public interface IHaveDomainOwner : IResourceInterface
    {
        dynamic DomainOwner { get; set; }
    }

    public interface IHaveToken : IResourceInterface
    {
        dynamic Token { get; set; }
    }

    public interface IHaveHostArn : IResourceInterface
    {
        dynamic HostArn { get; set; }
    }

    public interface IHaveDeploymentConfigName : IResourceInterface
    {
        dynamic DeploymentConfigName { get; set; }
    }

    public interface IHaveCodePipelinePipelineTypesArtifactStoreArtifactStore : IResourceInterface
    {
        Humidifier.CodePipeline.PipelineTypes.ArtifactStore ArtifactStore { get; set; }
    }

    public interface IHaveAuthentication : IResourceInterface
    {
        dynamic Authentication { get; set; }
    }

    public interface IHaveSyncType : IResourceInterface
    {
        dynamic SyncType { get; set; }
    }

    public interface IHaveCreatedBy : IResourceInterface
    {
        dynamic CreatedBy { get; set; }
    }

    public interface IHaveTargetAddress : IResourceInterface
    {
        dynamic TargetAddress { get; set; }
    }

    public interface IHaveIdentityProviderName : IResourceInterface
    {
        dynamic IdentityProviderName { get; set; }
    }

    public interface IHaveSettings : IResourceInterface
    {
        dynamic Settings { get; set; }
    }

    public interface IHaveDataAccessRoleArn : IResourceInterface
    {
        dynamic DataAccessRoleArn { get; set; }
    }

    public interface IHaveModelKmsKeyId : IResourceInterface
    {
        dynamic ModelKmsKeyId { get; set; }
    }

    public interface IHaveConfigRuleName : IResourceInterface
    {
        dynamic ConfigRuleName { get; set; }
    }

    public interface IHaveDeliveryS3Bucket : IResourceInterface
    {
        dynamic DeliveryS3Bucket { get; set; }
    }

    public interface IHaveDeliveryS3KeyPrefix : IResourceInterface
    {
        dynamic DeliveryS3KeyPrefix { get; set; }
    }

    public interface IHaveTemplateS3Uri : IResourceInterface
    {
        dynamic TemplateS3Uri { get; set; }
    }

    public interface IHaveExcludedAccounts : IResourceInterface
    {
        dynamic ExcludedAccounts { get; set; }
    }

    public interface IHaveSecurityProfileName : IResourceInterface
    {
        dynamic SecurityProfileName { get; set; }
    }

    public interface IHaveViewArn : IResourceInterface
    {
        dynamic ViewArn { get; set; }
    }

    public interface IHaveTargetIdentifier : IResourceInterface
    {
        dynamic TargetIdentifier { get; set; }
    }

    public interface IHaveObjectTypeName : IResourceInterface
    {
        dynamic ObjectTypeName { get; set; }
    }

    public interface IHaveSegmentDefinitionName : IResourceInterface
    {
        dynamic SegmentDefinitionName { get; set; }
    }

    public interface IHaveReplicationFactor : IResourceInterface
    {
        dynamic ReplicationFactor { get; set; }
    }

    public interface IHaveCreateInterval : IResourceInterface
    {
        dynamic CreateInterval { get; set; }
    }

    public interface IHaveExtendDeletion : IResourceInterface
    {
        dynamic ExtendDeletion { get; set; }
    }

    public interface IHaveDLMLifecyclePolicyTypesExclusionsExclusions : IResourceInterface
    {
        Humidifier.DLM.LifecyclePolicyTypes.Exclusions Exclusions { get; set; }
    }

    public interface IHaveDLMLifecyclePolicyTypesCrossRegionCopyTargetsCrossRegionCopyTargets : IResourceInterface
    {
        Humidifier.DLM.LifecyclePolicyTypes.CrossRegionCopyTargets CrossRegionCopyTargets { get; set; }
    }

    public interface IHaveRetainInterval : IResourceInterface
    {
        dynamic RetainInterval { get; set; }
    }

    public interface IHaveCertificatePem : IResourceInterface
    {
        dynamic CertificatePem { get; set; }
    }

    public interface IHaveMigrationProjectIdentifier : IResourceInterface
    {
        dynamic MigrationProjectIdentifier { get; set; }
    }

    public interface IHaveDataProviderName : IResourceInterface
    {
        dynamic DataProviderName { get; set; }
    }

    public interface IHaveDataProviderIdentifier : IResourceInterface
    {
        dynamic DataProviderIdentifier { get; set; }
    }

    public interface IHaveEngineName : IResourceInterface
    {
        dynamic EngineName { get; set; }
    }

    public interface IHaveInstanceProfileIdentifier : IResourceInterface
    {
        dynamic InstanceProfileIdentifier { get; set; }
    }

    public interface IHaveInstanceProfileArn : IResourceInterface
    {
        dynamic InstanceProfileArn { get; set; }
    }

    public interface IHaveTableMappings : IResourceInterface
    {
        dynamic TableMappings { get; set; }
    }

    public interface IHaveSourceEndpointArn : IResourceInterface
    {
        dynamic SourceEndpointArn { get; set; }
    }

    public interface IHaveTargetEndpointArn : IResourceInterface
    {
        dynamic TargetEndpointArn { get; set; }
    }

    public interface IHaveReplicationSubnetGroupIdentifier : IResourceInterface
    {
        dynamic ReplicationSubnetGroupIdentifier { get; set; }
    }

    public interface IHaveCronExpression : IResourceInterface
    {
        dynamic CronExpression { get; set; }
    }

    public interface IHaveSubnetArns : IResourceInterface
    {
        dynamic SubnetArns { get; set; }
    }

    public interface IHaveAccessPointArn : IResourceInterface
    {
        dynamic AccessPointArn { get; set; }
    }

    public interface IHaveAccessKey : IResourceInterface
    {
        dynamic AccessKey { get; set; }
    }

    public interface IHaveSourceLocationArn : IResourceInterface
    {
        dynamic SourceLocationArn { get; set; }
    }

    public interface IHaveGlossaryTerms : IResourceInterface
    {
        dynamic GlossaryTerms { get; set; }
    }

    public interface IHaveProvisioningRoleArn : IResourceInterface
    {
        dynamic ProvisioningRoleArn { get; set; }
    }

    public interface IHaveEnvironmentBlueprintIdentifier : IResourceInterface
    {
        dynamic EnvironmentBlueprintIdentifier { get; set; }
    }

    public interface IHaveUserIdentifier : IResourceInterface
    {
        dynamic UserIdentifier { get; set; }
    }

    public interface IHaveMaxWorkerCount : IResourceInterface
    {
        dynamic MaxWorkerCount { get; set; }
    }

    public interface IHaveMinWorkerCount : IResourceInterface
    {
        dynamic MinWorkerCount { get; set; }
    }

    public interface IHaveIdentityCenterInstanceArn : IResourceInterface
    {
        dynamic IdentityCenterInstanceArn { get; set; }
    }

    public interface IHaveQueueId : IResourceInterface
    {
        dynamic QueueId { get; set; }
    }

    public interface IHaveFleetId : IResourceInterface
    {
        dynamic FleetId { get; set; }
    }

    public interface IHaveDisableEmailNotification : IResourceInterface
    {
        dynamic DisableEmailNotification { get; set; }
    }

    public interface IHaveCreateAlias : IResourceInterface
    {
        dynamic CreateAlias { get; set; }
    }

    public interface IHaveEnableSso : IResourceInterface
    {
        dynamic EnableSso { get; set; }
    }

    public interface IHaveShortName : IResourceInterface
    {
        dynamic ShortName { get; set; }
    }

    public interface IHaveRotateMasterUserPassword : IResourceInterface
    {
        dynamic RotateMasterUserPassword { get; set; }
    }

    public interface IHaveCACertificateIdentifier : IResourceInterface
    {
        dynamic CACertificateIdentifier { get; set; }
    }

    public interface IHaveCertificateRotationRestart : IResourceInterface
    {
        dynamic CertificateRotationRestart { get; set; }
    }

    public interface IHaveEnablePerformanceInsights : IResourceInterface
    {
        dynamic EnablePerformanceInsights { get; set; }
    }

    public interface IHaveAdminUserPassword : IResourceInterface
    {
        dynamic AdminUserPassword { get; set; }
    }

    public interface IHaveShardCount : IResourceInterface
    {
        dynamic ShardCount { get; set; }
    }

    public interface IHaveDynamoDBGlobalTableTypesPointInTimeRecoverySpecificationPointInTimeRecoverySpecification : IResourceInterface
    {
        Humidifier.DynamoDB.GlobalTableTypes.PointInTimeRecoverySpecification PointInTimeRecoverySpecification { get; set; }
    }

    public interface IHaveDynamoDBGlobalTableTypesWarmThroughputWarmThroughput : IResourceInterface
    {
        Humidifier.DynamoDB.GlobalTableTypes.WarmThroughput WarmThroughput { get; set; }
    }

    public interface IHaveDynamoDBGlobalTableTypesWriteProvisionedThroughputSettingsWriteProvisionedThroughputSettings : IResourceInterface
    {
        Humidifier.DynamoDB.GlobalTableTypes.WriteProvisionedThroughputSettings WriteProvisionedThroughputSettings { get; set; }
    }

    public interface IHaveDynamoDBGlobalTableTypesWriteOnDemandThroughputSettingsWriteOnDemandThroughputSettings : IResourceInterface
    {
        Humidifier.DynamoDB.GlobalTableTypes.WriteOnDemandThroughputSettings WriteOnDemandThroughputSettings { get; set; }
    }

    public interface IHaveDynamoDBTableTypesOnDemandThroughputOnDemandThroughput : IResourceInterface
    {
        Humidifier.DynamoDB.TableTypes.OnDemandThroughput OnDemandThroughput { get; set; }
    }

    public interface IHaveDynamoDBTableTypesContributorInsightsSpecificationContributorInsightsSpecification : IResourceInterface
    {
        Humidifier.DynamoDB.TableTypes.ContributorInsightsSpecification ContributorInsightsSpecification { get; set; }
    }

    public interface IHaveDynamoDBTableTypesProvisionedThroughputProvisionedThroughput : IResourceInterface
    {
        Humidifier.DynamoDB.TableTypes.ProvisionedThroughput ProvisionedThroughput { get; set; }
    }

    public interface IHaveDynamoDBTableTypesWarmThroughputWarmThroughput : IResourceInterface
    {
        Humidifier.DynamoDB.TableTypes.WarmThroughput WarmThroughput { get; set; }
    }

    public interface IHaveDynamoDBTableTypesResourcePolicyResourcePolicy : IResourceInterface
    {
        Humidifier.DynamoDB.TableTypes.ResourcePolicy ResourcePolicy { get; set; }
    }

    public interface IHaveDeletionProtectionEnabled : IResourceInterface
    {
        dynamic DeletionProtectionEnabled { get; set; }
    }

    public interface IHaveTableClass : IResourceInterface
    {
        dynamic TableClass { get; set; }
    }

    public interface IHaveInstancePlatform : IResourceInterface
    {
        dynamic InstancePlatform { get; set; }
    }

    public interface IHaveInstanceMatchCriteria : IResourceInterface
    {
        dynamic InstanceMatchCriteria { get; set; }
    }

    public interface IHaveTotalTargetCapacity : IResourceInterface
    {
        dynamic TotalTargetCapacity { get; set; }
    }

    public interface IHaveServerCertificateArn : IResourceInterface
    {
        dynamic ServerCertificateArn { get; set; }
    }

    public interface IHaveDnsServers : IResourceInterface
    {
        dynamic DnsServers { get; set; }
    }

    public interface IHaveExcessCapacityTerminationPolicy : IResourceInterface
    {
        dynamic ExcessCapacityTerminationPolicy { get; set; }
    }

    public interface IHaveValidFrom : IResourceInterface
    {
        dynamic ValidFrom { get; set; }
    }

    public interface IHaveReplaceUnhealthyInstances : IResourceInterface
    {
        dynamic ReplaceUnhealthyInstances { get; set; }
    }

    public interface IHaveTerminateInstancesWithExpiration : IResourceInterface
    {
        dynamic TerminateInstancesWithExpiration { get; set; }
    }

    public interface IHaveLogDestination : IResourceInterface
    {
        dynamic LogDestination { get; set; }
    }

    public interface IHaveGatewayId : IResourceInterface
    {
        dynamic GatewayId { get; set; }
    }

    public interface IHaveNetmaskLength : IResourceInterface
    {
        dynamic NetmaskLength { get; set; }
    }

    public interface IHaveLocale : IResourceInterface
    {
        dynamic Locale { get; set; }
    }

    public interface IHaveAddressFamily : IResourceInterface
    {
        dynamic AddressFamily { get; set; }
    }

    public interface IHaveIpamId : IResourceInterface
    {
        dynamic IpamId { get; set; }
    }

    public interface IHaveListOfEC2InstanceTypesInstanceIpv6AddressIpv6Addresses : IResourceInterface
    {
        List<Humidifier.EC2.InstanceTypes.InstanceIpv6Address> Ipv6Addresses { get; set; }
    }

    public interface IHaveAdditionalInfo : IResourceInterface
    {
        dynamic AdditionalInfo { get; set; }
    }

    public interface IHaveInstanceInitiatedShutdownBehavior : IResourceInterface
    {
        dynamic InstanceInitiatedShutdownBehavior { get; set; }
    }

    public interface IHaveDisableApiTermination : IResourceInterface
    {
        dynamic DisableApiTermination { get; set; }
    }

    public interface IHaveRamdiskId : IResourceInterface
    {
        dynamic RamdiskId { get; set; }
    }

    public interface IHaveSourceDestCheck : IResourceInterface
    {
        dynamic SourceDestCheck { get; set; }
    }

    public interface IHaveKeyFormat : IResourceInterface
    {
        dynamic KeyFormat { get; set; }
    }

    public interface IHaveLocalGatewayVirtualInterfaceGroupId : IResourceInterface
    {
        dynamic LocalGatewayVirtualInterfaceGroupId { get; set; }
    }

    public interface IHaveLocalGatewayId : IResourceInterface
    {
        dynamic LocalGatewayId { get; set; }
    }

    public interface IHaveNetworkAclId : IResourceInterface
    {
        dynamic NetworkAclId { get; set; }
    }

    public interface IHaveDestinationIp : IResourceInterface
    {
        dynamic DestinationIp { get; set; }
    }

    public interface IHaveIpv6PrefixCount : IResourceInterface
    {
        dynamic Ipv6PrefixCount { get; set; }
    }

    public interface IHaveIpv4PrefixCount : IResourceInterface
    {
        dynamic Ipv4PrefixCount { get; set; }
    }

    public interface IHaveGroupSet : IResourceInterface
    {
        dynamic GroupSet { get; set; }
    }

    public interface IHaveInterfaceType : IResourceInterface
    {
        dynamic InterfaceType { get; set; }
    }

    public interface IHaveStrategy : IResourceInterface
    {
        dynamic Strategy { get; set; }
    }

    public interface IHaveVpcPeeringConnectionId : IResourceInterface
    {
        dynamic VpcPeeringConnectionId { get; set; }
    }

    public interface IHaveNatGatewayId : IResourceInterface
    {
        dynamic NatGatewayId { get; set; }
    }

    public interface IHaveGroupDescription : IResourceInterface
    {
        dynamic GroupDescription { get; set; }
    }

    public interface IHaveDestinationSecurityGroupId : IResourceInterface
    {
        dynamic DestinationSecurityGroupId { get; set; }
    }

    public interface IHaveSourceSecurityGroupName : IResourceInterface
    {
        dynamic SourceSecurityGroupName { get; set; }
    }

    public interface IHaveSourceSecurityGroupOwnerId : IResourceInterface
    {
        dynamic SourceSecurityGroupOwnerId { get; set; }
    }

    public interface IHaveSourceSecurityGroupId : IResourceInterface
    {
        dynamic SourceSecurityGroupId { get; set; }
    }

    public interface IHaveSourcePrefixListId : IResourceInterface
    {
        dynamic SourcePrefixListId { get; set; }
    }

    public interface IHaveAvailabilityZoneId : IResourceInterface
    {
        dynamic AvailabilityZoneId { get; set; }
    }

    public interface IHaveTrafficMirrorFilterId : IResourceInterface
    {
        dynamic TrafficMirrorFilterId { get; set; }
    }

    public interface IHaveAmazonSideAsn : IResourceInterface
    {
        dynamic AmazonSideAsn { get; set; }
    }

    public interface IHaveTransportTransitGatewayAttachmentId : IResourceInterface
    {
        dynamic TransportTransitGatewayAttachmentId { get; set; }
    }

    public interface IHaveGroupIpAddress : IResourceInterface
    {
        dynamic GroupIpAddress { get; set; }
    }

    public interface IHavePeerRegion : IResourceInterface
    {
        dynamic PeerRegion { get; set; }
    }

    public interface IHaveResourceConfigurationArn : IResourceInterface
    {
        dynamic ResourceConfigurationArn { get; set; }
    }

    public interface IHaveAcceptanceRequired : IResourceInterface
    {
        dynamic AcceptanceRequired { get; set; }
    }

    public interface IHavePeerVpcId : IResourceInterface
    {
        dynamic PeerVpcId { get; set; }
    }

    public interface IHavePolicyEnabled : IResourceInterface
    {
        dynamic PolicyEnabled { get; set; }
    }

    public interface IHaveDeviceTrustProviderType : IResourceInterface
    {
        dynamic DeviceTrustProviderType { get; set; }
    }

    public interface IHaveTrustProviderType : IResourceInterface
    {
        dynamic TrustProviderType { get; set; }
    }

    public interface IHaveUserTrustProviderType : IResourceInterface
    {
        dynamic UserTrustProviderType { get; set; }
    }

    public interface IHaveDevice : IResourceInterface
    {
        dynamic Device { get; set; }
    }

    public interface IHaveRepositoryPolicyText : IResourceInterface
    {
        dynamic RepositoryPolicyText { get; set; }
    }

    public interface IHaveImageTagMutability : IResourceInterface
    {
        dynamic ImageTagMutability { get; set; }
    }

    public interface IHaveLifecyclePolicy : IResourceInterface
    {
        dynamic LifecyclePolicy { get; set; }
    }

    public interface IHaveCapacityProviders : IResourceInterface
    {
        dynamic CapacityProviders { get; set; }
    }

    public interface IHaveTaskDefinition : IResourceInterface
    {
        dynamic TaskDefinition { get; set; }
    }

    public interface IHaveBypassPolicyLockoutSafetyCheck : IResourceInterface
    {
        dynamic BypassPolicyLockoutSafetyCheck { get; set; }
    }

    public interface IHaveThroughputMode : IResourceInterface
    {
        dynamic ThroughputMode { get; set; }
    }

    public interface IHaveAvailabilityZoneName : IResourceInterface
    {
        dynamic AvailabilityZoneName { get; set; }
    }

    public interface IHavePrincipalArn : IResourceInterface
    {
        dynamic PrincipalArn { get; set; }
    }

    public interface IHaveAddonName : IResourceInterface
    {
        dynamic AddonName { get; set; }
    }

    public interface IHaveServiceAccount : IResourceInterface
    {
        dynamic ServiceAccount { get; set; }
    }

    public interface IHaveReleaseLabel : IResourceInterface
    {
        dynamic ReleaseLabel { get; set; }
    }

    public interface IHaveTargetOnDemandCapacity : IResourceInterface
    {
        dynamic TargetOnDemandCapacity { get; set; }
    }

    public interface IHaveTargetSpotCapacity : IResourceInterface
    {
        dynamic TargetSpotCapacity { get; set; }
    }

    public interface IHaveListOfEMRInstanceGroupConfigTypesConfigurationConfigurations : IResourceInterface
    {
        List<Humidifier.EMR.InstanceGroupConfigTypes.Configuration> Configurations { get; set; }
    }

    public interface IHaveJobFlowId : IResourceInterface
    {
        dynamic JobFlowId { get; set; }
    }

    public interface IHaveActionOnFailure : IResourceInterface
    {
        dynamic ActionOnFailure { get; set; }
    }

    public interface IHaveAuthMode : IResourceInterface
    {
        dynamic AuthMode { get; set; }
    }

    public interface IHaveIdentityType : IResourceInterface
    {
        dynamic IdentityType { get; set; }
    }

    public interface IHaveStudioId : IResourceInterface
    {
        dynamic StudioId { get; set; }
    }

    public interface IHaveEMRServerlessApplicationTypesImageConfigurationInputImageConfiguration : IResourceInterface
    {
        Humidifier.EMRServerless.ApplicationTypes.ImageConfigurationInput ImageConfiguration { get; set; }
    }

    public interface IHaveCacheSecurityGroupNames : IResourceInterface
    {
        dynamic CacheSecurityGroupNames { get; set; }
    }

    public interface IHaveIpDiscovery : IResourceInterface
    {
        dynamic IpDiscovery { get; set; }
    }

    public interface IHavePreferredAvailabilityZones : IResourceInterface
    {
        dynamic PreferredAvailabilityZones { get; set; }
    }

    public interface IHaveAutomaticFailoverEnabled : IResourceInterface
    {
        dynamic AutomaticFailoverEnabled { get; set; }
    }

    public interface IHaveDynDicOfProperties : IResourceInterface
    {
        Dictionary<string, dynamic> Properties { get; set; }
    }

    public interface IHaveUserGroupId : IResourceInterface
    {
        dynamic UserGroupId { get; set; }
    }

    public interface IHaveMajorEngineVersion : IResourceInterface
    {
        dynamic MajorEngineVersion { get; set; }
    }

    public interface IHaveAccessString : IResourceInterface
    {
        dynamic AccessString { get; set; }
    }

    public interface IHaveUserIds : IResourceInterface
    {
        dynamic UserIds { get; set; }
    }

    public interface IHavePlatformArn : IResourceInterface
    {
        dynamic PlatformArn { get; set; }
    }

    public interface IHaveSolutionStackName : IResourceInterface
    {
        dynamic SolutionStackName { get; set; }
    }

    public interface IHaveInstances : IResourceInterface
    {
        dynamic Instances { get; set; }
    }

    public interface IHaveUnhealthyThresholdCount : IResourceInterface
    {
        dynamic UnhealthyThresholdCount { get; set; }
    }

    public interface IHaveHealthCheckTimeoutSeconds : IResourceInterface
    {
        dynamic HealthCheckTimeoutSeconds { get; set; }
    }

    public interface IHaveHealthyThresholdCount : IResourceInterface
    {
        dynamic HealthyThresholdCount { get; set; }
    }

    public interface IHaveHealthCheckProtocol : IResourceInterface
    {
        dynamic HealthCheckProtocol { get; set; }
    }

    public interface IHaveHealthCheckPort : IResourceInterface
    {
        dynamic HealthCheckPort { get; set; }
    }

    public interface IHaveAccessPolicies : IResourceInterface
    {
        dynamic AccessPolicies { get; set; }
    }

    public interface IHaveDynDicOfAdvancedOptions : IResourceInterface
    {
        Dictionary<string, dynamic> AdvancedOptions { get; set; }
    }

    public interface IHaveArchiveName : IResourceInterface
    {
        dynamic ArchiveName { get; set; }
    }

    public interface IHaveRetentionDays : IResourceInterface
    {
        dynamic RetentionDays { get; set; }
    }

    public interface IHaveEventSourceName : IResourceInterface
    {
        dynamic EventSourceName { get; set; }
    }

    public interface IHaveEventBusName : IResourceInterface
    {
        dynamic EventBusName { get; set; }
    }

    public interface IHaveRandomizationSalt : IResourceInterface
    {
        dynamic RandomizationSalt { get; set; }
    }

    public interface IHaveSegment : IResourceInterface
    {
        dynamic Segment { get; set; }
    }

    public interface IHavePolicyDescription : IResourceInterface
    {
        dynamic PolicyDescription { get; set; }
    }

    public interface IHaveResourceTypeList : IResourceInterface
    {
        dynamic ResourceTypeList { get; set; }
    }

    public interface IHaveImportedFileChunkSize : IResourceInterface
    {
        dynamic ImportedFileChunkSize { get; set; }
    }

    public interface IHaveStorageCapacity : IResourceInterface
    {
        dynamic StorageCapacity { get; set; }
    }

    public interface IHaveDatasetType : IResourceInterface
    {
        dynamic DatasetType { get; set; }
    }

    public interface IHaveServerSdkVersion : IResourceInterface
    {
        dynamic ServerSdkVersion { get; set; }
    }

    public interface IHaveNewGameSessionProtectionPolicy : IResourceInterface
    {
        dynamic NewGameSessionProtectionPolicy { get; set; }
    }

    public interface IHaveMetricGroups : IResourceInterface
    {
        dynamic MetricGroups { get; set; }
    }

    public interface IHaveNotificationTarget : IResourceInterface
    {
        dynamic NotificationTarget { get; set; }
    }

    public interface IHaveCustomEventData : IResourceInterface
    {
        dynamic CustomEventData { get; set; }
    }

    public interface IHaveTablePrefix : IResourceInterface
    {
        dynamic TablePrefix { get; set; }
    }

    public interface IHavePublicKey : IResourceInterface
    {
        dynamic PublicKey { get; set; }
    }

    public interface IHaveArguments : IResourceInterface
    {
        dynamic Arguments { get; set; }
    }

    public interface IHaveMaintenanceWindow : IResourceInterface
    {
        dynamic MaintenanceWindow { get; set; }
    }

    public interface IHaveSchemaDefinition : IResourceInterface
    {
        dynamic SchemaDefinition { get; set; }
    }

    public interface IHaveOrganizationalUnits : IResourceInterface
    {
        dynamic OrganizationalUnits { get; set; }
    }

    public interface IHaveLoggerDefinitionVersionArn : IResourceInterface
    {
        dynamic LoggerDefinitionVersionArn { get; set; }
    }

    public interface IHaveDeviceDefinitionVersionArn : IResourceInterface
    {
        dynamic DeviceDefinitionVersionArn { get; set; }
    }

    public interface IHaveFunctionDefinitionVersionArn : IResourceInterface
    {
        dynamic FunctionDefinitionVersionArn { get; set; }
    }

    public interface IHaveCoreDefinitionVersionArn : IResourceInterface
    {
        dynamic CoreDefinitionVersionArn { get; set; }
    }

    public interface IHaveResourceDefinitionVersionArn : IResourceInterface
    {
        dynamic ResourceDefinitionVersionArn { get; set; }
    }

    public interface IHaveConnectorDefinitionVersionArn : IResourceInterface
    {
        dynamic ConnectorDefinitionVersionArn { get; set; }
    }

    public interface IHaveSubscriptionDefinitionVersionArn : IResourceInterface
    {
        dynamic SubscriptionDefinitionVersionArn { get; set; }
    }

    public interface IHaveContactPostPassDurationSeconds : IResourceInterface
    {
        dynamic ContactPostPassDurationSeconds { get; set; }
    }

    public interface IHaveContactPrePassDurationSeconds : IResourceInterface
    {
        dynamic ContactPrePassDurationSeconds { get; set; }
    }

    public interface IHaveFindingPublishingFrequency : IResourceInterface
    {
        dynamic FindingPublishingFrequency { get; set; }
    }

    public interface IHaveRank : IResourceInterface
    {
        dynamic Rank { get; set; }
    }

    public interface IHaveInvitationId : IResourceInterface
    {
        dynamic InvitationId { get; set; }
    }

    public interface IHavePermissionsBoundary : IResourceInterface
    {
        dynamic PermissionsBoundary { get; set; }
    }

    public interface IHaveSamlMetadataDocument : IResourceInterface
    {
        dynamic SamlMetadataDocument { get; set; }
    }

    public interface IHaveInsecureIngest : IResourceInterface
    {
        dynamic InsecureIngest { get; set; }
    }

    public interface IHaveChangeDescription : IResourceInterface
    {
        dynamic ChangeDescription { get; set; }
    }

    public interface IHaveParentImage : IResourceInterface
    {
        dynamic ParentImage { get; set; }
    }

    public interface IHaveContainerType : IResourceInterface
    {
        dynamic ContainerType { get; set; }
    }

    public interface IHaveInfrastructureConfigurationArn : IResourceInterface
    {
        dynamic InfrastructureConfigurationArn { get; set; }
    }

    public interface IHaveImageRecipeArn : IResourceInterface
    {
        dynamic ImageRecipeArn { get; set; }
    }

    public interface IHaveDistributionConfigurationArn : IResourceInterface
    {
        dynamic DistributionConfigurationArn { get; set; }
    }

    public interface IHaveContainerRecipeArn : IResourceInterface
    {
        dynamic ContainerRecipeArn { get; set; }
    }

    public interface IHaveEnhancedImageMetadataEnabled : IResourceInterface
    {
        dynamic EnhancedImageMetadataEnabled { get; set; }
    }

    public interface IHaveKeyPair : IResourceInterface
    {
        dynamic KeyPair { get; set; }
    }

    public interface IHaveDynDicOfResourceTags : IResourceInterface
    {
        Dictionary<string, dynamic> ResourceTags { get; set; }
    }

    public interface IHaveCACertificatePem : IResourceInterface
    {
        dynamic CACertificatePem { get; set; }
    }

    public interface IHaveLastUpdatedAt : IResourceInterface
    {
        dynamic LastUpdatedAt { get; set; }
    }

    public interface IHaveCreatedAt : IResourceInterface
    {
        dynamic CreatedAt { get; set; }
    }

    public interface IHaveServiceType : IResourceInterface
    {
        dynamic ServiceType { get; set; }
    }

    public interface IHaveDataExtraDimensions : IResourceInterface
    {
        dynamic DataExtraDimensions { get; set; }
    }

    public interface IHaveModelManifestArn : IResourceInterface
    {
        dynamic ModelManifestArn { get; set; }
    }

    public interface IHaveNodes : IResourceInterface
    {
        dynamic Nodes { get; set; }
    }

    public interface IHaveProjectId : IResourceInterface
    {
        dynamic ProjectId { get; set; }
    }

    public interface IHaveProjectDescription : IResourceInterface
    {
        dynamic ProjectDescription { get; set; }
    }

    public interface IHaveS3Location : IResourceInterface
    {
        dynamic S3Location { get; set; }
    }

    public interface IHaveDisassociateWirelessDevice : IResourceInterface
    {
        dynamic DisassociateWirelessDevice { get; set; }
    }

    public interface IHaveAssociateWirelessDevice : IResourceInterface
    {
        dynamic AssociateWirelessDevice { get; set; }
    }

    public interface IHaveLastUplinkReceivedAt : IResourceInterface
    {
        dynamic LastUplinkReceivedAt { get; set; }
    }

    public interface IHavePendingWindowInDays : IResourceInterface
    {
        dynamic PendingWindowInDays { get; set; }
    }

    public interface IHaveKeyPolicy : IResourceInterface
    {
        dynamic KeyPolicy { get; set; }
    }

    public interface IHaveKeyUsage : IResourceInterface
    {
        dynamic KeyUsage { get; set; }
    }

    public interface IHaveServiceExecutionRoleArn : IResourceInterface
    {
        dynamic ServiceExecutionRoleArn { get; set; }
    }

    public interface IHaveFileFormat : IResourceInterface
    {
        dynamic FileFormat { get; set; }
    }

    public interface IHaveRetentionPeriodHours : IResourceInterface
    {
        dynamic RetentionPeriodHours { get; set; }
    }

    public interface IHaveTableCatalogId : IResourceInterface
    {
        dynamic TableCatalogId { get; set; }
    }

    public interface IHavePermissionsWithGrantOption : IResourceInterface
    {
        dynamic PermissionsWithGrantOption { get; set; }
    }

    public interface IHaveTopics : IResourceInterface
    {
        dynamic Topics { get; set; }
    }

    public interface IHaveStartingPositionTimestamp : IResourceInterface
    {
        dynamic StartingPositionTimestamp { get; set; }
    }

    public interface IHaveQueues : IResourceInterface
    {
        dynamic Queues { get; set; }
    }

    public interface IHaveHandler : IResourceInterface
    {
        dynamic Handler { get; set; }
    }

    public interface IHaveArchitectures : IResourceInterface
    {
        dynamic Architectures { get; set; }
    }

    public interface IHaveOrganizationId : IResourceInterface
    {
        dynamic OrganizationId { get; set; }
    }

    public interface IHaveBotId : IResourceInterface
    {
        dynamic BotId { get; set; }
    }

    public interface IHaveHomeRegion : IResourceInterface
    {
        dynamic HomeRegion { get; set; }
    }

    public interface IHaveProductName : IResourceInterface
    {
        dynamic ProductName { get; set; }
    }

    public interface IHaveSizeInGb : IResourceInterface
    {
        dynamic SizeInGb { get; set; }
    }

    public interface IHaveDiskName : IResourceInterface
    {
        dynamic DiskName { get; set; }
    }

    public interface IHaveAttachedTo : IResourceInterface
    {
        dynamic AttachedTo { get; set; }
    }

    public interface IHaveEventBridgeEnabled : IResourceInterface
    {
        dynamic EventBridgeEnabled { get; set; }
    }

    public interface IHaveSelectionCriteria : IResourceInterface
    {
        dynamic SelectionCriteria { get; set; }
    }

    public interface IHaveFieldDelimiter : IResourceInterface
    {
        dynamic FieldDelimiter { get; set; }
    }

    public interface IHaveDataProtectionPolicy : IResourceInterface
    {
        dynamic DataProtectionPolicy { get; set; }
    }

    public interface IHaveApplyOnTransformedLogs : IResourceInterface
    {
        dynamic ApplyOnTransformedLogs { get; set; }
    }

    public interface IHaveClientSubnets : IResourceInterface
    {
        dynamic ClientSubnets { get; set; }
    }

    public interface IHaveWeeklyMaintenanceWindowStart : IResourceInterface
    {
        dynamic WeeklyMaintenanceWindowStart { get; set; }
    }

    public interface IHaveSenderIpAddress : IResourceInterface
    {
        dynamic SenderIpAddress { get; set; }
    }

    public interface IHaveIngestPort : IResourceInterface
    {
        dynamic IngestPort { get; set; }
    }

    public interface IHaveSenderControlPort : IResourceInterface
    {
        dynamic SenderControlPort { get; set; }
    }

    public interface IHaveSourceListenerAddress : IResourceInterface
    {
        dynamic SourceListenerAddress { get; set; }
    }

    public interface IHaveSourceListenerPort : IResourceInterface
    {
        dynamic SourceListenerPort { get; set; }
    }

    public interface IHaveWhitelistCidr : IResourceInterface
    {
        dynamic WhitelistCidr { get; set; }
    }

    public interface IHaveSettingsJson : IResourceInterface
    {
        dynamic SettingsJson { get; set; }
    }

    public interface IHaveInstanceRoleArn : IResourceInterface
    {
        dynamic InstanceRoleArn { get; set; }
    }

    public interface IHaveMultiplexId : IResourceInterface
    {
        dynamic MultiplexId { get; set; }
    }

    public interface IHavePreferredChannelPipeline : IResourceInterface
    {
        dynamic PreferredChannelPipeline { get; set; }
    }

    public interface IHaveProgramName : IResourceInterface
    {
        dynamic ProgramName { get; set; }
    }

    public interface IHavePackagingGroupId : IResourceInterface
    {
        dynamic PackagingGroupId { get; set; }
    }

    public interface IHaveTimeDelaySeconds : IResourceInterface
    {
        dynamic TimeDelaySeconds { get; set; }
    }

    public interface IHaveStartoverWindowSeconds : IResourceInterface
    {
        dynamic StartoverWindowSeconds { get; set; }
    }

    public interface IHaveInputType : IResourceInterface
    {
        dynamic InputType { get; set; }
    }

    public interface IHaveOriginEndpointName : IResourceInterface
    {
        dynamic OriginEndpointName { get; set; }
    }

    public interface IHaveAudiences : IResourceInterface
    {
        dynamic Audiences { get; set; }
    }

    public interface IHaveAdDecisionServerUrl : IResourceInterface
    {
        dynamic AdDecisionServerUrl { get; set; }
    }

    public interface IHaveVodSourceName : IResourceInterface
    {
        dynamic VodSourceName { get; set; }
    }

    public interface IHaveACLName : IResourceInterface
    {
        dynamic ACLName { get; set; }
    }

    public interface IHaveNumShards : IResourceInterface
    {
        dynamic NumShards { get; set; }
    }

    public interface IHaveTLSEnabled : IResourceInterface
    {
        dynamic TLSEnabled { get; set; }
    }

    public interface IHaveIamAuthEnabled : IResourceInterface
    {
        dynamic IamAuthEnabled { get; set; }
    }

    public interface IHaveDBInstanceParameterGroupName : IResourceInterface
    {
        dynamic DBInstanceParameterGroupName { get; set; }
    }

    public interface IHaveDBSnapshotIdentifier : IResourceInterface
    {
        dynamic DBSnapshotIdentifier { get; set; }
    }

    public interface IHaveReplicaCount : IResourceInterface
    {
        dynamic ReplicaCount { get; set; }
    }

    public interface IHaveFirewallName : IResourceInterface
    {
        dynamic FirewallName { get; set; }
    }

    public interface IHaveEdgeLocation : IResourceInterface
    {
        dynamic EdgeLocation { get; set; }
    }

    public interface IHaveLinkId : IResourceInterface
    {
        dynamic LinkId { get; set; }
    }

    public interface IHaveSiteId : IResourceInterface
    {
        dynamic SiteId { get; set; }
    }

    public interface IHaveVendor : IResourceInterface
    {
        dynamic Vendor { get; set; }
    }

    public interface IHaveTransitGatewayArn : IResourceInterface
    {
        dynamic TransitGatewayArn { get; set; }
    }

    public interface IHaveSubtype : IResourceInterface
    {
        dynamic Subtype { get; set; }
    }

    public interface IHaveOSISPipelineTypesVpcOptionsVpcOptions : IResourceInterface
    {
        Humidifier.OSIS.PipelineTypes.VpcOptions VpcOptions { get; set; }
    }

    public interface IHaveIPAddressType : IResourceInterface
    {
        dynamic IPAddressType { get; set; }
    }

    public interface IHaveShortname : IResourceInterface
    {
        dynamic Shortname { get; set; }
    }

    public interface IHaveAmiId : IResourceInterface
    {
        dynamic AmiId { get; set; }
    }

    public interface IHaveInstallUpdatesOnBoot : IResourceInterface
    {
        dynamic InstallUpdatesOnBoot { get; set; }
    }

    public interface IHaveCustomJson : IResourceInterface
    {
        dynamic CustomJson { get; set; }
    }

    public interface IHaveTargetIds : IResourceInterface
    {
        dynamic TargetIds { get; set; }
    }

    public interface IHaveOwnerAccount : IResourceInterface
    {
        dynamic OwnerAccount { get; set; }
    }

    public interface IHaveDatasetGroupArn : IResourceInterface
    {
        dynamic DatasetGroupArn { get; set; }
    }

    public interface IHavePinpointCampaignTypesTemplateConfigurationTemplateConfiguration : IResourceInterface
    {
        Humidifier.Pinpoint.CampaignTypes.TemplateConfiguration TemplateConfiguration { get; set; }
    }

    public interface IHaveTreatmentDescription : IResourceInterface
    {
        dynamic TreatmentDescription { get; set; }
    }

    public interface IHavePinpointCampaignTypesMessageConfigurationMessageConfiguration : IResourceInterface
    {
        Humidifier.Pinpoint.CampaignTypes.MessageConfiguration MessageConfiguration { get; set; }
    }

    public interface IHavePinpointCampaignTypesScheduleSchedule : IResourceInterface
    {
        Humidifier.Pinpoint.CampaignTypes.Schedule Schedule { get; set; }
    }

    public interface IHavePinpointCampaignTypesCustomDeliveryConfigurationCustomDeliveryConfiguration : IResourceInterface
    {
        Humidifier.Pinpoint.CampaignTypes.CustomDeliveryConfiguration CustomDeliveryConfiguration { get; set; }
    }

    public interface IHaveConfigurationSet : IResourceInterface
    {
        dynamic ConfigurationSet { get; set; }
    }

    public interface IHaveFromAddress : IResourceInterface
    {
        dynamic FromAddress { get; set; }
    }

    public interface IHaveHtmlPart : IResourceInterface
    {
        dynamic HtmlPart { get; set; }
    }

    public interface IHaveTextPart : IResourceInterface
    {
        dynamic TextPart { get; set; }
    }

    public interface IHaveCustomConfig : IResourceInterface
    {
        dynamic CustomConfig { get; set; }
    }

    public interface IHaveLayout : IResourceInterface
    {
        dynamic Layout { get; set; }
    }

    public interface IHaveSubtitle : IResourceInterface
    {
        dynamic Subtitle { get; set; }
    }

    public interface IHaveListOfQuickSightDashboardTypesResourcePermissionPermissions : IResourceInterface
    {
        List<Humidifier.QuickSight.DashboardTypes.ResourcePermission> Permissions { get; set; }
    }

    public interface IHaveDataSetId : IResourceInterface
    {
        dynamic DataSetId { get; set; }
    }

    public interface IHaveListOfQuickSightDataSourceTypesDataSourceParametersAlternateDataSourceParameters : IResourceInterface
    {
        List<Humidifier.QuickSight.DataSourceTypes.DataSourceParameters> AlternateDataSourceParameters { get; set; }
    }

    public interface IHaveQuickSightThemeTypesThemeConfigurationConfiguration : IResourceInterface
    {
        Humidifier.QuickSight.ThemeTypes.ThemeConfiguration Configuration { get; set; }
    }

    public interface IHaveBaseThemeId : IResourceInterface
    {
        dynamic BaseThemeId { get; set; }
    }

    public interface IHaveDBSystemId : IResourceInterface
    {
        dynamic DBSystemId { get; set; }
    }

    public interface IHaveMonitoringInterval : IResourceInterface
    {
        dynamic MonitoringInterval { get; set; }
    }

    public interface IHavePerformanceInsightsRetentionPeriod : IResourceInterface
    {
        dynamic PerformanceInsightsRetentionPeriod { get; set; }
    }

    public interface IHaveMonitoringRoleArn : IResourceInterface
    {
        dynamic MonitoringRoleArn { get; set; }
    }

    public interface IHaveGlobalClusterIdentifier : IResourceInterface
    {
        dynamic GlobalClusterIdentifier { get; set; }
    }

    public interface IHaveDomainIAMRoleName : IResourceInterface
    {
        dynamic DomainIAMRoleName { get; set; }
    }

    public interface IHaveSourceRegion : IResourceInterface
    {
        dynamic SourceRegion { get; set; }
    }

    public interface IHaveEnableIAMDatabaseAuthentication : IResourceInterface
    {
        dynamic EnableIAMDatabaseAuthentication { get; set; }
    }

    public interface IHaveOptionGroupName : IResourceInterface
    {
        dynamic OptionGroupName { get; set; }
    }

    public interface IHaveDBName : IResourceInterface
    {
        dynamic DBName { get; set; }
    }

    public interface IHaveEC2SecurityGroupId : IResourceInterface
    {
        dynamic EC2SecurityGroupId { get; set; }
    }

    public interface IHaveDestinationRegion : IResourceInterface
    {
        dynamic DestinationRegion { get; set; }
    }

    public interface IHaveNamespaceResourcePolicy : IResourceInterface
    {
        dynamic NamespaceResourcePolicy { get; set; }
    }

    public interface IHaveClassic : IResourceInterface
    {
        dynamic Classic { get; set; }
    }

    public interface IHaveResourceOwner : IResourceInterface
    {
        dynamic ResourceOwner { get; set; }
    }

    public interface IHaveAccount : IResourceInterface
    {
        dynamic Account { get; set; }
    }

    public interface IHaveScheduledActionName : IResourceInterface
    {
        dynamic ScheduledActionName { get; set; }
    }

    public interface IHaveAdminPasswordSecretKmsKeyId : IResourceInterface
    {
        dynamic AdminPasswordSecretKmsKeyId { get; set; }
    }

    public interface IHaveDefaultIamRoleArn : IResourceInterface
    {
        dynamic DefaultIamRoleArn { get; set; }
    }

    public interface IHaveDbName : IResourceInterface
    {
        dynamic DbName { get; set; }
    }

    public interface IHaveListOfRedshiftServerlessWorkgroupTypesConfigParameterConfigParameters : IResourceInterface
    {
        List<Humidifier.RedshiftServerless.WorkgroupTypes.ConfigParameter> ConfigParameters { get; set; }
    }

    public interface IHaveRedshiftServerlessWorkgroupTypesPerformanceTargetPricePerformanceTarget : IResourceInterface
    {
        Humidifier.RedshiftServerless.WorkgroupTypes.PerformanceTarget PricePerformanceTarget { get; set; }
    }

    public interface IHaveTagValue : IResourceInterface
    {
        dynamic TagValue { get; set; }
    }

    public interface IHaveFailover : IResourceInterface
    {
        dynamic Failover { get; set; }
    }

    public interface IHaveHealthCheckId : IResourceInterface
    {
        dynamic HealthCheckId { get; set; }
    }

    public interface IHaveMultiValueAnswer : IResourceInterface
    {
        dynamic MultiValueAnswer { get; set; }
    }

    public interface IHaveResourceRecords : IResourceInterface
    {
        dynamic ResourceRecords { get; set; }
    }

    public interface IHaveSetIdentifier : IResourceInterface
    {
        dynamic SetIdentifier { get; set; }
    }

    public interface IHaveControlPanelArn : IResourceInterface
    {
        dynamic ControlPanelArn { get; set; }
    }

    public interface IHaveCells : IResourceInterface
    {
        dynamic Cells { get; set; }
    }

    public interface IHaveResourceSetName : IResourceInterface
    {
        dynamic ResourceSetName { get; set; }
    }

    public interface IHavePreferredInstanceType : IResourceInterface
    {
        dynamic PreferredInstanceType { get; set; }
    }

    public interface IHaveVPCId : IResourceInterface
    {
        dynamic VPCId { get; set; }
    }

    public interface IHaveObjectLockEnabled : IResourceInterface
    {
        dynamic ObjectLockEnabled { get; set; }
    }

    public interface IHaveOutpostId : IResourceInterface
    {
        dynamic OutpostId { get; set; }
    }

    public interface IHaveSecurityGroupId : IResourceInterface
    {
        dynamic SecurityGroupId { get; set; }
    }

    public interface IHaveDefaultAction : IResourceInterface
    {
        dynamic DefaultAction { get; set; }
    }

    public interface IHaveRedrivePolicy : IResourceInterface
    {
        dynamic RedrivePolicy { get; set; }
    }

    public interface IHaveKmsMasterKeyId : IResourceInterface
    {
        dynamic KmsMasterKeyId { get; set; }
    }

    public interface IHaveContentBasedDeduplication : IResourceInterface
    {
        dynamic ContentBasedDeduplication { get; set; }
    }

    public interface IHaveMaxErrors : IResourceInterface
    {
        dynamic MaxErrors { get; set; }
    }

    public interface IHaveWindowId : IResourceInterface
    {
        dynamic WindowId { get; set; }
    }

    public interface IHaveKMSKeyArn : IResourceInterface
    {
        dynamic KMSKeyArn { get; set; }
    }

    public interface IHaveBucketRegion : IResourceInterface
    {
        dynamic BucketRegion { get; set; }
    }

    public interface IHaveSyncFormat : IResourceInterface
    {
        dynamic SyncFormat { get; set; }
    }

    public interface IHaveRotationIds : IResourceInterface
    {
        dynamic RotationIds { get; set; }
    }

    public interface IHavePrincipalId : IResourceInterface
    {
        dynamic PrincipalId { get; set; }
    }

    public interface IHaveAppType : IResourceInterface
    {
        dynamic AppType { get; set; }
    }

    public interface IHaveDeviceFleetName : IResourceInterface
    {
        dynamic DeviceFleetName { get; set; }
    }

    public interface IHaveModelCardStatus : IResourceInterface
    {
        dynamic ModelCardStatus { get; set; }
    }

    public interface IHaveTask : IResourceInterface
    {
        dynamic Task { get; set; }
    }

    public interface IHaveModelApprovalStatus : IResourceInterface
    {
        dynamic ModelApprovalStatus { get; set; }
    }

    public interface IHaveModelPackageVersion : IResourceInterface
    {
        dynamic ModelPackageVersion { get; set; }
    }

    public interface IHaveModelPackageDescription : IResourceInterface
    {
        dynamic ModelPackageDescription { get; set; }
    }

    public interface IHaveApprovalDescription : IResourceInterface
    {
        dynamic ApprovalDescription { get; set; }
    }

    public interface IHaveMonitoringScheduleName : IResourceInterface
    {
        dynamic MonitoringScheduleName { get; set; }
    }

    public interface IHaveProductArn : IResourceInterface
    {
        dynamic ProductArn { get; set; }
    }

    public interface IHaveSecurityControlId : IResourceInterface
    {
        dynamic SecurityControlId { get; set; }
    }

    public interface IHaveDataLakeArn : IResourceInterface
    {
        dynamic DataLakeArn { get; set; }
    }

    public interface IHaveProductType : IResourceInterface
    {
        dynamic ProductType { get; set; }
    }

    public interface IHavePathId : IResourceInterface
    {
        dynamic PathId { get; set; }
    }

    public interface IHaveNotificationArns : IResourceInterface
    {
        dynamic NotificationArns { get; set; }
    }

    public interface IHaveRegionList : IResourceInterface
    {
        dynamic RegionList { get; set; }
    }

    public interface IHaveProfileName : IResourceInterface
    {
        dynamic ProfileName { get; set; }
    }

    public interface IHaveStateMachineName : IResourceInterface
    {
        dynamic StateMachineName { get; set; }
    }

    public interface IHaveSid : IResourceInterface
    {
        dynamic Sid { get; set; }
    }

    public interface IHaveServerId : IResourceInterface
    {
        dynamic ServerId { get; set; }
    }

    public interface IHaveAccessRole : IResourceInterface
    {
        dynamic AccessRole { get; set; }
    }

    public interface IHavePartnerProfileId : IResourceInterface
    {
        dynamic PartnerProfileId { get; set; }
    }

    public interface IHaveLocalProfileId : IResourceInterface
    {
        dynamic LocalProfileId { get; set; }
    }

    public interface IHaveLoggingRole : IResourceInterface
    {
        dynamic LoggingRole { get; set; }
    }

    public interface IHaveSecurityPolicyName : IResourceInterface
    {
        dynamic SecurityPolicyName { get; set; }
    }

    public interface IHaveIdentityProviderType : IResourceInterface
    {
        dynamic IdentityProviderType { get; set; }
    }

    public interface IHaveServiceNetworkIdentifier : IResourceInterface
    {
        dynamic ServiceNetworkIdentifier { get; set; }
    }

    public interface IHaveWebACLId : IResourceInterface
    {
        dynamic WebACLId { get; set; }
    }

    public interface IHaveAddresses : IResourceInterface
    {
        dynamic Addresses { get; set; }
    }

    public interface IHaveWAFv2RuleGroupTypesVisibilityConfigVisibilityConfig : IResourceInterface
    {
        Humidifier.WAFv2.RuleGroupTypes.VisibilityConfig VisibilityConfig { get; set; }
    }

    public interface IHaveWAFv2WebACLTypesChallengeConfigChallengeConfig : IResourceInterface
    {
        Humidifier.WAFv2.WebACLTypes.ChallengeConfig ChallengeConfig { get; set; }
    }

    public interface IHaveWAFv2WebACLTypesVisibilityConfigVisibilityConfig : IResourceInterface
    {
        Humidifier.WAFv2.WebACLTypes.VisibilityConfig VisibilityConfig { get; set; }
    }

    public interface IHaveWAFv2WebACLTypesCaptchaConfigCaptchaConfig : IResourceInterface
    {
        Humidifier.WAFv2.WebACLTypes.CaptchaConfig CaptchaConfig { get; set; }
    }

    public interface IHaveAssociationType : IResourceInterface
    {
        dynamic AssociationType { get; set; }
    }

    public interface IHaveConnectionString : IResourceInterface
    {
        dynamic ConnectionString { get; set; }
    }

    public interface IHaveFilterExpression : IResourceInterface
    {
        dynamic FilterExpression { get; set; }
    }

    public interface IHavePartyName : IResourceInterface
    {
        dynamic PartyName { get; set; }
    }

    public interface IHaveNameAssigner : IResourceInterface
    {
        dynamic NameAssigner { get; set; }
    }

    public interface IHaveUniformResourceIdentifier : IResourceInterface
    {
        dynamic UniformResourceIdentifier { get; set; }
    }

    public interface IHaveRegisteredId : IResourceInterface
    {
        dynamic RegisteredId { get; set; }
    }

    public interface IHaveRfc822Name : IResourceInterface
    {
        dynamic Rfc822Name { get; set; }
    }

    public interface IHaveKeyCertSign : IResourceInterface
    {
        dynamic KeyCertSign { get; set; }
    }

    public interface IHaveDecipherOnly : IResourceInterface
    {
        dynamic DecipherOnly { get; set; }
    }

    public interface IHaveCRLSign : IResourceInterface
    {
        dynamic CRLSign { get; set; }
    }

    public interface IHaveEncipherOnly : IResourceInterface
    {
        dynamic EncipherOnly { get; set; }
    }

    public interface IHaveTypeId : IResourceInterface
    {
        dynamic TypeId { get; set; }
    }

    public interface IHaveOrganizationalUnit : IResourceInterface
    {
        dynamic OrganizationalUnit { get; set; }
    }

    public interface IHaveLocality : IResourceInterface
    {
        dynamic Locality { get; set; }
    }

    public interface IHaveGivenName : IResourceInterface
    {
        dynamic GivenName { get; set; }
    }

    public interface IHaveGenerationQualifier : IResourceInterface
    {
        dynamic GenerationQualifier { get; set; }
    }

    public interface IHaveInitials : IResourceInterface
    {
        dynamic Initials { get; set; }
    }

    public interface IHaveSurname : IResourceInterface
    {
        dynamic Surname { get; set; }
    }

    public interface IHaveDistinguishedNameQualifier : IResourceInterface
    {
        dynamic DistinguishedNameQualifier { get; set; }
    }

    public interface IHavePseudonym : IResourceInterface
    {
        dynamic Pseudonym { get; set; }
    }

    public interface IHaveContains : IResourceInterface
    {
        dynamic Contains { get; set; }
    }

    public interface IHaveNeq : IResourceInterface
    {
        dynamic Neq { get; set; }
    }

    public interface IHaveEnableBasicAuth : IResourceInterface
    {
        dynamic EnableBasicAuth { get; set; }
    }

    public interface IHaveOperand : IResourceInterface
    {
        dynamic Operand { get; set; }
    }

    public interface IHaveOperandType : IResourceInterface
    {
        dynamic OperandType { get; set; }
    }

    public interface IHavePlaceholder : IResourceInterface
    {
        dynamic Placeholder { get; set; }
    }

    public interface IHaveAccessLevel : IResourceInterface
    {
        dynamic AccessLevel { get; set; }
    }

    public interface IHaveTruststoreVersion : IResourceInterface
    {
        dynamic TruststoreVersion { get; set; }
    }

    public interface IHaveTruststoreUri : IResourceInterface
    {
        dynamic TruststoreUri { get; set; }
    }

    public interface IHaveContentHandling : IResourceInterface
    {
        dynamic ContentHandling { get; set; }
    }

    public interface IHaveAllowOrigins : IResourceInterface
    {
        dynamic AllowOrigins { get; set; }
    }

    public interface IHaveAllowCredentials : IResourceInterface
    {
        dynamic AllowCredentials { get; set; }
    }

    public interface IHaveAllowHeaders : IResourceInterface
    {
        dynamic AllowHeaders { get; set; }
    }

    public interface IHaveAllowMethods : IResourceInterface
    {
        dynamic AllowMethods { get; set; }
    }

    public interface IHaveDetailedMetricsEnabled : IResourceInterface
    {
        dynamic DetailedMetricsEnabled { get; set; }
    }

    public interface IHaveAudience : IResourceInterface
    {
        dynamic Audience { get; set; }
    }

    public interface IHaveAlarmRoleArn : IResourceInterface
    {
        dynamic AlarmRoleArn { get; set; }
    }

    public interface IHaveApiSecretKey : IResourceInterface
    {
        dynamic ApiSecretKey { get; set; }
    }

    public interface IHaveOAuth2GrantType : IResourceInterface
    {
        dynamic OAuth2GrantType { get; set; }
    }

    public interface IHaveClientCredentialsArn : IResourceInterface
    {
        dynamic ClientCredentialsArn { get; set; }
    }

    public interface IHavePrivateLinkServiceName : IResourceInterface
    {
        dynamic PrivateLinkServiceName { get; set; }
    }

    public interface IHaveWarehouse : IResourceInterface
    {
        dynamic Warehouse { get; set; }
    }

    public interface IHaveS3 : IResourceInterface
    {
        dynamic S3 { get; set; }
    }

    public interface IHaveServiceNow : IResourceInterface
    {
        dynamic ServiceNow { get; set; }
    }

    public interface IHaveMarketo : IResourceInterface
    {
        dynamic Marketo { get; set; }
    }

    public interface IHaveZendesk : IResourceInterface
    {
        dynamic Zendesk { get; set; }
    }

    public interface IHaveSalesforce : IResourceInterface
    {
        dynamic Salesforce { get; set; }
    }

    public interface IHaveDynDicOfCustomProperties : IResourceInterface
    {
        Dictionary<string, dynamic> CustomProperties { get; set; }
    }

    public interface IHaveApiVersion : IResourceInterface
    {
        dynamic ApiVersion { get; set; }
    }

    public interface IHaveDatetimeTypeFieldName : IResourceInterface
    {
        dynamic DatetimeTypeFieldName { get; set; }
    }

    public interface IHaveIntermediateBucketName : IResourceInterface
    {
        dynamic IntermediateBucketName { get; set; }
    }

    public interface IHaveAppFlowFlowTypesPrefixConfigPrefixConfig : IResourceInterface
    {
        Humidifier.AppFlow.FlowTypes.PrefixConfig PrefixConfig { get; set; }
    }

    public interface IHaveFileType : IResourceInterface
    {
        dynamic FileType { get; set; }
    }

    public interface IHaveAppFlowFlowTypesAggregationConfigAggregationConfig : IResourceInterface
    {
        Humidifier.AppFlow.FlowTypes.AggregationConfig AggregationConfig { get; set; }
    }

    public interface IHaveObjectPath : IResourceInterface
    {
        dynamic ObjectPath { get; set; }
    }

    public interface IHaveDataTransferApi : IResourceInterface
    {
        dynamic DataTransferApi { get; set; }
    }

    public interface IHaveIncludeDeletedRecords : IResourceInterface
    {
        dynamic IncludeDeletedRecords { get; set; }
    }

    public interface IHaveEnableDynamicFieldUpdate : IResourceInterface
    {
        dynamic EnableDynamicFieldUpdate { get; set; }
    }

    public interface IHaveScheduleEndTime : IResourceInterface
    {
        dynamic ScheduleEndTime { get; set; }
    }

    public interface IHaveScheduleStartTime : IResourceInterface
    {
        dynamic ScheduleStartTime { get; set; }
    }

    public interface IHaveDataPullMode : IResourceInterface
    {
        dynamic DataPullMode { get; set; }
    }

    public interface IHaveSourceFields : IResourceInterface
    {
        dynamic SourceFields { get; set; }
    }

    public interface IHaveDestinationField : IResourceInterface
    {
        dynamic DestinationField { get; set; }
    }

    public interface IHaveTriggerType : IResourceInterface
    {
        dynamic TriggerType { get; set; }
    }

    public interface IHaveAppMeshGatewayRouteTypesGatewayRouteRangeMatchRange : IResourceInterface
    {
        Humidifier.AppMesh.GatewayRouteTypes.GatewayRouteRangeMatch Range { get; set; }
    }

    public interface IHaveAppMeshGatewayRouteTypesGatewayRouteTargetTarget : IResourceInterface
    {
        Humidifier.AppMesh.GatewayRouteTypes.GatewayRouteTarget Target { get; set; }
    }

    public interface IHaveAppMeshGatewayRouteTypesGatewayRouteHostnameMatchHostname : IResourceInterface
    {
        Humidifier.AppMesh.GatewayRouteTypes.GatewayRouteHostnameMatch Hostname { get; set; }
    }

    public interface IHaveAppMeshGatewayRouteTypesGatewayRouteHostnameRewriteHostname : IResourceInterface
    {
        Humidifier.AppMesh.GatewayRouteTypes.GatewayRouteHostnameRewrite Hostname { get; set; }
    }

    public interface IHaveAppMeshRouteTypesDurationPerRetryTimeout : IResourceInterface
    {
        Humidifier.AppMesh.RouteTypes.Duration PerRetryTimeout { get; set; }
    }

    public interface IHaveHttpRetryEvents : IResourceInterface
    {
        dynamic HttpRetryEvents { get; set; }
    }

    public interface IHaveTcpRetryEvents : IResourceInterface
    {
        dynamic TcpRetryEvents { get; set; }
    }

    public interface IHaveAppMeshRouteTypesMatchRangeRange : IResourceInterface
    {
        Humidifier.AppMesh.RouteTypes.MatchRange Range { get; set; }
    }

    public interface IHaveAppMeshRouteTypesDurationPerRequest : IResourceInterface
    {
        Humidifier.AppMesh.RouteTypes.Duration PerRequest { get; set; }
    }

    public interface IHaveEnforce : IResourceInterface
    {
        dynamic Enforce { get; set; }
    }

    public interface IHaveAppMeshVirtualGatewayTypesVirtualGatewayListenerTlsSdsCertificateSDS : IResourceInterface
    {
        Humidifier.AppMesh.VirtualGatewayTypes.VirtualGatewayListenerTlsSdsCertificate SDS { get; set; }
    }

    public interface IHaveAppMeshVirtualGatewayTypesVirtualGatewayListenerTlsFileCertificateFile : IResourceInterface
    {
        Humidifier.AppMesh.VirtualGatewayTypes.VirtualGatewayListenerTlsFileCertificate File { get; set; }
    }

    public interface IHaveTimeoutMillis : IResourceInterface
    {
        dynamic TimeoutMillis { get; set; }
    }

    public interface IHaveIntervalMillis : IResourceInterface
    {
        dynamic IntervalMillis { get; set; }
    }

    public interface IHaveMaxPendingRequests : IResourceInterface
    {
        dynamic MaxPendingRequests { get; set; }
    }

    public interface IHaveAppMeshVirtualGatewayTypesSubjectAlternativeNamesSubjectAlternativeNames : IResourceInterface
    {
        Humidifier.AppMesh.VirtualGatewayTypes.SubjectAlternativeNames SubjectAlternativeNames { get; set; }
    }

    public interface IHaveAppMeshVirtualGatewayTypesVirtualGatewayTlsValidationContextSdsTrustSDS : IResourceInterface
    {
        Humidifier.AppMesh.VirtualGatewayTypes.VirtualGatewayTlsValidationContextSdsTrust SDS { get; set; }
    }

    public interface IHaveAppMeshVirtualGatewayTypesVirtualGatewayTlsValidationContextFileTrustFile : IResourceInterface
    {
        Humidifier.AppMesh.VirtualGatewayTypes.VirtualGatewayTlsValidationContextFileTrust File { get; set; }
    }

    public interface IHaveCertificateAuthorityArns : IResourceInterface
    {
        dynamic CertificateAuthorityArns { get; set; }
    }

    public interface IHaveAppMeshVirtualNodeTypesClientPolicyClientPolicy : IResourceInterface
    {
        Humidifier.AppMesh.VirtualNodeTypes.ClientPolicy ClientPolicy { get; set; }
    }

    public interface IHaveAppMeshVirtualNodeTypesListenerTlsSdsCertificateSDS : IResourceInterface
    {
        Humidifier.AppMesh.VirtualNodeTypes.ListenerTlsSdsCertificate SDS { get; set; }
    }

    public interface IHaveAppMeshVirtualNodeTypesListenerTlsFileCertificateFile : IResourceInterface
    {
        Humidifier.AppMesh.VirtualNodeTypes.ListenerTlsFileCertificate File { get; set; }
    }

    public interface IHaveAppMeshVirtualNodeTypesDurationPerRequest : IResourceInterface
    {
        Humidifier.AppMesh.VirtualNodeTypes.Duration PerRequest { get; set; }
    }

    public interface IHaveAppMeshVirtualNodeTypesSubjectAlternativeNamesSubjectAlternativeNames : IResourceInterface
    {
        Humidifier.AppMesh.VirtualNodeTypes.SubjectAlternativeNames SubjectAlternativeNames { get; set; }
    }

    public interface IHaveAppMeshVirtualNodeTypesTlsValidationContextSdsTrustSDS : IResourceInterface
    {
        Humidifier.AppMesh.VirtualNodeTypes.TlsValidationContextSdsTrust SDS { get; set; }
    }

    public interface IHaveAppMeshVirtualNodeTypesTlsValidationContextFileTrustFile : IResourceInterface
    {
        Humidifier.AppMesh.VirtualNodeTypes.TlsValidationContextFileTrust File { get; set; }
    }

    public interface IHaveListOfAppRunnerServiceTypesKeyValuePairRuntimeEnvironmentSecrets : IResourceInterface
    {
        List<Humidifier.AppRunner.ServiceTypes.KeyValuePair> RuntimeEnvironmentSecrets { get; set; }
    }

    public interface IHaveStartCommand : IResourceInterface
    {
        dynamic StartCommand { get; set; }
    }

    public interface IHaveListOfAppRunnerServiceTypesKeyValuePairRuntimeEnvironmentVariables : IResourceInterface
    {
        List<Humidifier.AppRunner.ServiceTypes.KeyValuePair> RuntimeEnvironmentVariables { get; set; }
    }

    public interface IHaveSettingsGroup : IResourceInterface
    {
        dynamic SettingsGroup { get; set; }
    }

    public interface IHaveMaximumLength : IResourceInterface
    {
        dynamic MaximumLength { get; set; }
    }

    public interface IHaveAuthTTL : IResourceInterface
    {
        dynamic AuthTTL { get; set; }
    }

    public interface IHaveIatTTL : IResourceInterface
    {
        dynamic IatTTL { get; set; }
    }

    public interface IHaveSigningRegion : IResourceInterface
    {
        dynamic SigningRegion { get; set; }
    }

    public interface IHaveLambdaConflictHandlerArn : IResourceInterface
    {
        dynamic LambdaConflictHandlerArn { get; set; }
    }

    public interface IHaveConflictHandler : IResourceInterface
    {
        dynamic ConflictHandler { get; set; }
    }

    public interface IHaveConflictDetection : IResourceInterface
    {
        dynamic ConflictDetection { get; set; }
    }

    public interface IHaveExportDataSetNames : IResourceInterface
    {
        dynamic ExportDataSetNames { get; set; }
    }

    public interface IHaveLength : IResourceInterface
    {
        dynamic Length { get; set; }
    }

    public interface IHaveScriptLocation : IResourceInterface
    {
        dynamic ScriptLocation { get; set; }
    }

    public interface IHaveCaptureTool : IResourceInterface
    {
        dynamic CaptureTool { get; set; }
    }

    public interface IHaveMaxCapacityBreachBehavior : IResourceInterface
    {
        dynamic MaxCapacityBreachBehavior { get; set; }
    }

    public interface IHaveMaxCapacityBuffer : IResourceInterface
    {
        dynamic MaxCapacityBuffer { get; set; }
    }

    public interface IHaveSchedulingBufferTime : IResourceInterface
    {
        dynamic SchedulingBufferTime { get; set; }
    }

    public interface IHaveMetricIntervalUpperBound : IResourceInterface
    {
        dynamic MetricIntervalUpperBound { get; set; }
    }

    public interface IHaveMetricIntervalLowerBound : IResourceInterface
    {
        dynamic MetricIntervalLowerBound { get; set; }
    }

    public interface IHaveListOfApplicationInsightsApplicationTypesWindowsEventWindowsEvents : IResourceInterface
    {
        List<Humidifier.ApplicationInsights.ApplicationTypes.WindowsEvent> WindowsEvents { get; set; }
    }

    public interface IHaveListOfApplicationInsightsApplicationTypesLogLogs : IResourceInterface
    {
        List<Humidifier.ApplicationInsights.ApplicationTypes.Log> Logs { get; set; }
    }

    public interface IHaveListOfApplicationInsightsApplicationTypesProcessProcesses : IResourceInterface
    {
        List<Humidifier.ApplicationInsights.ApplicationTypes.Process> Processes { get; set; }
    }

    public interface IHaveHostPort : IResourceInterface
    {
        dynamic HostPort { get; set; }
    }

    public interface IHaveEncoding : IResourceInterface
    {
        dynamic Encoding { get; set; }
    }

    public interface IHavePatternSet : IResourceInterface
    {
        dynamic PatternSet { get; set; }
    }

    public interface IHavePatternName : IResourceInterface
    {
        dynamic PatternName { get; set; }
    }

    public interface IHaveDurationUnit : IResourceInterface
    {
        dynamic DurationUnit { get; set; }
    }

    public interface IHaveMetricThreshold : IResourceInterface
    {
        dynamic MetricThreshold { get; set; }
    }

    public interface IHaveDynDicOfKeyAttributes : IResourceInterface
    {
        Dictionary<string, dynamic> KeyAttributes { get; set; }
    }

    public interface IHaveOutputLocation : IResourceInterface
    {
        dynamic OutputLocation { get; set; }
    }

    public interface IHaveExpectedBucketOwner : IResourceInterface
    {
        dynamic ExpectedBucketOwner { get; set; }
    }

    public interface IHaveRoleType : IResourceInterface
    {
        dynamic RoleType { get; set; }
    }

    public interface IHaveOnDemandAllocationStrategy : IResourceInterface
    {
        dynamic OnDemandAllocationStrategy { get; set; }
    }

    public interface IHaveAutoScalingAutoScalingGroupTypesLaunchTemplateSpecificationLaunchTemplateSpecification : IResourceInterface
    {
        Humidifier.AutoScaling.AutoScalingGroupTypes.LaunchTemplateSpecification LaunchTemplateSpecification { get; set; }
    }

    public interface IHaveTopicARN : IResourceInterface
    {
        dynamic TopicARN { get; set; }
    }

    public interface IHaveHttpEndpoint : IResourceInterface
    {
        dynamic HttpEndpoint { get; set; }
    }

    public interface IHaveListOfAutoScalingScalingPolicyTypesMetricDimensionDimensions : IResourceInterface
    {
        List<Humidifier.AutoScaling.ScalingPolicyTypes.MetricDimension> Dimensions { get; set; }
    }

    public interface IHaveAutoScalingScalingPolicyTypesMetricMetric : IResourceInterface
    {
        Humidifier.AutoScaling.ScalingPolicyTypes.Metric Metric { get; set; }
    }

    public interface IHaveListOfAutoScalingPlansScalingPlanTypesMetricDimensionDimensions : IResourceInterface
    {
        List<Humidifier.AutoScalingPlans.ScalingPlanTypes.MetricDimension> Dimensions { get; set; }
    }

    public interface IHaveTransactionSet : IResourceInterface
    {
        dynamic TransactionSet { get; set; }
    }

    public interface IHaveB2BITransformerTypesFormatOptionsFormatOptions : IResourceInterface
    {
        Humidifier.B2BI.TransformerTypes.FormatOptions FormatOptions { get; set; }
    }

    public interface IHaveOutputType : IResourceInterface
    {
        dynamic OutputType { get; set; }
    }

    public interface IHaveBackupBackupPlanTypesLifecycleResourceTypeLifecycle : IResourceInterface
    {
        Humidifier.Backup.BackupPlanTypes.LifecycleResourceType Lifecycle { get; set; }
    }

    public interface IHaveConditionValue : IResourceInterface
    {
        dynamic ConditionValue { get; set; }
    }

    public interface IHaveConditionKey : IResourceInterface
    {
        dynamic ConditionKey { get; set; }
    }

    public interface IHaveSNSTopicArn : IResourceInterface
    {
        dynamic SNSTopicArn { get; set; }
    }

    public interface IHaveBackupVaultEvents : IResourceInterface
    {
        dynamic BackupVaultEvents { get; set; }
    }

    public interface IHaveComplianceResourceTypes : IResourceInterface
    {
        dynamic ComplianceResourceTypes { get; set; }
    }

    public interface IHaveJobRoleArn : IResourceInterface
    {
        dynamic JobRoleArn { get; set; }
    }

    public interface IHaveVcpus : IResourceInterface
    {
        dynamic Vcpus { get; set; }
    }

    public interface IHaveBatchJobDefinitionTypesNetworkConfigurationNetworkConfiguration : IResourceInterface
    {
        Humidifier.Batch.JobDefinitionTypes.NetworkConfiguration NetworkConfiguration { get; set; }
    }

    public interface IHaveHostPath : IResourceInterface
    {
        dynamic HostPath { get; set; }
    }

    public interface IHaveAccessPointId : IResourceInterface
    {
        dynamic AccessPointId { get; set; }
    }

    public interface IHaveTransitEncryption : IResourceInterface
    {
        dynamic TransitEncryption { get; set; }
    }

    public interface IHaveTransitEncryptionPort : IResourceInterface
    {
        dynamic TransitEncryptionPort { get; set; }
    }

    public interface IHaveListOfBatchJobDefinitionTypesTaskContainerPropertiesContainers : IResourceInterface
    {
        List<Humidifier.Batch.JobDefinitionTypes.TaskContainerProperties> Containers { get; set; }
    }

    public interface IHaveMountPath : IResourceInterface
    {
        dynamic MountPath { get; set; }
    }

    public interface IHaveOptional : IResourceInterface
    {
        dynamic Optional { get; set; }
    }

    public interface IHaveSwappiness : IResourceInterface
    {
        dynamic Swappiness { get; set; }
    }

    public interface IHaveSharedMemorySize : IResourceInterface
    {
        dynamic SharedMemorySize { get; set; }
    }

    public interface IHaveInitProcessEnabled : IResourceInterface
    {
        dynamic InitProcessEnabled { get; set; }
    }

    public interface IHaveMaxSwap : IResourceInterface
    {
        dynamic MaxSwap { get; set; }
    }

    public interface IHaveSourceVolume : IResourceInterface
    {
        dynamic SourceVolume { get; set; }
    }

    public interface IHaveOperatingSystemFamily : IResourceInterface
    {
        dynamic OperatingSystemFamily { get; set; }
    }

    public interface IHaveCpuArchitecture : IResourceInterface
    {
        dynamic CpuArchitecture { get; set; }
    }

    public interface IHaveSoftLimit : IResourceInterface
    {
        dynamic SoftLimit { get; set; }
    }

    public interface IHaveHardLimit : IResourceInterface
    {
        dynamic HardLimit { get; set; }
    }

    public interface IHaveParsingModality : IResourceInterface
    {
        dynamic ParsingModality { get; set; }
    }

    public interface IHaveChunkingStrategy : IResourceInterface
    {
        dynamic ChunkingStrategy { get; set; }
    }

    public interface IHaveHostType : IResourceInterface
    {
        dynamic HostType { get; set; }
    }

    public interface IHaveOverlapPercentage : IResourceInterface
    {
        dynamic OverlapPercentage { get; set; }
    }

    public interface IHaveOverlapTokens : IResourceInterface
    {
        dynamic OverlapTokens { get; set; }
    }

    public interface IHaveParsingStrategy : IResourceInterface
    {
        dynamic ParsingStrategy { get; set; }
    }

    public interface IHaveParsingPromptText : IResourceInterface
    {
        dynamic ParsingPromptText { get; set; }
    }

    public interface IHaveInclusionPrefixes : IResourceInterface
    {
        dynamic InclusionPrefixes { get; set; }
    }

    public interface IHaveBufferSize : IResourceInterface
    {
        dynamic BufferSize { get; set; }
    }

    public interface IHaveBreakpointPercentileThreshold : IResourceInterface
    {
        dynamic BreakpointPercentileThreshold { get; set; }
    }

    public interface IHaveTenantId : IResourceInterface
    {
        dynamic TenantId { get; set; }
    }

    public interface IHaveAgentAliasArn : IResourceInterface
    {
        dynamic AgentAliasArn { get; set; }
    }

    public interface IHaveSourceOutput : IResourceInterface
    {
        dynamic SourceOutput { get; set; }
    }

    public interface IHaveTargetInput : IResourceInterface
    {
        dynamic TargetInput { get; set; }
    }

    public interface IHaveIterator : IResourceInterface
    {
        dynamic Iterator { get; set; }
    }

    public interface IHaveCollector : IResourceInterface
    {
        dynamic Collector { get; set; }
    }

    public interface IHaveBedrockFlowTypesGuardrailConfigurationGuardrailConfiguration : IResourceInterface
    {
        Humidifier.Bedrock.FlowTypes.GuardrailConfiguration GuardrailConfiguration { get; set; }
    }

    public interface IHaveBotAliasArn : IResourceInterface
    {
        dynamic BotAliasArn { get; set; }
    }

    public interface IHaveBedrockFlowVersionTypesGuardrailConfigurationGuardrailConfiguration : IResourceInterface
    {
        Humidifier.Bedrock.FlowVersionTypes.GuardrailConfiguration GuardrailConfiguration { get; set; }
    }

    public interface IHaveOutputStrength : IResourceInterface
    {
        dynamic OutputStrength { get; set; }
    }

    public interface IHaveInputStrength : IResourceInterface
    {
        dynamic InputStrength { get; set; }
    }

    public interface IHaveExamples : IResourceInterface
    {
        dynamic Examples { get; set; }
    }

    public interface IHaveVectorIndexName : IResourceInterface
    {
        dynamic VectorIndexName { get; set; }
    }

    public interface IHaveListOfBedrockPromptTypesPromptInputVariableInputVariables : IResourceInterface
    {
        List<Humidifier.Bedrock.PromptTypes.PromptInputVariable> InputVariables { get; set; }
    }

    public interface IHavePolicyArn : IResourceInterface
    {
        dynamic PolicyArn { get; set; }
    }

    public interface IHaveCassandraTableTypesAutoScalingSettingReadCapacityAutoScaling : IResourceInterface
    {
        Humidifier.Cassandra.TableTypes.AutoScalingSetting ReadCapacityAutoScaling { get; set; }
    }

    public interface IHaveColumnType : IResourceInterface
    {
        dynamic ColumnType { get; set; }
    }

    public interface IHaveWriteCapacityUnits : IResourceInterface
    {
        dynamic WriteCapacityUnits { get; set; }
    }

    public interface IHaveIsResponsible : IResourceInterface
    {
        dynamic IsResponsible { get; set; }
    }

    public interface IHaveAllowedJoinOperators : IResourceInterface
    {
        dynamic AllowedJoinOperators { get; set; }
    }

    public interface IHaveJoinColumns : IResourceInterface
    {
        dynamic JoinColumns { get; set; }
    }

    public interface IHaveInputReferenceArn : IResourceInterface
    {
        dynamic InputReferenceArn { get; set; }
    }

    public interface IHaveManageResourcePolicies : IResourceInterface
    {
        dynamic ManageResourcePolicies { get; set; }
    }

    public interface IHaveInvocationPoint : IResourceInterface
    {
        dynamic InvocationPoint { get; set; }
    }

    public interface IHaveFilteringCriteria : IResourceInterface
    {
        dynamic FilteringCriteria { get; set; }
    }

    public interface IHaveTargetNames : IResourceInterface
    {
        dynamic TargetNames { get; set; }
    }

    public interface IHaveInvocationPoints : IResourceInterface
    {
        dynamic InvocationPoints { get; set; }
    }

    public interface IHaveParameterKey : IResourceInterface
    {
        dynamic ParameterKey { get; set; }
    }

    public interface IHaveCookies : IResourceInterface
    {
        dynamic Cookies { get; set; }
    }

    public interface IHaveCookieBehavior : IResourceInterface
    {
        dynamic CookieBehavior { get; set; }
    }

    public interface IHaveHeaderBehavior : IResourceInterface
    {
        dynamic HeaderBehavior { get; set; }
    }

    public interface IHaveQueryStrings : IResourceInterface
    {
        dynamic QueryStrings { get; set; }
    }

    public interface IHaveQueryStringBehavior : IResourceInterface
    {
        dynamic QueryStringBehavior { get; set; }
    }

    public interface IHaveMaximumTTL : IResourceInterface
    {
        dynamic MaximumTTL { get; set; }
    }

    public interface IHaveCloudFrontContinuousDeploymentPolicyTypesSessionStickinessConfigSessionStickinessConfig : IResourceInterface
    {
        Humidifier.CloudFront.ContinuousDeploymentPolicyTypes.SessionStickinessConfig SessionStickinessConfig { get; set; }
    }

    public interface IHaveCompress : IResourceInterface
    {
        dynamic Compress { get; set; }
    }

    public interface IHaveListOfCloudFrontDistributionTypesFunctionAssociationFunctionAssociations : IResourceInterface
    {
        List<Humidifier.CloudFront.DistributionTypes.FunctionAssociation> FunctionAssociations { get; set; }
    }

    public interface IHaveListOfCloudFrontDistributionTypesLambdaFunctionAssociationLambdaFunctionAssociations : IResourceInterface
    {
        List<Humidifier.CloudFront.DistributionTypes.LambdaFunctionAssociation> LambdaFunctionAssociations { get; set; }
    }

    public interface IHaveTargetOriginId : IResourceInterface
    {
        dynamic TargetOriginId { get; set; }
    }

    public interface IHaveViewerProtocolPolicy : IResourceInterface
    {
        dynamic ViewerProtocolPolicy { get; set; }
    }

    public interface IHaveResponseHeadersPolicyId : IResourceInterface
    {
        dynamic ResponseHeadersPolicyId { get; set; }
    }

    public interface IHaveCloudFrontDistributionTypesGrpcConfigGrpcConfig : IResourceInterface
    {
        Humidifier.CloudFront.DistributionTypes.GrpcConfig GrpcConfig { get; set; }
    }

    public interface IHaveRealtimeLogConfigArn : IResourceInterface
    {
        dynamic RealtimeLogConfigArn { get; set; }
    }

    public interface IHaveTrustedSigners : IResourceInterface
    {
        dynamic TrustedSigners { get; set; }
    }

    public interface IHaveFieldLevelEncryptionId : IResourceInterface
    {
        dynamic FieldLevelEncryptionId { get; set; }
    }

    public interface IHaveTrustedKeyGroups : IResourceInterface
    {
        dynamic TrustedKeyGroups { get; set; }
    }

    public interface IHaveCachedMethods : IResourceInterface
    {
        dynamic CachedMethods { get; set; }
    }

    public interface IHaveSmoothStreaming : IResourceInterface
    {
        dynamic SmoothStreaming { get; set; }
    }

    public interface IHaveCloudFrontDistributionTypesForwardedValuesForwardedValues : IResourceInterface
    {
        Humidifier.CloudFront.DistributionTypes.ForwardedValues ForwardedValues { get; set; }
    }

    public interface IHaveOriginRequestPolicyId : IResourceInterface
    {
        dynamic OriginRequestPolicyId { get; set; }
    }

    public interface IHaveCachePolicyId : IResourceInterface
    {
        dynamic CachePolicyId { get; set; }
    }

    public interface IHaveErrorCode : IResourceInterface
    {
        dynamic ErrorCode { get; set; }
    }

    public interface IHaveHTTPSPort : IResourceInterface
    {
        dynamic HTTPSPort { get; set; }
    }

    public interface IHaveOriginSSLProtocols : IResourceInterface
    {
        dynamic OriginSSLProtocols { get; set; }
    }

    public interface IHaveHTTPPort : IResourceInterface
    {
        dynamic HTTPPort { get; set; }
    }

    public interface IHaveOriginProtocolPolicy : IResourceInterface
    {
        dynamic OriginProtocolPolicy { get; set; }
    }

    public interface IHavePriceClass : IResourceInterface
    {
        dynamic PriceClass { get; set; }
    }

    public interface IHaveFunctionARN : IResourceInterface
    {
        dynamic FunctionARN { get; set; }
    }

    public interface IHaveConnectionTimeout : IResourceInterface
    {
        dynamic ConnectionTimeout { get; set; }
    }

    public interface IHaveAccessControlMaxAgeSec : IResourceInterface
    {
        dynamic AccessControlMaxAgeSec { get; set; }
    }

    public interface IHaveNotStartsWith : IResourceInterface
    {
        dynamic NotStartsWith { get; set; }
    }

    public interface IHaveNotEndsWith : IResourceInterface
    {
        dynamic NotEndsWith { get; set; }
    }

    public interface IHaveStartsWith : IResourceInterface
    {
        dynamic StartsWith { get; set; }
    }

    public interface IHaveEndsWith : IResourceInterface
    {
        dynamic EndsWith { get; set; }
    }

    public interface IHaveInsightType : IResourceInterface
    {
        dynamic InsightType { get; set; }
    }

    public interface IHaveDefaultBehavior : IResourceInterface
    {
        dynamic DefaultBehavior { get; set; }
    }

    public interface IHavePackaging : IResourceInterface
    {
        dynamic Packaging { get; set; }
    }

    public interface IHaveCommitId : IResourceInterface
    {
        dynamic CommitId { get; set; }
    }

    public interface IHaveListOfCodePipelinePipelineTypesInputArtifactInputArtifacts : IResourceInterface
    {
        List<Humidifier.CodePipeline.PipelineTypes.InputArtifact> InputArtifacts { get; set; }
    }

    public interface IHaveResult : IResourceInterface
    {
        dynamic Result { get; set; }
    }

    public interface IHaveCodePipelinePipelineTypesGitFilePathFilterCriteriaFilePaths : IResourceInterface
    {
        Humidifier.CodePipeline.PipelineTypes.GitFilePathFilterCriteria FilePaths { get; set; }
    }

    public interface IHaveCodePipelinePipelineTypesGitBranchFilterCriteriaBranches : IResourceInterface
    {
        Humidifier.CodePipeline.PipelineTypes.GitBranchFilterCriteria Branches { get; set; }
    }

    public interface IHaveEventSource : IResourceInterface
    {
        dynamic EventSource { get; set; }
    }

    public interface IHaveExtension : IResourceInterface
    {
        dynamic Extension { get; set; }
    }

    public interface IHaveEmailMessage : IResourceInterface
    {
        dynamic EmailMessage { get; set; }
    }

    public interface IHaveEmailSubject : IResourceInterface
    {
        dynamic EmailSubject { get; set; }
    }

    public interface IHaveMaxLength : IResourceInterface
    {
        dynamic MaxLength { get; set; }
    }

    public interface IHaveEventAction : IResourceInterface
    {
        dynamic EventAction { get; set; }
    }

    public interface IHaveHtmlBody : IResourceInterface
    {
        dynamic HtmlBody { get; set; }
    }

    public interface IHaveTestS3Uri : IResourceInterface
    {
        dynamic TestS3Uri { get; set; }
    }

    public interface IHaveLabels : IResourceInterface
    {
        dynamic Labels { get; set; }
    }

    public interface IHaveMessageType : IResourceInterface
    {
        dynamic MessageType { get; set; }
    }

    public interface IHaveAllAwsRegions : IResourceInterface
    {
        dynamic AllAwsRegions { get; set; }
    }

    public interface IHaveAwsRegions : IResourceInterface
    {
        dynamic AwsRegions { get; set; }
    }

    public interface IHaveRecordingFrequency : IResourceInterface
    {
        dynamic RecordingFrequency { get; set; }
    }

    public interface IHaveOrganizationConfigRuleTriggerTypes : IResourceInterface
    {
        dynamic OrganizationConfigRuleTriggerTypes { get; set; }
    }

    public interface IHaveConnectEvaluationFormTypesEvaluationFormSectionSection : IResourceInterface
    {
        Humidifier.Connect.EvaluationFormTypes.EvaluationFormSection Section { get; set; }
    }

    public interface IHaveScore : IResourceInterface
    {
        dynamic Score { get; set; }
    }

    public interface IHaveAutomaticFail : IResourceInterface
    {
        dynamic AutomaticFail { get; set; }
    }

    public interface IHaveInstructions : IResourceInterface
    {
        dynamic Instructions { get; set; }
    }

    public interface IHaveDisplayAs : IResourceInterface
    {
        dynamic DisplayAs { get; set; }
    }

    public interface IHaveConnectInstanceStorageConfigTypesEncryptionConfigEncryptionConfig : IResourceInterface
    {
        Humidifier.Connect.InstanceStorageConfigTypes.EncryptionConfig EncryptionConfig { get; set; }
    }

    public interface IHaveQueueArn : IResourceInterface
    {
        dynamic QueueArn { get; set; }
    }

    public interface IHaveListOfConnectRuleTypesFieldFields : IResourceInterface
    {
        List<Humidifier.Connect.RuleTypes.Field> Fields { get; set; }
    }

    public interface IHaveAttributeValue : IResourceInterface
    {
        dynamic AttributeValue { get; set; }
    }

    public interface IHaveEnableAnswerMachineDetection : IResourceInterface
    {
        dynamic EnableAnswerMachineDetection { get; set; }
    }

    public interface IHaveAwaitAnswerMachinePrompt : IResourceInterface
    {
        dynamic AwaitAnswerMachinePrompt { get; set; }
    }

    public interface IHaveConnectSourcePhoneNumber : IResourceInterface
    {
        dynamic ConnectSourcePhoneNumber { get; set; }
    }

    public interface IHaveWisdomTemplateArn : IResourceInterface
    {
        dynamic WisdomTemplateArn { get; set; }
    }

    public interface IHaveObjectCount : IResourceInterface
    {
        dynamic ObjectCount { get; set; }
    }

    public interface IHaveCustomerProfilesDomainTypesConflictResolutionConflictResolution : IResourceInterface
    {
        Humidifier.CustomerProfiles.DomainTypes.ConflictResolution ConflictResolution { get; set; }
    }

    public interface IHaveTime : IResourceInterface
    {
        dynamic Time { get; set; }
    }

    public interface IHaveCustomerProfilesDomainTypesExportingConfigExportingConfig : IResourceInterface
    {
        Humidifier.CustomerProfiles.DomainTypes.ExportingConfig ExportingConfig { get; set; }
    }

    public interface IHaveDLMLifecyclePolicyTypesCrossRegionCopyRetainRuleRetainRule : IResourceInterface
    {
        Humidifier.DLM.LifecyclePolicyTypes.CrossRegionCopyRetainRule RetainRule { get; set; }
    }

    public interface IHaveTargetRegion : IResourceInterface
    {
        dynamic TargetRegion { get; set; }
    }

    public interface IHaveCmkArn : IResourceInterface
    {
        dynamic CmkArn { get; set; }
    }

    public interface IHaveExecutionTimeout : IResourceInterface
    {
        dynamic ExecutionTimeout { get; set; }
    }

    public interface IHaveAuthSource : IResourceInterface
    {
        dynamic AuthSource { get; set; }
    }

    public interface IHaveAuthMechanism : IResourceInterface
    {
        dynamic AuthMechanism { get; set; }
    }

    public interface IHaveSecretsManagerOracleAsmAccessRoleArn : IResourceInterface
    {
        dynamic SecretsManagerOracleAsmAccessRoleArn { get; set; }
    }

    public interface IHaveSecretsManagerOracleAsmSecretId : IResourceInterface
    {
        dynamic SecretsManagerOracleAsmSecretId { get; set; }
    }

    public interface IHaveAsmServer : IResourceInterface
    {
        dynamic AsmServer { get; set; }
    }

    public interface IHaveDocsToInvestigate : IResourceInterface
    {
        dynamic DocsToInvestigate { get; set; }
    }

    public interface IHaveExtractDocId : IResourceInterface
    {
        dynamic ExtractDocId { get; set; }
    }

    public interface IHaveNestingLevel : IResourceInterface
    {
        dynamic NestingLevel { get; set; }
    }

    public interface IHaveErrorRetryDuration : IResourceInterface
    {
        dynamic ErrorRetryDuration { get; set; }
    }

    public interface IHaveCleanSourceMetadataOnMismatch : IResourceInterface
    {
        dynamic CleanSourceMetadataOnMismatch { get; set; }
    }

    public interface IHaveServerTimezone : IResourceInterface
    {
        dynamic ServerTimezone { get; set; }
    }

    public interface IHaveEventsPollInterval : IResourceInterface
    {
        dynamic EventsPollInterval { get; set; }
    }

    public interface IHaveParallelLoadThreads : IResourceInterface
    {
        dynamic ParallelLoadThreads { get; set; }
    }

    public interface IHaveLoadTimeout : IResourceInterface
    {
        dynamic LoadTimeout { get; set; }
    }

    public interface IHaveWriteBufferSize : IResourceInterface
    {
        dynamic WriteBufferSize { get; set; }
    }

    public interface IHaveIncludeTransactionDetails : IResourceInterface
    {
        dynamic IncludeTransactionDetails { get; set; }
    }

    public interface IHaveIncludeTableAlterOperations : IResourceInterface
    {
        dynamic IncludeTableAlterOperations { get; set; }
    }

    public interface IHaveSslCaCertificateArn : IResourceInterface
    {
        dynamic SslCaCertificateArn { get; set; }
    }

    public interface IHaveIncludeControlDetails : IResourceInterface
    {
        dynamic IncludeControlDetails { get; set; }
    }

    public interface IHaveIncludePartitionValue : IResourceInterface
    {
        dynamic IncludePartitionValue { get; set; }
    }

    public interface IHaveNoHexPrefix : IResourceInterface
    {
        dynamic NoHexPrefix { get; set; }
    }

    public interface IHavePartitionIncludeSchemaTable : IResourceInterface
    {
        dynamic PartitionIncludeSchemaTable { get; set; }
    }

    public interface IHaveIncludeNullAndEmpty : IResourceInterface
    {
        dynamic IncludeNullAndEmpty { get; set; }
    }

    public interface IHaveFailTasksOnLobTruncation : IResourceInterface
    {
        dynamic FailTasksOnLobTruncation { get; set; }
    }

    public interface IHaveRetryInterval : IResourceInterface
    {
        dynamic RetryInterval { get; set; }
    }

    public interface IHaveMapBooleanAsBoolean : IResourceInterface
    {
        dynamic MapBooleanAsBoolean { get; set; }
    }

    public interface IHaveServerSideEncryptionKmsKeyId : IResourceInterface
    {
        dynamic ServerSideEncryptionKmsKeyId { get; set; }
    }

    public interface IHaveBucketFolder : IResourceInterface
    {
        dynamic BucketFolder { get; set; }
    }

    public interface IHaveDateFormat : IResourceInterface
    {
        dynamic DateFormat { get; set; }
    }

    public interface IHaveHeaderRow : IResourceInterface
    {
        dynamic HeaderRow { get; set; }
    }

    public interface IHaveDataBrewDatasetTypesS3LocationTempDirectory : IResourceInterface
    {
        Humidifier.DataBrew.DatasetTypes.S3Location TempDirectory { get; set; }
    }

    public interface IHaveGlueConnectionName : IResourceInterface
    {
        dynamic GlueConnectionName { get; set; }
    }

    public interface IHaveSheetNames : IResourceInterface
    {
        dynamic SheetNames { get; set; }
    }

    public interface IHaveIntegerListOfSheetIndexes : IResourceInterface
    {
        List<int> SheetIndexes { get; set; }
    }

    public interface IHaveValueReference : IResourceInterface
    {
        dynamic ValueReference { get; set; }
    }

    public interface IHaveMultiLine : IResourceInterface
    {
        dynamic MultiLine { get; set; }
    }

    public interface IHaveDataBrewJobTypesDatabaseTableOutputOptionsDatabaseOptions : IResourceInterface
    {
        Humidifier.DataBrew.JobTypes.DatabaseTableOutputOptions DatabaseOptions { get; set; }
    }

    public interface IHaveDataBrewJobTypesS3LocationLocation : IResourceInterface
    {
        Humidifier.DataBrew.JobTypes.S3Location Location { get; set; }
    }

    public interface IHaveTargetColumn : IResourceInterface
    {
        dynamic TargetColumn { get; set; }
    }

    public interface IHaveDataBrewRecipeTypesS3LocationS3InputDefinition : IResourceInterface
    {
        Humidifier.DataBrew.RecipeTypes.S3Location S3InputDefinition { get; set; }
    }

    public interface IHaveDataBrewRecipeTypesDataCatalogInputDefinitionDataCatalogInputDefinition : IResourceInterface
    {
        Humidifier.DataBrew.RecipeTypes.DataCatalogInputDefinition DataCatalogInputDefinition { get; set; }
    }

    public interface IHaveSampleSize : IResourceInterface
    {
        dynamic SampleSize { get; set; }
    }

    public interface IHaveFormName : IResourceInterface
    {
        dynamic FormName { get; set; }
    }

    public interface IHaveDataAccessRole : IResourceInterface
    {
        dynamic DataAccessRole { get; set; }
    }

    public interface IHaveListOfDataZoneDataSourceTypesRelationalFilterConfigurationRelationalFilterConfigurations : IResourceInterface
    {
        List<Humidifier.DataZone.DataSourceTypes.RelationalFilterConfiguration> RelationalFilterConfigurations { get; set; }
    }

    public interface IHaveListOfDeadlineFleetTypesFleetAttributeCapabilityCustomAttributes : IResourceInterface
    {
        List<Humidifier.Deadline.FleetTypes.FleetAttributeCapability> CustomAttributes { get; set; }
    }

    public interface IHaveListOfDeadlineFleetTypesFleetAmountCapabilityCustomAmounts : IResourceInterface
    {
        List<Humidifier.Deadline.FleetTypes.FleetAmountCapability> CustomAmounts { get; set; }
    }

    public interface IHaveDeadlineFleetTypesVCpuCountRangeVCpuCount : IResourceInterface
    {
        Humidifier.Deadline.FleetTypes.VCpuCountRange VCpuCount { get; set; }
    }

    public interface IHaveDeadlineFleetTypesMemoryMiBRangeMemoryMiB : IResourceInterface
    {
        Humidifier.Deadline.FleetTypes.MemoryMiBRange MemoryMiB { get; set; }
    }

    public interface IHaveCpuArchitectureType : IResourceInterface
    {
        dynamic CpuArchitectureType { get; set; }
    }

    public interface IHaveSizeGiB : IResourceInterface
    {
        dynamic SizeGiB { get; set; }
    }

    public interface IHaveDynamoDBGlobalTableTypesProjectionProjection : IResourceInterface
    {
        Humidifier.DynamoDB.GlobalTableTypes.Projection Projection { get; set; }
    }

    public interface IHaveApproximateCreationDateTimePrecision : IResourceInterface
    {
        dynamic ApproximateCreationDateTimePrecision { get; set; }
    }

    public interface IHaveProjectionType : IResourceInterface
    {
        dynamic ProjectionType { get; set; }
    }

    public interface IHaveNonKeyAttributes : IResourceInterface
    {
        dynamic NonKeyAttributes { get; set; }
    }

    public interface IHaveMaxReadRequestUnits : IResourceInterface
    {
        dynamic MaxReadRequestUnits { get; set; }
    }

    public interface IHaveDynamoDBGlobalTableTypesContributorInsightsSpecificationContributorInsightsSpecification : IResourceInterface
    {
        Humidifier.DynamoDB.GlobalTableTypes.ContributorInsightsSpecification ContributorInsightsSpecification { get; set; }
    }

    public interface IHaveDynamoDBGlobalTableTypesReadProvisionedThroughputSettingsReadProvisionedThroughputSettings : IResourceInterface
    {
        Humidifier.DynamoDB.GlobalTableTypes.ReadProvisionedThroughputSettings ReadProvisionedThroughputSettings { get; set; }
    }

    public interface IHaveDynamoDBGlobalTableTypesReadOnDemandThroughputSettingsReadOnDemandThroughputSettings : IResourceInterface
    {
        Humidifier.DynamoDB.GlobalTableTypes.ReadOnDemandThroughputSettings ReadOnDemandThroughputSettings { get; set; }
    }

    public interface IHaveKMSMasterKeyId : IResourceInterface
    {
        dynamic KMSMasterKeyId { get; set; }
    }

    public interface IHaveDynamoDBGlobalTableTypesResourcePolicyResourcePolicy : IResourceInterface
    {
        Humidifier.DynamoDB.GlobalTableTypes.ResourcePolicy ResourcePolicy { get; set; }
    }

    public interface IHaveSSEType : IResourceInterface
    {
        dynamic SSEType { get; set; }
    }

    public interface IHaveStreamViewType : IResourceInterface
    {
        dynamic StreamViewType { get; set; }
    }

    public interface IHaveReadUnitsPerSecond : IResourceInterface
    {
        dynamic ReadUnitsPerSecond { get; set; }
    }

    public interface IHaveWriteUnitsPerSecond : IResourceInterface
    {
        dynamic WriteUnitsPerSecond { get; set; }
    }

    public interface IHaveMaxWriteRequestUnits : IResourceInterface
    {
        dynamic MaxWriteRequestUnits { get; set; }
    }

    public interface IHaveHeaderList : IResourceInterface
    {
        dynamic HeaderList { get; set; }
    }

    public interface IHaveDynamoDBTableTypesProjectionProjection : IResourceInterface
    {
        Humidifier.DynamoDB.TableTypes.Projection Projection { get; set; }
    }

    public interface IHaveTerminationDelay : IResourceInterface
    {
        dynamic TerminationDelay { get; set; }
    }

    public interface IHaveReplacementStrategy : IResourceInterface
    {
        dynamic ReplacementStrategy { get; set; }
    }

    public interface IHaveMaxPrice : IResourceInterface
    {
        dynamic MaxPrice { get; set; }
    }

    public interface IHaveSingleAvailabilityZone : IResourceInterface
    {
        dynamic SingleAvailabilityZone { get; set; }
    }

    public interface IHaveSingleInstanceType : IResourceInterface
    {
        dynamic SingleInstanceType { get; set; }
    }

    public interface IHaveMinTargetCapacity : IResourceInterface
    {
        dynamic MinTargetCapacity { get; set; }
    }

    public interface IHaveMaxTotalPrice : IResourceInterface
    {
        dynamic MaxTotalPrice { get; set; }
    }

    public interface IHaveSpreadDomain : IResourceInterface
    {
        dynamic SpreadDomain { get; set; }
    }

    public interface IHavePartitionNumber : IResourceInterface
    {
        dynamic PartitionNumber { get; set; }
    }

    public interface IHaveInstancePoolsToUseCount : IResourceInterface
    {
        dynamic InstancePoolsToUseCount { get; set; }
    }

    public interface IHaveOnDemandTargetCapacity : IResourceInterface
    {
        dynamic OnDemandTargetCapacity { get; set; }
    }

    public interface IHaveTargetCapacityUnitType : IResourceInterface
    {
        dynamic TargetCapacityUnitType { get; set; }
    }

    public interface IHaveCoreCount : IResourceInterface
    {
        dynamic CoreCount { get; set; }
    }

    public interface IHaveLicenseConfigurationArn : IResourceInterface
    {
        dynamic LicenseConfigurationArn { get; set; }
    }

    public interface IHaveAssociateCarrierIpAddress : IResourceInterface
    {
        dynamic AssociateCarrierIpAddress { get; set; }
    }

    public interface IHaveUdpTimeout : IResourceInterface
    {
        dynamic UdpTimeout { get; set; }
    }

    public interface IHaveTcpEstablishedTimeout : IResourceInterface
    {
        dynamic TcpEstablishedTimeout { get; set; }
    }

    public interface IHaveUdpStreamTimeout : IResourceInterface
    {
        dynamic UdpStreamTimeout { get; set; }
    }

    public interface IHaveEnaSrdEnabled : IResourceInterface
    {
        dynamic EnaSrdEnabled { get; set; }
    }

    public interface IHaveEnaSrdUdpEnabled : IResourceInterface
    {
        dynamic EnaSrdUdpEnabled { get; set; }
    }

    public interface IHaveIpv4Prefix : IResourceInterface
    {
        dynamic Ipv4Prefix { get; set; }
    }

    public interface IHaveIpv6Prefix : IResourceInterface
    {
        dynamic Ipv6Prefix { get; set; }
    }

    public interface IHaveDestinationAddresses : IResourceInterface
    {
        dynamic DestinationAddresses { get; set; }
    }

    public interface IHaveSourceAddresses : IResourceInterface
    {
        dynamic SourceAddresses { get; set; }
    }

    public interface IHaveEC2NetworkInsightsAccessScopeTypesResourceStatementRequestResourceStatement : IResourceInterface
    {
        Humidifier.EC2.NetworkInsightsAccessScopeTypes.ResourceStatementRequest ResourceStatement { get; set; }
    }

    public interface IHaveComponentId : IResourceInterface
    {
        dynamic ComponentId { get; set; }
    }

    public interface IHaveEC2NetworkInsightsAnalysisTypesPortRangePortRange : IResourceInterface
    {
        Humidifier.EC2.NetworkInsightsAnalysisTypes.PortRange PortRange { get; set; }
    }

    public interface IHaveLoadBalancerPort : IResourceInterface
    {
        dynamic LoadBalancerPort { get; set; }
    }

    public interface IHavePrefixListId : IResourceInterface
    {
        dynamic PrefixListId { get; set; }
    }

    public interface IHaveEC2NetworkInsightsAnalysisTypesAnalysisComponentElasticLoadBalancerListener : IResourceInterface
    {
        Humidifier.EC2.NetworkInsightsAnalysisTypes.AnalysisComponent ElasticLoadBalancerListener { get; set; }
    }

    public interface IHaveEC2NetworkInsightsAnalysisTypesAnalysisComponentSourceVpc : IResourceInterface
    {
        Humidifier.EC2.NetworkInsightsAnalysisTypes.AnalysisComponent SourceVpc { get; set; }
    }

    public interface IHaveEC2NetworkInsightsAnalysisTypesTransitGatewayRouteTableRouteTransitGatewayRouteTableRoute : IResourceInterface
    {
        Humidifier.EC2.NetworkInsightsAnalysisTypes.TransitGatewayRouteTableRoute TransitGatewayRouteTableRoute { get; set; }
    }

    public interface IHaveEC2NetworkInsightsAnalysisTypesAnalysisComponentDestinationVpc : IResourceInterface
    {
        Humidifier.EC2.NetworkInsightsAnalysisTypes.AnalysisComponent DestinationVpc { get; set; }
    }

    public interface IHaveEC2NetworkInsightsAnalysisTypesAnalysisComponentTransitGateway : IResourceInterface
    {
        Humidifier.EC2.NetworkInsightsAnalysisTypes.AnalysisComponent TransitGateway { get; set; }
    }

    public interface IHaveEC2NetworkInsightsAnalysisTypesAnalysisComponentSubnet : IResourceInterface
    {
        Humidifier.EC2.NetworkInsightsAnalysisTypes.AnalysisComponent Subnet { get; set; }
    }

    public interface IHaveEC2NetworkInsightsAnalysisTypesAnalysisComponentVpc : IResourceInterface
    {
        Humidifier.EC2.NetworkInsightsAnalysisTypes.AnalysisComponent Vpc { get; set; }
    }

    public interface IHaveEC2NetworkInsightsAnalysisTypesAnalysisRouteTableRouteRouteTableRoute : IResourceInterface
    {
        Humidifier.EC2.NetworkInsightsAnalysisTypes.AnalysisRouteTableRoute RouteTableRoute { get; set; }
    }

    public interface IHaveEC2NetworkInsightsAnalysisTypesAnalysisSecurityGroupRuleSecurityGroupRule : IResourceInterface
    {
        Humidifier.EC2.NetworkInsightsAnalysisTypes.AnalysisSecurityGroupRule SecurityGroupRule { get; set; }
    }

    public interface IHaveEC2NetworkInsightsAnalysisTypesAnalysisAclRuleAclRule : IResourceInterface
    {
        Humidifier.EC2.NetworkInsightsAnalysisTypes.AnalysisAclRule AclRule { get; set; }
    }

    public interface IHaveEC2SpotFleetTypesInstanceRequirementsRequestInstanceRequirements : IResourceInterface
    {
        Humidifier.EC2.SpotFleetTypes.InstanceRequirementsRequest InstanceRequirements { get; set; }
    }

    public interface IHaveListOfEC2SpotFleetTypesSpotFleetTagSpecificationTagSpecifications : IResourceInterface
    {
        List<Humidifier.EC2.SpotFleetTypes.SpotFleetTagSpecification> TagSpecifications { get; set; }
    }

    public interface IHaveTargetCapacity : IResourceInterface
    {
        dynamic TargetCapacity { get; set; }
    }

    public interface IHaveRegistryId : IResourceInterface
    {
        dynamic RegistryId { get; set; }
    }

    public interface IHaveFilter : IResourceInterface
    {
        dynamic Filter { get; set; }
    }

    public interface IHaveCloudWatchLogGroupName : IResourceInterface
    {
        dynamic CloudWatchLogGroupName { get; set; }
    }

    public interface IHaveRollback : IResourceInterface
    {
        dynamic Rollback { get; set; }
    }

    public interface IHavePortName : IResourceInterface
    {
        dynamic PortName { get; set; }
    }

    public interface IHaveRegistryArn : IResourceInterface
    {
        dynamic RegistryArn { get; set; }
    }

    public interface IHaveEntryPoint : IResourceInterface
    {
        dynamic EntryPoint { get; set; }
    }

    public interface IHaveMemoryReservation : IResourceInterface
    {
        dynamic MemoryReservation { get; set; }
    }

    public interface IHaveStartPeriod : IResourceInterface
    {
        dynamic StartPeriod { get; set; }
    }

    public interface IHaveDeviceType : IResourceInterface
    {
        dynamic DeviceType { get; set; }
    }

    public interface IHaveDrop : IResourceInterface
    {
        dynamic Drop { get; set; }
    }

    public interface IHaveStatusMessage : IResourceInterface
    {
        dynamic StatusMessage { get; set; }
    }

    public interface IHaveIdleTimeout : IResourceInterface
    {
        dynamic IdleTimeout { get; set; }
    }

    public interface IHaveJar : IResourceInterface
    {
        dynamic Jar { get; set; }
    }

    public interface IHaveMainClass : IResourceInterface
    {
        dynamic MainClass { get; set; }
    }

    public interface IHaveEMRClusterTypesEbsConfigurationEbsConfiguration : IResourceInterface
    {
        Humidifier.EMR.ClusterTypes.EbsConfiguration EbsConfiguration { get; set; }
    }

    public interface IHaveBidPriceAsPercentageOfOnDemandPrice : IResourceInterface
    {
        dynamic BidPriceAsPercentageOfOnDemandPrice { get; set; }
    }

    public interface IHaveEMRClusterTypesOnDemandCapacityReservationOptionsCapacityReservationOptions : IResourceInterface
    {
        Humidifier.EMR.ClusterTypes.OnDemandCapacityReservationOptions CapacityReservationOptions { get; set; }
    }

    public interface IHaveCoolDown : IResourceInterface
    {
        dynamic CoolDown { get; set; }
    }

    public interface IHaveListOfEMRInstanceFleetConfigTypesConfigurationConfigurations : IResourceInterface
    {
        List<Humidifier.EMR.InstanceFleetConfigTypes.Configuration> Configurations { get; set; }
    }

    public interface IHaveEMRInstanceFleetConfigTypesOnDemandCapacityReservationOptionsCapacityReservationOptions : IResourceInterface
    {
        Humidifier.EMR.InstanceFleetConfigTypes.OnDemandCapacityReservationOptions CapacityReservationOptions { get; set; }
    }

    public interface IHaveWorkerCount : IResourceInterface
    {
        dynamic WorkerCount { get; set; }
    }

    public interface IHaveDisk : IResourceInterface
    {
        dynamic Disk { get; set; }
    }

    public interface IHaveReplicationGroupRegion : IResourceInterface
    {
        dynamic ReplicationGroupRegion { get; set; }
    }

    public interface IHaveNodeGroupId : IResourceInterface
    {
        dynamic NodeGroupId { get; set; }
    }

    public interface IHaveDeleteSourceFromS3 : IResourceInterface
    {
        dynamic DeleteSourceFromS3 { get; set; }
    }

    public interface IHaveMaxCount : IResourceInterface
    {
        dynamic MaxCount { get; set; }
    }

    public interface IHaveUserPoolClientId : IResourceInterface
    {
        dynamic UserPoolClientId { get; set; }
    }

    public interface IHaveUserPoolDomain : IResourceInterface
    {
        dynamic UserPoolDomain { get; set; }
    }

    public interface IHaveUseExistingClientSecret : IResourceInterface
    {
        dynamic UseExistingClientSecret { get; set; }
    }

    public interface IHaveMessageBody : IResourceInterface
    {
        dynamic MessageBody { get; set; }
    }

    public interface IHaveQuery : IResourceInterface
    {
        dynamic Query { get; set; }
    }

    public interface IHaveHttpCode : IResourceInterface
    {
        dynamic HttpCode { get; set; }
    }

    public interface IHaveRevocationType : IResourceInterface
    {
        dynamic RevocationType { get; set; }
    }

    public interface IHaveAnonymousAuthEnabled : IResourceInterface
    {
        dynamic AnonymousAuthEnabled { get; set; }
    }

    public interface IHaveInternalUserDatabaseEnabled : IResourceInterface
    {
        dynamic InternalUserDatabaseEnabled { get; set; }
    }

    public interface IHaveCustomEndpoint : IResourceInterface
    {
        dynamic CustomEndpoint { get; set; }
    }

    public interface IHaveCustomEndpointCertificateArn : IResourceInterface
    {
        dynamic CustomEndpointCertificateArn { get; set; }
    }

    public interface IHaveCustomEndpointEnabled : IResourceInterface
    {
        dynamic CustomEndpointEnabled { get; set; }
    }

    public interface IHaveEnforceHTTPS : IResourceInterface
    {
        dynamic EnforceHTTPS { get; set; }
    }

    public interface IHaveTLSSecurityPolicy : IResourceInterface
    {
        dynamic TLSSecurityPolicy { get; set; }
    }

    public interface IHaveEBSEnabled : IResourceInterface
    {
        dynamic EBSEnabled { get; set; }
    }

    public interface IHaveDedicatedMasterCount : IResourceInterface
    {
        dynamic DedicatedMasterCount { get; set; }
    }

    public interface IHaveDedicatedMasterEnabled : IResourceInterface
    {
        dynamic DedicatedMasterEnabled { get; set; }
    }

    public interface IHaveDedicatedMasterType : IResourceInterface
    {
        dynamic DedicatedMasterType { get; set; }
    }

    public interface IHaveWarmCount : IResourceInterface
    {
        dynamic WarmCount { get; set; }
    }

    public interface IHaveWarmEnabled : IResourceInterface
    {
        dynamic WarmEnabled { get; set; }
    }

    public interface IHaveWarmType : IResourceInterface
    {
        dynamic WarmType { get; set; }
    }

    public interface IHaveZoneAwarenessEnabled : IResourceInterface
    {
        dynamic ZoneAwarenessEnabled { get; set; }
    }

    public interface IHaveMasterUserARN : IResourceInterface
    {
        dynamic MasterUserARN { get; set; }
    }

    public interface IHaveAutomatedSnapshotStartHour : IResourceInterface
    {
        dynamic AutomatedSnapshotStartHour { get; set; }
    }

    public interface IHaveAvailabilityZoneCount : IResourceInterface
    {
        dynamic AvailabilityZoneCount { get; set; }
    }

    public interface IHaveIdMappingType : IResourceInterface
    {
        dynamic IdMappingType { get; set; }
    }

    public interface IHaveOutputS3Path : IResourceInterface
    {
        dynamic OutputS3Path { get; set; }
    }

    public interface IHaveIntermediateS3Path : IResourceInterface
    {
        dynamic IntermediateS3Path { get; set; }
    }

    public interface IHaveApplyNormalization : IResourceInterface
    {
        dynamic ApplyNormalization { get; set; }
    }

    public interface IHaveHashed : IResourceInterface
    {
        dynamic Hashed { get; set; }
    }

    public interface IHaveEventsConnectionTypesResourceParametersResourceParameters : IResourceInterface
    {
        Humidifier.Events.ConnectionTypes.ResourceParameters ResourceParameters { get; set; }
    }

    public interface IHaveJobDefinition : IResourceInterface
    {
        dynamic JobDefinition { get; set; }
    }

    public interface IHaveSqls : IResourceInterface
    {
        dynamic Sqls { get; set; }
    }

    public interface IHaveSql : IResourceInterface
    {
        dynamic Sql { get; set; }
    }

    public interface IHaveWithEvent : IResourceInterface
    {
        dynamic WithEvent { get; set; }
    }

    public interface IHaveEntityIdKey : IResourceInterface
    {
        dynamic EntityIdKey { get; set; }
    }

    public interface IHaveFeature : IResourceInterface
    {
        dynamic Feature { get; set; }
    }

    public interface IHaveSplitWeight : IResourceInterface
    {
        dynamic SplitWeight { get; set; }
    }

    public interface IHaveFirewallDeploymentModel : IResourceInterface
    {
        dynamic FirewallDeploymentModel { get; set; }
    }

    public interface IHaveClients : IResourceInterface
    {
        dynamic Clients { get; set; }
    }

    public interface IHaveEndpointIpAddressRange : IResourceInterface
    {
        dynamic EndpointIpAddressRange { get; set; }
    }

    public interface IHaveCopyTagsToSnapshots : IResourceInterface
    {
        dynamic CopyTagsToSnapshots { get; set; }
    }

    public interface IHaveRecordSizeKiB : IResourceInterface
    {
        dynamic RecordSizeKiB { get; set; }
    }

    public interface IHaveFileSystemAdministratorsGroup : IResourceInterface
    {
        dynamic FileSystemAdministratorsGroup { get; set; }
    }

    public interface IHaveDnsIps : IResourceInterface
    {
        dynamic DnsIps { get; set; }
    }

    public interface IHavePolicyPeriodInMinutes : IResourceInterface
    {
        dynamic PolicyPeriodInMinutes { get; set; }
    }

    public interface IHaveNewGameSessionsPerCreator : IResourceInterface
    {
        dynamic NewGameSessionsPerCreator { get; set; }
    }

    public interface IHaveScalingAdjustmentType : IResourceInterface
    {
        dynamic ScalingAdjustmentType { get; set; }
    }

    public interface IHaveListOfGameLiftContainerGroupDefinitionTypesContainerMountPointMountPoints : IResourceInterface
    {
        List<Humidifier.GameLift.ContainerGroupDefinitionTypes.ContainerMountPoint> MountPoints { get; set; }
    }

    public interface IHaveListOfGameLiftContainerGroupDefinitionTypesContainerDependencyDependsOn : IResourceInterface
    {
        List<Humidifier.GameLift.ContainerGroupDefinitionTypes.ContainerDependency> DependsOn { get; set; }
    }

    public interface IHaveListOfGameLiftContainerGroupDefinitionTypesContainerEnvironmentEnvironmentOverride : IResourceInterface
    {
        List<Humidifier.GameLift.ContainerGroupDefinitionTypes.ContainerEnvironment> EnvironmentOverride { get; set; }
    }

    public interface IHaveResolvedImageDigest : IResourceInterface
    {
        dynamic ResolvedImageDigest { get; set; }
    }

    public interface IHaveGameLiftContainerGroupDefinitionTypesPortConfigurationPortConfiguration : IResourceInterface
    {
        Humidifier.GameLift.ContainerGroupDefinitionTypes.PortConfiguration PortConfiguration { get; set; }
    }

    public interface IHaveUpdateStatus : IResourceInterface
    {
        dynamic UpdateStatus { get; set; }
    }

    public interface IHaveQuoteSymbol : IResourceInterface
    {
        dynamic QuoteSymbol { get; set; }
    }

    public interface IHaveContainsHeader : IResourceInterface
    {
        dynamic ContainsHeader { get; set; }
    }

    public interface IHaveSecurityGroupIdList : IResourceInterface
    {
        dynamic SecurityGroupIdList { get; set; }
    }

    public interface IHaveDlqEventQueueArn : IResourceInterface
    {
        dynamic DlqEventQueueArn { get; set; }
    }

    public interface IHaveEventQueueArn : IResourceInterface
    {
        dynamic EventQueueArn { get; set; }
    }

    public interface IHaveNotifyDelayAfter : IResourceInterface
    {
        dynamic NotifyDelayAfter { get; set; }
    }

    public interface IHaveColumn : IResourceInterface
    {
        dynamic Column { get; set; }
    }

    public interface IHaveSchemaVersionNumber : IResourceInterface
    {
        dynamic SchemaVersionNumber { get; set; }
    }

    public interface IHaveSerializationLibrary : IResourceInterface
    {
        dynamic SerializationLibrary { get; set; }
    }

    public interface IHaveSkewedColumnNames : IResourceInterface
    {
        dynamic SkewedColumnNames { get; set; }
    }

    public interface IHaveSkewedColumnValues : IResourceInterface
    {
        dynamic SkewedColumnValues { get; set; }
    }

    public interface IHaveSkewedColumnValueLocationMaps : IResourceInterface
    {
        dynamic SkewedColumnValueLocationMaps { get; set; }
    }

    public interface IHaveStoredAsSubDirectories : IResourceInterface
    {
        dynamic StoredAsSubDirectories { get; set; }
    }

    public interface IHaveBucketColumns : IResourceInterface
    {
        dynamic BucketColumns { get; set; }
    }

    public interface IHaveNumberOfBuckets : IResourceInterface
    {
        dynamic NumberOfBuckets { get; set; }
    }

    public interface IHaveCompressed : IResourceInterface
    {
        dynamic Compressed { get; set; }
    }

    public interface IHaveCrawlerName : IResourceInterface
    {
        dynamic CrawlerName { get; set; }
    }

    public interface IHaveGreengrassFunctionDefinitionTypesExecutionExecution : IResourceInterface
    {
        Humidifier.Greengrass.FunctionDefinitionTypes.Execution Execution { get; set; }
    }

    public interface IHaveVariables : IResourceInterface
    {
        dynamic Variables { get; set; }
    }

    public interface IHaveAccessSysfs : IResourceInterface
    {
        dynamic AccessSysfs { get; set; }
    }

    public interface IHaveExecutable : IResourceInterface
    {
        dynamic Executable { get; set; }
    }

    public interface IHaveGreengrassFunctionDefinitionVersionTypesExecutionExecution : IResourceInterface
    {
        Humidifier.Greengrass.FunctionDefinitionVersionTypes.Execution Execution { get; set; }
    }

    public interface IHaveSpace : IResourceInterface
    {
        dynamic Space { get; set; }
    }

    public interface IHaveComponent : IResourceInterface
    {
        dynamic Component { get; set; }
    }

    public interface IHaveAutoAddGroupOwner : IResourceInterface
    {
        dynamic AutoAddGroupOwner { get; set; }
    }

    public interface IHaveGreengrassResourceDefinitionTypesGroupOwnerSettingGroupOwnerSetting : IResourceInterface
    {
        Humidifier.Greengrass.ResourceDefinitionTypes.GroupOwnerSetting GroupOwnerSetting { get; set; }
    }

    public interface IHaveGroupPermission : IResourceInterface
    {
        dynamic GroupPermission { get; set; }
    }

    public interface IHaveGreengrassResourceDefinitionTypesResourceDownloadOwnerSettingOwnerSetting : IResourceInterface
    {
        Humidifier.Greengrass.ResourceDefinitionTypes.ResourceDownloadOwnerSetting OwnerSetting { get; set; }
    }

    public interface IHaveSageMakerJobArn : IResourceInterface
    {
        dynamic SageMakerJobArn { get; set; }
    }

    public interface IHaveARN : IResourceInterface
    {
        dynamic ARN { get; set; }
    }

    public interface IHaveAdditionalStagingLabelsToDownload : IResourceInterface
    {
        dynamic AdditionalStagingLabelsToDownload { get; set; }
    }

    public interface IHaveGreengrassResourceDefinitionVersionTypesGroupOwnerSettingGroupOwnerSetting : IResourceInterface
    {
        Humidifier.Greengrass.ResourceDefinitionVersionTypes.GroupOwnerSetting GroupOwnerSetting { get; set; }
    }

    public interface IHaveGreengrassResourceDefinitionVersionTypesResourceDownloadOwnerSettingOwnerSetting : IResourceInterface
    {
        Humidifier.Greengrass.ResourceDefinitionVersionTypes.ResourceDownloadOwnerSetting OwnerSetting { get; set; }
    }

    public interface IHaveAddGroupOwner : IResourceInterface
    {
        dynamic AddGroupOwner { get; set; }
    }

    public interface IHaveDynDicOfEnvironmentVariables : IResourceInterface
    {
        Dictionary<string, dynamic> EnvironmentVariables { get; set; }
    }

    public interface IHaveComponentVersion : IResourceInterface
    {
        dynamic ComponentVersion { get; set; }
    }

    public interface IHaveMinNumberOfExecutedThings : IResourceInterface
    {
        dynamic MinNumberOfExecutedThings { get; set; }
    }

    public interface IHaveMaximumPerMinute : IResourceInterface
    {
        dynamic MaximumPerMinute { get; set; }
    }

    public interface IHaveBaseRatePerMinute : IResourceInterface
    {
        dynamic BaseRatePerMinute { get; set; }
    }

    public interface IHaveIncrementFactor : IResourceInterface
    {
        dynamic IncrementFactor { get; set; }
    }

    public interface IHaveNumberOfSucceededThings : IResourceInterface
    {
        dynamic NumberOfSucceededThings { get; set; }
    }

    public interface IHaveNumberOfNotifiedThings : IResourceInterface
    {
        dynamic NumberOfNotifiedThings { get; set; }
    }

    public interface IHaveInProgressTimeoutInMinutes : IResourceInterface
    {
        dynamic InProgressTimeoutInMinutes { get; set; }
    }

    public interface IHaveGroundStationConfigTypesSpectrumConfigSpectrumConfig : IResourceInterface
    {
        Humidifier.GroundStation.ConfigTypes.SpectrumConfig SpectrumConfig { get; set; }
    }

    public interface IHaveUnvalidatedJSON : IResourceInterface
    {
        dynamic UnvalidatedJSON { get; set; }
    }

    public interface IHavePolarization : IResourceInterface
    {
        dynamic Polarization { get; set; }
    }

    public interface IHaveGroundStationConfigTypesFrequencyCenterFrequency : IResourceInterface
    {
        Humidifier.GroundStation.ConfigTypes.Frequency CenterFrequency { get; set; }
    }

    public interface IHaveSeconds : IResourceInterface
    {
        dynamic Seconds { get; set; }
    }

    public interface IHaveMetadata : IResourceInterface
    {
        dynamic Metadata { get; set; }
    }

    public interface IHaveImageScanningEnabled : IResourceInterface
    {
        dynamic ImageScanningEnabled { get; set; }
    }

    public interface IHaveTimeoutMinutes : IResourceInterface
    {
        dynamic TimeoutMinutes { get; set; }
    }

    public interface IHaveImageTestsEnabled : IResourceInterface
    {
        dynamic ImageTestsEnabled { get; set; }
    }

    public interface IHaveParallelGroup : IResourceInterface
    {
        dynamic ParallelGroup { get; set; }
    }

    public interface IHaveWorkflowArn : IResourceInterface
    {
        dynamic WorkflowArn { get; set; }
    }

    public interface IHaveOnFailure : IResourceInterface
    {
        dynamic OnFailure { get; set; }
    }

    public interface IHaveIsPublic : IResourceInterface
    {
        dynamic IsPublic { get; set; }
    }

    public interface IHaveEndInclusive : IResourceInterface
    {
        dynamic EndInclusive { get; set; }
    }

    public interface IHaveExportMetric : IResourceInterface
    {
        dynamic ExportMetric { get; set; }
    }

    public interface IHaveIoTSecurityProfileTypesMetricDimensionMetricDimension : IResourceInterface
    {
        Humidifier.IoT.SecurityProfileTypes.MetricDimension MetricDimension { get; set; }
    }

    public interface IHaveConfidenceLevel : IResourceInterface
    {
        dynamic ConfidenceLevel { get; set; }
    }

    public interface IHaveMetricValue : IResourceInterface
    {
        dynamic MetricValue { get; set; }
    }

    public interface IHaveMetricNamespace : IResourceInterface
    {
        dynamic MetricNamespace { get; set; }
    }

    public interface IHaveIndex : IResourceInterface
    {
        dynamic Index { get; set; }
    }

    public interface IHaveConfirmationUrl : IResourceInterface
    {
        dynamic ConfirmationUrl { get; set; }
    }

    public interface IHaveMessageId : IResourceInterface
    {
        dynamic MessageId { get; set; }
    }

    public interface IHaveServiceManagedS3 : IResourceInterface
    {
        dynamic ServiceManagedS3 { get; set; }
    }

    public interface IHaveSqlQuery : IResourceInterface
    {
        dynamic SqlQuery { get; set; }
    }

    public interface IHaveContentExpression : IResourceInterface
    {
        dynamic ContentExpression { get; set; }
    }

    public interface IHaveListOfIoTEventsDetectorModelTypesActionActions : IResourceInterface
    {
        List<Humidifier.IoTEvents.DetectorModelTypes.Action> Actions { get; set; }
    }

    public interface IHaveTriggerMode : IResourceInterface
    {
        dynamic TriggerMode { get; set; }
    }

    public interface IHaveConditionExpression : IResourceInterface
    {
        dynamic ConditionExpression { get; set; }
    }

    public interface IHaveInterfaceId : IResourceInterface
    {
        dynamic InterfaceId { get; set; }
    }

    public interface IHaveAssignedValue : IResourceInterface
    {
        dynamic AssignedValue { get; set; }
    }

    public interface IHavearn : IResourceInterface
    {
        dynamic arn { get; set; }
    }

    public interface IHaveListOfIoTSiteWiseAssetModelTypesExpressionVariableVariables : IResourceInterface
    {
        List<Humidifier.IoTSiteWise.AssetModelTypes.ExpressionVariable> Variables { get; set; }
    }

    public interface IHaveUnitOfMeasure : IResourceInterface
    {
        dynamic UnitOfMeasure { get; set; }
    }

    public interface IHaveIsExternalId : IResourceInterface
    {
        dynamic IsExternalId { get; set; }
    }

    public interface IHaveIsStoredExternally : IResourceInterface
    {
        dynamic IsStoredExternally { get; set; }
    }

    public interface IHaveIsTimeSeries : IResourceInterface
    {
        dynamic IsTimeSeries { get; set; }
    }

    public interface IHaveIsRequiredInEntity : IResourceInterface
    {
        dynamic IsRequiredInEntity { get; set; }
    }

    public interface IHaveGroupType : IResourceInterface
    {
        dynamic GroupType { get; set; }
    }

    public interface IHavePropertyNames : IResourceInterface
    {
        dynamic PropertyNames { get; set; }
    }

    public interface IHaveRelationshipType : IResourceInterface
    {
        dynamic RelationshipType { get; set; }
    }

    public interface IHaveTargetComponentTypeId : IResourceInterface
    {
        dynamic TargetComponentTypeId { get; set; }
    }

    public interface IHaveTargetComponentName : IResourceInterface
    {
        dynamic TargetComponentName { get; set; }
    }

    public interface IHaveTargetEntityId : IResourceInterface
    {
        dynamic TargetEntityId { get; set; }
    }

    public interface IHaveIoTTwinMakerEntityTypesStatusStatus : IResourceInterface
    {
        Humidifier.IoTTwinMaker.EntityTypes.Status Status { get; set; }
    }

    public interface IHaveIoTTwinMakerEntityTypesPropertyGroupPropertyGroups : IResourceInterface
    {
        Dictionary<string, Humidifier.IoTTwinMaker.EntityTypes.PropertyGroup> PropertyGroups { get; set; }
    }

    public interface IHaveIoTTwinMakerEntityTypesPropertyProperties : IResourceInterface
    {
        Dictionary<string, Humidifier.IoTTwinMaker.EntityTypes.Property> Properties { get; set; }
    }

    public interface IHaveAppServerPrivateKey : IResourceInterface
    {
        dynamic AppServerPrivateKey { get; set; }
    }

    public interface IHaveIoTWirelessTaskDefinitionTypesLoRaWANGatewayVersionUpdateVersion : IResourceInterface
    {
        Humidifier.IoTWireless.TaskDefinitionTypes.LoRaWANGatewayVersion UpdateVersion { get; set; }
    }

    public interface IHaveIoTWirelessTaskDefinitionTypesLoRaWANGatewayVersionCurrentVersion : IResourceInterface
    {
        Humidifier.IoTWireless.TaskDefinitionTypes.LoRaWANGatewayVersion CurrentVersion { get; set; }
    }

    public interface IHaveDevAddr : IResourceInterface
    {
        dynamic DevAddr { get; set; }
    }

    public interface IHaveAppKey : IResourceInterface
    {
        dynamic AppKey { get; set; }
    }

    public interface IHaveAppSKey : IResourceInterface
    {
        dynamic AppSKey { get; set; }
    }

    public interface IHaveMcuCount : IResourceInterface
    {
        dynamic McuCount { get; set; }
    }

    public interface IHaveCpuUtilizationPercentage : IResourceInterface
    {
        dynamic CpuUtilizationPercentage { get; set; }
    }

    public interface IHaveDisableLocalGroups : IResourceInterface
    {
        dynamic DisableLocalGroups { get; set; }
    }

    public interface IHaveUseChangeLog : IResourceInterface
    {
        dynamic UseChangeLog { get; set; }
    }

    public interface IHaveGroupAttributeField : IResourceInterface
    {
        dynamic GroupAttributeField { get; set; }
    }

    public interface IHaveUserNameAttributeField : IResourceInterface
    {
        dynamic UserNameAttributeField { get; set; }
    }

    public interface IHaveNamePrefix : IResourceInterface
    {
        dynamic NamePrefix { get; set; }
    }

    public interface IHaveKinesisAnalyticsV2ApplicationTypesS3ContentLocationS3ContentLocation : IResourceInterface
    {
        Humidifier.KinesisAnalyticsV2.ApplicationTypes.S3ContentLocation S3ContentLocation { get; set; }
    }

    public interface IHaveIndexRotationPeriod : IResourceInterface
    {
        dynamic IndexRotationPeriod { get; set; }
    }

    public interface IHaveClusterEndpoint : IResourceInterface
    {
        dynamic ClusterEndpoint { get; set; }
    }

    public interface IHaveDomainARN : IResourceInterface
    {
        dynamic DomainARN { get; set; }
    }

    public interface IHaveKinesisFirehoseDeliveryStreamTypesDocumentIdOptionsDocumentIdOptions : IResourceInterface
    {
        Humidifier.KinesisFirehose.DeliveryStreamTypes.DocumentIdOptions DocumentIdOptions { get; set; }
    }

    public interface IHaveErrorOutputPrefix : IResourceInterface
    {
        dynamic ErrorOutputPrefix { get; set; }
    }

    public interface IHaveKinesisFirehoseDeliveryStreamTypesS3DestinationConfigurationS3BackupConfiguration : IResourceInterface
    {
        Humidifier.KinesisFirehose.DeliveryStreamTypes.S3DestinationConfiguration S3BackupConfiguration { get; set; }
    }

    public interface IHaveKinesisFirehoseDeliveryStreamTypesEncryptionConfigurationEncryptionConfiguration : IResourceInterface
    {
        Humidifier.KinesisFirehose.DeliveryStreamTypes.EncryptionConfiguration EncryptionConfiguration { get; set; }
    }

    public interface IHaveFormatVersion : IResourceInterface
    {
        dynamic FormatVersion { get; set; }
    }

    public interface IHaveBlockSizeBytes : IResourceInterface
    {
        dynamic BlockSizeBytes { get; set; }
    }

    public interface IHaveTableWildcard : IResourceInterface
    {
        dynamic TableWildcard { get; set; }
    }

    public interface IHaveProvisionedConcurrentExecutions : IResourceInterface
    {
        dynamic ProvisionedConcurrentExecutions { get; set; }
    }

    public interface IHaveConsumerGroupId : IResourceInterface
    {
        dynamic ConsumerGroupId { get; set; }
    }

    public interface IHaveUpdateRuntimeOn : IResourceInterface
    {
        dynamic UpdateRuntimeOn { get; set; }
    }

    public interface IHaveRuntimeVersionArn : IResourceInterface
    {
        dynamic RuntimeVersionArn { get; set; }
    }

    public interface IHaveApplyOn : IResourceInterface
    {
        dynamic ApplyOn { get; set; }
    }

    public interface IHaveIpv6AllowedForDualStack : IResourceInterface
    {
        dynamic Ipv6AllowedForDualStack { get; set; }
    }

    public interface IHaveStartTimeoutMs : IResourceInterface
    {
        dynamic StartTimeoutMs { get; set; }
    }

    public interface IHaveEndTimeoutMs : IResourceInterface
    {
        dynamic EndTimeoutMs { get; set; }
    }

    public interface IHaveLexBotTypesResponseSpecificationResponse : IResourceInterface
    {
        Humidifier.Lex.BotTypes.ResponseSpecification Response { get; set; }
    }

    public interface IHaveEnableCodeHookInvocation : IResourceInterface
    {
        dynamic EnableCodeHookInvocation { get; set; }
    }

    public interface IHaveInvocationLabel : IResourceInterface
    {
        dynamic InvocationLabel { get; set; }
    }

    public interface IHaveListOfLexBotTypesMessageGroupMessageGroups : IResourceInterface
    {
        List<Humidifier.Lex.BotTypes.MessageGroup> MessageGroups { get; set; }
    }

    public interface IHaveFrequencyInSeconds : IResourceInterface
    {
        dynamic FrequencyInSeconds { get; set; }
    }

    public interface IHaveLexBotTypesConditionalSpecificationConditional : IResourceInterface
    {
        Humidifier.Lex.BotTypes.ConditionalSpecification Conditional { get; set; }
    }

    public interface IHaveListOfLexBotTypesSampleUtteranceSampleUtterances : IResourceInterface
    {
        List<Humidifier.Lex.BotTypes.SampleUtterance> SampleUtterances { get; set; }
    }

    public interface IHaveLexBotTypesPromptSpecificationPromptSpecification : IResourceInterface
    {
        Humidifier.Lex.BotTypes.PromptSpecification PromptSpecification { get; set; }
    }

    public interface IHaveLexBotTypesElicitationCodeHookInvocationSettingElicitationCodeHook : IResourceInterface
    {
        Humidifier.Lex.BotTypes.ElicitationCodeHookInvocationSetting ElicitationCodeHook { get; set; }
    }

    public interface IHaveCodeHookInterfaceVersion : IResourceInterface
    {
        dynamic CodeHookInterfaceVersion { get; set; }
    }

    public interface IHaveLexBotTypesResponseSpecificationSuccessResponse : IResourceInterface
    {
        Humidifier.Lex.BotTypes.ResponseSpecification SuccessResponse { get; set; }
    }

    public interface IHaveLexBotTypesDialogStateTimeoutNextStep : IResourceInterface
    {
        Humidifier.Lex.BotTypes.DialogState TimeoutNextStep { get; set; }
    }

    public interface IHaveLexBotTypesConditionalSpecificationSuccessConditional : IResourceInterface
    {
        Humidifier.Lex.BotTypes.ConditionalSpecification SuccessConditional { get; set; }
    }

    public interface IHaveLexBotTypesResponseSpecificationTimeoutResponse : IResourceInterface
    {
        Humidifier.Lex.BotTypes.ResponseSpecification TimeoutResponse { get; set; }
    }

    public interface IHaveLexBotTypesDialogStateSuccessNextStep : IResourceInterface
    {
        Humidifier.Lex.BotTypes.DialogState SuccessNextStep { get; set; }
    }

    public interface IHaveLexBotTypesConditionalSpecificationTimeoutConditional : IResourceInterface
    {
        Humidifier.Lex.BotTypes.ConditionalSpecification TimeoutConditional { get; set; }
    }

    public interface IHaveDetectSentiment : IResourceInterface
    {
        dynamic DetectSentiment { get; set; }
    }

    public interface IHaveMaxTimeToLiveInMinutes : IResourceInterface
    {
        dynamic MaxTimeToLiveInMinutes { get; set; }
    }

    public interface IHaveVariable : IResourceInterface
    {
        dynamic Variable { get; set; }
    }

    public interface IHaveAddOnType : IResourceInterface
    {
        dynamic AddOnType { get; set; }
    }

    public interface IHaveSnapshotTimeOfDay : IResourceInterface
    {
        dynamic SnapshotTimeOfDay { get; set; }
    }

    public interface IHaveCharset : IResourceInterface
    {
        dynamic Charset { get; set; }
    }

    public interface IHaveFileCompression : IResourceInterface
    {
        dynamic FileCompression { get; set; }
    }

    public interface IHaveLookoutMetricsAnomalyDetectorTypesVpcConfigurationVpcConfiguration : IResourceInterface
    {
        Humidifier.LookoutMetrics.AnomalyDetectorTypes.VpcConfiguration VpcConfiguration { get; set; }
    }

    public interface IHaveEnabledInBroker : IResourceInterface
    {
        dynamic EnabledInBroker { get; set; }
    }

    public interface IHaveFrameworkVersion : IResourceInterface
    {
        dynamic FrameworkVersion { get; set; }
    }

    public interface IHaveMulticastIp : IResourceInterface
    {
        dynamic MulticastIp { get; set; }
    }

    public interface IHaveFailoverMode : IResourceInterface
    {
        dynamic FailoverMode { get; set; }
    }

    public interface IHaveMulticastSourceIp : IResourceInterface
    {
        dynamic MulticastSourceIp { get; set; }
    }

    public interface IHavePrimarySource : IResourceInterface
    {
        dynamic PrimarySource { get; set; }
    }

    public interface IHaveEncodingName : IResourceInterface
    {
        dynamic EncodingName { get; set; }
    }

    public interface IHaveMetadataControl : IResourceInterface
    {
        dynamic MetadataControl { get; set; }
    }

    public interface IHaveLfeFilter : IResourceInterface
    {
        dynamic LfeFilter { get; set; }
    }

    public interface IHaveBitstreamMode : IResourceInterface
    {
        dynamic BitstreamMode { get; set; }
    }

    public interface IHaveAttenuationControl : IResourceInterface
    {
        dynamic AttenuationControl { get; set; }
    }

    public interface IHaveMediaLiveChannelTypesM2tsSettingsM2tsSettings : IResourceInterface
    {
        Humidifier.MediaLive.ChannelTypes.M2tsSettings M2tsSettings { get; set; }
    }

    public interface IHaveAudioSelectorName : IResourceInterface
    {
        dynamic AudioSelectorName { get; set; }
    }

    public interface IHaveDvbDashAccessibility : IResourceInterface
    {
        dynamic DvbDashAccessibility { get; set; }
    }

    public interface IHavePostFilterSharpening : IResourceInterface
    {
        dynamic PostFilterSharpening { get; set; }
    }

    public interface IHaveStrength : IResourceInterface
    {
        dynamic Strength { get; set; }
    }

    public interface IHaveBackgroundOpacity : IResourceInterface
    {
        dynamic BackgroundOpacity { get; set; }
    }

    public interface IHaveFontResolution : IResourceInterface
    {
        dynamic FontResolution { get; set; }
    }

    public interface IHaveOutlineColor : IResourceInterface
    {
        dynamic OutlineColor { get; set; }
    }

    public interface IHaveShadowColor : IResourceInterface
    {
        dynamic ShadowColor { get; set; }
    }

    public interface IHaveShadowOpacity : IResourceInterface
    {
        dynamic ShadowOpacity { get; set; }
    }

    public interface IHaveMediaLiveChannelTypesInputLocationFont : IResourceInterface
    {
        Humidifier.MediaLive.ChannelTypes.InputLocation Font { get; set; }
    }

    public interface IHaveShadowYOffset : IResourceInterface
    {
        dynamic ShadowYOffset { get; set; }
    }

    public interface IHaveXPosition : IResourceInterface
    {
        dynamic XPosition { get; set; }
    }

    public interface IHaveYPosition : IResourceInterface
    {
        dynamic YPosition { get; set; }
    }

    public interface IHaveOutlineSize : IResourceInterface
    {
        dynamic OutlineSize { get; set; }
    }

    public interface IHaveTeletextGridControl : IResourceInterface
    {
        dynamic TeletextGridControl { get; set; }
    }

    public interface IHaveFontOpacity : IResourceInterface
    {
        dynamic FontOpacity { get; set; }
    }

    public interface IHaveShadowXOffset : IResourceInterface
    {
        dynamic ShadowXOffset { get; set; }
    }

    public interface IHaveLanguageDescription : IResourceInterface
    {
        dynamic LanguageDescription { get; set; }
    }

    public interface IHaveSegmentLength : IResourceInterface
    {
        dynamic SegmentLength { get; set; }
    }

    public interface IHaveSendDelayMs : IResourceInterface
    {
        dynamic SendDelayMs { get; set; }
    }

    public interface IHaveOcrLanguage : IResourceInterface
    {
        dynamic OcrLanguage { get; set; }
    }

    public interface IHaveDrcRf : IResourceInterface
    {
        dynamic DrcRf { get; set; }
    }

    public interface IHaveDrcLine : IResourceInterface
    {
        dynamic DrcLine { get; set; }
    }

    public interface IHaveFontFamily : IResourceInterface
    {
        dynamic FontFamily { get; set; }
    }

    public interface IHaveSource608ChannelNumber : IResourceInterface
    {
        dynamic Source608ChannelNumber { get; set; }
    }

    public interface IHaveConvert608To708 : IResourceInterface
    {
        dynamic Convert608To708 { get; set; }
    }

    public interface IHaveAcquisitionPointId : IResourceInterface
    {
        dynamic AcquisitionPointId { get; set; }
    }

    public interface IHaveAudioRenditionSets : IResourceInterface
    {
        dynamic AudioRenditionSets { get; set; }
    }

    public interface IHaveMediaLiveChannelTypesBandwidthReductionFilterSettingsBandwidthReductionFilterSettings : IResourceInterface
    {
        Humidifier.MediaLive.ChannelTypes.BandwidthReductionFilterSettings BandwidthReductionFilterSettings { get; set; }
    }

    public interface IHaveSlices : IResourceInterface
    {
        dynamic Slices { get; set; }
    }

    public interface IHaveFlickerAq : IResourceInterface
    {
        dynamic FlickerAq { get; set; }
    }

    public interface IHaveMinQp : IResourceInterface
    {
        dynamic MinQp { get; set; }
    }

    public interface IHaveSubgopLength : IResourceInterface
    {
        dynamic SubgopLength { get; set; }
    }

    public interface IHaveGopNumBFrames : IResourceInterface
    {
        dynamic GopNumBFrames { get; set; }
    }

    public interface IHaveHttpTransferMode : IResourceInterface
    {
        dynamic HttpTransferMode { get; set; }
    }

    public interface IHaveSegmentationMode : IResourceInterface
    {
        dynamic SegmentationMode { get; set; }
    }

    public interface IHaveTimedMetadataId3Frame : IResourceInterface
    {
        dynamic TimedMetadataId3Frame { get; set; }
    }

    public interface IHaveTimedMetadataId3Period : IResourceInterface
    {
        dynamic TimedMetadataId3Period { get; set; }
    }

    public interface IHaveH265PackagingType : IResourceInterface
    {
        dynamic H265PackagingType { get; set; }
    }

    public interface IHaveMaximumBitrate : IResourceInterface
    {
        dynamic MaximumBitrate { get; set; }
    }

    public interface IHaveEtvPlatformPid : IResourceInterface
    {
        dynamic EtvPlatformPid { get; set; }
    }

    public interface IHavePatInterval : IResourceInterface
    {
        dynamic PatInterval { get; set; }
    }

    public interface IHaveProgramNum : IResourceInterface
    {
        dynamic ProgramNum { get; set; }
    }

    public interface IHaveKlvDataPids : IResourceInterface
    {
        dynamic KlvDataPids { get; set; }
    }

    public interface IHavePmtInterval : IResourceInterface
    {
        dynamic PmtInterval { get; set; }
    }

    public interface IHaveEsRateInPes : IResourceInterface
    {
        dynamic EsRateInPes { get; set; }
    }

    public interface IHaveAudioStreamType : IResourceInterface
    {
        dynamic AudioStreamType { get; set; }
    }

    public interface IHaveKlv : IResourceInterface
    {
        dynamic Klv { get; set; }
    }

    public interface IHaveScte35PrerollPullupMilliseconds : IResourceInterface
    {
        dynamic Scte35PrerollPullupMilliseconds { get; set; }
    }

    public interface IHaveDvbTeletextPid : IResourceInterface
    {
        dynamic DvbTeletextPid { get; set; }
    }

    public interface IHaveScte35Control : IResourceInterface
    {
        dynamic Scte35Control { get; set; }
    }

    public interface IHaveCcDescriptor : IResourceInterface
    {
        dynamic CcDescriptor { get; set; }
    }

    public interface IHaveAbsentInputAudioBehavior : IResourceInterface
    {
        dynamic AbsentInputAudioBehavior { get; set; }
    }

    public interface IHaveEtvSignalPid : IResourceInterface
    {
        dynamic EtvSignalPid { get; set; }
    }

    public interface IHaveArib : IResourceInterface
    {
        dynamic Arib { get; set; }
    }

    public interface IHaveEcmPid : IResourceInterface
    {
        dynamic EcmPid { get; set; }
    }

    public interface IHaveAudioPids : IResourceInterface
    {
        dynamic AudioPids { get; set; }
    }

    public interface IHaveAudioBufferModel : IResourceInterface
    {
        dynamic AudioBufferModel { get; set; }
    }

    public interface IHaveEbif : IResourceInterface
    {
        dynamic Ebif { get; set; }
    }

    public interface IHaveMaintenanceStartTime : IResourceInterface
    {
        dynamic MaintenanceStartTime { get; set; }
    }

    public interface IHaveColorSpace : IResourceInterface
    {
        dynamic ColorSpace { get; set; }
    }

    public interface IHaveWebDeliveryAllowedFlag : IResourceInterface
    {
        dynamic WebDeliveryAllowedFlag { get; set; }
    }

    public interface IHaveNoRegionalBlackoutFlag : IResourceInterface
    {
        dynamic NoRegionalBlackoutFlag { get; set; }
    }

    public interface IHaveMediaLiveChannelTypesUdpContainerSettingsContainerSettings : IResourceInterface
    {
        Humidifier.MediaLive.ChannelTypes.UdpContainerSettings ContainerSettings { get; set; }
    }

    public interface IHaveBufferMsec : IResourceInterface
    {
        dynamic BufferMsec { get; set; }
    }

    public interface IHaveGateway : IResourceInterface
    {
        dynamic Gateway { get; set; }
    }

    public interface IHaveDetailsUri : IResourceInterface
    {
        dynamic DetailsUri { get; set; }
    }

    public interface IHaveErrorMessage : IResourceInterface
    {
        dynamic ErrorMessage { get; set; }
    }

    public interface IHaveSecretsRoleArn : IResourceInterface
    {
        dynamic SecretsRoleArn { get; set; }
    }

    public interface IHaveCdnIdentifierSecret : IResourceInterface
    {
        dynamic CdnIdentifierSecret { get; set; }
    }

    public interface IHaveManifestLayout : IResourceInterface
    {
        dynamic ManifestLayout { get; set; }
    }

    public interface IHaveRepeatExtXKey : IResourceInterface
    {
        dynamic RepeatExtXKey { get; set; }
    }

    public interface IHavePlaylistWindowSeconds : IResourceInterface
    {
        dynamic PlaylistWindowSeconds { get; set; }
    }

    public interface IHavePlaylistType : IResourceInterface
    {
        dynamic PlaylistType { get; set; }
    }

    public interface IHaveUseAudioRenditionGroup : IResourceInterface
    {
        dynamic UseAudioRenditionGroup { get; set; }
    }

    public interface IHaveIncludeDvbSubtitles : IResourceInterface
    {
        dynamic IncludeDvbSubtitles { get; set; }
    }

    public interface IHaveSystemIds : IResourceInterface
    {
        dynamic SystemIds { get; set; }
    }

    public interface IHaveMinVideoBitsPerSecond : IResourceInterface
    {
        dynamic MinVideoBitsPerSecond { get; set; }
    }

    public interface IHaveStreamOrder : IResourceInterface
    {
        dynamic StreamOrder { get; set; }
    }

    public interface IHaveMaxVideoBitsPerSecond : IResourceInterface
    {
        dynamic MaxVideoBitsPerSecond { get; set; }
    }

    public interface IHaveListOfMediaPackagePackagingConfigurationTypesHlsManifestHlsManifests : IResourceInterface
    {
        List<Humidifier.MediaPackage.PackagingConfigurationTypes.HlsManifest> HlsManifests { get; set; }
    }

    public interface IHaveIncludeEncoderConfigurationInSegments : IResourceInterface
    {
        dynamic IncludeEncoderConfigurationInSegments { get; set; }
    }

    public interface IHavePresetSpeke20Audio : IResourceInterface
    {
        dynamic PresetSpeke20Audio { get; set; }
    }

    public interface IHavePresetSpeke20Video : IResourceInterface
    {
        dynamic PresetSpeke20Video { get; set; }
    }

    public interface IHaveChildManifestName : IResourceInterface
    {
        dynamic ChildManifestName { get; set; }
    }

    public interface IHaveMediaPackageV2OriginEndpointTypesScteHlsScteHls : IResourceInterface
    {
        Humidifier.MediaPackageV2.OriginEndpointTypes.ScteHls ScteHls { get; set; }
    }

    public interface IHaveMediaPackageV2OriginEndpointTypesStartTagStartTag : IResourceInterface
    {
        Humidifier.MediaPackageV2.OriginEndpointTypes.StartTag StartTag { get; set; }
    }

    public interface IHaveAllowedHeaders : IResourceInterface
    {
        dynamic AllowedHeaders { get; set; }
    }

    public interface IHaveManifestEndpointPrefix : IResourceInterface
    {
        dynamic ManifestEndpointPrefix { get; set; }
    }

    public interface IHaveAddressDefinition : IResourceInterface
    {
        dynamic AddressDefinition { get; set; }
    }

    public interface IHaveIntegerListOfProtocols : IResourceInterface
    {
        List<int> Protocols { get; set; }
    }

    public interface IHavePeerAsn : IResourceInterface
    {
        dynamic PeerAsn { get; set; }
    }

    public interface IHaveScript : IResourceInterface
    {
        dynamic Script { get; set; }
    }

    public interface IHaveGroupAttribute : IResourceInterface
    {
        dynamic GroupAttribute { get; set; }
    }

    public interface IHaveSshKey : IResourceInterface
    {
        dynamic SshKey { get; set; }
    }

    public interface IHaveDecrypt : IResourceInterface
    {
        dynamic Decrypt { get; set; }
    }

    public interface IHaveSign : IResourceInterface
    {
        dynamic Sign { get; set; }
    }

    public interface IHavePCAConnectorADTemplateTypesKeyUsagePropertyKeyUsageProperty : IResourceInterface
    {
        Humidifier.PCAConnectorAD.TemplateTypes.KeyUsageProperty KeyUsageProperty { get; set; }
    }

    public interface IHaveRequireAlternateSignatureAlgorithm : IResourceInterface
    {
        dynamic RequireAlternateSignatureAlgorithm { get; set; }
    }

    public interface IHaveHashAlgorithm : IResourceInterface
    {
        dynamic HashAlgorithm { get; set; }
    }

    public interface IHaveMaxInstanceCount : IResourceInterface
    {
        dynamic MaxInstanceCount { get; set; }
    }

    public interface IHaveMinInstanceCount : IResourceInterface
    {
        dynamic MinInstanceCount { get; set; }
    }

    public interface IHavePayloadData : IResourceInterface
    {
        dynamic PayloadData { get; set; }
    }

    public interface IHaveDatasetArn : IResourceInterface
    {
        dynamic DatasetArn { get; set; }
    }

    public interface IHaveWebUrl : IResourceInterface
    {
        dynamic WebUrl { get; set; }
    }

    public interface IHaveLambdaFunctionName : IResourceInterface
    {
        dynamic LambdaFunctionName { get; set; }
    }

    public interface IHaveDaily : IResourceInterface
    {
        dynamic Daily { get; set; }
    }

    public interface IHaveTotal : IResourceInterface
    {
        dynamic Total { get; set; }
    }

    public interface IHaveMessagesPerSecond : IResourceInterface
    {
        dynamic MessagesPerSecond { get; set; }
    }

    public interface IHaveBorderRadius : IResourceInterface
    {
        dynamic BorderRadius { get; set; }
    }

    public interface IHaveMediaUrl : IResourceInterface
    {
        dynamic MediaUrl { get; set; }
    }

    public interface IHaveImageIconUrl : IResourceInterface
    {
        dynamic ImageIconUrl { get; set; }
    }

    public interface IHaveSendingPoolName : IResourceInterface
    {
        dynamic SendingPoolName { get; set; }
    }

    public interface IHaveReputationMetricsEnabled : IResourceInterface
    {
        dynamic ReputationMetricsEnabled { get; set; }
    }

    public interface IHaveSendingEnabled : IResourceInterface
    {
        dynamic SendingEnabled { get; set; }
    }

    public interface IHaveCustomRedirectDomain : IResourceInterface
    {
        dynamic CustomRedirectDomain { get; set; }
    }

    public interface IHaveDimensionValueSource : IResourceInterface
    {
        dynamic DimensionValueSource { get; set; }
    }

    public interface IHaveDefaultDimensionValue : IResourceInterface
    {
        dynamic DefaultDimensionValue { get; set; }
    }

    public interface IHaveMatchingEventTypes : IResourceInterface
    {
        dynamic MatchingEventTypes { get; set; }
    }

    public interface IHaveDeliveryStreamArn : IResourceInterface
    {
        dynamic DeliveryStreamArn { get; set; }
    }

    public interface IHaveMailFromDomain : IResourceInterface
    {
        dynamic MailFromDomain { get; set; }
    }

    public interface IHaveBehaviorOnMxFailure : IResourceInterface
    {
        dynamic BehaviorOnMxFailure { get; set; }
    }

    public interface IHaveDimensionValueType : IResourceInterface
    {
        dynamic DimensionValueType { get; set; }
    }

    public interface IHaveBasicAuth : IResourceInterface
    {
        dynamic BasicAuth { get; set; }
    }

    public interface IHaveClientCertificateTlsAuth : IResourceInterface
    {
        dynamic ClientCertificateTlsAuth { get; set; }
    }

    public interface IHaveSaslScram512Auth : IResourceInterface
    {
        dynamic SaslScram512Auth { get; set; }
    }

    public interface IHaveMeasureValue : IResourceInterface
    {
        dynamic MeasureValue { get; set; }
    }

    public interface IHaveIncludeExecutionData : IResourceInterface
    {
        dynamic IncludeExecutionData { get; set; }
    }

    public interface IHavePipesPipeTypesMQBrokerAccessCredentialsCredentials : IResourceInterface
    {
        Humidifier.Pipes.PipeTypes.MQBrokerAccessCredentials Credentials { get; set; }
    }

    public interface IHaveOnPartialBatchItemFailure : IResourceInterface
    {
        dynamic OnPartialBatchItemFailure { get; set; }
    }

    public interface IHavePipesPipeTypesDeadLetterConfigDeadLetterConfig : IResourceInterface
    {
        Humidifier.Pipes.PipeTypes.DeadLetterConfig DeadLetterConfig { get; set; }
    }

    public interface IHaveConsumerGroupID : IResourceInterface
    {
        dynamic ConsumerGroupID { get; set; }
    }

    public interface IHaveMeasureName : IResourceInterface
    {
        dynamic MeasureName { get; set; }
    }

    public interface IHaveQBusinessDataSourceTypesDocumentAttributeValueValue : IResourceInterface
    {
        Humidifier.QBusiness.DataSourceTypes.DocumentAttributeValue Value { get; set; }
    }

    public interface IHaveQuickSightAnalysisTypesSectionStyleStyle : IResourceInterface
    {
        Humidifier.QuickSight.AnalysisTypes.SectionStyle Style { get; set; }
    }

    public interface IHaveQuickSightAnalysisTypesSectionLayoutConfigurationLayout : IResourceInterface
    {
        Humidifier.QuickSight.AnalysisTypes.SectionLayoutConfiguration Layout { get; set; }
    }

    public interface IHaveQuickSightAnalysisTypesPaginationConfigurationPaginationConfiguration : IResourceInterface
    {
        Humidifier.QuickSight.AnalysisTypes.PaginationConfiguration PaginationConfiguration { get; set; }
    }

    public interface IHaveQuickSightAnalysisTypesStringFormatConfigurationFormatConfiguration : IResourceInterface
    {
        Humidifier.QuickSight.AnalysisTypes.StringFormatConfiguration FormatConfiguration { get; set; }
    }

    public interface IHaveQuickSightAnalysisTypesCategoryFilterConfigurationConfiguration : IResourceInterface
    {
        Humidifier.QuickSight.AnalysisTypes.CategoryFilterConfiguration Configuration { get; set; }
    }

    public interface IHaveQuickSightAnalysisTypesFormatConfigurationFormatConfiguration : IResourceInterface
    {
        Humidifier.QuickSight.AnalysisTypes.FormatConfiguration FormatConfiguration { get; set; }
    }

    public interface IHaveQuickSightAnalysisTypesSingleAxisOptionsSingleAxisOptions : IResourceInterface
    {
        Humidifier.QuickSight.AnalysisTypes.SingleAxisOptions SingleAxisOptions { get; set; }
    }

    public interface IHaveQuickSightAnalysisTypesChartAxisLabelOptionsSecondaryYAxisLabelOptions : IResourceInterface
    {
        Humidifier.QuickSight.AnalysisTypes.ChartAxisLabelOptions SecondaryYAxisLabelOptions { get; set; }
    }

    public interface IHaveQuickSightAnalysisTypesNumberDisplayFormatConfigurationNumberDisplayFormatConfiguration : IResourceInterface
    {
        Humidifier.QuickSight.AnalysisTypes.NumberDisplayFormatConfiguration NumberDisplayFormatConfiguration { get; set; }
    }

    public interface IHaveQuickSightAnalysisTypesPercentageDisplayFormatConfigurationPercentageDisplayFormatConfiguration : IResourceInterface
    {
        Humidifier.QuickSight.AnalysisTypes.PercentageDisplayFormatConfiguration PercentageDisplayFormatConfiguration { get; set; }
    }

    public interface IHaveQuickSightAnalysisTypesLineChartSeriesSettingsSettings : IResourceInterface
    {
        Humidifier.QuickSight.AnalysisTypes.LineChartSeriesSettings Settings { get; set; }
    }

    public interface IHaveQuickSightAnalysisTypesFontConfigurationLabelFontConfiguration : IResourceInterface
    {
        Humidifier.QuickSight.AnalysisTypes.FontConfiguration LabelFontConfiguration { get; set; }
    }

    public interface IHaveQuickSightAnalysisTypesDateTimeFormatConfigurationFormatConfiguration : IResourceInterface
    {
        Humidifier.QuickSight.AnalysisTypes.DateTimeFormatConfiguration FormatConfiguration { get; set; }
    }

    public interface IHaveQuickSightAnalysisTypesNumericFormatConfigurationNumericFormatConfiguration : IResourceInterface
    {
        Humidifier.QuickSight.AnalysisTypes.NumericFormatConfiguration NumericFormatConfiguration { get; set; }
    }

    public interface IHaveQuickSightAnalysisTypesFreeFormLayoutCanvasSizeOptionsCanvasSizeOptions : IResourceInterface
    {
        Humidifier.QuickSight.AnalysisTypes.FreeFormLayoutCanvasSizeOptions CanvasSizeOptions { get; set; }
    }

    public interface IHaveQuickSightAnalysisTypesGridLayoutCanvasSizeOptionsCanvasSizeOptions : IResourceInterface
    {
        Humidifier.QuickSight.AnalysisTypes.GridLayoutCanvasSizeOptions CanvasSizeOptions { get; set; }
    }

    public interface IHaveQuickSightAnalysisTypesRelativeDateTimeControlDisplayOptionsDisplayOptions : IResourceInterface
    {
        Humidifier.QuickSight.AnalysisTypes.RelativeDateTimeControlDisplayOptions DisplayOptions { get; set; }
    }

    public interface IHaveQuickSightAnalysisTypesSectionBasedLayoutCanvasSizeOptionsCanvasSizeOptions : IResourceInterface
    {
        Humidifier.QuickSight.AnalysisTypes.SectionBasedLayoutCanvasSizeOptions CanvasSizeOptions { get; set; }
    }

    public interface IHaveQuickSightAnalysisTypesListControlSelectAllOptionsSelectAllOptions : IResourceInterface
    {
        Humidifier.QuickSight.AnalysisTypes.ListControlSelectAllOptions SelectAllOptions { get; set; }
    }

    public interface IHaveListOfQuickSightAnalysisTypesColumnIdentifierColumns : IResourceInterface
    {
        List<Humidifier.QuickSight.AnalysisTypes.ColumnIdentifier> Columns { get; set; }
    }

    public interface IHaveListOfQuickSightAnalysisTypesDimensionFieldGeospatial : IResourceInterface
    {
        List<Humidifier.QuickSight.AnalysisTypes.DimensionField> Geospatial { get; set; }
    }

    public interface IHaveQuickSightAnalysisTypesGeospatialMapStyleOptionsMapStyleOptions : IResourceInterface
    {
        Humidifier.QuickSight.AnalysisTypes.GeospatialMapStyleOptions MapStyleOptions { get; set; }
    }

    public interface IHaveQuickSightAnalysisTypesGeospatialWindowOptionsWindowOptions : IResourceInterface
    {
        Humidifier.QuickSight.AnalysisTypes.GeospatialWindowOptions WindowOptions { get; set; }
    }

    public interface IHaveAbsolute : IResourceInterface
    {
        dynamic Absolute { get; set; }
    }

    public interface IHaveListOfQuickSightAnalysisTypesFreeFormLayoutElementElements : IResourceInterface
    {
        List<Humidifier.QuickSight.AnalysisTypes.FreeFormLayoutElement> Elements { get; set; }
    }

    public interface IHaveQuickSightAnalysisTypesConditionalFormattingColorForegroundColor : IResourceInterface
    {
        Humidifier.QuickSight.AnalysisTypes.ConditionalFormattingColor ForegroundColor { get; set; }
    }

    public interface IHaveListOfQuickSightAnalysisTypesMeasureFieldTargetValues : IResourceInterface
    {
        List<Humidifier.QuickSight.AnalysisTypes.MeasureField> TargetValues { get; set; }
    }

    public interface IHaveQuickSightAnalysisTypesComparisonConfigurationComparison : IResourceInterface
    {
        Humidifier.QuickSight.AnalysisTypes.ComparisonConfiguration Comparison { get; set; }
    }

    public interface IHaveQuickSightAnalysisTypesFontConfigurationPrimaryValueFontConfiguration : IResourceInterface
    {
        Humidifier.QuickSight.AnalysisTypes.FontConfiguration PrimaryValueFontConfiguration { get; set; }
    }

    public interface IHaveQuickSightAnalysisTypesGeospatialNullDataSettingsNullDataSettings : IResourceInterface
    {
        Humidifier.QuickSight.AnalysisTypes.GeospatialNullDataSettings NullDataSettings { get; set; }
    }

    public interface IHaveRadius : IResourceInterface
    {
        dynamic Radius { get; set; }
    }

    public interface IHaveQuickSightAnalysisTypesGeospatialLineWidthStrokeWidth : IResourceInterface
    {
        Humidifier.QuickSight.AnalysisTypes.GeospatialLineWidth StrokeWidth { get; set; }
    }

    public interface IHaveQuickSightAnalysisTypesGeospatialColorStrokeColor : IResourceInterface
    {
        Humidifier.QuickSight.AnalysisTypes.GeospatialColor StrokeColor { get; set; }
    }

    public interface IHaveLayerType : IResourceInterface
    {
        dynamic LayerType { get; set; }
    }

    public interface IHaveShapeKeyField : IResourceInterface
    {
        dynamic ShapeKeyField { get; set; }
    }

    public interface IHaveQuickSightAnalysisTypesGeospatialCoordinateBoundsBounds : IResourceInterface
    {
        Humidifier.QuickSight.AnalysisTypes.GeospatialCoordinateBounds Bounds { get; set; }
    }

    public interface IHaveMapNavigation : IResourceInterface
    {
        dynamic MapNavigation { get; set; }
    }

    public interface IHaveBaseMapVisibility : IResourceInterface
    {
        dynamic BaseMapVisibility { get; set; }
    }

    public interface IHaveFillColor : IResourceInterface
    {
        dynamic FillColor { get; set; }
    }

    public interface IHaveStrokeWidth : IResourceInterface
    {
        dynamic StrokeWidth { get; set; }
    }

    public interface IHaveStrokeColor : IResourceInterface
    {
        dynamic StrokeColor { get; set; }
    }

    public interface IHaveListOfQuickSightAnalysisTypesDimensionFieldColumns : IResourceInterface
    {
        List<Humidifier.QuickSight.AnalysisTypes.DimensionField> Columns { get; set; }
    }

    public interface IHaveListOfQuickSightAnalysisTypesDimensionFieldRows : IResourceInterface
    {
        List<Humidifier.QuickSight.AnalysisTypes.DimensionField> Rows { get; set; }
    }

    public interface IHaveQuickSightAnalysisTypesColorScaleColorScale : IResourceInterface
    {
        Humidifier.QuickSight.AnalysisTypes.ColorScale ColorScale { get; set; }
    }

    public interface IHaveQuickSightAnalysisTypesAxisDisplayOptionsYAxisDisplayOptions : IResourceInterface
    {
        Humidifier.QuickSight.AnalysisTypes.AxisDisplayOptions YAxisDisplayOptions { get; set; }
    }

    public interface IHaveQuickSightAnalysisTypesStaticFileSourceSource : IResourceInterface
    {
        Humidifier.QuickSight.AnalysisTypes.StaticFileSource Source { get; set; }
    }

    public interface IHaveQuickSightAnalysisTypesCustomActionFilterOperationFilterOperation : IResourceInterface
    {
        Humidifier.QuickSight.AnalysisTypes.CustomActionFilterOperation FilterOperation { get; set; }
    }

    public interface IHaveQuickSightAnalysisTypesGridLayoutConfigurationGridLayout : IResourceInterface
    {
        Humidifier.QuickSight.AnalysisTypes.GridLayoutConfiguration GridLayout { get; set; }
    }

    public interface IHaveQuickSightAnalysisTypesLineChartLineStyleSettingsLineStyleSettings : IResourceInterface
    {
        Humidifier.QuickSight.AnalysisTypes.LineChartLineStyleSettings LineStyleSettings { get; set; }
    }

    public interface IHaveQuickSightAnalysisTypesLineChartMarkerStyleSettingsMarkerStyleSettings : IResourceInterface
    {
        Humidifier.QuickSight.AnalysisTypes.LineChartMarkerStyleSettings MarkerStyleSettings { get; set; }
    }

    public interface IHaveQuickSightAnalysisTypesNumericFormatConfigurationFormatConfiguration : IResourceInterface
    {
        Humidifier.QuickSight.AnalysisTypes.NumericFormatConfiguration FormatConfiguration { get; set; }
    }

    public interface IHaveQuickSightAnalysisTypesNumberFormatConfigurationFormatConfiguration : IResourceInterface
    {
        Humidifier.QuickSight.AnalysisTypes.NumberFormatConfiguration FormatConfiguration { get; set; }
    }

    public interface IHaveQuickSightAnalysisTypesParameterSelectableValuesSelectableValues : IResourceInterface
    {
        Humidifier.QuickSight.AnalysisTypes.ParameterSelectableValues SelectableValues { get; set; }
    }

    public interface IHaveQuickSightAnalysisTypesTextConditionalFormatTextFormat : IResourceInterface
    {
        Humidifier.QuickSight.AnalysisTypes.TextConditionalFormat TextFormat { get; set; }
    }

    public interface IHaveQuickSightAnalysisTypesTableCellStyleCellStyle : IResourceInterface
    {
        Humidifier.QuickSight.AnalysisTypes.TableCellStyle CellStyle { get; set; }
    }

    public interface IHaveQuickSightAnalysisTypesRowAlternateColorOptionsRowAlternateColorOptions : IResourceInterface
    {
        Humidifier.QuickSight.AnalysisTypes.RowAlternateColorOptions RowAlternateColorOptions { get; set; }
    }

    public interface IHaveListOfQuickSightAnalysisTypesTotalAggregationOptionTotalAggregationOptions : IResourceInterface
    {
        List<Humidifier.QuickSight.AnalysisTypes.TotalAggregationOption> TotalAggregationOptions { get; set; }
    }

    public interface IHaveQuickSightAnalysisTypesTableCellStyleValueCellStyle : IResourceInterface
    {
        Humidifier.QuickSight.AnalysisTypes.TableCellStyle ValueCellStyle { get; set; }
    }

    public interface IHaveQuickSightAnalysisTypesTableCellStyleMetricHeaderCellStyle : IResourceInterface
    {
        Humidifier.QuickSight.AnalysisTypes.TableCellStyle MetricHeaderCellStyle { get; set; }
    }

    public interface IHaveListOfQuickSightAnalysisTypesFieldSortOptionsRowSort : IResourceInterface
    {
        List<Humidifier.QuickSight.AnalysisTypes.FieldSortOptions> RowSort { get; set; }
    }

    public interface IHaveQueryExecutionMode : IResourceInterface
    {
        dynamic QueryExecutionMode { get; set; }
    }

    public interface IHaveQuickSightAnalysisTypesExcludePeriodConfigurationExcludePeriodConfiguration : IResourceInterface
    {
        Humidifier.QuickSight.AnalysisTypes.ExcludePeriodConfiguration ExcludePeriodConfiguration { get; set; }
    }

    public interface IHaveListOfQuickSightAnalysisTypesDimensionFieldLabel : IResourceInterface
    {
        List<Humidifier.QuickSight.AnalysisTypes.DimensionField> Label { get; set; }
    }

    public interface IHaveListOfQuickSightAnalysisTypesSheetImageImages : IResourceInterface
    {
        List<Humidifier.QuickSight.AnalysisTypes.SheetImage> Images { get; set; }
    }

    public interface IHaveQuickSightAnalysisTypesTextControlPlaceholderOptionsPlaceholderOptions : IResourceInterface
    {
        Humidifier.QuickSight.AnalysisTypes.TextControlPlaceholderOptions PlaceholderOptions { get; set; }
    }

    public interface IHaveQuickSightDashboardTypesSectionStyleStyle : IResourceInterface
    {
        Humidifier.QuickSight.DashboardTypes.SectionStyle Style { get; set; }
    }

    public interface IHaveQuickSightDashboardTypesSectionLayoutConfigurationLayout : IResourceInterface
    {
        Humidifier.QuickSight.DashboardTypes.SectionLayoutConfiguration Layout { get; set; }
    }

    public interface IHaveQuickSightDashboardTypesPaginationConfigurationPaginationConfiguration : IResourceInterface
    {
        Humidifier.QuickSight.DashboardTypes.PaginationConfiguration PaginationConfiguration { get; set; }
    }

    public interface IHaveQuickSightDashboardTypesStringFormatConfigurationFormatConfiguration : IResourceInterface
    {
        Humidifier.QuickSight.DashboardTypes.StringFormatConfiguration FormatConfiguration { get; set; }
    }

    public interface IHaveQuickSightDashboardTypesCategoryFilterConfigurationConfiguration : IResourceInterface
    {
        Humidifier.QuickSight.DashboardTypes.CategoryFilterConfiguration Configuration { get; set; }
    }

    public interface IHaveQuickSightDashboardTypesFormatConfigurationFormatConfiguration : IResourceInterface
    {
        Humidifier.QuickSight.DashboardTypes.FormatConfiguration FormatConfiguration { get; set; }
    }

    public interface IHaveQuickSightDashboardTypesSingleAxisOptionsSingleAxisOptions : IResourceInterface
    {
        Humidifier.QuickSight.DashboardTypes.SingleAxisOptions SingleAxisOptions { get; set; }
    }

    public interface IHaveQuickSightDashboardTypesChartAxisLabelOptionsSecondaryYAxisLabelOptions : IResourceInterface
    {
        Humidifier.QuickSight.DashboardTypes.ChartAxisLabelOptions SecondaryYAxisLabelOptions { get; set; }
    }

    public interface IHaveQuickSightDashboardTypesNumberDisplayFormatConfigurationNumberDisplayFormatConfiguration : IResourceInterface
    {
        Humidifier.QuickSight.DashboardTypes.NumberDisplayFormatConfiguration NumberDisplayFormatConfiguration { get; set; }
    }

    public interface IHaveQuickSightDashboardTypesPercentageDisplayFormatConfigurationPercentageDisplayFormatConfiguration : IResourceInterface
    {
        Humidifier.QuickSight.DashboardTypes.PercentageDisplayFormatConfiguration PercentageDisplayFormatConfiguration { get; set; }
    }

    public interface IHaveSourceEntityArn : IResourceInterface
    {
        dynamic SourceEntityArn { get; set; }
    }

    public interface IHaveQuickSightDashboardTypesLineChartSeriesSettingsSettings : IResourceInterface
    {
        Humidifier.QuickSight.DashboardTypes.LineChartSeriesSettings Settings { get; set; }
    }

    public interface IHaveQuickSightDashboardTypesFontConfigurationLabelFontConfiguration : IResourceInterface
    {
        Humidifier.QuickSight.DashboardTypes.FontConfiguration LabelFontConfiguration { get; set; }
    }

    public interface IHaveQuickSightDashboardTypesDateTimeFormatConfigurationFormatConfiguration : IResourceInterface
    {
        Humidifier.QuickSight.DashboardTypes.DateTimeFormatConfiguration FormatConfiguration { get; set; }
    }

    public interface IHaveQuickSightDashboardTypesNumericFormatConfigurationNumericFormatConfiguration : IResourceInterface
    {
        Humidifier.QuickSight.DashboardTypes.NumericFormatConfiguration NumericFormatConfiguration { get; set; }
    }

    public interface IHaveQuickSightDashboardTypesFreeFormLayoutCanvasSizeOptionsCanvasSizeOptions : IResourceInterface
    {
        Humidifier.QuickSight.DashboardTypes.FreeFormLayoutCanvasSizeOptions CanvasSizeOptions { get; set; }
    }

    public interface IHaveQuickSightDashboardTypesGridLayoutCanvasSizeOptionsCanvasSizeOptions : IResourceInterface
    {
        Humidifier.QuickSight.DashboardTypes.GridLayoutCanvasSizeOptions CanvasSizeOptions { get; set; }
    }

    public interface IHaveQuickSightDashboardTypesRelativeDateTimeControlDisplayOptionsDisplayOptions : IResourceInterface
    {
        Humidifier.QuickSight.DashboardTypes.RelativeDateTimeControlDisplayOptions DisplayOptions { get; set; }
    }

    public interface IHaveQuickSightDashboardTypesSectionBasedLayoutCanvasSizeOptionsCanvasSizeOptions : IResourceInterface
    {
        Humidifier.QuickSight.DashboardTypes.SectionBasedLayoutCanvasSizeOptions CanvasSizeOptions { get; set; }
    }

    public interface IHaveQuickSightDashboardTypesListControlSelectAllOptionsSelectAllOptions : IResourceInterface
    {
        Humidifier.QuickSight.DashboardTypes.ListControlSelectAllOptions SelectAllOptions { get; set; }
    }

    public interface IHaveListOfQuickSightDashboardTypesColumnIdentifierColumns : IResourceInterface
    {
        List<Humidifier.QuickSight.DashboardTypes.ColumnIdentifier> Columns { get; set; }
    }

    public interface IHaveListOfQuickSightDashboardTypesDimensionFieldGeospatial : IResourceInterface
    {
        List<Humidifier.QuickSight.DashboardTypes.DimensionField> Geospatial { get; set; }
    }

    public interface IHaveQuickSightDashboardTypesGeospatialMapStyleOptionsMapStyleOptions : IResourceInterface
    {
        Humidifier.QuickSight.DashboardTypes.GeospatialMapStyleOptions MapStyleOptions { get; set; }
    }

    public interface IHaveQuickSightDashboardTypesGeospatialWindowOptionsWindowOptions : IResourceInterface
    {
        Humidifier.QuickSight.DashboardTypes.GeospatialWindowOptions WindowOptions { get; set; }
    }

    public interface IHaveListOfQuickSightDashboardTypesFreeFormLayoutElementElements : IResourceInterface
    {
        List<Humidifier.QuickSight.DashboardTypes.FreeFormLayoutElement> Elements { get; set; }
    }

    public interface IHaveQuickSightDashboardTypesConditionalFormattingColorForegroundColor : IResourceInterface
    {
        Humidifier.QuickSight.DashboardTypes.ConditionalFormattingColor ForegroundColor { get; set; }
    }

    public interface IHaveListOfQuickSightDashboardTypesMeasureFieldTargetValues : IResourceInterface
    {
        List<Humidifier.QuickSight.DashboardTypes.MeasureField> TargetValues { get; set; }
    }

    public interface IHaveQuickSightDashboardTypesComparisonConfigurationComparison : IResourceInterface
    {
        Humidifier.QuickSight.DashboardTypes.ComparisonConfiguration Comparison { get; set; }
    }

    public interface IHaveQuickSightDashboardTypesFontConfigurationPrimaryValueFontConfiguration : IResourceInterface
    {
        Humidifier.QuickSight.DashboardTypes.FontConfiguration PrimaryValueFontConfiguration { get; set; }
    }

    public interface IHaveQuickSightDashboardTypesGeospatialNullDataSettingsNullDataSettings : IResourceInterface
    {
        Humidifier.QuickSight.DashboardTypes.GeospatialNullDataSettings NullDataSettings { get; set; }
    }

    public interface IHaveQuickSightDashboardTypesGeospatialLineWidthStrokeWidth : IResourceInterface
    {
        Humidifier.QuickSight.DashboardTypes.GeospatialLineWidth StrokeWidth { get; set; }
    }

    public interface IHaveQuickSightDashboardTypesGeospatialColorStrokeColor : IResourceInterface
    {
        Humidifier.QuickSight.DashboardTypes.GeospatialColor StrokeColor { get; set; }
    }

    public interface IHaveQuickSightDashboardTypesGeospatialCoordinateBoundsBounds : IResourceInterface
    {
        Humidifier.QuickSight.DashboardTypes.GeospatialCoordinateBounds Bounds { get; set; }
    }

    public interface IHaveListOfQuickSightDashboardTypesDimensionFieldColumns : IResourceInterface
    {
        List<Humidifier.QuickSight.DashboardTypes.DimensionField> Columns { get; set; }
    }

    public interface IHaveListOfQuickSightDashboardTypesDimensionFieldRows : IResourceInterface
    {
        List<Humidifier.QuickSight.DashboardTypes.DimensionField> Rows { get; set; }
    }

    public interface IHaveQuickSightDashboardTypesColorScaleColorScale : IResourceInterface
    {
        Humidifier.QuickSight.DashboardTypes.ColorScale ColorScale { get; set; }
    }

    public interface IHaveQuickSightDashboardTypesAxisDisplayOptionsYAxisDisplayOptions : IResourceInterface
    {
        Humidifier.QuickSight.DashboardTypes.AxisDisplayOptions YAxisDisplayOptions { get; set; }
    }

    public interface IHaveQuickSightDashboardTypesStaticFileSourceSource : IResourceInterface
    {
        Humidifier.QuickSight.DashboardTypes.StaticFileSource Source { get; set; }
    }

    public interface IHaveQuickSightDashboardTypesCustomActionFilterOperationFilterOperation : IResourceInterface
    {
        Humidifier.QuickSight.DashboardTypes.CustomActionFilterOperation FilterOperation { get; set; }
    }

    public interface IHaveQuickSightDashboardTypesGridLayoutConfigurationGridLayout : IResourceInterface
    {
        Humidifier.QuickSight.DashboardTypes.GridLayoutConfiguration GridLayout { get; set; }
    }

    public interface IHaveQuickSightDashboardTypesLineChartLineStyleSettingsLineStyleSettings : IResourceInterface
    {
        Humidifier.QuickSight.DashboardTypes.LineChartLineStyleSettings LineStyleSettings { get; set; }
    }

    public interface IHaveQuickSightDashboardTypesLineChartMarkerStyleSettingsMarkerStyleSettings : IResourceInterface
    {
        Humidifier.QuickSight.DashboardTypes.LineChartMarkerStyleSettings MarkerStyleSettings { get; set; }
    }

    public interface IHaveQuickSightDashboardTypesNumericFormatConfigurationFormatConfiguration : IResourceInterface
    {
        Humidifier.QuickSight.DashboardTypes.NumericFormatConfiguration FormatConfiguration { get; set; }
    }

    public interface IHaveQuickSightDashboardTypesNumberFormatConfigurationFormatConfiguration : IResourceInterface
    {
        Humidifier.QuickSight.DashboardTypes.NumberFormatConfiguration FormatConfiguration { get; set; }
    }

    public interface IHaveQuickSightDashboardTypesParameterSelectableValuesSelectableValues : IResourceInterface
    {
        Humidifier.QuickSight.DashboardTypes.ParameterSelectableValues SelectableValues { get; set; }
    }

    public interface IHaveQuickSightDashboardTypesTextConditionalFormatTextFormat : IResourceInterface
    {
        Humidifier.QuickSight.DashboardTypes.TextConditionalFormat TextFormat { get; set; }
    }

    public interface IHaveQuickSightDashboardTypesTableCellStyleCellStyle : IResourceInterface
    {
        Humidifier.QuickSight.DashboardTypes.TableCellStyle CellStyle { get; set; }
    }

    public interface IHaveQuickSightDashboardTypesRowAlternateColorOptionsRowAlternateColorOptions : IResourceInterface
    {
        Humidifier.QuickSight.DashboardTypes.RowAlternateColorOptions RowAlternateColorOptions { get; set; }
    }

    public interface IHaveListOfQuickSightDashboardTypesTotalAggregationOptionTotalAggregationOptions : IResourceInterface
    {
        List<Humidifier.QuickSight.DashboardTypes.TotalAggregationOption> TotalAggregationOptions { get; set; }
    }

    public interface IHaveQuickSightDashboardTypesTableCellStyleValueCellStyle : IResourceInterface
    {
        Humidifier.QuickSight.DashboardTypes.TableCellStyle ValueCellStyle { get; set; }
    }

    public interface IHaveQuickSightDashboardTypesTableCellStyleMetricHeaderCellStyle : IResourceInterface
    {
        Humidifier.QuickSight.DashboardTypes.TableCellStyle MetricHeaderCellStyle { get; set; }
    }

    public interface IHaveListOfQuickSightDashboardTypesFieldSortOptionsRowSort : IResourceInterface
    {
        List<Humidifier.QuickSight.DashboardTypes.FieldSortOptions> RowSort { get; set; }
    }

    public interface IHaveQuickSightDashboardTypesExcludePeriodConfigurationExcludePeriodConfiguration : IResourceInterface
    {
        Humidifier.QuickSight.DashboardTypes.ExcludePeriodConfiguration ExcludePeriodConfiguration { get; set; }
    }

    public interface IHaveListOfQuickSightDashboardTypesDimensionFieldLabel : IResourceInterface
    {
        List<Humidifier.QuickSight.DashboardTypes.DimensionField> Label { get; set; }
    }

    public interface IHaveListOfQuickSightDashboardTypesSheetImageImages : IResourceInterface
    {
        List<Humidifier.QuickSight.DashboardTypes.SheetImage> Images { get; set; }
    }

    public interface IHaveQuickSightDashboardTypesTextControlPlaceholderOptionsPlaceholderOptions : IResourceInterface
    {
        Humidifier.QuickSight.DashboardTypes.TextControlPlaceholderOptions PlaceholderOptions { get; set; }
    }

    public interface IHaveListOfQuickSightDataSetTypesInputColumnInputColumns : IResourceInterface
    {
        List<Humidifier.QuickSight.DataSetTypes.InputColumn> InputColumns { get; set; }
    }

    public interface IHaveDatabaseAccessControlRole : IResourceInterface
    {
        dynamic DatabaseAccessControlRole { get; set; }
    }

    public interface IHaveQuickSightDataSourceTypesOAuthParametersOAuthParameters : IResourceInterface
    {
        Humidifier.QuickSight.DataSourceTypes.OAuthParameters OAuthParameters { get; set; }
    }

    public interface IHaveQuickSightTemplateTypesSectionStyleStyle : IResourceInterface
    {
        Humidifier.QuickSight.TemplateTypes.SectionStyle Style { get; set; }
    }

    public interface IHaveQuickSightTemplateTypesSectionLayoutConfigurationLayout : IResourceInterface
    {
        Humidifier.QuickSight.TemplateTypes.SectionLayoutConfiguration Layout { get; set; }
    }

    public interface IHaveQuickSightTemplateTypesPaginationConfigurationPaginationConfiguration : IResourceInterface
    {
        Humidifier.QuickSight.TemplateTypes.PaginationConfiguration PaginationConfiguration { get; set; }
    }

    public interface IHaveQuickSightTemplateTypesStringFormatConfigurationFormatConfiguration : IResourceInterface
    {
        Humidifier.QuickSight.TemplateTypes.StringFormatConfiguration FormatConfiguration { get; set; }
    }

    public interface IHaveQuickSightTemplateTypesCategoryFilterConfigurationConfiguration : IResourceInterface
    {
        Humidifier.QuickSight.TemplateTypes.CategoryFilterConfiguration Configuration { get; set; }
    }

    public interface IHaveQuickSightTemplateTypesFormatConfigurationFormatConfiguration : IResourceInterface
    {
        Humidifier.QuickSight.TemplateTypes.FormatConfiguration FormatConfiguration { get; set; }
    }

    public interface IHaveQuickSightTemplateTypesSingleAxisOptionsSingleAxisOptions : IResourceInterface
    {
        Humidifier.QuickSight.TemplateTypes.SingleAxisOptions SingleAxisOptions { get; set; }
    }

    public interface IHaveQuickSightTemplateTypesChartAxisLabelOptionsSecondaryYAxisLabelOptions : IResourceInterface
    {
        Humidifier.QuickSight.TemplateTypes.ChartAxisLabelOptions SecondaryYAxisLabelOptions { get; set; }
    }

    public interface IHaveQuickSightTemplateTypesNumberDisplayFormatConfigurationNumberDisplayFormatConfiguration : IResourceInterface
    {
        Humidifier.QuickSight.TemplateTypes.NumberDisplayFormatConfiguration NumberDisplayFormatConfiguration { get; set; }
    }

    public interface IHaveQuickSightTemplateTypesPercentageDisplayFormatConfigurationPercentageDisplayFormatConfiguration : IResourceInterface
    {
        Humidifier.QuickSight.TemplateTypes.PercentageDisplayFormatConfiguration PercentageDisplayFormatConfiguration { get; set; }
    }

    public interface IHaveQuickSightTemplateTypesLineChartSeriesSettingsSettings : IResourceInterface
    {
        Humidifier.QuickSight.TemplateTypes.LineChartSeriesSettings Settings { get; set; }
    }

    public interface IHaveQuickSightTemplateTypesFontConfigurationLabelFontConfiguration : IResourceInterface
    {
        Humidifier.QuickSight.TemplateTypes.FontConfiguration LabelFontConfiguration { get; set; }
    }

    public interface IHaveQuickSightTemplateTypesDateTimeFormatConfigurationFormatConfiguration : IResourceInterface
    {
        Humidifier.QuickSight.TemplateTypes.DateTimeFormatConfiguration FormatConfiguration { get; set; }
    }

    public interface IHaveQuickSightTemplateTypesNumericFormatConfigurationNumericFormatConfiguration : IResourceInterface
    {
        Humidifier.QuickSight.TemplateTypes.NumericFormatConfiguration NumericFormatConfiguration { get; set; }
    }

    public interface IHaveQuickSightTemplateTypesFreeFormLayoutCanvasSizeOptionsCanvasSizeOptions : IResourceInterface
    {
        Humidifier.QuickSight.TemplateTypes.FreeFormLayoutCanvasSizeOptions CanvasSizeOptions { get; set; }
    }

    public interface IHaveQuickSightTemplateTypesGridLayoutCanvasSizeOptionsCanvasSizeOptions : IResourceInterface
    {
        Humidifier.QuickSight.TemplateTypes.GridLayoutCanvasSizeOptions CanvasSizeOptions { get; set; }
    }

    public interface IHaveQuickSightTemplateTypesRelativeDateTimeControlDisplayOptionsDisplayOptions : IResourceInterface
    {
        Humidifier.QuickSight.TemplateTypes.RelativeDateTimeControlDisplayOptions DisplayOptions { get; set; }
    }

    public interface IHaveQuickSightTemplateTypesSectionBasedLayoutCanvasSizeOptionsCanvasSizeOptions : IResourceInterface
    {
        Humidifier.QuickSight.TemplateTypes.SectionBasedLayoutCanvasSizeOptions CanvasSizeOptions { get; set; }
    }

    public interface IHaveQuickSightTemplateTypesListControlSelectAllOptionsSelectAllOptions : IResourceInterface
    {
        Humidifier.QuickSight.TemplateTypes.ListControlSelectAllOptions SelectAllOptions { get; set; }
    }

    public interface IHaveListOfQuickSightTemplateTypesColumnIdentifierColumns : IResourceInterface
    {
        List<Humidifier.QuickSight.TemplateTypes.ColumnIdentifier> Columns { get; set; }
    }

    public interface IHaveListOfQuickSightTemplateTypesDimensionFieldGeospatial : IResourceInterface
    {
        List<Humidifier.QuickSight.TemplateTypes.DimensionField> Geospatial { get; set; }
    }

    public interface IHaveQuickSightTemplateTypesGeospatialMapStyleOptionsMapStyleOptions : IResourceInterface
    {
        Humidifier.QuickSight.TemplateTypes.GeospatialMapStyleOptions MapStyleOptions { get; set; }
    }

    public interface IHaveQuickSightTemplateTypesGeospatialWindowOptionsWindowOptions : IResourceInterface
    {
        Humidifier.QuickSight.TemplateTypes.GeospatialWindowOptions WindowOptions { get; set; }
    }

    public interface IHaveListOfQuickSightTemplateTypesFreeFormLayoutElementElements : IResourceInterface
    {
        List<Humidifier.QuickSight.TemplateTypes.FreeFormLayoutElement> Elements { get; set; }
    }

    public interface IHaveQuickSightTemplateTypesConditionalFormattingColorForegroundColor : IResourceInterface
    {
        Humidifier.QuickSight.TemplateTypes.ConditionalFormattingColor ForegroundColor { get; set; }
    }

    public interface IHaveListOfQuickSightTemplateTypesMeasureFieldTargetValues : IResourceInterface
    {
        List<Humidifier.QuickSight.TemplateTypes.MeasureField> TargetValues { get; set; }
    }

    public interface IHaveQuickSightTemplateTypesComparisonConfigurationComparison : IResourceInterface
    {
        Humidifier.QuickSight.TemplateTypes.ComparisonConfiguration Comparison { get; set; }
    }

    public interface IHaveQuickSightTemplateTypesFontConfigurationPrimaryValueFontConfiguration : IResourceInterface
    {
        Humidifier.QuickSight.TemplateTypes.FontConfiguration PrimaryValueFontConfiguration { get; set; }
    }

    public interface IHaveListOfQuickSightTemplateTypesDimensionFieldColumns : IResourceInterface
    {
        List<Humidifier.QuickSight.TemplateTypes.DimensionField> Columns { get; set; }
    }

    public interface IHaveListOfQuickSightTemplateTypesDimensionFieldRows : IResourceInterface
    {
        List<Humidifier.QuickSight.TemplateTypes.DimensionField> Rows { get; set; }
    }

    public interface IHaveQuickSightTemplateTypesColorScaleColorScale : IResourceInterface
    {
        Humidifier.QuickSight.TemplateTypes.ColorScale ColorScale { get; set; }
    }

    public interface IHaveQuickSightTemplateTypesAxisDisplayOptionsYAxisDisplayOptions : IResourceInterface
    {
        Humidifier.QuickSight.TemplateTypes.AxisDisplayOptions YAxisDisplayOptions { get; set; }
    }

    public interface IHaveQuickSightTemplateTypesCustomActionNavigationOperationNavigationOperation : IResourceInterface
    {
        Humidifier.QuickSight.TemplateTypes.CustomActionNavigationOperation NavigationOperation { get; set; }
    }

    public interface IHaveQuickSightTemplateTypesCustomActionSetParametersOperationSetParametersOperation : IResourceInterface
    {
        Humidifier.QuickSight.TemplateTypes.CustomActionSetParametersOperation SetParametersOperation { get; set; }
    }

    public interface IHaveQuickSightTemplateTypesCustomActionURLOperationURLOperation : IResourceInterface
    {
        Humidifier.QuickSight.TemplateTypes.CustomActionURLOperation URLOperation { get; set; }
    }

    public interface IHaveQuickSightTemplateTypesGridLayoutConfigurationGridLayout : IResourceInterface
    {
        Humidifier.QuickSight.TemplateTypes.GridLayoutConfiguration GridLayout { get; set; }
    }

    public interface IHaveQuickSightTemplateTypesLineChartLineStyleSettingsLineStyleSettings : IResourceInterface
    {
        Humidifier.QuickSight.TemplateTypes.LineChartLineStyleSettings LineStyleSettings { get; set; }
    }

    public interface IHaveQuickSightTemplateTypesLineChartMarkerStyleSettingsMarkerStyleSettings : IResourceInterface
    {
        Humidifier.QuickSight.TemplateTypes.LineChartMarkerStyleSettings MarkerStyleSettings { get; set; }
    }

    public interface IHaveQuickSightTemplateTypesNumericFormatConfigurationFormatConfiguration : IResourceInterface
    {
        Humidifier.QuickSight.TemplateTypes.NumericFormatConfiguration FormatConfiguration { get; set; }
    }

    public interface IHaveQuickSightTemplateTypesNumberFormatConfigurationFormatConfiguration : IResourceInterface
    {
        Humidifier.QuickSight.TemplateTypes.NumberFormatConfiguration FormatConfiguration { get; set; }
    }

    public interface IHaveQuickSightTemplateTypesParameterSelectableValuesSelectableValues : IResourceInterface
    {
        Humidifier.QuickSight.TemplateTypes.ParameterSelectableValues SelectableValues { get; set; }
    }

    public interface IHaveQuickSightTemplateTypesTextConditionalFormatTextFormat : IResourceInterface
    {
        Humidifier.QuickSight.TemplateTypes.TextConditionalFormat TextFormat { get; set; }
    }

    public interface IHaveQuickSightTemplateTypesTableCellStyleCellStyle : IResourceInterface
    {
        Humidifier.QuickSight.TemplateTypes.TableCellStyle CellStyle { get; set; }
    }

    public interface IHaveQuickSightTemplateTypesRowAlternateColorOptionsRowAlternateColorOptions : IResourceInterface
    {
        Humidifier.QuickSight.TemplateTypes.RowAlternateColorOptions RowAlternateColorOptions { get; set; }
    }

    public interface IHaveListOfQuickSightTemplateTypesTotalAggregationOptionTotalAggregationOptions : IResourceInterface
    {
        List<Humidifier.QuickSight.TemplateTypes.TotalAggregationOption> TotalAggregationOptions { get; set; }
    }

    public interface IHaveQuickSightTemplateTypesTableCellStyleValueCellStyle : IResourceInterface
    {
        Humidifier.QuickSight.TemplateTypes.TableCellStyle ValueCellStyle { get; set; }
    }

    public interface IHaveQuickSightTemplateTypesTableCellStyleMetricHeaderCellStyle : IResourceInterface
    {
        Humidifier.QuickSight.TemplateTypes.TableCellStyle MetricHeaderCellStyle { get; set; }
    }

    public interface IHaveListOfQuickSightTemplateTypesFieldSortOptionsRowSort : IResourceInterface
    {
        List<Humidifier.QuickSight.TemplateTypes.FieldSortOptions> RowSort { get; set; }
    }

    public interface IHaveQuickSightTemplateTypesExcludePeriodConfigurationExcludePeriodConfiguration : IResourceInterface
    {
        Humidifier.QuickSight.TemplateTypes.ExcludePeriodConfiguration ExcludePeriodConfiguration { get; set; }
    }

    public interface IHaveListOfQuickSightTemplateTypesDimensionFieldLabel : IResourceInterface
    {
        List<Humidifier.QuickSight.TemplateTypes.DimensionField> Label { get; set; }
    }

    public interface IHaveListOfQuickSightTemplateTypesSheetImageImages : IResourceInterface
    {
        List<Humidifier.QuickSight.TemplateTypes.SheetImage> Images { get; set; }
    }

    public interface IHaveListOfQuickSightTemplateTypesDataSetConfigurationDataSetConfigurations : IResourceInterface
    {
        List<Humidifier.QuickSight.TemplateTypes.DataSetConfiguration> DataSetConfigurations { get; set; }
    }

    public interface IHaveQuickSightTemplateTypesTextControlPlaceholderOptionsPlaceholderOptions : IResourceInterface
    {
        Humidifier.QuickSight.TemplateTypes.TextControlPlaceholderOptions PlaceholderOptions { get; set; }
    }

    public interface IHaveDynDicOfTypeParameters : IResourceInterface
    {
        Dictionary<string, dynamic> TypeParameters { get; set; }
    }

    public interface IHaveSubTypeName : IResourceInterface
    {
        dynamic SubTypeName { get; set; }
    }

    public interface IHaveQuickSightTopicTypesSemanticTypeSemanticType : IResourceInterface
    {
        Humidifier.QuickSight.TopicTypes.SemanticType SemanticType { get; set; }
    }

    public interface IHaveNotAllowedAggregations : IResourceInterface
    {
        dynamic NotAllowedAggregations { get; set; }
    }

    public interface IHaveQuickSightTopicTypesDefaultFormattingDefaultFormatting : IResourceInterface
    {
        Humidifier.QuickSight.TopicTypes.DefaultFormatting DefaultFormatting { get; set; }
    }

    public interface IHaveAllowedAggregations : IResourceInterface
    {
        dynamic AllowedAggregations { get; set; }
    }

    public interface IHaveIsIncludedInTopic : IResourceInterface
    {
        dynamic IsIncludedInTopic { get; set; }
    }

    public interface IHaveColumnDataRole : IResourceInterface
    {
        dynamic ColumnDataRole { get; set; }
    }

    public interface IHaveNonAdditive : IResourceInterface
    {
        dynamic NonAdditive { get; set; }
    }

    public interface IHaveNeverAggregateInFilter : IResourceInterface
    {
        dynamic NeverAggregateInFilter { get; set; }
    }

    public interface IHaveDisableIndexing : IResourceInterface
    {
        dynamic DisableIndexing { get; set; }
    }

    public interface IHaveQuickSightTopicTypesComparativeOrderComparativeOrder : IResourceInterface
    {
        Humidifier.QuickSight.TopicTypes.ComparativeOrder ComparativeOrder { get; set; }
    }

    public interface IHaveListOfQuickSightTopicTypesCellValueSynonymCellValueSynonyms : IResourceInterface
    {
        List<Humidifier.QuickSight.TopicTypes.CellValueSynonym> CellValueSynonyms { get; set; }
    }

    public interface IHaveSingularConstant : IResourceInterface
    {
        dynamic SingularConstant { get; set; }
    }

    public interface IHaveInclusive : IResourceInterface
    {
        dynamic Inclusive { get; set; }
    }

    public interface IHaveQuickSightTopicTypesTopicRangeFilterConstantConstant : IResourceInterface
    {
        Humidifier.QuickSight.TopicTypes.TopicRangeFilterConstant Constant { get; set; }
    }

    public interface IHaveQuickSightTopicTypesTopicSingularFilterConstantConstant : IResourceInterface
    {
        Humidifier.QuickSight.TopicTypes.TopicSingularFilterConstant Constant { get; set; }
    }

    public interface IHaveSecondsUntilAutoPause : IResourceInterface
    {
        dynamic SecondsUntilAutoPause { get; set; }
    }

    public interface IHaveCreationDate : IResourceInterface
    {
        dynamic CreationDate { get; set; }
    }

    public interface IHaveActivationState : IResourceInterface
    {
        dynamic ActivationState { get; set; }
    }

    public interface IHaveInverted : IResourceInterface
    {
        dynamic Inverted { get; set; }
    }

    public interface IHaveEvaluateTargetHealth : IResourceInterface
    {
        dynamic EvaluateTargetHealth { get; set; }
    }

    public interface IHaveContinentCode : IResourceInterface
    {
        dynamic ContinentCode { get; set; }
    }

    public interface IHaveSubdivisionCode : IResourceInterface
    {
        dynamic SubdivisionCode { get; set; }
    }

    public interface IHaveAWSRegion : IResourceInterface
    {
        dynamic AWSRegion { get; set; }
    }

    public interface IHaveBias : IResourceInterface
    {
        dynamic Bias { get; set; }
    }

    public interface IHaveLocalZoneGroup : IResourceInterface
    {
        dynamic LocalZoneGroup { get; set; }
    }

    public interface IHaveWaitPeriodMs : IResourceInterface
    {
        dynamic WaitPeriodMs { get; set; }
    }

    public interface IHaveRecordSetId : IResourceInterface
    {
        dynamic RecordSetId { get; set; }
    }

    public interface IHaveIpv6 : IResourceInterface
    {
        dynamic Ipv6 { get; set; }
    }

    public interface IHaveS3BucketTypesDestinationDestination : IResourceInterface
    {
        Humidifier.S3.BucketTypes.Destination Destination { get; set; }
    }

    public interface IHaveOutputSchemaVersion : IResourceInterface
    {
        dynamic OutputSchemaVersion { get; set; }
    }

    public interface IHaveNoncurrentDays : IResourceInterface
    {
        dynamic NoncurrentDays { get; set; }
    }

    public interface IHaveNewerNoncurrentVersions : IResourceInterface
    {
        dynamic NewerNoncurrentVersions { get; set; }
    }

    public interface IHaveTransitionInDays : IResourceInterface
    {
        dynamic TransitionInDays { get; set; }
    }

    public interface IHaveHostName : IResourceInterface
    {
        dynamic HostName { get; set; }
    }

    public interface IHaveObjectSizeGreaterThan : IResourceInterface
    {
        dynamic ObjectSizeGreaterThan { get; set; }
    }

    public interface IHaveObjectSizeLessThan : IResourceInterface
    {
        dynamic ObjectSizeLessThan { get; set; }
    }

    public interface IHaveExpirationDate : IResourceInterface
    {
        dynamic ExpirationDate { get; set; }
    }

    public interface IHaveSSEAlgorithm : IResourceInterface
    {
        dynamic SSEAlgorithm { get; set; }
    }

    public interface IHaveKMSMasterKeyID : IResourceInterface
    {
        dynamic KMSMasterKeyID { get; set; }
    }

    public interface IHaveBucketKeyEnabled : IResourceInterface
    {
        dynamic BucketKeyEnabled { get; set; }
    }

    public interface IHaveS3StorageLensTypesAdvancedDataProtectionMetricsAdvancedDataProtectionMetrics : IResourceInterface
    {
        Humidifier.S3.StorageLensTypes.AdvancedDataProtectionMetrics AdvancedDataProtectionMetrics { get; set; }
    }

    public interface IHaveS3StorageLensTypesActivityMetricsActivityMetrics : IResourceInterface
    {
        Humidifier.S3.StorageLensTypes.ActivityMetrics ActivityMetrics { get; set; }
    }

    public interface IHaveS3StorageLensTypesAdvancedCostOptimizationMetricsAdvancedCostOptimizationMetrics : IResourceInterface
    {
        Humidifier.S3.StorageLensTypes.AdvancedCostOptimizationMetrics AdvancedCostOptimizationMetrics { get; set; }
    }

    public interface IHaveS3StorageLensTypesDetailedStatusCodesMetricsDetailedStatusCodesMetrics : IResourceInterface
    {
        Humidifier.S3.StorageLensTypes.DetailedStatusCodesMetrics DetailedStatusCodesMetrics { get; set; }
    }

    public interface IHaveEngagementMetrics : IResourceInterface
    {
        dynamic EngagementMetrics { get; set; }
    }

    public interface IHaveTlsPolicy : IResourceInterface
    {
        dynamic TlsPolicy { get; set; }
    }

    public interface IHaveOptimizedSharedDelivery : IResourceInterface
    {
        dynamic OptimizedSharedDelivery { get; set; }
    }

    public interface IHaveAnalyzer : IResourceInterface
    {
        dynamic Analyzer { get; set; }
    }

    public interface IHaveResultField : IResourceInterface
    {
        dynamic ResultField { get; set; }
    }

    public interface IHaveOutputS3KeyPrefix : IResourceInterface
    {
        dynamic OutputS3KeyPrefix { get; set; }
    }

    public interface IHaveOutputS3BucketName : IResourceInterface
    {
        dynamic OutputS3BucketName { get; set; }
    }

    public interface IHaveRetryIntervalInMinutes : IResourceInterface
    {
        dynamic RetryIntervalInMinutes { get; set; }
    }

    public interface IHaveIsEssential : IResourceInterface
    {
        dynamic IsEssential { get; set; }
    }

    public interface IHaveHandOffTime : IResourceInterface
    {
        dynamic HandOffTime { get; set; }
    }

    public interface IHaveSageMakerAppImageConfigTypesContainerConfigContainerConfig : IResourceInterface
    {
        Humidifier.SageMaker.AppImageConfigTypes.ContainerConfig ContainerConfig { get; set; }
    }

    public interface IHaveSageMakerDomainTypesAppLifecycleManagementAppLifecycleManagement : IResourceInterface
    {
        Humidifier.SageMaker.DomainTypes.AppLifecycleManagement AppLifecycleManagement { get; set; }
    }

    public interface IHaveMaximumEbsVolumeSizeInGb : IResourceInterface
    {
        dynamic MaximumEbsVolumeSizeInGb { get; set; }
    }

    public interface IHaveDefaultEbsVolumeSizeInGb : IResourceInterface
    {
        dynamic DefaultEbsVolumeSizeInGb { get; set; }
    }

    public interface IHaveSageMakerDomainTypesJupyterLabAppSettingsJupyterLabAppSettings : IResourceInterface
    {
        Humidifier.SageMaker.DomainTypes.JupyterLabAppSettings JupyterLabAppSettings { get; set; }
    }

    public interface IHaveSageMakerDomainTypesKernelGatewayAppSettingsKernelGatewayAppSettings : IResourceInterface
    {
        Humidifier.SageMaker.DomainTypes.KernelGatewayAppSettings KernelGatewayAppSettings { get; set; }
    }

    public interface IHaveSageMakerDomainTypesJupyterServerAppSettingsJupyterServerAppSettings : IResourceInterface
    {
        Humidifier.SageMaker.DomainTypes.JupyterServerAppSettings JupyterServerAppSettings { get; set; }
    }

    public interface IHaveListOfSageMakerDomainTypesCustomFileSystemConfigCustomFileSystemConfigs : IResourceInterface
    {
        List<Humidifier.SageMaker.DomainTypes.CustomFileSystemConfig> CustomFileSystemConfigs { get; set; }
    }

    public interface IHaveSageMakerDomainTypesDefaultSpaceStorageSettingsSpaceStorageSettings : IResourceInterface
    {
        Humidifier.SageMaker.DomainTypes.DefaultSpaceStorageSettings SpaceStorageSettings { get; set; }
    }

    public interface IHaveSageMakerDomainTypesCustomPosixUserConfigCustomPosixUserConfig : IResourceInterface
    {
        Humidifier.SageMaker.DomainTypes.CustomPosixUserConfig CustomPosixUserConfig { get; set; }
    }

    public interface IHaveMaxIdleTimeoutInMinutes : IResourceInterface
    {
        dynamic MaxIdleTimeoutInMinutes { get; set; }
    }

    public interface IHaveMinIdleTimeoutInMinutes : IResourceInterface
    {
        dynamic MinIdleTimeoutInMinutes { get; set; }
    }

    public interface IHaveLifecycleManagement : IResourceInterface
    {
        dynamic LifecycleManagement { get; set; }
    }

    public interface IHaveAccessStatus : IResourceInterface
    {
        dynamic AccessStatus { get; set; }
    }

    public interface IHaveUserGroup : IResourceInterface
    {
        dynamic UserGroup { get; set; }
    }

    public interface IHaveNotebookOutputOption : IResourceInterface
    {
        dynamic NotebookOutputOption { get; set; }
    }

    public interface IHaveS3KmsKeyId : IResourceInterface
    {
        dynamic S3KmsKeyId { get; set; }
    }

    public interface IHaveHiddenAppTypes : IResourceInterface
    {
        dynamic HiddenAppTypes { get; set; }
    }

    public interface IHaveHiddenMlTools : IResourceInterface
    {
        dynamic HiddenMlTools { get; set; }
    }

    public interface IHaveStudioWebPortal : IResourceInterface
    {
        dynamic StudioWebPortal { get; set; }
    }

    public interface IHaveDefaultLandingUri : IResourceInterface
    {
        dynamic DefaultLandingUri { get; set; }
    }

    public interface IHaveMaximumExecutionTimeoutInSeconds : IResourceInterface
    {
        dynamic MaximumExecutionTimeoutInSeconds { get; set; }
    }

    public interface IHaveWaitIntervalInSeconds : IResourceInterface
    {
        dynamic WaitIntervalInSeconds { get; set; }
    }

    public interface IHaveJsonContentTypes : IResourceInterface
    {
        dynamic JsonContentTypes { get; set; }
    }

    public interface IHaveCsvContentTypes : IResourceInterface
    {
        dynamic CsvContentTypes { get; set; }
    }

    public interface IHaveMaxPayloadInMB : IResourceInterface
    {
        dynamic MaxPayloadInMB { get; set; }
    }

    public interface IHaveModelDataDownloadTimeoutInSeconds : IResourceInterface
    {
        dynamic ModelDataDownloadTimeoutInSeconds { get; set; }
    }

    public interface IHaveContainerStartupHealthCheckTimeoutInSeconds : IResourceInterface
    {
        dynamic ContainerStartupHealthCheckTimeoutInSeconds { get; set; }
    }

    public interface IHaveSageMakerModelTypesS3DataSourceS3DataSource : IResourceInterface
    {
        Humidifier.SageMaker.ModelTypes.S3DataSource S3DataSource { get; set; }
    }

    public interface IHaveContainerHostname : IResourceInterface
    {
        dynamic ContainerHostname { get; set; }
    }

    public interface IHaveAcceptEula : IResourceInterface
    {
        dynamic AcceptEula { get; set; }
    }

    public interface IHaveConfigUri : IResourceInterface
    {
        dynamic ConfigUri { get; set; }
    }

    public interface IHaveNearestModelName : IResourceInterface
    {
        dynamic NearestModelName { get; set; }
    }

    public interface IHaveContainerImage : IResourceInterface
    {
        dynamic ContainerImage { get; set; }
    }

    public interface IHaveProblemType : IResourceInterface
    {
        dynamic ProblemType { get; set; }
    }

    public interface IHaveAlgorithmName : IResourceInterface
    {
        dynamic AlgorithmName { get; set; }
    }

    public interface IHaveSupportedContentTypes : IResourceInterface
    {
        dynamic SupportedContentTypes { get; set; }
    }

    public interface IHaveSupportedRealtimeInferenceInstanceTypes : IResourceInterface
    {
        dynamic SupportedRealtimeInferenceInstanceTypes { get; set; }
    }

    public interface IHaveListOfSageMakerModelPackageTypesModelPackageContainerDefinitionContainers : IResourceInterface
    {
        List<Humidifier.SageMaker.ModelPackageTypes.ModelPackageContainerDefinition> Containers { get; set; }
    }

    public interface IHaveSupportedTransformInstanceTypes : IResourceInterface
    {
        dynamic SupportedTransformInstanceTypes { get; set; }
    }

    public interface IHaveSupportedResponseMIMETypes : IResourceInterface
    {
        dynamic SupportedResponseMIMETypes { get; set; }
    }

    public interface IHaveSageMakerModelPackageTypesMetricsSourceReport : IResourceInterface
    {
        Humidifier.SageMaker.ModelPackageTypes.MetricsSource Report { get; set; }
    }

    public interface IHaveSageMakerModelPackageTypesFileSourceConfigFile : IResourceInterface
    {
        Humidifier.SageMaker.ModelPackageTypes.FileSource ConfigFile { get; set; }
    }

    public interface IHaveContentDigest : IResourceInterface
    {
        dynamic ContentDigest { get; set; }
    }

    public interface IHaveSageMakerSpaceTypesSpaceAppLifecycleManagementAppLifecycleManagement : IResourceInterface
    {
        Humidifier.SageMaker.SpaceTypes.SpaceAppLifecycleManagement AppLifecycleManagement { get; set; }
    }

    public interface IHaveSageMakerUserProfileTypesAppLifecycleManagementAppLifecycleManagement : IResourceInterface
    {
        Humidifier.SageMaker.UserProfileTypes.AppLifecycleManagement AppLifecycleManagement { get; set; }
    }

    public interface IHaveExcludeCharacters : IResourceInterface
    {
        dynamic ExcludeCharacters { get; set; }
    }

    public interface IHaveEnum : IResourceInterface
    {
        dynamic Enum { get; set; }
    }

    public interface IHaveInteger : IResourceInterface
    {
        dynamic Integer { get; set; }
    }

    public interface IHaveEnumList : IResourceInterface
    {
        dynamic EnumList { get; set; }
    }

    public interface IHaveIntegerListOfIntegerList : IResourceInterface
    {
        List<int> IntegerList { get; set; }
    }

    public interface IHaveString : IResourceInterface
    {
        dynamic String { get; set; }
    }

    public interface IHaveBoolean : IResourceInterface
    {
        dynamic Boolean { get; set; }
    }

    public interface IHaveDouble : IResourceInterface
    {
        dynamic Double { get; set; }
    }

    public interface IHaveStateMachineVersionArn : IResourceInterface
    {
        dynamic StateMachineVersionArn { get; set; }
    }

    public interface IHaveListOfTimestreamScheduledQueryTypesMultiMeasureAttributeMappingMultiMeasureAttributeMappings : IResourceInterface
    {
        List<Humidifier.Timestream.ScheduledQueryTypes.MultiMeasureAttributeMapping> MultiMeasureAttributeMappings { get; set; }
    }

    public interface IHaveOverwriteExisting : IResourceInterface
    {
        dynamic OverwriteExisting { get; set; }
    }

    public interface IHaveGroupEntityType : IResourceInterface
    {
        dynamic GroupEntityType { get; set; }
    }

    public interface IHaveClientIds : IResourceInterface
    {
        dynamic ClientIds { get; set; }
    }

    public interface IHavePrincipalIdClaim : IResourceInterface
    {
        dynamic PrincipalIdClaim { get; set; }
    }

    public interface IHaveTargetGroupIdentifier : IResourceInterface
    {
        dynamic TargetGroupIdentifier { get; set; }
    }

    public interface IHaveTargetString : IResourceInterface
    {
        dynamic TargetString { get; set; }
    }

    public interface IHaveTargetStringBase64 : IResourceInterface
    {
        dynamic TargetStringBase64 { get; set; }
    }

    public interface IHaveListOfWAFv2RuleGroupTypesStatementStatements : IResourceInterface
    {
        List<Humidifier.WAFv2.RuleGroupTypes.Statement> Statements { get; set; }
    }

    public interface IHaveSearchStringBase64 : IResourceInterface
    {
        dynamic SearchStringBase64 { get; set; }
    }

    public interface IHaveWAFv2RuleGroupTypesImmunityTimePropertyImmunityTimeProperty : IResourceInterface
    {
        Humidifier.WAFv2.RuleGroupTypes.ImmunityTimeProperty ImmunityTimeProperty { get; set; }
    }

    public interface IHaveIncludedCookies : IResourceInterface
    {
        dynamic IncludedCookies { get; set; }
    }

    public interface IHaveExcludedCookies : IResourceInterface
    {
        dynamic ExcludedCookies { get; set; }
    }

    public interface IHaveCustomResponseBodyKey : IResourceInterface
    {
        dynamic CustomResponseBodyKey { get; set; }
    }

    public interface IHaveAllQueryArguments : IResourceInterface
    {
        dynamic AllQueryArguments { get; set; }
    }

    public interface IHaveWAFv2RuleGroupTypesForwardedIPConfigurationForwardedIPConfig : IResourceInterface
    {
        Humidifier.WAFv2.RuleGroupTypes.ForwardedIPConfiguration ForwardedIPConfig { get; set; }
    }

    public interface IHaveCountryCodes : IResourceInterface
    {
        dynamic CountryCodes { get; set; }
    }

    public interface IHaveIncludedHeaders : IResourceInterface
    {
        dynamic IncludedHeaders { get; set; }
    }

    public interface IHaveExcludedHeaders : IResourceInterface
    {
        dynamic ExcludedHeaders { get; set; }
    }

    public interface IHaveImmunityTime : IResourceInterface
    {
        dynamic ImmunityTime { get; set; }
    }

    public interface IHaveInvalidFallbackBehavior : IResourceInterface
    {
        dynamic InvalidFallbackBehavior { get; set; }
    }

    public interface IHaveIncludedPaths : IResourceInterface
    {
        dynamic IncludedPaths { get; set; }
    }

    public interface IHaveWAFv2RuleGroupTypesStatementStatement : IResourceInterface
    {
        Humidifier.WAFv2.RuleGroupTypes.Statement Statement { get; set; }
    }

    public interface IHaveAggregateKeyType : IResourceInterface
    {
        dynamic AggregateKeyType { get; set; }
    }

    public interface IHaveEvaluationWindowSec : IResourceInterface
    {
        dynamic EvaluationWindowSec { get; set; }
    }

    public interface IHaveForwardedIP : IResourceInterface
    {
        dynamic ForwardedIP { get; set; }
    }

    public interface IHaveIP : IResourceInterface
    {
        dynamic IP { get; set; }
    }

    public interface IHaveSensitivityLevel : IResourceInterface
    {
        dynamic SensitivityLevel { get; set; }
    }

    public interface IHaveSampledRequestsEnabled : IResourceInterface
    {
        dynamic SampledRequestsEnabled { get; set; }
    }

    public interface IHaveWAFv2WebACLTypesResponseInspectionResponseInspection : IResourceInterface
    {
        Humidifier.WAFv2.WebACLTypes.ResponseInspection ResponseInspection { get; set; }
    }

    public interface IHaveEnableRegexInPath : IResourceInterface
    {
        dynamic EnableRegexInPath { get; set; }
    }

    public interface IHaveLoginPath : IResourceInterface
    {
        dynamic LoginPath { get; set; }
    }

    public interface IHaveListOfWAFv2WebACLTypesStatementStatements : IResourceInterface
    {
        List<Humidifier.WAFv2.WebACLTypes.Statement> Statements { get; set; }
    }

    public interface IHaveWAFv2WebACLTypesImmunityTimePropertyImmunityTimeProperty : IResourceInterface
    {
        Humidifier.WAFv2.WebACLTypes.ImmunityTimeProperty ImmunityTimeProperty { get; set; }
    }

    public interface IHaveWAFv2WebACLTypesBlockActionBlock : IResourceInterface
    {
        Humidifier.WAFv2.WebACLTypes.BlockAction Block { get; set; }
    }

    public interface IHaveWAFv2WebACLTypesAllowActionAllow : IResourceInterface
    {
        Humidifier.WAFv2.WebACLTypes.AllowAction Allow { get; set; }
    }

    public interface IHaveWAFv2WebACLTypesForwardedIPConfigurationForwardedIPConfig : IResourceInterface
    {
        Humidifier.WAFv2.WebACLTypes.ForwardedIPConfiguration ForwardedIPConfig { get; set; }
    }

    public interface IHaveListOfWAFv2WebACLTypesRuleActionOverrideRuleActionOverrides : IResourceInterface
    {
        List<Humidifier.WAFv2.WebACLTypes.RuleActionOverride> RuleActionOverrides { get; set; }
    }

    public interface IHaveListOfWAFv2WebACLTypesExcludedRuleExcludedRules : IResourceInterface
    {
        List<Humidifier.WAFv2.WebACLTypes.ExcludedRule> ExcludedRules { get; set; }
    }

    public interface IHaveWAFv2WebACLTypesStatementScopeDownStatement : IResourceInterface
    {
        Humidifier.WAFv2.WebACLTypes.Statement ScopeDownStatement { get; set; }
    }

    public interface IHaveWAFv2WebACLTypesStatementStatement : IResourceInterface
    {
        Humidifier.WAFv2.WebACLTypes.Statement Statement { get; set; }
    }

    public interface IHaveSuccessValues : IResourceInterface
    {
        dynamic SuccessValues { get; set; }
    }

    public interface IHaveFailureValues : IResourceInterface
    {
        dynamic FailureValues { get; set; }
    }

    public interface IHaveAnswerGenerationAIPromptId : IResourceInterface
    {
        dynamic AnswerGenerationAIPromptId { get; set; }
    }

    public interface IHaveAnswerGenerationAIGuardrailId : IResourceInterface
    {
        dynamic AnswerGenerationAIGuardrailId { get; set; }
    }

    public interface IHaveListOfWisdomAIAgentTypesTagConditionAndConditions : IResourceInterface
    {
        List<Humidifier.Wisdom.AIAgentTypes.TagCondition> AndConditions { get; set; }
    }

    public interface IHaveWisdomAIAgentTypesTagConditionTagCondition : IResourceInterface
    {
        Humidifier.Wisdom.AIAgentTypes.TagCondition TagCondition { get; set; }
    }

    public interface IHaveWisdomMessageTemplateTypesMessageTemplateBodyContentProviderPlainText : IResourceInterface
    {
        Humidifier.Wisdom.MessageTemplateTypes.MessageTemplateBodyContentProvider PlainText { get; set; }
    }
}