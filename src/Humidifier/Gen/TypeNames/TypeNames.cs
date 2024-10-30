namespace Humidifier;
public class AWS
{
    public class ACMPCA
    {
        public const string Certificate = "AWS::ACMPCA::Certificate";
        public const string CertificateAuthority = "AWS::ACMPCA::CertificateAuthority";
        public const string CertificateAuthorityActivation = "AWS::ACMPCA::CertificateAuthorityActivation";
        public const string Permission = "AWS::ACMPCA::Permission";
    }
    public class APS
    {
        public const string RuleGroupsNamespace = "AWS::APS::RuleGroupsNamespace";
        public const string Scraper = "AWS::APS::Scraper";
        public const string Workspace = "AWS::APS::Workspace";
    }
    public class ARCZonalShift
    {
        public const string AutoshiftObserverNotificationStatus = "AWS::ARCZonalShift::AutoshiftObserverNotificationStatus";
        public const string ZonalAutoshiftConfiguration = "AWS::ARCZonalShift::ZonalAutoshiftConfiguration";
    }
    public class AccessAnalyzer
    {
        public const string Analyzer = "AWS::AccessAnalyzer::Analyzer";
    }
    public class AmazonMQ
    {
        public const string Broker = "AWS::AmazonMQ::Broker";
        public const string Configuration = "AWS::AmazonMQ::Configuration";
        public const string ConfigurationAssociation = "AWS::AmazonMQ::ConfigurationAssociation";
    }
    public class Amplify
    {
        public const string App = "AWS::Amplify::App";
        public const string Branch = "AWS::Amplify::Branch";
        public const string Domain = "AWS::Amplify::Domain";
    }
    public class AmplifyUIBuilder
    {
        public const string Component = "AWS::AmplifyUIBuilder::Component";
        public const string Form = "AWS::AmplifyUIBuilder::Form";
        public const string Theme = "AWS::AmplifyUIBuilder::Theme";
    }
    public class ApiGateway
    {
        public const string Account = "AWS::ApiGateway::Account";
        public const string ApiKey = "AWS::ApiGateway::ApiKey";
        public const string Authorizer = "AWS::ApiGateway::Authorizer";
        public const string BasePathMapping = "AWS::ApiGateway::BasePathMapping";
        public const string ClientCertificate = "AWS::ApiGateway::ClientCertificate";
        public const string Deployment = "AWS::ApiGateway::Deployment";
        public const string DocumentationPart = "AWS::ApiGateway::DocumentationPart";
        public const string DocumentationVersion = "AWS::ApiGateway::DocumentationVersion";
        public const string DomainName = "AWS::ApiGateway::DomainName";
        public const string GatewayResponse = "AWS::ApiGateway::GatewayResponse";
        public const string Method = "AWS::ApiGateway::Method";
        public const string Model = "AWS::ApiGateway::Model";
        public const string RequestValidator = "AWS::ApiGateway::RequestValidator";
        public const string Resource = "AWS::ApiGateway::Resource";
        public const string RestApi = "AWS::ApiGateway::RestApi";
        public const string Stage = "AWS::ApiGateway::Stage";
        public const string UsagePlan = "AWS::ApiGateway::UsagePlan";
        public const string UsagePlanKey = "AWS::ApiGateway::UsagePlanKey";
        public const string VpcLink = "AWS::ApiGateway::VpcLink";
    }
    public class ApiGatewayV2
    {
        public const string Api = "AWS::ApiGatewayV2::Api";
        public const string ApiGatewayManagedOverrides = "AWS::ApiGatewayV2::ApiGatewayManagedOverrides";
        public const string ApiMapping = "AWS::ApiGatewayV2::ApiMapping";
        public const string Authorizer = "AWS::ApiGatewayV2::Authorizer";
        public const string Deployment = "AWS::ApiGatewayV2::Deployment";
        public const string DomainName = "AWS::ApiGatewayV2::DomainName";
        public const string Integration = "AWS::ApiGatewayV2::Integration";
        public const string IntegrationResponse = "AWS::ApiGatewayV2::IntegrationResponse";
        public const string Model = "AWS::ApiGatewayV2::Model";
        public const string Route = "AWS::ApiGatewayV2::Route";
        public const string RouteResponse = "AWS::ApiGatewayV2::RouteResponse";
        public const string Stage = "AWS::ApiGatewayV2::Stage";
        public const string VpcLink = "AWS::ApiGatewayV2::VpcLink";
    }
    public class AppConfig
    {
        public const string Application = "AWS::AppConfig::Application";
        public const string ConfigurationProfile = "AWS::AppConfig::ConfigurationProfile";
        public const string Deployment = "AWS::AppConfig::Deployment";
        public const string DeploymentStrategy = "AWS::AppConfig::DeploymentStrategy";
        public const string Environment = "AWS::AppConfig::Environment";
        public const string Extension = "AWS::AppConfig::Extension";
        public const string ExtensionAssociation = "AWS::AppConfig::ExtensionAssociation";
        public const string HostedConfigurationVersion = "AWS::AppConfig::HostedConfigurationVersion";
    }
    public class AppFlow
    {
        public const string Connector = "AWS::AppFlow::Connector";
        public const string ConnectorProfile = "AWS::AppFlow::ConnectorProfile";
        public const string Flow = "AWS::AppFlow::Flow";
    }
    public class AppIntegrations
    {
        public const string Application = "AWS::AppIntegrations::Application";
        public const string DataIntegration = "AWS::AppIntegrations::DataIntegration";
        public const string EventIntegration = "AWS::AppIntegrations::EventIntegration";
    }
    public class AppMesh
    {
        public const string GatewayRoute = "AWS::AppMesh::GatewayRoute";
        public const string Mesh = "AWS::AppMesh::Mesh";
        public const string Route = "AWS::AppMesh::Route";
        public const string VirtualGateway = "AWS::AppMesh::VirtualGateway";
        public const string VirtualNode = "AWS::AppMesh::VirtualNode";
        public const string VirtualRouter = "AWS::AppMesh::VirtualRouter";
        public const string VirtualService = "AWS::AppMesh::VirtualService";
    }
    public class AppRunner
    {
        public const string AutoScalingConfiguration = "AWS::AppRunner::AutoScalingConfiguration";
        public const string ObservabilityConfiguration = "AWS::AppRunner::ObservabilityConfiguration";
        public const string Service = "AWS::AppRunner::Service";
        public const string VpcConnector = "AWS::AppRunner::VpcConnector";
        public const string VpcIngressConnection = "AWS::AppRunner::VpcIngressConnection";
    }
    public class AppStream
    {
        public const string AppBlock = "AWS::AppStream::AppBlock";
        public const string AppBlockBuilder = "AWS::AppStream::AppBlockBuilder";
        public const string Application = "AWS::AppStream::Application";
        public const string ApplicationEntitlementAssociation = "AWS::AppStream::ApplicationEntitlementAssociation";
        public const string ApplicationFleetAssociation = "AWS::AppStream::ApplicationFleetAssociation";
        public const string DirectoryConfig = "AWS::AppStream::DirectoryConfig";
        public const string Entitlement = "AWS::AppStream::Entitlement";
        public const string Fleet = "AWS::AppStream::Fleet";
        public const string ImageBuilder = "AWS::AppStream::ImageBuilder";
        public const string Stack = "AWS::AppStream::Stack";
        public const string StackFleetAssociation = "AWS::AppStream::StackFleetAssociation";
        public const string StackUserAssociation = "AWS::AppStream::StackUserAssociation";
        public const string User = "AWS::AppStream::User";
    }
    public class AppSync
    {
        public const string ApiCache = "AWS::AppSync::ApiCache";
        public const string ApiKey = "AWS::AppSync::ApiKey";
        public const string DataSource = "AWS::AppSync::DataSource";
        public const string DomainName = "AWS::AppSync::DomainName";
        public const string DomainNameApiAssociation = "AWS::AppSync::DomainNameApiAssociation";
        public const string FunctionConfiguration = "AWS::AppSync::FunctionConfiguration";
        public const string GraphQLApi = "AWS::AppSync::GraphQLApi";
        public const string GraphQLSchema = "AWS::AppSync::GraphQLSchema";
        public const string Resolver = "AWS::AppSync::Resolver";
        public const string SourceApiAssociation = "AWS::AppSync::SourceApiAssociation";
    }
    public class AppTest
    {
        public const string TestCase = "AWS::AppTest::TestCase";
    }
    public class ApplicationAutoScaling
    {
        public const string ScalableTarget = "AWS::ApplicationAutoScaling::ScalableTarget";
        public const string ScalingPolicy = "AWS::ApplicationAutoScaling::ScalingPolicy";
    }
    public class ApplicationInsights
    {
        public const string Application = "AWS::ApplicationInsights::Application";
    }
    public class ApplicationSignals
    {
        public const string ServiceLevelObjective = "AWS::ApplicationSignals::ServiceLevelObjective";
    }
    public class Athena
    {
        public const string CapacityReservation = "AWS::Athena::CapacityReservation";
        public const string DataCatalog = "AWS::Athena::DataCatalog";
        public const string NamedQuery = "AWS::Athena::NamedQuery";
        public const string PreparedStatement = "AWS::Athena::PreparedStatement";
        public const string WorkGroup = "AWS::Athena::WorkGroup";
    }
    public class AuditManager
    {
        public const string Assessment = "AWS::AuditManager::Assessment";
    }
    public class AutoScaling
    {
        public const string AutoScalingGroup = "AWS::AutoScaling::AutoScalingGroup";
        public const string LaunchConfiguration = "AWS::AutoScaling::LaunchConfiguration";
        public const string LifecycleHook = "AWS::AutoScaling::LifecycleHook";
        public const string ScalingPolicy = "AWS::AutoScaling::ScalingPolicy";
        public const string ScheduledAction = "AWS::AutoScaling::ScheduledAction";
        public const string WarmPool = "AWS::AutoScaling::WarmPool";
    }
    public class AutoScalingPlans
    {
        public const string ScalingPlan = "AWS::AutoScalingPlans::ScalingPlan";
    }
    public class B2BI
    {
        public const string Capability = "AWS::B2BI::Capability";
        public const string Partnership = "AWS::B2BI::Partnership";
        public const string Profile = "AWS::B2BI::Profile";
        public const string Transformer = "AWS::B2BI::Transformer";
    }
    public class BCMDataExports
    {
        public const string Export = "AWS::BCMDataExports::Export";
    }
    public class Backup
    {
        public const string BackupPlan = "AWS::Backup::BackupPlan";
        public const string BackupSelection = "AWS::Backup::BackupSelection";
        public const string BackupVault = "AWS::Backup::BackupVault";
        public const string Framework = "AWS::Backup::Framework";
        public const string ReportPlan = "AWS::Backup::ReportPlan";
        public const string RestoreTestingPlan = "AWS::Backup::RestoreTestingPlan";
        public const string RestoreTestingSelection = "AWS::Backup::RestoreTestingSelection";
    }
    public class BackupGateway
    {
        public const string Hypervisor = "AWS::BackupGateway::Hypervisor";
    }
    public class Batch
    {
        public const string ComputeEnvironment = "AWS::Batch::ComputeEnvironment";
        public const string JobDefinition = "AWS::Batch::JobDefinition";
        public const string JobQueue = "AWS::Batch::JobQueue";
        public const string SchedulingPolicy = "AWS::Batch::SchedulingPolicy";
    }
    public class Bedrock
    {
        public const string Agent = "AWS::Bedrock::Agent";
        public const string AgentAlias = "AWS::Bedrock::AgentAlias";
        public const string DataSource = "AWS::Bedrock::DataSource";
        public const string Flow = "AWS::Bedrock::Flow";
        public const string FlowAlias = "AWS::Bedrock::FlowAlias";
        public const string FlowVersion = "AWS::Bedrock::FlowVersion";
        public const string Guardrail = "AWS::Bedrock::Guardrail";
        public const string GuardrailVersion = "AWS::Bedrock::GuardrailVersion";
        public const string KnowledgeBase = "AWS::Bedrock::KnowledgeBase";
        public const string Prompt = "AWS::Bedrock::Prompt";
        public const string PromptVersion = "AWS::Bedrock::PromptVersion";
    }
    public class BillingConductor
    {
        public const string BillingGroup = "AWS::BillingConductor::BillingGroup";
        public const string CustomLineItem = "AWS::BillingConductor::CustomLineItem";
        public const string PricingPlan = "AWS::BillingConductor::PricingPlan";
        public const string PricingRule = "AWS::BillingConductor::PricingRule";
    }
    public class Budgets
    {
        public const string Budget = "AWS::Budgets::Budget";
        public const string BudgetsAction = "AWS::Budgets::BudgetsAction";
    }
    public class CE
    {
        public const string AnomalyMonitor = "AWS::CE::AnomalyMonitor";
        public const string AnomalySubscription = "AWS::CE::AnomalySubscription";
        public const string CostCategory = "AWS::CE::CostCategory";
    }
    public class CUR
    {
        public const string ReportDefinition = "AWS::CUR::ReportDefinition";
    }
    public class Cassandra
    {
        public const string Keyspace = "AWS::Cassandra::Keyspace";
        public const string Table = "AWS::Cassandra::Table";
    }
    public class CertificateManager
    {
        public const string Account = "AWS::CertificateManager::Account";
        public const string Certificate = "AWS::CertificateManager::Certificate";
    }
    public class Chatbot
    {
        public const string MicrosoftTeamsChannelConfiguration = "AWS::Chatbot::MicrosoftTeamsChannelConfiguration";
        public const string SlackChannelConfiguration = "AWS::Chatbot::SlackChannelConfiguration";
    }
    public class CleanRooms
    {
        public const string AnalysisTemplate = "AWS::CleanRooms::AnalysisTemplate";
        public const string Collaboration = "AWS::CleanRooms::Collaboration";
        public const string ConfiguredTable = "AWS::CleanRooms::ConfiguredTable";
        public const string ConfiguredTableAssociation = "AWS::CleanRooms::ConfiguredTableAssociation";
        public const string IdMappingTable = "AWS::CleanRooms::IdMappingTable";
        public const string IdNamespaceAssociation = "AWS::CleanRooms::IdNamespaceAssociation";
        public const string Membership = "AWS::CleanRooms::Membership";
        public const string PrivacyBudgetTemplate = "AWS::CleanRooms::PrivacyBudgetTemplate";
    }
    public class CleanRoomsML
    {
        public const string TrainingDataset = "AWS::CleanRoomsML::TrainingDataset";
    }
    public class Cloud9
    {
        public const string EnvironmentEC2 = "AWS::Cloud9::EnvironmentEC2";
    }
    public class CloudFormation
    {
        public const string CustomResource = "AWS::CloudFormation::CustomResource";
        public const string HookDefaultVersion = "AWS::CloudFormation::HookDefaultVersion";
        public const string HookTypeConfig = "AWS::CloudFormation::HookTypeConfig";
        public const string HookVersion = "AWS::CloudFormation::HookVersion";
        public const string Macro = "AWS::CloudFormation::Macro";
        public const string ModuleDefaultVersion = "AWS::CloudFormation::ModuleDefaultVersion";
        public const string ModuleVersion = "AWS::CloudFormation::ModuleVersion";
        public const string PublicTypeVersion = "AWS::CloudFormation::PublicTypeVersion";
        public const string Publisher = "AWS::CloudFormation::Publisher";
        public const string ResourceDefaultVersion = "AWS::CloudFormation::ResourceDefaultVersion";
        public const string ResourceVersion = "AWS::CloudFormation::ResourceVersion";
        public const string Stack = "AWS::CloudFormation::Stack";
        public const string StackSet = "AWS::CloudFormation::StackSet";
        public const string TypeActivation = "AWS::CloudFormation::TypeActivation";
        public const string WaitCondition = "AWS::CloudFormation::WaitCondition";
        public const string WaitConditionHandle = "AWS::CloudFormation::WaitConditionHandle";
    }
    public class CloudFront
    {
        public const string CachePolicy = "AWS::CloudFront::CachePolicy";
        public const string CloudFrontOriginAccessIdentity = "AWS::CloudFront::CloudFrontOriginAccessIdentity";
        public const string ContinuousDeploymentPolicy = "AWS::CloudFront::ContinuousDeploymentPolicy";
        public const string Distribution = "AWS::CloudFront::Distribution";
        public const string Function = "AWS::CloudFront::Function";
        public const string KeyGroup = "AWS::CloudFront::KeyGroup";
        public const string KeyValueStore = "AWS::CloudFront::KeyValueStore";
        public const string MonitoringSubscription = "AWS::CloudFront::MonitoringSubscription";
        public const string OriginAccessControl = "AWS::CloudFront::OriginAccessControl";
        public const string OriginRequestPolicy = "AWS::CloudFront::OriginRequestPolicy";
        public const string PublicKey = "AWS::CloudFront::PublicKey";
        public const string RealtimeLogConfig = "AWS::CloudFront::RealtimeLogConfig";
        public const string ResponseHeadersPolicy = "AWS::CloudFront::ResponseHeadersPolicy";
        public const string StreamingDistribution = "AWS::CloudFront::StreamingDistribution";
    }
    public class CloudTrail
    {
        public const string Channel = "AWS::CloudTrail::Channel";
        public const string EventDataStore = "AWS::CloudTrail::EventDataStore";
        public const string ResourcePolicy = "AWS::CloudTrail::ResourcePolicy";
        public const string Trail = "AWS::CloudTrail::Trail";
    }
    public class CloudWatch
    {
        public const string Alarm = "AWS::CloudWatch::Alarm";
        public const string AnomalyDetector = "AWS::CloudWatch::AnomalyDetector";
        public const string CompositeAlarm = "AWS::CloudWatch::CompositeAlarm";
        public const string Dashboard = "AWS::CloudWatch::Dashboard";
        public const string InsightRule = "AWS::CloudWatch::InsightRule";
        public const string MetricStream = "AWS::CloudWatch::MetricStream";
    }
    public class CodeArtifact
    {
        public const string Domain = "AWS::CodeArtifact::Domain";
        public const string PackageGroup = "AWS::CodeArtifact::PackageGroup";
        public const string Repository = "AWS::CodeArtifact::Repository";
    }
    public class CodeBuild
    {
        public const string Fleet = "AWS::CodeBuild::Fleet";
        public const string Project = "AWS::CodeBuild::Project";
        public const string ReportGroup = "AWS::CodeBuild::ReportGroup";
        public const string SourceCredential = "AWS::CodeBuild::SourceCredential";
    }
    public class CodeCommit
    {
        public const string Repository = "AWS::CodeCommit::Repository";
    }
    public class CodeConnections
    {
        public const string Connection = "AWS::CodeConnections::Connection";
    }
    public class CodeDeploy
    {
        public const string Application = "AWS::CodeDeploy::Application";
        public const string DeploymentConfig = "AWS::CodeDeploy::DeploymentConfig";
        public const string DeploymentGroup = "AWS::CodeDeploy::DeploymentGroup";
    }
    public class CodeGuruProfiler
    {
        public const string ProfilingGroup = "AWS::CodeGuruProfiler::ProfilingGroup";
    }
    public class CodeGuruReviewer
    {
        public const string RepositoryAssociation = "AWS::CodeGuruReviewer::RepositoryAssociation";
    }
    public class CodePipeline
    {
        public const string CustomActionType = "AWS::CodePipeline::CustomActionType";
        public const string Pipeline = "AWS::CodePipeline::Pipeline";
        public const string Webhook = "AWS::CodePipeline::Webhook";
    }
    public class CodeStar
    {
        public const string GitHubRepository = "AWS::CodeStar::GitHubRepository";
    }
    public class CodeStarConnections
    {
        public const string Connection = "AWS::CodeStarConnections::Connection";
        public const string RepositoryLink = "AWS::CodeStarConnections::RepositoryLink";
        public const string SyncConfiguration = "AWS::CodeStarConnections::SyncConfiguration";
    }
    public class CodeStarNotifications
    {
        public const string NotificationRule = "AWS::CodeStarNotifications::NotificationRule";
    }
    public class Cognito
    {
        public const string IdentityPool = "AWS::Cognito::IdentityPool";
        public const string IdentityPoolPrincipalTag = "AWS::Cognito::IdentityPoolPrincipalTag";
        public const string IdentityPoolRoleAttachment = "AWS::Cognito::IdentityPoolRoleAttachment";
        public const string LogDeliveryConfiguration = "AWS::Cognito::LogDeliveryConfiguration";
        public const string UserPool = "AWS::Cognito::UserPool";
        public const string UserPoolClient = "AWS::Cognito::UserPoolClient";
        public const string UserPoolDomain = "AWS::Cognito::UserPoolDomain";
        public const string UserPoolGroup = "AWS::Cognito::UserPoolGroup";
        public const string UserPoolIdentityProvider = "AWS::Cognito::UserPoolIdentityProvider";
        public const string UserPoolResourceServer = "AWS::Cognito::UserPoolResourceServer";
        public const string UserPoolRiskConfigurationAttachment = "AWS::Cognito::UserPoolRiskConfigurationAttachment";
        public const string UserPoolUICustomizationAttachment = "AWS::Cognito::UserPoolUICustomizationAttachment";
        public const string UserPoolUser = "AWS::Cognito::UserPoolUser";
        public const string UserPoolUserToGroupAttachment = "AWS::Cognito::UserPoolUserToGroupAttachment";
    }
    public class Comprehend
    {
        public const string DocumentClassifier = "AWS::Comprehend::DocumentClassifier";
        public const string Flywheel = "AWS::Comprehend::Flywheel";
    }
    public class Config
    {
        public const string AggregationAuthorization = "AWS::Config::AggregationAuthorization";
        public const string ConfigRule = "AWS::Config::ConfigRule";
        public const string ConfigurationAggregator = "AWS::Config::ConfigurationAggregator";
        public const string ConfigurationRecorder = "AWS::Config::ConfigurationRecorder";
        public const string ConformancePack = "AWS::Config::ConformancePack";
        public const string DeliveryChannel = "AWS::Config::DeliveryChannel";
        public const string OrganizationConfigRule = "AWS::Config::OrganizationConfigRule";
        public const string OrganizationConformancePack = "AWS::Config::OrganizationConformancePack";
        public const string RemediationConfiguration = "AWS::Config::RemediationConfiguration";
        public const string StoredQuery = "AWS::Config::StoredQuery";
    }
    public class Connect
    {
        public const string AgentStatus = "AWS::Connect::AgentStatus";
        public const string ApprovedOrigin = "AWS::Connect::ApprovedOrigin";
        public const string ContactFlow = "AWS::Connect::ContactFlow";
        public const string ContactFlowModule = "AWS::Connect::ContactFlowModule";
        public const string EvaluationForm = "AWS::Connect::EvaluationForm";
        public const string HoursOfOperation = "AWS::Connect::HoursOfOperation";
        public const string Instance = "AWS::Connect::Instance";
        public const string InstanceStorageConfig = "AWS::Connect::InstanceStorageConfig";
        public const string IntegrationAssociation = "AWS::Connect::IntegrationAssociation";
        public const string PhoneNumber = "AWS::Connect::PhoneNumber";
        public const string PredefinedAttribute = "AWS::Connect::PredefinedAttribute";
        public const string Prompt = "AWS::Connect::Prompt";
        public const string Queue = "AWS::Connect::Queue";
        public const string QuickConnect = "AWS::Connect::QuickConnect";
        public const string RoutingProfile = "AWS::Connect::RoutingProfile";
        public const string Rule = "AWS::Connect::Rule";
        public const string SecurityKey = "AWS::Connect::SecurityKey";
        public const string SecurityProfile = "AWS::Connect::SecurityProfile";
        public const string TaskTemplate = "AWS::Connect::TaskTemplate";
        public const string TrafficDistributionGroup = "AWS::Connect::TrafficDistributionGroup";
        public const string User = "AWS::Connect::User";
        public const string UserHierarchyGroup = "AWS::Connect::UserHierarchyGroup";
        public const string UserHierarchyStructure = "AWS::Connect::UserHierarchyStructure";
        public const string View = "AWS::Connect::View";
        public const string ViewVersion = "AWS::Connect::ViewVersion";
    }
    public class ConnectCampaigns
    {
        public const string Campaign = "AWS::ConnectCampaigns::Campaign";
    }
    public class ControlTower
    {
        public const string EnabledBaseline = "AWS::ControlTower::EnabledBaseline";
        public const string EnabledControl = "AWS::ControlTower::EnabledControl";
        public const string LandingZone = "AWS::ControlTower::LandingZone";
    }
    public class CustomerProfiles
    {
        public const string CalculatedAttributeDefinition = "AWS::CustomerProfiles::CalculatedAttributeDefinition";
        public const string Domain = "AWS::CustomerProfiles::Domain";
        public const string EventStream = "AWS::CustomerProfiles::EventStream";
        public const string Integration = "AWS::CustomerProfiles::Integration";
        public const string ObjectType = "AWS::CustomerProfiles::ObjectType";
    }
    public class DAX
    {
        public const string Cluster = "AWS::DAX::Cluster";
        public const string ParameterGroup = "AWS::DAX::ParameterGroup";
        public const string SubnetGroup = "AWS::DAX::SubnetGroup";
    }
    public class DLM
    {
        public const string LifecyclePolicy = "AWS::DLM::LifecyclePolicy";
    }
    public class DMS
    {
        public const string Certificate = "AWS::DMS::Certificate";
        public const string DataProvider = "AWS::DMS::DataProvider";
        public const string Endpoint = "AWS::DMS::Endpoint";
        public const string EventSubscription = "AWS::DMS::EventSubscription";
        public const string InstanceProfile = "AWS::DMS::InstanceProfile";
        public const string MigrationProject = "AWS::DMS::MigrationProject";
        public const string ReplicationConfig = "AWS::DMS::ReplicationConfig";
        public const string ReplicationInstance = "AWS::DMS::ReplicationInstance";
        public const string ReplicationSubnetGroup = "AWS::DMS::ReplicationSubnetGroup";
        public const string ReplicationTask = "AWS::DMS::ReplicationTask";
    }
    public class DataBrew
    {
        public const string Dataset = "AWS::DataBrew::Dataset";
        public const string Job = "AWS::DataBrew::Job";
        public const string Project = "AWS::DataBrew::Project";
        public const string Recipe = "AWS::DataBrew::Recipe";
        public const string Ruleset = "AWS::DataBrew::Ruleset";
        public const string Schedule = "AWS::DataBrew::Schedule";
    }
    public class DataPipeline
    {
        public const string Pipeline = "AWS::DataPipeline::Pipeline";
    }
    public class DataSync
    {
        public const string Agent = "AWS::DataSync::Agent";
        public const string LocationAzureBlob = "AWS::DataSync::LocationAzureBlob";
        public const string LocationEFS = "AWS::DataSync::LocationEFS";
        public const string LocationFSxLustre = "AWS::DataSync::LocationFSxLustre";
        public const string LocationFSxONTAP = "AWS::DataSync::LocationFSxONTAP";
        public const string LocationFSxOpenZFS = "AWS::DataSync::LocationFSxOpenZFS";
        public const string LocationFSxWindows = "AWS::DataSync::LocationFSxWindows";
        public const string LocationHDFS = "AWS::DataSync::LocationHDFS";
        public const string LocationNFS = "AWS::DataSync::LocationNFS";
        public const string LocationObjectStorage = "AWS::DataSync::LocationObjectStorage";
        public const string LocationS3 = "AWS::DataSync::LocationS3";
        public const string LocationSMB = "AWS::DataSync::LocationSMB";
        public const string StorageSystem = "AWS::DataSync::StorageSystem";
        public const string Task = "AWS::DataSync::Task";
    }
    public class DataZone
    {
        public const string DataSource = "AWS::DataZone::DataSource";
        public const string Domain = "AWS::DataZone::Domain";
        public const string Environment = "AWS::DataZone::Environment";
        public const string EnvironmentActions = "AWS::DataZone::EnvironmentActions";
        public const string EnvironmentBlueprintConfiguration = "AWS::DataZone::EnvironmentBlueprintConfiguration";
        public const string EnvironmentProfile = "AWS::DataZone::EnvironmentProfile";
        public const string GroupProfile = "AWS::DataZone::GroupProfile";
        public const string Project = "AWS::DataZone::Project";
        public const string ProjectMembership = "AWS::DataZone::ProjectMembership";
        public const string SubscriptionTarget = "AWS::DataZone::SubscriptionTarget";
        public const string UserProfile = "AWS::DataZone::UserProfile";
    }
    public class Deadline
    {
        public const string Farm = "AWS::Deadline::Farm";
        public const string Fleet = "AWS::Deadline::Fleet";
        public const string LicenseEndpoint = "AWS::Deadline::LicenseEndpoint";
        public const string MeteredProduct = "AWS::Deadline::MeteredProduct";
        public const string Monitor = "AWS::Deadline::Monitor";
        public const string Queue = "AWS::Deadline::Queue";
        public const string QueueEnvironment = "AWS::Deadline::QueueEnvironment";
        public const string QueueFleetAssociation = "AWS::Deadline::QueueFleetAssociation";
        public const string StorageProfile = "AWS::Deadline::StorageProfile";
    }
    public class Detective
    {
        public const string Graph = "AWS::Detective::Graph";
        public const string MemberInvitation = "AWS::Detective::MemberInvitation";
        public const string OrganizationAdmin = "AWS::Detective::OrganizationAdmin";
    }
    public class DevOpsGuru
    {
        public const string LogAnomalyDetectionIntegration = "AWS::DevOpsGuru::LogAnomalyDetectionIntegration";
        public const string NotificationChannel = "AWS::DevOpsGuru::NotificationChannel";
        public const string ResourceCollection = "AWS::DevOpsGuru::ResourceCollection";
    }
    public class DirectoryService
    {
        public const string MicrosoftAD = "AWS::DirectoryService::MicrosoftAD";
        public const string SimpleAD = "AWS::DirectoryService::SimpleAD";
    }
    public class DocDB
    {
        public const string DBCluster = "AWS::DocDB::DBCluster";
        public const string DBClusterParameterGroup = "AWS::DocDB::DBClusterParameterGroup";
        public const string DBInstance = "AWS::DocDB::DBInstance";
        public const string DBSubnetGroup = "AWS::DocDB::DBSubnetGroup";
        public const string EventSubscription = "AWS::DocDB::EventSubscription";
    }
    public class DocDBElastic
    {
        public const string Cluster = "AWS::DocDBElastic::Cluster";
    }
    public class DynamoDB
    {
        public const string GlobalTable = "AWS::DynamoDB::GlobalTable";
        public const string Table = "AWS::DynamoDB::Table";
    }
    public class EC2
    {
        public const string CapacityReservation = "AWS::EC2::CapacityReservation";
        public const string CapacityReservationFleet = "AWS::EC2::CapacityReservationFleet";
        public const string CarrierGateway = "AWS::EC2::CarrierGateway";
        public const string ClientVpnAuthorizationRule = "AWS::EC2::ClientVpnAuthorizationRule";
        public const string ClientVpnEndpoint = "AWS::EC2::ClientVpnEndpoint";
        public const string ClientVpnRoute = "AWS::EC2::ClientVpnRoute";
        public const string ClientVpnTargetNetworkAssociation = "AWS::EC2::ClientVpnTargetNetworkAssociation";
        public const string CustomerGateway = "AWS::EC2::CustomerGateway";
        public const string DHCPOptions = "AWS::EC2::DHCPOptions";
        public const string EC2Fleet = "AWS::EC2::EC2Fleet";
        public const string EIP = "AWS::EC2::EIP";
        public const string EIPAssociation = "AWS::EC2::EIPAssociation";
        public const string EgressOnlyInternetGateway = "AWS::EC2::EgressOnlyInternetGateway";
        public const string EnclaveCertificateIamRoleAssociation = "AWS::EC2::EnclaveCertificateIamRoleAssociation";
        public const string FlowLog = "AWS::EC2::FlowLog";
        public const string GatewayRouteTableAssociation = "AWS::EC2::GatewayRouteTableAssociation";
        public const string Host = "AWS::EC2::Host";
        public const string IPAM = "AWS::EC2::IPAM";
        public const string IPAMAllocation = "AWS::EC2::IPAMAllocation";
        public const string IPAMPool = "AWS::EC2::IPAMPool";
        public const string IPAMPoolCidr = "AWS::EC2::IPAMPoolCidr";
        public const string IPAMResourceDiscovery = "AWS::EC2::IPAMResourceDiscovery";
        public const string IPAMResourceDiscoveryAssociation = "AWS::EC2::IPAMResourceDiscoveryAssociation";
        public const string IPAMScope = "AWS::EC2::IPAMScope";
        public const string Instance = "AWS::EC2::Instance";
        public const string InstanceConnectEndpoint = "AWS::EC2::InstanceConnectEndpoint";
        public const string InternetGateway = "AWS::EC2::InternetGateway";
        public const string KeyPair = "AWS::EC2::KeyPair";
        public const string LaunchTemplate = "AWS::EC2::LaunchTemplate";
        public const string LocalGatewayRoute = "AWS::EC2::LocalGatewayRoute";
        public const string LocalGatewayRouteTable = "AWS::EC2::LocalGatewayRouteTable";
        public const string LocalGatewayRouteTableVPCAssociation = "AWS::EC2::LocalGatewayRouteTableVPCAssociation";
        public const string LocalGatewayRouteTableVirtualInterfaceGroupAssociation = "AWS::EC2::LocalGatewayRouteTableVirtualInterfaceGroupAssociation";
        public const string NatGateway = "AWS::EC2::NatGateway";
        public const string NetworkAcl = "AWS::EC2::NetworkAcl";
        public const string NetworkAclEntry = "AWS::EC2::NetworkAclEntry";
        public const string NetworkInsightsAccessScope = "AWS::EC2::NetworkInsightsAccessScope";
        public const string NetworkInsightsAccessScopeAnalysis = "AWS::EC2::NetworkInsightsAccessScopeAnalysis";
        public const string NetworkInsightsAnalysis = "AWS::EC2::NetworkInsightsAnalysis";
        public const string NetworkInsightsPath = "AWS::EC2::NetworkInsightsPath";
        public const string NetworkInterface = "AWS::EC2::NetworkInterface";
        public const string NetworkInterfaceAttachment = "AWS::EC2::NetworkInterfaceAttachment";
        public const string NetworkInterfacePermission = "AWS::EC2::NetworkInterfacePermission";
        public const string NetworkPerformanceMetricSubscription = "AWS::EC2::NetworkPerformanceMetricSubscription";
        public const string PlacementGroup = "AWS::EC2::PlacementGroup";
        public const string PrefixList = "AWS::EC2::PrefixList";
        public const string Route = "AWS::EC2::Route";
        public const string RouteTable = "AWS::EC2::RouteTable";
        public const string SecurityGroup = "AWS::EC2::SecurityGroup";
        public const string SecurityGroupEgress = "AWS::EC2::SecurityGroupEgress";
        public const string SecurityGroupIngress = "AWS::EC2::SecurityGroupIngress";
        public const string SnapshotBlockPublicAccess = "AWS::EC2::SnapshotBlockPublicAccess";
        public const string SpotFleet = "AWS::EC2::SpotFleet";
        public const string Subnet = "AWS::EC2::Subnet";
        public const string SubnetCidrBlock = "AWS::EC2::SubnetCidrBlock";
        public const string SubnetNetworkAclAssociation = "AWS::EC2::SubnetNetworkAclAssociation";
        public const string SubnetRouteTableAssociation = "AWS::EC2::SubnetRouteTableAssociation";
        public const string TrafficMirrorFilter = "AWS::EC2::TrafficMirrorFilter";
        public const string TrafficMirrorFilterRule = "AWS::EC2::TrafficMirrorFilterRule";
        public const string TrafficMirrorSession = "AWS::EC2::TrafficMirrorSession";
        public const string TrafficMirrorTarget = "AWS::EC2::TrafficMirrorTarget";
        public const string TransitGateway = "AWS::EC2::TransitGateway";
        public const string TransitGatewayAttachment = "AWS::EC2::TransitGatewayAttachment";
        public const string TransitGatewayConnect = "AWS::EC2::TransitGatewayConnect";
        public const string TransitGatewayMulticastDomain = "AWS::EC2::TransitGatewayMulticastDomain";
        public const string TransitGatewayMulticastDomainAssociation = "AWS::EC2::TransitGatewayMulticastDomainAssociation";
        public const string TransitGatewayMulticastGroupMember = "AWS::EC2::TransitGatewayMulticastGroupMember";
        public const string TransitGatewayMulticastGroupSource = "AWS::EC2::TransitGatewayMulticastGroupSource";
        public const string TransitGatewayPeeringAttachment = "AWS::EC2::TransitGatewayPeeringAttachment";
        public const string TransitGatewayRoute = "AWS::EC2::TransitGatewayRoute";
        public const string TransitGatewayRouteTable = "AWS::EC2::TransitGatewayRouteTable";
        public const string TransitGatewayRouteTableAssociation = "AWS::EC2::TransitGatewayRouteTableAssociation";
        public const string TransitGatewayRouteTablePropagation = "AWS::EC2::TransitGatewayRouteTablePropagation";
        public const string TransitGatewayVpcAttachment = "AWS::EC2::TransitGatewayVpcAttachment";
        public const string VPC = "AWS::EC2::VPC";
        public const string VPCCidrBlock = "AWS::EC2::VPCCidrBlock";
        public const string VPCDHCPOptionsAssociation = "AWS::EC2::VPCDHCPOptionsAssociation";
        public const string VPCEndpoint = "AWS::EC2::VPCEndpoint";
        public const string VPCEndpointConnectionNotification = "AWS::EC2::VPCEndpointConnectionNotification";
        public const string VPCEndpointService = "AWS::EC2::VPCEndpointService";
        public const string VPCEndpointServicePermissions = "AWS::EC2::VPCEndpointServicePermissions";
        public const string VPCGatewayAttachment = "AWS::EC2::VPCGatewayAttachment";
        public const string VPCPeeringConnection = "AWS::EC2::VPCPeeringConnection";
        public const string VPNConnection = "AWS::EC2::VPNConnection";
        public const string VPNConnectionRoute = "AWS::EC2::VPNConnectionRoute";
        public const string VPNGateway = "AWS::EC2::VPNGateway";
        public const string VPNGatewayRoutePropagation = "AWS::EC2::VPNGatewayRoutePropagation";
        public const string VerifiedAccessEndpoint = "AWS::EC2::VerifiedAccessEndpoint";
        public const string VerifiedAccessGroup = "AWS::EC2::VerifiedAccessGroup";
        public const string VerifiedAccessInstance = "AWS::EC2::VerifiedAccessInstance";
        public const string VerifiedAccessTrustProvider = "AWS::EC2::VerifiedAccessTrustProvider";
        public const string Volume = "AWS::EC2::Volume";
        public const string VolumeAttachment = "AWS::EC2::VolumeAttachment";
    }
    public class ECR
    {
        public const string PublicRepository = "AWS::ECR::PublicRepository";
        public const string PullThroughCacheRule = "AWS::ECR::PullThroughCacheRule";
        public const string RegistryPolicy = "AWS::ECR::RegistryPolicy";
        public const string ReplicationConfiguration = "AWS::ECR::ReplicationConfiguration";
        public const string Repository = "AWS::ECR::Repository";
        public const string RepositoryCreationTemplate = "AWS::ECR::RepositoryCreationTemplate";
    }
    public class ECS
    {
        public const string CapacityProvider = "AWS::ECS::CapacityProvider";
        public const string Cluster = "AWS::ECS::Cluster";
        public const string ClusterCapacityProviderAssociations = "AWS::ECS::ClusterCapacityProviderAssociations";
        public const string PrimaryTaskSet = "AWS::ECS::PrimaryTaskSet";
        public const string Service = "AWS::ECS::Service";
        public const string TaskDefinition = "AWS::ECS::TaskDefinition";
        public const string TaskSet = "AWS::ECS::TaskSet";
    }
    public class EFS
    {
        public const string AccessPoint = "AWS::EFS::AccessPoint";
        public const string FileSystem = "AWS::EFS::FileSystem";
        public const string MountTarget = "AWS::EFS::MountTarget";
    }
    public class EKS
    {
        public const string AccessEntry = "AWS::EKS::AccessEntry";
        public const string Addon = "AWS::EKS::Addon";
        public const string Cluster = "AWS::EKS::Cluster";
        public const string FargateProfile = "AWS::EKS::FargateProfile";
        public const string IdentityProviderConfig = "AWS::EKS::IdentityProviderConfig";
        public const string Nodegroup = "AWS::EKS::Nodegroup";
        public const string PodIdentityAssociation = "AWS::EKS::PodIdentityAssociation";
    }
    public class EMR
    {
        public const string Cluster = "AWS::EMR::Cluster";
        public const string InstanceFleetConfig = "AWS::EMR::InstanceFleetConfig";
        public const string InstanceGroupConfig = "AWS::EMR::InstanceGroupConfig";
        public const string SecurityConfiguration = "AWS::EMR::SecurityConfiguration";
        public const string Step = "AWS::EMR::Step";
        public const string Studio = "AWS::EMR::Studio";
        public const string StudioSessionMapping = "AWS::EMR::StudioSessionMapping";
        public const string WALWorkspace = "AWS::EMR::WALWorkspace";
    }
    public class EMRContainers
    {
        public const string VirtualCluster = "AWS::EMRContainers::VirtualCluster";
    }
    public class EMRServerless
    {
        public const string Application = "AWS::EMRServerless::Application";
    }
    public class ElastiCache
    {
        public const string CacheCluster = "AWS::ElastiCache::CacheCluster";
        public const string GlobalReplicationGroup = "AWS::ElastiCache::GlobalReplicationGroup";
        public const string ParameterGroup = "AWS::ElastiCache::ParameterGroup";
        public const string ReplicationGroup = "AWS::ElastiCache::ReplicationGroup";
        public const string SecurityGroup = "AWS::ElastiCache::SecurityGroup";
        public const string SecurityGroupIngress = "AWS::ElastiCache::SecurityGroupIngress";
        public const string ServerlessCache = "AWS::ElastiCache::ServerlessCache";
        public const string SubnetGroup = "AWS::ElastiCache::SubnetGroup";
        public const string User = "AWS::ElastiCache::User";
        public const string UserGroup = "AWS::ElastiCache::UserGroup";
    }
    public class ElasticBeanstalk
    {
        public const string Application = "AWS::ElasticBeanstalk::Application";
        public const string ApplicationVersion = "AWS::ElasticBeanstalk::ApplicationVersion";
        public const string ConfigurationTemplate = "AWS::ElasticBeanstalk::ConfigurationTemplate";
        public const string Environment = "AWS::ElasticBeanstalk::Environment";
    }
    public class ElasticLoadBalancing
    {
        public const string LoadBalancer = "AWS::ElasticLoadBalancing::LoadBalancer";
    }
    public class ElasticLoadBalancingV2
    {
        public const string Listener = "AWS::ElasticLoadBalancingV2::Listener";
        public const string ListenerCertificate = "AWS::ElasticLoadBalancingV2::ListenerCertificate";
        public const string ListenerRule = "AWS::ElasticLoadBalancingV2::ListenerRule";
        public const string LoadBalancer = "AWS::ElasticLoadBalancingV2::LoadBalancer";
        public const string TargetGroup = "AWS::ElasticLoadBalancingV2::TargetGroup";
        public const string TrustStore = "AWS::ElasticLoadBalancingV2::TrustStore";
        public const string TrustStoreRevocation = "AWS::ElasticLoadBalancingV2::TrustStoreRevocation";
    }
    public class Elasticsearch
    {
        public const string Domain = "AWS::Elasticsearch::Domain";
    }
    public class EntityResolution
    {
        public const string IdMappingWorkflow = "AWS::EntityResolution::IdMappingWorkflow";
        public const string IdNamespace = "AWS::EntityResolution::IdNamespace";
        public const string MatchingWorkflow = "AWS::EntityResolution::MatchingWorkflow";
        public const string PolicyStatement = "AWS::EntityResolution::PolicyStatement";
        public const string SchemaMapping = "AWS::EntityResolution::SchemaMapping";
    }
    public class EventSchemas
    {
        public const string Discoverer = "AWS::EventSchemas::Discoverer";
        public const string Registry = "AWS::EventSchemas::Registry";
        public const string RegistryPolicy = "AWS::EventSchemas::RegistryPolicy";
        public const string Schema = "AWS::EventSchemas::Schema";
    }
    public class Events
    {
        public const string ApiDestination = "AWS::Events::ApiDestination";
        public const string Archive = "AWS::Events::Archive";
        public const string Connection = "AWS::Events::Connection";
        public const string Endpoint = "AWS::Events::Endpoint";
        public const string EventBus = "AWS::Events::EventBus";
        public const string EventBusPolicy = "AWS::Events::EventBusPolicy";
        public const string Rule = "AWS::Events::Rule";
    }
    public class Evidently
    {
        public const string Experiment = "AWS::Evidently::Experiment";
        public const string Feature = "AWS::Evidently::Feature";
        public const string Launch = "AWS::Evidently::Launch";
        public const string Project = "AWS::Evidently::Project";
        public const string Segment = "AWS::Evidently::Segment";
    }
    public class FIS
    {
        public const string ExperimentTemplate = "AWS::FIS::ExperimentTemplate";
        public const string TargetAccountConfiguration = "AWS::FIS::TargetAccountConfiguration";
    }
    public class FMS
    {
        public const string NotificationChannel = "AWS::FMS::NotificationChannel";
        public const string Policy = "AWS::FMS::Policy";
        public const string ResourceSet = "AWS::FMS::ResourceSet";
    }
    public class FSx
    {
        public const string DataRepositoryAssociation = "AWS::FSx::DataRepositoryAssociation";
        public const string FileSystem = "AWS::FSx::FileSystem";
        public const string Snapshot = "AWS::FSx::Snapshot";
        public const string StorageVirtualMachine = "AWS::FSx::StorageVirtualMachine";
        public const string Volume = "AWS::FSx::Volume";
    }
    public class FinSpace
    {
        public const string Environment = "AWS::FinSpace::Environment";
    }
    public class Forecast
    {
        public const string Dataset = "AWS::Forecast::Dataset";
        public const string DatasetGroup = "AWS::Forecast::DatasetGroup";
    }
    public class FraudDetector
    {
        public const string Detector = "AWS::FraudDetector::Detector";
        public const string EntityType = "AWS::FraudDetector::EntityType";
        public const string EventType = "AWS::FraudDetector::EventType";
        public const string Label = "AWS::FraudDetector::Label";
        public const string List = "AWS::FraudDetector::List";
        public const string Outcome = "AWS::FraudDetector::Outcome";
        public const string Variable = "AWS::FraudDetector::Variable";
    }
    public class GameLift
    {
        public const string Alias = "AWS::GameLift::Alias";
        public const string Build = "AWS::GameLift::Build";
        public const string ContainerGroupDefinition = "AWS::GameLift::ContainerGroupDefinition";
        public const string Fleet = "AWS::GameLift::Fleet";
        public const string GameServerGroup = "AWS::GameLift::GameServerGroup";
        public const string GameSessionQueue = "AWS::GameLift::GameSessionQueue";
        public const string Location = "AWS::GameLift::Location";
        public const string MatchmakingConfiguration = "AWS::GameLift::MatchmakingConfiguration";
        public const string MatchmakingRuleSet = "AWS::GameLift::MatchmakingRuleSet";
        public const string Script = "AWS::GameLift::Script";
    }
    public class GlobalAccelerator
    {
        public const string Accelerator = "AWS::GlobalAccelerator::Accelerator";
        public const string CrossAccountAttachment = "AWS::GlobalAccelerator::CrossAccountAttachment";
        public const string EndpointGroup = "AWS::GlobalAccelerator::EndpointGroup";
        public const string Listener = "AWS::GlobalAccelerator::Listener";
    }
    public class Glue
    {
        public const string Classifier = "AWS::Glue::Classifier";
        public const string Connection = "AWS::Glue::Connection";
        public const string Crawler = "AWS::Glue::Crawler";
        public const string CustomEntityType = "AWS::Glue::CustomEntityType";
        public const string DataCatalogEncryptionSettings = "AWS::Glue::DataCatalogEncryptionSettings";
        public const string DataQualityRuleset = "AWS::Glue::DataQualityRuleset";
        public const string Database = "AWS::Glue::Database";
        public const string DevEndpoint = "AWS::Glue::DevEndpoint";
        public const string Job = "AWS::Glue::Job";
        public const string MLTransform = "AWS::Glue::MLTransform";
        public const string Partition = "AWS::Glue::Partition";
        public const string Registry = "AWS::Glue::Registry";
        public const string Schema = "AWS::Glue::Schema";
        public const string SchemaVersion = "AWS::Glue::SchemaVersion";
        public const string SchemaVersionMetadata = "AWS::Glue::SchemaVersionMetadata";
        public const string SecurityConfiguration = "AWS::Glue::SecurityConfiguration";
        public const string Table = "AWS::Glue::Table";
        public const string TableOptimizer = "AWS::Glue::TableOptimizer";
        public const string Trigger = "AWS::Glue::Trigger";
        public const string UsageProfile = "AWS::Glue::UsageProfile";
        public const string Workflow = "AWS::Glue::Workflow";
    }
    public class Grafana
    {
        public const string Workspace = "AWS::Grafana::Workspace";
    }
    public class Greengrass
    {
        public const string ConnectorDefinition = "AWS::Greengrass::ConnectorDefinition";
        public const string ConnectorDefinitionVersion = "AWS::Greengrass::ConnectorDefinitionVersion";
        public const string CoreDefinition = "AWS::Greengrass::CoreDefinition";
        public const string CoreDefinitionVersion = "AWS::Greengrass::CoreDefinitionVersion";
        public const string DeviceDefinition = "AWS::Greengrass::DeviceDefinition";
        public const string DeviceDefinitionVersion = "AWS::Greengrass::DeviceDefinitionVersion";
        public const string FunctionDefinition = "AWS::Greengrass::FunctionDefinition";
        public const string FunctionDefinitionVersion = "AWS::Greengrass::FunctionDefinitionVersion";
        public const string Group = "AWS::Greengrass::Group";
        public const string GroupVersion = "AWS::Greengrass::GroupVersion";
        public const string LoggerDefinition = "AWS::Greengrass::LoggerDefinition";
        public const string LoggerDefinitionVersion = "AWS::Greengrass::LoggerDefinitionVersion";
        public const string ResourceDefinition = "AWS::Greengrass::ResourceDefinition";
        public const string ResourceDefinitionVersion = "AWS::Greengrass::ResourceDefinitionVersion";
        public const string SubscriptionDefinition = "AWS::Greengrass::SubscriptionDefinition";
        public const string SubscriptionDefinitionVersion = "AWS::Greengrass::SubscriptionDefinitionVersion";
    }
    public class GreengrassV2
    {
        public const string ComponentVersion = "AWS::GreengrassV2::ComponentVersion";
        public const string Deployment = "AWS::GreengrassV2::Deployment";
    }
    public class GroundStation
    {
        public const string Config = "AWS::GroundStation::Config";
        public const string DataflowEndpointGroup = "AWS::GroundStation::DataflowEndpointGroup";
        public const string MissionProfile = "AWS::GroundStation::MissionProfile";
    }
    public class GuardDuty
    {
        public const string Detector = "AWS::GuardDuty::Detector";
        public const string Filter = "AWS::GuardDuty::Filter";
        public const string IPSet = "AWS::GuardDuty::IPSet";
        public const string MalwareProtectionPlan = "AWS::GuardDuty::MalwareProtectionPlan";
        public const string Master = "AWS::GuardDuty::Master";
        public const string Member = "AWS::GuardDuty::Member";
        public const string ThreatIntelSet = "AWS::GuardDuty::ThreatIntelSet";
    }
    public class HealthImaging
    {
        public const string Datastore = "AWS::HealthImaging::Datastore";
    }
    public class HealthLake
    {
        public const string FHIRDatastore = "AWS::HealthLake::FHIRDatastore";
    }
    public class IAM
    {
        public const string AccessKey = "AWS::IAM::AccessKey";
        public const string Group = "AWS::IAM::Group";
        public const string GroupPolicy = "AWS::IAM::GroupPolicy";
        public const string InstanceProfile = "AWS::IAM::InstanceProfile";
        public const string ManagedPolicy = "AWS::IAM::ManagedPolicy";
        public const string OIDCProvider = "AWS::IAM::OIDCProvider";
        public const string Policy = "AWS::IAM::Policy";
        public const string Role = "AWS::IAM::Role";
        public const string RolePolicy = "AWS::IAM::RolePolicy";
        public const string SAMLProvider = "AWS::IAM::SAMLProvider";
        public const string ServerCertificate = "AWS::IAM::ServerCertificate";
        public const string ServiceLinkedRole = "AWS::IAM::ServiceLinkedRole";
        public const string User = "AWS::IAM::User";
        public const string UserPolicy = "AWS::IAM::UserPolicy";
        public const string UserToGroupAddition = "AWS::IAM::UserToGroupAddition";
        public const string VirtualMFADevice = "AWS::IAM::VirtualMFADevice";
    }
    public class IVS
    {
        public const string Channel = "AWS::IVS::Channel";
        public const string EncoderConfiguration = "AWS::IVS::EncoderConfiguration";
        public const string PlaybackKeyPair = "AWS::IVS::PlaybackKeyPair";
        public const string PlaybackRestrictionPolicy = "AWS::IVS::PlaybackRestrictionPolicy";
        public const string PublicKey = "AWS::IVS::PublicKey";
        public const string RecordingConfiguration = "AWS::IVS::RecordingConfiguration";
        public const string Stage = "AWS::IVS::Stage";
        public const string StorageConfiguration = "AWS::IVS::StorageConfiguration";
        public const string StreamKey = "AWS::IVS::StreamKey";
    }
    public class IVSChat
    {
        public const string LoggingConfiguration = "AWS::IVSChat::LoggingConfiguration";
        public const string Room = "AWS::IVSChat::Room";
    }
    public class IdentityStore
    {
        public const string Group = "AWS::IdentityStore::Group";
        public const string GroupMembership = "AWS::IdentityStore::GroupMembership";
    }
    public class ImageBuilder
    {
        public const string Component = "AWS::ImageBuilder::Component";
        public const string ContainerRecipe = "AWS::ImageBuilder::ContainerRecipe";
        public const string DistributionConfiguration = "AWS::ImageBuilder::DistributionConfiguration";
        public const string Image = "AWS::ImageBuilder::Image";
        public const string ImagePipeline = "AWS::ImageBuilder::ImagePipeline";
        public const string ImageRecipe = "AWS::ImageBuilder::ImageRecipe";
        public const string InfrastructureConfiguration = "AWS::ImageBuilder::InfrastructureConfiguration";
        public const string LifecyclePolicy = "AWS::ImageBuilder::LifecyclePolicy";
        public const string Workflow = "AWS::ImageBuilder::Workflow";
    }
    public class Inspector
    {
        public const string AssessmentTarget = "AWS::Inspector::AssessmentTarget";
        public const string AssessmentTemplate = "AWS::Inspector::AssessmentTemplate";
        public const string ResourceGroup = "AWS::Inspector::ResourceGroup";
    }
    public class InspectorV2
    {
        public const string CisScanConfiguration = "AWS::InspectorV2::CisScanConfiguration";
        public const string Filter = "AWS::InspectorV2::Filter";
    }
    public class InternetMonitor
    {
        public const string Monitor = "AWS::InternetMonitor::Monitor";
    }
    public class IoT1Click
    {
        public const string Device = "AWS::IoT1Click::Device";
        public const string Placement = "AWS::IoT1Click::Placement";
        public const string Project = "AWS::IoT1Click::Project";
    }
    public class IoT
    {
        public const string AccountAuditConfiguration = "AWS::IoT::AccountAuditConfiguration";
        public const string Authorizer = "AWS::IoT::Authorizer";
        public const string BillingGroup = "AWS::IoT::BillingGroup";
        public const string CACertificate = "AWS::IoT::CACertificate";
        public const string Certificate = "AWS::IoT::Certificate";
        public const string CertificateProvider = "AWS::IoT::CertificateProvider";
        public const string CustomMetric = "AWS::IoT::CustomMetric";
        public const string Dimension = "AWS::IoT::Dimension";
        public const string DomainConfiguration = "AWS::IoT::DomainConfiguration";
        public const string FleetMetric = "AWS::IoT::FleetMetric";
        public const string JobTemplate = "AWS::IoT::JobTemplate";
        public const string Logging = "AWS::IoT::Logging";
        public const string MitigationAction = "AWS::IoT::MitigationAction";
        public const string Policy = "AWS::IoT::Policy";
        public const string PolicyPrincipalAttachment = "AWS::IoT::PolicyPrincipalAttachment";
        public const string ProvisioningTemplate = "AWS::IoT::ProvisioningTemplate";
        public const string ResourceSpecificLogging = "AWS::IoT::ResourceSpecificLogging";
        public const string RoleAlias = "AWS::IoT::RoleAlias";
        public const string ScheduledAudit = "AWS::IoT::ScheduledAudit";
        public const string SecurityProfile = "AWS::IoT::SecurityProfile";
        public const string SoftwarePackage = "AWS::IoT::SoftwarePackage";
        public const string SoftwarePackageVersion = "AWS::IoT::SoftwarePackageVersion";
        public const string Thing = "AWS::IoT::Thing";
        public const string ThingGroup = "AWS::IoT::ThingGroup";
        public const string ThingPrincipalAttachment = "AWS::IoT::ThingPrincipalAttachment";
        public const string ThingType = "AWS::IoT::ThingType";
        public const string TopicRule = "AWS::IoT::TopicRule";
        public const string TopicRuleDestination = "AWS::IoT::TopicRuleDestination";
    }
    public class IoTAnalytics
    {
        public const string Channel = "AWS::IoTAnalytics::Channel";
        public const string Dataset = "AWS::IoTAnalytics::Dataset";
        public const string Datastore = "AWS::IoTAnalytics::Datastore";
        public const string Pipeline = "AWS::IoTAnalytics::Pipeline";
    }
    public class IoTCoreDeviceAdvisor
    {
        public const string SuiteDefinition = "AWS::IoTCoreDeviceAdvisor::SuiteDefinition";
    }
    public class IoTEvents
    {
        public const string AlarmModel = "AWS::IoTEvents::AlarmModel";
        public const string DetectorModel = "AWS::IoTEvents::DetectorModel";
        public const string Input = "AWS::IoTEvents::Input";
    }
    public class IoTFleetHub
    {
        public const string Application = "AWS::IoTFleetHub::Application";
    }
    public class IoTFleetWise
    {
        public const string Campaign = "AWS::IoTFleetWise::Campaign";
        public const string DecoderManifest = "AWS::IoTFleetWise::DecoderManifest";
        public const string Fleet = "AWS::IoTFleetWise::Fleet";
        public const string ModelManifest = "AWS::IoTFleetWise::ModelManifest";
        public const string SignalCatalog = "AWS::IoTFleetWise::SignalCatalog";
        public const string Vehicle = "AWS::IoTFleetWise::Vehicle";
    }
    public class IoTSiteWise
    {
        public const string AccessPolicy = "AWS::IoTSiteWise::AccessPolicy";
        public const string Asset = "AWS::IoTSiteWise::Asset";
        public const string AssetModel = "AWS::IoTSiteWise::AssetModel";
        public const string Dashboard = "AWS::IoTSiteWise::Dashboard";
        public const string Gateway = "AWS::IoTSiteWise::Gateway";
        public const string Portal = "AWS::IoTSiteWise::Portal";
        public const string Project = "AWS::IoTSiteWise::Project";
    }
    public class IoTThingsGraph
    {
        public const string FlowTemplate = "AWS::IoTThingsGraph::FlowTemplate";
    }
    public class IoTTwinMaker
    {
        public const string ComponentType = "AWS::IoTTwinMaker::ComponentType";
        public const string Entity = "AWS::IoTTwinMaker::Entity";
        public const string Scene = "AWS::IoTTwinMaker::Scene";
        public const string SyncJob = "AWS::IoTTwinMaker::SyncJob";
        public const string Workspace = "AWS::IoTTwinMaker::Workspace";
    }
    public class IoTWireless
    {
        public const string Destination = "AWS::IoTWireless::Destination";
        public const string DeviceProfile = "AWS::IoTWireless::DeviceProfile";
        public const string FuotaTask = "AWS::IoTWireless::FuotaTask";
        public const string MulticastGroup = "AWS::IoTWireless::MulticastGroup";
        public const string NetworkAnalyzerConfiguration = "AWS::IoTWireless::NetworkAnalyzerConfiguration";
        public const string PartnerAccount = "AWS::IoTWireless::PartnerAccount";
        public const string ServiceProfile = "AWS::IoTWireless::ServiceProfile";
        public const string TaskDefinition = "AWS::IoTWireless::TaskDefinition";
        public const string WirelessDevice = "AWS::IoTWireless::WirelessDevice";
        public const string WirelessDeviceImportTask = "AWS::IoTWireless::WirelessDeviceImportTask";
        public const string WirelessGateway = "AWS::IoTWireless::WirelessGateway";
    }
    public class KMS
    {
        public const string Alias = "AWS::KMS::Alias";
        public const string Key = "AWS::KMS::Key";
        public const string ReplicaKey = "AWS::KMS::ReplicaKey";
    }
    public class KafkaConnect
    {
        public const string Connector = "AWS::KafkaConnect::Connector";
        public const string CustomPlugin = "AWS::KafkaConnect::CustomPlugin";
        public const string WorkerConfiguration = "AWS::KafkaConnect::WorkerConfiguration";
    }
    public class Kendra
    {
        public const string DataSource = "AWS::Kendra::DataSource";
        public const string Faq = "AWS::Kendra::Faq";
        public const string Index = "AWS::Kendra::Index";
    }
    public class KendraRanking
    {
        public const string ExecutionPlan = "AWS::KendraRanking::ExecutionPlan";
    }
    public class Kinesis
    {
        public const string ResourcePolicy = "AWS::Kinesis::ResourcePolicy";
        public const string Stream = "AWS::Kinesis::Stream";
        public const string StreamConsumer = "AWS::Kinesis::StreamConsumer";
    }
    public class KinesisAnalytics
    {
        public const string Application = "AWS::KinesisAnalytics::Application";
        public const string ApplicationOutput = "AWS::KinesisAnalytics::ApplicationOutput";
        public const string ApplicationReferenceDataSource = "AWS::KinesisAnalytics::ApplicationReferenceDataSource";
    }
    public class KinesisAnalyticsV2
    {
        public const string Application = "AWS::KinesisAnalyticsV2::Application";
        public const string ApplicationCloudWatchLoggingOption = "AWS::KinesisAnalyticsV2::ApplicationCloudWatchLoggingOption";
        public const string ApplicationOutput = "AWS::KinesisAnalyticsV2::ApplicationOutput";
        public const string ApplicationReferenceDataSource = "AWS::KinesisAnalyticsV2::ApplicationReferenceDataSource";
    }
    public class KinesisFirehose
    {
        public const string DeliveryStream = "AWS::KinesisFirehose::DeliveryStream";
    }
    public class KinesisVideo
    {
        public const string SignalingChannel = "AWS::KinesisVideo::SignalingChannel";
        public const string Stream = "AWS::KinesisVideo::Stream";
    }
    public class LakeFormation
    {
        public const string DataCellsFilter = "AWS::LakeFormation::DataCellsFilter";
        public const string DataLakeSettings = "AWS::LakeFormation::DataLakeSettings";
        public const string Permissions = "AWS::LakeFormation::Permissions";
        public const string PrincipalPermissions = "AWS::LakeFormation::PrincipalPermissions";
        public const string Resource = "AWS::LakeFormation::Resource";
        public const string Tag = "AWS::LakeFormation::Tag";
        public const string TagAssociation = "AWS::LakeFormation::TagAssociation";
    }
    public class Lambda
    {
        public const string Alias = "AWS::Lambda::Alias";
        public const string CodeSigningConfig = "AWS::Lambda::CodeSigningConfig";
        public const string EventInvokeConfig = "AWS::Lambda::EventInvokeConfig";
        public const string EventSourceMapping = "AWS::Lambda::EventSourceMapping";
        public const string Function = "AWS::Lambda::Function";
        public const string LayerVersion = "AWS::Lambda::LayerVersion";
        public const string LayerVersionPermission = "AWS::Lambda::LayerVersionPermission";
        public const string Permission = "AWS::Lambda::Permission";
        public const string Url = "AWS::Lambda::Url";
        public const string Version = "AWS::Lambda::Version";
    }
    public class LaunchWizard
    {
        public const string Deployment = "AWS::LaunchWizard::Deployment";
    }
    public class Lex
    {
        public const string Bot = "AWS::Lex::Bot";
        public const string BotAlias = "AWS::Lex::BotAlias";
        public const string BotVersion = "AWS::Lex::BotVersion";
        public const string ResourcePolicy = "AWS::Lex::ResourcePolicy";
    }
    public class LicenseManager
    {
        public const string Grant = "AWS::LicenseManager::Grant";
        public const string License = "AWS::LicenseManager::License";
    }
    public class Lightsail
    {
        public const string Alarm = "AWS::Lightsail::Alarm";
        public const string Bucket = "AWS::Lightsail::Bucket";
        public const string Certificate = "AWS::Lightsail::Certificate";
        public const string Container = "AWS::Lightsail::Container";
        public const string Database = "AWS::Lightsail::Database";
        public const string Disk = "AWS::Lightsail::Disk";
        public const string Distribution = "AWS::Lightsail::Distribution";
        public const string Instance = "AWS::Lightsail::Instance";
        public const string LoadBalancer = "AWS::Lightsail::LoadBalancer";
        public const string LoadBalancerTlsCertificate = "AWS::Lightsail::LoadBalancerTlsCertificate";
        public const string StaticIp = "AWS::Lightsail::StaticIp";
    }
    public class Location
    {
        public const string APIKey = "AWS::Location::APIKey";
        public const string GeofenceCollection = "AWS::Location::GeofenceCollection";
        public const string Map = "AWS::Location::Map";
        public const string PlaceIndex = "AWS::Location::PlaceIndex";
        public const string RouteCalculator = "AWS::Location::RouteCalculator";
        public const string Tracker = "AWS::Location::Tracker";
        public const string TrackerConsumer = "AWS::Location::TrackerConsumer";
    }
    public class Logs
    {
        public const string AccountPolicy = "AWS::Logs::AccountPolicy";
        public const string Delivery = "AWS::Logs::Delivery";
        public const string DeliveryDestination = "AWS::Logs::DeliveryDestination";
        public const string DeliverySource = "AWS::Logs::DeliverySource";
        public const string Destination = "AWS::Logs::Destination";
        public const string LogAnomalyDetector = "AWS::Logs::LogAnomalyDetector";
        public const string LogGroup = "AWS::Logs::LogGroup";
        public const string LogStream = "AWS::Logs::LogStream";
        public const string MetricFilter = "AWS::Logs::MetricFilter";
        public const string QueryDefinition = "AWS::Logs::QueryDefinition";
        public const string ResourcePolicy = "AWS::Logs::ResourcePolicy";
        public const string SubscriptionFilter = "AWS::Logs::SubscriptionFilter";
    }
    public class LookoutEquipment
    {
        public const string InferenceScheduler = "AWS::LookoutEquipment::InferenceScheduler";
    }
    public class LookoutMetrics
    {
        public const string Alert = "AWS::LookoutMetrics::Alert";
        public const string AnomalyDetector = "AWS::LookoutMetrics::AnomalyDetector";
    }
    public class LookoutVision
    {
        public const string Project = "AWS::LookoutVision::Project";
    }
    public class M2
    {
        public const string Application = "AWS::M2::Application";
        public const string Environment = "AWS::M2::Environment";
    }
    public class MSK
    {
        public const string BatchScramSecret = "AWS::MSK::BatchScramSecret";
        public const string Cluster = "AWS::MSK::Cluster";
        public const string ClusterPolicy = "AWS::MSK::ClusterPolicy";
        public const string Configuration = "AWS::MSK::Configuration";
        public const string Replicator = "AWS::MSK::Replicator";
        public const string ServerlessCluster = "AWS::MSK::ServerlessCluster";
        public const string VpcConnection = "AWS::MSK::VpcConnection";
    }
    public class MWAA
    {
        public const string Environment = "AWS::MWAA::Environment";
    }
    public class Macie
    {
        public const string AllowList = "AWS::Macie::AllowList";
        public const string CustomDataIdentifier = "AWS::Macie::CustomDataIdentifier";
        public const string FindingsFilter = "AWS::Macie::FindingsFilter";
        public const string Session = "AWS::Macie::Session";
    }
    public class ManagedBlockchain
    {
        public const string Accessor = "AWS::ManagedBlockchain::Accessor";
        public const string Member = "AWS::ManagedBlockchain::Member";
        public const string Node = "AWS::ManagedBlockchain::Node";
    }
    public class MediaConnect
    {
        public const string Bridge = "AWS::MediaConnect::Bridge";
        public const string BridgeOutput = "AWS::MediaConnect::BridgeOutput";
        public const string BridgeSource = "AWS::MediaConnect::BridgeSource";
        public const string Flow = "AWS::MediaConnect::Flow";
        public const string FlowEntitlement = "AWS::MediaConnect::FlowEntitlement";
        public const string FlowOutput = "AWS::MediaConnect::FlowOutput";
        public const string FlowSource = "AWS::MediaConnect::FlowSource";
        public const string FlowVpcInterface = "AWS::MediaConnect::FlowVpcInterface";
        public const string Gateway = "AWS::MediaConnect::Gateway";
    }
    public class MediaConvert
    {
        public const string JobTemplate = "AWS::MediaConvert::JobTemplate";
        public const string Preset = "AWS::MediaConvert::Preset";
        public const string Queue = "AWS::MediaConvert::Queue";
    }
    public class MediaLive
    {
        public const string Channel = "AWS::MediaLive::Channel";
        public const string ChannelPlacementGroup = "AWS::MediaLive::ChannelPlacementGroup";
        public const string CloudWatchAlarmTemplate = "AWS::MediaLive::CloudWatchAlarmTemplate";
        public const string CloudWatchAlarmTemplateGroup = "AWS::MediaLive::CloudWatchAlarmTemplateGroup";
        public const string Cluster = "AWS::MediaLive::Cluster";
        public const string EventBridgeRuleTemplate = "AWS::MediaLive::EventBridgeRuleTemplate";
        public const string EventBridgeRuleTemplateGroup = "AWS::MediaLive::EventBridgeRuleTemplateGroup";
        public const string Input = "AWS::MediaLive::Input";
        public const string InputSecurityGroup = "AWS::MediaLive::InputSecurityGroup";
        public const string Multiplex = "AWS::MediaLive::Multiplex";
        public const string Multiplexprogram = "AWS::MediaLive::Multiplexprogram";
        public const string Network = "AWS::MediaLive::Network";
        public const string SdiSource = "AWS::MediaLive::SdiSource";
        public const string SignalMap = "AWS::MediaLive::SignalMap";
    }
    public class MediaPackage
    {
        public const string Asset = "AWS::MediaPackage::Asset";
        public const string Channel = "AWS::MediaPackage::Channel";
        public const string OriginEndpoint = "AWS::MediaPackage::OriginEndpoint";
        public const string PackagingConfiguration = "AWS::MediaPackage::PackagingConfiguration";
        public const string PackagingGroup = "AWS::MediaPackage::PackagingGroup";
    }
    public class MediaPackageV2
    {
        public const string Channel = "AWS::MediaPackageV2::Channel";
        public const string ChannelGroup = "AWS::MediaPackageV2::ChannelGroup";
        public const string ChannelPolicy = "AWS::MediaPackageV2::ChannelPolicy";
        public const string OriginEndpoint = "AWS::MediaPackageV2::OriginEndpoint";
        public const string OriginEndpointPolicy = "AWS::MediaPackageV2::OriginEndpointPolicy";
    }
    public class MediaStore
    {
        public const string Container = "AWS::MediaStore::Container";
    }
    public class MediaTailor
    {
        public const string Channel = "AWS::MediaTailor::Channel";
        public const string ChannelPolicy = "AWS::MediaTailor::ChannelPolicy";
        public const string LiveSource = "AWS::MediaTailor::LiveSource";
        public const string PlaybackConfiguration = "AWS::MediaTailor::PlaybackConfiguration";
        public const string SourceLocation = "AWS::MediaTailor::SourceLocation";
        public const string VodSource = "AWS::MediaTailor::VodSource";
    }
    public class MemoryDB
    {
        public const string ACL = "AWS::MemoryDB::ACL";
        public const string Cluster = "AWS::MemoryDB::Cluster";
        public const string ParameterGroup = "AWS::MemoryDB::ParameterGroup";
        public const string SubnetGroup = "AWS::MemoryDB::SubnetGroup";
        public const string User = "AWS::MemoryDB::User";
    }
    public class Neptune
    {
        public const string DBCluster = "AWS::Neptune::DBCluster";
        public const string DBClusterParameterGroup = "AWS::Neptune::DBClusterParameterGroup";
        public const string DBInstance = "AWS::Neptune::DBInstance";
        public const string DBParameterGroup = "AWS::Neptune::DBParameterGroup";
        public const string DBSubnetGroup = "AWS::Neptune::DBSubnetGroup";
        public const string EventSubscription = "AWS::Neptune::EventSubscription";
    }
    public class NeptuneGraph
    {
        public const string Graph = "AWS::NeptuneGraph::Graph";
        public const string PrivateGraphEndpoint = "AWS::NeptuneGraph::PrivateGraphEndpoint";
    }
    public class NetworkFirewall
    {
        public const string Firewall = "AWS::NetworkFirewall::Firewall";
        public const string FirewallPolicy = "AWS::NetworkFirewall::FirewallPolicy";
        public const string LoggingConfiguration = "AWS::NetworkFirewall::LoggingConfiguration";
        public const string RuleGroup = "AWS::NetworkFirewall::RuleGroup";
        public const string TLSInspectionConfiguration = "AWS::NetworkFirewall::TLSInspectionConfiguration";
    }
    public class NetworkManager
    {
        public const string ConnectAttachment = "AWS::NetworkManager::ConnectAttachment";
        public const string ConnectPeer = "AWS::NetworkManager::ConnectPeer";
        public const string CoreNetwork = "AWS::NetworkManager::CoreNetwork";
        public const string CustomerGatewayAssociation = "AWS::NetworkManager::CustomerGatewayAssociation";
        public const string Device = "AWS::NetworkManager::Device";
        public const string GlobalNetwork = "AWS::NetworkManager::GlobalNetwork";
        public const string Link = "AWS::NetworkManager::Link";
        public const string LinkAssociation = "AWS::NetworkManager::LinkAssociation";
        public const string Site = "AWS::NetworkManager::Site";
        public const string SiteToSiteVpnAttachment = "AWS::NetworkManager::SiteToSiteVpnAttachment";
        public const string TransitGatewayPeering = "AWS::NetworkManager::TransitGatewayPeering";
        public const string TransitGatewayRegistration = "AWS::NetworkManager::TransitGatewayRegistration";
        public const string TransitGatewayRouteTableAttachment = "AWS::NetworkManager::TransitGatewayRouteTableAttachment";
        public const string VpcAttachment = "AWS::NetworkManager::VpcAttachment";
    }
    public class NimbleStudio
    {
        public const string LaunchProfile = "AWS::NimbleStudio::LaunchProfile";
        public const string StreamingImage = "AWS::NimbleStudio::StreamingImage";
        public const string Studio = "AWS::NimbleStudio::Studio";
        public const string StudioComponent = "AWS::NimbleStudio::StudioComponent";
    }
    public class OSIS
    {
        public const string Pipeline = "AWS::OSIS::Pipeline";
    }
    public class Oam
    {
        public const string Link = "AWS::Oam::Link";
        public const string Sink = "AWS::Oam::Sink";
    }
    public class Omics
    {
        public const string AnnotationStore = "AWS::Omics::AnnotationStore";
        public const string ReferenceStore = "AWS::Omics::ReferenceStore";
        public const string RunGroup = "AWS::Omics::RunGroup";
        public const string SequenceStore = "AWS::Omics::SequenceStore";
        public const string VariantStore = "AWS::Omics::VariantStore";
        public const string Workflow = "AWS::Omics::Workflow";
    }
    public class OpenSearchServerless
    {
        public const string AccessPolicy = "AWS::OpenSearchServerless::AccessPolicy";
        public const string Collection = "AWS::OpenSearchServerless::Collection";
        public const string LifecyclePolicy = "AWS::OpenSearchServerless::LifecyclePolicy";
        public const string SecurityConfig = "AWS::OpenSearchServerless::SecurityConfig";
        public const string SecurityPolicy = "AWS::OpenSearchServerless::SecurityPolicy";
        public const string VpcEndpoint = "AWS::OpenSearchServerless::VpcEndpoint";
    }
    public class OpenSearchService
    {
        public const string Domain = "AWS::OpenSearchService::Domain";
    }
    public class OpsWorks
    {
        public const string App = "AWS::OpsWorks::App";
        public const string ElasticLoadBalancerAttachment = "AWS::OpsWorks::ElasticLoadBalancerAttachment";
        public const string Instance = "AWS::OpsWorks::Instance";
        public const string Layer = "AWS::OpsWorks::Layer";
        public const string Stack = "AWS::OpsWorks::Stack";
        public const string UserProfile = "AWS::OpsWorks::UserProfile";
        public const string Volume = "AWS::OpsWorks::Volume";
    }
    public class OpsWorksCM
    {
        public const string Server = "AWS::OpsWorksCM::Server";
    }
    public class Organizations
    {
        public const string Account = "AWS::Organizations::Account";
        public const string Organization = "AWS::Organizations::Organization";
        public const string OrganizationalUnit = "AWS::Organizations::OrganizationalUnit";
        public const string Policy = "AWS::Organizations::Policy";
        public const string ResourcePolicy = "AWS::Organizations::ResourcePolicy";
    }
    public class PCAConnectorAD
    {
        public const string Connector = "AWS::PCAConnectorAD::Connector";
        public const string DirectoryRegistration = "AWS::PCAConnectorAD::DirectoryRegistration";
        public const string ServicePrincipalName = "AWS::PCAConnectorAD::ServicePrincipalName";
        public const string Template = "AWS::PCAConnectorAD::Template";
        public const string TemplateGroupAccessControlEntry = "AWS::PCAConnectorAD::TemplateGroupAccessControlEntry";
    }
    public class PCAConnectorSCEP
    {
        public const string Challenge = "AWS::PCAConnectorSCEP::Challenge";
        public const string Connector = "AWS::PCAConnectorSCEP::Connector";
    }
    public class Panorama
    {
        public const string ApplicationInstance = "AWS::Panorama::ApplicationInstance";
        public const string Package = "AWS::Panorama::Package";
        public const string PackageVersion = "AWS::Panorama::PackageVersion";
    }
    public class PaymentCryptography
    {
        public const string Alias = "AWS::PaymentCryptography::Alias";
        public const string Key = "AWS::PaymentCryptography::Key";
    }
    public class Personalize
    {
        public const string Dataset = "AWS::Personalize::Dataset";
        public const string DatasetGroup = "AWS::Personalize::DatasetGroup";
        public const string Schema = "AWS::Personalize::Schema";
        public const string Solution = "AWS::Personalize::Solution";
    }
    public class Pinpoint
    {
        public const string ADMChannel = "AWS::Pinpoint::ADMChannel";
        public const string APNSChannel = "AWS::Pinpoint::APNSChannel";
        public const string APNSSandboxChannel = "AWS::Pinpoint::APNSSandboxChannel";
        public const string APNSVoipChannel = "AWS::Pinpoint::APNSVoipChannel";
        public const string APNSVoipSandboxChannel = "AWS::Pinpoint::APNSVoipSandboxChannel";
        public const string App = "AWS::Pinpoint::App";
        public const string ApplicationSettings = "AWS::Pinpoint::ApplicationSettings";
        public const string BaiduChannel = "AWS::Pinpoint::BaiduChannel";
        public const string Campaign = "AWS::Pinpoint::Campaign";
        public const string EmailChannel = "AWS::Pinpoint::EmailChannel";
        public const string EmailTemplate = "AWS::Pinpoint::EmailTemplate";
        public const string EventStream = "AWS::Pinpoint::EventStream";
        public const string GCMChannel = "AWS::Pinpoint::GCMChannel";
        public const string InAppTemplate = "AWS::Pinpoint::InAppTemplate";
        public const string PushTemplate = "AWS::Pinpoint::PushTemplate";
        public const string SMSChannel = "AWS::Pinpoint::SMSChannel";
        public const string Segment = "AWS::Pinpoint::Segment";
        public const string SmsTemplate = "AWS::Pinpoint::SmsTemplate";
        public const string VoiceChannel = "AWS::Pinpoint::VoiceChannel";
    }
    public class PinpointEmail
    {
        public const string ConfigurationSet = "AWS::PinpointEmail::ConfigurationSet";
        public const string ConfigurationSetEventDestination = "AWS::PinpointEmail::ConfigurationSetEventDestination";
        public const string DedicatedIpPool = "AWS::PinpointEmail::DedicatedIpPool";
        public const string Identity = "AWS::PinpointEmail::Identity";
    }
    public class Pipes
    {
        public const string Pipe = "AWS::Pipes::Pipe";
    }
    public class Proton
    {
        public const string EnvironmentAccountConnection = "AWS::Proton::EnvironmentAccountConnection";
        public const string EnvironmentTemplate = "AWS::Proton::EnvironmentTemplate";
        public const string ServiceTemplate = "AWS::Proton::ServiceTemplate";
    }
    public class QBusiness
    {
        public const string Application = "AWS::QBusiness::Application";
        public const string DataSource = "AWS::QBusiness::DataSource";
        public const string Index = "AWS::QBusiness::Index";
        public const string Plugin = "AWS::QBusiness::Plugin";
        public const string Retriever = "AWS::QBusiness::Retriever";
        public const string WebExperience = "AWS::QBusiness::WebExperience";
    }
    public class QLDB
    {
        public const string Ledger = "AWS::QLDB::Ledger";
        public const string Stream = "AWS::QLDB::Stream";
    }
    public class QuickSight
    {
        public const string Analysis = "AWS::QuickSight::Analysis";
        public const string Dashboard = "AWS::QuickSight::Dashboard";
        public const string DataSet = "AWS::QuickSight::DataSet";
        public const string DataSource = "AWS::QuickSight::DataSource";
        public const string Folder = "AWS::QuickSight::Folder";
        public const string RefreshSchedule = "AWS::QuickSight::RefreshSchedule";
        public const string Template = "AWS::QuickSight::Template";
        public const string Theme = "AWS::QuickSight::Theme";
        public const string Topic = "AWS::QuickSight::Topic";
        public const string VPCConnection = "AWS::QuickSight::VPCConnection";
    }
    public class RAM
    {
        public const string Permission = "AWS::RAM::Permission";
        public const string ResourceShare = "AWS::RAM::ResourceShare";
    }
    public class RDS
    {
        public const string CustomDBEngineVersion = "AWS::RDS::CustomDBEngineVersion";
        public const string DBCluster = "AWS::RDS::DBCluster";
        public const string DBClusterParameterGroup = "AWS::RDS::DBClusterParameterGroup";
        public const string DBInstance = "AWS::RDS::DBInstance";
        public const string DBParameterGroup = "AWS::RDS::DBParameterGroup";
        public const string DBProxy = "AWS::RDS::DBProxy";
        public const string DBProxyEndpoint = "AWS::RDS::DBProxyEndpoint";
        public const string DBProxyTargetGroup = "AWS::RDS::DBProxyTargetGroup";
        public const string DBSecurityGroup = "AWS::RDS::DBSecurityGroup";
        public const string DBSecurityGroupIngress = "AWS::RDS::DBSecurityGroupIngress";
        public const string DBSubnetGroup = "AWS::RDS::DBSubnetGroup";
        public const string EventSubscription = "AWS::RDS::EventSubscription";
        public const string GlobalCluster = "AWS::RDS::GlobalCluster";
        public const string Integration = "AWS::RDS::Integration";
        public const string OptionGroup = "AWS::RDS::OptionGroup";
    }
    public class RUM
    {
        public const string AppMonitor = "AWS::RUM::AppMonitor";
    }
    public class Redshift
    {
        public const string Cluster = "AWS::Redshift::Cluster";
        public const string ClusterParameterGroup = "AWS::Redshift::ClusterParameterGroup";
        public const string ClusterSecurityGroup = "AWS::Redshift::ClusterSecurityGroup";
        public const string ClusterSecurityGroupIngress = "AWS::Redshift::ClusterSecurityGroupIngress";
        public const string ClusterSubnetGroup = "AWS::Redshift::ClusterSubnetGroup";
        public const string EndpointAccess = "AWS::Redshift::EndpointAccess";
        public const string EndpointAuthorization = "AWS::Redshift::EndpointAuthorization";
        public const string EventSubscription = "AWS::Redshift::EventSubscription";
        public const string ScheduledAction = "AWS::Redshift::ScheduledAction";
    }
    public class RedshiftServerless
    {
        public const string Namespace = "AWS::RedshiftServerless::Namespace";
        public const string Workgroup = "AWS::RedshiftServerless::Workgroup";
    }
    public class RefactorSpaces
    {
        public const string Application = "AWS::RefactorSpaces::Application";
        public const string Environment = "AWS::RefactorSpaces::Environment";
        public const string Route = "AWS::RefactorSpaces::Route";
        public const string Service = "AWS::RefactorSpaces::Service";
    }
    public class Rekognition
    {
        public const string Collection = "AWS::Rekognition::Collection";
        public const string Project = "AWS::Rekognition::Project";
        public const string StreamProcessor = "AWS::Rekognition::StreamProcessor";
    }
    public class ResilienceHub
    {
        public const string App = "AWS::ResilienceHub::App";
        public const string ResiliencyPolicy = "AWS::ResilienceHub::ResiliencyPolicy";
    }
    public class ResourceExplorer2
    {
        public const string DefaultViewAssociation = "AWS::ResourceExplorer2::DefaultViewAssociation";
        public const string Index = "AWS::ResourceExplorer2::Index";
        public const string View = "AWS::ResourceExplorer2::View";
    }
    public class ResourceGroups
    {
        public const string Group = "AWS::ResourceGroups::Group";
    }
    public class RoboMaker
    {
        public const string Fleet = "AWS::RoboMaker::Fleet";
        public const string Robot = "AWS::RoboMaker::Robot";
        public const string RobotApplication = "AWS::RoboMaker::RobotApplication";
        public const string RobotApplicationVersion = "AWS::RoboMaker::RobotApplicationVersion";
        public const string SimulationApplication = "AWS::RoboMaker::SimulationApplication";
        public const string SimulationApplicationVersion = "AWS::RoboMaker::SimulationApplicationVersion";
    }
    public class RolesAnywhere
    {
        public const string CRL = "AWS::RolesAnywhere::CRL";
        public const string Profile = "AWS::RolesAnywhere::Profile";
        public const string TrustAnchor = "AWS::RolesAnywhere::TrustAnchor";
    }
    public class Route53
    {
        public const string CidrCollection = "AWS::Route53::CidrCollection";
        public const string DNSSEC = "AWS::Route53::DNSSEC";
        public const string HealthCheck = "AWS::Route53::HealthCheck";
        public const string HostedZone = "AWS::Route53::HostedZone";
        public const string KeySigningKey = "AWS::Route53::KeySigningKey";
        public const string RecordSet = "AWS::Route53::RecordSet";
        public const string RecordSetGroup = "AWS::Route53::RecordSetGroup";
    }
    public class Route53Profiles
    {
        public const string Profile = "AWS::Route53Profiles::Profile";
        public const string ProfileAssociation = "AWS::Route53Profiles::ProfileAssociation";
        public const string ProfileResourceAssociation = "AWS::Route53Profiles::ProfileResourceAssociation";
    }
    public class Route53RecoveryControl
    {
        public const string Cluster = "AWS::Route53RecoveryControl::Cluster";
        public const string ControlPanel = "AWS::Route53RecoveryControl::ControlPanel";
        public const string RoutingControl = "AWS::Route53RecoveryControl::RoutingControl";
        public const string SafetyRule = "AWS::Route53RecoveryControl::SafetyRule";
    }
    public class Route53RecoveryReadiness
    {
        public const string Cell = "AWS::Route53RecoveryReadiness::Cell";
        public const string ReadinessCheck = "AWS::Route53RecoveryReadiness::ReadinessCheck";
        public const string RecoveryGroup = "AWS::Route53RecoveryReadiness::RecoveryGroup";
        public const string ResourceSet = "AWS::Route53RecoveryReadiness::ResourceSet";
    }
    public class Route53Resolver
    {
        public const string FirewallDomainList = "AWS::Route53Resolver::FirewallDomainList";
        public const string FirewallRuleGroup = "AWS::Route53Resolver::FirewallRuleGroup";
        public const string FirewallRuleGroupAssociation = "AWS::Route53Resolver::FirewallRuleGroupAssociation";
        public const string OutpostResolver = "AWS::Route53Resolver::OutpostResolver";
        public const string ResolverConfig = "AWS::Route53Resolver::ResolverConfig";
        public const string ResolverDNSSECConfig = "AWS::Route53Resolver::ResolverDNSSECConfig";
        public const string ResolverEndpoint = "AWS::Route53Resolver::ResolverEndpoint";
        public const string ResolverQueryLoggingConfig = "AWS::Route53Resolver::ResolverQueryLoggingConfig";
        public const string ResolverQueryLoggingConfigAssociation = "AWS::Route53Resolver::ResolverQueryLoggingConfigAssociation";
        public const string ResolverRule = "AWS::Route53Resolver::ResolverRule";
        public const string ResolverRuleAssociation = "AWS::Route53Resolver::ResolverRuleAssociation";
    }
    public class S3
    {
        public const string AccessGrant = "AWS::S3::AccessGrant";
        public const string AccessGrantsInstance = "AWS::S3::AccessGrantsInstance";
        public const string AccessGrantsLocation = "AWS::S3::AccessGrantsLocation";
        public const string AccessPoint = "AWS::S3::AccessPoint";
        public const string Bucket = "AWS::S3::Bucket";
        public const string BucketPolicy = "AWS::S3::BucketPolicy";
        public const string MultiRegionAccessPoint = "AWS::S3::MultiRegionAccessPoint";
        public const string MultiRegionAccessPointPolicy = "AWS::S3::MultiRegionAccessPointPolicy";
        public const string StorageLens = "AWS::S3::StorageLens";
        public const string StorageLensGroup = "AWS::S3::StorageLensGroup";
    }
    public class S3Express
    {
        public const string BucketPolicy = "AWS::S3Express::BucketPolicy";
        public const string DirectoryBucket = "AWS::S3Express::DirectoryBucket";
    }
    public class S3ObjectLambda
    {
        public const string AccessPoint = "AWS::S3ObjectLambda::AccessPoint";
        public const string AccessPointPolicy = "AWS::S3ObjectLambda::AccessPointPolicy";
    }
    public class S3Outposts
    {
        public const string AccessPoint = "AWS::S3Outposts::AccessPoint";
        public const string Bucket = "AWS::S3Outposts::Bucket";
        public const string BucketPolicy = "AWS::S3Outposts::BucketPolicy";
        public const string Endpoint = "AWS::S3Outposts::Endpoint";
    }
    public class SDB
    {
        public const string Domain = "AWS::SDB::Domain";
    }
    public class SES
    {
        public const string ConfigurationSet = "AWS::SES::ConfigurationSet";
        public const string ConfigurationSetEventDestination = "AWS::SES::ConfigurationSetEventDestination";
        public const string ContactList = "AWS::SES::ContactList";
        public const string DedicatedIpPool = "AWS::SES::DedicatedIpPool";
        public const string EmailIdentity = "AWS::SES::EmailIdentity";
        public const string MailManagerAddonInstance = "AWS::SES::MailManagerAddonInstance";
        public const string MailManagerAddonSubscription = "AWS::SES::MailManagerAddonSubscription";
        public const string MailManagerArchive = "AWS::SES::MailManagerArchive";
        public const string MailManagerIngressPoint = "AWS::SES::MailManagerIngressPoint";
        public const string MailManagerRelay = "AWS::SES::MailManagerRelay";
        public const string MailManagerRuleSet = "AWS::SES::MailManagerRuleSet";
        public const string MailManagerTrafficPolicy = "AWS::SES::MailManagerTrafficPolicy";
        public const string ReceiptFilter = "AWS::SES::ReceiptFilter";
        public const string ReceiptRule = "AWS::SES::ReceiptRule";
        public const string ReceiptRuleSet = "AWS::SES::ReceiptRuleSet";
        public const string Template = "AWS::SES::Template";
        public const string VdmAttributes = "AWS::SES::VdmAttributes";
    }
    public class SNS
    {
        public const string Subscription = "AWS::SNS::Subscription";
        public const string Topic = "AWS::SNS::Topic";
        public const string TopicInlinePolicy = "AWS::SNS::TopicInlinePolicy";
        public const string TopicPolicy = "AWS::SNS::TopicPolicy";
    }
    public class SQS
    {
        public const string Queue = "AWS::SQS::Queue";
        public const string QueueInlinePolicy = "AWS::SQS::QueueInlinePolicy";
        public const string QueuePolicy = "AWS::SQS::QueuePolicy";
    }
    public class SSM
    {
        public const string Association = "AWS::SSM::Association";
        public const string Document = "AWS::SSM::Document";
        public const string MaintenanceWindow = "AWS::SSM::MaintenanceWindow";
        public const string MaintenanceWindowTarget = "AWS::SSM::MaintenanceWindowTarget";
        public const string MaintenanceWindowTask = "AWS::SSM::MaintenanceWindowTask";
        public const string Parameter = "AWS::SSM::Parameter";
        public const string PatchBaseline = "AWS::SSM::PatchBaseline";
        public const string ResourceDataSync = "AWS::SSM::ResourceDataSync";
        public const string ResourcePolicy = "AWS::SSM::ResourcePolicy";
    }
    public class SSMContacts
    {
        public const string Contact = "AWS::SSMContacts::Contact";
        public const string ContactChannel = "AWS::SSMContacts::ContactChannel";
        public const string Plan = "AWS::SSMContacts::Plan";
        public const string Rotation = "AWS::SSMContacts::Rotation";
    }
    public class SSMIncidents
    {
        public const string ReplicationSet = "AWS::SSMIncidents::ReplicationSet";
        public const string ResponsePlan = "AWS::SSMIncidents::ResponsePlan";
    }
    public class SSMQuickSetup
    {
        public const string ConfigurationManager = "AWS::SSMQuickSetup::ConfigurationManager";
    }
    public class SSO
    {
        public const string Application = "AWS::SSO::Application";
        public const string ApplicationAssignment = "AWS::SSO::ApplicationAssignment";
        public const string Assignment = "AWS::SSO::Assignment";
        public const string Instance = "AWS::SSO::Instance";
        public const string InstanceAccessControlAttributeConfiguration = "AWS::SSO::InstanceAccessControlAttributeConfiguration";
        public const string PermissionSet = "AWS::SSO::PermissionSet";
    }
    public class SageMaker
    {
        public const string App = "AWS::SageMaker::App";
        public const string AppImageConfig = "AWS::SageMaker::AppImageConfig";
        public const string Cluster = "AWS::SageMaker::Cluster";
        public const string CodeRepository = "AWS::SageMaker::CodeRepository";
        public const string DataQualityJobDefinition = "AWS::SageMaker::DataQualityJobDefinition";
        public const string Device = "AWS::SageMaker::Device";
        public const string DeviceFleet = "AWS::SageMaker::DeviceFleet";
        public const string Domain = "AWS::SageMaker::Domain";
        public const string Endpoint = "AWS::SageMaker::Endpoint";
        public const string EndpointConfig = "AWS::SageMaker::EndpointConfig";
        public const string FeatureGroup = "AWS::SageMaker::FeatureGroup";
        public const string Image = "AWS::SageMaker::Image";
        public const string ImageVersion = "AWS::SageMaker::ImageVersion";
        public const string InferenceComponent = "AWS::SageMaker::InferenceComponent";
        public const string InferenceExperiment = "AWS::SageMaker::InferenceExperiment";
        public const string MlflowTrackingServer = "AWS::SageMaker::MlflowTrackingServer";
        public const string Model = "AWS::SageMaker::Model";
        public const string ModelBiasJobDefinition = "AWS::SageMaker::ModelBiasJobDefinition";
        public const string ModelCard = "AWS::SageMaker::ModelCard";
        public const string ModelExplainabilityJobDefinition = "AWS::SageMaker::ModelExplainabilityJobDefinition";
        public const string ModelPackage = "AWS::SageMaker::ModelPackage";
        public const string ModelPackageGroup = "AWS::SageMaker::ModelPackageGroup";
        public const string ModelQualityJobDefinition = "AWS::SageMaker::ModelQualityJobDefinition";
        public const string MonitoringSchedule = "AWS::SageMaker::MonitoringSchedule";
        public const string NotebookInstance = "AWS::SageMaker::NotebookInstance";
        public const string NotebookInstanceLifecycleConfig = "AWS::SageMaker::NotebookInstanceLifecycleConfig";
        public const string Pipeline = "AWS::SageMaker::Pipeline";
        public const string Project = "AWS::SageMaker::Project";
        public const string Space = "AWS::SageMaker::Space";
        public const string StudioLifecycleConfig = "AWS::SageMaker::StudioLifecycleConfig";
        public const string UserProfile = "AWS::SageMaker::UserProfile";
        public const string Workteam = "AWS::SageMaker::Workteam";
    }
    public class Scheduler
    {
        public const string Schedule = "AWS::Scheduler::Schedule";
        public const string ScheduleGroup = "AWS::Scheduler::ScheduleGroup";
    }
    public class SecretsManager
    {
        public const string ResourcePolicy = "AWS::SecretsManager::ResourcePolicy";
        public const string RotationSchedule = "AWS::SecretsManager::RotationSchedule";
        public const string Secret = "AWS::SecretsManager::Secret";
        public const string SecretTargetAttachment = "AWS::SecretsManager::SecretTargetAttachment";
    }
    public class SecurityHub
    {
        public const string AutomationRule = "AWS::SecurityHub::AutomationRule";
        public const string ConfigurationPolicy = "AWS::SecurityHub::ConfigurationPolicy";
        public const string DelegatedAdmin = "AWS::SecurityHub::DelegatedAdmin";
        public const string FindingAggregator = "AWS::SecurityHub::FindingAggregator";
        public const string Hub = "AWS::SecurityHub::Hub";
        public const string Insight = "AWS::SecurityHub::Insight";
        public const string OrganizationConfiguration = "AWS::SecurityHub::OrganizationConfiguration";
        public const string PolicyAssociation = "AWS::SecurityHub::PolicyAssociation";
        public const string ProductSubscription = "AWS::SecurityHub::ProductSubscription";
        public const string SecurityControl = "AWS::SecurityHub::SecurityControl";
        public const string Standard = "AWS::SecurityHub::Standard";
    }
    public class SecurityLake
    {
        public const string AwsLogSource = "AWS::SecurityLake::AwsLogSource";
        public const string DataLake = "AWS::SecurityLake::DataLake";
        public const string Subscriber = "AWS::SecurityLake::Subscriber";
        public const string SubscriberNotification = "AWS::SecurityLake::SubscriberNotification";
    }
    public class ServiceCatalog
    {
        public const string AcceptedPortfolioShare = "AWS::ServiceCatalog::AcceptedPortfolioShare";
        public const string CloudFormationProduct = "AWS::ServiceCatalog::CloudFormationProduct";
        public const string CloudFormationProvisionedProduct = "AWS::ServiceCatalog::CloudFormationProvisionedProduct";
        public const string LaunchNotificationConstraint = "AWS::ServiceCatalog::LaunchNotificationConstraint";
        public const string LaunchRoleConstraint = "AWS::ServiceCatalog::LaunchRoleConstraint";
        public const string LaunchTemplateConstraint = "AWS::ServiceCatalog::LaunchTemplateConstraint";
        public const string Portfolio = "AWS::ServiceCatalog::Portfolio";
        public const string PortfolioPrincipalAssociation = "AWS::ServiceCatalog::PortfolioPrincipalAssociation";
        public const string PortfolioProductAssociation = "AWS::ServiceCatalog::PortfolioProductAssociation";
        public const string PortfolioShare = "AWS::ServiceCatalog::PortfolioShare";
        public const string ResourceUpdateConstraint = "AWS::ServiceCatalog::ResourceUpdateConstraint";
        public const string ServiceAction = "AWS::ServiceCatalog::ServiceAction";
        public const string ServiceActionAssociation = "AWS::ServiceCatalog::ServiceActionAssociation";
        public const string StackSetConstraint = "AWS::ServiceCatalog::StackSetConstraint";
        public const string TagOption = "AWS::ServiceCatalog::TagOption";
        public const string TagOptionAssociation = "AWS::ServiceCatalog::TagOptionAssociation";
    }
    public class ServiceCatalogAppRegistry
    {
        public const string Application = "AWS::ServiceCatalogAppRegistry::Application";
        public const string AttributeGroup = "AWS::ServiceCatalogAppRegistry::AttributeGroup";
        public const string AttributeGroupAssociation = "AWS::ServiceCatalogAppRegistry::AttributeGroupAssociation";
        public const string ResourceAssociation = "AWS::ServiceCatalogAppRegistry::ResourceAssociation";
    }
    public class ServiceDiscovery
    {
        public const string HttpNamespace = "AWS::ServiceDiscovery::HttpNamespace";
        public const string Instance = "AWS::ServiceDiscovery::Instance";
        public const string PrivateDnsNamespace = "AWS::ServiceDiscovery::PrivateDnsNamespace";
        public const string PublicDnsNamespace = "AWS::ServiceDiscovery::PublicDnsNamespace";
        public const string Service = "AWS::ServiceDiscovery::Service";
    }
    public class Shield
    {
        public const string DRTAccess = "AWS::Shield::DRTAccess";
        public const string ProactiveEngagement = "AWS::Shield::ProactiveEngagement";
        public const string Protection = "AWS::Shield::Protection";
        public const string ProtectionGroup = "AWS::Shield::ProtectionGroup";
    }
    public class Signer
    {
        public const string ProfilePermission = "AWS::Signer::ProfilePermission";
        public const string SigningProfile = "AWS::Signer::SigningProfile";
    }
    public class SimSpaceWeaver
    {
        public const string Simulation = "AWS::SimSpaceWeaver::Simulation";
    }
    public class StepFunctions
    {
        public const string Activity = "AWS::StepFunctions::Activity";
        public const string StateMachine = "AWS::StepFunctions::StateMachine";
        public const string StateMachineAlias = "AWS::StepFunctions::StateMachineAlias";
        public const string StateMachineVersion = "AWS::StepFunctions::StateMachineVersion";
    }
    public class SupportApp
    {
        public const string AccountAlias = "AWS::SupportApp::AccountAlias";
        public const string SlackChannelConfiguration = "AWS::SupportApp::SlackChannelConfiguration";
        public const string SlackWorkspaceConfiguration = "AWS::SupportApp::SlackWorkspaceConfiguration";
    }
    public class Synthetics
    {
        public const string Canary = "AWS::Synthetics::Canary";
        public const string Group = "AWS::Synthetics::Group";
    }
    public class SystemsManagerSAP
    {
        public const string Application = "AWS::SystemsManagerSAP::Application";
    }
    public class Timestream
    {
        public const string Database = "AWS::Timestream::Database";
        public const string InfluxDBInstance = "AWS::Timestream::InfluxDBInstance";
        public const string ScheduledQuery = "AWS::Timestream::ScheduledQuery";
        public const string Table = "AWS::Timestream::Table";
    }
    public class Transfer
    {
        public const string Agreement = "AWS::Transfer::Agreement";
        public const string Certificate = "AWS::Transfer::Certificate";
        public const string Connector = "AWS::Transfer::Connector";
        public const string Profile = "AWS::Transfer::Profile";
        public const string Server = "AWS::Transfer::Server";
        public const string User = "AWS::Transfer::User";
        public const string Workflow = "AWS::Transfer::Workflow";
    }
    public class VerifiedPermissions
    {
        public const string IdentitySource = "AWS::VerifiedPermissions::IdentitySource";
        public const string Policy = "AWS::VerifiedPermissions::Policy";
        public const string PolicyStore = "AWS::VerifiedPermissions::PolicyStore";
        public const string PolicyTemplate = "AWS::VerifiedPermissions::PolicyTemplate";
    }
    public class VoiceID
    {
        public const string Domain = "AWS::VoiceID::Domain";
    }
    public class VpcLattice
    {
        public const string AccessLogSubscription = "AWS::VpcLattice::AccessLogSubscription";
        public const string AuthPolicy = "AWS::VpcLattice::AuthPolicy";
        public const string Listener = "AWS::VpcLattice::Listener";
        public const string ResourcePolicy = "AWS::VpcLattice::ResourcePolicy";
        public const string Rule = "AWS::VpcLattice::Rule";
        public const string Service = "AWS::VpcLattice::Service";
        public const string ServiceNetwork = "AWS::VpcLattice::ServiceNetwork";
        public const string ServiceNetworkServiceAssociation = "AWS::VpcLattice::ServiceNetworkServiceAssociation";
        public const string ServiceNetworkVpcAssociation = "AWS::VpcLattice::ServiceNetworkVpcAssociation";
        public const string TargetGroup = "AWS::VpcLattice::TargetGroup";
    }
    public class WAF
    {
        public const string ByteMatchSet = "AWS::WAF::ByteMatchSet";
        public const string IPSet = "AWS::WAF::IPSet";
        public const string Rule = "AWS::WAF::Rule";
        public const string SizeConstraintSet = "AWS::WAF::SizeConstraintSet";
        public const string SqlInjectionMatchSet = "AWS::WAF::SqlInjectionMatchSet";
        public const string WebACL = "AWS::WAF::WebACL";
        public const string XssMatchSet = "AWS::WAF::XssMatchSet";
    }
    public class WAFRegional
    {
        public const string ByteMatchSet = "AWS::WAFRegional::ByteMatchSet";
        public const string GeoMatchSet = "AWS::WAFRegional::GeoMatchSet";
        public const string IPSet = "AWS::WAFRegional::IPSet";
        public const string RateBasedRule = "AWS::WAFRegional::RateBasedRule";
        public const string RegexPatternSet = "AWS::WAFRegional::RegexPatternSet";
        public const string Rule = "AWS::WAFRegional::Rule";
        public const string SizeConstraintSet = "AWS::WAFRegional::SizeConstraintSet";
        public const string SqlInjectionMatchSet = "AWS::WAFRegional::SqlInjectionMatchSet";
        public const string WebACL = "AWS::WAFRegional::WebACL";
        public const string WebACLAssociation = "AWS::WAFRegional::WebACLAssociation";
        public const string XssMatchSet = "AWS::WAFRegional::XssMatchSet";
    }
    public class WAFv2
    {
        public const string IPSet = "AWS::WAFv2::IPSet";
        public const string LoggingConfiguration = "AWS::WAFv2::LoggingConfiguration";
        public const string RegexPatternSet = "AWS::WAFv2::RegexPatternSet";
        public const string RuleGroup = "AWS::WAFv2::RuleGroup";
        public const string WebACL = "AWS::WAFv2::WebACL";
        public const string WebACLAssociation = "AWS::WAFv2::WebACLAssociation";
    }
    public class Wisdom
    {
        public const string Assistant = "AWS::Wisdom::Assistant";
        public const string AssistantAssociation = "AWS::Wisdom::AssistantAssociation";
        public const string KnowledgeBase = "AWS::Wisdom::KnowledgeBase";
    }
    public class WorkSpaces
    {
        public const string ConnectionAlias = "AWS::WorkSpaces::ConnectionAlias";
        public const string Workspace = "AWS::WorkSpaces::Workspace";
        public const string WorkspacesPool = "AWS::WorkSpaces::WorkspacesPool";
    }
    public class WorkSpacesThinClient
    {
        public const string Environment = "AWS::WorkSpacesThinClient::Environment";
    }
    public class WorkSpacesWeb
    {
        public const string BrowserSettings = "AWS::WorkSpacesWeb::BrowserSettings";
        public const string IdentityProvider = "AWS::WorkSpacesWeb::IdentityProvider";
        public const string IpAccessSettings = "AWS::WorkSpacesWeb::IpAccessSettings";
        public const string NetworkSettings = "AWS::WorkSpacesWeb::NetworkSettings";
        public const string Portal = "AWS::WorkSpacesWeb::Portal";
        public const string TrustStore = "AWS::WorkSpacesWeb::TrustStore";
        public const string UserAccessLoggingSettings = "AWS::WorkSpacesWeb::UserAccessLoggingSettings";
        public const string UserSettings = "AWS::WorkSpacesWeb::UserSettings";
    }
    public class XRay
    {
        public const string Group = "AWS::XRay::Group";
        public const string ResourcePolicy = "AWS::XRay::ResourcePolicy";
        public const string SamplingRule = "AWS::XRay::SamplingRule";
    }
}
public class Alexa
{
    public class ASK
    {
        public const string Skill = "Alexa::ASK::Skill";
    }
}
